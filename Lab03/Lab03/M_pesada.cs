using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class M_pesada : Vehiculo
    {
        public M_pesada(string marca, string patente, string modelo, string licencia)
            : base(marca, patente, modelo, licencia)
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