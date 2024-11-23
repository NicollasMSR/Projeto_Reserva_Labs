using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace IdeiaProj1
{
    public partial class tela3 : Form
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
        public tela3()
        {
            InitializeComponent();
        }

        private void tela3_Load(object sender, EventArgs e)
        {
            btnlimpar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnlimpar.Width, btnlimpar.Height, 30, 30));
            btnreserva.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnreserva.Width, btnreserva.Height, 30, 30));
            btnvoltar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnvoltar.Width, btnvoltar.Height, 30, 30));

        }
        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtano.Text = string.Empty;
            txtcurso.Text = string.Empty;
            txtdata.Text = string.Empty;
            txthora1.Text = string.Empty;
            txthora2.Text = string.Empty;
            txtlocal.Text = string.Empty;
            txtprof.Text = string.Empty;
            txtfixa.Text = string.Empty;
            txtSemana.Text = string.Empty;

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Tela2 tela2 = new Tela2();
            this.Hide();
            tela2.ShowDialog();
            this.Dispose();
        }


        private void txtfixa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtfixa.Text == "SIM")
            {
                txtSemana.Visible = true;
                label13.Visible = true;
                label9.Visible = false;
                txtdata.Visible = false;
            }
            else
            {
                txtSemana.Visible = false;
                label13.Visible = false;
                label9.Visible = true;
                txtdata.Visible = true;
            }

        }

        private void txtdata_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnreserva_Click(object sender, EventArgs e)
        {
            MySqlConnection Conexao = null;
            try
            {
                string data_source = "datasource=localhost; username=root; database=reservas_labs";
                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * from reserva WHERE horario_incial = @horarioInicial AND horario_final = @horarioFinal AND data_reserva = @dataReserva;";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                comando.Parameters.AddWithValue("@horarioInicial", txthora1.Text);
                comando.Parameters.AddWithValue("@horarioFinal", txthora2.Text);
                comando.Parameters.AddWithValue("@dataReserva", txtdata.Text);

                Conexao.Open();

                DataTable dataTable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Reserva ja feita por outro professor, troque o horario ou o dia da reserva", "Erro de duplicidade de reserva", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        Conexao = new MySqlConnection(data_source);

                        string sqlinsert = "INSERT INTO reserva(local_reserva, data_reserva, dia_semana, horario_incial, horario_final, curso, ano, prof_resp, reserva_fixa)" + "VALUES(@localReserva, @dataReserva, @diaSemana, @horarioIncial, @horarioFinal, @curso, @ano, @profResp, @reservaFixa);";

                        MySqlCommand comandoinsert = new MySqlCommand(sqlinsert, Conexao);
                        comandoinsert.Parameters.AddWithValue("@localReserva", txtlocal.Text);
                        comandoinsert.Parameters.AddWithValue("@dataReserva", txtdata.Text);
                        comandoinsert.Parameters.AddWithValue("@diaSemana", txtSemana.Text);
                        comandoinsert.Parameters.AddWithValue("@horarioIncial", txthora1.Text);
                        comandoinsert.Parameters.AddWithValue("@horarioFinal", txthora2.Text);
                        comandoinsert.Parameters.AddWithValue("@curso", txtcurso.Text);
                        comandoinsert.Parameters.AddWithValue("@ano", txtano.Text);
                        comandoinsert.Parameters.AddWithValue("@profResp", txtprof.Text);
                        comandoinsert.Parameters.AddWithValue("@reservaFixa", txtfixa.Text);


                        Conexao.Open();
                        comandoinsert.ExecuteNonQuery();
                        MessageBox.Show("Reserva feita com sucesso!","ALERTA", MessageBoxButtons.OK);
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
       
}
