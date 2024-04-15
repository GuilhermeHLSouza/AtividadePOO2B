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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        double salarioL;
        private void btn_CalcSala_Click(object sender, EventArgs e)
        {
            double idade, salario;
            salario = Convert.ToDouble(txt_Salario.Text);
            idade = Convert.ToDouble(txt_idade.Text);

            string nome, sexo;
            nome = txt_Nome.Text;
            sexo = txt_Sexo.Text;

            if(sexo == "M" && idade >= 30)
            {
                salarioL = salario + 100;
            }
            else if(sexo == "M" && idade < 30) 
            {
                salarioL = salario + 80;
            }
            else if (sexo == "F" && idade < 30)
            {
                salarioL = salario + 50;
            }
            else if (sexo == "F" && idade < 50)
            {
                salarioL = salario + 200;

            }
            txt_MostraNome.Text = nome.ToString();
            txt_SalaL.Text = salarioL.ToString();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_idade.Clear();
            txt_MostraNome.Clear();
            txt_SalaL.Clear();
            txt_idade.Clear();
            txt_Sexo.Clear();
            txt_Salario.Clear();
            txt_Nome.Clear();
            txt_idade.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PgMenu tela = new PgMenu();
            tela.Show();
        }
    }
}
