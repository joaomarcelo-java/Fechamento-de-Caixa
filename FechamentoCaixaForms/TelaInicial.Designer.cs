namespace FechamentoCaixaForms
{
    partial class TelaInicial
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            btnBuscarFechamentosFinais = new Button();
            btnDeletarFechamentoFinal = new Button();
            btnMotoqueiros = new Button();
            panelMenuMotoqueiros = new Panel();
            btnCadastrarMotoqueiro = new Button();
            btnEditarMotoqueiro = new Button();
            btnDeletarMotoqueiro = new Button();
            btnBuscarMotoqueiro = new Button();
            btnVales = new Button();
            panelLateral = new Panel();
            panelMenuFechamentosFinais = new Panel();
            btnFechamentosFinais = new Button();
            panelMenuFechamentos = new Panel();
            btnDeletarFechamentoDiario = new Button();
            btnEditarFechamentoDiario = new Button();
            btnFechamentosDiarios = new Button();
            panelFechamentoDia = new Panel();
            btnFecharSemana = new FechamentoCaixa.UI.Components.BotaoPadrao();
            btnAtualizarFechamentoDiario = new FechamentoCaixa.UI.Components.BotaoPadrao();
            btnAdicionarFechamentoMotoqueiro = new FechamentoCaixa.UI.Components.BotaoPadrao();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dgvFechamentoDia = new DataGridView();
            panelMenuMotoqueiros.SuspendLayout();
            panelLateral.SuspendLayout();
            panelMenuFechamentosFinais.SuspendLayout();
            panelMenuFechamentos.SuspendLayout();
            panelFechamentoDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFechamentoDia).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarFechamentosFinais
            // 
            btnBuscarFechamentosFinais.Dock = DockStyle.Top;
            btnBuscarFechamentosFinais.Location = new Point(0, 0);
            btnBuscarFechamentosFinais.Name = "btnBuscarFechamentosFinais";
            btnBuscarFechamentosFinais.Size = new Size(200, 30);
            btnBuscarFechamentosFinais.TabIndex = 3;
            btnBuscarFechamentosFinais.Text = "Exportar Fechamentos Finais";
            btnBuscarFechamentosFinais.Click += btnBuscarFechamentosFinais_Click;
            // 
            // btnDeletarFechamentoFinal
            // 
            btnDeletarFechamentoFinal.Dock = DockStyle.Top;
            btnDeletarFechamentoFinal.Location = new Point(0, 30);
            btnDeletarFechamentoFinal.Name = "btnDeletarFechamentoFinal";
            btnDeletarFechamentoFinal.Size = new Size(200, 30);
            btnDeletarFechamentoFinal.TabIndex = 3;
            btnDeletarFechamentoFinal.Text = "Deletar Fechamento Final";
            btnDeletarFechamentoFinal.Click += btnDeletarFechamentoFinal_Click;
            // 
            // btnMotoqueiros
            // 
            btnMotoqueiros.Dock = DockStyle.Top;
            btnMotoqueiros.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMotoqueiros.Location = new Point(0, 0);
            btnMotoqueiros.Name = "btnMotoqueiros";
            btnMotoqueiros.Size = new Size(200, 40);
            btnMotoqueiros.TabIndex = 2;
            btnMotoqueiros.Text = "Motoqueiros";
            btnMotoqueiros.Click += btnMotoqueiros_Click;
            // 
            // panelMenuMotoqueiros
            // 
            panelMenuMotoqueiros.Controls.Add(btnCadastrarMotoqueiro);
            panelMenuMotoqueiros.Controls.Add(btnEditarMotoqueiro);
            panelMenuMotoqueiros.Controls.Add(btnDeletarMotoqueiro);
            panelMenuMotoqueiros.Controls.Add(btnBuscarMotoqueiro);
            panelMenuMotoqueiros.Dock = DockStyle.Top;
            panelMenuMotoqueiros.Location = new Point(0, 40);
            panelMenuMotoqueiros.Name = "panelMenuMotoqueiros";
            panelMenuMotoqueiros.Size = new Size(200, 120);
            panelMenuMotoqueiros.TabIndex = 1;
            panelMenuMotoqueiros.Visible = false;
            // 
            // btnCadastrarMotoqueiro
            // 
            btnCadastrarMotoqueiro.Dock = DockStyle.Top;
            btnCadastrarMotoqueiro.Location = new Point(0, 90);
            btnCadastrarMotoqueiro.Name = "btnCadastrarMotoqueiro";
            btnCadastrarMotoqueiro.Size = new Size(200, 30);
            btnCadastrarMotoqueiro.TabIndex = 0;
            btnCadastrarMotoqueiro.Text = "Cadastrar Motoqueiro";
            btnCadastrarMotoqueiro.Click += btnCadastrarMotoqueiro_Click;
            // 
            // btnEditarMotoqueiro
            // 
            btnEditarMotoqueiro.Dock = DockStyle.Top;
            btnEditarMotoqueiro.Location = new Point(0, 60);
            btnEditarMotoqueiro.Name = "btnEditarMotoqueiro";
            btnEditarMotoqueiro.Size = new Size(200, 30);
            btnEditarMotoqueiro.TabIndex = 1;
            btnEditarMotoqueiro.Text = "Editar Motoqueiro";
            btnEditarMotoqueiro.Click += btnEditarMotoqueiro_Click;
            // 
            // btnDeletarMotoqueiro
            // 
            btnDeletarMotoqueiro.Dock = DockStyle.Top;
            btnDeletarMotoqueiro.Location = new Point(0, 30);
            btnDeletarMotoqueiro.Name = "btnDeletarMotoqueiro";
            btnDeletarMotoqueiro.Size = new Size(200, 30);
            btnDeletarMotoqueiro.TabIndex = 2;
            btnDeletarMotoqueiro.Text = "Deletar Motoqueiro";
            btnDeletarMotoqueiro.Click += btnDeletarMotoqueiro_Click;
            // 
            // btnBuscarMotoqueiro
            // 
            btnBuscarMotoqueiro.Dock = DockStyle.Top;
            btnBuscarMotoqueiro.Location = new Point(0, 0);
            btnBuscarMotoqueiro.Name = "btnBuscarMotoqueiro";
            btnBuscarMotoqueiro.Size = new Size(200, 30);
            btnBuscarMotoqueiro.TabIndex = 3;
            btnBuscarMotoqueiro.Text = "Buscar Motoqueiro";
            btnBuscarMotoqueiro.Click += btnBuscarMotoqueiro_Click;
            // 
            // btnVales
            // 
            btnVales.Dock = DockStyle.Top;
            btnVales.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVales.Location = new Point(0, 360);
            btnVales.Name = "btnVales";
            btnVales.Size = new Size(200, 40);
            btnVales.TabIndex = 0;
            btnVales.Text = "Vales";
            btnVales.Click += btnVales_Click;
            // 
            // panelLateral
            // 
            panelLateral.BackColor = Color.Gainsboro;
            panelLateral.Controls.Add(btnVales);
            panelLateral.Controls.Add(panelMenuFechamentosFinais);
            panelLateral.Controls.Add(btnFechamentosFinais);
            panelLateral.Controls.Add(panelMenuFechamentos);
            panelLateral.Controls.Add(btnFechamentosDiarios);
            panelLateral.Controls.Add(panelMenuMotoqueiros);
            panelLateral.Controls.Add(btnMotoqueiros);
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Location = new Point(0, 0);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(200, 410);
            panelLateral.TabIndex = 1;
            // 
            // panelMenuFechamentosFinais
            // 
            panelMenuFechamentosFinais.Controls.Add(btnDeletarFechamentoFinal);
            panelMenuFechamentosFinais.Controls.Add(btnBuscarFechamentosFinais);
            panelMenuFechamentosFinais.Dock = DockStyle.Top;
            panelMenuFechamentosFinais.Location = new Point(0, 300);
            panelMenuFechamentosFinais.Name = "panelMenuFechamentosFinais";
            panelMenuFechamentosFinais.Size = new Size(200, 60);
            panelMenuFechamentosFinais.TabIndex = 1;
            panelMenuFechamentosFinais.Visible = false;
            // 
            // btnFechamentosFinais
            // 
            btnFechamentosFinais.Dock = DockStyle.Top;
            btnFechamentosFinais.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechamentosFinais.Location = new Point(0, 260);
            btnFechamentosFinais.Name = "btnFechamentosFinais";
            btnFechamentosFinais.Size = new Size(200, 40);
            btnFechamentosFinais.TabIndex = 3;
            btnFechamentosFinais.Text = "Fechamentos Finais";
            btnFechamentosFinais.Click += btnFechamentosFinais_Click;
            // 
            // panelMenuFechamentos
            // 
            panelMenuFechamentos.Controls.Add(btnDeletarFechamentoDiario);
            panelMenuFechamentos.Controls.Add(btnEditarFechamentoDiario);
            panelMenuFechamentos.Dock = DockStyle.Top;
            panelMenuFechamentos.Location = new Point(0, 200);
            panelMenuFechamentos.Name = "panelMenuFechamentos";
            panelMenuFechamentos.Size = new Size(200, 60);
            panelMenuFechamentos.TabIndex = 1;
            panelMenuFechamentos.Visible = false;
            // 
            // btnDeletarFechamentoDiario
            // 
            btnDeletarFechamentoDiario.Dock = DockStyle.Top;
            btnDeletarFechamentoDiario.Location = new Point(0, 30);
            btnDeletarFechamentoDiario.Name = "btnDeletarFechamentoDiario";
            btnDeletarFechamentoDiario.Size = new Size(200, 30);
            btnDeletarFechamentoDiario.TabIndex = 0;
            btnDeletarFechamentoDiario.Text = "Deletar Fechamento Diário";
            btnDeletarFechamentoDiario.Click += btnDeletarFechamentoDiario_Click;
            // 
            // btnEditarFechamentoDiario
            // 
            btnEditarFechamentoDiario.Dock = DockStyle.Top;
            btnEditarFechamentoDiario.Location = new Point(0, 0);
            btnEditarFechamentoDiario.Name = "btnEditarFechamentoDiario";
            btnEditarFechamentoDiario.Size = new Size(200, 30);
            btnEditarFechamentoDiario.TabIndex = 1;
            btnEditarFechamentoDiario.Text = "Editar Fechamento Diário";
            btnEditarFechamentoDiario.Click += btnEditarFechamentoDiario_Click;
            // 
            // btnFechamentosDiarios
            // 
            btnFechamentosDiarios.Dock = DockStyle.Top;
            btnFechamentosDiarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechamentosDiarios.Location = new Point(0, 160);
            btnFechamentosDiarios.Name = "btnFechamentosDiarios";
            btnFechamentosDiarios.Size = new Size(200, 40);
            btnFechamentosDiarios.TabIndex = 2;
            btnFechamentosDiarios.Text = "Fechamentos Diários";
            btnFechamentosDiarios.Click += btnFechamentosDiarios_Click;
            // 
            // panelFechamentoDia
            // 
            panelFechamentoDia.BorderStyle = BorderStyle.FixedSingle;
            panelFechamentoDia.Controls.Add(btnFecharSemana);
            panelFechamentoDia.Controls.Add(btnAtualizarFechamentoDiario);
            panelFechamentoDia.Controls.Add(btnAdicionarFechamentoMotoqueiro);
            panelFechamentoDia.Controls.Add(label1);
            panelFechamentoDia.Controls.Add(dateTimePicker1);
            panelFechamentoDia.Controls.Add(dgvFechamentoDia);
            panelFechamentoDia.Dock = DockStyle.Fill;
            panelFechamentoDia.Location = new Point(200, 0);
            panelFechamentoDia.Name = "panelFechamentoDia";
            panelFechamentoDia.Size = new Size(579, 410);
            panelFechamentoDia.TabIndex = 0;
            // 
            // btnFecharSemana
            // 
            btnFecharSemana.BackColor = Color.FromArgb(100, 149, 237);
            btnFecharSemana.FlatAppearance.BorderSize = 0;
            btnFecharSemana.FlatStyle = FlatStyle.Flat;
            btnFecharSemana.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFecharSemana.ForeColor = Color.White;
            btnFecharSemana.Location = new Point(434, 51);
            btnFecharSemana.Name = "btnFecharSemana";
            btnFecharSemana.Size = new Size(131, 25);
            btnFecharSemana.TabIndex = 8;
            btnFecharSemana.Text = "Fechar Semana";
            btnFecharSemana.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Azul;
            btnFecharSemana.UseVisualStyleBackColor = false;
            btnFecharSemana.Click += btnFecharSemana_Click;
            // 
            // btnAtualizarFechamentoDiario
            // 
            btnAtualizarFechamentoDiario.BackColor = Color.FromArgb(102, 187, 106);
            btnAtualizarFechamentoDiario.FlatAppearance.BorderSize = 0;
            btnAtualizarFechamentoDiario.FlatStyle = FlatStyle.Flat;
            btnAtualizarFechamentoDiario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizarFechamentoDiario.ForeColor = Color.White;
            btnAtualizarFechamentoDiario.Location = new Point(434, 368);
            btnAtualizarFechamentoDiario.Name = "btnAtualizarFechamentoDiario";
            btnAtualizarFechamentoDiario.Size = new Size(131, 25);
            btnAtualizarFechamentoDiario.TabIndex = 7;
            btnAtualizarFechamentoDiario.Text = "Atualizar";
            btnAtualizarFechamentoDiario.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Verde;
            btnAtualizarFechamentoDiario.UseVisualStyleBackColor = false;
            btnAtualizarFechamentoDiario.Click += btnAtualizarFechamentoDiario_Click;
            // 
            // btnAdicionarFechamentoMotoqueiro
            // 
            btnAdicionarFechamentoMotoqueiro.BackColor = Color.FromArgb(102, 187, 106);
            btnAdicionarFechamentoMotoqueiro.FlatAppearance.BorderSize = 0;
            btnAdicionarFechamentoMotoqueiro.FlatStyle = FlatStyle.Flat;
            btnAdicionarFechamentoMotoqueiro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarFechamentoMotoqueiro.ForeColor = Color.White;
            btnAdicionarFechamentoMotoqueiro.Location = new Point(11, 368);
            btnAdicionarFechamentoMotoqueiro.Name = "btnAdicionarFechamentoMotoqueiro";
            btnAdicionarFechamentoMotoqueiro.Size = new Size(131, 25);
            btnAdicionarFechamentoMotoqueiro.TabIndex = 6;
            btnAdicionarFechamentoMotoqueiro.Text = "Fechar Motoqueiro";
            btnAdicionarFechamentoMotoqueiro.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Verde;
            btnAdicionarFechamentoMotoqueiro.UseVisualStyleBackColor = false;
            btnAdicionarFechamentoMotoqueiro.Click += btnAdicionarFechamento_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(212, 15);
            label1.Name = "label1";
            label1.Size = new Size(138, 23);
            label1.TabIndex = 0;
            label1.Text = "Fechamento do Dia";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(11, 50);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dgvFechamentoDia
            // 
            dgvFechamentoDia.AllowUserToAddRows = false;
            dgvFechamentoDia.AllowUserToDeleteRows = false;
            dgvFechamentoDia.AllowUserToResizeColumns = false;
            dgvFechamentoDia.AllowUserToResizeRows = false;
            dgvFechamentoDia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvFechamentoDia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvFechamentoDia.Location = new Point(11, 85);
            dgvFechamentoDia.Name = "dgvFechamentoDia";
            dgvFechamentoDia.ReadOnly = true;
            dgvFechamentoDia.RowHeadersVisible = false;
            dgvFechamentoDia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFechamentoDia.Size = new Size(554, 274);
            dgvFechamentoDia.TabIndex = 3;
            // 
            // TelaInicial
            // 
            ClientSize = new Size(779, 410);
            Controls.Add(panelFechamentoDia);
            Controls.Add(panelLateral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fechamento de Caixa";
            FormClosing += TelaInicial_FormClosing;
            panelMenuMotoqueiros.ResumeLayout(false);
            panelLateral.ResumeLayout(false);
            panelMenuFechamentosFinais.ResumeLayout(false);
            panelMenuFechamentos.ResumeLayout(false);
            panelFechamentoDia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFechamentoDia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMotoqueiros;
        private Button btnCadastrarMotoqueiro;
        private Button btnEditarMotoqueiro;
        private Button btnDeletarMotoqueiro;
        private Button btnBuscarMotoqueiro;
        private Button btnVales;

        private Panel panelFechamentoDia;
        private Panel panelMenuMotoqueiros;

        private Label label1;

        private DateTimePicker dateTimePicker1;

        private DataGridView dgvFechamentoDia;
        private Panel panelLateral;
        private Button btnFechamentosDiarios;
        private Panel panelMenuFechamentos;
        private Button btnEditarFechamentoDiario;
        private Button btnDeletarFechamentoDiario;
        private Button btnFechamentosFinais;
        private Panel panelMenuFechamentosFinais;
        private Button btnBuscarFechamentosFinais;
        private Button btnDeletarFechamentoFinal;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnAdicionarFechamentoMotoqueiro;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnAtualizarFechamentoDiario;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnFecharSemana;
    }
}
