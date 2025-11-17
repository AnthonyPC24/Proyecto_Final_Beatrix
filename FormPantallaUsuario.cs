using Beatrix_Formulario.ClasesTareas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beatrix_Formulario
{
    public partial class FormPantallaUsuario : Form
    {
        private List<Usuarios> users = new List<Usuarios>();
        public FormPantallaUsuario()
        {
            InitializeComponent();
        }


        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            // Los usuarios se añadirán al archivo JSON después de su creación.

            string usersPath = Path.Combine(Application.StartupPath, "JSON", "Usuarios.json");
        }
    }
}
