using Beatrix_Formulario.ClasesTareas;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Beatrix_Formulario
{
    public partial class BeatrixForm : Form
    {
        private List<Usuarios> usuarios;
        public BeatrixForm()
        {
            InitializeComponent();
            cargarUsuarios();
        }

        private void Beatrix_Load(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = '*';
 
        }

        private void cargarUsuarios()
        {

            try
            {
                string filePath = Path.Combine(Application.StartupPath, "JSON", "Usuarios.json");

                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    usuarios = JsonSerializer.Deserialize<List<Usuarios>>(json);
                }
                else
                {
                    MessageBox.Show("No se encontró el archivo json", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usuarios = new List<Usuarios>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuarios = new List<Usuarios>();
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text.Trim();
            string password = txtContrasena.Text;

            Usuarios usuarioEncontrado = usuarios
                .Find(u => u.nombreUsuario == user && u.contrasena == password);

            if (usuarioEncontrado != null)
            {
               
                Inicio inicio = new Inicio();
                inicio.Show();

                this.Hide();   
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

    }
}
