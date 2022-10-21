namespace _03_MultiConversor
{
    public partial class Form1 : Form
    {
        bool semaforoAliexpress = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void PulgadasRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UnidadesConvLabel.Text = "''";
            UnidadesResultLabel.Text = "cm";

            if (semaforoAliexpress)
            {
                semaforoAliexpress = false;

                double n;
                if (double.TryParse(ValorAConvertirTextBox.Text, out n))
                {
                    ResultadoTextBox.Text = Math.Round((n * 2.54), 2).ToString();
                }
                else
                {
                    if (ValorAConvertirTextBox.Text == string.Empty)
                    {
                        ResultadoTextBox.Text = string.Empty;
                    }
                    else
                    {
                        ResultadoTextBox.Text = "ERROR";
                    }
                }

                semaforoAliexpress = true;
            }
        }

        private void CentímetrosradioButton_CheckedChanged(object sender, EventArgs e)
        {
            UnidadesConvLabel.Text = "cm";
            UnidadesResultLabel.Text = "''";

            if (semaforoAliexpress)
            {
                semaforoAliexpress = false;

                double n;
                if (double.TryParse(ValorAConvertirTextBox.Text, out n))
                {
                    ResultadoTextBox.Text = Math.Round((n / 2.54), 2).ToString();
                }
                else
                {
                    if (ValorAConvertirTextBox.Text == string.Empty)
                    {
                        ResultadoTextBox.Text = string.Empty;
                    }
                    else
                    {
                        ResultadoTextBox.Text = "ERROR";
                    }
                }

                semaforoAliexpress = true;
            }
        }

        private void KelvinRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UnidadesConvLabel.Text = "K";
            UnidadesResultLabel.Text = "°C";

            if (semaforoAliexpress)
            {
                semaforoAliexpress = false;

                double n;
                if (double.TryParse(ValorAConvertirTextBox.Text, out n))
                {
                    ResultadoTextBox.Text = Math.Round((n - 273), 2).ToString();
                }
                else
                {
                    if (ValorAConvertirTextBox.Text == string.Empty)
                    {
                        ResultadoTextBox.Text = string.Empty;
                    }
                    else
                    {
                        ResultadoTextBox.Text = "ERROR";
                    }
                }

                semaforoAliexpress = true;
            }
        }

        private void CentígradosRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UnidadesConvLabel.Text = "°C";
            UnidadesResultLabel.Text = "K";

            if (semaforoAliexpress)
            {
                semaforoAliexpress = false;

                double n;
                if (double.TryParse(ValorAConvertirTextBox.Text, out n))
                {
                    ResultadoTextBox.Text = Math.Round((n + 273), 2).ToString();
                }
                else
                {
                    if (ValorAConvertirTextBox.Text == string.Empty)
                    {
                        ResultadoTextBox.Text = string.Empty;
                    }
                    else
                    {
                        ResultadoTextBox.Text = "ERROR";
                    }
                }

                semaforoAliexpress = true;
                //CentígradosRadioButton.Checked = false;
            }
        }
    }
}