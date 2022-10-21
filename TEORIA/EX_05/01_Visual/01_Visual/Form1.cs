namespace _01_Visual
{
    public partial class Form1 : Form
    {
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // text --> lo q se ve x pantalla --> cambia texto de la etiqueta


            if (textBox1.Text.Trim().Length > 0)
            {
                Texto_de_Dios.Text = "¡Hola, " + textBox1.Text + " !";
                timer1.Start();

                // textBox1.Hide(); 
                // textBox1.Enabled = false; --> más recomendado pq lo desabilita
                // textBox1.ReadOnly = true; deja seleccionar y copiar
            }
            else
            {
                MessageBox.Show("Error, el contenido debe ser un nombre", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox myTextBox = (TextBox)sender;
            myTextBox.Text = "";
            textBox2.Text = "";
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Texto_de_Dios.ForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Estas seguro que quieres cerrar?",
                "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
