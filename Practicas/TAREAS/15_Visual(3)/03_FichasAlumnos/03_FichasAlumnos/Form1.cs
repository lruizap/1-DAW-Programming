using System.Globalization;
using System.IO;

namespace _03_FichasAlumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            modificarToolStripMenuItem.Enabled = false;
            eliminarToolStripMenuItem.Enabled = false;

            CargarDatos("alumnos.bin");

        }

        private void CargarDatos(string fichero)
        {
            if (File.Exists(fichero))
            {
                FileStream fs = new FileStream("alumnos.bin", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                int num = br.ReadInt32();

                for (int i = 0; i < num; i++)
                {
                    string nombre = br.ReadString();

                    long fechaNac = br.ReadInt64(); //datetime
                    DateTime fecha2 = new DateTime(fechaNac);
                    string fecha3 = fecha2.ToString("dd/MM/yyyy");

                    string sexo = br.ReadString();
                    string repetidor = br.ReadString();
                    string notaFinal = br.ReadString();

                    string[] campos = { nombre, fecha3, sexo, repetidor, notaFinal };
                    listView1.Items.Add(new ListViewItem(campos));
                }

                br.Close();
                fs.Close();
            }
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FichasAlumnos f2 = new FichasAlumnos();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                listView1.Items.Add(new ListViewItem(f2.linea));
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                modificarToolStripMenuItem.Enabled = true;
                eliminarToolStripMenuItem.Enabled = true;
            }
            else
            {
                modificarToolStripMenuItem.Enabled = false;
                eliminarToolStripMenuItem.Enabled = false;
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
            eliminarToolStripMenuItem.Enabled = false;

            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                }

                while (listView1.SelectedItems.Count > 0)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                List<string> linea = new List<string>();

                for (int i = 0; i < listView1.SelectedIndices.Count; i++)
                {
                    for (int j = 0; j < listView1.SelectedItems[i].SubItems.Count; j++)
                    {
                        linea.Add(listView1.SelectedItems[i].SubItems[j].Text);
                    }
                }

                string[] array = linea.ToArray();

                FichasAlumnos f2 = new FichasAlumnos(array);
                array = f2.linea;

                if (f2.ShowDialog() == DialogResult.OK)
                {
                    listView1.Items.Add(new ListViewItem(f2.linea));
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarDatos("alumnos.bin");
        }

        private void GuardarDatos(string fichero)
        {
            FileStream fs = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            int num = listView1.Items.Count;

            bw.Write(num);

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                bw.Write(listView1.Items[i].SubItems[0].Text);

                string fecha = listView1.Items[i].SubItems[1].Text;
                DateTime fecha2 = DateTime.ParseExact(fecha,"dd/MM/yyyy",null);
                long fecha3 = fecha2.ToBinary();

                bw.Write(fecha3);

                bw.Write(listView1.Items[i].SubItems[2].Text);
                bw.Write(listView1.Items[i].SubItems[3].Text);
                bw.Write(listView1.Items[i].SubItems[4].Text);
            }

            bw.Close();
            fs.Close();
        }


    }
}