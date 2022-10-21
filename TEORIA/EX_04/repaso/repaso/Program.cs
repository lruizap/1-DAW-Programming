using System;

namespace repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = new string[10];

            for (int i = 0; i < text.Length; i++)
            {
                // Cambia el salto de linea por espacios vacios para a la hora de hacer el split, quitarlos
                text[i].Replace("\n", string.Empty);

                // las palabras estan divididas por los saltos de linea y espacios
                string[] words = new string[text[i].Split(new string[] { "\t", "\n" }, StringSplitOptions.RemoveEmptyEntries).Length];

                for (int j = 0; j < words.Length; j++)
                {
                    // words[j] = text[i].Split(new string { " " }, StringSplitOptions.None);// = words[j].;
                    words[j] = words[j];
                }

            }
        }
    }
}
