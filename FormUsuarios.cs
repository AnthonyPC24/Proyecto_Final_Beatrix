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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Run(new FormPantallaUsuario());
        }

        private void lblCrearUsuario_Click(object sender, EventArgs e)
        {

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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (!MostrarFormExist<Inicio>())
            {
                Inicio inicioForm = new Inicio();
                inicioForm.Show();
            }
        }

        private void btnProyetos_Click(object sender, EventArgs e)
        {
            if (!MostrarFormExist<FormProyectosGerard1>())
            {
                FormProyectosGerard1 proyectosForm = new FormProyectosGerard1();
                proyectosForm.Show();
            }
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
