﻿using MySql.Data.MySqlClient;
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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection Conexao = null;
            try
            {
                string data_source = "datasource=localhost; username=root; database=reservas_labs";
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
}