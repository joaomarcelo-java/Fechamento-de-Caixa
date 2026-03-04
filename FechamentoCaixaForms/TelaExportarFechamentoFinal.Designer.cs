namespace FechamentoCaixaForms
{
    partial class TelaExportarFechamentoFinal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaExportarFechamentoFinal));
            labelTitulo = new Label();
            comboBoxFechamentosFinais = new ComboBox();
            labelAviso = new Label();
            btnExportar = new FechamentoCaixa.UI.Components.BotaoPadrao();
            btnCancelar = new FechamentoCaixa.UI.Components.BotaoPadrao();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitulo.Location = new Point(29, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(214, 21);
            labelTitulo.TabIndex = 2;
            labelTitulo.Text = "Exportar Fechamento Final";
            // 
            // comboBoxFechamentosFinais
            // 
            comboBoxFechamentosFinais.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFechamentosFinais.Location = new Point(12, 44);
            comboBoxFechamentosFinais.Name = "comboBoxFechamentosFinais";
            comboBoxFechamentosFinais.Size = new Size(250, 23);
            comboBoxFechamentosFinais.TabIndex = 3;
            // 
            // labelAviso
            // 
            labelAviso.AutoSize = true;
            labelAviso.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelAviso.ForeColor = Color.DarkRed;
            labelAviso.Location = new Point(12, 81);
            labelAviso.Name = "labelAviso";
            labelAviso.Size = new Size(237, 45);
            labelAviso.TabIndex = 7;
            labelAviso.Text = " Atenção: Os fechamentos finais serão \nsalvos em arquivos de texto dentro da pasta\n \"Fechamentos Finais\" na área de trabalho.";
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(102, 187, 106);
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI", 9F);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(12, 138);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(90, 25);
            btnExportar.TabIndex = 8;
            btnExportar.Text = "Exportar";
            btnExportar.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Verde;
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(100, 149, 237);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(168, 138);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 25);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Azul;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // TelaExportarFechamentoFinal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 175);
            Controls.Add(btnCancelar);
            Controls.Add(btnExportar);
            Controls.Add(labelAviso);
            Controls.Add(labelTitulo);
            Controls.Add(comboBoxFechamentosFinais);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaExportarFechamentoFinal";
            Text = "TelaExportarFechamentoFinal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private ComboBox comboBoxFechamentosFinais;
        private Label labelAviso;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnExportar;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnCancelar;
    }
}