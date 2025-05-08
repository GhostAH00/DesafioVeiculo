using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using VeiculoClass.Estacionamento.Classes;

namespace VeiculoDesk
{
    public partial class FrmHistorico : Form
    {
        private EstacionamentoService estacionamentoService;
        public FrmHistorico()
        {
            InitializeComponent();
            estacionamentoService = new EstacionamentoService();
        }

        private void FrmHistorico_Load(object sender, EventArgs e)
        {
            CarregarHistorico();
        }
        private void CarregarHistorico()
        {
            dgvHistorico.Rows.Clear(); // Limpa o grid antes de preencher

            var historico = estacionamentoService.ListarHistorico(); // Busca apenas os que já saíram

            foreach (var mov in historico)
            {
                string entrada = mov.HoraEntrada.ToString("dd/MM/yyyy HH:mm");
                string saida = mov.HoraSaida?.ToString("dd/MM/yyyy HH:mm") ?? "-";
                string valor = mov.ValorPago?.ToString("C2") ?? "-";

                dgvHistorico.Rows.Add(
                    mov.Id,
                    mov.Placa,
                    mov.Modelo,
                    entrada,
                    saida,
                    valor
                );
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            string termoBusca = txtBusca.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(termoBusca))
            {
                // Se não houver termo de busca, apenas recarregue todos os veículos

                return;
            }

            var veiculos = estacionamentoService.BuscarVeiculos(termoBusca);

            dgvHistorico.Rows.Clear();

            if (veiculos.Count > 0)
            {
                foreach (var veiculo in veiculos)
                {
                    string horaEntrada = veiculo.HoraEntrada.ToString("dd/MM/yyyy HH:mm");
                    string horaSaida = veiculo.HoraSaida?.ToString("dd/MM/yyyy HH:mm") ?? "Ainda está estacionado";
                    string valor = veiculo.ValorPago.HasValue ? veiculo.ValorPago.Value.ToString("C2") : "Aguardando pagamento";
                    string modelo = veiculo.Modelo;

                    dgvHistorico.Rows.Add(
                        veiculo.Id,
                        veiculo.Placa,
                        modelo,
                        horaEntrada,
                        horaSaida,
                        valor
                    );
                }
            }
            else
            {
                MessageBox.Show("Nenhum veículo encontrado com essa placa ou modelo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar o campo de busca
            txtBusca.Text = "";
        }

        private void btnFiltrarPorData_Click(object sender, EventArgs e)
        {
            DateTime dataSelecionada = hopeDatePicker1.Date;

            var historico = estacionamentoService.ListarHistoricoPorData(dataSelecionada);

            dgvHistorico.Rows.Clear();

            if (historico.Count == 0)
            {
                MessageBox.Show("Nenhum registro encontrado para esta data.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var mov in historico)
            {
                dgvHistorico.Rows.Add(
                    mov.Id,
                    mov.Placa,
                    mov.Modelo,
                    mov.HoraEntrada.ToString("dd/MM/yyyy HH:mm"),
                    mov.HoraSaida?.ToString("dd/MM/yyyy HH:mm") ?? "-",
                    mov.ValorPago?.ToString("C2") ?? "-"
                );
            }
        }
    }  
}