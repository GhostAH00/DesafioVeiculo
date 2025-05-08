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

            // Busca todos os ve�culos, incluindo os que j� sa�ram
            var veiculos = estacionamentoService.ListarVeiculosEstacionados();

            // Preenche o DataGridView com os dados
            foreach (var veiculo in veiculos)
            {
                string horaEntrada = veiculo.HoraEntrada.ToString("dd/MM/yyyy HH:mm");
                string horaSaida = veiculo.HoraSaida?.ToString("dd/MM/yyyy HH:mm") ?? "Ainda est� estacionado";
                string valor = veiculo.ValorPago.HasValue ? veiculo.ValorPago.Value.ToString("C2") : "Aguardando pagamento";
                string modelo = veiculo.Modelo;

                // Adiciona cada ve�culo no DataGridView
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
            CarregarVeiculosEstacionados();  // Chama o m�todo privado de carregamento de dados
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string termoBusca = txtBusca.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(termoBusca))
            {
                // Se n�o houver termo de busca, apenas recarregue todos os ve�culos
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
                    string horaSaida = veiculo.HoraSaida?.ToString("dd/MM/yyyy HH:mm") ?? "Ainda est� estacionado";
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
                MessageBox.Show("Nenhum ve�culo encontrado com essa placa ou modelo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar o campo de busca
            txtBusca.Text = "";

            // Chamar o m�todo para exibir todos os ve�culos
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
            FrmES frmES = new FrmES(this);  // Passa 'this', que � a inst�ncia de FrmVeiculo
            frmES.Show();
        }

        private void btnHist�rico_Click(object sender, EventArgs e)
        {
            FrmHistorico frm = new FrmHistorico();
            frm.Show();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
