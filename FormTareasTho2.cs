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
    public partial class FormTareasTho2 : Form
    {

        public Tareas NuevaTareaCreada { get; private set; }
        public FormTareasTho2()
        {
            InitializeComponent();

            //Carga los usuarios del Json al combobox
            cargarUsuariosDesdeJson();

            //Carga los proyectos del Json al combobox
            cargarProyectosDesdeJson();

        }

        private void cargarProyectosDesdeJson()
        {
            try
            {
                // Obtener ruta correcta: 3 niveles arriba + carpeta JSON
                string rutaProyecto = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                string rutaArchivoProyecto = Path.Combine(rutaProyecto, "JSON", "Proyectos.json");

                if (!File.Exists(rutaArchivoProyecto))
                {
                    MessageBox.Show("No se encontró el archivo de proyectos en la carpeta JSON.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string jsonProyectos = File.ReadAllText(rutaArchivoProyecto);
                var listaProyectos = JsonSerializer.Deserialize<List<Proyectos>>(jsonProyectos,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                if (listaProyectos == null || listaProyectos.Count == 0)
                {
                    MessageBox.Show("No hay proyectos en el archivo JSON.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                comboBoxProyectoNuevaTarea.Items.Clear();
                foreach (var proyecto in listaProyectos)
                {
                    comboBoxProyectoNuevaTarea.Items.Add(proyecto.NombreProyecto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proyectos: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarUsuariosDesdeJson()
        {
            try
            {
                // Obtener ruta correcta: subir 3 niveles y entrar en /JSON
                string rutaProyecto = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                string rutaArchivo = Path.Combine(rutaProyecto, "JSON", "Usuarios.json");

                if (!File.Exists(rutaArchivo))
                {
                    MessageBox.Show("No se encontró el archivo Usuarios.json en la carpeta JSON.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string json = File.ReadAllText(rutaArchivo);

                var listaUsuarios = JsonSerializer.Deserialize<List<Usuarios>>(json,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                if (listaUsuarios == null || listaUsuarios.Count == 0)
                {
                    MessageBox.Show("No hay usuarios en el archivo JSON.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                comboBoxUsuariosAsignarTareas.Items.Clear();
                foreach (var usuario in listaUsuarios)
                {
                    comboBoxUsuariosAsignarTareas.Items.Add(usuario.nombreUsuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxProyectoNuevaTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCrearNuevaTarea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombreNuevaTarea.Text))
            {
                MessageBox.Show("Introduzca el nombre de la tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxProyectoNuevaTarea.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un proyecto para la tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listBoxUsuarios.Items.Count == 0)
            {
                MessageBox.Show("Asigne al menos un usuario a la tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Crear la nueva tarea
                NuevaTareaCreada = new Tareas
                {
                    nombreTarea = textBoxNombreNuevaTarea.Text,
                    descripcion = richTextBoxDescripcion.Text,
                    fechaEntrega = dateTimePickerFechaTareaFin.Value,
                    fechaInicio = dateTimePickerFechaTareaInicio.Value,
                    estado = "Pendiente",
                    usuariosAsignados = new List<Usuarios>()
                };

                // Añadir los usuarios seleccionados en la listbox a la nueva tarea
                foreach (var item in listBoxUsuarios.Items)
                {
                    NuevaTareaCreada.usuariosAsignados.Add(new Usuarios { nombreUsuario = item.ToString() });
                }

                // Ruta donde encuentra el proyecto
                string rutaArchivoProyecto = Path.GetFullPath(
                    Path.Combine(Application.StartupPath, @"..\..\..\JSON\Proyectos.json")
                );

                // Verificar que el archivo existe
                if (!File.Exists(rutaArchivoProyecto))
                {
                    MessageBox.Show($"No se encontró el archivo JSON en:\n{rutaArchivoProyecto}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //  Leer el JSON correctamente
                string jsonProyectos = File.ReadAllText(rutaArchivoProyecto);
                var listaProyectos = JsonSerializer.Deserialize<List<Proyectos>>(jsonProyectos);

                if (listaProyectos == null)
                {
                    MessageBox.Show("No se pudieron cargar los proyectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Buscar el proyecto seleccionado
                string nombreProyectoSeleccionado = comboBoxProyectoNuevaTarea.SelectedItem.ToString();
                var proyectoSeleccionado = listaProyectos.FirstOrDefault(p => p.NombreProyecto == nombreProyectoSeleccionado);

                if (proyectoSeleccionado == null)
                {
                    MessageBox.Show("No se encontró el proyecto seleccionado en el archivo JSON.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Añadir la nueva tarea al proyecto seleccionado
                if (proyectoSeleccionado.Tareas == null)
                    proyectoSeleccionado.Tareas = new List<Tareas>();

                proyectoSeleccionado.Tareas.Add(NuevaTareaCreada);

                // Guardar los cambios en el archivo JSON
                string proyectosActualizadosJson = JsonSerializer.Serialize(listaProyectos, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivoProyecto, proyectosActualizadosJson);

                MessageBox.Show("Tarea creada y asignada al proyecto correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la tarea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonCancelarTarea_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //ComboBox para seleccionar los usuarios y añadirlos a la listbox
        private void comboBoxUsuariosAsignarTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUsuariosAsignarTareas.SelectedItem != null)
            {
                String usuario = comboBoxUsuariosAsignarTareas.SelectedItem.ToString();

                if (!listBoxUsuarios.Items.Contains(usuario))
                {
                    listBoxUsuarios.Items.Add(usuario);
                }
                comboBoxUsuariosAsignarTareas.SelectedItem = -1;
            }

        }

        //Boton para quitar los usuarios dentro de la listbox
        private void buttonQuitarUsuario_Click(object sender, EventArgs e)
        {
            if(listBoxUsuarios.SelectedItem != null)
            {
                listBoxUsuarios.Items.Remove(listBoxUsuarios.SelectedItem);
            }
        }
    }
}
