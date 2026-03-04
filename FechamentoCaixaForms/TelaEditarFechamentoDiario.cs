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
    public partial class TelaEditarFechamentoDiario : Form
    {
        private readonly MotoqueiroService _motoqueiroService;
        private readonly FechamentoDiaService _fechamentoDiaService;
        public TelaEditarFechamentoDiario(MotoqueiroService motoqueiroService, FechamentoDiaService fechamentoDiaService)
        {
            _motoqueiroService = motoqueiroService;
            _fechamentoDiaService = fechamentoDiaService;
            InitializeComponent();
            AplicarSelectAll(this);

            CarregarMotoqueiros();
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
        private void CarregarMotoqueiros()
        {
            var motoqueiros = _motoqueiroService.ListarMotoqueiros();
            comboBoxEscolherMotoqueiro.DataSource = motoqueiros;
            comboBoxEscolherMotoqueiro.DisplayMember = "Nome";
            comboBoxEscolherMotoqueiro.ValueMember = "Id";
            comboBoxEscolherMotoqueiro.SelectedIndex = 0;
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
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                FechamentoDia fechamento = new FechamentoDia
                {
                    MotoqueiroId = (int)comboBoxEscolherMotoqueiro.SelectedValue,
                    Data = DateOnly.FromDateTime(dateTimePicker1.Value),
                    Entrega5 = (int)numericUpDownEntrega5.Value,
                    Entrega7 = (int)numericUpDownEntrega7.Value,
                    Entrega10 = (int)numericUpDownEntrega10.Value,
                    ValorFixo = numericUpDownValorFixo.Value,
                    Desconto = numericUpDownDesconto.Value
                };
                _fechamentoDiaService.EditarFechamentoDiaMotoqueiro(fechamento, DateOnly.FromDateTime(dateTimePicker1.Value));
                MessageBox.Show("Fechamento diário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                numericUpDownEntrega5.Value = fechamento.Entrega5;
                numericUpDownEntrega7.Value = fechamento.Entrega7;
                numericUpDownEntrega10.Value = fechamento.Entrega10;
                numericUpDownValorFixo.Value = fechamento.ValorFixo;
                numericUpDownDesconto.Value = fechamento.Desconto;
            }
            else
            {
                numericUpDownEntrega5.Value = 0;
                numericUpDownEntrega7.Value = 0;
                numericUpDownEntrega10.Value = 0;
                numericUpDownValorFixo.Value = 0;
                numericUpDownDesconto.Value = 0;
            }

        }
    }
}
