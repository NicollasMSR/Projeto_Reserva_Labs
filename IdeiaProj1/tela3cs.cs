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
    public partial class tela3cs : Form
    { 
        public tela3cs()
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
            txtreserva.Text = string.Empty;

        }
    }

       
}
