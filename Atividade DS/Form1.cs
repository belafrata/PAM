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
    public partial class frmsorteio : Form
    {
        public frmsorteio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetorSorteio = new int[15];
            int i;
            Random num = new Random();

            for (i = 0; i < 15; i++)
            {
                vetorSorteio[i] = num.Next(1, 100);
            }

            for (i = 0; i < 15; i++)
            {
                if (vetorSorteio[i] % 2 == 0)
                {
                    txtsorteio.Text += vetorSorteio[i].ToString() + Environment.NewLine;
                }
            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtsorteio.Clear();
        }
    }
}
