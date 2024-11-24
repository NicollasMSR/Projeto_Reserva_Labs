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

        private void btneditar_Click(object sender, EventArgs e)
        {
            tela3 Tela3Cs = new tela3();
            this.Hide();
            Tela3Cs.ShowDialog();
            this.Dispose();
        }
    }
}
