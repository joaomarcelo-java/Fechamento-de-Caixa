namespace FechamentoCaixaForms
{
    partial class TelaDeletarFechamentoFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeletarFechamentoFinal));
            btnCancelar = new FechamentoCaixa.UI.Components.BotaoPadrao();
            btnExportar = new FechamentoCaixa.UI.Components.BotaoPadrao();
            labelAviso = new Label();
            labelTitulo = new Label();
            comboBoxFechamentosFinais = new ComboBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(100, 149, 237);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(178, 138);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 25);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Azul;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(102, 187, 106);
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI", 9F);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(22, 138);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(90, 25);
            btnExportar.TabIndex = 13;
            btnExportar.Text = "Deletar";
            btnExportar.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Verde;
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnDeletar_Click;
            // 
            // labelAviso
            // 
            labelAviso.AutoSize = true;
            labelAviso.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelAviso.ForeColor = Color.DarkRed;
            labelAviso.Location = new Point(22, 81);
            labelAviso.Name = "labelAviso";
            labelAviso.Size = new Size(252, 45);
            labelAviso.TabIndex = 12;
            labelAviso.Text = " Atenção: Apagar o fechamento final, não irá\napagar o arquivo exportado do mesmo, nem os\nfechamentos do periodo fechado.";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitulo.Location = new Point(54, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(205, 21);
            labelTitulo.TabIndex = 10;
            labelTitulo.Text = "Deletar Fechamento Final";
            // 
            // comboBoxFechamentosFinais
            // 
            comboBoxFechamentosFinais.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFechamentosFinais.Location = new Point(22, 44);
            comboBoxFechamentosFinais.Name = "comboBoxFechamentosFinais";
            comboBoxFechamentosFinais.Size = new Size(250, 23);
            comboBoxFechamentosFinais.TabIndex = 11;
            // 
            // TelaDeletarFechamentoFinal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 184);
            Controls.Add(btnCancelar);
            Controls.Add(btnExportar);
            Controls.Add(labelAviso);
            Controls.Add(labelTitulo);
            Controls.Add(comboBoxFechamentosFinais);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaDeletarFechamentoFinal";
            Text = "TelaDeletarFechamentoFinal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FechamentoCaixa.UI.Components.BotaoPadrao btnCancelar;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnExportar;
        private Label labelAviso;
        private Label labelTitulo;
        private ComboBox comboBoxFechamentosFinais;
    }
}