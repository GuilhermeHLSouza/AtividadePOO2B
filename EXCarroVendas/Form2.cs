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
    public partial class PgMenu : Form
    {
        public PgMenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void OpenCarro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 tela = new Form1();
            tela.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void competiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 tela = new Form3();
            tela.Show();
        }
    }
}
