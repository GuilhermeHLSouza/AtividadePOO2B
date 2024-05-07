using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXCarroVendas
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double distancia, premio;
            distancia = Convert.ToDouble(txtDistancia.Text);

            if (distancia > 1500)
            {
                premio = 15000;
            }
            else if (distancia < 800)
            {
                premio = 5000;
            }
            else
            {
                premio = 10000;
            }

            txtPremio.Text = premio.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDistancia.Clear();
            txtPremio.Clear();
            txtDistancia.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            PgMenu tela = new PgMenu();
            tela.Show();
        }
    }
}
