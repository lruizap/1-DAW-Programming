using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Mi_Primera_DB__Chispas
{
    public partial class Añadir : Form
    {
        public string[] lista = { };
        SQLiteConnection conn2;
        public Añadir()
        {
            InitializeComponent();
        }

        public Añadir(string[] linea) : this()
        {
            for (int i = 0; i < linea.Length; i++)
            {
                textBox1codigo.Text = linea[0];

                textBox4Descripcion.Text = linea[1];

                textBox2precio.Text = linea[2];

                textBox3stock.Text = linea[3];
            }

            lista = linea;
        }

        private void textBox2precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarPrecio(sender, e);
        }

        private bool ValidarPrecio(object sender, KeyPressEventArgs e)
        {
            bool valid = false;
            TextBox miTb = (TextBox)sender;

            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == ',')
            {
                if (e.KeyChar == ',')
                {
                    if (miTb.SelectionStart != 0 && !miTb.Text.Contains(","))
                    {
                        valid = true;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
            else
            {
                e.Handled = true;
            }

            return valid;
        }

        private void textBox3stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarINT(sender, e);
        }

        private bool ValidarINT(object sender, KeyPressEventArgs e)
        {
            bool valid = false;
            TextBox miTb = (TextBox)sender;

            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                valid = true;
            }
            else
            {
                e.Handled = true;
            }

            return valid;
        }

        private void textBox1codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarINT(sender, e);
        }

        private void button1Aceptar_Click(object sender, EventArgs e)
        {
            //Form1 f1 = new Form1();
            //conn2 = new SQLiteConnection("Data Source=" + f1.DB + ";Version=3;");
            //conn2.Open();

            int codigo, stock;
            double precio;

            codigo = int.Parse(textBox1codigo.Text);
            stock = int.Parse(textBox3stock.Text);
            precio = double.Parse(textBox2precio.Text);

            lista = (codigo + "-" + textBox4Descripcion.Text + "-" + precio + "-" + stock).Split("-");

            //SQLiteCommand cmd = new SQLiteCommand(conn2);

            //cmd.CommandText = "INSERT INTO productos VALUES(" + codigo + ", '" + textBox4Descripcion.Text + "'," + precio + "," + stock + ");";
            //// tener en cuenta qe el teto se debe estar entre comillas simples

            //MessageBox.Show(cmd.CommandText); // para ver que lo esta haciendo bien 

            //cmd.ExecuteNonQuery(); // para que haga el comando el programa

            textBox1codigo.Text = "";
            textBox4Descripcion.Text = "";
            textBox2precio.Text = "";
            textBox3stock.Text = "";

            this.DialogResult = DialogResult.OK;
        }
    }
}
