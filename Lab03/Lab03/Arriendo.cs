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
            this.accesorio = new List<Accesorio>();
            this.costo = costo;
        }
      
    }
}
