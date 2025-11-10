using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; 
using System.Windows.Forms;

namespace Beatrix_Formulario.ClasesTareas
{
    public class Reunion
    {
        public string titulo { get; set; }
        public DateTime fechaHora { get; set; }
        public List<string> usuariosReuniones { get; set; }
        public string descripcion { get; set; }
    }
}
