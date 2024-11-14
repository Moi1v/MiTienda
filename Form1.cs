using System;
using System.Data;
using System.Windows.Forms;
using ConexionSQLAzure;


namespace MiTienda
{
    public partial class log_in : Form
    {

        private AzureSqlConnection _connection;


        public log_in()
        {
            InitializeComponent();

            // Configurar cadena de conexión
            string connectionString = "Server=uspg.database.windows.net;Database=winforms-pos;User Id=jhernandez;Password=g&ouJ1szsLZ6rJLt;";
            _connection = new AzureSqlConnection(connectionString);

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
           
            try
            {
                // Abrir la conexión
                _connection.OpenConnection();
                MessageBox.Show("Conexión establecida exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar: {ex.Message}");
            }
            finally
            {
                // Cerrar la conexión
                _connection.CloseConnection();
            }


            string usuario = textBox1.Text;
            string contrasena = textBox2.Text;


            string usuarioValido = "usuarioEjemplo";
            string contrasenaValida = "contrasenaEjemplo";


            if (usuario == usuarioValido && contrasena == contrasenaValida)
            {

                Menu designedForm = new Menu();
                designedForm.Show();

                textBox1.Clear();
                textBox2.Clear();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void log_in_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
