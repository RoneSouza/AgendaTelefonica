using MySql.Data.MySqlClient;

namespace Agenda
{

    internal class Dall
    {
        string servidor = "localhost";
        string banco = "agenda";
        string usuario = "root";
        string senha = " ";
        public MySqlConnection conexao;

        public Dall()
        {
            string connectionString = $"Server = {servidor}; Database = {banco}; Uid = {usuario}; Pwd = {senha}";
            conexao = new MySqlConnection(connectionString);
            conexao.Open();

        }

    }

}