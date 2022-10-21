namespace _04_SuperTest
{
    public partial class Form1 : Form
    {
        int cont = 0;
        double puntuacion = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al test sobre redes.\n Pulse el botón para realizar el text");
            PreguntaLabel.Visible = true;
            PreguntaLabel.Text = ("Primera Pregunta : \n ¿Cómo se llama el objeto de la imágen?");
            cont = 1;
        }

        private void SiguienteButton_Click(object sender, EventArgs e)
        {
            cont++;

            if (cont == 2)
            {
                pictureBox1.ImageLocation = "switch.jpg";
                radioButton1.Text = "Servidor";
                radioButton3.Text = "Tarjeta de red";
                radioButton2.Text = "Switch";
            }

            if (cont == 3)
            {
                pictureBox1.ImageLocation = "tarjeta_de_red.jpg";
                radioButton1.Text = "Tarjeta Gráfica";
                radioButton3.Text = "Tarjeta de Red";
                radioButton2.Text = "Tarjeta de Sonido";
            }

            if (cont == 4)
            {
                SiguienteButton.Text = "Fin";
                groupBox1.Visible = false;
                pictureBox1.Visible = false;
                PreguntaLabel.Visible=false;
                ResultadoLabel.Visible=true;
                ResultadoLabel.Text = "Tu puntuación es de : " + puntuacion.ToString();
            }

            if (cont == 5)
            {
                Close();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if ((cont == 1 && radioButton3.Checked) || (cont == 3 && radioButton3.Checked))
            {
                puntuacion += 1;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (cont == 2 && radioButton2.Checked)
            {
                puntuacion += 1;
            }
        }
    }
}