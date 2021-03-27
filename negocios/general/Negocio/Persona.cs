using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursos.general.Generales
{
    public abstract class Persona
    {
        public int CuilCuit { get; set; }
        public int Rol { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
    }
}
