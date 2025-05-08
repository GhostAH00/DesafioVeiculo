using MySql.Data.MySqlClient;

namespace VeiculoClass
{
    // Esta classe vai ser responsável por conectar ao banco de dados MySQL
    public class BancoDeDados
    {       
        // Método para abrir uma conexão com o banco de dados
        public static MySqlCommand Abrir()
        {
            MySqlCommand cmd = new(); // Cria um objeto do tipo MySqlCommand, que vai executar comandos no banco de dados

            // Aqui está a string de conexão, onde configuramos as informações para conectar ao banco de dados
            // O formato da string de conexão: "server=ENDEREÇO_DO_SERVIDOR;database=NOME_DO_BANCO;user=USUÁRIO;password=SENHA"

            string strConn = @"server=127.0.0.1;database=Dveiculobd;user=root;password="; // meu servidor local

            // Cria uma conexão com o banco usando a string de conexão que criamos
            MySqlConnection cn = new(strConn);
            try
            {
                // Tenta abrir a conexão com o banco de dados
                cn.Open();

                // Se a conexão foi bem-sucedida, a conexão é associada ao comando (cmd)
                cmd.Connection = cn;
            }
            catch (Exception ex)
            {
                // Se houver algum erro ao tentar se conectar, ele será mostrado no console
                Console.WriteLine(ex.Message);
            }
            // O comando MySqlCommand é retornado, e será usado posteriormente para enviar comandos SQL ao banco
            return cmd;
        }
    }
}
