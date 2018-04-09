using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Clientes
{
    public class Persona: Cliente
    {
        
        public string licencia;
        public Persona(string rut, string nombre,  string licencia)
            : base(nombre, rut)
        {
            this.nombre = nombre;
            this.rut = rut;
            this.licencia = licencia;
        }
    }
}
