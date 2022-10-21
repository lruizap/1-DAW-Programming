using BrightIdeasSoftware;
namespace _04_Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listView1.Columns.Add("Patata");
            //listView1.Columns[4].Width = 100;
            //listView1.Columns[4].TextAlign = HorizontalAlignment.Right;

            //listView1.Items.Add("Patata");
            //listView1.Items[listView1.Items.Count-1].SubItems.Add("Patata1");
            //listView1.Items[listView1.Items.Count - 1].SubItems.Add("Patata2");
            //listView1.Items[listView1.Items.Count - 1].SubItems.Add("Patata3");
            //listView1.Items.Count - 1 --> ultima linea añadida 

            string[] campos = { "patata1", "patata2", "patata3", "patata4" };
            listView1.Items.Insert(0, new ListViewItem(campos));

            listView1.Items[0].SubItems[2].Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            objectListView2.Columns.Add(new OLVColumn("nombre", "nombre"));
            objectListView2.Columns.Add(new OLVColumn("tipo", "tipo"));
            objectListView2.Columns.Add(new OLVColumn("desmayado", "desmayado"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //List<Pokemon> lista = new List<Pokemon>();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count>0)
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }

            int pos = listView1.SelectedIndices[0];
            listView1.Items.RemoveAt(pos);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = listView1.SelectedIndices.Count-1; i >= 0 ; i--)
            {
                int pos = listView1.SelectedIndices[i];
                listView1.Items.RemoveAt(pos);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //int pos = listView1.SelectedIndices[0];
            //string id = listView1.SelectedIndices[1];
            //string nombre = listView1.SelectedIndices[1];
            //string tipo = listView1.SelectedIndices[1];

            //MessageBox.Show(id + nombre + tipo);

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}