using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Clientes
{
    public class Otro_cliente: Cliente
    {
        public string tipo; // esto se refiere a si es empresa, organización o institución
        public string permiso;
        public Otro_cliente(string nombre, string rut, string tipo, string permiso) : base(nombre, rut)
        {
            this.nombre = nombre;
            this.rut = rut;
            this.tipo = tipo;
            this.permiso = permiso;
        }
    }
}
