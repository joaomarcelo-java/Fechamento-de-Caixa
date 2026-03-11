using FechamentoCaixa.Entities;
using FechamentoCaixa.ViewModel;
using FechamentoCaixa.ViewModels;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace FechamentoCaixa.DataBase
{
    public class GerenciadorDatabase : DbContext
    {
        #region DbSets

        public DbSet<Motoqueiro> Motoqueiros { get; set; }
        public DbSet<FechamentoDia> FechamentosDia { get; set; }
        public DbSet<FechamentoFinal> FechamentosFinais { get; set; }

        #endregion

        #region Configuração

        public GerenciadorDatabase()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=fechamento.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FechamentoDia>()
                .HasIndex(f => new { f.Data, f.MotoqueiroId })
                .IsUnique();

            modelBuilder.Entity<FechamentoFinal>()
                .Property(f => f.DataInicio)
                .HasConversion(d => d.ToString("yyyy-MM-dd"),
                               d => DateOnly.Parse(d))
                .HasColumnType("TEXT");

            modelBuilder.Entity<FechamentoFinal>()
                .Property(f => f.DataFinal)
                .HasConversion(d => d.ToString("yyyy-MM-dd"),
                               d => DateOnly.Parse(d))
                .HasColumnType("TEXT");

            modelBuilder.Entity<FechamentoDia>()
                .Property(f => f.Data)
                .HasConversion(d => d.ToString("yyyy-MM-dd"),
                               d => DateOnly.Parse(d))
                .HasColumnType("TEXT");
        }
        public bool CriarBackup()
            {
                try
                {
                    string pastaBackup = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                        "Fechamentos Finais",
                        "Backups"
                    );

                    if (!Directory.Exists(pastaBackup))
                        Directory.CreateDirectory(pastaBackup);

                    string caminhoBackup = Path.Combine(
                        pastaBackup,
                        $"backup_{DateTime.Now:yyyy-MM-dd}.db"
                    );

                    using (var connection = new SqliteConnection("Data Source=fechamento.db"))
                    {
                        connection.Open();

                        var command = connection.CreateCommand();
                        command.CommandText = $"VACUUM INTO '{caminhoBackup}'";
                        command.ExecuteNonQuery();
                    }

                    return true;
                }
                catch
                {
                    return false;
                }
            }

        #endregion

    #region ===================== MOTOQUEIROS =====================

    public bool AddMotoqueiro(Motoqueiro motoqueiro)
        {
            try
            {
                Motoqueiros.Add(motoqueiro);
                SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar motoqueiro: " + ex.Message);
                return false;
            }
        }

        public bool UpdateMotoqueiro(int idMotoqueiro, Motoqueiro novoMotoqueiro)
        {
            try
            {
                var existente = Motoqueiros.Find(idMotoqueiro);
                if (existente == null)
                    return false;

                existente.Nome = novoMotoqueiro.Nome;
                existente.Vale = novoMotoqueiro.Vale;
                existente.Extra = novoMotoqueiro.Extra;

                SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao editar motoqueiro: " + ex.Message);
                return false;
            }
        }

        public bool RemoveMotoqueiro(int idMotoqueiro)
        {
            try
            {
                var motoqueiro = Motoqueiros.Find(idMotoqueiro);
                if (motoqueiro == null)
                    return false;

                var fechamentos = FechamentosDia
                    .Where(f => f.MotoqueiroId == idMotoqueiro)
                    .ToList();

                if (fechamentos.Any())
                    FechamentosDia.RemoveRange(fechamentos);

                Motoqueiros.Remove(motoqueiro);
                SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao remover motoqueiro: " + ex.Message);
                return false;
            }
        }

        public List<Motoqueiro> GetAllMotoqueiros()
            => Motoqueiros.ToList();

        public List<Motoqueiro> SearchMotoqueiro(string nome)
            => Motoqueiros.Where(m => m.Nome.Contains(nome)).ToList();

        public Motoqueiro GetMotoqueiroById(int idMotoqueiro)
            => Motoqueiros.FirstOrDefault(m => m.Id == idMotoqueiro);

        public bool ExistsMotoqueiroByName(string nome)
            => Motoqueiros.Any(m => m.Nome == nome);

        #endregion

        #region ===================== VALES =====================

        public decimal GetVale(int idMotoqueiro)
            => Motoqueiros
                .Where(m => m.Id == idMotoqueiro)
                .Select(m => m.Vale)
                .FirstOrDefault();

        public void AddVale(int idMotoqueiro, decimal valor)
        {
            var motoqueiro = Motoqueiros.FirstOrDefault(m => m.Id == idMotoqueiro);
            motoqueiro.Vale += valor;
            SaveChanges();
        }

        public void RemoveVale(int idMotoqueiro, decimal valor)
        {
            var motoqueiro = Motoqueiros.FirstOrDefault(m => m.Id == idMotoqueiro);
            motoqueiro.Vale -= valor;
            SaveChanges();
        }

        public void SetVale(int idMotoqueiro, decimal valor)
        {
            var motoqueiro = Motoqueiros.FirstOrDefault(m => m.Id == idMotoqueiro);
            motoqueiro.Vale = valor;
            SaveChanges();
        }

        #endregion

        #region ===================== FECHAMENTO DIA =====================

        public bool AddFechamentoDia(FechamentoDia dia)
        {
            try
            {
                FechamentosDia.Add(dia);
                SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar fechamento: " + ex.Message);
                return false;
            }
        }

        public bool UpdateFechamentoDia(FechamentoDia dia, DateOnly data)
        {
            try
            {
                var existente = FechamentosDia
                    .FirstOrDefault(f => f.MotoqueiroId == dia.MotoqueiroId &&
                                         f.Data == data);

                existente.Entrega5 = dia.Entrega5;
                existente.Entrega7 = dia.Entrega7;
                existente.Entrega10 = dia.Entrega10;
                existente.ValorFixo = dia.ValorFixo;
                existente.Desconto = dia.Desconto;

                SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao editar fechamento: " + ex.Message);
                return false;
            }
        }

        public FechamentoDia GetFechamentoDia(int motoqueiroId, DateOnly data)
            => FechamentosDia
                .Include(f => f.Motoqueiro)
                .FirstOrDefault(f =>
                    f.MotoqueiroId == motoqueiroId &&
                    f.Data == data);

        public bool RemoveFechamentoDia(int motoqueiroId, DateOnly data)
        {
            var fechamento = FechamentosDia
                .FirstOrDefault(f =>
                    f.MotoqueiroId == motoqueiroId &&
                    f.Data == data);

            if (fechamento == null)
                return false;

            FechamentosDia.Remove(fechamento);
            SaveChanges();
            return true;
        }

        public bool ExistsFechamentoDia(int motoqueiroId, DateOnly data)
            => FechamentosDia.Any(f =>
                f.MotoqueiroId == motoqueiroId &&
                f.Data == data);

        #endregion

        #region ===================== RELATÓRIOS / RESUMOS =====================

        public List<FechamentoDiaViewModel> GetFechamentosByDate(DateOnly data)
            => FechamentosDia
                .Include(f => f.Motoqueiro)
                .Where(f => f.Data == data)
                .Select(f => new FechamentoDiaViewModel
                {
                    Motoqueiro = f.Motoqueiro.Nome,
                    Entrega5 = f.Entrega5,
                    Entrega7 = f.Entrega7,
                    Entrega10 = f.Entrega10,
                    ValorFixo = f.ValorFixo,
                    Descontos = f.Desconto,
                    Total = f.ValorDia
                })
                .ToList();

        public List<ResumoFechamento> GetResumoPeriodo(DateOnly dataInicio, DateOnly dataFinal)
            => FechamentosDia
                .Include(f => f.Motoqueiro)
                .Where(f => f.Data >= dataInicio && f.Data <= dataFinal)
                .AsEnumerable()
                .GroupBy(f => f.Motoqueiro.Nome)
                .Select(g => new ResumoFechamento
                {
                    MotoqueiroId = g.First().MotoqueiroId,
                    Motoqueiro = g.Key,
                    Taxa5 = g.Sum(x => x.Entrega5),
                    Taxa7 = g.Sum(x => x.Entrega7),
                    Taxa10 = g.Sum(x => x.Entrega10),
                    TotalFixo = g.Sum(x => x.ValorFixo),
                    TotalGeral = g.Sum(x => x.ValorDia)
                })
                .OrderBy(r => r.Motoqueiro)
                .ToList();

        #endregion

        #region ===================== FECHAMENTO FINAL =====================

        public FechamentoFinal GetFechamentoFinalById(int idFechamentoFinal)
            => FechamentosFinais
                .Include(f => f.Itens)
                .FirstOrDefault(f => f.Id == idFechamentoFinal);

        public List<FechamentoFinal> GetAllFechamentosFinais()
            => FechamentosFinais
                .Include(f => f.Itens)
                .ToList();

        public bool ExistsFechamentoFinalInPeriod(DateOnly inicio, DateOnly final)
            => FechamentosFinais.Any(f =>
                inicio <= f.DataFinal &&
                final >= f.DataInicio);

        public bool IsDateInsideFechamentoFinal(DateOnly data)
            => FechamentosFinais.Any(f =>
                data >= f.DataInicio &&
                data <= f.DataFinal);

        public bool AddFechamentoFinal(FechamentoFinal fechamento)
        {
            try
            {
                FechamentosFinais.Add(fechamento);
                SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar fechamento final: " + ex.Message);
                return false;
            }
        }

        public bool AddFechamentoFinalItem(FechamentoFinalItem item)
        {
            try
            {
                var fechamento = FechamentosFinais.Find(item.FechamentoFinalId);
                if (fechamento == null)
                    return false;

                fechamento.Itens.Add(item);
                SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir item no fechamento final: " + ex.Message);
                return false;
            }
        }

            public bool DeleteFechamentoFinal(int idFechamentoFinal)
        {
            try
            {
                var fechamento = FechamentosFinais
                    .Include(f => f.Itens)
                    .FirstOrDefault(f => f.Id == idFechamentoFinal);

                if (fechamento == null)
                    return false;

                if (fechamento.Itens != null && fechamento.Itens.Any())
                {
                    RemoveRange(fechamento.Itens);
                }
                FechamentosFinais.Remove(fechamento);

                SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao remover fechamento final: " + ex.Message);
                return false;
            }
        }
        

        #endregion
        #region ===================== ENTREGAS =====================
        public int TotalEntregas5Motoqueiro(int idMotoqueiro)
        {
            return FechamentosDia
                .Where(f => f.MotoqueiroId == idMotoqueiro)
                .Sum(f => f.Entrega5);
        }
        public int TotalEntregas7Motoqueiro(int idMotoqueiro)
        {
            return FechamentosDia
                .Where(f => f.MotoqueiroId == idMotoqueiro)
                .Sum(f => f.Entrega7);
        }
        public int TotalEntregas10Motoqueiro(int idMotoqueiro)
        {
            return FechamentosDia
                .Where(f => f.MotoqueiroId == idMotoqueiro)
                .Sum(f => f.Entrega10);
        }

        public decimal TotalFixoGanho(int idMotoqueiro)
        {
            return (decimal)FechamentosDia
                    .Where(f => f.MotoqueiroId == idMotoqueiro)
                    .Sum(f => (double)f.ValorFixo);
        }
        #endregion
    }
}