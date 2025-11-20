using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using Beatrix_Formulario.ClasesTareas;

namespace Beatrix_Formulario
{
    public partial class FormProyectosGerard1 : Form
    {
        private List<Proyectos> listaDeProyectos;
        private string rutaArchivoJson;

        public FormProyectosGerard1()
        {
            InitializeComponent();

            // --- Lógica para apuntar a la carpeta del código fuente ---
            try
            {
                // Subimos 3 niveles desde /bin/Debug/net6.0/ para llegar a la raíz del proyecto
                string rutaProyecto = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                rutaArchivoJson = Path.Combine(rutaProyecto, "JSON", "Proyectos.JSON");
            }
            catch (Exception)
            {
                // Fallback por seguridad
                rutaArchivoJson = Path.Combine(Application.StartupPath, "JSON", "Proyectos.JSON");
            }
        }

        private void FormProyectosGerard1_Load_1(object sender, EventArgs e)
        {
            CargarProyectosDesdeJson();
        }

        // --- Cargar proyectos desde JSON ---
        private void CargarProyectosDesdeJson()
        {
            if (File.Exists(rutaArchivoJson))
            {
                try
                {
                    string json = File.ReadAllText(rutaArchivoJson, Encoding.UTF8);
                    if (string.IsNullOrWhiteSpace(json))
                    {
                        listaDeProyectos = new List<Proyectos>();
                    }
                    else
                    {
                        var options = new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        };
                        listaDeProyectos = JsonSerializer.Deserialize<List<Proyectos>>(json, options);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer el archivo JSON: {ex.Message}");
                    listaDeProyectos = new List<Proyectos>();
                }
            }
            else
            {
                listaDeProyectos = new List<Proyectos>();
            }

            RefrescarDataGridView();
        }

        // --- Refrescar la tabla ---
        private void RefrescarDataGridView()
        {
            dataGridViewTarea.Rows.Clear();

            if (listaDeProyectos == null) return;

            foreach (Proyectos proyecto in listaDeProyectos)
            {
                AgregarFilaAGrid(proyecto);
            }
        }

        // --- MÉTODO ACTUALIZADO: LEE DATOS DE LA RAÍZ DEL PROYECTO ---
        private void AgregarFilaAGrid(Proyectos proyecto)
        {
            string usuariosStr = "N/A";
            string fechaEntregaStr = "N/A";

            // --- 1. Procesar Usuarios (Desde la raíz: UsuariosAsignados) ---
            if (proyecto.UsuariosAsignados != null && proyecto.UsuariosAsignados.Any())
            {
                // Seleccionamos los nombres y quitamos duplicados
                var nombresUsuarios = proyecto.UsuariosAsignados
                    .Select(u => u.nombreUsuario)
                    .Where(n => !string.IsNullOrWhiteSpace(n)) // Seguridad extra
                    .Distinct();

                if (nombresUsuarios.Any())
                {
                    usuariosStr = string.Join(", ", nombresUsuarios);
                }
            }
            // (Opcional) Fallback: Si la raíz está vacía, mirar en tareas (para proyectos viejos)
            else if (proyecto.Tareas != null && proyecto.Tareas.Any())
            {
                var usuariosViejos = proyecto.Tareas
                   .SelectMany(t => t.usuariosAsignados ?? new List<Usuarios>())
                   .Select(u => u.nombreUsuario)
                   .Distinct();
                if (usuariosViejos.Any()) usuariosStr = string.Join(", ", usuariosViejos);
            }

            // --- 2. Procesar Fecha de Entrega (Desde la raíz: fechaEntrega) ---
            // Verificamos que no sea la fecha por defecto (0001-01-01)
            if (proyecto.fechaEntrega != DateTime.MinValue && proyecto.fechaEntrega.Year > 1)
            {
                fechaEntregaStr = proyecto.fechaEntrega.ToShortDateString();
            }

            // --- 3. Agregar la fila ---
            dataGridViewTarea.Rows.Add(
                proyecto.NombreProyecto,
                usuariosStr,
                fechaEntregaStr
            );
        }

        // --- Otros métodos del form (Búsqueda, Eliminación, Navegación) ---

        private void button1_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscarProyecto.Text.Trim();

            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                MessageBox.Show("Introduce un nombre de proyecto para buscar.");
                return;
            }

            dataGridViewTarea.ClearSelection();

            Proyectos proyectoEncontrado = listaDeProyectos.FirstOrDefault(p =>
                p.NombreProyecto.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0
            );

            if (proyectoEncontrado != null)
            {
                int index = listaDeProyectos.IndexOf(proyectoEncontrado);
                if (index >= 0 && index < dataGridViewTarea.Rows.Count)
                {
                    dataGridViewTarea.Rows[index].Selected = true;
                    dataGridViewTarea.FirstDisplayedScrollingRowIndex = index;
                    dataGridViewTarea.Focus();
                }
            }
            else
            {
                MessageBox.Show($"No se encontró ningún proyecto que contenga '{textoBusqueda}'.", "No Encontrado");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            using (FormProyectosGerard2 formCrear = new FormProyectosGerard2())
            {
                DialogResult resultado = formCrear.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    CargarProyectosDesdeJson();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTarea.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un proyecto de la lista para eliminar.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Estás seguro de que quieres eliminar este proyecto? Esta acción no se puede deshacer.",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.No) return;

            try
            {
                string nombreProyecto = dataGridViewTarea.SelectedRows[0].Cells[0].Value.ToString();
                Proyectos proyectoAEliminar = listaDeProyectos.FirstOrDefault(p => p.NombreProyecto == nombreProyecto);

                if (proyectoAEliminar != null)
                {
                    listaDeProyectos.Remove(proyectoAEliminar);
                    GuardarProyectosEnJson();
                    RefrescarDataGridView();
                    MessageBox.Show("Proyecto eliminado con éxito.", "Eliminado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el proyecto: {ex.Message}");
            }
        }

        private void GuardarProyectosEnJson()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonActualizado = JsonSerializer.Serialize(listaDeProyectos, options);
                File.WriteAllText(rutaArchivoJson, jsonActualizado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los cambios en JSON: {ex.Message}");
            }
        }

        private void dataGridViewTarea_SelectionChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = dataGridViewTarea.SelectedRows.Count > 0;
        }

        private void dataGridViewTarea_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                string nombreProyecto = dataGridViewTarea.Rows[e.RowIndex].Cells[0].Value.ToString();
                using (FormProyectosGerard3 formDetalle = new FormProyectosGerard3(nombreProyecto))
                {
                    formDetalle.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el detalle del proyecto: {ex.Message}");
            }
            CargarProyectosDesdeJson();
        }

        // Navegación y placeholders
        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }
        private void btnReunion_Click_1(object sender, EventArgs e)
        {
            FormReunionesDy1 formReunionesDy1 = new FormReunionesDy1();
            formReunionesDy1.Show();
            this.Hide();
        }
        private void btnTareas_Click(object sender, EventArgs e)
        {
            FormTareasTho1 formTareasTho1 = new FormTareasTho1();
            formTareasTho1.ShowDialog();
            this.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click_1(object sender, EventArgs e) { }
        private void btnReunion_Click(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e) { }
        private void dataGridViewTarea_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}