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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();

            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
        }

        private void lblCrearUsuario_Click(object sender, EventArgs e)
        {
            FormPantallaUsuario crearNuevoUsusario = new FormPantallaUsuario();
            crearNuevoUsusario.Show();

        }

        private void CargarUsuarios()
        {
            string proyectoRaiz = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..");
            string carpetaJSON = Path.Combine(proyectoRaiz, "JSON");
            string usuariosPath = Path.Combine(carpetaJSON, "Usuarios.json");

            if (!File.Exists(usuariosPath))
            {
                MessageBox.Show($"Archivo de usuarios no encontrado: {usuariosPath}");
                return;
            }

            try
            {
                string json = File.ReadAllText(usuariosPath);
                List<Usuarios> usuarios = JsonSerializer.Deserialize<List<Usuarios>>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                dgvUsuarios.Columns.Clear();
                dgvUsuarios.AutoGenerateColumns = false;

                // Configurar columnas de dgvUsuarios
                dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "nombreUsuario",
                    HeaderText = "Nombre de Usuario"
                });

                dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "nombreApellidos",
                    HeaderText = "Nombre y Apellidos"
                });

                dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "email",
                    HeaderText = "Email"
                });

                dgvUsuarios.DataSource = usuarios;

                dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUsuarios.ColumnHeadersVisible = true;
                dgvUsuarios.RowHeadersVisible = false;

                // Configurar contenido a la izquierda y centrado vertical
                foreach (DataGridViewColumn column in dgvUsuarios.Columns)
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }



        private void btnTareas_Click(object sender, EventArgs e)
        {
            if (!MostrarFormExist<FormTareasTho1>())
            {
                FormTareasTho1 tareasForm = new FormTareasTho1();
                tareasForm.Show();
                this.Hide();
            }
        }

        private void btnReuniones_Click(object sender, EventArgs e)
        {
            if (!MostrarFormExist<FormReunionesDy1>())
            {
                FormReunionesDy1 reunionesForm = new FormReunionesDy1();
                reunionesForm.Show();
                this.Hide();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (!MostrarFormExist<Inicio>())
            {
                Inicio inicioForm = new Inicio();
                inicioForm.Show();
                Hide();
            }
        }

        private void btnProyetos_Click(object sender, EventArgs e)
        {
            if (!MostrarFormExist<FormProyectosGerard1>())
            {
                FormProyectosGerard1 proyectosForm = new FormProyectosGerard1();
                proyectosForm.Show();
                Hide();
            }
        }

        // actualizar los datos de usuario
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text.Trim();
            string nombreApellidos = txtNombre.Text.Trim();
            string pwd = txtPassword.Text.Trim();
            string email = txtCorreu.Text.Trim();
            string tele = txtTele.Text.Trim();

            if (string.IsNullOrEmpty(nombreUsuario))
            {
                MessageBox.Show("¡Por favor, ingrese el nombre de usuario!");
                return;
            }

            try
            {
                string proyectoRaiz = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..");
                string carpetaJSON = Path.Combine(proyectoRaiz, "JSON");
                string usuariosPath = Path.Combine(carpetaJSON, "Usuarios.json");

                if (!File.Exists(usuariosPath))
                {
                    MessageBox.Show($"Archivo de usuarios no encontrado: {usuariosPath}");
                    return;
                }

                List<Usuarios> usuarios;
                using (var sr = new StreamReader(usuariosPath))
                {
                    usuarios = JsonSerializer.Deserialize<List<Usuarios>>(sr.ReadToEnd());
                }

                bool encontrado = false;

                for (int i = 0; i < usuarios.Count; i++)
                {
                    if (usuarios[i].nombreUsuario == nombreUsuario)
                    {
                        usuarios[i].nombreApellidos = nombreApellidos;
                        usuarios[i].email = email;
                        usuarios[i].telefono = tele;
                        usuarios[i].contrasena = pwd;
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show("¡No se encontró el usuario!");
                    return;
                }

                using (var sw = new StreamWriter(usuariosPath, false))
                {
                    sw.Write(JsonSerializer.Serialize(usuarios, new JsonSerializerOptions { WriteIndented = true }));
                }

                // refresh 
                txtNombre.Text = nombreApellidos;
                txtCorreu.Text = email;
                txtTele.Text = tele;
                txtPassword.Text = pwd;

                if (dgvUsuarios != null)
                {
                    dgvUsuarios.DataSource = null;
                    dgvUsuarios.DataSource = usuarios;
                }

                MessageBox.Show("¡Información actualizada correctamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }


        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
                return;

            Usuarios usuarioSeleccionado = dgvUsuarios.CurrentRow.DataBoundItem as Usuarios;

            if (usuarioSeleccionado != null)
            {
                txtNombreUsuario.Text = usuarioSeleccionado.nombreUsuario;
                txtNombre.Text = usuarioSeleccionado.nombreApellidos;
                txtCorreu.Text = usuarioSeleccionado.email;
                txtTele.Text = usuarioSeleccionado.telefono;
                txtPassword.Text = usuarioSeleccionado.contrasena;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             if (!MostrarFormExist<FormUsuarios>())
            {
                FormUsuarios configuracion = new FormUsuarios();
                configuracion.Show();
                this.Hide();
            }
        }

        private bool MostrarFormExist<T>() where T : Form
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is T)
                {
                    form.Show();
                    form.WindowState = FormWindowState.Normal;
                    form.Activate();

                    form.TopMost = true;
                    form.TopMost = false;

                    return true;
                }
            }
            return false;
        }

    }
}
