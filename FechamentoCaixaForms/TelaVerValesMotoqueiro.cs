using FechamentoCaixa.DataBase;
using FechamentoCaixa.Entities;
using FechamentoCaixa.Service;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FechamentoCaixaForms
{
    public partial class TelaVerValesMotoqueiro : Form
    {
        private readonly MotoqueiroService _motoqueiroService;

        public TelaVerValesMotoqueiro(MotoqueiroService motoqueiroService)
        {
            _motoqueiroService = motoqueiroService;
            AplicarSelectAll(this);
            InitializeComponent();
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

            comboBoxMotoqueiros.DataSource = motoqueiros;
            comboBoxMotoqueiros.DisplayMember = "Nome";
            comboBoxMotoqueiros.ValueMember = "Id";
        }

        private void comboBoxMotoqueiros_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValeAtual();
        }

        private void AtualizarValeAtual()
        {
            if (VerificaComboBoxVazio())
                return;
            var motoqueiro = comboBoxMotoqueiros.SelectedItem as Motoqueiro;

            labelValorValeAtual.Text = $"Vale atual: R$ {motoqueiro.Vale:N2}";
        }

        private void btnAdicionarVale_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaComboBoxVazio())
                    return;

                var motoqueiro = comboBoxMotoqueiros.SelectedItem as Motoqueiro;
                decimal valor = numericValor.Value;

                _motoqueiroService.AdicionarValeMotoqueiro(motoqueiro.Id, valor);
                AtualizarValeAtual();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoverVale_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaComboBoxVazio())
                    return;

                var motoqueiro = comboBoxMotoqueiros.SelectedItem as Motoqueiro;
                decimal valor = numericValor.Value;

                _motoqueiroService.RemoverValeMotoqueiro(motoqueiro.Id, valor);
                AtualizarValeAtual();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool VerificaComboBoxVazio()
        {
            return comboBoxMotoqueiros.SelectedItem is not Motoqueiro motoqueiro;
        }
    }
}
