using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeiaProj1
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nleft
            , int ntop
            , int nright
            , int nbottom
            , int nwidthellipise
            , int nheightellipise
            );
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
                    Tela2 tela2 = new Tela2(txtemail.Text);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnentrar.Region =       Region.FromHrgn(CreateRoundRectRgn(0, 0, btnentrar.Width, btnentrar.Height, 5, 5));
            btnCadastro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCadastro.Width, btnCadastro.Height, 5, 5));



        }
    }
}
