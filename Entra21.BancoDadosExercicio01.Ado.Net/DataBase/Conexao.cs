using System.Data.SqlClient;

namespace Entra21.BancoDadosExercicio01.Ado.Net.DataBase
{
    internal class Conexao
    {
       public SqlConnection Conectar()
        {
            SqlConnection conexao = new SqlConnection();

            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kaua_\source\repos\KauaAmaral\entra-21\Entra21.BancoDadosExercicio01.Ado.Net\DataBase\BancoDadosExercicio01.mdf;Integrated Security=True;Connect Timeout=30";

            conexao.ConnectionString = connectionString;           
            
            conexao.Open();

            return conexao;
        }
    }
}
