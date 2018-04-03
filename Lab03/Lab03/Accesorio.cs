using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Accesorio
    {
        string nombre;
        int precio;
        bool usa;
        Accesorio(string nombre, int precio, bool usa)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.usa = usa;
        }
    }
}
