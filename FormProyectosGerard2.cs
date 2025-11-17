// --- AÑADE ESTOS 'USING' AL PRINCIPIO DE TU ARCHIVO ---
using Beatrix_Formulario.ClasesTareas; // Para tus clases
using System;
using System.Collections.Generic; // Para List<T>
using System.IO;              // Para leer/escribir archivos
using System.Text.Json;       // Para procesar JSON
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq; // <-- ¡Asegúrate de tener este!

namespace Beatrix_Formulario
{
    public partial class FormProyectosGerard2 : Form
    {
        public Proyectos NuevoProyecto { get; private set; }

        public FormProyectosGerard2()
        {
            InitializeComponent();
        }

        // --- CÓDIGO DEL BOTÓN "CREAR" (CORREGIDO) ---
        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            // --- 1. VALIDACIÓN (Con la descripción añadida) ---
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- ¡NUEVA VALIDACIÓN! ---
            // Comprobamos que el RichTextBox de la descripción no esté vacío
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("El campo 'Descripción' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // --- FIN DE LA NUEVA VALIDACIÓN ---

            if (listBoxUsuarios.Items.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un 'Usuario'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateTimePicker2.Value.Date < dateTimePicker1.Value.Date)
            {
                MessageBox.Show(
                    "La fecha de entrega no puede ser anterior a la fecha de inicio del proyecto.",
                    "Error de Fechas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // --- 2. PROCESAMIENTO DE USUARIOS ---
            List<Usuarios> listaUsuariosParaTarea = new List<Usuarios>();
            foreach (object item in listBoxUsuarios.Items)
            {
                string nombreUsuario = item.ToString();
                listaUsuariosParaTarea.Add(new Usuarios { nombreUsuario = nombreUsuario });
            }


            // --- 3. CREACIÓN DE LA "TAREA CONTENEDORA" ---
            // (Esta es tu lógica original para guardar fechas y usuarios en la primera tarea)
            Tareas tareaInicial = new Tareas
            {
                nombreTarea = "Datos Generales del Proyecto",
                descripcion = "Tarea inicial creada con el proyecto.",
                fechaInicio = dateTimePicker1.Value,
                fechaEntrega = dateTimePicker2.Value,
                estado = "Pendiente",
                usuariosAsignados = listaUsuariosParaTarea,
                SubTareas = new List<SubTareas>()
            };


            // --- 4. CREACIÓN DEL OBJETO PROYECTO ---
            Proyectos proyectoTemporal = new Proyectos
            {
                NombreProyecto = txtNombre.Text,

                // --- ¡CAMBIO IMPORTANTE AQUÍ! ---
                // Guardamos el texto del RichTextBox en la propiedad
                // que lee el Formulario 3.
                DescripcionProyecto = richTextBox1.Text,
                // --- FIN DEL CAMBIO ---

                // Añadimos la tarea que acabamos de crear
                Tareas = new List<Tareas> { tareaInicial },

                // Propiedades raíz que tu lógica no usa (rellenadas por defecto)
                fechaInicio = new DateTime(1, 1, 1), // 0001-01-01
                fechaEntrega = new DateTime(1, 1, 1), // 0001-01-01
                UsuariosAsignados = new List<Usuarios>() // Lista vacía
            };


            // --- 5. LÓGICA DE GUARDADO EN JSON (Sin cambios) ---
            try
            {
                string rutaArchivoJson = Path.Combine(Application.StartupPath, "JSON", "Proyectos.JSON");
                List<Proyectos> listaDeProyectos;

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    PropertyNameCaseInsensitive = true
                };

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
                        listaDeProyectos = JsonSerializer.Deserialize<List<Proyectos>>(jsonExistente, options);
                    }
                }
                else
                {
                    listaDeProyectos = new List<Proyectos>();
                }

                // B. Añadir el nuevo proyecto a la lista
                listaDeProyectos.Add(proyectoTemporal);

                // C. Serializar y Escribir el archivo de nuevo
                string jsonActualizado = JsonSerializer.Serialize(listaDeProyectos, options);
                File.WriteAllText(rutaArchivoJson, jsonActualizado);

                // --- 6. GUARDAR Y CERRAR ---
                this.NuevoProyecto = proyectoTemporal;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el proyecto en JSON: {ex.Message}");
            }
        }

        // --- CÓDIGO DEL BOTÓN "CANCELAR" (Sin cambios) ---
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // --- CÓDIGO DE CARGA DE FORMULARIO (Sin cambios) ---
        private void FormProyectosGerard2_Load_1(object sender, EventArgs e)
        {
            string rutaUsuariosJson = Path.Combine(Application.StartupPath, "JSON", "Usuarios.JSON");

            if (File.Exists(rutaUsuariosJson))
            {
                try
                {
                    string json = File.ReadAllText(rutaUsuariosJson);

                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    List<Usuarios> listaTotalUsuarios = JsonSerializer.Deserialize<List<Usuarios>>(json, options);

                    if (listaTotalUsuarios == null) return;

                    comboBoxUsuarios.Items.Clear();
                    foreach (Usuarios user in listaTotalUsuarios)
                    {
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

        // --- CÓDIGO DEL COMBOBOX (Sin cambios) ---
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUsuarios.SelectedItem != null)
            {
                Usuarios usuarioSeleccionado = (Usuarios)comboBoxUsuarios.SelectedItem;

                // Asumo que tu clase Usuarios tiene un .ToString() que devuelve el nombre
                string nombreUsuario = usuarioSeleccionado.ToString();

                if (!listBoxUsuarios.Items.Contains(nombreUsuario))
                {
                    listBoxUsuarios.Items.Add(nombreUsuario);
                }

                comboBoxUsuarios.SelectedIndex = -1;
            }
        }

        private void quitarUsuarios_Click(object sender, EventArgs e)
        {
            if (listBoxUsuarios.SelectedItem != null)
            {
                listBoxUsuarios.Items.Remove(listBoxUsuarios.SelectedItem);
            }
        }
    }
}