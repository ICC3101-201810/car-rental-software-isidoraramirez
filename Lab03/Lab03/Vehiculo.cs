using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Vehiculo
    {
        public string patente;
        public string marca;
        public string modelo;
        public string licencia;
        public int precio;
        public int stock;
        public Vehiculo(string patente, string marca, string modelo, string licencia)
        {
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;
            this.licencia = licencia;
            Random rndm = new Random();
            int ran = rndm.Next(1000, 9000);
            Random randm = new Random();
            int sto = rndm.Next(1, 10);
            int stock = sto;
            int precio = ran;
        }
    }
}

