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
    public partial class TelaDeletarMotoqueiro : Form
    {
        private readonly MotoqueiroService _motoqueiroService;
        public TelaDeletarMotoqueiro(MotoqueiroService motoqueiroService)
        {
            InitializeComponent();
            _motoqueiroService = motoqueiroService;
            CarregarMotoqueiros();
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
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (comboBoxMotoqueiros.SelectedItem is not Motoqueiro motoqueiroSelecionado)
                return;
            var confirmResult = MessageBox.Show($"Tem certeza que deseja deletar o motoqueiro '{motoqueiroSelecionado.Nome}'?", "Confirmar Deleção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    _motoqueiroService.DeletarMotoqueiro(motoqueiroSelecionado.Id);
                    MessageBox.Show("Motoqueiro deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarMotoqueiros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao deletar motoqueiro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
