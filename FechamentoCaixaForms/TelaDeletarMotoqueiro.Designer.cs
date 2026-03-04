namespace FechamentoCaixaForms
{
    partial class TelaDeletarMotoqueiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeletarMotoqueiro));
            comboBoxMotoqueiros = new ComboBox();
            btnDeletar = new Button();
            labelTitulo = new Label();
            labelAviso = new Label();
            groupBox = new GroupBox();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxMotoqueiros
            // 
            comboBoxMotoqueiros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMotoqueiros.Location = new Point(20, 30);
            comboBoxMotoqueiros.Name = "comboBoxMotoqueiros";
            comboBoxMotoqueiros.Size = new Size(280, 23);
            comboBoxMotoqueiros.TabIndex = 0;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.IndianRed;
            btnDeletar.FlatStyle = FlatStyle.Flat;
            btnDeletar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeletar.ForeColor = Color.White;
            btnDeletar.Location = new Point(20, 65);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(280, 30);
            btnDeletar.TabIndex = 1;
            btnDeletar.Text = "Deletar Motoqueiro";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitulo.Location = new Point(30, 15);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(185, 25);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Excluir Motoqueiro";
            // 
            // labelAviso
            // 
            labelAviso.AutoSize = true;
            labelAviso.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelAviso.ForeColor = Color.DarkRed;
            labelAviso.Location = new Point(30, 180);
            labelAviso.Name = "labelAviso";
            labelAviso.Size = new Size(268, 30);
            labelAviso.TabIndex = 2;
            labelAviso.Text = "Atenção: Ao deletar um motoqueiro,\ntodos os fechamentos vinculados serão removidos.";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(comboBoxMotoqueiros);
            groupBox.Controls.Add(btnDeletar);
            groupBox.Location = new Point(30, 50);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(320, 120);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Selecione o motoqueiro";
            // 
            // TelaDeletarMotoqueiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 230);
            Controls.Add(groupBox);
            Controls.Add(labelTitulo);
            Controls.Add(labelAviso);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TelaDeletarMotoqueiro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Excluir Motoqueiro";
            groupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxMotoqueiros;
        private Button btnDeletar;
        private Label labelTitulo;
        private Label labelAviso;
        private GroupBox groupBox;
    }
}
