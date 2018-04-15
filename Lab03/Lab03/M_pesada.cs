using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Vehiculos
{
    class M_pesada : Vehiculo
    {
        Cliente cliente;
        public M_pesada(string marca, string patente, string modelo, string licencia, int precio, int stock)
            : base(marca, patente, modelo, licencia, precio, stock)
        {
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;
            this.licencia = licencia;
            this.precio = precio;
            this.stock = stock;

        }
        public override bool puede_arrendar()
        {
            if ((cliente.GetType()).ToString() == "Empresa" && cliente.licencias.Contains(licencia))
            {
                return true;
            }
            else if (cliente.licencias.Contains(licencia) && (cliente.GetType()).ToString() == "Persona")
            {
                return true;
            }

            else { return false; }
        }

    }
}