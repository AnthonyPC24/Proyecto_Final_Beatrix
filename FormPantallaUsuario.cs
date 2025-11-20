using Beatrix_Formulario.ClasesTareas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beatrix_Formulario
{
    public partial class FormPantallaUsuario : Form
    {
        public FormPantallaUsuario()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            Usuarios nuevoUsuario = new Usuarios
            {
                nombreUsuario = txtUser.Text,
                nombreApellidos = txtNombre.Text,
                contrasena = "",
                email = txtCorreo.Text,
                telefono = txtTele.Text,
                rol = ""
            };

            // Regresar al directorio raíz del proyecto
            string proyectoRaiz = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..");

            string carpeta = Path.Combine(proyectoRaiz, "JSON");
            if (!Directory.Exists(carpeta))
                // si no existe, crear un nuevo carpeta 
                Directory.CreateDirectory(carpeta);

            // empalme la ruta de json 
            string rutaArchivo = Path.Combine(carpeta, "Usuarios.json");

            AgregarUsuario(nuevoUsuario, rutaArchivo);

        }

        public void AgregarUsuario(Usuarios nuevoUsuario, string rutaArchivo)
        {
            List<Usuarios> usuarios = new List<Usuarios>();

            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                if (!string.IsNullOrWhiteSpace(json))
                    usuarios = JsonSerializer.Deserialize<List<Usuarios>>(json) ?? new List<Usuarios>();
            }

            usuarios.Add(nuevoUsuario);

            string jsonActualizado = JsonSerializer.Serialize(usuarios, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(rutaArchivo, jsonActualizado);
            
            MessageBox.Show("Usuario agregado correctamente.\nArchivo: " + Path.GetFullPath(rutaArchivo));
        }
    }
}
