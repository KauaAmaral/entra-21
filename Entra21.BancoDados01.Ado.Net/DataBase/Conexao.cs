using System.Data.SqlClient;

namespace Entra21.BancoDados01.Ado.Net.DataBase
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {
            // Instanciado um objeto da classe SqlConnection, que permitira fazer selects, inserts, updates, deletes, etc 
            SqlConnection conexao = new SqlConnection();

            // String quem contem o caminho para o banco de dados, o que permitira conectar ao banco de dados
            var connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\kaua.amaral\\source\\repos\\KauaAmaral\\entra-21\\Banco de Dados\\ExemploBancoDados01AdoNet.mdf\";Integrated Security=True;Connect Timeout=30";

            // Definir o caminho da conexao para o SqlConnection
            conexao.ConnectionString = connectionString;

            // Abrir a conexao com o banco de dados
            conexao.Open();

            return conexao;
        }
    }
}
