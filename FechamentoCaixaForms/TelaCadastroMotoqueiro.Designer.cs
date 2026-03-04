namespace FechamentoCaixaForms
{
    partial class TelaCadastroMotoqueiro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroMotoqueiro));
            labelNome = new Label();
            textBoxNome = new TextBox();
            checkBoxExtra = new CheckBox();
            btnSalvar = new FechamentoCaixa.UI.Components.BotaoPadrao();
            btnCancelar = new FechamentoCaixa.UI.Components.BotaoPadrao();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(20, 20);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(123, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome do Motoqueiro";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(20, 40);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(240, 23);
            textBoxNome.TabIndex = 1;
            // 
            // checkBoxExtra
            // 
            checkBoxExtra.AutoSize = true;
            checkBoxExtra.Location = new Point(20, 75);
            checkBoxExtra.Name = "checkBoxExtra";
            checkBoxExtra.Size = new Size(117, 19);
            checkBoxExtra.TabIndex = 2;
            checkBoxExtra.Text = "Motoqueiro Extra";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(102, 187, 106);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(20, 115);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 25);
            btnSalvar.TabIndex = 7;
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
            btnCancelar.Location = new Point(166, 115);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 25);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Tipo = FechamentoCaixa.UI.Components.TipoBotao.Azul;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // TelaCadastroMotoqueiro
            // 
            ClientSize = new Size(268, 156);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(labelNome);
            Controls.Add(textBoxNome);
            Controls.Add(checkBoxExtra);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaCadastroMotoqueiro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Motoqueiro";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelNome;
        private TextBox textBoxNome;
        private CheckBox checkBoxExtra;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnSalvar;
        private FechamentoCaixa.UI.Components.BotaoPadrao btnCancelar;
    }
}
