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
        List<Arriendo> arriendos;
        public Sucursal(string location,string nombre)
        {
            this.location = location;
            this.nombre = nombre;
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            List<Accesorio> accesorio = new List<Accesorio>();
            List<Cliente> clientes = new List<Cliente>();
            List<Arriendo> arriendos = new List<Arriendo>();
        }
        public void Arrendar(Cliente cliente, DateTime Datei, DateTime Datef, Vehiculo vehiculo, Sucursal sucursal, Accesorio accesorio_extra)
        {
            if (cliente.licencias.Contains(vehiculo.licencia))
            {
                int costo = vehiculo.precio + accesorio_extra.precio;
                Arriendo Arrendado = new Arriendo(cliente, Datei, Datef, vehiculo, sucursal, costo);
                Arrendado.accesorio.Add(accesorio_extra);
                accesorio_extra.stock--;
                vehiculo.stock--;
                sucursal.arriendos.Add(Arrendado);

            }
            else { Console.WriteLine("No tiene la licencia para poder arrendar este vehiculo.\n"); }
        }
        public void Arrendar(Cliente cliente, DateTime Datei, DateTime Datef, Vehiculo vehiculo, Sucursal sucursal)
        {
            if (cliente.licencias.Contains(vehiculo.licencia) && (cliente.GetType()).ToString() == "Persona")
            {
                int costo = vehiculo.precio;
                Arriendo Arrendado = new Arriendo(cliente, Datei, Datef, vehiculo, sucursal, costo);
                vehiculo.stock--;
                sucursal.arriendos.Add(Arrendado);

            }

            else if ((cliente.GetType()).ToString() == "Empresa" && (vehiculo.GetType()).ToString() == "M_pesada"  )
            {
                int costo = vehiculo.precio;
                Arriendo Arrendado = new Arriendo(cliente, Datei, Datef, vehiculo, sucursal, costo);
                vehiculo.stock--;
                sucursal.arriendos.Add(Arrendado);
            }

            else if ((cliente.GetType()).ToString() != "Empresa" && (cliente.GetType()).ToString() != "Persona" && (vehiculo.GetType()).ToString() == "M_pesada")
            {
                Console.WriteLine("No se puede arrendar este vehiculo\n");
            }
            
            else { Console.WriteLine("No se puede arrendar este vehiculo.\n"); }
        }
    }
}
