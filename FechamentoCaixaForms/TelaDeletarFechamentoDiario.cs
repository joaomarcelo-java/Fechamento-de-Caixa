using FechamentoCaixa.Entities;
using FechamentoCaixa.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FechamentoCaixaForms
{
    public partial class TelaDeletarFechamentoDiario : Form
    {
        private readonly MotoqueiroService _motoqueiroService;
        private readonly FechamentoDiaService _fechamentoDiaService;
        public TelaDeletarFechamentoDiario(MotoqueiroService motoqueiroService, FechamentoDiaService fechamentoDiaService)
        {
            _motoqueiroService = motoqueiroService;
            _fechamentoDiaService = fechamentoDiaService;
            InitializeComponent();
            CarregarMotoqueiros();
            AtualizarDados();
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEscolherMotoqueiro.SelectedItem is not Motoqueiro motoqueiroSelecionado)
                {
                    throw new InvalidOperationException("Nenhum motoqueiro foi selecionado.");
                }
                _fechamentoDiaService.DeletarFechamentoDiaMotoqueiro(motoqueiroSelecionado.Id, DateOnly.FromDateTime(dateTimePicker1.Value));
                MessageBox.Show("Fechamento diário deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBoxEscolherMotoqueiro_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarDados();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            AtualizarDados();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CarregarMotoqueiros()
        {
            var motoqueiros = _motoqueiroService.ListarMotoqueiros();
            comboBoxEscolherMotoqueiro.DataSource = motoqueiros;
            comboBoxEscolherMotoqueiro.DisplayMember = "Nome";
            comboBoxEscolherMotoqueiro.ValueMember = "Id";
            comboBoxEscolherMotoqueiro.SelectedIndex = 0;
        }
        private void AtualizarDados()
        {
            if (comboBoxEscolherMotoqueiro.SelectedItem is not Motoqueiro motoqueiroSelecionado)
            {
                throw new InvalidOperationException("Nenhum motoqueiro foi selecionado.");
            }

            var fechamento = _fechamentoDiaService.ObterFechamentoDiaMotoqueiro(motoqueiroSelecionado.Id, DateOnly.FromDateTime(dateTimePicker1.Value));
            if (fechamento != null)
            {
                labelEntrega5.Text = $"Entregas R$ 5,00: {fechamento.Entrega5}";
                labelEntrega7.Text = $"Entregas R$ 7,00: {fechamento.Entrega7}";
                labelEntrega10.Text = $"Entregas R$ 10,00: {fechamento.Entrega10}";
                labelValorFixo.Text = $"Valor Fixo: {FormatarMoeda(fechamento.ValorFixo)}";
                labelDesconto.Text = $"Descontos: {FormatarMoeda(fechamento.Desconto)}";
                labelValorTotal.Text = $"Valor Total: {FormatarMoeda(fechamento.CalcularValorDia())}";
            }
            else
            {
                labelEntrega5.Text = $"Entregas R$ 5,00: 0";
                labelEntrega7.Text = $"Entregas R$ 7,00: 0";
                labelEntrega10.Text = $"Entregas R$ 10,00: 0";
                labelValorFixo.Text = $"Valor Fixo: R$ 0,00";
                labelDesconto.Text = $"Descontos: R$ 0,00";
                labelValorTotal.Text = $"Valor Total: R$ 0,00";
            }
        }
        private string FormatarMoeda(decimal? valor)
        {
            return (valor ?? 0).ToString("C");
        }

        private void TelaDeletarFechamentoDiario_Load(object sender, EventArgs e)
        {

        }
    }
}
