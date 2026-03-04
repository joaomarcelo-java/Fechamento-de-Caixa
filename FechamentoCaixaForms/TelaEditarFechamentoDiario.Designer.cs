namespace FechamentoCaixaForms
{
    partial class TelaEditarFechamentoDiario : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEditarFechamentoDiario));
            labelMotoqueiro = new Label();
            labelData = new Label();
            labelValorFixo = new Label();
            labelDesconto = new Label();
            comboBoxEscolherMotoqueiro = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            groupBoxEntregas = new GroupBox();
            labelEntrega5 = new Label();
            numericUpDownEntrega5 = new NumericUpDown();
            labelEntrega7 = new Label();
            numericUpDownEntrega7 = new NumericUpDown();
            labelEntrega10 = new Label();
            numericUpDownEntrega10 = new NumericUpDown();
            numericUpDownValorFixo = new NumericUpDown();
            numericUpDownDesconto = new NumericUpDown();
            btnSalvar = new FechamentoCaixa.UI.Components.BotaoPadrao();
            btnCancelar = new FechamentoCaixa.UI.Components.BotaoPadrao();
            labelAviso = new Label();
            groupBoxEntregas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEntrega5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEntrega7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEntrega10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownValorFixo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).BeginInit();
            SuspendLayout();
            // 
            // labelMotoqueiro
            // 
            labelMotoqueiro.Location = new Point(20, 20);
            labelMotoqueiro.Name = "labelMotoqueiro";
            labelMotoqueiro.Size = new Size(100, 17);
            labelMotoqueiro.TabIndex = 0;
            labelMotoqueiro.Text = "Motoqueiro";
            // 
            // labelData
            // 
            labelData.Location = new Point(240, 20);
            labelData.Name = "labelData";
            labelData.Size = new Size(100, 17);
            labelData.TabIndex = 2;
            labelData.Text = "Data";
            // 
            // labelValorFixo
            // 
            labelValorFixo.Location = new Point(20, 215);
            labelValorFixo.Name = "labelValorFixo";
            labelValorFixo.Size = new Size(100, 23);
            labelValorFixo.TabIndex = 5;
            labelValorFixo.Text = "Valor Fixo";
            // 
            // labelDesconto
            // 
            labelDesconto.Location = new Point(20, 245);
            labelDesconto.Name = "labelDesconto";
            labelDesconto.Size = new Size(100, 23);
            labelDesconto.TabIndex = 7;
            labelDesconto.Text = "Desconto";
            // 
            // comboBoxEscolherMotoqueiro
            // 
            comboBoxEscolherMotoqueiro.Location = new Point(20, 40);
            comboBoxEscolherMotoqueiro.Name = "comboBoxEscolherMotoqueiro";
            comboBoxEscolherMotoqueiro.Size = new Size(200, 23);
            comboBoxEscolherMotoqueiro.TabIndex = 1;
            comboBoxEscolherMotoqueiro.SelectedIndexChanged += comboBoxEscolherMotoqueiro_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(240, 40);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // groupBoxEntregas
            // 
            groupBoxEntregas.Controls.Add(labelEntrega5);
            groupBoxEntregas.Controls.Add(numericUpDownEntrega5);
            groupBoxEntregas.Controls.Add(labelEntrega7);
            groupBoxEntregas.Controls.Add(numericUpDownEntrega7);
            groupBoxEntregas.Controls.Add(labelEntrega10);
            groupBoxEntregas.Controls.Add(numericUpDownEntrega10);
            groupBoxEntregas.Location = new Point(20, 80);
            groupBoxEntregas.Name = "groupBoxEntregas";
            groupBoxEntregas.Size = new Size(320, 120);
            groupBoxEntregas.TabIndex = 4;
            groupBoxEntregas.TabStop = false;
            groupBoxEntregas.Text = "Entregas do Dia";
            // 
            // labelEntrega5
            // 
            labelEntrega5.Location = new Point(20, 30);
            labelEntrega5.Name = "labelEntrega5";
            labelEntrega5.Size = new Size(100, 23);
            labelEntrega5.TabIndex = 0;
            labelEntrega5.Text = "Entregas R$ 5,00";
            // 
            // numericUpDownEntrega5
            // 
            numericUpDownEntrega5.Location = new Point(180, 28);
            numericUpDownEntrega5.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericUpDownEntrega5.Name = "numericUpDownEntrega5";
            numericUpDownEntrega5.Size = new Size(120, 23);
            numericUpDownEntrega5.TabIndex = 1;
            // 
            // labelEntrega7
            // 
            labelEntrega7.Location = new Point(20, 55);
            labelEntrega7.Name = "labelEntrega7";
            labelEntrega7.Size = new Size(100, 23);
            labelEntrega7.TabIndex = 2;
            labelEntrega7.Text = "Entregas R$ 7,00";
            // 
            // numericUpDownEntrega7
            // 
            numericUpDownEntrega7.Location = new Point(180, 53);
            numericUpDownEntrega7.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericUpDownEntrega7.Name = "numericUpDownEntrega7";
            numericUpDownEntrega7.Size = new Size(120, 23);
            numericUpDownEntrega7.TabIndex = 3;
            // 
            // labelEntrega10
            // 
            labelEntrega10.Location = new Point(20, 80);
            labelEntrega10.Name = "labelEntrega10";
            labelEntrega10.Size = new Size(100, 23);
            labelEntrega10.TabIndex = 4;
            labelEntrega10.Text = "Entregas R$ 10,00";
            // 
            // numericUpDownEntrega10
            // 
            numericUpDownEntrega10.Location = new Point(180, 78);
            numericUpDownEntrega10.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericUpDownEntrega10.Name = "numericUpDownEntrega10";
            numericUpDownEntrega10.Size = new Size(120, 23);
            numericUpDownEntrega10.TabIndex = 5;
            // 
            // numericUpDownValorFixo
            // 
            numericUpDownValorFixo.DecimalPlaces = 2;
            numericUpDownValorFixo.Location = new Point(180, 213);
            numericUpDownValorFixo.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownValorFixo.Name = "numericUpDownValorFixo";
            numericUpDownValorFixo.Size = new Size(100, 23);
            numericUpDownValorFixo.TabIndex = 6;
            // 
            // numericUpDownDesconto
            // 
            numericUpDownDesconto.DecimalPlaces = 2;
            numericUpDownDesconto.Location = new Point(180, 243);
            numericUpDownDesconto.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownDesconto.Name = "numericUpDownDesconto";
            numericUpDownDesconto.Size = new Size(100, 23);
            numericUpDownDesconto.TabIndex = 8;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(102, 187, 106);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(40, 325);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 25);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Verde;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(100, 149, 237);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(230, 325);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 25);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Azul;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // labelAviso
            // 
            labelAviso.AutoSize = true;
            labelAviso.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelAviso.ForeColor = Color.DarkRed;
            labelAviso.Location = new Point(40, 293);
            labelAviso.Name = "labelAviso";
            labelAviso.Size = new Size(278, 15);
            labelAviso.TabIndex = 13;
            labelAviso.Text = "Atenção: Valores negativos serão substituidos por 0.";
            // 
            // TelaEditarFechamentoDiario
            // 
            ClientSize = new Size(358, 371);
            Controls.Add(labelAviso);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(labelMotoqueiro);
            Controls.Add(comboBoxEscolherMotoqueiro);
            Controls.Add(labelData);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBoxEntregas);
            Controls.Add(labelValorFixo);
            Controls.Add(numericUpDownValorFixo);
            Controls.Add(labelDesconto);
            Controls.Add(numericUpDownDesconto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaEditarFechamentoDiario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Fechamento do Motoqueiro";
            groupBoxEntregas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownEntrega5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEntrega7).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEntrega10).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownValorFixo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBox comboBoxEscolherMotoqueiro;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBoxEntregas;
        private Label labelEntrega5;
        private Label labelEntrega7;
        private Label labelEntrega10;
        private NumericUpDown numericUpDownEntrega5;
        private NumericUpDown numericUpDownEntrega7;
        private NumericUpDown numericUpDownEntrega10;
        private NumericUpDown numericUpDownValorFixo;
        private NumericUpDown numericUpDownDesconto;
        private Label labelMotoqueiro;
        private Label labelData;
        private Label labelValorFixo;
        private Label labelDesconto;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnSalvar;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnCancelar;
        private Label labelAviso;
    }
}
