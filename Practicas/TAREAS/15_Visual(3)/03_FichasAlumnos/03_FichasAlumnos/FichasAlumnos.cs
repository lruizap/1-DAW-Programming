using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_FichasAlumnos
{
    public partial class FichasAlumnos : Form
    {
        public string[] linea = { };

        public FichasAlumnos()
        {
            InitializeComponent();
        }

        public FichasAlumnos(string[] lista) : this()
        {
            for (int i = 0; i < lista.Length; i++)
            {
                textBox1Nombre.Text = lista[0];

                dateTimePicker1.Value = DateTime.Parse(lista[1]);

                if (lista[2] == "Hombre")
                {
                    radioButton1Hombre.Checked = true;
                }
                else
                {
                    radioButton2Mujer.Checked = true;
                }

                if (lista[3] == "SI")
                {
                    checkBox1Repetidor.Checked = true;
                }
                else
                {
                    checkBox1Repetidor.Checked = false;
                }

                textBox1Nota.Text = lista[4];
            }

            linea = lista;
        }

        private bool ValidarNotasConDecimales(object sender, KeyPressEventArgs e)
        {
            bool valid = false;
            TextBox miTb = (TextBox)sender;

            if (miTb.SelectionStart < 4 && miTb.Text.Length < 4)
            {
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == ','))
                {
                    e.Handled = true;
                    valid = true;
                }
                else
                {
                    if (e.KeyChar == ',')
                    {
                        if (!(miTb.SelectionStart != 0 && miTb.SelectionStart <= 2 && !miTb.Text.Contains(",")))
                        {
                            e.Handled = true;
                            valid = true;
                        }
                    }
                }
            }
            else
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }

            return valid;
        }

        private void textBox1Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidarLetras(e))
            {
                if (e.KeyChar == 13)
                {
                    dateTimePicker1.Focus();
                }
            }
        }

        private bool ValidarLetras(KeyPressEventArgs e)
        {
            bool valid = false;
            if ((!char.IsLetter(e.KeyChar)) && e.KeyChar != 8 && e.KeyChar != ' ')
            {
                valid = true;
                e.Handled = true;
            }

            return valid;
        }

        private void textBox1Nota_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (ValidarNotasConDecimales(sender, e))
            {
                if (e.KeyChar == 13)
                {
                    button1Aceptar.Focus();
                }
            }
        }

        private void button1Aceptar_Click(object sender, EventArgs e)
        {
            if (textBox1Nombre.Text.Length>0 && dateTimePicker1.Value <= DateTime.Now.AddYears(-18) &&
                (radioButton1Hombre.Checked || radioButton2Mujer.Checked) && compruebaNota(textBox1Nota.Text))
            {
                string sexo, repetidor;

                if (radioButton1Hombre.Checked)
                {
                    sexo = "Hombre";
                }
                else
                {
                    sexo = "Mujer";
                }

                if (checkBox1Repetidor.Checked)
                {
                    repetidor = "SI";
                }
                else
                {
                    repetidor = "NO";
                }

                //string nota1 = textBox1Nota.Text.Replace(".", ",");
                //decimal nota2 = decimal.Parse(nota1);
                //decimal nota3 = Math.Round(nota2, 2);

                linea = (textBox1Nombre.Text + ";" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + ";" +
                    sexo + ";" + repetidor + ";" + textBox1Nota.Text).Split(";");

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Compruebe los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool compruebaNota(string text)
        {
            string text2 = text.Replace(".", ",");

            decimal n;

            if (decimal.TryParse(text2,out n))
            {
                if (n >= 0 && n <= 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
        }
    }
}
