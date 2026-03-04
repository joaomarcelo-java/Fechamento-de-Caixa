using FechamentoCaixa.DataBase;
using FechamentoCaixa.Entities;
using FechamentoCaixa.Service;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FechamentoCaixaForms
{
    public partial class TelaBuscarMotoqueiro : Form
    {
        private readonly MotoqueiroService _motoqueiroService;

        public TelaBuscarMotoqueiro(MotoqueiroService motoqueiroService)
        {
            _motoqueiroService = motoqueiroService;
            InitializeComponent();
            CarregarMotoqueiros();
        }

        private void CarregarMotoqueiros()
        {
            comboMotoqueiro.DataSource = _motoqueiroService.ListarMotoqueiros();
            comboMotoqueiro.DisplayMember = "Nome";
        }

        private void comboMotoqueiro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMotoqueiro.SelectedItem is not Motoqueiro motoqueiro)
                return;

            AtualizarResumo(motoqueiro);
        }

        private void AtualizarResumo(Motoqueiro motoqueiro)
        {
            int entregas5 = _motoqueiroService.TotalEntregasDe5(motoqueiro.Id);
            int entregas7 = _motoqueiroService.TotalEntregasDe7(motoqueiro.Id);
            int entregas10 = _motoqueiroService.TotalEntregasDe10(motoqueiro.Id);

            labelEntregasDe5.Text = $"Entregas de R$5: {entregas5}";
            labelEntregasDe7.Text = $"Entregas de R$7: {entregas7}";
            labelEntregasDe10.Text = $"Entregas de R$10: {entregas10}";

            labelTotalEntregas.Text =
                $"Total de Entregas: {entregas5 + entregas7 + entregas10}";

            decimal totalFixo = _motoqueiroService.TotalFixoGanho(motoqueiro.Id);

            labelTotalFixoGanho.Text =
                $"Total Fixo Ganho: R$ {totalFixo:N2}";

            labelValeAtual.Text =
                $"Vale Atual: R$ {motoqueiro.Vale:N2}";
        }
    }
}
