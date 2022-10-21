using System.Data.SQLite;

namespace ExpliacionSQLite

{
    public partial class Form1 : Form
    {

        SQLiteConnection conn; //creamos aqui la conexion para usarla durante todo el programa y a la hora de cerrar dicho programa es cuando se cierra

        public Form1()
        {
            InitializeComponent();

            conn = new SQLiteConnection("Data Source=ejemplo.db;Version=3;");
            conn.Open();
        }

        private void button1CreateTable_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=ejemplo.db;Version=3;"); 
            // pa conectarnos a la base de datos
            // tenemos que poner una cadena a la que le pasamos como se llama la base de datos y la versión

            // con esto creamos el objeto para la conexion y con el conn.open es para que se conecte

            conn.Open(); // esto es lo que hace la conexion

            //SQLiteCommand cmd = conn.CreateCommand();
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = "CREATE TABLE tabla(id INTEGER PRIMARY KEY, texto VARCHAR(50));"; // el comando a crear

            cmd.ExecuteNonQuery(); // lanza una consulta que no necesita ser respondida

            conn.Close(); // para cerrar el acceso a la base de datos

        }

        private void button1Insert_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand(conn);

            string id = textBox1.Text;
            string texto = textBox2.Text;

            cmd.CommandText = "INSERT INTO tabla(id, texto) VALUES(" + id + ", '" + texto + "');";
            // tener en cuenta qe el teto se debe estar entre comillas simples
            
            MessageBox.Show(cmd.CommandText); // para ver que lo esta haciendo bien 

            cmd.ExecuteNonQuery(); // para que haga el comando el programa

            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button1select_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            SQLiteCommand cmd = new SQLiteCommand(conn);

            cmd.CommandText = "SELECT id, texto FROM tabla WHERE id > 2;";

            //ORDER BY texto

            // tener en cuenta qe el teto se debe estar entre comillas simples

            SQLiteDataReader data = cmd.ExecuteReader(); // para que devuelva el dato que estamos preguntando

            while (data.Read()) // lee 1 linea del listado de resultados
            {
                int id = data.GetInt32(0);
                string texto = data.GetString(1); // get para transformar el dato en el tipo de dato que queramos

                listBox1.Items.Add(id + " - " + texto);
            }

            data.Close(); // para leer datos, se debe cerrar la base de datos para que no pete
        }
    }
}