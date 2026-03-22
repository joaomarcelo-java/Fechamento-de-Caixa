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
    public partial class TelaAdicionarVale : Form
    {
        private readonly MotoqueiroService _motoqueiroService;
        private readonly ValesService _valesService;
        public TelaAdicionarVale(MotoqueiroService motoqueiroService, ValesService valesService)
        {
            _motoqueiroService = motoqueiroService;
            _valesService = valesService;
            InitializeComponent();
            CarregarMotoqueiros();
        }

        private void btnAdicionarVale_Click(object sender, EventArgs e)
        {
            if (comboBoxEscolherMotoqueiro.SelectedItem is not Motoqueiro motoqueiro)
            {
                MessageBox.Show(
                "Nenhum motoqueiro selecionado.",
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }
            if (numericUpDown1.Value < 0 || numericUpDown1.Value == 0)
            {
                MessageBox.Show(
                "Valor do vale inválido.",
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }
            if (textBoxDescricao.Text.Length == 0)
            {
                MessageBox.Show(
                "Adicione uma descrição ao vale.",
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }

            decimal valorVale = numericUpDown1.Value;
            string descricao = textBoxDescricao.Text;
            DateOnly data = DateOnly.FromDateTime(DateTime.Now);
            var valePassado = new Vales(valorVale, descricao, data);

            try
            {
                _valesService.AddValeMotoqueiro(motoqueiro.Id, valePassado);

                MessageBox.Show(
                "Vale adicionado com sucesso!",
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

                textBoxDescricao.Clear();
                numericUpDown1.Value = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                $"{ex.Message}",
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
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
    }
}
