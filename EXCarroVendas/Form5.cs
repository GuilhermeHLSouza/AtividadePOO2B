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

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            double num, i, x;
            num = Convert.ToDouble(txtNum.Text);
            i = 1;
            while(i >= 10)
            {
                x = i * (i - 1) * num * 1 ;
                i++;
                txtResult.Text = String.Concat(txtResult.Text, "/r/n", x.ToString());
            }
        }
    }
}
