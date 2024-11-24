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
    public partial class Excluir : Form
    { public string EmailProf {  get; set; }
        public Excluir(string emailProf)
        {
            InitializeComponent();
            EmailProf = emailProf;
        }

        private void Excluir_Load(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Tela2 tela2 = new Tela2();
            this.Hide();
            tela2.ShowDialog();
            this.Dispose();
        }
    }
}
