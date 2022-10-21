namespace _08_Bloc_De_Notas
{
    public partial class Form1 : Form
    {
        bool modificado = false;
        string nombre = "";
        public Form1()
        {
            InitializeComponent();
            EnableBottoms();
        }

        private void EnableBottoms()
        {
            if (TextotextBox1.SelectedText.Length > 0)
            {
                copiarToolStripMenuItem.Enabled = true;
                copiarToolStripMenuItem1.Enabled = true;
                cortarToolStripMenuItem.Enabled = true;
                cortarToolStripMenuItem1.Enabled = true;
                eliminarToolStripMenuItem.Enabled = true;
                eliminarToolStripMenuItem1.Enabled=true;
            }
            else
            {
                copiarToolStripMenuItem.Enabled = false;
                copiarToolStripMenuItem1.Enabled = false;
                cortarToolStripMenuItem.Enabled = false;
                cortarToolStripMenuItem1.Enabled = false;
                eliminarToolStripMenuItem.Enabled=false;
                eliminarToolStripMenuItem1.Enabled=false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            modificado = true;
            EnableBottoms();
            int letras = 0;
            for (int i = 0; i < TextotextBox1.Text.Length; i++)
            {
                letras++;
            }

            LIneaColumnatoolStripStatusLabel1.Text = "Líneas "
                + letras.ToString()
                + ", columnas"
                + (TextotextBox1.Lines.Count() -1) ;
        }

        private void nUevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modificado == true)
            {
                DialogResult dr = MessageBox.Show("¿Quieres borrarlo sin guardar?",
                "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    GuardarFicheroTXT();
                    MessageBox.Show("El documento ha sido guardado");
                }
                else
                {
                    TextotextBox1.Text = "";
                    nombre = "";
                }
            }
            else
            {
                TextotextBox1.Text = "";
                nombre = "";
            }
        }

        private void GuardarFicheroTXT()
        {
            modificado = true;

            DialogResult dr = saveFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, TextotextBox1.Text);

                nombre = saveFileDialog1.FileName;
            }

            //StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

            //sw.Write(TextotextBox1.Text);

            //sw.Close();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modificado == true)
            {
                DialogResult dr = MessageBox.Show("¿Quieres abrir otro documento sin guardar?",
                "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    AbrirFicheroTXT();
                }
            }
            else
            {
                AbrirFicheroTXT();
               
            }
        }

        private void AbrirFicheroTXT()
        {
            DialogResult dr = openFileDialog1.ShowDialog();
           
            if(dr == DialogResult.OK)
            {
                TextotextBox1.Text = File.ReadAllText(openFileDialog1.FileName);

                nombre = openFileDialog1.FileName;
            }

            //StreamReader sr = new StreamReader(openFileDialog1.FileName);

            //TextotextBox1.Text = sr.ReadToEnd();

            //sr.Close();

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarFicheroTXT();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarFicheroTXT();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modificado == true)
            {
                DialogResult dr = MessageBox.Show("¿Quieres salir sin guardar?",
                "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    GuardarFicheroTXT();
                    Close();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void barraDeEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (barraDeEstadoToolStripMenuItem.Checked)
            {
                statusStrip1.Visible = false;
                barraDeEstadoToolStripMenuItem.Checked = false;
            }
            else
            {
                statusStrip1.Visible = true;
                barraDeEstadoToolStripMenuItem.Checked = true;
            }
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextotextBox1.Undo();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextotextBox1.Cut();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextotextBox1.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextotextBox1.Paste();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextotextBox1.SelectAll();
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            TextotextBox1.Font = fontDialog1.Font;
        }

        private void horaYFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextotextBox1.Text += DateTime.Now.ToString("HH:mm dd:MM:yyyy");
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TextotextBox1.SelectionLength > 0)
            {
                TextotextBox1.Text = TextotextBox1.Text.Remove(TextotextBox1.SelectionStart, TextotextBox1.SelectionLength);
            }
        }

        private void AjusteDeLineatoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (AjusteDeLineatoolStripMenuItem1.Checked)
            {
                TextotextBox1.WordWrap = false;
                AjusteDeLineatoolStripMenuItem1.Checked = false; 
            }
            else
            {
                TextotextBox1.WordWrap = true;
                AjusteDeLineatoolStripMenuItem1.Checked = true;
            }
        }

        private void TextotextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            EnableBottoms();
        }

        private void TextotextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            EnableBottoms();
        }

        private void TextotextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            EnableBottoms();
        }

        private void TextotextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            EnableBottoms();
        }
    }
}