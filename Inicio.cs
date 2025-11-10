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
            // === 1️⃣ 加载任务文件 ===
            string tareasPath = @"D:\GIT\Proyecto_escritorio_form\JSON\Proyectos.json";
            LoadJsonToTarea(tareasPath, dgvTarea);

            // === 2️⃣ 加载会议文件 ===
            string reunionesPath = @"D:\GIT\Proyecto_escritorio_form\JSON\Reuniones.json";
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
                    MessageBox.Show("Error al cargar reuniones: " + ex.Message);
                }
            }

            // === 3️⃣ 默认显示当天的会议 ===
            ShowReuniones(DateTime.Today);
        }


        //comboBox de proyecto 
        private void comboBoxProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //button de cambiar idioma
        private void btnIdioma_Click(object sender, EventArgs e)
        {

        }

        // evento de 
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            ShowReuniones(e.Start);
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

        //cargar los datos de tareas
        private void LoadJsonToTarea(string jsonPath, DataGridView dgv)
        {
            string jsonString = ReadJsonString(jsonPath);
            if (string.IsNullOrEmpty(jsonString)) return;

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Proyectos> proyectos = JsonSerializer.Deserialize<List<Proyectos>>(jsonString, options);

            if (proyectos == null || proyectos.Count == 0)
            {
                MessageBox.Show("No se encontraron proyectos en el archivo JSON.");
                return;
            }

            dgv.Rows.Clear();

            foreach (var proyecto in proyectos)
            {
                if (proyecto.Tareas == null) continue;

                foreach (var tarea in proyecto.Tareas)
                {
                    string usuarios = "";
                    if (tarea.usuariosAsignados != null && tarea.usuariosAsignados.Count > 0)
                    {
                        usuarios = string.Join(", ", tarea.usuariosAsignados.Select(u => u.nombreUsuario));
                    }

                    dgv.Rows.Add(
                        tarea.nombreTarea,
                        tarea.descripcion,
                        usuarios
                    );
                }
            }

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ShowReuniones(DateTime fechaSeleccionada)
        {
            panelTareaHoy.Controls.Clear();

            // Filtrar reuniones del día seleccionado
            var reunionesDelDia = reuniones
                .Where(r => r.fechaHora.Date == fechaSeleccionada.Date)
                .ToList();

            if (reunionesDelDia.Count == 0)
            {
                panelTareaHoy.Controls.Add(new Label
                {
                    Text = "No hay reuniones para este día.",
                    AutoSize = true,
                    Font = new System.Drawing.Font("Montserrat", 10, System.Drawing.FontStyle.Regular),
                    Top = 10,
                    Left = 10
                });
                return;
            }

            int top = 10;
            foreach (var r in reunionesDelDia)
            {
                // Título
                panelTareaHoy.Controls.Add(new Label
                {
                    Text = $" {r.titulo}",
                    AutoSize = true,
                    Font = new System.Drawing.Font("Montserrat", 11, System.Drawing.FontStyle.Bold),
                    Top = top,
                    Left = 10
                });
                top += 25;

                // Fecha y hora
                panelTareaHoy.Controls.Add(new Label
                {
                    Text = $"Fecha: {r.fechaHora:yyyy-MM-dd HH:mm}",
                    AutoSize = true,
                    Top = top,
                    Left = 10
                });
                top += 20;

                // Participantes
                string usuarios = r.usuariosReuniones != null && r.usuariosReuniones.Count > 0
                    ? string.Join(", ", r.usuariosReuniones)
                    : "(Sin participantes)";

                panelTareaHoy.Controls.Add(new Label
                {
                    Text = $"Usuarios Asignados: {usuarios}",
                    AutoSize = true,
                    Top = top,
                    Left = 10
                });
                top += 20;

                // Descripción
                panelTareaHoy.Controls.Add(new Label
                {
                    Text = $"Descripcion: {r.descripcion}",
                    AutoSize = true,
                    MaximumSize = new System.Drawing.Size(panelTareaHoy.Width - 30, 0),
                    Top = top,
                    Left = 10
                });
                top += 40;
            }
        }

    }
}