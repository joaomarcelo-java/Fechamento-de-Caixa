using FechamentoCaixa.Entities;
using FechamentoCaixa.Service;

namespace FechamentoCaixaForms
{
    public partial class TelaCadastroMotoqueiro : Form
    {
        private readonly MotoqueiroService _motoqueiroService;
        public Motoqueiro MotoqueiroCriado { get; private set; }

        public TelaCadastroMotoqueiro(MotoqueiroService motoqueiroService)
        {
            InitializeComponent();
            _motoqueiroService = motoqueiroService;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Motoqueiro Moto = new Motoqueiro
                {
                    Nome = textBoxNome.Text.Trim(),
                    Extra = checkBoxExtra.Checked
                };
                _motoqueiroService.AdicionarMotoqueiro(Moto);
                MotoqueiroCriado = Moto;
                MessageBox.Show("Motoqueiro salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
