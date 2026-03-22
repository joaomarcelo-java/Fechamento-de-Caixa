using FechamentoCaixa.DataBase;
using FechamentoCaixa.Entities;
using FechamentoCaixa.Exceptions;
using FechamentoCaixa.ViewModels;
using System.Text;

namespace FechamentoCaixa.Service
{
    public class FechamentoFinalService
    {
        private readonly GerenciadorDatabase _db;
        private readonly MotoqueiroService _motoqueiroService;
        private readonly ValesService _valesService;

        public FechamentoFinalService(GerenciadorDatabase db)
        {
            _db = db;
            _motoqueiroService = new MotoqueiroService(_db);
            _valesService = new ValesService(_db);
        }

        // =====================================================
        // RESUMO PERÍODO
        // =====================================================

        public List<ResumoFechamento> ObterFechamentosPeriodo(DateOnly inicio, DateOnly final)
        {
            if (inicio > final)
                throw new DataInicioMaiorException();

            var resumo = _db.GetResumoPeriodo(inicio, final);

            if (resumo == null || resumo.Count == 0)
                throw new ResumoVazioException();

            return resumo;
        }

        // =====================================================
        // SALVAR FECHAMENTO FINAL
        // =====================================================

        public void SalvarFechamentoFinal(DateOnly dataInicio, DateOnly dataFinal, List<FechamentoFinalItem> itens)
        {
            if (itens == null || itens.Count == 0)
                throw new Exception("Nenhum item para salvar.");

            var fechamento = new FechamentoFinal
            {
                DataInicio = dataInicio,
                DataFinal = dataFinal,
                Itens = itens
            };

            _db.AddFechamentoFinal(fechamento);
        }

        // =====================================================
        // CRIAR ITEM
        // =====================================================

        public FechamentoFinalItem CriarItemFechamentoFinal(
            ResumoFechamento resumo,
            decimal valeDescontado,
            decimal descontoExtra)
        {
            if (descontoExtra < 0)
                throw new ValorDescontoNegativoException();

            if ((descontoExtra + valeDescontado) > resumo.TotalGeral)
                throw new ValorMaiorQueTotalException();

            _valesService.RemoveValeMotoqueiro(
                resumo.MotoqueiroId,
                valeDescontado);

            var totalLiquido =
                resumo.TotalGeral - valeDescontado - descontoExtra;

            return new FechamentoFinalItem
            {
                MotoqueiroId = resumo.MotoqueiroId,
                Taxa5 = resumo.Taxa5,
                Taxa7 = resumo.Taxa7,
                Taxa10 = resumo.Taxa10,
                TotalFixo = resumo.TotalFixo,
                TotalBruto = resumo.TotalGeral,
                ValeDescontado = valeDescontado,
                DescontoExtra = descontoExtra,
                TotalLiquido = totalLiquido
            };
        }

        // =====================================================
        // VALIDAÇÕES
        // =====================================================

        public void VerificarFechamentoExistente(DateOnly inicio, DateOnly final)
        {
            if (_db.ExistsFechamentoFinalInPeriod(inicio, final))
                throw new FechamentoFinalExistenteException();
        }

        // =====================================================
        // CONSULTAS
        // =====================================================

        public List<FechamentoFinal> ObterFechamentosFinais()
            => _db.GetAllFechamentosFinais();

        public FechamentoFinal ObterFechamentoFinalPorId(int id)
        {
            var fechamento = _db.GetFechamentoFinalById(id);

            if (fechamento == null)
                throw new Exception("Fechamento final não encontrado.");

            return fechamento;
        }

        // =====================================================
        // EXPORTAÇÃO
        // =====================================================

        public void ExportarFechamentoFinal(int fechamentoFinalId)
        {
            var fechamento = ObterFechamentoFinalPorId(fechamentoFinalId);

            if (fechamento.Itens == null || !fechamento.Itens.Any())
                throw new Exception("O fechamento não possui itens.");

            var pastaPath = ObterOuCriarPasta();
            var caminhoArquivo = GerarCaminhoArquivo(fechamento, pastaPath);
            var conteudo = MontarConteudoArquivo(fechamento);

            File.WriteAllText(caminhoArquivo, conteudo);
            System.Diagnostics.Process.Start("explorer.exe", pastaPath);
        }

        // =====================================================
        // MÉTODOS PRIVADOS AUXILIARES
        // =====================================================

        private string ObterOuCriarPasta()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pastaPath = Path.Combine(desktopPath, "Fechamentos Finais");

            if (!Directory.Exists(pastaPath))
                Directory.CreateDirectory(pastaPath);

            return pastaPath;
        }

        private string GerarCaminhoArquivo(FechamentoFinal fechamento, string pastaPath)
        {
            string nomeSeguro = string.Join("_",
                fechamento.Nome.Split(Path.GetInvalidFileNameChars()));

            string nomeArquivo =
                $"FechamentoFinal_{nomeSeguro}_{DateTime.Now:dd-MM-yyyy_HH-mm}.txt";

            return Path.Combine(pastaPath, nomeArquivo);
        }

        private string MontarConteudoArquivo(FechamentoFinal fechamento)
        {
            var sb = new StringBuilder();

            decimal valorTotal = fechamento.Itens.Sum(i => i.TotalLiquido);
            int totalEntregas = fechamento.Itens.Sum(i => i.Taxa5 + i.Taxa7 + i.Taxa10);

            sb.AppendLine("===== FECHAMENTO FINAL =====");
            sb.AppendLine($"ID: {fechamento.Id}");
            sb.AppendLine($"Data Inicial: {fechamento.DataInicio:dd/MM/yyyy}");
            sb.AppendLine($"Data Final: {fechamento.DataFinal:dd/MM/yyyy}");
            sb.AppendLine($"Valor Total: {valorTotal:C}");
            sb.AppendLine($"Total Entregas: {totalEntregas}");
            sb.AppendLine();
            sb.AppendLine("----- MOTOQUEIROS -----");

            foreach (var item in fechamento.Itens)
            {
                var motoqueiro = _motoqueiroService
                    .BuscarMotoqueiroId(item.MotoqueiroId);

                sb.AppendLine($"Nome: {motoqueiro?.Nome ?? "Não encontrado"}");
                sb.AppendLine($"Taxas de R$ 5,00: {item.Taxa5}");
                sb.AppendLine($"Taxas de R$ 7,00: {item.Taxa7}");
                sb.AppendLine($"Taxas de R$ 10,00: {item.Taxa10}");
                sb.AppendLine($"Total Fixo: {item.TotalFixo:C}");
                sb.AppendLine($"Total Bruto: {item.TotalBruto:C}");
                sb.AppendLine($"Vale Descontado: {item.ValeDescontado:C}");
                sb.AppendLine($"Desconto Extra: {item.DescontoExtra:C}");
                sb.AppendLine($"Total Líquido: {item.TotalLiquido:C}");
                sb.AppendLine("-----------------------------");
            }
            sb.AppendLine("----- FECHAMENTO SIMPLIFICADO -----");

            foreach(var item in fechamento.Itens)
            {
                var motoqueiro = _motoqueiroService.BuscarMotoqueiroId(item.MotoqueiroId);
                sb.AppendLine($"{motoqueiro?.Nome}: R$ {item.TotalLiquido:C}");
            }
            return sb.ToString();
        }

        // =====================================================
        // DELETAR FECHAMENTO FINAL
        // =====================================================
        public void DeletarFechamentoFinal(int fechamentoFinalId)
        {
            var fechamento = ObterFechamentoFinalPorId(fechamentoFinalId);
            if (fechamento == null)
                throw new Exception("Fechamento final não encontrado.");
            _db.DeleteFechamentoFinal(fechamentoFinalId);
        }
    } 
}