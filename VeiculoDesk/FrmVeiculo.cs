using VeiculoClass;
using VeiculoClass.Estacionamento.Classes;

namespace VeiculoDesk
{

    public partial class FrmVeiculo : Form
    {
        private EstacionamentoService estacionamentoService;
        public FrmVeiculo()
        {
            InitializeComponent();
            estacionamentoService = new EstacionamentoService();
        }



        private void FrmVeiculo_Load(object sender, EventArgs e)
        {
            CarregarVeiculosEstacionados();

        }
        public void CarregarVeiculosEstacionados()
        {
            dgvVeiculo.Rows.Clear();  // Limpa todas as linhas do DataGridView antes de adicionar os novos dados

            // Busca todos os veículos, incluindo os que já saíram
            var veiculos = estacionamentoService.ListarVeiculosEstacionados();

            // Preenche o DataGridView com os dados
            foreach (var veiculo in veiculos)
            {
                string horaEntrada = veiculo.HoraEntrada.ToString("dd/MM/yyyy HH:mm");
                string horaSaida = veiculo.HoraSaida?.ToString("dd/MM/yyyy HH:mm") ?? "Ainda está estacionado";
                string valor = veiculo.ValorPago.HasValue ? veiculo.ValorPago.Value.ToString("C2") : "Aguardando pagamento";
                string modelo = veiculo.Modelo;

                // Adiciona cada veículo no DataGridView
                dgvVeiculo.Rows.Add(
                    veiculo.Id,
                    veiculo.Placa,
                    modelo,
                    horaEntrada,
                    horaSaida,
                    valor
                );
            }
        }

        public void AtualizarTabela()
        {
            CarregarVeiculosEstacionados();  // Chama o método privado de carregamento de dados
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string termoBusca = txtBusca.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(termoBusca))
            {
                // Se não houver termo de busca, apenas recarregue todos os veículos
                CarregarVeiculosEstacionados();
                return;
            }

            var veiculos = estacionamentoService.BuscarVeiculos(termoBusca);

            dgvVeiculo.Rows.Clear();

            if (veiculos.Count > 0)
            {
                foreach (var veiculo in veiculos)
                {
                    string horaEntrada = veiculo.HoraEntrada.ToString("dd/MM/yyyy HH:mm");
                    string horaSaida = veiculo.HoraSaida?.ToString("dd/MM/yyyy HH:mm") ?? "Ainda está estacionado";
                    string valor = veiculo.ValorPago.HasValue ? veiculo.ValorPago.Value.ToString("C2") : "Aguardando pagamento";
                    string modelo = veiculo.Modelo;

                    dgvVeiculo.Rows.Add(
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

            // Chamar o método para exibir todos os veículos
            CarregarVeiculosEstacionados();
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnES_Click(object sender, EventArgs e)
        {
            FrmES frmES = new FrmES(this);  // Passa 'this', que é a instância de FrmVeiculo
            frmES.Show();
        }

        private void btnHistórico_Click(object sender, EventArgs e)
        {
            FrmHistorico frm = new FrmHistorico();
            frm.Show();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
