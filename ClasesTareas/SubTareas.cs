using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beatrix_Formulario.ClasesTareas
{
    public class SubTareas
    {
        public string NombreSubTarea { get; set; }
        public string DescripcionSubTarea { get; set; }
        public DateTime FechaInicioSubtarea { get; set; }
        public DateTime FechaEntregaSubtarea { get; set; }
        public string EstadoSubTarea { get; set; }

        public List<Usuarios> UsuariosAsignadosSubtarea { get; set; } = new List<Usuarios>();


    }
}
