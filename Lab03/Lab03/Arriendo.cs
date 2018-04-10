using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Arriendo
    {
        Cliente cliente;
        DateTime Datei;
        DateTime Datef;
        Vehiculo vehiculo;
        public List<Accesorio> accesorio;
        public int costo;
        Sucursal sucursal;

        public Arriendo(Cliente cliente, DateTime Datei,DateTime Datef, Vehiculo vehiculo, Sucursal sucursal,int  costo)
        {
            this.cliente = cliente;
            this.Datei = Datei;
            this.Datef = Datef;
            this.vehiculo = vehiculo;
            this.sucursal = sucursal;
            accesorio = new List<Accesorio>();
            this.costo = costo;
        }
        /*
        public void Arrendar(Cliente cliente, DateTime Datei, DateTime Datef, Vehiculo vehiculo, Sucursal sucursal, Accesorio accesorio_extra)
        {
            Arriendo Arrendado = new Arriendo(cliente, Datei, Datef, vehiculo, sucursal);
            accesorio.Add(accesorio_extra);
            accesorio_extra.stock -- ;
            sucursal(vehiculos)
        }
        public void Arrendar(Cliente cliente, DateTime Datei, DateTime Datef, Vehiculo vehiculo, Sucursal sucursal)
        {
            Arriendo Arrendado = new Arriendo(cliente, Datei, Datef, vehiculo, sucursal);
        }*/
    }
}
