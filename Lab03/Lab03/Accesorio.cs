using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Accesorio
    {
        public string nombre;
        public int precio;
        public int stock;
        public Accesorio(string nombre, int precio, int stock)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }
    }
}
