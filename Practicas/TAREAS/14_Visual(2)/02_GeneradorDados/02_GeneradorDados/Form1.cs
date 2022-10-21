namespace _02_GeneradorDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTirar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int suma = 0;
            for (int i = 0; i < NumDadosNumericUpDown.Value; i++)
            {
                int cara = r.Next(1, ((int)CarasNumericUpDown.Value) + 1);
                DadoslistBox.Items.Add(i+1 + "-->" + cara);
                suma += cara;
            }

            SumaTextBox.Text = suma.ToString();
        }
    }
}