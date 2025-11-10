using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beatrix_Formulario.ClasesTareas
{
    public class Usuarios
    {
        public string nombreApellidos { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }

        public string email { get; set; }

        public string telefono { get; set; }
        public string rol { get; set; }

        public override string ToString()
        {
            return this.nombreUsuario;
        }

    }

}
