using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Sucursal
    {
        public string location, nombre;
        List<Vehiculo> vehiculos;
        List<Accesorio> accesorio;
        public Sucursal(string location,string nombre, List<Vehiculo> vehiculos)
        {
            this.location = location;
            this.nombre = nombre;
            this.vehiculos = vehiculos;
            
        }
    }
}
