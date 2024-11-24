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
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Tela2 tela2 = new Tela2();
            this.Hide();
            tela2.ShowDialog();
            this.Dispose();
        }

        private int reservaId;
        private string connectionString = "datasource=localhost; username=root; database=reserva_labs;";
        public Editar(int reservaId)
        {
            InitializeComponent();
            this.reservaId = reservaId;
            CarregarDadosReserva();
        }
        private void CarregarDadosReserva()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open(); string query = "SELECT local_reserva, data_reserva, dia_semana, horario_inicial, horario_final, curso, ano, prof_resp, reserva_fixa FROM reserva WHERE id = @id";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", reservaId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtprof.Text = reader.GetString("prof_resp");
                            txtano.Text = reader.GetString("ano");
                            txtdata.Text = reader.GetString("data_reserva");
                            txtlocal.Text = reader.GetString("local_reserva");
                            txtcurso.Text = reader.GetString("curso");
                            txtfixa.Text = reader.GetString("reserva_fixa");
                            txtSemana.Text = reader.GetString("dia_semana");
                            txthora1.Text = reader.GetString("horario_inicial");
                            txthora2.Text = reader.GetString("horario_final");
                        }
                    }
                }
            }

        }
        private void btneditar_Click(object sender, EventArgs e)
        {
            AlterarBD();
            Tela2 tela2 = new Tela2();
            this.Hide();
            tela2.ShowDialog();
            this.Dispose();
        }

        private void AlterarBD()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT local_reserva, data_reserva, dia_semana, horario_inicial, horario_final, curso, ano, prof_resp, reserva_fim FROM reserva WHERE id = @id";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", reservaId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtlocal.Text = reader.GetString("local_reserva");
                            txtdata.Text = reader.GetString("data_reserva");
                            txtSemana.Text = reader.GetString("dia_semana");
                            txthora1.Text = reader.GetString("horario_inicial");
                            txthora2.Text = reader.GetString("horario_final");
                            txtcurso.Text = reader.GetString("curso");
                            txtano.Text = reader.GetString("ano");
                            txtprof.Text = reader.GetString("prof_resp");
                            txtfixa.Text = reader.GetString("reserva_fim");

                            MessageBox.Show("Dados carregados com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

            }
        }
    }
}
   