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

        // =========================
        // MENU MOTOQUEIROS
        // =========================
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CarregarFechamentoDia();
        }
        private void btnMotoqueiros_Click(object sender, EventArgs e)
        {
            panelMenuFechamentos.Visible = false;
            panelMenuFechamentosFinais.Visible = false;
            panelMenuMotoqueiros.Visible = !panelMenuMotoqueiros.Visible;
        }

        private void btnCadastrarMotoqueiro_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            var service = new MotoqueiroService(db);
            new TelaCadastroMotoqueiro(service).ShowDialog();
        }

        private void btnEditarMotoqueiro_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            var service = new MotoqueiroService(db);
            new TelaEditarMotoqueiro(service).ShowDialog();
        }

        private void btnDeletarMotoqueiro_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            var service = new MotoqueiroService(db);
            new TelaDeletarMotoqueiro(service).ShowDialog();
        }

        private void btnBuscarMotoqueiro_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            var service = new MotoqueiroService(db);
            new TelaBuscarMotoqueiro(service).ShowDialog();
        }
        // =========================
        // MENU FECHAMENTOS DIARIOS
        // =========================
        private void btnFechamentosDiarios_Click(object sender, EventArgs e)
        {
            panelMenuMotoqueiros.Visible = false;
            panelMenuFechamentosFinais.Visible = false;
            panelMenuFechamentos.Visible = !panelMenuFechamentos.Visible;
        }

        private void btnEditarFechamentoDiario_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            var motoService = new MotoqueiroService(db);
            var fechamentoService = new FechamentoDiaService(db);
            var tela = new TelaEditarFechamentoDiario(motoService, fechamentoService);
            if (tela.ShowDialog() == DialogResult.OK)
                CarregarFechamentoDia();
        }

        private void btnDeletarFechamentoDiario_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            var motoService = new MotoqueiroService(db);
            var fechamentoService = new FechamentoDiaService(db);
            var tela = new TelaDeletarFechamentoDiario(motoService, fechamentoService);
            if (tela.ShowDialog() == DialogResult.OK)
                CarregarFechamentoDia();
        }

        // =========================
        // FECHAMENTO DIA
        // =========================
        private void btnAdicionarFechamento_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            var motoService = new MotoqueiroService(db);
            var fechamentoService = new FechamentoDiaService(db);

            var tela = new TelaFechamentoMotoqueiro(motoService, fechamentoService);

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
            var fechamentoFinal = new FechamentoFinalService(db);
            var motoService = new MotoqueiroService(db);

            new TelaFecharSemana(fechamentoFinal, motoService).ShowDialog();
        }

        private void btnVales_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            var service = new MotoqueiroService(db);
            new TelaVerValesMotoqueiro(service).ShowDialog();
        }
        // =========================
        // MENU FECHAMENTOS FINAIS
        // =========================
        private void btnFechamentosFinais_Click(object sender, EventArgs e)
        {
            panelMenuMotoqueiros.Visible = false;
            panelMenuFechamentos.Visible = false;
            panelMenuFechamentosFinais.Visible = !panelMenuFechamentosFinais.Visible;
        }
        private void btnBuscarFechamentosFinais_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            var service = new FechamentoFinalService(db);
            new TelaExportarFechamentoFinal(service).ShowDialog();


        }
        private void btnDeletarFechamentoFinal_Click(object sender, EventArgs e)
        {
            using var db = new GerenciadorDatabase();
            var service = new FechamentoFinalService(db);
            new TelaDeletarFechamentoFinal(service).ShowDialog();
        }

        // =========================
        // GRID
        // =========================
        private void ConfigurarGrid()
        {
            dgvFechamentoDia.AutoGenerateColumns = false;
        }

        private void CarregarFechamentoDia()
        {
            var data = DateOnly.FromDateTime(dateTimePicker1.Value);

            using var db = new GerenciadorDatabase();
            var fechamentoService = new FechamentoDiaService(db);

            dgvFechamentoDia.DataSource =
                fechamentoService.ObterFechamentosDoDiaModel(data);
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
        private void TelaInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            using var db = new GerenciadorDatabase();
            db.CriarBackup();
        }
    }
}