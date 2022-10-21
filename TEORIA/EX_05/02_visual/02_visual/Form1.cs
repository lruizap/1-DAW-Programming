namespace _02_visual
{
    public partial class Form1 : Form
    {
        bool semaforoAliexpress = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (semaforoAliexpress)
            {
                semaforoAliexpress = false;

                int n;
                if (int.TryParse(textBox1.Text, out n))
                {
                    textBox3.Text = (n + 1).ToString();
                }
                else
                {
                    if (textBox1.Text == string.Empty)
                    {
                        textBox3.Text = string.Empty;
                    }
                    else
                    {
                        textBox3.Text = "ERROR";
                    }
                }

                semaforoAliexpress = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (semaforoAliexpress)
            {
                semaforoAliexpress = false;

                textBox1.Text = textBox3.Text + "2";

                semaforoAliexpress = true;
            }
        }
    }
}