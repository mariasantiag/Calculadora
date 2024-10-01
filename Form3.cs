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
    public partial class frmConverte : Form
    {
        public frmConverte()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double Conversao;
            float Celsius = Convert.ToSingle(txtNumeroDigitado.Text);
            Conversao = Celsius * 1.8 + 32;

            lblResul.Text = Conversao.ToString("0");

        }

        private void frmConverter_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblResul_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumeroDigitado.Clear();
            lblResul.Text = "";
        }
    }
}
