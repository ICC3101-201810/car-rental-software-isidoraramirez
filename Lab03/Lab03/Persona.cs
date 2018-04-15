using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Persona: Cliente
    {
        
        public Persona(string rut, string nombre)
            : base(nombre, rut)
        {
            this.nombre = nombre;
            this.rut = rut;
            List<string> licencias = new List<string>();
        }
        public override bool Puede_arrendar(Vehiculo vehiculo)
        {
            if((vehiculo.GetType()).ToString() == "Bus")
            {
                return false;
            }
            return true;
        }

    }

}
