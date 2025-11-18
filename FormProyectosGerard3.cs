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
using System.IO;                // <--- Necesario para Path y File
using System.Text.Json;         // <--- Necesario para JsonSerializer

namespace Beatrix_Formulario
{
    public partial class FormProyectosGerard3 : Form
    {
        private string nombreProyectoBuscado;

        // 1. Constructor
        public FormProyectosGerard3(string nombreProyecto)
        {
            InitializeComponent();
            this.nombreProyectoBuscado = nombreProyecto;
        }

        // 2. Evento Load
        private void FormProyectosGerard3_Load_1(object sender, EventArgs e)
        {
            CargarDatosDelProyecto();
        }

        // 3. Método principal de carga
        private void CargarDatosDelProyecto()
        {
            // Validación inicial
            if (string.IsNullOrEmpty(this.nombreProyectoBuscado))
            {
                MessageBox.Show("No se especificó ningún proyecto.");
                this.Close();
                return;
            }

            try
            {
                // --- A. Cargar el JSON ---
                string rutaArchivoJson = Path.Combine(Application.StartupPath, "JSON", "Proyectos.JSON");

                if (!File.Exists(rutaArchivoJson))
                {
                    MessageBox.Show("Error: No se encontró el archivo Proyectos.JSON");
                    return;
                }

                string json = File.ReadAllText(rutaArchivoJson, Encoding.UTF8);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                // Deserializamos la lista de proyectos
                List<Proyectos> listaDeProyectos = JsonSerializer.Deserialize<List<Proyectos>>(json, options);

                // --- B. Buscar el proyecto ---
                Proyectos proyectoActual = listaDeProyectos.FirstOrDefault(p => p.NombreProyecto == this.nombreProyectoBuscado);

                if (proyectoActual == null)
                {
                    MessageBox.Show($"No se pudieron encontrar los datos para: {this.nombreProyectoBuscado}");
                    this.Close();
                    return;
                }

                // --- C. Rellenar la interfaz ---

                // 1. Título del Proyecto
                labelTituloProyecto.Text = proyectoActual.NombreProyecto;

                // 2. Descripción del Proyecto (En el TextBox 'txtBoxDescr')
                if (!string.IsNullOrEmpty(proyectoActual.DescripcionProyecto))
                {
                    txtBoxDescr.Text = proyectoActual.DescripcionProyecto;
                }
                else
                {
                    txtBoxDescr.Text = "Este proyecto no tiene una descripción general.";
                }

                // 3. Cálculos basados en las Tareas (Fechas y Usuarios)
                if (proyectoActual.Tareas != null && proyectoActual.Tareas.Any())
                {
                    // Filtramos tareas que no sean nulas
                    var tareasValidas = proyectoActual.Tareas.Where(t => t != null);

                    // -- Fechas (Inicio Mínima y Entrega Máxima) --
                    DateTime fechaInicio = tareasValidas.Min(t => t.fechaInicio);
                    DateTime fechaEntrega = tareasValidas.Max(t => t.fechaEntrega);

                    lblFechaInicio.Text = fechaInicio.ToShortDateString();
                    lblFechaEntrega.Text = fechaEntrega.ToShortDateString();

                    // -- Usuarios Asignados (Unir todos sin repetir) --
                    var todosLosUsuarios = tareasValidas
                        .SelectMany(t => t.usuariosAsignados ?? new List<Usuarios>()) // Si es null, usa lista vacía
                        .Where(u => u != null)
                        .Select(u => u.nombreUsuario)
                        .Distinct(); // Elimina duplicados

                    if (todosLosUsuarios.Any())
                    {
                        txtUsuariosAsignados.Text = string.Join(", ", todosLosUsuarios);
                    }
                    else
                    {
                        txtUsuariosAsignados.Text = "No hay usuarios asignados a las tareas.";
                    }
                }
                else
                {
                    // Si no hay tareas, mostramos valores por defecto
                    lblFechaInicio.Text = "N/A";
                    lblFechaEntrega.Text = "N/A";
                    txtUsuariosAsignados.Text = "Sin tareas asignadas.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
                this.Close();
            }
        }

        // --- Eventos vacíos generados por el diseñador ---
        private void lbltituloform_Click(object sender, EventArgs e) { }
        private void txtUsuariosAsignados_TextChanged(object sender, EventArgs e) { }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            // 1. Usamos directamente el nombre del proyecto actual (guardado en la variable global)
            // No hace falta buscar en ningún ListBox
            string nombreDelProyecto = this.nombreProyectoBuscado;

            // 2. Abrimos el formulario de edición pasando ese nombre
            FormProyectosGerard4 formEditar = new FormProyectosGerard4(nombreDelProyecto);

            // 3. Esperamos a que se cierre
            if (formEditar.ShowDialog() == DialogResult.OK)
            {
                // 4. ACTUALIZACIÓN CRÍTICA:
                // Si editaste el nombre del proyecto, tenemos que actualizar nuestra variable local
                // para que la función 'CargarDatosDelProyecto' busque el nombre NUEVO, no el viejo.
                if (formEditar.ProyectoEditado != null)
                {
                    this.nombreProyectoBuscado = formEditar.ProyectoEditado.NombreProyecto;
                }

                // 5. Recargamos los datos en pantalla para ver los cambios
                CargarDatosDelProyecto();
            }
        }
    }
}