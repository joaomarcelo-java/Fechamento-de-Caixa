namespace FechamentoCaixaForms
{
    partial class TelaFechamentoMotoqueiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFechamentoMotoqueiro));
            labelMotoqueiro = new Label();
            labelData = new Label();
            labelValorFixo = new Label();
            labelDesconto = new Label();
            comboBoxEscolherMotoqueiro = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            groupBoxEntregas = new GroupBox();
            labelEntrega5 = new Label();
            numericUpDown1 = new NumericUpDown();
            labelEntrega7 = new Label();
            numericUpDown2 = new NumericUpDown();
            labelEntrega10 = new Label();
            numericUpDown3 = new NumericUpDown();
            numericValorFixo = new NumericUpDown();
            numericDesconto = new NumericUpDown();
            btnSalvar = new FechamentoCaixa.UI.Components.BotaoPadrao();
            btnCancelar = new FechamentoCaixa.UI.Components.BotaoPadrao();
            labelAviso = new Label();
            groupBoxEntregas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericValorFixo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDesconto).BeginInit();
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
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(240, 40);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // groupBoxEntregas
            // 
            groupBoxEntregas.Controls.Add(labelEntrega5);
            groupBoxEntregas.Controls.Add(numericUpDown1);
            groupBoxEntregas.Controls.Add(labelEntrega7);
            groupBoxEntregas.Controls.Add(numericUpDown2);
            groupBoxEntregas.Controls.Add(labelEntrega10);
            groupBoxEntregas.Controls.Add(numericUpDown3);
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(180, 28);
            numericUpDown1.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // labelEntrega7
            // 
            labelEntrega7.Location = new Point(20, 55);
            labelEntrega7.Name = "labelEntrega7";
            labelEntrega7.Size = new Size(100, 23);
            labelEntrega7.TabIndex = 2;
            labelEntrega7.Text = "Entregas R$ 7,00";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(180, 53);
            numericUpDown2.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 3;
            // 
            // labelEntrega10
            // 
            labelEntrega10.Location = new Point(20, 80);
            labelEntrega10.Name = "labelEntrega10";
            labelEntrega10.Size = new Size(100, 23);
            labelEntrega10.TabIndex = 4;
            labelEntrega10.Text = "Entregas R$ 10,00";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(180, 78);
            numericUpDown3.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 5;
            // 
            // numericValorFixo
            // 
            numericValorFixo.DecimalPlaces = 2;
            numericValorFixo.Location = new Point(180, 213);
            numericValorFixo.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericValorFixo.Name = "numericValorFixo";
            numericValorFixo.Size = new Size(100, 23);
            numericValorFixo.TabIndex = 6;
            // 
            // numericDesconto
            // 
            numericDesconto.DecimalPlaces = 2;
            numericDesconto.Location = new Point(180, 243);
            numericDesconto.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericDesconto.Name = "numericDesconto";
            numericDesconto.Size = new Size(100, 23);
            numericDesconto.TabIndex = 8;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(102, 187, 106);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(20, 333);
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
            btnCancelar.Location = new Point(250, 333);
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
            labelAviso.Location = new Point(40, 285);
            labelAviso.Name = "labelAviso";
            labelAviso.Size = new Size(278, 15);
            labelAviso.TabIndex = 14;
            labelAviso.Text = "Atenção: Valores negativos serão substituidos por 0.";
            // 
            // TelaFechamentoMotoqueiro
            // 
            ClientSize = new Size(363, 374);
            Controls.Add(labelAviso);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(labelMotoqueiro);
            Controls.Add(comboBoxEscolherMotoqueiro);
            Controls.Add(labelData);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBoxEntregas);
            Controls.Add(labelValorFixo);
            Controls.Add(numericValorFixo);
            Controls.Add(labelDesconto);
            Controls.Add(numericDesconto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaFechamentoMotoqueiro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Fechamento do Motoqueiro";
            groupBoxEntregas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericValorFixo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDesconto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBox comboBoxEscolherMotoqueiro;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBoxEntregas;
        private Label labelEntrega5;
        private Label labelEntrega7;
        private Label labelEntrega10;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericValorFixo;
        private NumericUpDown numericDesconto;
        private Label labelMotoqueiro;
        private Label labelData;
        private Label labelValorFixo;
        private Label labelDesconto;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnSalvar;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnCancelar;
        private Label labelAviso;
    }
}
