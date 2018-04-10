using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Clientes
{
    class Empresa : Cliente
    {
        bool permiso;
        public Empresa(string nombre, string rut, bool permiso) : base(nombre, rut)
        {
            this.nombre = nombre;
            this.rut = rut;

        }
    }
}

