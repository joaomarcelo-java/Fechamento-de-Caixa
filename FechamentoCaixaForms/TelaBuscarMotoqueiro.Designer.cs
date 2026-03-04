namespace FechamentoCaixaForms
{
    partial class TelaBuscarMotoqueiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaBuscarMotoqueiro));
            comboMotoqueiro = new ComboBox();
            labelTitulo = new Label();
            labelEntregasDe5 = new Label();
            labelEntregasDe7 = new Label();
            labelEntregasDe10 = new Label();
            labelTotalEntregas = new Label();
            labelTotalFixoGanho = new Label();
            labelValeAtual = new Label();
            SuspendLayout();
            // 
            // comboMotoqueiro
            // 
            comboMotoqueiro.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMotoqueiro.Location = new Point(24, 55);
            comboMotoqueiro.Name = "comboMotoqueiro";
            comboMotoqueiro.Size = new Size(250, 23);
            comboMotoqueiro.TabIndex = 1;
            comboMotoqueiro.SelectedIndexChanged += comboMotoqueiro_SelectedIndexChanged;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitulo.Location = new Point(24, 20);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(190, 21);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Resumo do Motoqueiro";
            // 
            // labelEntregasDe5
            // 
            labelEntregasDe5.AutoSize = true;
            labelEntregasDe5.Location = new Point(24, 95);
            labelEntregasDe5.Name = "labelEntregasDe5";
            labelEntregasDe5.Size = new Size(102, 15);
            labelEntregasDe5.TabIndex = 2;
            labelEntregasDe5.Text = "Entregas de R$5: 0";
            // 
            // labelEntregasDe7
            // 
            labelEntregasDe7.AutoSize = true;
            labelEntregasDe7.Location = new Point(24, 115);
            labelEntregasDe7.Name = "labelEntregasDe7";
            labelEntregasDe7.Size = new Size(102, 15);
            labelEntregasDe7.TabIndex = 3;
            labelEntregasDe7.Text = "Entregas de R$7: 0";
            // 
            // labelEntregasDe10
            // 
            labelEntregasDe10.AutoSize = true;
            labelEntregasDe10.Location = new Point(24, 135);
            labelEntregasDe10.Name = "labelEntregasDe10";
            labelEntregasDe10.Size = new Size(108, 15);
            labelEntregasDe10.TabIndex = 4;
            labelEntregasDe10.Text = "Entregas de R$10: 0";
            // 
            // labelTotalEntregas
            // 
            labelTotalEntregas.AutoSize = true;
            labelTotalEntregas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTotalEntregas.Location = new Point(24, 225);
            labelTotalEntregas.Name = "labelTotalEntregas";
            labelTotalEntregas.Size = new Size(115, 15);
            labelTotalEntregas.TabIndex = 7;
            labelTotalEntregas.Text = "Total de Entregas: 0";
            // 
            // labelTotalFixoGanho
            // 
            labelTotalFixoGanho.AutoSize = true;
            labelTotalFixoGanho.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTotalFixoGanho.Location = new Point(24, 175);
            labelTotalFixoGanho.Name = "labelTotalFixoGanho";
            labelTotalFixoGanho.Size = new Size(147, 15);
            labelTotalFixoGanho.TabIndex = 5;
            labelTotalFixoGanho.Text = "Total Fixo Ganho: R$ 0,00";
            // 
            // labelValeAtual
            // 
            labelValeAtual.AutoSize = true;
            labelValeAtual.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelValeAtual.Location = new Point(24, 195);
            labelValeAtual.Name = "labelValeAtual";
            labelValeAtual.Size = new Size(110, 15);
            labelValeAtual.TabIndex = 6;
            labelValeAtual.Text = "Vale Atual: R$ 0,00";
            // 
            // TelaBuscarMotoqueiro
            // 
            ClientSize = new Size(350, 280);
            Controls.Add(labelTitulo);
            Controls.Add(comboMotoqueiro);
            Controls.Add(labelEntregasDe5);
            Controls.Add(labelEntregasDe7);
            Controls.Add(labelEntregasDe10);
            Controls.Add(labelTotalFixoGanho);
            Controls.Add(labelValeAtual);
            Controls.Add(labelTotalEntregas);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TelaBuscarMotoqueiro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Motoqueiro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboMotoqueiro;
        private Label labelTitulo;
        private Label labelEntregasDe5;
        private Label labelEntregasDe7;
        private Label labelEntregasDe10;
        private Label labelTotalEntregas;
        private Label labelTotalFixoGanho;
        private Label labelValeAtual;
    }
}
