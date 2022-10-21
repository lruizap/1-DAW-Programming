using System.Data.SQLite;

namespace _04_Mi_Primera_DB__Chispas
{
    public partial class Form1 : Form
    {
        SQLiteConnection conn;
        public string DB = "db.db";
        public Form1()
        {
            InitializeComponent();
            EnabledButtons();
            CargarDB(DB);
        }
        private void EnabledButtons()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                modificarStockToolStripMenuItem.Enabled = true;
                eliminarToolStripMenuItem.Enabled = true;
                modificarStockToolStripMenuItem1.Enabled = true;
                eliminarToolStripMenuItem1.Enabled = true;
            }
            else
            {
                modificarStockToolStripMenuItem.Enabled = false;
                eliminarToolStripMenuItem.Enabled = false;
                modificarStockToolStripMenuItem1.Enabled = false;
                eliminarToolStripMenuItem1.Enabled = false;
            }
        }

        private void CargarDB(string dB)
        {
            if (File.Exists(dB))
            {
                conn = new SQLiteConnection("Data Source=" + dB + ";Version=3;");
                conn.Open();

                listView1.Items.Clear();

                SQLiteCommand cmd = new SQLiteCommand(conn);

                cmd.CommandText = "SELECT * FROM productos;";

                //ORDER BY texto

                // tener en cuenta qe el teto se debe estar entre comillas simples

                SQLiteDataReader data = cmd.ExecuteReader(); // para que devuelva el dato que estamos preguntando

                int stock, codigo;
                string descripcion;
                double precio;
                string[] elemento;

                while (data.Read()) // lee 1 linea del listado de resultados
                {
                    codigo = data.GetInt32(0);
                    descripcion = data.GetString(1); // get para transformar el dato en el tipo de dato que queramos
                    precio = data.GetDouble(2);
                    stock = data.GetInt32(3);

                    elemento = (codigo.ToString() + "-" + descripcion + "-" + precio.ToString() + "-" + stock.ToString()).Split("-");

                    listView1.Items.Add(new ListViewItem(elemento));
                }

                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                data.Close(); // para leer datos, se debe cerrar la base de datos para que no pete
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Añadir f2 = new Añadir();
            //SQLiteCommand cmd = new SQLiteCommand(conn);
        }

        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Añadir f2 = new Añadir();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                conn = new SQLiteConnection("Data Source=" + DB + ";Version=3;");
                conn.Open();

                SQLiteCommand cmd = new SQLiteCommand(conn);

                cmd.CommandText = "INSERT INTO productos VALUES(" + f2.lista[0] + ", '" + f2.lista[1] + "'," + f2.lista[2] + "," + f2.lista[3] + ");";
                
                cmd.ExecuteNonQuery();

                listView1.Items.Add(new ListViewItem(f2.lista));
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand(conn);
            if (listView1.SelectedItems.Count > 0)
            {
                while (listView1.SelectedItems.Count > 0)
                {
                    cmd.CommandText = "DELETE FROM productos WHERE codigo =" + listView1.SelectedItems[0].SubItems[0].Text + ";";
                    cmd.ExecuteNonQuery();
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }

            eliminarToolStripMenuItem.Enabled = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabledButtons();
        }

        private void modificarStockToolStripMenuItem_Click(object sender, EventArgs e)
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

                Añadir f2 = new Añadir(array);
                array = f2.lista;

                SQLiteCommand cmd = new SQLiteCommand(conn);

                if (f2.ShowDialog() == DialogResult.OK)
                {
                    cmd.CommandText = "UPDATE productos SET stock =" + f2.lista[3] + " WHERE codigo =" + listView1.SelectedItems[0].SubItems[0].Text + ";";
                    cmd.ExecuteNonQuery();
                    listView1.Items.Add(new ListViewItem(f2.lista));
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }

            modificarStockToolStripMenuItem.Enabled = false;
        }
    }
}