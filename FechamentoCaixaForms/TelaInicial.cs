using FechamentoCaixa.DataBase;
using FechamentoCaixa.Service;
using System;
using System.Windows.Forms;

namespace FechamentoCaixaForms
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            panelMenuMotoqueiros.Visible = false;
            Load += TelaInicial_Load;
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CriarColunas();
            CarregarFechamentoDia();
        }

        private void TelaInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            using var db = new GerenciadorDatabase();
            db.CriarBackup();
        }
        private void btnMotoqueiros_Click(object sender, EventArgs e)
        {
            FecharMenus(exceto: panelMenuMotoqueiros);
            panelMenuMotoqueiros.Visible = !panelMenuMotoqueiros.Visible;
        }

        private void btnCadastrarMotoqueiro_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            new TelaCadastroMotoqueiro(new MotoqueiroService(db)).ShowDialog();
        }

        private void btnEditarMotoqueiro_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            new TelaEditarMotoqueiro(new MotoqueiroService(db)).ShowDialog();
        }

        private void btnDeletarMotoqueiro_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            new TelaDeletarMotoqueiro(new MotoqueiroService(db)).ShowDialog();
        }

        private void btnBuscarMotoqueiro_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            new TelaBuscarMotoqueiro(new MotoqueiroService(db), new ValesService(db)).ShowDialog();
        }


        private void btnVales_Click(object sender, EventArgs e)
        {
            FecharMenus(exceto: panelMenuVales);
            panelMenuVales.Visible = !panelMenuVales.Visible;
        }

        private void btnAdicionarVale_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            var motoqueiroService = new MotoqueiroService(db);
            var valesService = new ValesService(db);
            new TelaAdicionarVale(motoqueiroService, valesService).ShowDialog();
        }

        private void btnRemoverVale_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            var motoqueiroService = new MotoqueiroService(db);
            var valesService = new ValesService(db);
            new TelaDescontarVales(motoqueiroService, valesService).ShowDialog();
        }
        private void btnVerificarVales_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            var motoqueiroService = new MotoqueiroService(db);
            var valesService = new ValesService(db);
            new TelaVerificarVales(motoqueiroService, valesService).ShowDialog();
        }

        private void btnFechamentosDiarios_Click(object sender, EventArgs e)
        {
            FecharMenus(exceto: panelMenuFechamentos);
            panelMenuFechamentos.Visible = !panelMenuFechamentos.Visible;
        }

        private void btnEditarFechamentoDiario_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            var tela = new TelaEditarFechamentoDiario(new MotoqueiroService(db), new FechamentoDiaService(db));
            if (tela.ShowDialog() == DialogResult.OK)
                CarregarFechamentoDia();
        }

        private void btnDeletarFechamentoDiario_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            var tela = new TelaDeletarFechamentoDiario(new MotoqueiroService(db), new FechamentoDiaService(db));
            if (tela.ShowDialog() == DialogResult.OK)
                CarregarFechamentoDia();
        }


        private void btnFechamentosFinais_Click(object sender, EventArgs e)
        {
            FecharMenus(exceto: panelMenuFechamentosFinais);
            panelMenuFechamentosFinais.Visible = !panelMenuFechamentosFinais.Visible;
        }

        private void btnBuscarFechamentosFinais_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            new TelaExportarFechamentoFinal(new FechamentoFinalService(db)).ShowDialog();
        }

        private void btnDeletarFechamentoFinal_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            new TelaDeletarFechamentoFinal(new FechamentoFinalService(db)).ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CarregarFechamentoDia();
        }

        private void btnAdicionarFechamento_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            var tela = new TelaFechamentoMotoqueiro(new MotoqueiroService(db), new FechamentoDiaService(db));
            if (tela.ShowDialog() == DialogResult.OK)
                CarregarFechamentoDia();
        }

        private void btnAtualizarFechamentoDiario_Click(object sender, EventArgs e)
        {
            CarregarFechamentoDia();
        }

        private void btnFecharSemana_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            new TelaFecharSemana(new FechamentoFinalService(db), new MotoqueiroService(db), new ValesService(db)).ShowDialog();
        }
        private void CarregarFechamentoDia()
        {
            using var db = new GerenciadorDatabase();
            var data = DateOnly.FromDateTime(dateTimePicker1.Value);
            dgvFechamentoDia.DataSource = new FechamentoDiaService(db).ObterFechamentosDoDiaModel(data);
        }

        private void ConfigurarGrid()
        {
            dgvFechamentoDia.AutoGenerateColumns = false;
        }

        private void CriarColunas()
        {
            dgvFechamentoDia.AutoGenerateColumns = false;
            dgvFechamentoDia.Columns.Clear();

            dgvFechamentoDia.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Motoqueiro",
                DataPropertyName = "Motoqueiro"
            });
            dgvFechamentoDia.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Entrega 5",
                DataPropertyName = "Entrega5"
            });
            dgvFechamentoDia.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Entrega 7",
                DataPropertyName = "Entrega7"
            });
            dgvFechamentoDia.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Entrega 10",
                DataPropertyName = "Entrega10"
            });
            dgvFechamentoDia.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Descontos",
                DataPropertyName = "Descontos",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });
            dgvFechamentoDia.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fixo",
                DataPropertyName = "ValorFixo",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });
            dgvFechamentoDia.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total",
                DataPropertyName = "Total",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Font = new Font("Segoe UI", 9, FontStyle.Bold)
                }
            });
        }
        private void FecharMenus(Panel exceto)
        {
            if (panelMenuMotoqueiros != exceto) panelMenuMotoqueiros.Visible = false;
            if (panelMenuVales != exceto) panelMenuVales.Visible = false;
            if (panelMenuFechamentos != exceto) panelMenuFechamentos.Visible = false;
            if (panelMenuFechamentosFinais != exceto) panelMenuFechamentosFinais.Visible = false;
        }
    }
}