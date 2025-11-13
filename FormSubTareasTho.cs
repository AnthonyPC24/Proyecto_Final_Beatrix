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
using Beatrix_Formulario.ClasesTareas;

namespace Beatrix_Formulario
{
    public partial class FormSubTareasTho : Form
    {

        public SubTareas NuevaSubTareaCreada { get; set; }

        public Tareas TareaPadre { get; set; }
        public FormSubTareasTho(Proyectos proyecto, Tareas tarea)
        {
            InitializeComponent();
            CargarProyectosYTareas();
            cargarUsuariosDesdeJson();
        }

        private void CargarProyectosYTareas()
        {
            try
            {
                string rutaArchivo = Path.Combine(Application.StartupPath, "JSON", "Proyectos.json");
                if (!File.Exists(rutaArchivo)) return;

                string json = File.ReadAllText(rutaArchivo);
                var listaProyectos = JsonSerializer.Deserialize<List<Proyectos>>(json);

                comboBoxProyectosSubTareas.Items.Clear();
                comboBoxTareaSubTareas.Items.Clear();

                foreach (var proyecto in listaProyectos ?? new List<Proyectos>())
                {
                    comboBoxProyectosSubTareas.Items.Add(proyecto.NombreProyecto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proyectos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cargarUsuariosDesdeJson()
        {
            try
            {
                string rutaArchivo = Path.Combine(Application.StartupPath, "JSON", "Usuarios.json");
                if (!File.Exists(rutaArchivo)) return;

                string json = File.ReadAllText(rutaArchivo);
                var listaUsuarios = JsonSerializer.Deserialize<List<Usuarios>>(json);

                comboBoxUsuariosAsignarsubTareas.Items.Clear();
                foreach (var usuario in listaUsuarios ?? new List<Usuarios>())
                {
                    comboBoxUsuariosAsignarsubTareas.Items.Add(usuario.nombreUsuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCrearNuevaSubTarea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombreNuevaSubTarea.Text))
            {
                MessageBox.Show("El nombre de la subtarea no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxProyectosSubTareas.SelectedItem == null || comboBoxTareaSubTareas.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un proyecto y una tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listBoxUsuariosSubTarea.Items.Count == 0)
            {
                MessageBox.Show("Debe asignar al menos un usuario a la subtarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Crear la nueva subtarea
                NuevaSubTareaCreada = new SubTareas
                {
                    NombreSubTarea = textBoxNombreNuevaSubTarea.Text,
                    DescripcionSubTarea = richTextBoxSubTareaDescripcion.Text,
                    FechaInicioSubtarea = dateTimePickerFechaSubTareaInicio.Value,
                    FechaEntregaSubtarea = dateTimePickerFechasubTareaFin.Value,
                    EstadoSubTarea = "Pendiente",
                    UsuariosAsignadosSubtarea = new List<Usuarios>()
                };

                foreach (var item in listBoxUsuariosSubTarea.Items)
                    NuevaSubTareaCreada.UsuariosAsignadosSubtarea.Add(new Usuarios { nombreUsuario = item.ToString() });

                // Ruta del JSON
                string rutaArchivoProyecto = Path.GetFullPath(
                    Path.Combine(Application.StartupPath, @"..\..\..\JSON\Proyectos.json")
                );

                if (!File.Exists(rutaArchivoProyecto))
                {
                    MessageBox.Show("No se encontró el archivo JSON de proyectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Leer el JSON completo
                string jsonProyectos = File.ReadAllText(rutaArchivoProyecto);
                var listaProyectos = JsonSerializer.Deserialize<List<Proyectos>>(jsonProyectos, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                if (listaProyectos == null)
                {
                    MessageBox.Show("No se pudieron cargar los proyectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Buscar proyecto y tarea seleccionada
                string nombreProyectoSeleccionado = comboBoxProyectosSubTareas.SelectedItem.ToString();
                string nombreTareaSeleccionada = comboBoxTareaSubTareas.SelectedItem.ToString();

                var proyectoSeleccionado = listaProyectos.FirstOrDefault(p => p.NombreProyecto == nombreProyectoSeleccionado);
                if (proyectoSeleccionado == null)
                {
                    MessageBox.Show("No se encontró el proyecto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (proyectoSeleccionado.Tareas == null)
                    proyectoSeleccionado.Tareas = new List<Tareas>();

                var tareaSeleccionada = proyectoSeleccionado.Tareas.FirstOrDefault(t => t.nombreTarea == nombreTareaSeleccionada);
                if (tareaSeleccionada == null)
                {
                    MessageBox.Show("No se encontró la tarea seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tareaSeleccionada.SubTareas == null)
                    tareaSeleccionada.SubTareas = new List<SubTareas>();

                // Agregar la subtarea
                tareaSeleccionada.SubTareas.Add(NuevaSubTareaCreada);

                // Guardar JSON actualizado
                string proyectosActualizadosJson = JsonSerializer.Serialize(listaProyectos, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivoProyecto, proyectosActualizadosJson);

                MessageBox.Show("Subtarea creada correctamente y guardada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la subtarea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Carga de usuarios a la lista de asignados
        private void comboBoxUsuariosAsignarsubTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxUsuariosAsignarsubTareas.SelectedItem != null)
            {
                string usuario = comboBoxUsuariosAsignarsubTareas.SelectedItem.ToString();
                if (!listBoxUsuariosSubTarea.Items.Contains(usuario))
                    listBoxUsuariosSubTarea.Items.Add(usuario);

                comboBoxUsuariosAsignarsubTareas.SelectedIndex = -1;
            }
        }

        private void comboBoxProyectosSubTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTareaSubTareas.Items.Clear();

            if (comboBoxProyectosSubTareas.SelectedItem == null) return;

            string nombreProyecto = comboBoxProyectosSubTareas.SelectedItem.ToString();
            string rutaArchivo = Path.Combine(Application.StartupPath, "JSON", "Proyectos.json");
            var listaProyectos = JsonSerializer.Deserialize<List<Proyectos>>(File.ReadAllText(rutaArchivo));

            var proyecto = listaProyectos?.FirstOrDefault(p => p.NombreProyecto == nombreProyecto);
            if (proyecto != null)
            {
                foreach (var tarea in proyecto.Tareas)
                {
                    comboBoxTareaSubTareas.Items.Add(tarea.nombreTarea);
                }
            }
        }
        private void buttonQuitarUsuarioSubTarea_Click(object sender, EventArgs e)
        {

            if (listBoxUsuariosSubTarea.SelectedItem != null)
            {
                listBoxUsuariosSubTarea.Items.Remove(listBoxUsuariosSubTarea.SelectedItem);
            }
        }
        private void buttonCancelarSubTarea_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

}
