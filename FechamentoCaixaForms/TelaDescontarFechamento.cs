using FechamentoCaixa.Entities;
using FechamentoCaixa.Service;
using FechamentoCaixa.ViewModels;
using FechamentoCaixa.Exceptions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FechamentoCaixaForms
{
    public partial class TelaDescontarFechamento : Form
    {
        public decimal ValorDescontarVale { get; private set; }
        public decimal DescontoExtra { get; private set; }

        private readonly MotoqueiroService _motoqueiroService;
        private int _motoqueiroId;

        private readonly List<ResumoFechamento> _resumo;
        private int _contadorResumo = 0;
        private int _tamanhoResumo => _resumo.Count - 1;
        public List<FechamentoFinalItem> fechamentoFinalItems = new List<FechamentoFinalItem>();



        public TelaDescontarFechamento(List<ResumoFechamento> resumo, MotoqueiroService motoqueiroService)
        {
            InitializeComponent();
            numericDescontoVale.Value = 0;
            numericDescontoExtra.Value = 0;
            AplicarSelectAll(this);
            btnConfirmar.Click += BtnConfirmar_Click;

            _motoqueiroService = motoqueiroService;
            _resumo = resumo;
            configuraMotoqueiroAtual();
        }
        private void AplicarSelectAll(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox txt)
                {
                    txt.Enter += (s, e) => txt.SelectAll();
                }

                if (control is NumericUpDown numeric)
                {
                    numeric.Enter += (s, e) =>
                    {
                        numeric.Select(0, numeric.Text.Length);
                    };
                }

                if (control.HasChildren)
                {
                    AplicarSelectAll(control);
                }
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if(_contadorResumo < _tamanhoResumo)
            {
                MessageBox.Show("Ainda existem motoqueiros em aberto..", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
                
        }
        private void btnProximoMotoqueiro_Click(object sender, EventArgs e)
        {
            try
            {
                if (_contadorResumo > _tamanhoResumo)
                {
                    MessageBox.Show("Não existem mais motoqueiros nesse fechamento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                decimal valorValeDescontado = numericDescontoVale.Value;
                decimal valorTotalDescontado = valorValeDescontado + numericDescontoExtra.Value;
                var motoqueiroVale = _motoqueiroService.ObterValeMotoqueiro(_motoqueiroId);

                //

                if (valorTotalDescontado > _resumo[_contadorResumo].TotalGeral)
                {
                    decimal valorRestanteVale = valorTotalDescontado - _resumo[_contadorResumo].TotalGeral;
                    if (MessageBox.Show($"O valor total a ser descontado de {valorTotalDescontado:C} é maior do que o valor final fechado pelo motoqueiro ({_resumo[_contadorResumo].TotalGeral:C}). Deseja descontar o valor feito pelo motoqueiro do vale e deixar {valorRestanteVale:C} de vale?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        _motoqueiroService.SetValeMotoqueiro(_motoqueiroId, valorRestanteVale);
                    }
                    else
                    {
                        return;
                    }
                }
                else 
                { 
                _motoqueiroService.RemoverValeMotoqueiro(_motoqueiroId, numericDescontoVale.Value);
                }
                FechamentoFinalItem item = new FechamentoFinalItem
                {
                    MotoqueiroId = _motoqueiroId,
                    Taxa5 = _resumo[_contadorResumo].Taxa5,
                    Taxa7 = _resumo[_contadorResumo].Taxa7,
                    Taxa10 = _resumo[_contadorResumo].Taxa10,
                    ValeDescontado = numericDescontoVale.Value,
                    DescontoExtra = numericDescontoExtra.Value,
                    TotalFixo = _resumo[_contadorResumo].TotalFixo,
                    TotalBruto = _resumo[_contadorResumo].TotalGeral,
                    TotalLiquido = _resumo[_contadorResumo].TotalGeral - valorTotalDescontado
                };
                fechamentoFinalItems.Add(item);
                _contadorResumo++;
                configuraMotoqueiroAtual();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void configuraMotoqueiroAtual()
        {
            numericDescontoVale.Value = 0;
            numericDescontoExtra.Value = 0;
            if (_contadorResumo > _tamanhoResumo)
            {
                MessageBox.Show("Não existem mais motoqueiros nesse fechamento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numericDescontoExtra.Value = 0;
                numericDescontoVale.Value = 0;

                numericDescontoVale.Enabled = false;
                numericDescontoExtra.Enabled = false;
                return;
            }
            if(_resumo.Count == 0)
            {
                MessageBox.Show("Não existem motoqueiros nesse fechamento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var resumoAtual = _resumo[_contadorResumo]; 
            _motoqueiroId = resumoAtual.MotoqueiroId;
            labelMotoqueiro.Text = $"Motoqueiro: {resumoAtual.Motoqueiro}";
            labelValeMotoqueiro.Text = $"Vale atual: {_motoqueiroService.ObterValeMotoqueiro(_motoqueiroId):C}";
            labelValorTotalFechado.Text = $"Valor Total Fechado: {resumoAtual.TotalGeral:C}";
            
        }


    }
}