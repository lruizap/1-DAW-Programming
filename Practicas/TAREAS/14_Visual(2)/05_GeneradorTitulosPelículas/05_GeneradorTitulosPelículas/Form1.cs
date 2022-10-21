namespace _05_GeneradorTitulosPelículas
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        List<string> list = new List<string>();
        List<string> list2 = new List<string>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TítuloLabel.ForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fichero1 = "uno.txt", ficheros2 = "dos.txt";
            StreamReader sr2 = new StreamReader(ficheros2);
            StreamReader sr = new StreamReader(fichero1);

            string[] linea;
            string[] lineb;

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine().Split(", ");
                for (int i = 0; i < linea.Length; i++)
                {
                    list.Add(linea[i]);
                    comboBox1.Items.Add(linea[i]);
                }
            }

            sr.Close();

            while (!sr2.EndOfStream)
            {
                lineb = sr2.ReadLine().Split(", ");
                for (int i = 0; i < lineb.Length; i++)
                {
                    list2.Add(lineb[i]);
                    comboBox2.Items.Add(lineb[i]);
                }
            }

            sr2.Close();
        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            TítuloLabel.Visible = true;
            timer1.Start();
            TítuloLabel.Text = comboBox1.Text + " " + comboBox2.Text;
        }

        private void AleatorioButton_Click(object sender, EventArgs e)
        {
            TítuloLabel.Visible = true;
            timer1.Start();
            Random r2 = new Random();
            TítuloLabel.Text = (list[r2.Next(comboBox1.Items.Count)] + " " + list2[r2.Next(comboBox2.Items.Count)]);
        }
    }
}