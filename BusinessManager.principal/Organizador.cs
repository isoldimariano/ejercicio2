using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurante;

namespace BusinessManager.principal
{
    class Organizador
    {
        private NegocioRestaurante[] Restaurantes { get; set; }
        public Organizador()
        {
            this.Iniciar();
        }
        public void Iniciar()
        {
            Console.WriteLine("Iniciando");
        }
    }
}
