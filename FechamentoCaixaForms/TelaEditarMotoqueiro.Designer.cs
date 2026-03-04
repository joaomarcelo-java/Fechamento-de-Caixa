namespace FechamentoCaixaForms
{
    partial class TelaEditarMotoqueiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEditarMotoqueiro));
            comboBoxMotoqueiros = new ComboBox();
            textNomeMotoqueiro = new TextBox();
            checkBoxExtra = new CheckBox();
            labelAviso = new Label();
            groupBoxDados = new GroupBox();
            labelMotoqueiro = new Label();
            labelNome = new Label();
            btnSalvar = new FechamentoCaixa.UI.Components.BotaoPadrao();
            groupBoxDados.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxMotoqueiros
            // 
            comboBoxMotoqueiros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMotoqueiros.Location = new Point(15, 45);
            comboBoxMotoqueiros.Name = "comboBoxMotoqueiros";
            comboBoxMotoqueiros.Size = new Size(320, 23);
            comboBoxMotoqueiros.TabIndex = 1;
            comboBoxMotoqueiros.SelectedIndexChanged += comboBoxMotoqueiros_SelectedIndexChanged;
            // 
            // textNomeMotoqueiro
            // 
            textNomeMotoqueiro.Location = new Point(15, 95);
            textNomeMotoqueiro.Name = "textNomeMotoqueiro";
            textNomeMotoqueiro.Size = new Size(320, 23);
            textNomeMotoqueiro.TabIndex = 2;
            // 
            // checkBoxExtra
            // 
            checkBoxExtra.AutoSize = true;
            checkBoxExtra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxExtra.Location = new Point(18, 125);
            checkBoxExtra.Name = "checkBoxExtra";
            checkBoxExtra.Size = new Size(55, 19);
            checkBoxExtra.TabIndex = 3;
            checkBoxExtra.Text = "Extra";
            checkBoxExtra.UseVisualStyleBackColor = true;
            // 
            // labelAviso
            // 
            labelAviso.AutoSize = true;
            labelAviso.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelAviso.ForeColor = Color.DarkRed;
            labelAviso.Location = new Point(20, 180);
            labelAviso.Name = "labelAviso";
            labelAviso.Size = new Size(225, 30);
            labelAviso.TabIndex = 1;
            labelAviso.Text = "Atenção: Alterações feitas aqui afetam\nfechamentos anteriores deste motoqueiro.";
            // 
            // groupBoxDados
            // 
            groupBoxDados.Controls.Add(labelMotoqueiro);
            groupBoxDados.Controls.Add(comboBoxMotoqueiros);
            groupBoxDados.Controls.Add(labelNome);
            groupBoxDados.Controls.Add(textNomeMotoqueiro);
            groupBoxDados.Controls.Add(checkBoxExtra);
            groupBoxDados.Location = new Point(20, 20);
            groupBoxDados.Name = "groupBoxDados";
            groupBoxDados.Size = new Size(360, 150);
            groupBoxDados.TabIndex = 0;
            groupBoxDados.TabStop = false;
            groupBoxDados.Text = "Dados do Motoqueiro";
            // 
            // labelMotoqueiro
            // 
            labelMotoqueiro.AutoSize = true;
            labelMotoqueiro.Location = new Point(15, 25);
            labelMotoqueiro.Name = "labelMotoqueiro";
            labelMotoqueiro.Size = new Size(133, 15);
            labelMotoqueiro.TabIndex = 0;
            labelMotoqueiro.Text = "Selecione o motoqueiro";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(15, 75);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(102, 187, 106);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(263, 243);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(117, 25);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar Alterações";
            btnSalvar.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Verde;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += buttonSalvar_Click;
            // 
            // TelaEditarMotoqueiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 280);
            Controls.Add(btnSalvar);
            Controls.Add(groupBoxDados);
            Controls.Add(labelAviso);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TelaEditarMotoqueiro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Motoqueiro";
            Click += buttonSalvar_Click;
            groupBoxDados.ResumeLayout(false);
            groupBoxDados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxMotoqueiros;
        private TextBox textNomeMotoqueiro;
        private CheckBox checkBoxExtra;
        private Label labelAviso;
        private GroupBox groupBoxDados;
        private Label labelMotoqueiro;
        private Label labelNome;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnSalvar;
    }
}
