namespace _07_Mini_Agenda
{
    public partial class Form1 : Form
    {
        DateTime d = DateTime.Now;
        bool modificado = false;
        public Form1()
        {
            InitializeComponent();

            textBox2Dia.Text = d.Day.ToString();
            textBox4Mes.Text = d.Month.ToString();
            textBox3Año.Text = d.Year.ToString();

            Cargar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox1.Text = d.Day.ToString() + d.Month.ToString() + d.Year.ToString();
        }

        private void atrás_Click(object sender, EventArgs e)
        {
            Guardar();

            d = d.AddDays(-1);
            textBox2Dia.Text = d.Day.ToString();
            textBox4Mes.Text = d.Month.ToString();
            textBox3Año.Text = d.Year.ToString();

            Cargar();            
        }

        private void delante_Click(object sender, EventArgs e)
        {
            Guardar();

            d = d.AddDays(+1);
            textBox2Dia.Text = d.Day.ToString();
            textBox4Mes.Text = d.Month.ToString();
            textBox3Año.Text = d.Year.ToString();

            Cargar();
        }

        private void Cargar()
        {
            string fichero = d.ToString("ddMMyyyy") + ".txt";
            if (File.Exists(fichero))
            {
                StreamReader sr = new StreamReader(fichero);
                while (!sr.EndOfStream)
                {
                    textBox1.Text = sr.ReadToEnd();
                }

                sr.Close();
            }
            else
            {
                textBox1.Text = "";
            }
            modificado = false;
        }

        private void Guardar()
        {
            string fichero = d.ToString("ddMMyyyy") + ".txt";

            if (modificado)
            {
                FileStream fs = new FileStream(fichero, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);

                for (int i = 0; i < textBox1.TextLength; i++)
                {
                    bw.Write(textBox1.Text[i]);
                }

                fs.Close();
                bw.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            modificado = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Guardar();
        }
    }
}