namespace FechamentoCaixaForms
{
    partial class TelaDescontarFechamento
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDescontarFechamento));
            labelMotoqueiro = new Label();
            labelValorTotalFechado = new Label();
            labelLinha1 = new Label();
            labelValeMotoqueiro = new Label();
            labelValorDescontarVale = new Label();
            numericDescontoVale = new NumericUpDown();
            labelDescontosExtras = new Label();
            numericDescontoExtra = new NumericUpDown();
            btnConfirmar = new Button();
            btnProximoMotoqueiro = new Button();
            labelAviso = new Label();
            ((System.ComponentModel.ISupportInitialize)numericDescontoVale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDescontoExtra).BeginInit();
            SuspendLayout();
            // 
            // labelMotoqueiro
            // 
            labelMotoqueiro.AutoSize = true;
            labelMotoqueiro.Font = new Font("Segoe UI", 9F);
            labelMotoqueiro.Location = new Point(20, 20);
            labelMotoqueiro.Name = "labelMotoqueiro";
            labelMotoqueiro.Size = new Size(115, 15);
            labelMotoqueiro.TabIndex = 0;
            labelMotoqueiro.Text = "Motoqueiro: {nome}";
            // 
            // labelValorTotalFechado
            // 
            labelValorTotalFechado.AutoSize = true;
            labelValorTotalFechado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelValorTotalFechado.ForeColor = Color.DarkGreen;
            labelValorTotalFechado.Location = new Point(20, 45);
            labelValorTotalFechado.Name = "labelValorTotalFechado";
            labelValorTotalFechado.Size = new Size(198, 19);
            labelValorTotalFechado.TabIndex = 1;
            labelValorTotalFechado.Text = "Valor Total Fechado: R$ 0,00";
            // 
            // labelLinha1
            // 
            labelLinha1.BorderStyle = BorderStyle.Fixed3D;
            labelLinha1.Location = new Point(20, 70);
            labelLinha1.Name = "labelLinha1";
            labelLinha1.Size = new Size(330, 2);
            labelLinha1.TabIndex = 2;
            // 
            // labelValeMotoqueiro
            // 
            labelValeMotoqueiro.AutoSize = true;
            labelValeMotoqueiro.Location = new Point(20, 85);
            labelValeMotoqueiro.Name = "labelValeMotoqueiro";
            labelValeMotoqueiro.Size = new Size(100, 15);
            labelValeMotoqueiro.TabIndex = 3;
            labelValeMotoqueiro.Text = "Vale atual: R$ 0,00";
            // 
            // labelValorDescontarVale
            // 
            labelValorDescontarVale.AutoSize = true;
            labelValorDescontarVale.Location = new Point(20, 110);
            labelValorDescontarVale.Name = "labelValorDescontarVale";
            labelValorDescontarVale.Size = new Size(141, 15);
            labelValorDescontarVale.TabIndex = 4;
            labelValorDescontarVale.Text = "Valor a descontar do vale:";
            // 
            // numericDescontoVale
            // 
            numericDescontoVale.DecimalPlaces = 2;
            numericDescontoVale.Location = new Point(20, 130);
            numericDescontoVale.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericDescontoVale.Name = "numericDescontoVale";
            numericDescontoVale.Size = new Size(150, 23);
            numericDescontoVale.TabIndex = 5;
            numericDescontoVale.ThousandsSeparator = true;
            // 
            // labelDescontosExtras
            // 
            labelDescontosExtras.AutoSize = true;
            labelDescontosExtras.Location = new Point(20, 165);
            labelDescontosExtras.Name = "labelDescontosExtras";
            labelDescontosExtras.Size = new Size(98, 15);
            labelDescontosExtras.TabIndex = 6;
            labelDescontosExtras.Text = "Descontos extras:";
            // 
            // numericDescontoExtra
            // 
            numericDescontoExtra.DecimalPlaces = 2;
            numericDescontoExtra.Location = new Point(20, 185);
            numericDescontoExtra.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericDescontoExtra.Name = "numericDescontoExtra";
            numericDescontoExtra.Size = new Size(150, 23);
            numericDescontoExtra.TabIndex = 7;
            numericDescontoExtra.ThousandsSeparator = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(40, 167, 69);
            btnConfirmar.CausesValidation = false;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(103, 301);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(197, 32);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "Salvar Fechamento";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnProximoMotoqueiro
            // 
            btnProximoMotoqueiro.BackColor = Color.DarkBlue;
            btnProximoMotoqueiro.CausesValidation = false;
            btnProximoMotoqueiro.FlatAppearance.BorderSize = 0;
            btnProximoMotoqueiro.FlatStyle = FlatStyle.Flat;
            btnProximoMotoqueiro.ForeColor = Color.White;
            btnProximoMotoqueiro.Location = new Point(103, 263);
            btnProximoMotoqueiro.Name = "btnProximoMotoqueiro";
            btnProximoMotoqueiro.Size = new Size(197, 32);
            btnProximoMotoqueiro.TabIndex = 9;
            btnProximoMotoqueiro.Text = "Confirmar Motoqueiro e Próximo";
            btnProximoMotoqueiro.UseVisualStyleBackColor = false;
            btnProximoMotoqueiro.Click += btnProximoMotoqueiro_Click;
            // 
            // labelAviso
            // 
            labelAviso.AutoSize = true;
            labelAviso.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelAviso.ForeColor = Color.DarkRed;
            labelAviso.Location = new Point(58, 229);
            labelAviso.Name = "labelAviso";
            labelAviso.Size = new Size(278, 15);
            labelAviso.TabIndex = 14;
            labelAviso.Text = "Atenção: Valores negativos serão substituidos por 0.";
            // 
            // TelaDescontarFechamento
            // 
            ClientSize = new Size(380, 345);
            Controls.Add(labelAviso);
            Controls.Add(btnProximoMotoqueiro);
            Controls.Add(labelMotoqueiro);
            Controls.Add(labelValorTotalFechado);
            Controls.Add(labelLinha1);
            Controls.Add(labelValeMotoqueiro);
            Controls.Add(labelValorDescontarVale);
            Controls.Add(numericDescontoVale);
            Controls.Add(labelDescontosExtras);
            Controls.Add(numericDescontoExtra);
            Controls.Add(btnConfirmar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaDescontarFechamento";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Descontar Fechamento";
            ((System.ComponentModel.ISupportInitialize)numericDescontoVale).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDescontoExtra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMotoqueiro;
        private Label labelValorTotalFechado;
        private Label labelLinha1;
        private Label labelValeMotoqueiro;
        private Label labelValorDescontarVale;
        private NumericUpDown numericDescontoVale;
        private Label labelDescontosExtras;
        private NumericUpDown numericDescontoExtra;
        private Button btnConfirmar;
        private Button btnProximoMotoqueiro;
        private Label labelAviso;
    }
}
