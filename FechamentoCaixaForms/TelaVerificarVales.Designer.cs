namespace FechamentoCaixaForms
{
    partial class TelaVerificarVales
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
            comboBoxMotoqueiros = new ComboBox();
            checkBoxMostrarValesPago = new CheckBox();
            labelListaDeVales = new Label();
            comboBoxValesDoMotoqueiro = new ComboBox();
            labelValorAtualDoVale = new Label();
            labelValorAtualValor = new Label();
            labelDescricaoVale = new Label();
            textBoxDescricaoVale = new TextBox();
            SuspendLayout();
            // 
            // labelMotoqueiro
            // 
            labelMotoqueiro.AutoSize = true;
            labelMotoqueiro.Location = new Point(20, 20);
            labelMotoqueiro.Name = "labelMotoqueiro";
            labelMotoqueiro.Size = new Size(70, 15);
            labelMotoqueiro.TabIndex = 8;
            labelMotoqueiro.Text = "Motoqueiro";
            // 
            // comboBoxMotoqueiros
            // 
            comboBoxMotoqueiros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMotoqueiros.Location = new Point(20, 38);
            comboBoxMotoqueiros.Name = "comboBoxMotoqueiros";
            comboBoxMotoqueiros.Size = new Size(240, 23);
            comboBoxMotoqueiros.TabIndex = 0;
            comboBoxMotoqueiros.SelectedIndexChanged += comboBoxMotoqueiros_SelectedIndexChanged;
            // 
            // checkBoxMostrarValesPago
            // 
            checkBoxMostrarValesPago.AutoSize = true;
            checkBoxMostrarValesPago.Location = new Point(20, 72);
            checkBoxMostrarValesPago.Name = "checkBoxMostrarValesPago";
            checkBoxMostrarValesPago.Size = new Size(131, 19);
            checkBoxMostrarValesPago.TabIndex = 1;
            checkBoxMostrarValesPago.Text = "Mostrar Vales Pagos";
            checkBoxMostrarValesPago.CheckedChanged += checkBoxMostrarValesPago_CheckedChanged;
            // 
            // labelListaDeVales
            // 
            labelListaDeVales.AutoSize = true;
            labelListaDeVales.Location = new Point(20, 105);
            labelListaDeVales.Name = "labelListaDeVales";
            labelListaDeVales.Size = new Size(76, 15);
            labelListaDeVales.TabIndex = 7;
            labelListaDeVales.Text = "Lista de Vales";
            // 
            // comboBoxValesDoMotoqueiro
            // 
            comboBoxValesDoMotoqueiro.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxValesDoMotoqueiro.Location = new Point(20, 123);
            comboBoxValesDoMotoqueiro.Name = "comboBoxValesDoMotoqueiro";
            comboBoxValesDoMotoqueiro.Size = new Size(240, 23);
            comboBoxValesDoMotoqueiro.TabIndex = 2;
            comboBoxValesDoMotoqueiro.SelectedIndexChanged += comboBoxValesDoMotoqueiro_SelectedIndexChanged;
            // 
            // labelValorAtualDoVale
            // 
            labelValorAtualDoVale.AutoSize = true;
            labelValorAtualDoVale.Location = new Point(20, 160);
            labelValorAtualDoVale.Name = "labelValorAtualDoVale";
            labelValorAtualDoVale.Size = new Size(106, 15);
            labelValorAtualDoVale.TabIndex = 6;
            labelValorAtualDoVale.Text = "Valor atual do vale:";
            // 
            // labelValorAtualValor
            // 
            labelValorAtualValor.AutoSize = true;
            labelValorAtualValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelValorAtualValor.ForeColor = Color.FromArgb(102, 187, 106);
            labelValorAtualValor.Location = new Point(20, 178);
            labelValorAtualValor.Name = "labelValorAtualValor";
            labelValorAtualValor.Size = new Size(49, 15);
            labelValorAtualValor.TabIndex = 5;
            labelValorAtualValor.Text = "R$ 0,00";
            // 
            // labelDescricaoVale
            // 
            labelDescricaoVale.AutoSize = true;
            labelDescricaoVale.Location = new Point(20, 210);
            labelDescricaoVale.Name = "labelDescricaoVale";
            labelDescricaoVale.Size = new Size(99, 15);
            labelDescricaoVale.TabIndex = 4;
            labelDescricaoVale.Text = "Descrição do Vale";
            // 
            // textBoxDescricaoVale
            // 
            textBoxDescricaoVale.BorderStyle = BorderStyle.FixedSingle;
            textBoxDescricaoVale.Location = new Point(20, 228);
            textBoxDescricaoVale.Multiline = true;
            textBoxDescricaoVale.Name = "textBoxDescricaoVale";
            textBoxDescricaoVale.ReadOnly = true;
            textBoxDescricaoVale.ScrollBars = ScrollBars.Vertical;
            textBoxDescricaoVale.Size = new Size(240, 100);
            textBoxDescricaoVale.TabIndex = 3;
            // 
            // TelaVerificarVales
            // 
            ClientSize = new Size(280, 350);
            Controls.Add(textBoxDescricaoVale);
            Controls.Add(labelDescricaoVale);
            Controls.Add(labelValorAtualValor);
            Controls.Add(labelValorAtualDoVale);
            Controls.Add(comboBoxValesDoMotoqueiro);
            Controls.Add(labelListaDeVales);
            Controls.Add(checkBoxMostrarValesPago);
            Controls.Add(comboBoxMotoqueiros);
            Controls.Add(labelMotoqueiro);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaVerificarVales";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Verificar Vales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMotoqueiro;
        private ComboBox comboBoxMotoqueiros;
        private CheckBox checkBoxMostrarValesPago;
        private Label labelListaDeVales;
        private ComboBox comboBoxValesDoMotoqueiro;
        private Label labelValorAtualDoVale;
        private Label labelValorAtualValor;
        private Label labelDescricaoVale;
        public TextBox textBoxDescricaoVale;
    }
}