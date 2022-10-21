namespace _09_Estadisticas_Texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Texto_TextChanged(object sender, EventArgs e)
        {
            int letras = 0, vocales = 0, consonantes = 0;
            string[] palabras = Texto.Text.Split(" ");
            nPalabras.Text = palabras.Length.ToString();

            //int espB = 0;
            //for (int i = 0; i < Texto.Text.Length; i++)
            //{
            //    if (char.IsWhiteSpace(Texto.Text[i]))
            //    {
            //        espB++;
            //    }
            //}
            // nEspacios.Text = espB.ToString();

            nEspacios.Text = (palabras.Length -1 ).ToString();

            for (int i = 0; i < palabras.Length; i++)
            {
                for (int j = 0; j < palabras[i].Length; j++)
                {
                    letras++;
                    if (palabras[i][j] == 'a'
                        || palabras[i][j] == 'e'
                        || palabras[i][j] == 'i'
                        || palabras[i][j] == 'o'
                        || palabras[i][j] == 'u')
                    {
                       vocales++;
                    }
                    else
                    {
                       consonantes++;
                    }
                    //NumeroVocales(palabras[i]);
                }
            }
            nLetras.Text = (letras).ToString();
            nVocales.Text = (vocales).ToString();
            nConsonantes.Text = (consonantes).ToString();
        }

        //private void NumeroVocales(string s)
        //{
        //    int vocales = 0, consonantes = 0;

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (char.IsLetter(s[i]))
        //        {
        //            if (s[i] == 'a'
        //                || s[i] == 'e'
        //                || s[i] == 'i'
        //                || s[i] == 'o'
        //                || s[i] == 'u')
        //            {
        //                vocales++;
        //            }
        //            else
        //            {
        //                consonantes++;
        //            }
        //        }
        //    }

        //    nVocales.Text = (vocales).ToString();
        //    nConsonantes.Text = (consonantes).ToString();
        //}
    }
}