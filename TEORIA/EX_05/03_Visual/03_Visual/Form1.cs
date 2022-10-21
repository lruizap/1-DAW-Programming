namespace _03_Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 6;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value = (int)numericUpDown1.Value;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            MessageBox.Show("Cambio: " + radioButton.Name + ", nuevo estado: " + radioButton.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int n = random.Next(0, 100 + 1);

            listBox1.Items.Add(DateTime.Now);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) // comprueba que hay algo seleccionado.
            {
                labelSeleccion.Text = "Seleccionado " + listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                labelSeleccion.Text = "Nada";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}