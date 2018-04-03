using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Persona: Cliente
    {
        
        public bool licencia;
        public Persona(string rut, string nombre,  bool licencia)
            : base(nombre, rut)
        {
            this.nombre = nombre;
            this.rut = rut;
            this.licencia = licencia;


        }
    }
}
