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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PgMenu tela = new PgMenu();
            tela.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double i, x;
            i = Convert.ToDouble(txtNum.Text);
            x = 1;
            do
            {
                x *= i;
                i--;
                txtResult.Text = String.Concat(txtResult.Text, "\r\n", x.ToString());
            } while (i > 1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            double i, x;
            x = 1;
            i = Convert.ToDouble(txtNum.Text);
            while(i > 1)
            {
                x *= i;
                i--;
                txtResult.Text = String.Concat(txtResult.Text, "\r\n", x.ToString());
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtResult.Clear();
            txtNum.Focus();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            double i,x; 
            x = 1;
            for (i = Convert.ToDouble(txtNum.Text); i > 1; i--)
            {
                x *= i;
                txtResult.Text = String.Concat(txtResult.Text, "\r\n", x.ToString());
            }
        }
    }
}
