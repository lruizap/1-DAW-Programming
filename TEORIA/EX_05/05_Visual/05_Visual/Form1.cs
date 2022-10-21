namespace _05_Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string fichero = openFileDialog1.FileName;
                this.Text = Path.GetFileName(fichero);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           saveFileDialog1.ShowDialog();
        }

        private void cambiarFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
            }
        }

        private void contextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void cambiarColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                label1.ForeColor = colorDialog1.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.ContextMenuStrip = contextMenuStrip1; // menu en el from load --> en el evento
        }
    }
}