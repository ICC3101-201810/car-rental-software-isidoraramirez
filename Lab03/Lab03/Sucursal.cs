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
        public List<Vehiculo> vehiculos;
        public List<Accesorio> accesorio;
        public List<Cliente> clientes;
        public List<Arriendo> arriendos;
        public List<Vehiculo> v_arrendados;
        public Sucursal(string location,string nombre)
        {
            this.location = location;
            this.nombre = nombre;
            this.vehiculos = new List<Vehiculo>();
            this.accesorio = new List<Accesorio>();
            this.clientes = new List<Cliente>();
            this.arriendos = new List<Arriendo>();
            this.v_arrendados = new List<Vehiculo>();
        }
        public void Arrendar(Cliente cliente, DateTime Datei, DateTime Datef, Vehiculo vehiculo, Sucursal sucursal, Accesorio accesorio_extra)
        {
            int costo = vehiculo.precio + accesorio_extra.precio;
            Arriendo Arrendado = new Arriendo(cliente, Datei, Datef, vehiculo, sucursal, costo);
            Arrendado.accesorio.Add(accesorio_extra);
            accesorio_extra.stock--;
            vehiculo.stock--;
            sucursal.arriendos.Add(Arrendado);
            Console.WriteLine("Arrendado con exito!");
            Console.Beep();

        }
        public void Arrendar(Cliente cliente, DateTime Datei, DateTime Datef, Vehiculo vehiculo, Sucursal sucursal)
        {

            int costo = vehiculo.precio;
            Arriendo Arrendado = new Arriendo(cliente, Datei, Datef, vehiculo, sucursal, costo);
            vehiculo.stock--;
            sucursal.arriendos.Add(Arrendado);
            Console.WriteLine("Arrendado con exito!");
            Console.Beep();
        }
    }
}
