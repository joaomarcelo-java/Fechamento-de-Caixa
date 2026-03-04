using FechamentoCaixa.Service;
using FechamentoCaixa.Entities;
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
    public partial class TelaEditarMotoqueiro : Form
    {
        private readonly MotoqueiroService _motoqueiroService;
        public TelaEditarMotoqueiro(MotoqueiroService motoqueiroService)
        {
            InitializeComponent();

            _motoqueiroService = motoqueiroService;
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

            comboBoxMotoqueiros.DataSource = motoqueiros;
            comboBoxMotoqueiros.DisplayMember = nameof(Motoqueiro.Nome);
            comboBoxMotoqueiros.ValueMember = nameof(Motoqueiro.Id);

            if (comboBoxMotoqueiros.Items.Count > 0)
                comboBoxMotoqueiros.SelectedIndex = 0;
        }

        private void comboBoxMotoqueiros_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarCampos();
        }

        private void AtualizarCampos()
        {
            if (comboBoxMotoqueiros.SelectedItem is not Motoqueiro motoqueiro)
                return;

            textNomeMotoqueiro.Text = motoqueiro.Nome;
            checkBoxExtra.Checked = motoqueiro.Extra;
        }


        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Motoqueiro motoqueiroSelecionado = comboBoxMotoqueiros.SelectedItem as Motoqueiro;
                Motoqueiro motoqueiroNovo = new Motoqueiro(textNomeMotoqueiro.Text, checkBoxExtra.Checked);
                _motoqueiroService.EditarMotoqueiro(motoqueiroSelecionado.Id, motoqueiroNovo);
                MessageBox.Show("Motoqueiro editado com sucesso!");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
