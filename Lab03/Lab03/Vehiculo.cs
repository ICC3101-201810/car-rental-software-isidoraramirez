﻿using System;
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
        public Vehiculo(string patente, string marca, string modelo, string licencia, int precio)
        {
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;
            this.licencia = licencia;
            this.precio = precio;
        }
    }
}
