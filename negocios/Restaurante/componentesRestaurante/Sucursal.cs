using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using recursos.general.Generales;

namespace Restaurante.componentesRestaurante
{
    class Sucursal: Edificio
    {
        public int NumeroSucursal { get; set; }
        public string Alquiler { get; set; }
        public string Nivel { get; set; }
        public string Estado { get; set; }
        private Empleado[] Empleados { get; set; }
    }
}
