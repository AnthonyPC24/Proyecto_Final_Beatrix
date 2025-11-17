// --- AÑADE ESTOS 'USING' AL PRINCIPIO ---
using Beatrix_Formulario.ClasesTareas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement; // Lo tenías, lo mantengo

namespace Beatrix_Formulario
{
    // Este es tu formulario de EDICIÓN, renombrado a FormProyectosGerard4
    public partial class FormProyectosGerard4 : Form
    {
        // Propiedades para saber qué proyecto editar y para pasar el resultado
        private string nombreProyectoOriginal;
        public Proyectos ProyectoEditado { get; private set; }
        private List<Proyectos> listaCompletaDeProyectos; // Para guardar la lista leída
        private Proyectos proyectoAEditar;

        // --- 1. CONSTRUCTOR MODIFICADO ---
        // Recibe el NOMBRE del proyecto que se va a editar
        public FormProyectosGerard4(string nombreProyectoAEditar)
        {
            InitializeComponent();
            this.nombreProyectoOriginal = nombreProyectoAEditar;

            // Asumimos que tu botón de guardar se sigue llamando 'btnCrear'
            // Si le cambiaste el nombre, actualiza 'btnCrear' por el nuevo nombre
            this.btnCrear.Text = "Guardar Cambios";
        }

        // --- 2. CÓDIGO DE CARGA DEL FORMULARIO ---
        // Revisa que el evento Load de tu formulario esté conectado a esta función
        private void FormProyectosGerard4_Load(object sender, EventArgs e)
        {
            // Primero, cargamos el ComboBox de usuarios (igual que en Form2)
            CargarUsuariosDelJson();

            try
            {
                // Ahora, cargamos la lista de Proyectos
                string rutaProyectosJson = Path.Combine(Application.StartupPath, "JSON", "Proyectos.JSON");
                if (!File.Exists(rutaProyectosJson))
                {
                    MessageBox.Show("No se encuentra Proyectos.JSON");
                    this.Close();
                    return;
                }

                string jsonProyectos = File.ReadAllText(rutaProyectosJson);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                // Guardamos la lista completa para usarla al guardar
                listaCompletaDeProyectos = JsonSerializer.Deserialize<List<Proyectos>>(jsonProyectos, options);

                // Buscamos el proyecto que queremos editar
                proyectoAEditar = listaCompletaDeProyectos.FirstOrDefault(p => p.NombreProyecto == this.nombreProyectoOriginal);

                if (proyectoAEditar == null)
                {
                    MessageBox.Show($"No se pudo encontrar el proyecto: {this.nombreProyectoOriginal}");
                    this.Close();
                    return;
                }

                // --- RELLENAR CAMPOS ---
                txtNombre.Text = proyectoAEditar.NombreProyecto;
                richTextBox1.Text = proyectoAEditar.DescripcionProyecto;

                // Tu lógica guarda las fechas y usuarios en la PRIMERA tarea.
                // Debemos leer de ahí.
                Tareas tareaContenedora = proyectoAEditar.Tareas.FirstOrDefault();
                if (tareaContenedora != null)
                {
                    dateTimePicker1.Value = tareaContenedora.fechaInicio;
                    dateTimePicker2.Value = tareaContenedora.fechaEntrega;

                    listBoxUsuarios.Items.Clear();
                    if (tareaContenedora.usuariosAsignados != null)
                    {
                        foreach (var usuario in tareaContenedora.usuariosAsignados)
                        {
                            // Asumimos que tu clase 'Usuarios' tiene 'nombreUsuario'
                            listBoxUsuarios.Items.Add(usuario.nombreUsuario);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el proyecto: {ex.Message}");
                this.Close();
            }
        }

        // --- 3. CÓDIGO DEL BOTÓN "GUARDAR CAMBIOS" (modificado de 'btnCrear') ---
        // Revisa que el clic de tu botón de guardar esté conectado a esta función
        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            // --- 1. VALIDACIÓN (Idéntica a la de Form2) ---
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("El campo 'Descripción' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listBoxUsuarios.Items.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un 'Usuario'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateTimePicker2.Value.Date < dateTimePicker1.Value.Date)
            {
                MessageBox.Show("La fecha de entrega no puede ser anterior a la fecha de inicio.", "Error de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- 2. PROCESAMIENTO DE USUARIOS (Idéntico a Form2) ---
            List<Usuarios> listaUsuariosParaTarea = new List<Usuarios>();
            foreach (object item in listBoxUsuarios.Items)
            {
                string nombreUsuario = item.ToString();
                listaUsuariosParaTarea.Add(new Usuarios { nombreUsuario = nombreUsuario });
            }

            // --- 3. CREACIÓN DE LA "TAREA CONTENEDORA" (Idéntico a Form2) ---
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

            // --- 4. CREACIÓN DEL OBJETO PROYECTO (Idéntico a Form2) ---
            // Este es el objeto 'NUEVO' o 'EDITADO'
            Proyectos proyectoTemporal = new Proyectos
            {
                NombreProyecto = txtNombre.Text,
                DescripcionProyecto = richTextBox1.Text,
                Tareas = new List<Tareas> { tareaInicial },
                fechaInicio = new DateTime(1, 1, 1),
                fechaEntrega = new DateTime(1, 1, 1),
                UsuariosAsignados = new List<Usuarios>()
            };

            // --- 5. LÓGICA DE GUARDADO (¡LA PARTE CLAVE!) ---
            try
            {
                string rutaArchivoJson = Path.Combine(Application.StartupPath, "JSON", "Proyectos.JSON");
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    PropertyNameCaseInsensitive = true
                };

                // A. Borramos el proyecto ORIGINAL de la lista que cargamos
                // (Usamos la variable 'proyectoAEditar' que guardamos en el Load)
                if (proyectoAEditar != null)
                {
                    listaCompletaDeProyectos.Remove(proyectoAEditar);
                }

                // B. Añadir el proyecto 'NUEVO' (editado) a la lista
                listaCompletaDeProyectos.Add(proyectoTemporal);

                // C. Serializar y Escribir la lista COMPLETA de nuevo
                string jsonActualizado = JsonSerializer.Serialize(listaCompletaDeProyectos, options);
                File.WriteAllText(rutaArchivoJson, jsonActualizado);

                // --- 6. GUARDAR Y CERRAR ---
                this.ProyectoEditado = proyectoTemporal;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el proyecto en JSON: {ex.Message}");
            }
        }

        // --- CÓDIGO DEL BOTÓN "CANCELAR" ---
        // Revisa que el clic de tu botón de cancelar esté conectado a esta función
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // --- CÓDIGO DE CARGA DE USUARIOS (Separado para limpieza) ---
        private void CargarUsuariosDelJson()
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

        // --- CÓDIGO DEL COMBOBOX ---
        // Revisa que el evento 'SelectedIndexChanged' de tu ComboBox esté conectado aquí
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUsuarios.SelectedItem != null)
            {
                Usuarios usuarioSeleccionado = (Usuarios)comboBoxUsuarios.SelectedItem;
                string nombreUsuario = usuarioSeleccionado.ToString();

                if (!listBoxUsuarios.Items.Contains(nombreUsuario))
                {
                    listBoxUsuarios.Items.Add(nombreUsuario);
                }
                comboBoxUsuarios.SelectedIndex = -1;
            }
        }

        // --- CÓDIGO PARA QUITAR USUARIOS ---
        // Revisa que el clic de tu botón 'Quitar' esté conectado aquí
        private void quitarUsuarios_Click(object sender, EventArgs e)
        {
            if (listBoxUsuarios.SelectedItem != null)
            {
                listBoxUsuarios.Items.Remove(listBoxUsuarios.SelectedItem);
            }
        }
    }
}