using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Bus : Vehiculo
    {
        public Bus(string marca, string patente, string modelo, string licencia, int precio, int stock, string tipo)
            : base(marca, patente, modelo, licencia, precio, stock)
        {
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo; //AQUI NOS REFERIMOS SI ES DE LUJO, NORMAL O LIVIANO.
            this.licencia = licencia;
            this.precio = precio;
            this.stock = stock;

        }
    }
}
