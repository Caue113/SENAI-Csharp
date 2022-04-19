namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(txtValor1.Text);
            int valor2 = Convert.ToInt32(txtValor2.Text);

            lblResultado2.Text = (valor1 + valor2).ToString();
        }
        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(txtValor1.Text);
            int valor2 = Convert.ToInt32(txtValor2.Text);

            lblResultado2.Text = (valor1 - valor2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(txtValor1.Text);
            int valor2 = Convert.ToInt32(txtValor2.Text);

            lblResultado2.Text = (valor1 * valor2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(txtValor1.Text);
            int valor2 = Convert.ToInt32(txtValor2.Text);

            lblResultado2.Text = (valor1 / valor2).ToString();
        }
    }
}