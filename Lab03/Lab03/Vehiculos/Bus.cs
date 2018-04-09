using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Vehiculos
{
    class Bus : Vehiculo
    {
        public Bus(string marca, string patente, string modelo, string licencia, int precio)
            : base(marca, patente, modelo, licencia, precio)
        {
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;
            this.licencia = licencia;
            this.precio = precio;
        }
    }
}
