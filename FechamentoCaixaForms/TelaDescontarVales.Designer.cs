namespace FechamentoCaixaForms
{
    partial class TelaDescontarVales
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
            labelSaldoAtual = new Label();
            labelSaldoValor = new Label();
            labelValorDescontar = new Label();
            numericUpDownValorVale = new NumericUpDown();
            btnDescontarVale = new FechamentoCaixa.UI.Components.BotaoPadrao();
            btnCancelar = new FechamentoCaixa.UI.Components.BotaoPadrao();
            ((System.ComponentModel.ISupportInitialize)numericUpDownValorVale).BeginInit();
            SuspendLayout();
            // 
            // labelMotoqueiro
            // 
            labelMotoqueiro.AutoSize = true;
            labelMotoqueiro.Location = new Point(20, 20);
            labelMotoqueiro.Name = "labelMotoqueiro";
            labelMotoqueiro.Size = new Size(70, 15);
            labelMotoqueiro.TabIndex = 7;
            labelMotoqueiro.Text = "Motoqueiro";
            // 
            // comboBoxEscolherMotoqueiro
            // 
            comboBoxEscolherMotoqueiro.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEscolherMotoqueiro.Location = new Point(20, 38);
            comboBoxEscolherMotoqueiro.Name = "comboBoxEscolherMotoqueiro";
            comboBoxEscolherMotoqueiro.Size = new Size(240, 23);
            comboBoxEscolherMotoqueiro.TabIndex = 0;
            comboBoxEscolherMotoqueiro.SelectedIndexChanged += SelectedIndexChange;
            // 
            // labelSaldoAtual
            // 
            labelSaldoAtual.AutoSize = true;
            labelSaldoAtual.Location = new Point(20, 75);
            labelSaldoAtual.Name = "labelSaldoAtual";
            labelSaldoAtual.Size = new Size(117, 15);
            labelSaldoAtual.TabIndex = 6;
            labelSaldoAtual.Text = "Saldo atual em vales:";
            // 
            // labelSaldoValor
            // 
            labelSaldoValor.AutoSize = true;
            labelSaldoValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelSaldoValor.ForeColor = Color.FromArgb(102, 187, 106);
            labelSaldoValor.Location = new Point(20, 93);
            labelSaldoValor.Name = "labelSaldoValor";
            labelSaldoValor.Size = new Size(49, 15);
            labelSaldoValor.TabIndex = 5;
            labelSaldoValor.Text = "R$ 0,00";
            // 
            // labelValorDescontar
            // 
            labelValorDescontar.AutoSize = true;
            labelValorDescontar.Location = new Point(20, 125);
            labelValorDescontar.Name = "labelValorDescontar";
            labelValorDescontar.Size = new Size(97, 15);
            labelValorDescontar.TabIndex = 4;
            labelValorDescontar.Text = "Valor a descontar";
            // 
            // numericUpDownValorVale
            // 
            numericUpDownValorVale.DecimalPlaces = 2;
            numericUpDownValorVale.Location = new Point(20, 143);
            numericUpDownValorVale.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDownValorVale.Name = "numericUpDownValorVale";
            numericUpDownValorVale.Size = new Size(150, 23);
            numericUpDownValorVale.TabIndex = 1;
            // 
            // btnDescontarVale
            // 
            btnDescontarVale.BackColor = Color.FromArgb(102, 187, 106);
            btnDescontarVale.FlatAppearance.BorderSize = 0;
            btnDescontarVale.FlatStyle = FlatStyle.Flat;
            btnDescontarVale.Font = new Font("Segoe UI", 9F);
            btnDescontarVale.ForeColor = Color.White;
            btnDescontarVale.Location = new Point(20, 190);
            btnDescontarVale.Name = "btnDescontarVale";
            btnDescontarVale.Size = new Size(90, 25);
            btnDescontarVale.TabIndex = 2;
            btnDescontarVale.Text = "Descontar";
            btnDescontarVale.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Verde;
            btnDescontarVale.UseVisualStyleBackColor = false;
            btnDescontarVale.Click += btnDescontarVale_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(100, 149, 237);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(170, 190);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 25);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Azul;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // TelaDescontarVales
            // 
            ClientSize = new Size(280, 232);
            Controls.Add(btnCancelar);
            Controls.Add(btnDescontarVale);
            Controls.Add(numericUpDownValorVale);
            Controls.Add(labelValorDescontar);
            Controls.Add(labelSaldoValor);
            Controls.Add(labelSaldoAtual);
            Controls.Add(comboBoxEscolherMotoqueiro);
            Controls.Add(labelMotoqueiro);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaDescontarVales";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Descontar Vale";
            ((System.ComponentModel.ISupportInitialize)numericUpDownValorVale).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMotoqueiro;
        private ComboBox comboBoxEscolherMotoqueiro;
        private Label labelSaldoAtual;
        private Label labelSaldoValor;
        private Label labelValorDescontar;
        private NumericUpDown numericUpDownValorVale;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnDescontarVale;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnCancelar;
    }
}