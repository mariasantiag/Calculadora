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
    public partial class FRMcm : Form
    {
        public FRMcm()
        {
            InitializeComponent();
        }

        private void btnConverte_Click(object sender, EventArgs e)
        {
            double Converter;
            float CM = Convert.ToSingle(txtNumero.Text);
            Converter = CM / 2.54;

            lblResultado.Text = Converter.ToString("0");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            lblResultado.Text = "";
        }

        private void FRMcm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
