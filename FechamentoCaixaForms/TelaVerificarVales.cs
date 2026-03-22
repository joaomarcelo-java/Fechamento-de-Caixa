using FechamentoCaixa.Service;
using FechamentoCaixa.Entities;
using FechamentoCaixa.Exceptions;
using System;
using System.Windows.Forms;

namespace FechamentoCaixaForms
{
    public partial class TelaVerificarVales : Form
    {
        private readonly MotoqueiroService _motoqueiroService;
        private readonly ValesService _valesService;

        public TelaVerificarVales(MotoqueiroService motoqueiroService, ValesService valesService)
        {
            InitializeComponent();
            _motoqueiroService = motoqueiroService;
            _valesService = valesService;
            CarregarMotoqueiros();
        }

        private void CarregarMotoqueiros()
        {
            comboBoxMotoqueiros.DataSource = _motoqueiroService.ListarMotoqueiros();
            comboBoxMotoqueiros.DisplayMember = "Nome";
        }

        private void CarregarVales()
        {
            if (comboBoxMotoqueiros.SelectedItem is not Motoqueiro motoqueiro)
                return;

            try
            {
                comboBoxValesDoMotoqueiro.DataSource = checkBoxMostrarValesPago.Checked
                    ? _valesService.GetAllValesMotoqueiro(motoqueiro.Id)
                    : _valesService.GetValesAtivosMotoqueiro(motoqueiro.Id);
            }
            catch (MotoqueiroNaoPossuiVale)
            {
                comboBoxValesDoMotoqueiro.DataSource = null;
                LimparDetalhes();
            }
        }

        private void AtualizarDetalhesVale()
        {
            if (comboBoxValesDoMotoqueiro.SelectedItem is Vales vale)
            {
                labelValorAtualValor.Text = vale.Valor.ToString("C");
                textBoxDescricaoVale.Text = vale.Descricao;
            }
            else
            {
                LimparDetalhes();
            }
        }

        private void LimparDetalhes()
        {
            labelValorAtualValor.Text = 0m.ToString("C");
            textBoxDescricaoVale.Clear();
        }

        private void comboBoxMotoqueiros_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarVales();
        }

        private void comboBoxValesDoMotoqueiro_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarDetalhesVale();
        }

        private void checkBoxMostrarValesPago_CheckedChanged(object sender, EventArgs e)
        {
            CarregarVales();
        }
    }
}