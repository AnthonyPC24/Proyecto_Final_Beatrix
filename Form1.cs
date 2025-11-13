

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

                    
                    try
                    {
                        usuarios = JsonSerializer.Deserialize<List<Usuarios>>(json);
                    }
                    catch
                    {
                   
                        Usuarios usuario = JsonSerializer.Deserialize<Usuarios>(json);
                        usuarios = new List<Usuarios>();
                        if (usuario != null)
                            usuarios.Add(usuario);
                    }
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


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            cargarUsuarios();

            string user = txtUsuario.Text.Trim();
            string password = txtContrasena.Text;

            Usuarios usuarioEncontrado = usuarios.Find(u => u.nombreUsuario.Equals(user, StringComparison.OrdinalIgnoreCase) && u.contrasena == password);


            if (usuarioEncontrado != null)
            {
                // abrir el form Inicio
                Inicio inicioForm = new Inicio();
                inicioForm.Show();

                this.Hide();

                // cuando se cierra el form Inicio, se cierra toda la app
                inicioForm.FormClosed += (s, args) => this.Close();
            }
            else 
            {
                MessageBox.Show("El nombre de usuario o la contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
            }


        }
    }
}

