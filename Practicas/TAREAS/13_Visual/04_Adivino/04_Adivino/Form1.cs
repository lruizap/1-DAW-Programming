namespace _04_Adivino
{
    public partial class Form1 : Form
    {
        public Random r = new Random();
        public int n;

        public Form1()
        {
            InitializeComponent();
            n = r.Next(1, 101);
            Numero.Text = n.ToString();
            intentos.Text = 0.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = n;
            n = r.Next(1, num);
            Numero.Text = n.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int num = n;
            n = r.Next(num, 101);
            Numero.Text = n.ToString();
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has acertado", "¡Felicidades!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}