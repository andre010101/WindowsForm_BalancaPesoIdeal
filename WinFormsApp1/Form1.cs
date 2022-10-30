namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAltura.Clear();
            cmbSexo.Text = "";
            txtNome.Focus();
        }

        

        private void btnPesoIdeal_Click(object sender, EventArgs e)
        {
            try
            {
                Double Altura = 0, Pesoideal = 0;
                Altura = double.Parse(txtAltura.Text);
                if (cmbSexo.Text == "Feminino")
                {
                    Pesoideal = (62.7 * Altura) - 44.7;
                    MessageBox.Show(txtNome.Text + "seu peso ideal é:" + Pesoideal.ToString("F") + " kg ", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbSexo.Text == "Maculino")
                {
                    Pesoideal = (72.7 * Altura) - 58;
                    MessageBox.Show(txtNome.Text + "seu peso ideal é:" + Pesoideal.ToString("F") + "kg", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Escolha o sexo", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("verifique os valores informado", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}