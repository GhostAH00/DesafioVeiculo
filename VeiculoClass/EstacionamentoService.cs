using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiculoClass
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;

    namespace Estacionamento.Classes
    {
        // Classe que contém os serviços de estacionamento (entrada, saída, consultas)
        public class EstacionamentoService
        {
            // Função para registrar a entrada de um veículo
            public bool RegistrarEntrada(Veiculo veiculo)
            {
                // Verifica se já existe um veículo com a mesma placa estacionado
                if (BuscarVeiculoEstacionado(veiculo.Placa) != null)
                    return false; // Se já estiver estacionado, não faz a entrada e retorna false

                // Abre a conexão com o banco de dados
                var cmd = BancoDeDados.Abrir();

                // Comando SQL para inserir os dados de entrada do veículo no banco
                cmd.CommandText = @"INSERT INTO movimentacoes 
                (placa, modelo, hora_entrada) 
                VALUES (@placa, @modelo, @entrada)";

                // Passa os dados do veículo como parâmetros para a consulta
                cmd.Parameters.AddWithValue("@placa", veiculo.Placa);
                cmd.Parameters.AddWithValue("@modelo", veiculo.Modelo);
                cmd.Parameters.AddWithValue("@entrada", veiculo.HoraEntrada);

                // Executa o comando no banco de dados e retorna true se a operação for bem-sucedida
                return cmd.ExecuteNonQuery() == 1;
            }

            // Função para registrar a saída de um veículo
            public bool RegistrarSaida(string placa, decimal valorPago)
            {
                // Busca o veículo que está estacionado usando a placa
                var movimentacao = BuscarVeiculoEstacionado(placa);
                if (movimentacao == null) return false; // Se o veículo não for encontrado, retorna false

                // Obtém a hora atual como hora de saída
                DateTime horaSaida = DateTime.Now;

                // Abre a conexão com o banco de dados
                var cmd = BancoDeDados.Abrir();

                // Comando SQL para atualizar a hora de saída e o valor pago no banco
                cmd.CommandText = @"UPDATE movimentacoes SET 
                 hora_saida = @saida, valor_pago = @valor 
                WHERE id = @id";

                // Passa os dados da saída para o comando SQL
                cmd.Parameters.AddWithValue("@saida", horaSaida);
                cmd.Parameters.AddWithValue("@valor", valorPago);
                cmd.Parameters.AddWithValue("@id", movimentacao.Id);

                // Executa o comando no banco de dados e retorna true se a operação for bem-sucedida
                return cmd.ExecuteNonQuery() == 1;
            }

            // Função para listar todos os veículos que ainda estão estacionados
            public List<Movimentacao> ListarVeiculosEstacionados()
            {
                List<Movimentacao> lista = new List<Movimentacao>(); // Lista para armazenar os veículos estacionados

                // Abre a conexão com o banco de dados
                var cmd = BancoDeDados.Abrir();

                // Comando SQL para buscar veículos que ainda estão estacionados (hora_saida é NULL)
                cmd.CommandText = "SELECT * FROM movimentacoes WHERE hora_saida IS NULL ORDER BY id";

                // Executa a consulta no banco e armazena os resultados no "reader"
                var reader = cmd.ExecuteReader();

                // Para cada registro encontrado, cria um objeto Movimentacao e adiciona à lista
                while (reader.Read())
                {
                    lista.Add(new Movimentacao
                    {
                        Id = reader.GetInt32("id"),
                        Placa = reader.GetString("placa"),
                        Modelo = reader.GetString("modelo"),
                        HoraEntrada = reader.GetDateTime("hora_entrada"),
                        HoraSaida = null,  // Sabemos que é null porque estamos filtrando apenas os que ainda estão estacionados
                        ValorPago = null   // Também será null porque ainda não pagaram
                    });
                }

                return lista; // Retorna a lista de veículos estacionados
            }

            // Função para buscar um veículo que está estacionado, usando a placa
            public Movimentacao? BuscarVeiculoEstacionado(string placa)
            {
                // Abre a conexão com o banco de dados
                var cmd = BancoDeDados.Abrir();

                // Comando SQL para buscar o veículo pela placa, considerando que ele ainda está estacionado (hora_saida é NULL)
                cmd.CommandText = "SELECT * FROM movimentacoes WHERE placa = @placa AND hora_saida IS NULL";
                cmd.Parameters.AddWithValue("@placa", placa);

                // Executa a consulta no banco
                var reader = cmd.ExecuteReader();

                // Se encontrar o veículo estacionado, cria e retorna o objeto Movimentacao
                if (reader.Read())
                {
                    return new Movimentacao
                    {
                        Id = reader.GetInt32("id"),
                        Placa = reader.GetString("placa"),
                        Modelo = reader.GetString("modelo"),
                        HoraEntrada = reader.GetDateTime("hora_entrada")
                    };
                }

                return null; // Se não encontrar, retorna null
            }

            // Função para buscar veículos por parte da placa ou do modelo (inclui veículos que já saíram)
            public List<Movimentacao> BuscarVeiculos(string termo)
            {
                List<Movimentacao> lista = new List<Movimentacao>(); // Lista para armazenar os veículos encontrados

                // Abre a conexão com o banco de dados
                var cmd = BancoDeDados.Abrir();

                // Comando SQL para buscar veículos com a placa ou modelo que contém o termo
                cmd.CommandText = @"
                SELECT * FROM movimentacoes 
                WHERE placa LIKE @termo OR modelo LIKE @termo
                ORDER BY id ASC";
                cmd.Parameters.AddWithValue("@termo", "%" + termo + "%");

                // Executa a consulta e armazena os resultados no "reader"
                var reader = cmd.ExecuteReader();

                // Para cada registro encontrado, cria um objeto Movimentacao e adiciona à lista
                while (reader.Read())
                {
                    lista.Add(new Movimentacao
                    {
                        Id = reader.GetInt32("id"),
                        Placa = reader.GetString("placa"),
                        Modelo = reader.GetString("modelo"),
                        HoraEntrada = reader.GetDateTime("hora_entrada"),
                        HoraSaida = reader.IsDBNull(reader.GetOrdinal("hora_saida")) ? (DateTime?)null : reader.GetDateTime("hora_saida"),
                        ValorPago = reader.IsDBNull(reader.GetOrdinal("valor_pago")) ? (decimal?)null : reader.GetDecimal("valor_pago")
                    });
                }

                return lista; // Retorna a lista de veículos encontrados
            }

            // Função para listar o histórico de veículos (somente quem já saiu)
            public List<Movimentacao> ListarHistorico()
            {
                List<Movimentacao> lista = new List<Movimentacao>(); // Lista para armazenar o histórico de veículos

                // Abre a conexão com o banco de dados
                var cmd = BancoDeDados.Abrir();

                // Comando SQL para buscar veículos que já saíram (hora_saida não é NULL)
                cmd.CommandText = "SELECT * FROM movimentacoes WHERE hora_saida IS NOT NULL ORDER BY hora_saida DESC";

                // Executa a consulta e armazena os resultados no "reader"
                var reader = cmd.ExecuteReader();

                // Para cada registro encontrado, cria um objeto Movimentacao e adiciona ao histórico
                while (reader.Read())
                {
                    lista.Add(new Movimentacao
                    {
                        Id = reader.GetInt32("id"),
                        Placa = reader.GetString("placa"),
                        Modelo = reader.GetString("modelo"),
                        HoraEntrada = reader.GetDateTime("hora_entrada"),
                        HoraSaida = reader.GetDateTime("hora_saida"),
                        ValorPago = reader.GetDecimal("valor_pago")
                    });
                }

                return lista; // Retorna o histórico completo de veículos que saíram
            }

            // Função para listar o histórico de veículos por data
            public List<Movimentacao> ListarHistoricoPorData(DateTime data)
            {
                List<Movimentacao> lista = new List<Movimentacao>(); // Lista para armazenar o histórico de veículos por data

                // Abre a conexão com o banco de dados
                var cmd = BancoDeDados.Abrir();

                // Comando SQL para buscar veículos que saíram em uma data específica
                cmd.CommandText = @"
                SELECT * FROM movimentacoes 
                WHERE hora_saida IS NOT NULL AND DATE(hora_saida) = @data 
                ORDER BY hora_saida DESC";
                cmd.Parameters.AddWithValue("@data", data.Date);

                // Executa a consulta e armazena os resultados no "reader"
                var reader = cmd.ExecuteReader();

                // Para cada registro encontrado, cria um objeto Movimentacao e adiciona ao histórico
                while (reader.Read())
                {
                    lista.Add(new Movimentacao
                    {
                        Id = reader.GetInt32("id"),
                        Placa = reader.GetString("placa"),
                        Modelo = reader.GetString("modelo"),
                        HoraEntrada = reader.GetDateTime("hora_entrada"),
                        HoraSaida = reader.GetDateTime("hora_saida"),
                        ValorPago = reader.GetDecimal("valor_pago")
                    });
                }

                return lista; // Retorna o histórico dos veículos que saíram na data fornecida
            }
        }
    }
}
