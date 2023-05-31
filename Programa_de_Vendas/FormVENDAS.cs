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

namespace Programa_de_Vendas
{
    public partial class FormVENDAS : Form
    {
        string servidor = "";
        MySqlConnection conexao;
        MySqlCommand comando;

        string qualGRID = "";

        public FormVENDAS()
        {
            InitializeComponent();

            servidor = "Server=localhost;database=bd_porta_a_porta;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            
            labelDATA.Text = System.DateTime.Now.ToString();
            listarGRIDS();
        }
        private void listarGRIDS()
        {
            try
            {
                conexao.Open();
                
                if (qualGRID == "")
                {
                    comando.CommandText = "SELECT * FROM tbl_produto";
                }
                MySqlDataAdapter adapadorGrid = new MySqlDataAdapter(comando);
                DataTable tabelaGrid = new DataTable();
                adapadorGrid.Fill(tabelaGrid);

                if (qualGRID == "")
                {
                    dataGridViewVENDA.DataSource = tabelaGrid;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO tbl_venda(data_venda, fk_usuario) VALUES ('" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' , 1);";
                comando.ExecuteNonQuery();
            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            }            
            finally
            {
                conexao.Close();
            }
        }
    }
}
