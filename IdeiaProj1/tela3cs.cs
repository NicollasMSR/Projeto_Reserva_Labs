using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IdeiaProj1
{
    public partial class tela3 : Form
    {
        public tela3()
        {
            InitializeComponent();
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
            if(txtfixa.Text == "SIM")
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

                string sql = "INSERT INTO reserva(local_reserva, data_reserva, dia_semana, horario_incial, horario_final, curso, ano, prof_resp, reserva_fixa)" + "VALUES(@localReserva, @dataReserva, @diaSemana, @horarioIncial, @horarioFinal, @curso, @ano, @profResp, @reservaFixa);";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                comando.Parameters.AddWithValue("@localReserva", txtlocal.Text);
                comando.Parameters.AddWithValue("@dataReserva", txtdata.Text);
                comando.Parameters.AddWithValue("@diaSemana", txtSemana.Text);
                comando.Parameters.AddWithValue("@horarioIncial", txthora1.Text);
                comando.Parameters.AddWithValue("@horarioFinal", txthora2.Text);
                comando.Parameters.AddWithValue("@curso", txtcurso.Text);
                comando.Parameters.AddWithValue("@ano", txtano.Text); 
                comando.Parameters.AddWithValue("@profResp", txtprof.Text);
                comando.Parameters.AddWithValue("@reservaFixa", txtfixa.Text);


                Conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados inseridos com sucesso!");
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

        private void tela3_Load(object sender, EventArgs e)
        {

        }
    }

       
}
