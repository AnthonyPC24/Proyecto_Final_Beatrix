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
                // --- A. Cargar el JSON (Ruta Corregida) ---
                // Subimos 3 niveles desde /bin/Debug/netX.0/ para llegar a la raíz del proyecto
                string rutaProyecto;
                try
                {
                    rutaProyecto = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                }
                catch
                {
                    // Fallback por si acaso
                    rutaProyecto = Application.StartupPath;
                }

                string rutaArchivoJson = Path.Combine(rutaProyecto, "JSON", "Proyectos.JSON");

                if (!File.Exists(rutaArchivoJson))
                {
                    MessageBox.Show($"Error: No se encontró el archivo en: {rutaArchivoJson}");
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

                textBoxEstado.Text = proyectoActual.Estado;

                // 2. Descripción del Proyecto
                if (!string.IsNullOrEmpty(proyectoActual.DescripcionProyecto))
                {
                    txtBoxDescr.Text = proyectoActual.DescripcionProyecto;
                }
                else
                {
                    txtBoxDescr.Text = "Este proyecto no tiene una descripción general.";
                }

                // 3. Fechas (Ahora se leen directo del Proyecto)
                if (proyectoActual.fechaInicio != DateTime.MinValue)
                {
                    lblFechaInicio.Text = proyectoActual.fechaInicio.ToShortDateString();
                }
                else
                {
                    lblFechaInicio.Text = "N/A";
                }

                if (proyectoActual.fechaEntrega != DateTime.MinValue)
                {
                    lblFechaEntrega.Text = proyectoActual.fechaEntrega.ToShortDateString();
                }
                else
                {
                    lblFechaEntrega.Text = "N/A";
                }

                

                // 4. Usuarios Asignados (Ahora se leen directo del Proyecto)
                if (proyectoActual.UsuariosAsignados != null && proyectoActual.UsuariosAsignados.Any())
                {
                    // Seleccionamos solo los nombres y evitamos duplicados
                    var nombresUsuarios = proyectoActual.UsuariosAsignados
                        .Select(u => u.nombreUsuario)
                        .Where(n => !string.IsNullOrWhiteSpace(n))
                        .Distinct();

                    if (nombresUsuarios.Any())
                    {
                        txtUsuariosAsignados.Text = string.Join(", ", nombresUsuarios);
                    }
                    else
                    {
                        txtUsuariosAsignados.Text = "Sin usuarios asignados.";
                    }
                }
                else
                {
                    // (Opcional) Fallback para proyectos antiguos: Mirar en las tareas
                    if (proyectoActual.Tareas != null && proyectoActual.Tareas.Any())
                    {
                        var usuariosViejos = proyectoActual.Tareas
                           .SelectMany(t => t.usuariosAsignados ?? new List<Usuarios>())
                           .Select(u => u.nombreUsuario)
                           .Distinct();

                        if (usuariosViejos.Any())
                            txtUsuariosAsignados.Text = string.Join(", ", usuariosViejos);
                        else
                            txtUsuariosAsignados.Text = "Sin usuarios asignados.";
                    }
                    else
                    {
                        txtUsuariosAsignados.Text = "Sin usuarios asignados.";
                    }
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
            // 1. Usamos directamente el nombre del proyecto actual
            string nombreDelProyecto = this.nombreProyectoBuscado;

            // 2. Abrimos el formulario de edición pasando ese nombre
            FormProyectosGerard4 formEditar = new FormProyectosGerard4(nombreDelProyecto);

            // 3. Esperamos a que se cierre
            if (formEditar.ShowDialog() == DialogResult.OK)
            {
                // 4. Actualizamos el nombre buscado por si se editó el título del proyecto
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