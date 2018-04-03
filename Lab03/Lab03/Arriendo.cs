using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Arriendo
    {
        Cliente cliente;
        Accesorio accesorio;
        DateTime Date;
        Vehiculo vehiculo;
        Sucursal sucursal;

        Arriendo(Cliente cliente, DateTime Date, Vehiculo vehiculo, Sucursal sucursal)
        {
            this.cliente = cliente;
            this.Date = Date;
            this.vehiculo = vehiculo;
            this.sucursal = sucursal;
            
        }
        /*
        public String arrendar(Arriendo arriendo, Accesorio accesorio)
        {
            if ()
            {
                return "Se arrendo con accesorio";
            }
        }*/
    }
}
