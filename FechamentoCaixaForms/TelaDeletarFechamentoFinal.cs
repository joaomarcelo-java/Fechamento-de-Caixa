using System;
using FechamentoCaixa.Service;
using FechamentoCaixa.Entities;
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
    public partial class TelaDeletarFechamentoFinal : Form
    {
        private readonly FechamentoFinalService _fechamentoFinalService;
        public TelaDeletarFechamentoFinal(FechamentoFinalService fechamentoFinalService)
        {
            _fechamentoFinalService = fechamentoFinalService;
            InitializeComponent();
            CarregarFechamentosFinais();
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxFechamentosFinais.SelectedItem is FechamentoFinal fechamentoSelecionado)
                    _fechamentoFinalService.DeletarFechamentoFinal(fechamentoSelecionado.Id);
                MessageBox.Show("Fechamento final deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CarregarFechamentosFinais()
        {
            var fechamentos = _fechamentoFinalService.ObterFechamentosFinais();
            comboBoxFechamentosFinais.DataSource = fechamentos;
            comboBoxFechamentosFinais.DisplayMember = nameof(FechamentoFinal.Nome);
            comboBoxFechamentosFinais.ValueMember = nameof(FechamentoFinal.Id);
            if (comboBoxFechamentosFinais.Items.Count > 0)
                comboBoxFechamentosFinais.SelectedIndex = 0;
        }
    }
}
