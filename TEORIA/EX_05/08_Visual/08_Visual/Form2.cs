using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_Visual
{
    public partial class Form2 : Form
    {
        public string cadena = "";

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string texto) : this()
        {
            label1.Text = texto;
        }

        public Form2(int texto2)
        {
            InitializeComponent();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            //textBox1.Text = cadena;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            cadena = textBox1.Text;
        }

        private void button1OK_Click(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.OK;
        }

        private void button1Cancel_Click(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.Cancel;
        }
    }
}
