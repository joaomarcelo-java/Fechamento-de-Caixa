namespace FechamentoCaixaForms
{
    partial class TelaDeletarFechamentoDiario
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeletarFechamentoDiario));
            labelMotoqueiro = new Label();
            labelData = new Label();
            labelValorFixo = new Label();
            labelDesconto = new Label();
            comboBoxEscolherMotoqueiro = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            groupBoxEntregas = new GroupBox();
            labelValorTotal = new Label();
            labelEntrega5 = new Label();
            labelEntrega7 = new Label();
            labelEntrega10 = new Label();
            btnDeletar = new FechamentoCaixa.UI.Components.BotaoPadrao();
            btnCancelar = new FechamentoCaixa.UI.Components.BotaoPadrao();
            groupBoxEntregas.SuspendLayout();
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
            labelData.Location = new Point(175, 20);
            labelData.Name = "labelData";
            labelData.Size = new Size(100, 17);
            labelData.TabIndex = 2;
            labelData.Text = "Data";
            // 
            // labelValorFixo
            // 
            labelValorFixo.Location = new Point(20, 103);
            labelValorFixo.Name = "labelValorFixo";
            labelValorFixo.Size = new Size(231, 23);
            labelValorFixo.TabIndex = 5;
            labelValorFixo.Text = "Valor Fixo: ";
            // 
            // labelDesconto
            // 
            labelDesconto.Location = new Point(20, 126);
            labelDesconto.Name = "labelDesconto";
            labelDesconto.Size = new Size(231, 23);
            labelDesconto.TabIndex = 7;
            labelDesconto.Text = "Desconto: ";
            // 
            // comboBoxEscolherMotoqueiro
            // 
            comboBoxEscolherMotoqueiro.Location = new Point(20, 40);
            comboBoxEscolherMotoqueiro.Name = "comboBoxEscolherMotoqueiro";
            comboBoxEscolherMotoqueiro.Size = new Size(144, 23);
            comboBoxEscolherMotoqueiro.TabIndex = 1;
            comboBoxEscolherMotoqueiro.SelectedIndexChanged += comboBoxEscolherMotoqueiro_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(171, 40);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // groupBoxEntregas
            // 
            groupBoxEntregas.Controls.Add(labelValorTotal);
            groupBoxEntregas.Controls.Add(labelEntrega5);
            groupBoxEntregas.Controls.Add(labelEntrega7);
            groupBoxEntregas.Controls.Add(labelEntrega10);
            groupBoxEntregas.Controls.Add(labelValorFixo);
            groupBoxEntregas.Controls.Add(labelDesconto);
            groupBoxEntregas.Location = new Point(20, 78);
            groupBoxEntregas.Name = "groupBoxEntregas";
            groupBoxEntregas.Size = new Size(255, 175);
            groupBoxEntregas.TabIndex = 4;
            groupBoxEntregas.TabStop = false;
            groupBoxEntregas.Text = "Entregas do Dia";
            // 
            // labelValorTotal
            // 
            labelValorTotal.Location = new Point(20, 149);
            labelValorTotal.Name = "labelValorTotal";
            labelValorTotal.Size = new Size(231, 23);
            labelValorTotal.TabIndex = 8;
            labelValorTotal.Text = "Valor Total:";
            // 
            // labelEntrega5
            // 
            labelEntrega5.Location = new Point(20, 30);
            labelEntrega5.Name = "labelEntrega5";
            labelEntrega5.Size = new Size(231, 23);
            labelEntrega5.TabIndex = 0;
            labelEntrega5.Text = "Entregas R$ 5,00: ";
            // 
            // labelEntrega7
            // 
            labelEntrega7.Location = new Point(20, 55);
            labelEntrega7.Name = "labelEntrega7";
            labelEntrega7.Size = new Size(231, 23);
            labelEntrega7.TabIndex = 2;
            labelEntrega7.Text = "Entregas R$ 7,00: ";
            // 
            // labelEntrega10
            // 
            labelEntrega10.Location = new Point(20, 80);
            labelEntrega10.Name = "labelEntrega10";
            labelEntrega10.Size = new Size(231, 23);
            labelEntrega10.TabIndex = 4;
            labelEntrega10.Text = "Entregas R$ 10,00: ";
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.FromArgb(102, 187, 106);
            btnDeletar.FlatAppearance.BorderSize = 0;
            btnDeletar.FlatStyle = FlatStyle.Flat;
            btnDeletar.Font = new Font("Segoe UI", 9F);
            btnDeletar.ForeColor = Color.White;
            btnDeletar.Location = new Point(20, 269);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(90, 25);
            btnDeletar.TabIndex = 9;
            btnDeletar.Text = "Deletar";
            btnDeletar.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Verde;
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(100, 149, 237);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(185, 269);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 25);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Azul;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // TelaDeletarFechamentoDiario
            // 
            ClientSize = new Size(291, 326);
            Controls.Add(btnCancelar);
            Controls.Add(btnDeletar);
            Controls.Add(labelMotoqueiro);
            Controls.Add(comboBoxEscolherMotoqueiro);
            Controls.Add(labelData);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBoxEntregas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaDeletarFechamentoDiario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Fechamento do Motoqueiro";
            Load += TelaDeletarFechamentoDiario_Load;
            groupBoxEntregas.ResumeLayout(false);
            ResumeLayout(false);
        }

        private ComboBox comboBoxEscolherMotoqueiro;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBoxEntregas;
        private Label labelEntrega5;
        private Label labelEntrega7;
        private Label labelEntrega10;
        private Label labelMotoqueiro;
        private Label labelData;
        private Label labelValorFixo;
        private Label labelDesconto;
        private Label labelValorTotal;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnDeletar;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnCancelar;
    } 
}