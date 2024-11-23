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

namespace IdeiaProj1
{
    public partial class Tela2 : Form
    {
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

       
    }
}
