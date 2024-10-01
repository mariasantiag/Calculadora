using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmcalc : Form
    {

        float valor1 = 0;
        string operacao = "";


        public frmcalc()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            txtVisor.AppendText("+");
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            txtVisor.AppendText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVisor.AppendText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtVisor.AppendText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtVisor.AppendText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtVisor.AppendText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtVisor.AppendText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtVisor.AppendText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVisor.AppendText("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtVisor.AppendText("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtVisor.AppendText("0");
        }

        private void btnAdicao_Click_1(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txtVisor.Text);
            operacao = "Adicao";
            txtVisor.Clear();
        }

        private void txtVisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txtVisor.Text);
            operacao = "Subtracao";
            txtVisor.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txtVisor.Text);
            operacao = "Multiplicacao";
            txtVisor.Clear();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txtVisor.Text);
            operacao = "Divisao";
            txtVisor.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (this.operacao == "Subtracao")
            {
                float resultado = valor1 - Convert.ToSingle(txtVisor.Text);
                txtVisor.Text = resultado.ToString();
            }

            if (this.operacao == "Adicao")
            {
                float resultado = valor1 + Convert.ToSingle(txtVisor.Text);
                txtVisor.Text = resultado.ToString();
            }

            if (this.operacao == "Multiplicacao")
            {
                float resultado = valor1 * Convert.ToSingle(txtVisor.Text);
                txtVisor.Text = resultado.ToString();
            }

            if (this.operacao == "Divisao")
            {
                float resultado = valor1 / Convert.ToSingle(txtVisor.Text);
                txtVisor.Text = resultado.ToString();
            }

        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            txtVisor.Clear();
        }



        private void MSsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmcalc_Load(object sender, EventArgs e)
        {

        }

        private void MSConversao_Click(object sender, EventArgs e)
        {
            frmConverte formularioConverter = new frmConverte();
            formularioConverter.ShowDialog();
        }

        private void frmcalc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void centimetrosEmPolegadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMcm formularioCm = new FRMcm();   
            formularioCm.ShowDialog();
        }
    }
}
