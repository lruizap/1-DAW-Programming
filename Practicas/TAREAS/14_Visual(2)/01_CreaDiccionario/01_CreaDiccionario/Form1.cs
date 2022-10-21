namespace _01_CreaDiccionario
{
    public partial class Form1 : Form
    {
        List<string> esp = new List<string>();
        List<string> en = new List<string>();
        bool modificado = false;

        public Form1()
        {
            InitializeComponent();
            Cargar();
        }

        private void Cargar()
        {
            if (File.Exists("diccionario.txt"))
            {
                string linea;
                FileStream fs = new FileStream("diccionario.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    linea = sr.ReadLine();
                    Diccionario.Items.Add(linea);
                }

                sr.Close();
                fs.Close();
            }
        }

        private void Guardar()
        {
            if (modificado)
            {
                FileStream fs = new FileStream("diccionario.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                for (int i = 0; i < en.Count; i++)
                {
                    sw.Write(en[i] + ", " + esp[i] + Environment.NewLine);
                }

                sw.Close();
                fs.Close();
            }
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            if (PalESP.Text.Trim() != string.Empty && PalEN.Text.Trim() != string.Empty)
            {
                esp.Add(PalESP.Text);
                en.Add(PalEN.Text);

                Diccionario.Items.Add(PalEN.Text + ", " + PalESP.Text);

                PalEN.Text = "";
                PalESP.Text = "";
            }
        }

        private void Diccionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Diccionario.SelectedIndex != -1) // comprueba que hay algo seleccionado.
            {
                string[] linea = Diccionario.Text.Split(", ");
                for (int i = 0; i < linea.Length; i++)
                {
                    PalEN.Text = linea[0];
                    PalESP.Text = linea[1];
                }
                
                DeleteB.Enabled = true;
            }
            else
            {

                DeleteB.Enabled = false;
            }
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            if (Diccionario.SelectedIndex != -1) // comprueba que hay algo seleccionado.
            {
                Diccionario.Items.RemoveAt(Diccionario.SelectedIndex);
                esp.Remove(PalESP.Text);
                en.Remove(PalEN.Text);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            modificado = true;
            Guardar();
        }
    }
}