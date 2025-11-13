using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using Beatrix_Formulario.ClasesTareas;

namespace Beatrix_Formulario
{
    public partial class FormTareasTho1 : Form
    {
        private List<Proyectos> listaProyectos = new List<Proyectos>();

        public FormTareasTho1()
        {
            InitializeComponent();
            comboBoxUsuarios.Text = "Usuarios";
            comboBoxEstadosTarea.Text = "Estado";
            comboBoxProyectos.Text = "Proyectos";
            comboBoxTareas.Text = "Tareas";
            cargarProyectosDesdeJson();
        }

        private void cargarProyectosDesdeJson()
        {
            try
            {
                string rutaArchivoProyectos = Path.Combine(Application.StartupPath, "JSON", "Proyectos.json");

                if (!File.Exists(rutaArchivoProyectos))
                {
                    MessageBox.Show("No se encontró el archivo de proyectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string jsonProyectos = File.ReadAllText(rutaArchivoProyectos);

                // Ignorar mayúsculas/minúsculas en JSON
                listaProyectos = JsonSerializer.Deserialize<List<Proyectos>>(jsonProyectos, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (listaProyectos == null || listaProyectos.Count == 0)
                {
                    MessageBox.Show("No hay proyectos en el archivo JSON.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                comboBoxProyectos.Items.Clear();
                foreach (var proyecto in listaProyectos)
                    comboBoxProyectos.Items.Add(proyecto.NombreProyecto);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proyectos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTareas.Items.Clear();
            comboBoxSubTareas.Items.Clear();

            string proyectoSeleccionado = comboBoxProyectos.SelectedItem?.ToString();
            if (proyectoSeleccionado == null) return;

            Proyectos proyecto = listaProyectos.FirstOrDefault(p => p.NombreProyecto == proyectoSeleccionado);
            if (proyecto != null)
            {
                foreach (var tarea in proyecto.Tareas)
                    comboBoxTareas.Items.Add(tarea.nombreTarea);
            }
        }

        private void comboBoxTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreProyecto = comboBoxProyectos.SelectedItem?.ToString();
            string nombreTarea = comboBoxTareas.SelectedItem?.ToString();

            if (nombreProyecto == null || nombreTarea == null) return;

            Proyectos proyecto = listaProyectos.FirstOrDefault(p => p.NombreProyecto == nombreProyecto);
            if (proyecto == null) return;

            Tareas tarea = proyecto.Tareas.FirstOrDefault(t => t.nombreTarea == nombreTarea);
            if (tarea == null) return;

            // Mostrar detalles de la tarea
            textBoxNombreTarea.Text = tarea.nombreTarea;
            dateTimePickerFechaInicio.Value = tarea.fechaInicio;
            dateTimePickerFechaEntrega.Value = tarea.fechaEntrega;
            comboBoxEstadosTarea.Text = tarea.estado;

            comboBoxUsuarios.Items.Clear();
            foreach (var usuario in tarea.usuariosAsignados)
                comboBoxUsuarios.Items.Add(usuario.nombreUsuario);
            if (tarea.usuariosAsignados.Count > 0)
                comboBoxUsuarios.SelectedIndex = 0;

            richTextBoxDescripcionTare.Text = tarea.descripcion;

            // --- Llenar comboBoxSubTareas ---
            comboBoxSubTareas.Items.Clear();
            if (tarea.SubTareas != null && tarea.SubTareas.Count > 0)
            {
                foreach (var sub in tarea.SubTareas)
                    comboBoxSubTareas.Items.Add(sub.NombreSubTarea);

                comboBoxSubTareas.SelectedIndex = 0; // opcional: seleccionar la primera subtarea
            }
            else
            {
                comboBoxSubTareas.Text = "";
            }
        }

        private void comboBoxSubTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreProyecto = comboBoxProyectos.SelectedItem?.ToString();
            string nombreTarea = comboBoxTareas.SelectedItem?.ToString();
            string nombreSubTarea = comboBoxSubTareas.SelectedItem?.ToString();

            if (nombreProyecto == null || nombreTarea == null || nombreSubTarea == null) return;

            Proyectos proyecto = listaProyectos.FirstOrDefault(p => p.NombreProyecto == nombreProyecto);
            if (proyecto == null) return;

            Tareas tarea = proyecto.Tareas.FirstOrDefault(t => t.nombreTarea == nombreTarea);
            if (tarea == null) return;

            SubTareas subTarea = tarea.SubTareas.FirstOrDefault(st => st.NombreSubTarea == nombreSubTarea);
            if (subTarea == null) return;

            // Mostrar detalles de la subtarea
            dateTimePickerFechaInicioSubtarea.Value = subTarea.FechaInicioSubtarea;
            dateTimePickerSubTareaEntrega.Value = subTarea.FechaEntregaSubtarea;
            richTextBoxDescripcionSubTareas.Text = subTarea.DescripcionSubTarea;

            comboBoxUsuariosSubTarea.Items.Clear();
            foreach (var usuario in subTarea.UsuariosAsignadosSubtarea)
                comboBoxUsuariosSubTarea.Items.Add(usuario.nombreUsuario);

            foreach (var control in groupBoxSubtareaEstados.Controls)
            {
                if (control is RadioButton rb)
                    rb.Checked = rb.Text == subTarea.EstadoSubTarea;
            }
        }

        private void buttonNuevaTarea_Click(object sender, EventArgs e)
        {
            FormTareasTho2 nuevaTareaForm = new FormTareasTho2();

            if (nuevaTareaForm.ShowDialog() == DialogResult.OK)
            {
                string nombreProyecto = comboBoxProyectos.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(nombreProyecto))
                {
                    MessageBox.Show("Seleccione un proyecto para añadir la tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Proyectos proyecto = listaProyectos.FirstOrDefault(p => p.NombreProyecto == nombreProyecto);
                if (proyecto == null)
                {
                    MessageBox.Show("No se encontró el proyecto en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (proyecto.Tareas == null)
                    proyecto.Tareas = new List<Tareas>();

                proyecto.Tareas.Add(nuevaTareaForm.NuevaTareaCreada);

                string rutaArchivo = Path.Combine(Application.StartupPath, "JSON", "Proyectos.json");
                string jsonActualizado = JsonSerializer.Serialize(listaProyectos, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivo, jsonActualizado);

                comboBoxTareas.Items.Add(nuevaTareaForm.NuevaTareaCreada.nombreTarea);

                MessageBox.Show("Tarea añadida al proyecto correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSubTarea_Click(object sender, EventArgs e)
        {
            string nombreProyecto = comboBoxProyectos.SelectedItem?.ToString();
            string nombreTarea = comboBoxTareas.SelectedItem?.ToString();

            if (nombreProyecto == null || nombreTarea == null) return;

            Proyectos proyecto = listaProyectos.FirstOrDefault(p => p.NombreProyecto == nombreProyecto);
            if (proyecto == null) return;

            Tareas tarea = proyecto.Tareas.FirstOrDefault(t => t.nombreTarea == nombreTarea);
            if (tarea == null) return;

            // Abrir formulario de nueva subtarea
            FormSubTareasTho formSubTarea = new FormSubTareasTho(proyecto, tarea)
            {
                TareaPadre = tarea
            };

            if (formSubTarea.ShowDialog() == DialogResult.OK)
            {
                if (tarea.SubTareas == null)
                    tarea.SubTareas = new List<SubTareas>();

                // Agregar la nueva subtarea creada
                tarea.SubTareas.Add(formSubTarea.NuevaSubTareaCreada);

                // Guardar cambios en JSON
                string rutaArchivoProyecto = Path.Combine(Application.StartupPath, "JSON", "Proyectos.json");
                string proyectosActualizadosJson = JsonSerializer.Serialize(listaProyectos, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivoProyecto, proyectosActualizadosJson);

                // --- Recargar comboBoxSubTareas automáticamente ---
                comboBoxSubTareas.Items.Clear();
                foreach (var sub in tarea.SubTareas)
                {
                    comboBoxSubTareas.Items.Add(sub.NombreSubTarea);
                }

                // Seleccionar la última subtarea agregada
                comboBoxSubTareas.SelectedIndex = comboBoxSubTareas.Items.Count - 1;
            }
        }

        private void buttonInicioForm1Tareas_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }
        private void buttonProyetos1Tareas_Click(object sender, EventArgs e)
        {
            FormProyectosGerard1 proyectosForm = new FormProyectosGerard1();
            proyectosForm.Show();
            this.Hide();
        }
        private void buttonReuniones1Tareas_Click(object sender, EventArgs e)
        {
            FormReunionesDy1 reunionesForm = new FormReunionesDy1();
            reunionesForm.Show();
            this.Hide();
        }
        private void buttonBuscarNombreProyecto_Click(object sender, EventArgs e)
        {
            string textoBusqueda = textBoxBuscarNombreProyecto.Text.Trim();

            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                MessageBox.Show("Introduce un nombre de proyecto para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Buscar el proyecto en la lista
            Proyectos proyectoEncontrado = listaProyectos
                .FirstOrDefault(p => p.NombreProyecto.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0);

            if (proyectoEncontrado != null)
            {
                // Asegurarse de que el comboBox no es null y contiene el proyecto
                if (comboBoxProyectos != null && comboBoxProyectos.Items.Count > 0)
                {
                    int index = comboBoxProyectos.Items.IndexOf(proyectoEncontrado.NombreProyecto);
                    if (index >= 0)
                    {
                        comboBoxProyectos.SelectedIndex = index;
                    }
                }

                // Actualizar el comboBoxTareas para que muestre solo las tareas del proyecto encontrado
                comboBoxTareas.Items.Clear();
                comboBoxSubTareas.Items.Clear(); // Limpiamos subtareas también
                if (proyectoEncontrado.Tareas != null && proyectoEncontrado.Tareas.Count > 0)
                {
                    foreach (var tarea in proyectoEncontrado.Tareas)
                        comboBoxTareas.Items.Add(tarea.nombreTarea);
                }

                // seleccionar la primera tarea si existe
                if (comboBoxTareas.Items.Count > 0)
                    comboBoxTareas.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show($"No se encontró ningún proyecto que contenga '{textoBusqueda}'.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los comboBox si no hay coincidencias
                comboBoxProyectos.SelectedIndex = -1;
                comboBoxTareas.Items.Clear();
                comboBoxSubTareas.Items.Clear();
            }

        }

        private void comboBoxEstadosTarea_SelectedIndexChanged(object sender, EventArgs e)
        {

            string nombreProyecto = comboBoxProyectos.SelectedItem?.ToString();
            string nombreTarea = comboBoxTareas.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nombreProyecto) || string.IsNullOrEmpty(nombreTarea))
                return;

            try
            {
                // Ruta del JSON
                string rutaArchivoProyecto = Path.GetFullPath(
                    Path.Combine(Application.StartupPath, @"..\..\..\JSON\Proyectos.json")
                );

                if (!File.Exists(rutaArchivoProyecto))
                {
                    MessageBox.Show("No se encontró el archivo JSON de proyectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Leer JSON completo
                string jsonProyectos = File.ReadAllText(rutaArchivoProyecto);
                var listaProyectos = JsonSerializer.Deserialize<List<Proyectos>>(jsonProyectos, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                if (listaProyectos == null)
                {
                    MessageBox.Show("No se pudieron cargar los proyectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Buscar proyecto y tarea
                var proyectoSeleccionado = listaProyectos.FirstOrDefault(p => p.NombreProyecto == nombreProyecto);
                if (proyectoSeleccionado == null) return;

                var tareaSeleccionada = proyectoSeleccionado.Tareas.FirstOrDefault(t => t.nombreTarea == nombreTarea);
                if (tareaSeleccionada == null) return;

                // Actualizar estado
                string nuevoEstado = comboBoxEstadosTarea.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(nuevoEstado)) return;

                tareaSeleccionada.estado = nuevoEstado;

                // Guardar JSON actualizado
                string proyectosActualizadosJson = JsonSerializer.Serialize(listaProyectos, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivoProyecto, proyectosActualizadosJson);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el estado de la tarea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
