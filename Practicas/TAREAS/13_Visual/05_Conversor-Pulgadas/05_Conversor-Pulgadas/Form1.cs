namespace _05_Conversor_Pulgadas
{
    public partial class Form1 : Form
    {
        bool semaforoAliexpress = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Centimetros_TextChanged(object sender, EventArgs e)
        {
            if (semaforoAliexpress)
            {
                semaforoAliexpress = false;

                double n;
                if (double.TryParse(Centimetros.Text, out n))
                {
                    Pulgadas.Text = Math.Round((n * 2.54), 2).ToString();
                }
                else
                {
                    if (Centimetros.Text == string.Empty)
                    {
                        Pulgadas.Text = string.Empty;
                    }
                    else
                    {
                        Pulgadas.Text = "ERROR";
                    }
                }

                semaforoAliexpress = true;
            }
        }

        private void Pulgadas_TextChanged(object sender, EventArgs e)
        {
            if (semaforoAliexpress)
            {
                semaforoAliexpress = false;

                double n;
                if (double.TryParse(Pulgadas.Text, out n))
                {
                    Centimetros.Text = Math.Round((n / 2.54), 2).ToString();
                }
                else
                {
                    if (Pulgadas.Text == string.Empty)
                    {
                        Centimetros.Text = string.Empty;
                    }
                    else
                    {
                        Centimetros.Text = "ERROR";
                    }
                }

                semaforoAliexpress = true;
            }
        }
    }
}