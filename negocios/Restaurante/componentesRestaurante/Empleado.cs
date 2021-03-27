using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using recursos.general.Generales;

namespace Restaurante.componentesRestaurante
{
    class Empleado: Persona
    {
        public int Puesto { get; set; }
        public int Area { get; set; }
        public int Sueldo { get; set; }
        public string Superior { get; set; }
        public string Turno { get; set; }
    }
}
