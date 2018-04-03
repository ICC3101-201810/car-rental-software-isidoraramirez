using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Otro_cliente: Cliente
    {
        public string tipo;
        public bool autorizacion;
        public Otro_cliente(string nombre, string rut, string tipo, bool autorizacion) : base(nombre, rut)
        {
            this.nombre = nombre;
            this.rut = rut;
            this.tipo = tipo;
            this.autorizacion = autorizacion;
        }
    }
}
