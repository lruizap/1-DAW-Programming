namespace _08_Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.label1.Text = textBox1.Text;

            // el showdialog se queda bloqueado el primer form hasta que termina el form2
            DialogResult dr = f2.ShowDialog(); // hasta que no cierre la ventana no hace cosas

            string cadena = f2.textBox1.Text;

            MessageBox.Show("la cadena es: " + cadena);

            //if (dr == DialogResult.OK)
            //{
            //    MessageBox.Show("OK");
            //}
            //else
            //{
            //    MessageBox.Show("Cancel");
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.cadena = textBox2.Text;
            f2.ShowDialog();

            string s = f2.cadena;
            MessageBox.Show(s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(textBox3.Text);
            DialogResult dr = f2.ShowDialog();

            if (dr == DialogResult.OK)
            {
                MessageBox.Show(f2.cadena);
            }
        }
    }
}