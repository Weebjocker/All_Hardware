using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

//MySQL
using MySql.Data.MySqlClient;


namespace Projeto_All_Hardware
{
    class ConnectionFactory
    {
        private string servidor = "localhost";
        private string banco = "appadmin";
        private string usuario = "root";
        private string senha = "harley";

        MySqlConnection connection;
        private string conexao;//String de Conexão

        public MySqlConnection getConnection()
        {
            conexao = "Persist Security Info=False; server="+ servidor +"; database="+ banco +"; uid="+ usuario +"; pwd="+ senha;

            try
            {
                connection = new MySqlConnection(conexao);

                connection.Open();

                //string sql = "INSERT INTO itens (descricao) VALUES ('carteira')";
                //MySqlCommand comando = new MySqlCommand(sql, connection);
                //comando.BeginExecuteNonQuery();
                MessageBox.Show("Conectado");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ops. Erro ao conectar ao banco");
                connection.Close();
            }

            return connection;

        }

    }
}