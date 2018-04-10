using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Clientes
{
    class Organizacion : Cliente
    {
        public Organizacion(string nombre, string rut) : base(nombre, rut)
        {
            this.nombre = nombre;
            this.rut = rut;
        }
    }
}
