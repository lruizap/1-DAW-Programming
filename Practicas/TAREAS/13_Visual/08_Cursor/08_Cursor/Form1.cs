namespace _08_Cursor
{
    public partial class Form1 : Form
    {
        Button[] buttons = new Button[9];
        public Form1()
        {
            InitializeComponent();

            buttons[0] = Centro;
            buttons[1] = EsquinaSupIzq;
            buttons[2] = EsquinaSupDer;
            buttons[3] = EsqInfDer;
            buttons[4] = EsqInfIzq;
            buttons[5] = CentroAbajo;
            buttons[6] = CentroArriba;
            buttons[7] = CentroDer;
            buttons[8] = CentroIzq;

        }

        private void Visible()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (LaO.Location == buttons[i].Location)
                {
                    buttons[i].Visible = false;
                }
                else
                {
                    buttons[i].Visible = true;
                }
            }
        }

        private void Position(Button b)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (b.Location == buttons[i].Location)
                {
                    LaO.Location = b.Location;
                }
            }
        }

        private void EsquinaSupIzq_Click(object sender, EventArgs e)
        {
            //LaO.Location = new Point(EsquinaSupIzq.Location.X, EsquinaSupIzq.Location.Y);
            Position(EsquinaSupIzq);
            Visible();
        }

        private void CentroIzq_Click(object sender, EventArgs e)
        {
            //LaO.Location = new Point(CentroIzq.Location.X, CentroIzq.Location.Y);
            Position(CentroIzq);
            Visible();
        }

        private void EsqInfIzq_Click(object sender, EventArgs e)
        {
            //LaO.Location = new Point(EsqInfIzq.Location.X, EsqInfIzq.Location.Y);
            Position(EsqInfIzq);
            Visible();
        }

        private void CentroArriba_Click(object sender, EventArgs e)
        {
            Position(CentroArriba);
            Visible();
        }

        private void CentroAbajo_Click(object sender, EventArgs e)
        {
            Position(CentroAbajo);
            Visible();
        }

        private void EsquinaSupDer_Click(object sender, EventArgs e)
        {
            Position(EsquinaSupDer);
            Visible();
        }

        private void CentroDer_Click(object sender, EventArgs e)
        {
            Position(CentroDer);
            Visible();
        }

        private void EsqInfDer_Click(object sender, EventArgs e)
        {
            Position(EsqInfDer);
            Visible();
        }

        private void Centro_Click(object sender, EventArgs e)
        {
            Position(Centro);
            Visible();
        }
    }
}