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
    public partial class Cadastro : Form
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
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length == 0)
            {
                MessageBox.Show("Por Favor insira o nome do usuario", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Por Favor insira o email do usuario","ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtSenha.Text.Length == 0)
            {
                MessageBox.Show("Por Favor insira uma senha", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MySqlConnection Conexao = null;
                try
                {
                    string data_source = "datasource=localhost; username=root; database=reserva_labs";
                    Conexao = new MySqlConnection(data_source);

                    string sql = "SELECT * from login WHERE email = @email AND senha = @senha;";
                    MySqlCommand comando = new MySqlCommand(sql, Conexao);
                    comando.Parameters.AddWithValue("@email", txtEmail.Text);
                    comando.Parameters.AddWithValue("@senha", txtSenha.Text);


                    Conexao.Open();

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(comando);
                    da.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        MessageBox.Show("Cadastro já feito", "Erro de duplicidade de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        try
                        {
                            Conexao = new MySqlConnection(data_source);

                            string sqlinsert = "INSERT INTO login(nome, email, senha)" + "VALUES(@nome, @email, @senha);";

                            MySqlCommand comandoinsert = new MySqlCommand(sqlinsert, Conexao);
                            comandoinsert.Parameters.AddWithValue("@nome", txtNome.Text);
                            comandoinsert.Parameters.AddWithValue("@email", txtEmail.Text);
                            comandoinsert.Parameters.AddWithValue("@senha", txtSenha.Text);


                            Conexao.Open();
                            comandoinsert.ExecuteNonQuery();
                            MessageBox.Show("Cadastro feito com sucesso!", "ALERTA", MessageBoxButtons.OK);
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
                                Form1 form1 = new Form1();
                                this.Hide();
                                form1.ShowDialog();
                                this.Dispose();
                            }
                        }

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

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            btnCadastrar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCadastrar.Width, btnCadastrar.Height, 5, 5));
            btnvoltar.Region    = Region.FromHrgn (CreateRoundRectRgn(  0,  0, btnvoltar.Width,  btnvoltar.Height,  5, 5));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Dispose();
        }
    }
}
