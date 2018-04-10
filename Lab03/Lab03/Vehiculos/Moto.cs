﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Vehiculos
{
    class Moto : Vehiculo
    {
        public Moto(string marca, string patente, string modelo, string licencia, int precio, int stock)
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

        }

    }
}