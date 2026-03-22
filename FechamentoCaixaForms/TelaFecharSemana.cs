using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FechamentoCaixa.DataBase;
using FechamentoCaixa.Entities;
using FechamentoCaixa.Service;

namespace FechamentoCaixaForms
{
    public partial class TelaFecharSemana : Form
    {
        private readonly FechamentoFinalService _fechamentoFinalService;
        private readonly MotoqueiroService _motoqueiroService;
        private readonly ValesService _valesService;
        public TelaFecharSemana(FechamentoFinalService fechamentoFinalService, MotoqueiroService motoqueiroService, ValesService valesService)
        {
            _fechamentoFinalService = fechamentoFinalService;
            _motoqueiroService = motoqueiroService;   
            _valesService = valesService;
            InitializeComponent();
        }

        private void TelaFecharSemana_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
        }

        // =========================
        // CONFIGURA GRID
        // =========================

        private void ConfigurarGrid()
        {
            dataGridResumo.AutoGenerateColumns = false;
            dataGridResumo.Columns.Clear();
            dataGridResumo.RowHeadersVisible = false;

            dataGridResumo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NomeMotoqueiro",
                HeaderText = "Motoqueiro"
            });

            dataGridResumo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalEntrega5",
                HeaderText = "Entrega 5"
            });

            dataGridResumo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalEntrega7",
                HeaderText = "Entrega 7"
            });

            dataGridResumo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalEntrega10",
                HeaderText = "Entrega 10"
            });

            dataGridResumo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalFixo",
                HeaderText = "Fixo",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dataGridResumo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalPeriodo",
                HeaderText = "Total Período",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dataGridResumo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridResumo.ReadOnly = true;
            dataGridResumo.AllowUserToAddRows = false;
            dataGridResumo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Estilo opcional
            dataGridResumo.EnableHeadersVisualStyles = false;
            dataGridResumo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dataGridResumo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridResumo.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        // =========================
        // BOTÃO ATUALIZAR
        // =========================

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try {
                    var resumo = _fechamentoFinalService.ObterFechamentosPeriodo(
                        DateOnly.FromDateTime(dateTimeInicio.Value),
                        DateOnly.FromDateTime(dateTimeFim.Value));

                    dataGridResumo.DataSource = resumo;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        // =========================
        // BOTÃO FECHAR SEMANA
        // =========================

        private void btnFechar_Click(object sender, EventArgs e)
        {
            try
            {
                DateOnly inicio = DateOnly.FromDateTime(dateTimeInicio.Value);
                DateOnly final = DateOnly.FromDateTime(dateTimeFim.Value);

                var resumo = _fechamentoFinalService.ObterFechamentosPeriodo(inicio, final);
                _fechamentoFinalService.VerificarFechamentoExistente(inicio, final);
                
                var tela = new TelaDescontarFechamento(resumo, _motoqueiroService, _valesService);
                tela.ShowDialog();
                var itens = tela.fechamentoFinalItems;

                if (itens.Count == 0)
                {
                    MessageBox.Show("Nenhum fechamento foi realizado.");
                    return;
                }

                _fechamentoFinalService.SalvarFechamentoFinal(inicio, final, itens);

                MessageBox.Show("Fechamento final realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
