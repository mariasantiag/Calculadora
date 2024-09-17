namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        

        private void pgbcarregar_Click(object sender, EventArgs e)
        {

        }

        private void tmrcarregar_Tick(object sender, EventArgs e)
        {
           
            if (pgbcarregar.Value >= 100)
            {
                tmrcarregar.Enabled = false;
                frmcalc Calculadora = new frmcalc();  
                Calculadora.ShowDialog();
            }

            else
            {
                pgbcarregar.Value = pgbcarregar.Value + 10;
            }
        }
    }
}