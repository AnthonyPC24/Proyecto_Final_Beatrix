// --- AÑADE ESTOS 'USING' AL PRINCIPIO DE TU ARCHIVO ---
using Beatrix_Formulario.ClasesTareas; // Para tus clases
using System;
using System.Collections.Generic; // Para List<T>
using System.IO;                  // Para leer/escribir archivos
using System.Text.Json;           // Para procesar JSON
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
            // --- 1. VALIDACIÓN (Sin cambios, tu validación es correcta) ---
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
            // Primero creamos la lista de objetos 'Usuarios'
            // (La clase 'Usuarios' que representa a una persona)
            List<Usuarios> listaUsuariosParaTarea = new List<Usuarios>();
            foreach (object item in listBoxUsuarios.Items)
            {
                string nombreUsuario = item.ToString();

                // Asumimos que tu clase 'Usuarios' tiene una propiedad 'nombreUsuario'
                // (Si tu clase se llama 'Usuario' (singular), cámbialo aquí)
                listaUsuariosParaTarea.Add(new Usuarios { nombreUsuario = nombreUsuario });
            }


            // --- 3. CREACIÓN DE LA "TAREA CONTENEDORA" ---
            // Creamos una tarea inicial que guardará esta información
            Tareas tareaInicial = new Tareas
            {
                // Puedes poner un nombre por defecto o el nombre del proyecto
                nombreTarea = "Datos Generales del Proyecto",
                descripcion = "Tarea inicial creada con el proyecto.",
                fechaInicio = dateTimePicker1.Value,
                fechaEntrega = dateTimePicker2.Value,
                estado = "Pendiente", // O un estado por defecto

                // ¡Aquí asignamos la lista de usuarios!
                usuariosAsignados = listaUsuariosParaTarea,

                // Inicializamos la lista de subtareas
                SubTareas = new List<SubTareas>()
            };


            // --- 4. CREACIÓN DEL OBJETO PROYECTO ---
            // Ahora creamos el proyecto principal
            Proyectos proyectoTemporal = new Proyectos
            {
                NombreProyecto = txtNombre.Text,

                // Añadimos la tarea que acabamos de crear a la lista de Tareas del proyecto
                Tareas = new List<Tareas> { tareaInicial },

                // Dejamos las propiedades raíz con valores por defecto o vacías,
                // ya que Form1 y Form3 ya no las leen.
                fechaInicio = new DateTime(1, 1, 1), // 0001-01-01
                fechaEntrega = new DateTime(1, 1, 1), // 0001-01-01
                UsuariosAsignados = new List<Usuarios>() // Lista vacía
            };


            // --- 5. LÓGICA DE GUARDADO EN JSON (Corregida con Opciones) ---
            try
            {
                string rutaArchivoJson = Path.Combine(Application.StartupPath, "JSON", "Proyectos.JSON");
                List<Proyectos> listaDeProyectos;

                // Definimos las opciones una vez, con Case Insensitive
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
                        // Usamos las 'options' para leer
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
                // Reutilizamos las 'options' para escribir
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

        // --- CÓDIGO DE CARGA DE FORMULARIO (Corregido con Opciones) ---
        private void FormProyectosGerard2_Load_1(object sender, EventArgs e)
        {
            string rutaUsuariosJson = Path.Combine(Application.StartupPath, "JSON", "Usuarios.JSON");

            if (File.Exists(rutaUsuariosJson))
            {
                try
                {
                    string json = File.ReadAllText(rutaUsuariosJson);

                    // Añadimos opciones aquí también por consistencia
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    List<Usuarios> listaTotalUsuarios = JsonSerializer.Deserialize<List<Usuarios>>(json, options);

                    if (listaTotalUsuarios == null) return;

                    comboBoxUsuarios.Items.Clear();
                    foreach (Usuarios user in listaTotalUsuarios)
                    {
                        // Asumimos que la clase 'Usuarios' tiene un ToString()
                        // que muestra el nombre de usuario
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
                // 'usuario' aquí es un objeto 'Usuarios'
                Usuarios usuarioSeleccionado = (Usuarios)comboBoxUsuarios.SelectedItem;

                // Usamos el 'ToString()' para añadir al ListBox
                // (Si tu clase 'Usuarios' no tiene un ToString() sobreescrito
                // quizás quieras añadir usuarioSeleccionado.nombreUsuario)
                string nombreUsuario = usuarioSeleccionado.ToString();

                if (!listBoxUsuarios.Items.Contains(nombreUsuario))
                {
                    listBoxUsuarios.Items.Add(nombreUsuario);
                }

                comboBoxUsuarios.SelectedIndex = -1;
            }
        }
    }
}