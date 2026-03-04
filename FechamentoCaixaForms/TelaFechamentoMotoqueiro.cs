using FechamentoCaixa.Service;
using FechamentoCaixa.Entities;

namespace FechamentoCaixaForms
{
    public partial class TelaFechamentoMotoqueiro : Form
    {
        private readonly MotoqueiroService _motoqueiroService;
        private readonly FechamentoDiaService _fechamentoService;
        public TelaFechamentoMotoqueiro(MotoqueiroService motoqueiroService, FechamentoDiaService fechamentoService)
        {
            _motoqueiroService = motoqueiroService;
            _fechamentoService = fechamentoService;
            InitializeComponent();
            AplicarSelectAll(this);

            CarregarMotoqueiros();
        }
        private void AplicarSelectAll(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox txt)
                {
                    txt.Enter += (s, e) => txt.SelectAll();
                }

                if (control is NumericUpDown numeric)
                {
                    numeric.Enter += (s, e) =>
                    {
                        numeric.Select(0, numeric.Text.Length);
                    };
                }

                if (control.HasChildren)
                {
                    AplicarSelectAll(control);
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CarregarMotoqueiros()
        {
            var motoqueiros = _motoqueiroService.ListarMotoqueiros();
            comboBoxEscolherMotoqueiro.DataSource = motoqueiros;
            comboBoxEscolherMotoqueiro.DisplayMember = "Nome";
            comboBoxEscolherMotoqueiro.ValueMember = "Id";
            comboBoxEscolherMotoqueiro.SelectedIndex = -1;
        }

        public FechamentoDia ObterFechamentoTela()
        {
            if(comboBoxEscolherMotoqueiro.SelectedItem is not Motoqueiro motoqueiroSelecionado)
            {
                throw new InvalidOperationException("Nenhum motoqueiro foi selecionado.");
            }
            return new FechamentoDia
            {
                MotoqueiroId = motoqueiroSelecionado.Id,
                Data = DateOnly.FromDateTime(dateTimePicker1.Value),
                Entrega5 = (int)numericUpDown1.Value,
                Entrega7 = (int)numericUpDown2.Value,
                Entrega10 = (int)numericUpDown3.Value,
                ValorFixo = numericValorFixo.Value,
                Desconto = numericDesconto.Value
            };
        }

        public void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var fechamento = ObterFechamentoTela();
                _fechamentoService.FecharDiaMotoqueiro(fechamento);
                
                    MessageBox.Show("Fechamento salvo com sucesso!");
                    DialogResult = DialogResult.OK;
                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
