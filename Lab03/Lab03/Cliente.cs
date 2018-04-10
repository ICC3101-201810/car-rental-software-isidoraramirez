using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Cliente
    {
        public string nombre,rut;
        public List<string> licencias;
        public Cliente(string nombre, string rut)
        {
            this.nombre = nombre;
            this.rut = rut;
            List<string> licencias = new List<string>();
        }
    }
}
