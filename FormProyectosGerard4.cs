// --- AÑADE ESTOS 'USING' AL PRINCIPIO ---
using Beatrix_Formulario.ClasesTareas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Beatrix_Formulario
{
    public partial class FormProyectosGerard4 : Form
    {
        private string nombreProyectoOriginal;
        public Proyectos ProyectoEditado { get; private set; }

        // Listas para gestionar los datos
        private List<Proyectos> listaCompletaDeProyectos;
        private Proyectos proyectoAEditar;
        private List<Usuarios> listaTotalUsuariosDisponibles;

        public FormProyectosGerard4(string nombreProyectoAEditar)
        {
            InitializeComponent();
            this.nombreProyectoOriginal = nombreProyectoAEditar;

            if (this.btnCrear != null) this.btnCrear.Text = "Guardar Cambios";
        }

        private void FormProyectosGerard4_Load(object sender, EventArgs e)
        {
            // 1. Cargar Usuarios disponibles
            CargarUsuariosDelJson();

            try
            {
                // 2. Calcular ruta del JSON y Cargar Proyectos
                string rutaProyectoSource = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                string rutaProyectosJson = Path.Combine(rutaProyectoSource, "JSON", "Proyectos.JSON");

                // Fallback
                if (!File.Exists(rutaProyectosJson))
                {
                    rutaProyectosJson = Path.Combine(Application.StartupPath, "JSON", "Proyectos.JSON");
                    if (!File.Exists(rutaProyectosJson))
                    {
                        MessageBox.Show("No se encuentra el archivo Proyectos.JSON");
                        this.Close();
                        return;
                    }
                }

                string jsonProyectos = File.ReadAllText(rutaProyectosJson);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                listaCompletaDeProyectos = JsonSerializer.Deserialize<List<Proyectos>>(jsonProyectos, options);
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
                textBoxEstado.Text = proyectoAEditar.Estado;

                if (proyectoAEditar.fechaInicio != DateTime.MinValue)
                    dateTimePicker1.Value = proyectoAEditar.fechaInicio;

                if (proyectoAEditar.fechaEntrega != DateTime.MinValue)
                    dateTimePicker2.Value = proyectoAEditar.fechaEntrega;

                // --- RELLENAR LISTA DE USUARIOS ASIGNADOS (Strings) ---
                listBoxUsuarios.Items.Clear();

                if (proyectoAEditar.UsuariosAsignados != null && proyectoAEditar.UsuariosAsignados.Any())
                {
                    foreach (var usuario in proyectoAEditar.UsuariosAsignados)
                    {
                        listBoxUsuarios.Items.Add(usuario.nombreUsuario);
                    }
                }
                // Fallback
                else if (proyectoAEditar.Tareas != null && proyectoAEditar.Tareas.Any())
                {
                    var usuariosViejos = proyectoAEditar.Tareas
                        .SelectMany(t => t.usuariosAsignados ?? new List<Usuarios>())
                        .Select(u => u.nombreUsuario)
                        .Distinct();

                    foreach (var u in usuariosViejos) listBoxUsuarios.Items.Add(u);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el proyecto: {ex.Message}");
                this.Close();
            }
        }

        // --- LOGICA GUARDAR ---
        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.");
                return;
            }
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("El campo 'Descripción' es obligatorio.");
                return;
            }
            if (listBoxUsuarios.Items.Count == 0)
            {
                MessageBox.Show("Debe haber al menos un usuario asignado.");
                return;
            }
            if (dateTimePicker2.Value.Date < dateTimePicker1.Value.Date)
            {
                MessageBox.Show("La fecha de entrega no puede ser anterior a la de inicio.");
                return;
            }

            try
            {
                // 1. Actualizar datos básicos (EN MEMORIA)
                proyectoAEditar.NombreProyecto = txtNombre.Text;
                proyectoAEditar.DescripcionProyecto = richTextBox1.Text;
                proyectoAEditar.fechaInicio = dateTimePicker1.Value;
                proyectoAEditar.fechaEntrega = dateTimePicker2.Value;
                proyectoAEditar.Estado = textBoxEstado.Text;

                // 2. RECONSTRUIR LISTA DE USUARIOS
                // Leemos lo que hay AHORA MISMO en el ListBox (después de que hayas quitado/añadido)
                List<Usuarios> usuariosFinales = new List<Usuarios>();

                foreach (object item in listBoxUsuarios.Items)
                {
                    string nombreEnLista = item.ToString();

                    // Recuperamos el objeto completo de la lista total para no perder datos (email, etc.)
                    Usuarios usuarioCompleto = listaTotalUsuariosDisponibles?
                        .FirstOrDefault(u => u.nombreUsuario == nombreEnLista);

                    if (usuarioCompleto != null)
                    {
                        usuariosFinales.Add(usuarioCompleto);
                    }
                    else
                    {
                        // Si es un usuario nuevo o manual
                        usuariosFinales.Add(new Usuarios { nombreUsuario = nombreEnLista });
                    }
                }

                // Sobreescribimos la lista de usuarios del proyecto con la NUEVA lista
                proyectoAEditar.UsuariosAsignados = usuariosFinales;

                // 3. GUARDAR EN DISCO
                // Como 'proyectoAEditar' es una referencia a un objeto dentro de 'listaCompletaDeProyectos',
                // al modificarlo arriba, la lista completa ya está actualizada. Solo hay que guardar.

                string rutaProyectoSource = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                string rutaArchivoJson = Path.Combine(rutaProyectoSource, "JSON", "Proyectos.JSON");

                if (!Directory.Exists(Path.GetDirectoryName(rutaArchivoJson)))
                    rutaArchivoJson = Path.Combine(Application.StartupPath, "JSON", "Proyectos.JSON");

                var options = new JsonSerializerOptions { WriteIndented = true, PropertyNameCaseInsensitive = true };
                string jsonActualizado = JsonSerializer.Serialize(listaCompletaDeProyectos, options);

                File.WriteAllText(rutaArchivoJson, jsonActualizado);

                // 4. Cerrar
                this.ProyectoEditado = proyectoAEditar;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar cambios: {ex.Message}");
            }
        }

        // --- CARGAR USUARIOS ---
        private void CargarUsuariosDelJson()
        {
            try
            {
                string rutaProyecto = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                string rutaUsuariosJson = Path.Combine(rutaProyecto, "JSON", "Usuarios.JSON");

                if (!File.Exists(rutaUsuariosJson))
                    rutaUsuariosJson = Path.Combine(Application.StartupPath, "JSON", "Usuarios.JSON");

                if (File.Exists(rutaUsuariosJson))
                {
                    string json = File.ReadAllText(rutaUsuariosJson);
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    listaTotalUsuariosDisponibles = JsonSerializer.Deserialize<List<Usuarios>>(json, options);

                    if (listaTotalUsuariosDisponibles != null)
                    {
                        comboBoxUsuarios.Items.Clear();
                        foreach (Usuarios user in listaTotalUsuariosDisponibles)
                        {
                            comboBoxUsuarios.Items.Add(user);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}");
                listaTotalUsuariosDisponibles = new List<Usuarios>();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Enlaces duplicados por seguridad del diseñador
        private void btnCrear_Click(object sender, EventArgs e) { btnCrear_Click_1(sender, e); }

        private void quitarUsuarios_Click_1(object sender, EventArgs e)
        {
            // Usamos SelectedIndex, es más seguro
            if (listBoxUsuarios.SelectedIndex != -1)
            {
                // Borramos el ítem en la posición seleccionada
                listBoxUsuarios.Items.RemoveAt(listBoxUsuarios.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un nombre de la lista para quitarlo.");
            }
        }

        private void comboBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUsuarios.SelectedItem != null)
            {
                Usuarios usuarioSeleccionado = (Usuarios)comboBoxUsuarios.SelectedItem;

                // Usamos explícitamente el nombre, no el ToString()
                string nombre = usuarioSeleccionado.nombreUsuario;

                if (!string.IsNullOrEmpty(nombre) && !listBoxUsuarios.Items.Contains(nombre))
                {
                    listBoxUsuarios.Items.Add(nombre);
                }

                comboBoxUsuarios.SelectedIndex = -1;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}