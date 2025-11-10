using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beatrix_Formulario.ClasesTareas
{
    public class Proyectos
    {
        public string NombreProyecto { get; set; }
        public List<Tareas> Tareas { get; set; } = new List<Tareas>();

        public DateTime fechaEntrega { get; set; }
        public DateTime fechaInicio { get; set; }

        public List<Usuarios> UsuariosAsignados { get; set; } = new List<Usuarios>();

    }
}
