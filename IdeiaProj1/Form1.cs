using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeiaProj1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnentrar_Click(object sender, EventArgs e)
        {
            
            MySqlConnection Conexao = null;
            try
            {
                string data_source = "datasource=localhost; username=root; database=reservas_labs";
                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * from login WHERE email = @email AND senha = @senha;";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                comando.Parameters.AddWithValue("@email", txtemail.Text);
                comando.Parameters.AddWithValue("@senha", txtsenha.Text);
                

                Conexao.Open();

                DataTable dataTable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    Tela2 tela2 = new Tela2();
                    this.Hide();
                    tela2.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Acesso negado, faça o seu cadastro primeiro", "Erro de acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
            finally
            {
                if (Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }

            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            this.Hide();
            cadastro.ShowDialog();
            this.Dispose();
        }
    }
}
