using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beatrix_Formulario.ClasesTareas
{
    public class Tareas
    {
        public string nombreTarea { get; set; } 
        public string descripcion { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaEntrega { get; set; }
        public string estado { get; set; }

        public List<Usuarios> usuariosAsignados { get; set; } = new List<Usuarios>();
    }
}
