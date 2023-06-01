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
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        string qualGRID = "";
        string vendaATIVA = "";

        public FormVENDAS()
        {
            InitializeComponent();

            servidor = "Server=localhost;Database=bd_porta_a_porta;Uid=root;Pwd=";
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
                if (qualGRID == "GRIDitem")
                {
                    comando.CommandText = "SELECT * FROM tbl_produto INNER JOIN tbl_venda_item ON (tbl_venda_item.fk_produto = tbl_produto.id) WHERE fk_venda = " + vendaATIVA;
                }
                MySqlDataAdapter adaptadorGRID = new MySqlDataAdapter(comando);
                DataTable tabelaGRID = new DataTable();
                adaptadorGRID.Fill(tabelaGRID);

                if (qualGRID == "")
                {
                    dataGridViewVENDA.DataSource = tabelaGRID;
                }
                if (qualGRID == "GRIDitem")
                {
                    dataGridViewvendaRealizada.DataSource = tabelaGRID;
                }

            }
            catch (Exception erro_Mysql)
            {
                MessageBox.Show(erro_Mysql.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void buttonNOVAVENDA_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO tbl_venda(data_venda, fk_usuario) VALUES ('" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', 1);";
                comando.ExecuteNonQuery();
            }
            catch (Exception erro_Mysql)
            {
                MessageBox.Show(erro_Mysql.Message);
            }
            finally
            {
                conexao.Close();
            }

            try
            {
                conexao.Open();
                comando.CommandText = "SELECT MAX(id) FROM tbl_venda;";

                MySqlDataReader readerVENDA = comando.ExecuteReader();

                if (readerVENDA.Read())
                {
                    vendaATIVA = readerVENDA.GetString(0);
                }
            }
            catch (Exception erro_Mysql)
            {
                MessageBox.Show(erro_Mysql.Message);
            }
            finally
            {
                conexao.Close();
            }
            labelIDVENDA.Text = vendaATIVA;
        }

        private void buttonADICIONAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO tbl_venda_item(fk_produto, fk_venda) VALUES (" + dataGridViewVENDA.CurrentRow.Cells[0].Value.ToString() + ", " + vendaATIVA + ");";
                comando.ExecuteNonQuery();

                qualGRID = "GRIDitem";
            }
            catch (Exception erro_Mysql)
            {
                MessageBox.Show(erro_Mysql.Message);
            }
            finally
            {
                conexao.Close();
            }
            MessageBox.Show("Produto adicionado com sucesso!");
            listarGRIDS();
        }
    }
}