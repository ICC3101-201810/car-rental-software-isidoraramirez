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
        List<Cliente> clientes;
        public Sucursal(string location,string nombre)
        {
            this.location = location;
            this.nombre = nombre;
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            List<Accesorio> accesorios = new List<Accesorio>();
            List<Cliente> clientes = new List<Cliente>();
        }
        public void Arrendar(Cliente cliente, DateTime Datei, DateTime Datef, Vehiculo vehiculo, Sucursal sucursal, Accesorio accesorio_extra)
        {
            int costo = vehiculo.precio + accesorio_extra.precio;
            Arriendo Arrendado = new Arriendo(cliente, Datei, Datef, vehiculo, sucursal, costo);
            accesorio.Add(accesorio_extra);
            accesorio_extra.stock--;
            vehiculo.stock--;

        }
        public void Arrendar(Cliente cliente, DateTime Datei, DateTime Datef, Vehiculo vehiculo, Sucursal sucursal)
        {
            int costo = vehiculo.precio;
            Arriendo Arrendado = new Arriendo(cliente, Datei, Datef, vehiculo, sucursal, costo);
            vehiculo.stock--;
        }
    }
}
