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
        private bool cargandoDatos = false;

        public FormTareasTho1()
        {


            InitializeComponent();
            comboBoxUsuarios.Text = "Usuarios";
            comboBoxEstadosTarea.Text = "Estado";
            comboBoxProyectos.Text = "Proyectos";
            comboBoxTareas.Text = "Tareas";
            cargarProyectosDesdeJson();


            //Configuracion del DataGridView
            // Evitar que el usuario redimensione columnas y filas
            dataGridViewTareas.AllowUserToResizeColumns = false;
            dataGridViewTareas.AllowUserToResizeRows = false;

            // Evitar agregar o borrar filas manualmente
            dataGridViewTareas.AllowUserToAddRows = false;
            dataGridViewTareas.AllowUserToDeleteRows = false;

            // Ajustar altura de filas al contenido
            dataGridViewTareas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            // Opcional: bloquear el tamaño de filas específico
            dataGridViewTareas.RowTemplate.Height = 30; // por ejemplo, 30 px

            dataGridViewTareas.Font = new System.Drawing.Font("Montserrat", 10); // Cambiar la fuente y tamaño
        }

        private void CargarTareasEnDataGridView(string nombreProyecto)
        {
            // Limpiamos el DataGridView
            dataGridViewTareas.Rows.Clear();
            dataGridViewTareas.Columns.Clear();

            // Creamos las columnas
            dataGridViewTareas.Columns.Add("nombreTarea", "Nombre de la Tarea");
            dataGridViewTareas.Columns.Add("descripcion", "Descripción");
            dataGridViewTareas.Columns.Add("fechaInicio", "Fecha Inicio");
            dataGridViewTareas.Columns.Add("fechaEntrega", "Fecha Entrega");
            dataGridViewTareas.Columns.Add("estado", "Estado");
            dataGridViewTareas.Columns.Add("usuariosAsignados", "Usuarios Asignados");

            // Buscar el proyecto
            var proyecto = listaProyectos.FirstOrDefault(p => p.NombreProyecto == nombreProyecto);
            if (proyecto == null || proyecto.Tareas == null) return;

            // Ordenar las tareas (por nombre, puedes cambiarlo si quieres)
            var tareasOrdenadas = proyecto.Tareas;

            // Agregar filas al DataGridView
            foreach (var tarea in tareasOrdenadas)
            {
                string usuarios = string.Join(", ", tarea.usuariosAsignados.Select(u => u.nombreUsuario));
                dataGridViewTareas.Rows.Add(
                    tarea.nombreTarea,
                    tarea.descripcion,
                    tarea.fechaInicio.ToString("yyyy-MM-dd"),
                    tarea.fechaEntrega.ToString("yyyy-MM-dd"),
                    tarea.estado,
                    usuarios
                );
            }

            // Ajustar tamaño de columnas automáticamente
            dataGridViewTareas.AutoResizeColumns();
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
            string nombreProyecto = comboBoxProyectos.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(nombreProyecto))
            {
                // Cargar tareas en el DataGridView
                CargarTareasEnDataGridView(nombreProyecto);

                // Opcional: actualizar comboBox de tareas también
                comboBoxTareas.Items.Clear();
                var proyecto = listaProyectos.FirstOrDefault(p => p.NombreProyecto == nombreProyecto);
                if (proyecto?.Tareas != null)
                {
                    foreach (var t in proyecto.Tareas.OrderBy(t => t.nombreTarea))
                    {
                        comboBoxTareas.Items.Add(t.nombreTarea);
                    }
                }
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
            // Obtener nombre de proyecto y tarea
            string nombreProyecto = comboBoxProyectos.SelectedItem?.ToString();
            string nombreTarea = comboBoxTareas.SelectedItem?.ToString();

            // Si estás llamando desde el DataGridView, tomar la fila seleccionada
            if (string.IsNullOrEmpty(nombreTarea) && dataGridViewTareas.CurrentRow != null)
            {
                nombreTarea = dataGridViewTareas.CurrentRow.Cells["nombreTarea"].Value?.ToString();
            }

            // Buscar proyecto y tarea
            Proyectos proyecto = listaProyectos.FirstOrDefault(p => p.NombreProyecto == nombreProyecto);
            if (proyecto == null) return;

            Tareas tarea = proyecto.Tareas.FirstOrDefault(t => t.nombreTarea == nombreTarea);
            if (tarea == null) return;

            // Tomar la primera subtarea automáticamente si no hay selección
            SubTareas subTarea = null;
            string nombreSubTarea = comboBoxSubTareas.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(nombreSubTarea))
            {
                subTarea = tarea.SubTareas.FirstOrDefault(st => st.NombreSubTarea == nombreSubTarea);
            }
            else if (tarea.SubTareas != null && tarea.SubTareas.Count > 0)
            {
                subTarea = tarea.SubTareas[0]; // la primera subtarea
                comboBoxSubTareas.SelectedItem = subTarea.NombreSubTarea;
            }

            if (subTarea == null) return;

            // Mostrar detalles
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

                // Agregar la tarea creada directamente
                proyecto.Tareas.Add(nuevaTareaForm.NuevaTareaCreada);

                // Guardar en JSON 
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

            // Si no hay tarea seleccionada en el comboBox, tomarla de la fila seleccionada del DataGridView
            if (string.IsNullOrEmpty(nombreTarea) && dataGridViewTareas.CurrentRow != null)
            {
                nombreTarea = dataGridViewTareas.CurrentRow.Cells["NombreTarea"].Value.ToString();
            }

            if (string.IsNullOrEmpty(nombreProyecto) || string.IsNullOrEmpty(nombreTarea))
            {
                MessageBox.Show("Seleccione un proyecto y una tarea primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar proyecto y tarea
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

                // Recargar comboBoxSubTareas automáticamente
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
            if (cargandoDatos)
                return; // No hacer nada mientras el form está cargando

            string nombreProyecto = comboBoxProyectos.SelectedItem?.ToString();
            string nombreTarea = comboBoxTareas.SelectedItem?.ToString();
            string nuevoEstado = comboBoxEstadosTarea.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nombreProyecto) ||
                string.IsNullOrEmpty(nombreTarea) ||
                string.IsNullOrEmpty(nuevoEstado))
            {
                return; // Quitamos el mensaje, no debe saltar solo
            }

            Proyectos proyecto = listaProyectos.FirstOrDefault(p => p.NombreProyecto == nombreProyecto);
            if (proyecto == null) return;

            Tareas tarea = proyecto.Tareas.FirstOrDefault(t => t.nombreTarea == nombreTarea);
            if (tarea == null) return;

            tarea.estado = nuevoEstado;

            string rutaProyecto = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
            string rutaArchivo = Path.Combine(rutaProyecto, "JSON", "Proyectos.json");

            File.WriteAllText(rutaArchivo,
                JsonSerializer.Serialize(listaProyectos, new JsonSerializerOptions { WriteIndented = true }));

        }
        private void radioButtonSubtareaEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (cargandoDatos)
                return;

            string nombreProyecto = comboBoxProyectos.SelectedItem?.ToString();
            string nombreTarea = comboBoxTareas.SelectedItem?.ToString();
            string nombreSubTarea = comboBoxSubTareas.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nombreProyecto) ||
                string.IsNullOrEmpty(nombreTarea) ||
                string.IsNullOrEmpty(nombreSubTarea))
                return;

            Proyectos proyecto = listaProyectos.FirstOrDefault(p => p.NombreProyecto == nombreProyecto);
            if (proyecto == null) return;

            Tareas tarea = proyecto.Tareas.FirstOrDefault(t => t.nombreTarea == nombreTarea);
            if (tarea == null) return;

            SubTareas subTarea = tarea.SubTareas.FirstOrDefault(st => st.NombreSubTarea == nombreSubTarea);
            if (subTarea == null) return;

            string rutaProyecto = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
            string rutaArchivo = Path.Combine(rutaProyecto, "JSON", "Proyectos.json");

            foreach (var control in groupBoxSubtareaEstados.Controls)
            {
                if (control is RadioButton rb && rb.Checked)
                {
                    subTarea.EstadoSubTarea = rb.Text;

                    // Guardar cambios
                    File.WriteAllText(rutaArchivo,
                        JsonSerializer.Serialize(listaProyectos, new JsonSerializerOptions { WriteIndented = true }));
                    break; // ya guardamos, no necesitamos seguir iterando
                }
            }
        }
        private void groupBoxSubtareaEstados_Enter(object sender, EventArgs e)
        {

        }

        private void buttonEliminarTarea_Click(object sender, EventArgs e)
        {
            if (dataGridViewTareas.CurrentRow == null) return;

            string nombreTarea = dataGridViewTareas.CurrentRow.Cells["nombreTarea"].Value?.ToString();
            string nombreProyecto = comboBoxProyectos.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(nombreProyecto) || string.IsNullOrEmpty(nombreTarea)) return;

            var resultado = MessageBox.Show($"¿Seguro que quieres eliminar la tarea '{nombreTarea}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.No) return;

            // Buscar proyecto y tarea en la lista en memoria
            Proyectos proyecto = listaProyectos.FirstOrDefault(p => p.NombreProyecto == nombreProyecto);
            if (proyecto == null || proyecto.Tareas == null) return;

            Tareas tareaAEliminar = proyecto.Tareas.FirstOrDefault(t => t.nombreTarea == nombreTarea);
            if (tareaAEliminar != null)
            {
                proyecto.Tareas.Remove(tareaAEliminar);

                // Guardar cambios en el JSON en la carpeta JSON
                string rutaArchivoProyecto = Path.GetFullPath(
                    Path.Combine(Application.StartupPath, @"..\..\..\JSON\Proyectos.json")
                );
                File.WriteAllText(rutaArchivoProyecto, JsonSerializer.Serialize(listaProyectos, new JsonSerializerOptions { WriteIndented = true }));

                // --- ACTUALIZAR EL DATAGRID ---
                CargarTareasEnDataGridView(nombreProyecto);

                // --- ACTUALIZAR COMBOBOX TAREAS ---
                comboBoxTareas.Items.Clear();
                comboBoxSubTareas.Items.Clear();

                if (proyecto.Tareas != null && proyecto.Tareas.Count > 0)
                {
                    foreach (var t in proyecto.Tareas)
                        comboBoxTareas.Items.Add(t.nombreTarea);

                    // Seleccionar la primera tarea disponible
                    comboBoxTareas.SelectedIndex = 0;
                }

                // Limpiar controles si no hay tareas restantes
                textBoxNombreTarea.Clear();
                richTextBoxDescripcionTare.Clear();
                comboBoxUsuarios.Items.Clear();
                comboBoxEstadosTarea.Text = "";
            }
        }



        private void dataGridViewTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTareas.CurrentRow == null) return;

            // Obtenemos el nombre de la tarea desde la fila seleccionada
            string nombreTareaSeleccionada = dataGridViewTareas.CurrentRow.Cells["nombreTarea"].Value?.ToString();
            string nombreProyecto = comboBoxProyectos.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nombreProyecto) || string.IsNullOrEmpty(nombreTareaSeleccionada)) return;

            // Buscar proyecto y tarea
            Proyectos proyecto = listaProyectos.FirstOrDefault(p => p.NombreProyecto == nombreProyecto);
            if (proyecto == null) return;

            Tareas tarea = proyecto.Tareas.FirstOrDefault(t => t.nombreTarea == nombreTareaSeleccionada);
            if (tarea == null) return;

            // Actualizar comboBoxTareas para que coincida con la tarea seleccionada
            cargandoDatos = true; // evita disparar eventos al actualizar el comboBox
            comboBoxTareas.SelectedItem = nombreTareaSeleccionada;
            cargandoDatos = false;

            // Mostrar detalles de la tarea en los controles
            textBoxNombreTarea.Text = tarea.nombreTarea;
            dateTimePickerFechaInicio.Value = tarea.fechaInicio;
            dateTimePickerFechaEntrega.Value = tarea.fechaEntrega;

            // Actualizar comboBoxEstadosTarea con el estado de la tarea
            cargandoDatos = true;
            comboBoxEstadosTarea.SelectedItem = tarea.estado;
            cargandoDatos = false;

            // Usuarios asignados
            comboBoxUsuarios.Items.Clear();
            foreach (var usuario in tarea.usuariosAsignados)
                comboBoxUsuarios.Items.Add(usuario.nombreUsuario);
            if (tarea.usuariosAsignados.Count > 0)
                comboBoxUsuarios.SelectedIndex = 0;

            richTextBoxDescripcionTare.Text = tarea.descripcion;

            // Subtareas
            comboBoxSubTareas.Items.Clear();
            if (tarea.SubTareas != null && tarea.SubTareas.Count > 0)
            {
                foreach (var sub in tarea.SubTareas)
                    comboBoxSubTareas.Items.Add(sub.NombreSubTarea);

                comboBoxSubTareas.SelectedIndex = 0; // opcional
            }
            else
            {
                comboBoxSubTareas.Text = "";
            }
        }

        private void FormTareasTho1_Load(object sender, EventArgs e)
        {
            cargandoDatos = true;

            comboBoxEstadosTarea.Items.Clear();
            comboBoxEstadosTarea.Items.AddRange(new string[]
            {
            "Pendiente",
            "En Progreso",
            "En Pausa",
            "Completada",
            "Cancelada"
            });

            cargandoDatos = false;
        }

        private void labelConfiguracion_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios();
            formUsuarios.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios();
            formUsuarios.Show();
            this.Hide();
        }

        private void FormTareasTho1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
