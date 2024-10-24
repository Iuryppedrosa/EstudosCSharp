using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotenv.net;

namespace UdemyCourseInicio.Inicio.Repository
{
    public class Conexoes
    {
        public void criandoConexao()
        {


            //DotEnv.Load();
            string connectionString = "Server=localhost;Database=sistemas_de_banco_de_dados;Uid=root;Pwd=";



            if (string.IsNullOrEmpty(connectionString))
            {
                Console.WriteLine("Erro: Variável de ambiente SQL_CONNECTION não encontrada.");
                return;
            }

            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexão aberta!");

                    // Query SQL que deseja executar
                    string query = "SELECT * FROM aluno";

                    // Criando o comando MySql
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Executando o comando e lendo os dados
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Verificando se há linhas para ler
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            { 
                                // Exemplo: pegando dados da primeira coluna (ajuste conforme sua tabela)
                                Console.WriteLine($"{reader.GetString(0)} - {reader.GetString(1)} - {reader.GetString(2)} - {reader.GetDecimal(3)}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao abrir conexão: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                    Console.WriteLine("Conexão fechada!");
                }
            }

        }
        
    }
}
