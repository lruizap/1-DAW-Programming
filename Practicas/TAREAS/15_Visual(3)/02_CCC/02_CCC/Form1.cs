namespace _02_CCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validate4Numbers(sender, e))
            {
                if (e.KeyChar == 13)
                {
                    textBox2.Focus();
                }
            }
        }

        private bool Validate4Numbers(object sender, KeyPressEventArgs e)
        {
            bool isValid = false;
            TextBox miTb = (TextBox)sender;

            if (miTb.SelectionStart < 4)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {
                    isValid = true;
                    e.Handled = true;
                }
            }
            else
            {
                if (e.KeyChar != 8)
                {
                    isValid = true;
                    e.Handled = true;
                }
            }
            return isValid;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validate4Numbers(sender, e))
            {
                if (e.KeyChar == 13)
                {
                    textBox3.Focus();
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validate4Numbers(sender, e))
            {
                if (e.KeyChar == 13)
                {
                    textBox4.Focus();
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validate4Numbers(sender, e))
            {
                if (e.KeyChar == 13 && (textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text).Length == 16)
                {
                    if (isValidCCC(textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text))
                    {
                        MessageBox.Show("Es válido");
                    }
                    else
                    {
                        MessageBox.Show("No es válido");
                    }
                }
            }
        }

        private bool isValidCCC (string NumeroT)
        {
            //int[] array = new int[16];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = int.Parse(NumeroT[i].ToString());
            //}

            //for (int i = 0; i < array.Length; i= i+2)
            //{
            //    array[i] = array[i] * 2;

            //    if (array[i] >= 10)
            //    {
            //        array[i] = array[i] - 9;
            //    }
            //}

            //int suma = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    suma += array[i];
            //}

            //if (suma % 10 == 0)
            //{
            //    return true;
            //}
            //else
            //{ 
            //    return false;
            //}

            int[] array = new int[16];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(NumeroT[i].ToString());
            }

            for (int i = 0; i < array.Length; i = i + 2)
            {
                array[i] = array[i] * 2;

                if (array[i] >= 10)
                {
                    array[i] = array[i] - 9;
                }
            }
            int suma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                suma += array[i];
            }

            if (suma % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}