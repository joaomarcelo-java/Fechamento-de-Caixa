namespace FechamentoCaixaForms
{
    partial class TelaVerValesMotoqueiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVerValesMotoqueiro));
            comboBoxMotoqueiros = new ComboBox();
            numericValor = new NumericUpDown();
            labelValorValeAtual = new Label();
            btnRemoverVale = new FechamentoCaixa.UI.Components.BotaoPadrao();
            btnAdicionarVale = new FechamentoCaixa.UI.Components.BotaoPadrao();
            ((System.ComponentModel.ISupportInitialize)numericValor).BeginInit();
            SuspendLayout();
            // 
            // comboBoxMotoqueiros
            // 
            comboBoxMotoqueiros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMotoqueiros.Location = new Point(35, 30);
            comboBoxMotoqueiros.Name = "comboBoxMotoqueiros";
            comboBoxMotoqueiros.Size = new Size(220, 23);
            comboBoxMotoqueiros.TabIndex = 0;
            comboBoxMotoqueiros.SelectedIndexChanged += comboBoxMotoqueiros_SelectedIndexChanged;
            // 
            // numericValor
            // 
            numericValor.DecimalPlaces = 2;
            numericValor.Location = new Point(35, 110);
            numericValor.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericValor.Name = "numericValor";
            numericValor.Size = new Size(120, 23);
            numericValor.TabIndex = 2;
            // 
            // labelValorValeAtual
            // 
            labelValorValeAtual.AutoSize = true;
            labelValorValeAtual.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelValorValeAtual.Location = new Point(35, 70);
            labelValorValeAtual.Name = "labelValorValeAtual";
            labelValorValeAtual.Size = new Size(131, 19);
            labelValorValeAtual.TabIndex = 1;
            labelValorValeAtual.Text = "Vale atual: R$ 0,00";
            // 
            // btnRemoverVale
            // 
            btnRemoverVale.BackColor = Color.FromArgb(102, 187, 106);
            btnRemoverVale.FlatAppearance.BorderSize = 0;
            btnRemoverVale.FlatStyle = FlatStyle.Flat;
            btnRemoverVale.Font = new Font("Segoe UI", 9F);
            btnRemoverVale.ForeColor = Color.White;
            btnRemoverVale.Location = new Point(35, 155);
            btnRemoverVale.Name = "btnRemoverVale";
            btnRemoverVale.Size = new Size(90, 25);
            btnRemoverVale.TabIndex = 5;
            btnRemoverVale.Text = "Remover Vale";
            btnRemoverVale.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Verde;
            btnRemoverVale.UseVisualStyleBackColor = false;
            btnRemoverVale.Click += btnRemoverVale_Click;
            // 
            // btnAdicionarVale
            // 
            btnAdicionarVale.BackColor = Color.FromArgb(100, 149, 237);
            btnAdicionarVale.FlatAppearance.BorderSize = 0;
            btnAdicionarVale.FlatStyle = FlatStyle.Flat;
            btnAdicionarVale.Font = new Font("Segoe UI", 9F);
            btnAdicionarVale.ForeColor = Color.White;
            btnAdicionarVale.Location = new Point(164, 155);
            btnAdicionarVale.Name = "btnAdicionarVale";
            btnAdicionarVale.Size = new Size(91, 25);
            btnAdicionarVale.TabIndex = 6;
            btnAdicionarVale.Text = "Adicionar Vale";
            btnAdicionarVale.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Azul;
            btnAdicionarVale.UseVisualStyleBackColor = false;
            btnAdicionarVale.Click += btnAdicionarVale_Click;
            // 
            // TelaVerValesMotoqueiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 230);
            Controls.Add(btnAdicionarVale);
            Controls.Add(btnRemoverVale);
            Controls.Add(comboBoxMotoqueiros);
            Controls.Add(labelValorValeAtual);
            Controls.Add(numericValor);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TelaVerValesMotoqueiro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vales do Motoqueiro";
            ((System.ComponentModel.ISupportInitialize)numericValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxMotoqueiros;
        private NumericUpDown numericValor;
        private Label labelValorValeAtual;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnRemoverVale;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnAdicionarVale;
    }
}
