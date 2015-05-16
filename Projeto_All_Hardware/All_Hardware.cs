using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Projeto_All_Hardware
{
    public partial class All_Hardware : Form
    {
        public All_Hardware()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            ConnectionFactory conn = new ConnectionFactory();
            MySqlConnection connection;
            connection = conn.getConnection();

            /* 
             * Teste
             * string sql = "INSERT INTO itens (descricao) VALUES ('notebook')";
             * MySqlCommand comando = new MySqlCommand(sql, connection);
             * comando.BeginExecuteNonQuery();
             * MessageBox.Show("Dados inseridos");
             */
        }
    }
}
