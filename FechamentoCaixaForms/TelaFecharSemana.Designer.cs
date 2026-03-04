namespace FechamentoCaixaForms
{
    partial class TelaFecharSemana
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos sendo usados.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFecharSemana));
            groupBoxFechamento = new GroupBox();
            btnAtualizar = new FechamentoCaixa.UI.Components.BotaoPadrao();
            btnFechar = new FechamentoCaixa.UI.Components.BotaoPadrao();
            dataGridResumo = new DataGridView();
            labelDataFim = new Label();
            labelDataInicio = new Label();
            dateTimeFim = new DateTimePicker();
            dateTimeInicio = new DateTimePicker();
            groupBoxFechamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridResumo).BeginInit();
            SuspendLayout();
            // 
            // groupBoxFechamento
            // 
            groupBoxFechamento.Controls.Add(btnAtualizar);
            groupBoxFechamento.Controls.Add(btnFechar);
            groupBoxFechamento.Controls.Add(dataGridResumo);
            groupBoxFechamento.Controls.Add(labelDataFim);
            groupBoxFechamento.Controls.Add(labelDataInicio);
            groupBoxFechamento.Controls.Add(dateTimeFim);
            groupBoxFechamento.Controls.Add(dateTimeInicio);
            groupBoxFechamento.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxFechamento.Location = new Point(40, 30);
            groupBoxFechamento.Name = "groupBoxFechamento";
            groupBoxFechamento.Size = new Size(900, 450);
            groupBoxFechamento.TabIndex = 0;
            groupBoxFechamento.TabStop = false;
            groupBoxFechamento.Text = "Fechamento da Semana";
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(100, 149, 237);
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Segoe UI", 11F);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(700, 380);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(160, 35);
            btnAtualizar.TabIndex = 8;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Azul;
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(102, 187, 106);
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 11F);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(30, 380);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(160, 35);
            btnFechar.TabIndex = 7;
            btnFechar.Text = "Fechar Semana";
            btnFechar.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Verde;
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // dataGridResumo
            // 
            dataGridResumo.AllowUserToAddRows = false;
            dataGridResumo.AllowUserToDeleteRows = false;
            dataGridResumo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridResumo.Location = new Point(30, 105);
            dataGridResumo.MultiSelect = false;
            dataGridResumo.Name = "dataGridResumo";
            dataGridResumo.ReadOnly = true;
            dataGridResumo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridResumo.Size = new Size(830, 250);
            dataGridResumo.TabIndex = 2;
            // 
            // labelDataFim
            // 
            labelDataFim.AutoSize = true;
            labelDataFim.Font = new Font("Segoe UI", 9F);
            labelDataFim.Location = new Point(180, 40);
            labelDataFim.Name = "labelDataFim";
            labelDataFim.Size = new Size(28, 15);
            labelDataFim.TabIndex = 3;
            labelDataFim.Text = "Até:";
            // 
            // labelDataInicio
            // 
            labelDataInicio.AutoSize = true;
            labelDataInicio.Font = new Font("Segoe UI", 9F);
            labelDataInicio.Location = new Point(30, 40);
            labelDataInicio.Name = "labelDataInicio";
            labelDataInicio.Size = new Size(24, 15);
            labelDataInicio.TabIndex = 4;
            labelDataInicio.Text = "De:";
            // 
            // dateTimeFim
            // 
            dateTimeFim.Format = DateTimePickerFormat.Short;
            dateTimeFim.Location = new Point(180, 60);
            dateTimeFim.Name = "dateTimeFim";
            dateTimeFim.Size = new Size(120, 27);
            dateTimeFim.TabIndex = 5;
            // 
            // dateTimeInicio
            // 
            dateTimeInicio.Format = DateTimePickerFormat.Short;
            dateTimeInicio.Location = new Point(30, 60);
            dateTimeInicio.Name = "dateTimeInicio";
            dateTimeInicio.Size = new Size(120, 27);
            dateTimeInicio.TabIndex = 6;
            // 
            // TelaFecharSemana
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 520);
            Controls.Add(groupBoxFechamento);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaFecharSemana";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fechamento de Semana";
            groupBoxFechamento.ResumeLayout(false);
            groupBoxFechamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridResumo).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private GroupBox groupBoxFechamento;
        private DateTimePicker dateTimeInicio;
        private DateTimePicker dateTimeFim;
        private Label labelDataInicio;
        private Label labelDataFim;
        private DataGridView dataGridResumo;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnFechar;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnAtualizar;
    }
}
