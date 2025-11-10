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

            // ✅ Usa una ruta segura (siempre relativa al ejecutable)
            rutaArchivoJson = Path.Combine(Application.StartupPath, "JSON", "Proyectos.JSON");
        }

        private void FormProyectosGerard1_Load_1(object sender, EventArgs e)
        {
            CargarProyectosDesdeJson();
        }

        // --- Al hacer clic en "Crear Proyecto" ---
        private void label1_Click(object sender, EventArgs e)
        {
            using (FormProyectosGerard2 formCrear = new FormProyectosGerard2())
            {
                DialogResult resultado = formCrear.ShowDialog();

                // ✅ Ya no llamamos a GuardarProyectosEnJson()
                // porque Form2 ya guarda el proyecto directamente.
                if (resultado == DialogResult.OK)
                {
                    CargarProyectosDesdeJson(); // Solo recargamos los datos
                }
            }
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
                        listaDeProyectos = JsonSerializer.Deserialize<List<Proyectos>>(json);
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

        private void AgregarFilaAGrid(Proyectos proyecto)
        {
            string usuariosStr = "N/A";

            if (proyecto.UsuariosAsignados != null && proyecto.UsuariosAsignados.Any())
            {
                usuariosStr = string.Join(", ", proyecto.UsuariosAsignados.Select(u => u.nombreApellidos));
            }

            dataGridViewTarea.Rows.Add(
                proyecto.NombreProyecto,
                usuariosStr,
                proyecto.fechaEntrega.ToShortDateString()
            );
        }

        // --- Otros métodos del form ---
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click_1(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void btnReunion_Click(object sender, EventArgs e) { }
        private void btnTareas_Click(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e) { }
        private void dataGridViewTarea_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
