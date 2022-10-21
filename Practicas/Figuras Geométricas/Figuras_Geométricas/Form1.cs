using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaidrollTeamWindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("Seleccionar");
            comboBox1.Items.Add("Circulo"); 
            comboBox1.Items.Add("Triangulo"); 
            comboBox1.Items.Add("Rectangulo"); 
            comboBox1.Items.Add("Cuadrado"); 
            comboBox1.Items.Add("Rombo"); 
            comboBox1.Items.Add("Paralelogramo"); 
            comboBox1.Items.Add("Trapecio"); 
            comboBox1.Items.Add("Pentagono"); 
            comboBox1.Items.Add("Hexagono");
            comboBox1.SelectedIndex = 0;
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != "") { txtresultado.Text = ""; }

            if (comboBox1.SelectedIndex == 1)
            {//Circulo
                txtresultado.Text += " " + Environment.NewLine;
                int x, y, radio;
                radio = int.Parse(txtnum1.Text);
                for (x = 0; x <= radio * 2; x++) 
                {
                    for (y = 0; y <= radio * 2; y++) 
                    {
                        if (Math.Pow(y - radio, 2) + Math.Pow(x - radio, 2) <= (int)Math.Pow(radio, 2))
                        {
                            txtresultado.Text += "*";
                        }
                        else
                        {
                            txtresultado.Text += " ";
                        }
                    }
                     txtresultado.Text += " "+ Environment.NewLine;
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {//triangulo
                int x, y, altura;
                altura = int.Parse(txtnum1.Text);
                txtresultado.Text += " " + Environment.NewLine;

                for (x = 1; x <= altura; x++)
                {
                    for (y = altura - x; y > 0; y--)
                    {
                        txtresultado.Text += " ";
                    }
                    for (y = 1; y < x; y++)
                    {
                        txtresultado.Text += " * * ";
                    }
                    txtresultado.Text += "*" + Environment.NewLine;
                }

            }
            if (comboBox1.SelectedIndex == 3)
            {//Rectangulo
                int base1, altura, x, y;
                base1 = int.Parse(txtnum1.Text);
                altura = int.Parse(txtnum2.Text);
                txtresultado.Text += " " + Environment.NewLine;

                for (x = 1; x <= altura; x++)
                {
                    for (y = 1; y <= base1; y++)
                    {
                        txtresultado.Text += "*  ";
                    }
                    txtresultado.Text += " " + Environment.NewLine;
                }
            }
            if (comboBox1.SelectedIndex == 4)
            {//Cuadrado
                int lado, x, y;
                lado = int.Parse(txtnum1.Text);
                txtresultado.Text += " " + Environment.NewLine;

                for (x = 1; x <= lado; x++)
                {
                    for (y = 1; y <= lado; y++)
                    {
                        txtresultado.Text += "*  ";
                    }
                    txtresultado.Text += " " + Environment.NewLine;
                }
            }
            if (comboBox1.SelectedIndex == 5)
            {//Rombo
                int x, y, lado;
                lado = int.Parse(txtnum1.Text);
      
        for (x = 0; x <= lado; x++)
                {
                    for (y = lado - x; y > 0; y--)
                    {
                        txtresultado.Text += " ";
                    }
                    for (y = 0; y < x; y++)
                    {
                        txtresultado.Text += "*  ";

                    }
                    txtresultado.Text += Environment.NewLine;
                }

                for (x = 0; x <= lado; x++)
                {
                    for (y = 0; y <= x; y++)
                    {
                        txtresultado.Text += " ";
                    }
                    for (y = lado - x - 1; y > 0; y--)
                    {
                        txtresultado.Text += "*  ";

                    }
                    txtresultado.Text +=  Environment.NewLine;
                }

            }
            if (comboBox1.SelectedIndex == 6)
            {//Paralelogramo
                int base1, altura, x, y;
                base1 = int.Parse(txtnum1.Text);
                altura = int.Parse(txtnum2.Text);
                txtresultado.Text += " " + Environment.NewLine;

                for (x = 1; x <= altura; x++)
                {
                    for (y = altura - x; y > 0; y--)
                    {
                        txtresultado.Text += " ";
                    }
                    for (y = 0; y < base1; y++)
                    {
                        txtresultado.Text += "  *";
                    }
                    txtresultado.Text += " " + Environment.NewLine;
                }
            }
            if (comboBox1.SelectedIndex == 7)
            {//Trapecio
                int base1, altura, x, y, z, aux;
                base1 = int.Parse(txtnum1.Text);
                altura = int.Parse(txtnum2.Text);

                txtresultado.Text += Environment.NewLine;

                aux = altura;
                for (x = 1; x <= altura; x++)
                {

                    for (y = aux; y > 1; y--)
                    {
                        txtresultado.Text += "  ";
                    }

                    for (z = 0; z < base1; z++)
                    {
                        txtresultado.Text += " *";
                    }

                    txtresultado.Text += " " + Environment.NewLine;

                    base1 = base1 + 4;
                    aux--;
                }
            }
            if (comboBox1.SelectedIndex == 8)
            {//Pentagono
                    int base1, x, y;
                 base1 = int.Parse(txtnum1.Text);
                txtresultado.Text += Environment.NewLine;

                for (x = 1; x <= base1; x++)
                    {
                        for (y = base1 - x; y > 0; y--)
                        {
                        txtresultado.Text += " ";
                    }
                        for (y = 1; y < x; y++)
                        {
                        txtresultado.Text += " * * ";
                    }
                    txtresultado.Text += "*" + Environment.NewLine;
                }

                    for (x = 1; x <= base1; x++)
                    {
                        for (y = 1; y <= base1; y++)
                        {
                        txtresultado.Text += " * * ";
                    }
                    txtresultado.Text +=  Environment.NewLine;
                }
                }
            if (comboBox1.SelectedIndex == 9)
            {//Hexagono
                int x, y, base1;

                base1 = int.Parse(txtnum1.Text);

                txtresultado.Text += Environment.NewLine;

                for (x = 0; x < base1 - 1; x++)
                {
                    txtresultado.Text += " ";
                }
                for (x = 0; x < base1; x++)
                {
                    txtresultado.Text += "*";
                }

                for (y = 1; y < base1 - 1; y++)
                {
                    txtresultado.Text += " " + Environment.NewLine;
                    for (x = 0; x < base1 - y - 1; x++)
                    {
                        txtresultado.Text += " ";
                    }
                    txtresultado.Text += "*";
                    for (x = 0; x < base1 + 2 * y - 2; x++)
                    {
                        txtresultado.Text += "*";
                    }
                    txtresultado.Text += "*";
                }

                for (y = base1; y > 1; y--)
                {
                    txtresultado.Text += " " + Environment.NewLine;
                    for (x = 0; x < base1 - y; x++)
                    {
                        txtresultado.Text += " ";
                    }
                    txtresultado.Text += "*";
                    for (x = 0; x < base1 + 2 * y - 4; x++)
                    {
                        txtresultado.Text += "*";
                    }
                    txtresultado.Text += "*";
                }

                txtresultado.Text += " " + Environment.NewLine;
                for (x = 0; x < base1 - 1; x++)
                {
                    txtresultado.Text += " ";
                }
                for (x = 0; x < base1; x++)
                {
                    txtresultado.Text += "*";
                }
                txtresultado.Text += " " + Environment.NewLine;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                lblvalor1.Text = "";
                lblvalor2.Text = "";
                txtnum1.Visible = false;
                txtnum2.Visible = false;
                btngenerar.Enabled = false;
            }
            else 
            {
                txtnum1.Visible = true;
                btngenerar.Enabled = true;
            }
            if (comboBox1.SelectedIndex==1) 
            {
                lblvalor1.Text = "Ingresar el radio del circulo:";
                lblvalor2.Text = "";
                txtnum2.Visible = false;
            }
            if (comboBox1.SelectedIndex == 2) 
            {
                lblvalor1.Text = "Ingresar la altura del triangulo:";
                lblvalor2.Text = "";
                txtnum2.Visible = false;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                lblvalor1.Text = "Ingresar la base del rectangulo:";
                lblvalor2.Text = "Ingresar la altura del rectangulo:";
                txtnum2.Visible = true;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                lblvalor1.Text = "Ingresar el lado del cuadrado:";
                lblvalor2.Text = "";
                txtnum2.Visible = false;

            }
            if (comboBox1.SelectedIndex == 5)
            {
                lblvalor1.Text = "Ingresar el lado del rombo:";
                lblvalor2.Text = "";
                txtnum2.Visible = false;

            }
            if (comboBox1.SelectedIndex == 6)
            {
                lblvalor1.Text = "Ingresar la base del Paralelogramo:";
                lblvalor2.Text = "Ingresar la altura del Paralelogramo:";
                txtnum2.Visible = true;

            }
            if (comboBox1.SelectedIndex == 7)
            {
                lblvalor1.Text = "Ingresar la base superior del trapecio:";
                lblvalor2.Text = "Ingresar la altura del trapecio:";
                txtnum2.Visible = true;
            }
            if (comboBox1.SelectedIndex == 8)
            {
                lblvalor1.Text = "Ingresar la base del pentagono:";
                lblvalor2.Text = "";
                txtnum2.Visible = false;
            }
            if (comboBox1.SelectedIndex == 9)
            {
                lblvalor1.Text = "Ingresar la base del hexagono:";
                lblvalor2.Text = "";
                txtnum2.Visible = false;
            }
            txtnum1.Text = "0";
            txtnum2.Text = "0";
            txtresultado.Text = "";
        }
    }
}
