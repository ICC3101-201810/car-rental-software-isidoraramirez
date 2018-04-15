using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public abstract class Cliente
    {
        public string nombre,rut;
        public Cliente(string nombre, string rut)
        {
            this.nombre = nombre;
            this.rut = rut;
        }
        public abstract bool Puede_arrendar(Vehiculo vehiculo);
    }
}
