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

            rutaArchivoJson = Path.Combine(Application.StartupPath, "JSON", "Proyectos.JSON");
        }

        private void FormProyectosGerard1_Load_1(object sender, EventArgs e)
        {
            CargarProyectosDesdeJson();
        }

        // --- Al hacer clic en "Crear Proyecto" ---

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

        // ... El resto de tus métodos (FormProyectosGerard1_Load, etc.) ...

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

        private void AgregarFilaAGrid(Proyectos proyecto)
        {
            string usuariosStr = "N/A";
            DateTime fechaEntregaFinal = DateTime.MinValue; // Un valor inicial bajo

            // --- 1. Procesar Usuarios Agregados ---
            // Comprobamos que el proyecto tenga tareas
            if (proyecto.Tareas != null && proyecto.Tareas.Any())
            {
                // Usamos SelectMany para "aplanar" todas las listas de usuarios de todas las tareas
                // en una sola gran lista.
                // Luego seleccionamos el nombreUsuario.
                // Usamos Distinct() para evitar nombres repetidos.
                var todosLosUsuarios = proyecto.Tareas
                    .SelectMany(tarea => tarea.usuariosAsignados ?? new List<Usuarios>()) // Aplanamos y evitamos nulls
                    .Select(usuario => usuario.nombreUsuario)
                    .Distinct();

                if (todosLosUsuarios.Any())
                {
                    usuariosStr = string.Join(", ", todosLosUsuarios);
                }
            }

            // --- 2. Procesar Fecha de Entrega ---
            // Buscamos la fecha de entrega más lejana (Max) de todas las tareas
            if (proyecto.Tareas != null && proyecto.Tareas.Any())
            {
                // Nos aseguramos de que haya tareas con fechas válidas antes de buscar el Max
                var fechasValidas = proyecto.Tareas.Select(t => t.fechaEntrega).Where(d => d > DateTime.MinValue);
                if (fechasValidas.Any())
                {
                    fechaEntregaFinal = fechasValidas.Max();
                }
            }

            // --- 3. Agregar la fila con los datos procesados ---
            dataGridViewTarea.Rows.Add(
                proyecto.NombreProyecto,
                usuariosStr,
                // Mostramos la fecha final solo si encontramos una válida
                fechaEntregaFinal > DateTime.MinValue ? fechaEntregaFinal.ToShortDateString() : "N/A"
            );
        }

        // --- Otros métodos del form ---
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Obtenemos el texto del TextBox y quitamos espacios en blanco
            string textoBusqueda = txtBuscarProyecto.Text.Trim();

            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                MessageBox.Show("Introduce un nombre de proyecto para buscar.");
                return;
            }

            // 2. Deseleccionamos cualquier fila que estuviera seleccionada antes
            dataGridViewTarea.ClearSelection();

            // 3. Buscamos en nuestra lista de datos (listaDeProyectos)
            //    Usamos 'IndexOf' con 'StringComparison.OrdinalIgnoreCase' para que
            //    busque el texto (aunque esté en mayúsculas o minúsculas)
            Proyectos proyectoEncontrado = listaDeProyectos.FirstOrDefault(p =>
                p.NombreProyecto.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0
            );

            // 4. Si lo encontramos...
            if (proyectoEncontrado != null)
            {
                // 5. Obtenemos el índice (la posición) de ese proyecto en la lista
                int index = listaDeProyectos.IndexOf(proyectoEncontrado);

                // 6. Nos aseguramos de que el índice es válido
                if (index >= 0 && index < dataGridViewTarea.Rows.Count)
                {
                    // 7. Seleccionamos la fila correspondiente en la tabla
                    dataGridViewTarea.Rows[index].Selected = true;
                        
                    // 8. Opcional: Hacemos scroll para que la fila se vea
                    dataGridViewTarea.FirstDisplayedScrollingRowIndex = index;

                    // 9. Opcional: Ponemos el foco en la tabla para que se vea la selección
                    dataGridViewTarea.Focus();
                }
            }
            else
            {
                // 10. Si no se encuentra, avisamos al usuario
                MessageBox.Show($"No se encontró ningún proyecto que contenga '{textoBusqueda}'.", "No Encontrado");
            }
        }
        private void btnReunion_Click(object sender, EventArgs e) { }
        private void btnTareas_Click(object sender, EventArgs e)
        {
            FormTareasTho1 formTareasTho1 = new FormTareasTho1();
            formTareasTho1.ShowDialog();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e) { }
        private void dataGridViewTarea_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void button4_Click_1(object sender, EventArgs e)
        {
            using (FormProyectosGerard2 formCrear = new FormProyectosGerard2())
            {
                DialogResult resultado = formCrear.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    CargarProyectosDesdeJson(); // Solo recargamos los datos
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Asegurarnos de que hay algo seleccionado
            if (dataGridViewTarea.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un proyecto de la lista para eliminar.");
                return;
            }

            // 2. Pedir confirmación al usuario
            DialogResult confirmacion = MessageBox.Show(
                "¿Estás seguro de que quieres eliminar este proyecto? Esta acción no se puede deshacer.",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.No)
            {
                return; // El usuario canceló
            }

            // 3. Obtener el proyecto a eliminar
            try
            {
                // Obtenemos el nombre del proyecto desde la celda 0 de la fila seleccionada
                string nombreProyecto = dataGridViewTarea.SelectedRows[0].Cells[0].Value.ToString();

                // Buscamos ese proyecto en nuestra lista principal
                Proyectos proyectoAEliminar = listaDeProyectos.FirstOrDefault(p => p.NombreProyecto == nombreProyecto);

                if (proyectoAEliminar != null)
                {
                    // 4. Eliminarlo de la lista en memoria
                    listaDeProyectos.Remove(proyectoAEliminar);

                    // 5. Guardar la lista actualizada en el archivo JSON
                    GuardarProyectosEnJson();

                    // 6. Refrescar el DataGridView para que desaparezca
                    RefrescarDataGridView();

                    MessageBox.Show("Proyecto eliminado con éxito.", "Eliminado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el proyecto: {ex.Message}");
            }
        }

        private void dataGridViewTarea_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTarea.SelectedRows.Count > 0)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        private void GuardarProyectosEnJson()
        {
            try
            {
                // Opciones para que el JSON se vea bonito (indentado)
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                // Serializa la lista COMPLETA (con los proyectos ya eliminados)
                string jsonActualizado = JsonSerializer.Serialize(listaDeProyectos, options);

                // Escribe el nuevo JSON al disco
                File.WriteAllText(rutaArchivoJson, jsonActualizado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los cambios en JSON: {ex.Message}");
            }
        }

        private void dataGridViewTarea_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignorar cabecera

            try
            {
                // 1. Obtener el nombre (string)
                string nombreProyecto = dataGridViewTarea.Rows[e.RowIndex].Cells[0].Value.ToString();

                // 2. Abrir Form3 pasándole el nombre
                using (FormProyectosGerard3 formDetalle = new FormProyectosGerard3(nombreProyecto))
                {
                    formDetalle.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el detalle del proyecto: {ex.Message}");
            }
        }

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
    }
}
