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
using MySql.Data.MySqlClient;

namespace IdeiaProj1
{
    public partial class Tela2 : Form
    {
        public string EmailProf { get; set; }   


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

        MySqlConnection Conexao = null;
        public void listaGrid()
        {
            string data_source = "datasource=localhost; username=root; database=reservas_labs";
            Conexao = new MySqlConnection(data_source);
            string strSQL = "select * from reserva";
            MySqlCommand comando = new MySqlCommand(strSQL, Conexao);


            Conexao.Open();

            try
            {
                DataTable dtLista = new DataTable();
                MySqlDataAdapter objAdp = new MySqlDataAdapter(comando);
                objAdp.Fill(dtLista);

                dataGrid.DataSource = dtLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
    
        public Tela2()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            tela3 Tela3Cs = new tela3();
            this.Hide();
            Tela3Cs.ShowDialog(); 
            this.Dispose();
        }

        private void Tela2_Load(object sender, EventArgs e)
        {
            listaGrid();

            btnadd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnadd.Width, btnadd.Height, 10, 10 ));
            btnLab1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLab1.Width, btnLab1.Height, 10, 10));
            btnLab2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLab2.Width, btnLab2.Height, 10, 10));
            btnLab3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLab3.Width, btnLab3.Height, 10,10));
            btnLabquimica.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLabquimica.Width, btnLabquimica.Height, 10, 10));
            btnSalamaker.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSalamaker.Width, btnSalamaker.Height, 10, 10));
            btnSiberia.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSiberia.Width, btnSiberia.Height, 10, 10));
        }

        private void btnLab1_Click(object sender, EventArgs e)
        {
            string data_source = "datasource=localhost; username=root; database=reservas_labs";
            Conexao = new MySqlConnection(data_source);
            string strSQL = "select * from reserva WHERE local_reserva = 'LABORATÓRIO 1 (Aquário)'";
            MySqlCommand comando = new MySqlCommand(strSQL, Conexao);


            Conexao.Open();

            try
            {
                DataTable dtLista = new DataTable();
                MySqlDataAdapter objAdp = new MySqlDataAdapter(comando);
                objAdp.Fill(dtLista);

                dataGrid.DataSource = dtLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnLab2_Click(object sender, EventArgs e)
        {
            string data_source = "datasource=localhost; username=root; database=reservas_labs";
            Conexao = new MySqlConnection(data_source);
            string strSQL = "select * from reserva WHERE local_reserva = 'LABORATÓRIO 2'";
            MySqlCommand comando = new MySqlCommand(strSQL, Conexao);


            Conexao.Open();

            try
            {
                DataTable dtLista = new DataTable();
                MySqlDataAdapter objAdp = new MySqlDataAdapter(comando);
                objAdp.Fill(dtLista);

                dataGrid.DataSource = dtLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnLab3_Click(object sender, EventArgs e)
        {
            string data_source = "datasource=localhost; username=root; database=reservas_labs";
            Conexao = new MySqlConnection(data_source);
            string strSQL = "select * from reserva WHERE local_reserva = 'LABORATÓRIO 3'";
            MySqlCommand comando = new MySqlCommand(strSQL, Conexao);


            Conexao.Open();

            try
            {
                DataTable dtLista = new DataTable();
                MySqlDataAdapter objAdp = new MySqlDataAdapter(comando);
                objAdp.Fill(dtLista);

                dataGrid.DataSource = dtLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnLabquimica_Click(object sender, EventArgs e)
        {
            string data_source = "datasource=localhost; username=root; database=reservas_labs";
            Conexao = new MySqlConnection(data_source);
            string strSQL = "select * from reserva WHERE local_reserva = 'LABORATÓRIO DE QUÍMICA'";
            MySqlCommand comando = new MySqlCommand(strSQL, Conexao);


            Conexao.Open();

            try
            {
                DataTable dtLista = new DataTable();
                MySqlDataAdapter objAdp = new MySqlDataAdapter(comando);
                objAdp.Fill(dtLista);

                dataGrid.DataSource = dtLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnSalamaker_Click(object sender, EventArgs e)
        {
            string data_source = "datasource=localhost; username=root; database=reservas_labs";
            Conexao = new MySqlConnection(data_source);
            string strSQL = "select * from reserva WHERE local_reserva = 'SALA MAKER'";
            MySqlCommand comando = new MySqlCommand(strSQL, Conexao);


            Conexao.Open();

            try
            {
                DataTable dtLista = new DataTable();
                MySqlDataAdapter objAdp = new MySqlDataAdapter(comando);
                objAdp.Fill(dtLista);

                dataGrid.DataSource = dtLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnSiberia_Click(object sender, EventArgs e)
        {
            string data_source = "datasource=localhost; username=root; database=reservas_labs";
            Conexao = new MySqlConnection(data_source);
            string strSQL = "select * from reserva WHERE local_reserva = 'SIBÉRIA'";
            MySqlCommand comando = new MySqlCommand(strSQL, Conexao);


            Conexao.Open();

            try
            {
                DataTable dtLista = new DataTable();
                MySqlDataAdapter objAdp = new MySqlDataAdapter(comando);
                objAdp.Fill(dtLista);

                dataGrid.DataSource = dtLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnAuditorio_Click(object sender, EventArgs e)
        {
            string data_source = "datasource=localhost; username=root; database=reservas_labs";
            Conexao = new MySqlConnection(data_source);
            string strSQL = "select * from reserva WHERE local_reserva = 'AUDITÓRIO'";
            MySqlCommand comando = new MySqlCommand(strSQL, Conexao);


            Conexao.Open();

            try
            {
                DataTable dtLista = new DataTable();
                MySqlDataAdapter objAdp = new MySqlDataAdapter(comando);
                objAdp.Fill(dtLista);

                dataGrid.DataSource = dtLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        public Tela2 (string emailProf)
        {
            InitializeComponent();
            
            EmailProf = emailProf; 

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione uma reserva para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            int reservaId = (int)dataGrid.SelectedRows[0].Cells["id"].Value;
            ExcluirReserva(reservaId);
        }
        private void ExcluirReserva(int reservaId)
        {
            string data_source = "datasource=localhost; username=root; database=reservas_labs";
            Conexao = new MySqlConnection(data_source);
            {
                try
                {
                    Conexao.Open();
                    string query = "DELETE FROM reserva WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, Conexao))
                    {
                        cmd.Parameters.AddWithValue("@id", reservaId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Reserva excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listaGrid(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir reserva: " + ex.Message);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar();
            this.Hide();
            editar.ShowDialog();
            this.Dispose();
        }
    }
}
