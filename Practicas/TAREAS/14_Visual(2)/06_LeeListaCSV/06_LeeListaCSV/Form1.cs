namespace _06_LeeListaCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CargarDatosButton_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            if (File.Exists(NombreFicheroTextBox.Text))
            {
                StreamReader sr = new StreamReader(NombreFicheroTextBox.Text);

                string[] linea;

                int i = 0, j;

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
            else
            {
                MessageBox.Show("No existe el fichero");
            }
        }
    }
}