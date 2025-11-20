using Beatrix_Formulario.ClasesTareas;
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

namespace Beatrix_Formulario
{
    public partial class Inicio : Form
    {
        private List<Reunion> reuniones = new List<Reunion>();

        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            string tareasPath = Path.Combine(Application.StartupPath, "JSON", "Proyectos.json");
            string reunionesPath = Path.Combine(Application.StartupPath, "JSON", "Reuniones.json");

            if (File.Exists(tareasPath))
            {
                try
                {
                    string jsonString = File.ReadAllText(tareasPath);
                    var proyectos = JsonSerializer.Deserialize<List<Proyectos>>(jsonString, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (proyectos != null && proyectos.Count > 0)
                    {
                        // Crear lista con texto mostrado (Proyecto 1, 2, 3) y objeto real
                        var comboData = proyectos.Select((p, index) => new
                        {
                            Display = $"Proyecto {index + 1}", // Texto que ve el usuario
                            Proyecto = p // Objeto real
                        }).ToList();

                        comboBoxProyecto.DataSource = comboData;
                        comboBoxProyecto.DisplayMember = "Display"; // Texto visual
                        comboBoxProyecto.ValueMember = "Proyecto"; // Objeto real
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar proyectos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show($"No se encontró el archivo de proyectos: {tareasPath}");
            }

            // cargar los reuniones
            if (File.Exists(reunionesPath))
            {
                string jsonString = ReadJsonString(reunionesPath);
                if (!string.IsNullOrEmpty(jsonString))
                {
                    try
                    {
                        var options = new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        };
                        reuniones = JsonSerializer.Deserialize<List<Reunion>>(jsonString, options);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar las reuniones: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show($"No se encontró el archivo de reuniones: {reunionesPath}");
            }

            // mostrar los reuniones
            MostrarReuniones(DateTime.Today);
        }

        //comboBox de proyecto
        private void comboBoxProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProyecto.SelectedValue is Proyectos proyectoSeleccionado)
            {
                dgvTarea.Rows.Clear();

                foreach (var tarea in proyectoSeleccionado.Tareas)
                {
                    string usuarios = (tarea.usuariosAsignados != null && tarea.usuariosAsignados.Count > 0)
                        ? string.Join(", ", tarea.usuariosAsignados.Select(u => u.nombreUsuario))
                        : "(Sin usuarios)";

                    dgvTarea.Rows.Add(tarea.nombreTarea, tarea.descripcion, usuarios);
                }
            }
        }

        // evento de hacer click a calendar
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            MostrarReuniones(e.Start);
        }

        private string ReadJsonString(string jsonPath)
        {
            if (!File.Exists(jsonPath))
            {
                MessageBox.Show("Archivo JSON no encontrado: " + jsonPath);
                return null;
            }

            try
            {
                return File.ReadAllText(jsonPath).Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer JSON: " + ex.Message);
                return null;
            }
        }

        private void MostrarReuniones(DateTime fechaSeleccionada)
        {
            if (reuniones == null || reuniones.Count == 0)
            {
                dgvReuniones.Rows.Clear();
                return;
            }

            var reunionesDelDia = reuniones
                .Where(r => r.fechaHora.Date == fechaSeleccionada.Date)
                .OrderBy(r => r.fechaHora)
                .ToList();

            dgvReuniones.Rows.Clear();

            if (reunionesDelDia.Count == 0)
            {
                return;
            }

            foreach (var r in reunionesDelDia)
            {
                string usuarios = (r.usuariosReuniones != null && r.usuariosReuniones.Count > 0)
                    ? string.Join(", ", r.usuariosReuniones)
                    : "(Sin participantes)";

                dgvReuniones.Rows.Add(
                    r.titulo,
                    r.fechaHora.ToString("yyyy-MM-dd HH:mm"),
                    usuarios,
                    r.descripcion
                );
            }

            dgvReuniones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            if (!MostrarFormExist<Inicio>())
            {
                Inicio inicioForm = new Inicio();
                inicioForm.Show();
            }
        }

        private void buttonProyetos_Click(object sender, EventArgs e)
        {
            if (!MostrarFormExist<FormProyectosGerard1>())
            {
                FormProyectosGerard1 proyectosForm = new FormProyectosGerard1();
                proyectosForm.Show();
            }
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            if (!MostrarFormExist<FormProyectosGerard2>())
            {
                FormProyectosGerard2 tareasForm = new FormProyectosGerard2();
                tareasForm.Show();
            }
        }

        private void btnReuniones_Click(object sender, EventArgs e)
        {

            if (!MostrarFormExist<FormReunionesDy1>())
            {
                FormReunionesDy1 reunionesForm = new FormReunionesDy1();
                reunionesForm.Show();
            }
        }

        //foto de usuario
        private void pbUser_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios();
            formUsuarios.Show();
            this.Hide();
            
        }

        private bool MostrarFormExist<T>() where T : Form
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is T)
                {
                    frm.BringToFront();
                    frm.WindowState = FormWindowState.Normal;
                    return true;
                }
            }
            return false;
        }
    }
}
