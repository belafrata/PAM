using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_DS
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void médiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmedia menu = new frmmedia();
            menu.Show();
        }

        private void sorteioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmsorteio menu = new frmsorteio();
            menu.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
