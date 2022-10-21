namespace _07_VisualGatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CargarFicheroTXT();
            buttonBorrar.Enabled = false;
            buttonModificar.Enabled = false;
        }

        private void CargarFicheroTXT()
        {
            StreamReader sr = new StreamReader("ficheroPrueba.txt");
            string[] linea;
            int i = 0;
            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine().Split(";");
                if (i == 0)
                {
                    for (int k = 0; k < linea.Length; k++)
                    {
                        listView1.Columns.Add(linea[k]);
                    }
                }
                else
                {
                    listView1.Items.Add(new ListViewItem(linea));
                }

                i++;
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            sr.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarFicheroTXT();
        }

        private void GuardarFicheroTXT()
        {
            StreamWriter sw = new StreamWriter("ficheroPrueba.txt");

            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                if (i == listView1.Columns.Count - 1)
                {
                    sw.Write(listView1.Columns[i].Text + "\n");
                }
                else
                {
                    sw.Write(listView1.Columns[i].Text + ";");
                }
            }

            for (int j = 0; j < listView1.Items.Count; j++)
            {
                for (int k = 0; k < listView1.Items[j].SubItems.Count; k++)
                {
                    if (k == listView1.Items[j].SubItems.Count - 1)
                    {
                        sw.Write(listView1.Items[j].SubItems[k].Text + "\n");
                    }
                    else
                    {
                        sw.Write(listView1.Items[j].SubItems[k].Text + ";");
                    }
                }
            }

            sw.Close();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            textBoxColorPelo.Text = "";
            textBoxRaza.Text = "";
            textBoxPeso.Text = "";
            textBoxTamaño.Text = "";
            textBoxColorOjos.Text = "";
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != string.Empty && textBoxColorPelo.Text != string.Empty && textBoxRaza.Text != string.Empty && textBoxPeso.Text != string.Empty && textBoxTamaño.Text != string.Empty && textBoxColorOjos.Text != string.Empty)
            {
                string linea = textBoxNombre.Text + ";" + textBoxColorPelo.Text + ";" + textBoxRaza.Text + ";" + textBoxPeso.Text + ";" + textBoxTamaño.Text + ";" + textBoxColorOjos.Text;
                string[] lineaSplit = linea.Split(';');

                listView1.Items.Add(new ListViewItem(lineaSplit));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                buttonBorrar.Enabled = true;
                buttonModificar.Enabled = true;
            }
            else
            {
                buttonBorrar.Enabled = false;
                buttonModificar.Enabled = false;
            }

            for (int i = 0; i < listView1.SelectedIndices.Count; i++)
            {
                for (int j = 0; j < listView1.SelectedItems[i].SubItems.Count; j++)
                {
                    textBoxNombre.Text = listView1.SelectedItems[i].SubItems[0].Text;
                    textBoxColorPelo.Text = listView1.SelectedItems[i].SubItems[1].Text;
                    textBoxRaza.Text = listView1.SelectedItems[i].SubItems[2].Text;
                    textBoxPeso.Text = listView1.SelectedItems[i].SubItems[3].Text;
                    textBoxTamaño.Text = listView1.SelectedItems[i].SubItems[4].Text;
                    textBoxColorOjos.Text = listView1.SelectedItems[i].SubItems[5].Text;
                }
            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
            buttonBorrar.Enabled = false;

            textBoxNombre.Text = "";
            textBoxColorPelo.Text = "";
            textBoxRaza.Text = "";
            textBoxPeso.Text = "";
            textBoxTamaño.Text = "";
            textBoxColorOjos.Text = "";
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.SelectedIndices.Count; i++)
            {
                for (int j = 0; j < listView1.SelectedItems[i].SubItems.Count; j++)
                {
                    listView1.SelectedItems[i].SubItems[0].Text = textBoxNombre.Text;
                    listView1.SelectedItems[i].SubItems[1].Text  = textBoxColorPelo.Text;
                    listView1.SelectedItems[i].SubItems[2].Text = textBoxRaza.Text;
                    listView1.SelectedItems[i].SubItems[3].Text = textBoxPeso.Text;
                    listView1.SelectedItems[i].SubItems[4].Text = textBoxTamaño.Text;
                    listView1.SelectedItems[i].SubItems[5].Text = textBoxColorOjos.Text;
                }
            }
        }
    }
}