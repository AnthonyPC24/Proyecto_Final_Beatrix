// --- AÑADE ESTOS 'USING' AL PRINCIPIO DE TU ARCHIVO ---
using Beatrix_Formulario.ClasesTareas; // Para tus clases
using System;
using System.Collections.Generic; // Para List<T>
using System.IO;                  // Para leer/escribir archivos
using System.Text.Json;           // Para procesar JSON
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Beatrix_Formulario
{
    public partial class FormProyectosGerard2 : Form
    {
        // Esta propiedad sigue siendo útil si Form1 necesita saber
        // que la operación fue un éxito.
        public Proyectos NuevoProyecto { get; private set; }

        public FormProyectosGerard2()
        {
            InitializeComponent();
        }

        // --- CÓDIGO DEL BOTÓN "CREAR" (CORREGIDO Y CON LÓGICA JSON) ---
        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            // --- 1. VALIDACIÓN ---
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listBoxUsuarios.Items.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un 'Usuario'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- 2. CREACIÓN DEL OBJETO PROYECTO
            Proyectos proyectoTemporal = new Proyectos
            {
                NombreProyecto = txtNombre.Text,
                fechaInicio = dateTimePicker1.Value,
                fechaEntrega = dateTimePicker2.Value
            };

            // --- 3. PROCESAMIENTO DE USUARIOS ---
            foreach (object item in listBoxUsuarios.Items)
            {
                string nombreUsuario = item.ToString();
                Usuarios usuarioAsignado = new Usuarios
                {
                    nombreApellidos = nombreUsuario
                };
                proyectoTemporal.UsuariosAsignados.Add(usuarioAsignado);
            }

            // --- 4. LÓGICA DE GUARDADO EN JSON ---
            try
            {
                string rutaArchivoJson = Path.Combine(Application.StartupPath, "JSON", "Proyectos.JSON");
                List<Proyectos> listaDeProyectos;

                // A. Leer el archivo JSON existente
                if (File.Exists(rutaArchivoJson))
                {
                    string jsonExistente = File.ReadAllText(rutaArchivoJson);
                    if (string.IsNullOrWhiteSpace(jsonExistente))
                    {
                        listaDeProyectos = new List<Proyectos>();
                    }
                    else
                    {
                        listaDeProyectos = JsonSerializer.Deserialize<List<Proyectos>>(jsonExistente);
                    }
                }
                else
                {
                    listaDeProyectos = new List<Proyectos>();
                }

                // B. Añadir el nuevo proyecto a la lista
                listaDeProyectos.Add(proyectoTemporal);

                // C. Serializar y Escribir el archivo de nuevo
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonActualizado = JsonSerializer.Serialize(listaDeProyectos, new JsonSerializerOptions { WriteIndented=true});
                File.WriteAllText(rutaArchivoJson, jsonActualizado);

                // --- 5. GUARDAR Y CERRAR ---
                this.NuevoProyecto = proyectoTemporal;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el proyecto en JSON: {ex.Message}");
            }
        }

        // --- CÓDIGO DEL BOTÓN "CANCELAR" ---
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // --- CÓDIGO DE CARGA DE FORMULARIO ---
        private void FormProyectosGerard2_Load_1(object sender, EventArgs e)
        {
            string rutaUsuariosJson = Path.Combine(Application.StartupPath, "JSON", "Usuarios.JSON");

            if (File.Exists(rutaUsuariosJson))
            {
                try
                {
                    string json = File.ReadAllText(rutaUsuariosJson);
                    List<Usuarios> listaTotalUsuarios = JsonSerializer.Deserialize<List<Usuarios>>(json);

                    // Aquí estás cargando 'comboBox1', lo cual es correcto
                    // para tu lógica de 'comboBox1_SelectedIndexChanged'
                    comboBoxUsuarios.Items.Clear();
                    foreach (Usuarios user in listaTotalUsuarios)
                    {
                        // Añadimos el objeto 'Usuarios'
                        // (el método ToString() mostrará el nombre)
                        comboBoxUsuarios.Items.Add(user);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los usuarios: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No se encontró el archivo 'Usuarios.JSON'.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUsuarios.SelectedItem != null)
            {
                // 'usuario' aquí es un objeto 'Usuarios'
                Usuarios usuarioSeleccionado = (Usuarios)comboBoxUsuarios.SelectedItem;

                // Usamos el 'ToString()' (nombreApellidos) para añadir al ListBox
                string nombreUsuario = usuarioSeleccionado.ToString();

                if (!listBoxUsuarios.Items.Contains(nombreUsuario))
                {
                    listBoxUsuarios.Items.Add(nombreUsuario);
                }

                // Corrección: Así se deselecciona un ComboBox
                comboBoxUsuarios.SelectedIndex = -1;
            }
        }

        // ... (otros métodos vacíos que tenías) ...
    }
}