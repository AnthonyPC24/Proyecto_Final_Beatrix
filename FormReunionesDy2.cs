using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beatrix_Formulario.ClasesTareas;


namespace Beatrix_Formulario
{


    public partial class FormReunionesDy2 : Form
    {

        private const int MaxCaracteresDescripcion = 60;
        private const int MaxCaracteresAsunto = 30;

        public FormReunionesDy2()
        {


            InitializeComponent();
            this.Load += FormReunionesDy2_Load;
        }

        private void FormReunionesDy2_Load(object sender, EventArgs e)
        {

            try
            {
                string rutaArchivo = Path.Combine(Application.StartupPath, "JSON", "Usuarios.json");

                if (File.Exists(rutaArchivo))
                {
                    string json = File.ReadAllText(rutaArchivo);

                    
                    List<Usuarios> listaUsuarios = JsonSerializer.Deserialize<List<Usuarios>>(json);

                    listaUsuarios = listaUsuarios.OrderBy(u => u.nombreApellidos).ToList();

                    checkedListBoxParticipantes.DataSource = listaUsuarios;
                    checkedListBoxParticipantes.DisplayMember = "nombreApellidos";
                    checkedListBoxParticipantes.ValueMember = "email";
                }
                else
                {
                    MessageBox.Show("No se encontró el archivo Usuarios.json", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            
            List<string> participantesSeleccionados = new List<string>();

            foreach (var item in checkedListBoxParticipantes.CheckedItems)
            {
                if (item is Usuarios usuario)
                    participantesSeleccionados.Add(usuario.nombreApellidos);
            }

          
            Reunion nuevaReunion = new Reunion
            {
                titulo = textBoxAsunto.Text,
                fechaHora = dateTimePickerFechaHoraNuevaReunion.Value,
                usuariosReuniones = participantesSeleccionados,
                descripcion = richTextBoxInformacion.Text
            };


            // Sube tres niveles desde bin\Debug\net8.0-windows
            string rutaProyecto = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;

            // Asegura que la carpeta JSON exista
            string carpetaJson = Path.Combine(rutaProyecto, "JSON");
            Directory.CreateDirectory(carpetaJson);

            // Ruta completa al archivo Reuniones.json
            string rutaArchivo = Path.Combine(carpetaJson, "Reuniones.json");



            try
            {
                List<Reunion> listaReuniones = new List<Reunion>();

                
                if (File.Exists(rutaArchivo))
                {
                    string jsonExistente = File.ReadAllText(rutaArchivo);
                    listaReuniones = JsonSerializer.Deserialize<List<Reunion>>(jsonExistente);
                }

               
                listaReuniones.Add(nuevaReunion);

              
                string nuevoJson = JsonSerializer.Serialize(listaReuniones, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivo, nuevoJson);

                MessageBox.Show("Reunión creada y guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReunionCreada?.Invoke(this, EventArgs.Empty);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la reunión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public event EventHandler ReunionCreada;

        private void richTextBoxInformacion_TextChanged(object sender, EventArgs e)
        {
        
            if (richTextBoxInformacion.Text.Length > MaxCaracteresDescripcion)
            {
                richTextBoxInformacion.Text = richTextBoxInformacion.Text.Substring(0, MaxCaracteresDescripcion);
                richTextBoxInformacion.SelectionStart = richTextBoxInformacion.Text.Length;
            }

            labelContador2.Text = $"{richTextBoxInformacion.Text.Length}/{MaxCaracteresDescripcion}";
        }

        private void textBoxAsunto_TextChanged(object sender, EventArgs e)
        {

            if (textBoxAsunto.Text.Length > MaxCaracteresAsunto)
            {
                textBoxAsunto.Text = textBoxAsunto.Text.Substring(0, MaxCaracteresAsunto);
                textBoxAsunto.SelectionStart = textBoxAsunto.Text.Length;
            }

            labelContador1.Text = $"{textBoxAsunto.Text.Length}/{MaxCaracteresAsunto}";
        }
    }
 }

