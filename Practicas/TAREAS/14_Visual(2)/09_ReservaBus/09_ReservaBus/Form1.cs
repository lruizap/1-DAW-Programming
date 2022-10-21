namespace _09_ReservaBus
{
    public partial class Form1 : Form
    {
        int posy = 30, posy2 = 30, posy3 = 290, posy4 = 290;
        List<Button> Botones = new List<Button>();

        public Form1()
        {
            InitializeComponent();
            int n = 1;
            for (int i = 0; i < 64; i++)
            {
                Button button = new Button();
                button.BackColor = Color.Green;
                button.Text = n.ToString();
                button.Click += new EventHandler(buttonDinamico_Click);
                Botones.Add(button);
                panel1.Controls.Add(button); // para que se vea el botón creado

                if (i < 16)
                {
                    if (i % 2 == 0)
                    {
                        button.Location = new Point(180, posy);
                    }
                    else
                    {
                        button.Location = new Point(270, posy);
                        posy += 30;
                    }
                }
                else if (i < 32)
                {
                    if (i % 2 == 0)
                    {
                        button.Location = new Point(400, posy2);
                    }
                    else
                    {
                        button.Location = new Point(490, posy2);
                        posy2 += 30;
                    }
                }
                else if (i < 48)
                {
                    if (i % 2 == 0)
                    {
                        button.Location = new Point(180, posy3);
                    }
                    else
                    {
                        button.Location = new Point(270, posy3);
                        posy3 += 30;
                    }
                }
                else if (i < 64)
                {
                    if (i % 2 == 0)
                    {
                        button.Location = new Point(400, posy4);
                    }
                    else
                    {
                        button.Location = new Point(490, posy4);
                        posy4 += 30;
                    }
                }

                n++;
            }
        }

        private void buttonDinamico_Click(object sender, EventArgs e)
        {
            Button myBoton = (Button)sender;

            if (myBoton.BackColor == Color.Green)
            {
                myBoton.BackColor = Color.Orange;
            }
        }

        private void ReservaButton1_Click(object sender, EventArgs e)
        {
            string linea = "";
            for (int i = 0; i < Botones.Count; i++)
            {
                if (Botones[i].BackColor == Color.Orange && textBox1.Text != string.Empty)
                {
                    Botones[i].BackColor = Color.Red;
                    linea += Botones[i].Text + ",";
                }
            }

            listView1.Items.Add(new ListViewItem((textBox1.Text + ";" + linea.Remove(linea.Length-1)).Split(";")));
            textBox1.Text = "";
        }
    }
}