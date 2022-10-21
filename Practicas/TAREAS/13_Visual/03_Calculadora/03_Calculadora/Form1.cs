namespace _03_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n, n2;
            if (double.TryParse(TBoperador1.Text, out n) && double.TryParse(TBoperador2.Text, out n2))
            {
                TBresultado.Text = (n / n2).ToString();
            }
            else
            {
                if (TBoperador1.Text == string.Empty)
                {
                    TBresultado.Text = string.Empty;
                }
                else
                {
                    TBresultado.Text = "ERROR";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n, n2;
            if (double.TryParse(TBoperador1.Text, out n) && double.TryParse(TBoperador2.Text, out n2))
            {
                TBresultado.Text = (n + n2).ToString();
            }
            else
            {
                if (TBoperador1.Text == string.Empty)
                {
                    TBresultado.Text = string.Empty;
                }
                else
                {
                    TBresultado.Text = "ERROR";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n, n2;
            if (double.TryParse(TBoperador1.Text, out n) && double.TryParse(TBoperador2.Text, out n2))
            {
                TBresultado.Text = (n - n2).ToString();
            }
            else
            {
                if (TBoperador1.Text == string.Empty)
                {
                    TBresultado.Text = string.Empty;
                }
                else
                {
                    TBresultado.Text = "ERROR";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n, n2;
            if (double.TryParse(TBoperador1.Text, out n) && double.TryParse(TBoperador2.Text, out n2))
            {
                TBresultado.Text = (n * n2).ToString();
            }
            else
            {
                if (TBoperador1.Text == string.Empty)
                {
                    TBresultado.Text = string.Empty;
                }
                else
                {
                    TBresultado.Text = "ERROR";
                }
            }
        }
    }
}