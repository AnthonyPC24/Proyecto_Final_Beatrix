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
        private Proyectos proyectoActual;
        private Tareas tareaActual;
        public SubTareas NuevaSubTareaCreada { get; set; }

        public Tareas TareaPadre { get; set; }
        public FormSubTareasTho(Proyectos proyecto, Tareas tarea)
        {
            InitializeComponent();
            proyectoActual = proyecto;
            tareaActual = tarea;
            cargarUsuariosDesdeJson();
        }

        private void cargarUsuariosDesdeJson()
        {
            try
            {
                string rutaArchivo = Path.Combine(Application.StartupPath, "JSON", "Usuarios.json");

                if (!File.Exists(rutaArchivo))
                {
                    MessageBox.Show("No se encontró el archivo de usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string json = File.ReadAllText(rutaArchivo);
                var listaUsuarios = JsonSerializer.Deserialize<List<Usuarios>>(json);

                if (listaUsuarios == null || listaUsuarios.Count == 0)
                {
                    MessageBox.Show("No hay usuarios en el archivo JSON.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                comboBoxUsuariosAsignarsubTareas.Items.Clear();
                foreach (var usuario in listaUsuarios)
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
                MessageBox.Show("El nombre de la sub-tarea no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listBoxUsuariosSubTarea.Items.Count == 0)
            {
                MessageBox.Show("Debe asignar al menos un usuario a la sub-tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
            {
                NuevaSubTareaCreada.UsuariosAsignadosSubtarea.Add(new Usuarios { nombreUsuario = item.ToString() });
            }

            // Añadir directamente a la tarea padre
            if (TareaPadre.SubTareas == null)
                TareaPadre.SubTareas = new List<SubTareas>();

            TareaPadre.SubTareas.Add(NuevaSubTareaCreada);

            // Guardar cambios en el JSON
            string rutaArchivoProyectos = Path.Combine(Application.StartupPath, "JSON", "Proyectos.json");
            //string jsonActualizado = JsonSerializer.Serialize(FormTareasTho1.listaProyectosGlobal, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(rutaArchivoProyectos, jsonActualizado);

            MessageBox.Show("Subtarea creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelarSubTarea_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comboBoxUsuariosAsignarsubTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxUsuariosAsignarsubTareas.SelectedItem != null)
            {
                String usuario = comboBoxUsuariosAsignarsubTareas.SelectedItem.ToString();

                if (!listBoxUsuariosSubTarea.Items.Contains(usuario))
                {
                    listBoxUsuariosSubTarea.Items.Add(usuario);
                }
                comboBoxUsuariosAsignarsubTareas.SelectedItem = -1;
            }
        }

        private void buttonQuitarUsuarioSubTarea_Click(object sender, EventArgs e)
        {

            if (listBoxUsuariosSubTarea.SelectedItem != null)
            {
                listBoxUsuariosSubTarea.Items.Remove(listBoxUsuariosSubTarea.SelectedItem);
            }
        }
    }

}
