namespace _06_Visual
{
    public partial class Form1 : Form
    {
        int n = 1;
        int posy=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = n.ToString();
            button.Location = new Point(0, posy);
            posy += 30;
            n++;

            button.Click += new EventHandler(buttonDinamico_Click); 

            this.Controls.Add(button);
        }

        private void buttonDinamico_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            MessageBox.Show("No toques el boton " + boton.Text);
        }

    }
}