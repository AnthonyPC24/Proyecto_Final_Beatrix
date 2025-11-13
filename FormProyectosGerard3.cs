using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beatrix_Formulario.ClasesTareas;
using System;
using System.Collections.Generic;
using System.IO;                 // <--- Para Path y File
using System.Linq;                // <--- Para .FirstOrDefault
using System.Text;                // <--- Para Encoding.UTF8
using System.Text.Json;           // <--- Para JsonSerializer
using System.Windows.Forms;
using Beatrix_Formulario.ClasesTareas; // ¡Importante!

namespace Beatrix_Formulario
{
    public partial class FormProyectosGerard3 : Form
    {
        private string nombreProyectoBuscado;

        // 1. Constructor (recibe el string)
        public FormProyectosGerard3(string nombreProyecto)
        {
            InitializeComponent();
            this.nombreProyectoBuscado = nombreProyecto;
        }

        // 2. Evento Load del formulario (haz doble clic en tu form3 para crearlo)
        private void FormProyectosGerard3_Load_1(object sender, EventArgs e)
        {
            CargarDatosDelProyecto();
        }

        // 3. Método principal de carga
        private void CargarDatosDelProyecto()
        {
            if (string.IsNullOrEmpty(this.nombreProyectoBuscado))
            {
                MessageBox.Show("No se especificó ningún proyecto.");
                this.Close();
                return;
            }

            try
            {
                // --- Carga del JSON (igual que en Form1) ---
                string rutaArchivoJson = Path.Combine(Application.StartupPath, "JSON", "Proyectos.JSON");
                if (!File.Exists(rutaArchivoJson))
                {
                    MessageBox.Show("Error: No se encontró el archivo Proyectos.JSON");
                    return;
                }

                string json = File.ReadAllText(rutaArchivoJson, Encoding.UTF8);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                List<Proyectos> listaDeProyectos = JsonSerializer.Deserialize<List<Proyectos>>(json, options);
                // --- Fin de la carga ---

                // 4. Buscar el proyecto específico
                Proyectos proyectoActual = listaDeProyectos.FirstOrDefault(p => p.NombreProyecto == this.nombreProyectoBuscado);

                if (proyectoActual == null)
                {
                    MessageBox.Show($"No se pudieron encontrar los datos para: {this.nombreProyectoBuscado}");
                    this.Close();
                    return;
                }

                // 5. Rellenar los controles (¡LA LÓGICA CORREGIDA!)

                // Título (Esto es fácil)
                labelTituloProyecto.Text = proyectoActual.NombreProyecto;

                // Comprobar si hay tareas para procesar
                if (proyectoActual.Tareas != null && proyectoActual.Tareas.Any())
                {
                    // Filtramos tareas nulas por si acaso
                    var tareasValidas = proyectoActual.Tareas.Where(t => t != null);

                    // --- Fechas ---
                    // Asumimos que las clases de Tarea tienen 'FechaInicio' y 'FechaEntrega' (con mayúscula)
                    // Buscamos la fecha de inicio MÁS TEMPRANA
                    DateTime fechaInicio = tareasValidas.Min(t => t.fechaInicio);
                    // Buscamos la fecha de entrega MÁS TARDÍA
                    DateTime fechaEntrega = tareasValidas.Max(t => t.fechaEntrega);

                    lblFechaInicio.Text = fechaInicio.ToShortDateString();
                    lblFechaEntrega.Text = fechaEntrega.ToShortDateString();

                    // --- Usuarios ---
                    // Asumimos que Tarea tiene 'UsuariosAsignados' y la clase de usuario es 'Usuarios' (plural, como antes)
                    var todosLosUsuarios = tareasValidas
                        .SelectMany(t => t.usuariosAsignados ?? new List<Usuarios>())
                        .Where(u => u != null)
                        .Select(u => u.nombreUsuario)
                        .Distinct();

                    if (todosLosUsuarios.Any())
                    {
                        txtUsuariosAsignados.Text = string.Join(", ", todosLosUsuarios);
                    }
                    else
                    {
                        txtUsuariosAsignados.Text = "No hay usuarios en las tareas.";
                    }

                    // --- Descripción ---
                    // Asumimos que Tarea tiene 'Descripcion'
                    // Vamos a juntar todas las descripciones de las tareas
                    var descripciones = tareasValidas
                        .Select(t => t.descripcion) // Ajusta 'descripcion' a 'Descripcion' si es PascalCase
                        .Where(d => !string.IsNullOrEmpty(d));

                    if (descripciones.Any())
                    {
                        // Environment.NewLine hace un salto de línea real en el TextBox
                        txtDescripcion.Text = string.Join(Environment.NewLine, descripciones);
                    }
                    else
                    {
                        txtDescripcion.Text = "No hay descripciones en las tareas.";
                    }
                }
                else
                {
                    // Si el proyecto no tiene tareas, mostramos N/A
                    lblFechaInicio.Text = "N/A";
                    lblFechaEntrega.Text = "N/A";
                    txtUsuariosAsignados.Text = "Sin tareas asignadas.";
                    txtDescripcion.Text = "Sin tareas asignadas.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fatal al cargar los datos del proyecto: {ex.Message}");
                this.Close();
            }
        }

        private void lbltituloform_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuariosAsignados_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}