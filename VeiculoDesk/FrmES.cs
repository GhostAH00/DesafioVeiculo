using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeiculoClass;
using VeiculoClass.Estacionamento.Classes;

namespace VeiculoDesk
{
    public partial class FrmES : Form
    {
        private EstacionamentoService estacionamentoService;
        private FrmVeiculo FrmVeiculo;

        // Construtor da tela. Ao criar a tela FrmES, ela precisa de uma referência da tela FrmVeiculo.
        public FrmES(FrmVeiculo frmVeiculo)
        {
            InitializeComponent();
            this.FrmVeiculo = frmVeiculo;  // Guarda a referência da tela FrmVeiculo
            estacionamentoService = new EstacionamentoService(); // Cria um objeto para acessar o serviço de estacionamento
        }

        // Método para registrar a entrada de um veículo no estacionamento
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.Trim().ToUpper();
            string modelo = txtModelo.Text.Trim();

            if (string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(modelo))
            {
                MessageBox.Show("Por favor, preencha os campos de placa e modelo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Criando o veículo e registrando a entrada
            Veiculo novoVeiculo = new Veiculo
            {
                Placa = placa,
                Modelo = modelo,
                HoraEntrada = DateTime.Now  // Hora de entrada automática
            };

            bool registrado = estacionamentoService.RegistrarEntrada(novoVeiculo);

            if (registrado)
            {
                MessageBox.Show("Veículo registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza o dgvVeiculo na tela FrmVeiculo após o registro
                FrmVeiculo.AtualizarTabela();  // Chama o método de atualização de FrmVeiculo

                txtPlaca.Text = "";
                txtModelo.Text = "";
            }
            else
            {
                MessageBox.Show("Falha ao registrar o veículo. Ele pode já estar estacionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para carregar os veículos que estão estacionados
        public void CarregarVeiculosEstacionados()
        {
            string placa = txtPlaca.Text.Trim().ToUpper(); // Pega a placa
            string modelo = txtModelo.Text.Trim(); // Pega o modelo

            // Verifica se os campos foram preenchidos
            if (string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(modelo))
            {
                MessageBox.Show("Por favor, preencha os campos de placa e modelo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cria um novo veículo com as informações de placa, modelo e hora de entrada
            Veiculo novoVeiculo = new Veiculo
            {
                Placa = placa,
                Modelo = modelo,
                HoraEntrada = DateTime.Now  // A hora de entrada é a hora atual
            };

            bool registrado = estacionamentoService.RegistrarEntrada(novoVeiculo);

            if (registrado)
            {
                MessageBox.Show("Veículo registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza os veículos estacionados na tela FrmVeiculo
                FrmVeiculo.CarregarVeiculosEstacionados();  // Atualiza a lista de veículos estacionados
            }
            else
            {
                MessageBox.Show("Falha ao registrar o veículo. Ele pode já estar estacionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para calcular o valor do estacionamento baseado no tempo
        private void btnPagar_Click(object sender, EventArgs e)
        {
            string placa = TxtSaidaPlaca.Text.Trim().ToUpper();  // Pega a placa do veículo
            var veiculo = estacionamentoService.BuscarVeiculoEstacionado(placa);  // Busca o veículo pelo número da placa

            // Se não encontrar o veículo estacionado, mostra um erro
            if (veiculo == null)
            {
                MessageBox.Show("Veículo não encontrado ou já saiu.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime horaEntrada = veiculo.HoraEntrada;  // Hora de entrada do veículo
            DateTime horaSaida = DateTime.Now;  // A hora de saída é a hora atual

            // Calcula o tempo que o veículo ficou estacionado
            TimeSpan tempoEstacionado = horaSaida - horaEntrada;
            int minutos = (int)tempoEstacionado.TotalMinutes;  // Converte o tempo em minutos

            // Converte os minutos para horas, arredondando para cima
            int horas = minutos > 0 ? (int)Math.Ceiling(minutos / 60.0) : 0;

            // Se o tempo for muito pequeno, mostra um erro
            if (horas <= 0)
            {
                MessageBox.Show("O tempo de estacionamento é muito pequeno. Verifique se o valor de entrada e saída estão corretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcula o valor a pagar (R$5,00 por hora)
            decimal valorPago = horas * 5m;

            // Exibe o valor formatado como moeda
            txtValor.Text = valorPago.ToString("C2");
        }

        // Método para emitir o recibo de pagamento
        private void btnRecibo_Click(object sender, EventArgs e)
        {
            string placa = TxtSaidaPlaca.Text.Trim();  // Pega a placa
            if (string.IsNullOrEmpty(placa))  // Se a placa estiver vazia, exibe uma mensagem
            {
                MessageBox.Show("Por favor, insira a placa do veículo.");
                return;
            }

            string valorStr = txtValor.Text.Trim();  // Pega o valor pago

            decimal valorPago;
            // Verifica se o valor está correto
            if (!decimal.TryParse(valorStr, NumberStyles.Currency, new CultureInfo("pt-BR"), out valorPago))
            {
                MessageBox.Show("Valor inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirma o pagamento
            MessageBox.Show($"Placa: {placa}\nValor a pagar: {valorPago:C}", "Confirmação");

            // Registra a saída do veículo
            bool sucesso = estacionamentoService.RegistrarSaida(placa, valorPago);

            if (sucesso)
            {
                MessageBox.Show($"Pagamento recebido com sucesso!\n\n" +
                                 $"Placa: {placa}\n" +
                                 $"Valor Pago: {valorPago:C}\n" +
                                 $"Hora de Saída: {DateTime.Now:HH:mm:ss}\n\n" +
                                 "Obrigado por utilizar nosso estacionamento!");

                // Limpa os campos após o pagamento
                TxtSaidaPlaca.Text = "";
                txtValor.Text = "";
                txtNumVaga.Text = "";

                // Libera a vaga - Só um teste
                string numVaga = txtNumVaga.Text.Trim(); // pega antes de limpar

                foreach (Control ctrl in pnlMapsVagas.Controls)
                {
                    if (ctrl is Button btn && btn.Text == numVaga)
                    {
                        btn.BackColor = SystemColors.Control;
                        btn.Enabled = true;
                        break;
                    }
                }

                // Agora sim, limpa os campos
                TxtSaidaPlaca.Text = "";
                txtValor.Text = "";
                txtNumVaga.Text = "";
            }
            else
            {
                MessageBox.Show("Não foi possível processar o pagamento. O veículo pode já ter saído ou não estar registrado.");
            }
        }

        // O valor do pagamento não pode ser editado
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            txtValor.ReadOnly = true;
        }

        private void txtNumVaga_TextChanged(object sender, EventArgs e)
        {
            txtNumVaga.ReadOnly = true;
        }

        // Método para estacionar o veículo, registrando a vaga
        private void btnEstacionar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.Trim();  // Pega a placa
            string modelo = txtModelo.Text.Trim();  // Pega o modelo
            string numVaga = txtNumVaga.Text.Trim();  // Pega o número da vaga

            // Verifica se todos os campos estão preenchidos
            if (string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(numVaga))
            {
                MessageBox.Show("Por favor, preencha os campos de placa, modelo e selecione uma vaga.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cria um novo veículo
            Veiculo novoVeiculo = new Veiculo
            {
                Placa = placa,
                Modelo = modelo,
                HoraEntrada = DateTime.Now  // Hora de entrada
            };

            // testando...
            bool registrado = estacionamentoService.RegistrarEntrada(novoVeiculo);
            if (registrado)
            {
                // Atualiza a cor da vaga
                MessageBox.Show($"Veículo estacionado na vaga {numVaga}.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Muda a cor da vaga para indicar que está ocupada
                foreach (Control ctrl in pnlMapsVagas.Controls)
                {
                    if (ctrl is Button btn && btn.Text == numVaga)
                    {
                        btn.BackColor = Color.Gray;  // Indica que a vaga foi ocupada
                        btn.Enabled = false;  // Desabilita o botão da vaga
                        break;
                    }
                }
                // Limpa os campos
                txtNumVaga.Text = "";
                TxtSaidaPlaca.Text = "";
                txtValor.Text = "";

            }
            else
            {
                MessageBox.Show("Falha ao estacionar o veículo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método que verifica a vaga ao clicar em um botão - Teste
        private void btnVaga1_Click_1(object sender, EventArgs e)
        {
            // Recupera o botão da vaga
            Button btnVaga = sender as Button;

            if (btnVaga != null)
            {
                // Verifica se a vaga já está ocupada
                if (btnVaga.BackColor == Color.Gray)
                {
                    MessageBox.Show("Esta vaga já está ocupada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;  // Se já estiver ocupada, sai do método
                }

                // Define o número da vaga no campo de texto
                txtNumVaga.Text = btnVaga.Text;
                txtNumVaga.ReadOnly = true;  // Não pode mais editar o campo

                // Muda a cor da vaga para mostrar que foi escolhida
                btnVaga.BackColor = Color.Gray;
                btnVaga.Enabled = false;  // Desabilita a vaga escolhida
            }
        }

        private void btnVaga2_Click(object sender, EventArgs e)
        {
            txtNumVaga.Text = btnVaga2.Text;
            txtNumVaga.ReadOnly = true;
            btnVaga1.BackColor = Color.Gray;
            btnVaga1.Enabled = false;
        }
        private void btnVaga3_Click(object sender, EventArgs e)
        {
            txtNumVaga.Text = btnVaga3.Text;
            txtNumVaga.ReadOnly = true;
            btnVaga1.BackColor = Color.Gray;
            btnVaga1.Enabled = false;
        }
        private void btnVaga4_Click(object sender, EventArgs e)
        {
            txtNumVaga.Text = btnVaga4.Text;
            txtNumVaga.ReadOnly = true;
            btnVaga1.BackColor = Color.Gray;
            btnVaga1.Enabled = false;
        }
        private void btnVaga5_Click(object sender, EventArgs e)
        {
            txtNumVaga.Text = btnVaga5.Text;
            txtNumVaga.ReadOnly = true;
            btnVaga1.BackColor = Color.Gray;
            btnVaga1.Enabled = false;
        }
        private void btnVaga6_Click(object sender, EventArgs e)
        {
            txtNumVaga.Text = btnVaga6.Text;
            txtNumVaga.ReadOnly = true;
            btnVaga1.BackColor = Color.Gray;
            btnVaga1.Enabled = false;
        }
        private void btnVaga7_Click(object sender, EventArgs e)
        {
            txtNumVaga.Text = btnVaga7.Text;
            txtNumVaga.ReadOnly = true;
            btnVaga1.BackColor = Color.Gray;
            btnVaga1.Enabled = false;
        }
        private void btnVaga8_Click(object sender, EventArgs e)
        {
            txtNumVaga.Text = btnVaga8.Text;
            txtNumVaga.ReadOnly = true;
            btnVaga1.BackColor = Color.Gray;
            btnVaga1.Enabled = false;
        }
        private void btnVaga9_Click(object sender, EventArgs e)
        {
            txtNumVaga.Text = btnVaga9.Text;
            txtNumVaga.ReadOnly = true;
            btnVaga1.BackColor = Color.Gray;
            btnVaga1.Enabled = false;
        }
        private void btnVaga10_Click(object sender, EventArgs e)
        {
            txtNumVaga.Text = btnVaga10.Text;
            txtNumVaga.ReadOnly = true;
            btnVaga1.BackColor = Color.Gray;
            btnVaga1.Enabled = false;
        }

        private void FrmES_Load(object sender, EventArgs e)
        {

        }
    }
}