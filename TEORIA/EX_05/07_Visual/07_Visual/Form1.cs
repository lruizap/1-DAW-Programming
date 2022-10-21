namespace _07_Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // El reseultado de lo que se ha escrito por teclado (lo que te ha llegado omitiendo que teclas has pulsado)

            //char c = e.KeyChar;

            //e.Handled = true; // esto hace que la letra pulsada no llegue a ninguna parte

            if (e.KeyChar == ' ' && textBox1.SelectionStart != textBox1.Text.Length)
            {
                e.Handled = true;   
            }

            //Mirar las teclas en la tabla ASCII

            if (e.KeyChar == 13)
            {
                label1.Text = textBox1.Text;
                textBox1.Text = "";
                e.Handled=true;
                textBox2.Focus();
            }

            if (e.KeyChar == 27)
            {
                textBox1.Text = "";
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            // Las teclas que se han pulsado en el teclado

            if (e.KeyCode == Keys.T && e.Control && e.Alt)
            {
                textBox2.SelectAll();
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Escape && e.Shift)
            {
                textBox2.Clear();
                e.SuppressKeyPress=true;
            }
        }
    }
}