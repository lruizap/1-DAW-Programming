namespace _02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Estas seguro que quieres borrar?",
               "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Estas seguro que quieres guardar?",
               "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                FileStream fs = new FileStream("02_visual.txt", FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);

                for (int i = 0; i < textBox1.TextLength; i++)
                {
                    bw.Write(textBox1.Text[i]);
                }

                fs.Close();
                bw.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("02_visual.txt");
            while (!sr.EndOfStream)
            {
                textBox1.Text += sr.ReadToEnd();
            }

            sr.Close();
        }
    }
}