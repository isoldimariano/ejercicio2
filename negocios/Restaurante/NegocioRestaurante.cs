using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using recursos.general.Generales;
using Restaurante.componentesRestaurante;

namespace Restaurante
{
    public class NegocioRestaurante: Negocio
    {
        private Sucursal[] Sucursales { get; set; }
        private Empleado[] Empleados { get; set; }
    }
}
