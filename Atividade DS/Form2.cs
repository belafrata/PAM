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
    public partial class frmmedia : Form
    {
        int[] vetorNotas = new int[5];
        int i, soma = 0, x;

        public frmmedia()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            txtmedia.Text = (soma/5).ToString();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            soma = 0;
            txtmedia.Clear();
            txtnota.Clear();
            txtnota.Focus();
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 5; i++)
            {
                x = Convert.ToInt32(txtnota.Text);
                vetorNotas[i] = x;
                soma = soma + vetorNotas[i];
                txtnota.Clear();
                txtnota.Focus();
                break;
            }
        }
    }
}
