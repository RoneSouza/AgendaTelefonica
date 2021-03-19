using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Agenda
{
    class AgendaBll
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Dall obj;
        private DataTable dataTable;



        public void Adicionar_Contato(string nome, string telefone)
        {
            obj = new Dall();

            string sql = $"insert into contatos(Nome, Telefone) values ('{nome}', '{telefone}')";

            MySqlCommand comando = new MySqlCommand(sql, obj.conexao);

            comando.ExecuteNonQuery();
        }
        public DataTable ConsultarAgenda()
        {

            obj = new Dall();
            string sql = "select * from contatos";

            var dataTable = new DataTable();

            MySqlCommand comando = new MySqlCommand(sql, obj.conexao);


            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dataTable);

            return dataTable;

        }

        public void EditarContato(int id, string nome, string telefone)
        {
            obj = new Dall();
            string sql = $"update contatos set nome = '{nome}',  telefone = '{telefone}' where id = {id}";
            MySqlCommand comando = new MySqlCommand(sql, obj.conexao);
            comando.ExecuteNonQuery();
        }
        public void ExcluirContato(int id)
        {
            obj = new Dall();
            string sql = $"delete from contatos where id={id}";
            MySqlCommand comando = new MySqlCommand(sql, obj.conexao);
            comando.ExecuteNonQuery();



        }
    }
}