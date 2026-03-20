using FechamentoCaixa.Entities;
using FechamentoCaixa.Service;
using FechamentoCaixa.ViewModels;
using FechamentoCaixa.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FechamentoCaixaForms
{
    public partial class TelaDescontarFechamento : Form
    {
        public decimal ValorDescontarVale { get; private set; }
        public decimal DescontoExtra { get; private set; }
        public List<FechamentoFinalItem> fechamentoFinalItems { get; } = new List<FechamentoFinalItem>();

        private readonly MotoqueiroService _motoqueiroService;
        private readonly List<ResumoFechamento> _resumo;

        private int _motoqueiroId;
        private int _contadorResumo = 0;

        private int _tamanhoResumo => _resumo.Count - 1;
        private bool TodosProcessados => _contadorResumo > _tamanhoResumo;

        public TelaDescontarFechamento(List<ResumoFechamento> resumo, MotoqueiroService motoqueiroService)
        {
            InitializeComponent();

            _motoqueiroService = motoqueiroService ?? throw new ArgumentNullException(nameof(motoqueiroService));
            _resumo = resumo ?? throw new ArgumentNullException(nameof(resumo));

            ResetarNumericos();
            AplicarSelectAll(this);
            configuraMotoqueiroAtual();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (this.DialogResult == DialogResult.OK)
                return;

            if (!TodosProcessados)
            {
                MessageBox.Show(
                    "Não é possível fechar. Ainda existem motoqueiros em aberto.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                e.Cancel = true;
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!TodosProcessados)
            {
                MessageBox.Show(
                    "Ainda existem motoqueiros em aberto.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnProximoMotoqueiro_Click(object sender, EventArgs e)
        {
            if (TodosProcessados)
            {
                MessageBox.Show(
                    "Não existem mais motoqueiros nesse fechamento.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            try
            {
                ProcessarMotoqueiroAtual();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ProcessarMotoqueiroAtual()
        {
            var resumoAtual = _resumo[_contadorResumo];
            decimal valorVale = numericDescontoVale.Value;
            decimal valorExtra = numericDescontoExtra.Value;
            decimal valorTotalDescontado = valorVale + valorExtra;

            if (!TentarAplicarDesconto(resumoAtual, valorTotalDescontado, valorVale))
                return;

            var item = CriarFechamentoFinalItem(resumoAtual, valorVale, valorExtra, valorTotalDescontado);
            fechamentoFinalItems.Add(item);

            _contadorResumo++;
            configuraMotoqueiroAtual();
        }

        private bool TentarAplicarDesconto(ResumoFechamento resumoAtual, decimal valorTotalDescontado, decimal valorVale)
        {
            if (valorTotalDescontado <= resumoAtual.TotalGeral)
            {
                _motoqueiroService.RemoverValeMotoqueiro(_motoqueiroId, valorVale);
                return true;
            }

            decimal valorRestanteVale = valorTotalDescontado - resumoAtual.TotalGeral;
            string mensagem = $"O valor a descontar ({valorTotalDescontado:C}) é maior que o total fechado " +
                              $"({resumoAtual.TotalGeral:C}). Deseja descontar o valor do motoqueiro do vale " +
                              $"e manter {valorRestanteVale:C} de saldo restante no vale?";

            var resposta = MessageBox.Show(mensagem, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta == DialogResult.Yes)
            {
                _motoqueiroService.SetValeMotoqueiro(_motoqueiroId, valorRestanteVale);
                return true;
            }

            return false;
        }

        private FechamentoFinalItem CriarFechamentoFinalItem(
            ResumoFechamento resumo,
            decimal valorVale,
            decimal valorExtra,
            decimal valorTotalDescontado)
        {
            return new FechamentoFinalItem
            {
                MotoqueiroId = _motoqueiroId,
                Taxa5 = resumo.Taxa5,
                Taxa7 = resumo.Taxa7,
                Taxa10 = resumo.Taxa10,
                ValeDescontado = valorVale,
                DescontoExtra = valorExtra,
                TotalFixo = resumo.TotalFixo,
                TotalBruto = resumo.TotalGeral,
                TotalLiquido = resumo.TotalGeral - valorTotalDescontado
            };
        }

        private void configuraMotoqueiroAtual()
        {
            ResetarNumericos();

            if (_resumo.Count == 0)
            {
                MessageBox.Show(
                    "Não existem motoqueiros nesse fechamento.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            if (TodosProcessados)
            {
                MessageBox.Show(
                    "Não existem mais motoqueiros nesse fechamento.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                DesabilitarNumericos();
                return;
            }

            var resumoAtual = _resumo[_contadorResumo];
            _motoqueiroId = resumoAtual.MotoqueiroId;

            labelMotoqueiro.Text = $"Motoqueiro: {resumoAtual.Motoqueiro}";
            labelValeMotoqueiro.Text = $"Vale atual: {_motoqueiroService.ObterValeMotoqueiro(_motoqueiroId):C}";
            labelValorTotalFechado.Text = $"Valor Total Fechado: {resumoAtual.TotalGeral:C}";
        }

        private void ResetarNumericos()
        {
            numericDescontoVale.Value = 0;
            numericDescontoExtra.Value = 0;
        }

        private void DesabilitarNumericos()
        {
            numericDescontoVale.Enabled = false;
            numericDescontoExtra.Enabled = false;
        }

        private static void AplicarSelectAll(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox txt)
                    txt.Enter += (s, e) => txt.SelectAll();

                if (control is NumericUpDown numeric)
                    numeric.Enter += (s, e) => numeric.Select(0, numeric.Text.Length);

                if (control.HasChildren)
                    AplicarSelectAll(control);
            }
        }
    }
}