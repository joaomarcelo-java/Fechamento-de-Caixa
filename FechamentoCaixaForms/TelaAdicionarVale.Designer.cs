namespace FechamentoCaixaForms
{
    partial class TelaAdicionarVale
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelMotoqueiro = new Label();
            comboBoxEscolherMotoqueiro = new ComboBox();
            labelValor = new Label();
            numericUpDown1 = new NumericUpDown();
            labelDescricaoVale = new Label();
            textBoxDescricao = new TextBox();
            btnAdicionarVale = new FechamentoCaixa.UI.Components.BotaoPadrao();
            btnCancelar = new FechamentoCaixa.UI.Components.BotaoPadrao();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // labelMotoqueiro
            // 
            labelMotoqueiro.AutoSize = true;
            labelMotoqueiro.Location = new Point(20, 20);
            labelMotoqueiro.Name = "labelMotoqueiro";
            labelMotoqueiro.Text = "Motoqueiro";
            // 
            // comboBoxEscolherMotoqueiro
            // 
            comboBoxEscolherMotoqueiro.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEscolherMotoqueiro.Location = new Point(20, 38);
            comboBoxEscolherMotoqueiro.Name = "comboBoxEscolherMotoqueiro";
            comboBoxEscolherMotoqueiro.Size = new Size(240, 23);
            comboBoxEscolherMotoqueiro.TabIndex = 0;
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Location = new Point(20, 75);
            labelValor.Name = "labelValor";
            labelValor.Text = "Valor do Vale";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(20, 93);
            numericUpDown1.Maximum = 99999;
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // labelDescricaoVale
            // 
            labelDescricaoVale.AutoSize = true;
            labelDescricaoVale.Location = new Point(20, 130);
            labelDescricaoVale.Name = "labelDescricaoVale";
            labelDescricaoVale.Text = "Descricao";
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.Location = new Point(20, 148);
            textBoxDescricao.Multiline = true;
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(240, 80);
            textBoxDescricao.TabIndex = 2;
            // 
            // btnAdicionarVale
            // 
            btnAdicionarVale.BackColor = Color.FromArgb(102, 187, 106);
            btnAdicionarVale.FlatAppearance.BorderSize = 0;
            btnAdicionarVale.FlatStyle = FlatStyle.Flat;
            btnAdicionarVale.Font = new Font("Segoe UI", 9F);
            btnAdicionarVale.ForeColor = Color.White;
            btnAdicionarVale.Location = new Point(20, 248);
            btnAdicionarVale.Name = "btnAdicionarVale";
            btnAdicionarVale.Size = new Size(90, 25);
            btnAdicionarVale.TabIndex = 3;
            btnAdicionarVale.Text = "Adicionar";
            btnAdicionarVale.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Verde;
            btnAdicionarVale.UseVisualStyleBackColor = false;
            btnAdicionarVale.Click += btnAdicionarVale_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(100, 149, 237);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(170, 248);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 25);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Azul;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // TelaAdicionarVale
            // 
            ClientSize = new Size(280, 290);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdicionarVale);
            Controls.Add(textBoxDescricao);
            Controls.Add(labelDescricaoVale);
            Controls.Add(numericUpDown1);
            Controls.Add(labelValor);
            Controls.Add(comboBoxEscolherMotoqueiro);
            Controls.Add(labelMotoqueiro);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaAdicionarVale";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Adicionar Vale";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMotoqueiro;
        private ComboBox comboBoxEscolherMotoqueiro;
        private Label labelValor;
        private NumericUpDown numericUpDown1;
        private Label labelDescricaoVale;
        private TextBox textBoxDescricao;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnAdicionarVale;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnCancelar;
    }
}