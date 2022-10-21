namespace _06_Traductor_inglés_español
{
    public partial class Traductor : Form
    {
        List<string> esp = new List<string>();
        List<string> en = new List<string>();

        public Traductor()
        {
            InitializeComponent();

            esp.Clear();
            en.Clear();

            StreamReader sr = new StreamReader("Traducciones.txt");
            string[] linea;

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine().Split(", ");
                esp.Add(linea[0]);
                en.Add(linea[1]);
            }

            sr.Close();
        }

        private void Traductor_Load(object sender, EventArgs e)
        {
            
        }

        private void ENES_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < en.Count; i++)
            {
                if (ingles.Text == en[i])
                {
                    español.Text = esp[i];
                    i = en.Count;
                }
                else
                {
                    español.Text = "ERROR";
                }
            }
        }

        private void ESEN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < esp.Count; i++)
            {
                if (español.Text == esp[i])
                {
                    ingles.Text = en[i];
                    i = en.Count;
                }
                else
                {
                    ingles.Text = "ERROR";
                }
            }
        }
    }
}