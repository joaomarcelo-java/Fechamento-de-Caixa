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
    public partial class TelaDescontarVales : Form
    {
        private readonly MotoqueiroService _motoqueiroService;
        private readonly ValesService _valesService;
        public TelaDescontarVales(MotoqueiroService motoqueiroService, ValesService valesService)
        {
            InitializeComponent();
            _motoqueiroService = motoqueiroService;
            _valesService = valesService;

            CarregarMotoqueiros();
        }

        private void btnDescontarVale_Click(object sender, EventArgs e)
        {
            if (comboBoxEscolherMotoqueiro.SelectedItem is not Motoqueiro motoqueiro)
                return;

            decimal valorVale = numericUpDownValorVale.Value;

            if (valorVale <= 0)
            {
                MessageBox.Show("Valor a ser removido inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _valesService.RemoveValeMotoqueiro(motoqueiro.Id, valorVale);

                MessageBox.Show("Valor removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizaValorVale();
                numericUpDownValorVale.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CarregarMotoqueiros()
        {
            comboBoxEscolherMotoqueiro.DataSource = _motoqueiroService.ListarMotoqueiros();
            comboBoxEscolherMotoqueiro.DisplayMember = "Nome";
        }

        private void AtualizaValorVale()
        {
            if (comboBoxEscolherMotoqueiro.SelectedItem is Motoqueiro motoqueiro)
            {
                labelSaldoValor.Text = _valesService.GetSaldoTotalValesMotoqueiro(motoqueiro.Id).ToString("C");
            }
            else
            {
                labelSaldoValor.Text = "R$ 0,00";
            }
        }

        private void SelectedIndexChange(object sender, EventArgs e)
        {
            AtualizaValorVale();
        }
    }
}