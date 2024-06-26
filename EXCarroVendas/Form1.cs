﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double salario, comissao, valorVendas, numeroVendas, resultado, porcentagem;
            salario = Convert.ToDouble(txtSalario.Text);
            comissao = Convert.ToDouble(txtComissao.Text);
            valorVendas = Convert.ToDouble(txtTotalVendas.Text);
            numeroVendas = Convert.ToDouble(txtCarrosVendidos.Text);


            resultado = salario + comissao;

            porcentagem = valorVendas * (0.05);

            txtResultado.Text = resultado.ToString();
            txtPorcentagem.Text = porcentagem.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCarrosVendidos.Clear();
            txtComissao.Clear();
            txtTotalVendas.Clear();
            txtSalario.Clear();
            txtResultado.Clear();
            txtSalario.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            PgMenu tela = new PgMenu();
            tela.Show();
        }
    }
}
