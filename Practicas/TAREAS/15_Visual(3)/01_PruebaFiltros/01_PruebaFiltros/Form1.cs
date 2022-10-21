namespace _01_PruebaFiltros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidarNumerico(e))
            {
                if (e.KeyChar == 13)
                {
                    Numerico.Text = textBoxNumerico.Text;
                    textBoxNumerico.Enabled = false;
                    textBoxNumerosEnteros.Focus();
                }
            }
        }

        private bool ValidarNumerico(KeyPressEventArgs e)
        {
            bool valid = false;
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                valid = true;
                e.Handled = true;
            }

            return valid;
        }

        private void textBoxNumerosEnteros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidarEnteros(sender, e))
            {
                if (e.KeyChar == 13)
                {
                    NumerosEnteros.Text = textBoxNumerosEnteros.Text;
                    textBoxNumerosEnteros.Enabled = false;
                    textBoxNumerosReales.Focus();
                }
            }
        }

        private bool ValidarEnteros(object sender, KeyPressEventArgs e)
        {
            bool valid = false;
            TextBox miTb = (TextBox)sender;
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == '-'))
            {
                e.Handled = true;
                valid = true;
            }
            else
            {
                if (e.KeyChar == 45)
                {
                    if (!(miTb.SelectionStart == 0 && !miTb.Text.Contains("-")))
                    {
                        e.Handled=true;
                        valid = true;
                    }
                }
                else
                {
                    if (miTb.Text.Contains('-') && miTb.SelectionStart == 0)
                    {
                        e.Handled = true;
                        valid = true;
                    }
                }
            }

            return valid;
        }

        private void textBoxNumerosReales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidarNumerosReales(sender, e))
            {
                if (e.KeyChar == 13)
                {
                    NumerosReales.Text = textBoxNumerosReales.Text;
                    textBoxNumerosReales.Enabled = false;
                    textBoxLetras.Focus();
                }
            }
        }

        private bool ValidarNumerosReales(object sender, KeyPressEventArgs e)
        {
            bool valid = false;
            TextBox miTb = (TextBox)sender;

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == '-' || e.KeyChar == ','))
            {
                e.Handled = true;
                valid = true;
            }
            else
            {
                if (e.KeyChar == 45)
                {
                    if (!(miTb.SelectionStart == 0 && !miTb.Text.Contains("-")))
                    {
                        e.Handled = true;
                        valid = true;
                    }
                }
                else
                {
                    if (e.KeyChar == ',')
                    {
                        if (!(miTb.SelectionStart != 0 && miTb.SelectionStart != 1 && !miTb.Text.Contains(",")))
                        {
                            e.Handled = true;
                            valid = true;
                        }
                    }
                    else
                    {
                        if (miTb.Text.Contains('-') && miTb.SelectionStart == 0)
                        {
                            e.Handled = true;
                            valid = true;
                        }
                    }
                }
            }

            return valid;
        }

        private void textBoxLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidarLetras(e))
            {
                if (e.KeyChar == 13)
                {
                    Letras.Text = textBoxLetras.Text;
                    textBoxLetras.Enabled = false;
                    textBoxAlfaNumerico.Focus();
                }
            }
        }

        private bool ValidarLetras(KeyPressEventArgs e)
        {
            bool valid = false;
            if ((!char.IsLetter(e.KeyChar)) && e.KeyChar != 8)
            {
                valid = true;
                e.Handled = true;
            }

            return valid;
        }

        private void textBoxAlfaNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidarLetrasYNumeros( e))
            {
                if (e.KeyChar == 13)
                {
                    LetrasYNumeros.Text = textBoxAlfaNumerico.Text;
                    textBoxAlfaNumerico.Enabled = false;
                    NIF.Focus();
                }
            }
        }

        private bool ValidarLetrasYNumeros(KeyPressEventArgs e)
        {
            bool valid = false;
            if (!(char.IsLetterOrDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                valid = true;
                e.Handled = true;
            }

            return valid;
        }

        private void textBoxNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidarNIF(sender, e))
            {
                if (e.KeyChar == 13)
                {
                    NIF.Text = textBoxNIF.Text;
                    textBoxNIF.Enabled = false;
                    MessageBox.Show("Todo Correcto");
                }
            }
        }
        private bool ValidarNIF(object sender, KeyPressEventArgs e)
        {
            bool valid = false;
            TextBox miTb = (TextBox)sender;

            if (miTb.SelectionStart < 8)
            {
                if ((!(char.IsDigit(e.KeyChar)) && e.KeyChar != 8))
                {
                    valid = true;
                    e.Handled = true;
                }
            }
            else
            {
                if (miTb.SelectionStart == 8)
                {
                    if ((!(char.IsLetter(e.KeyChar)) && e.KeyChar != 8))
                    {
                        valid = true;
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }

            if (miTb.Text.Length == 9)
            {
                e.Handled = true;
                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                }
            }

            return valid;
        }
    }
}