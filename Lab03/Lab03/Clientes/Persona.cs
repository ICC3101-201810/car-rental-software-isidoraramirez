﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Clientes
{
    public class Persona: Cliente
    {
        
        public Persona(string rut, string nombre)
            : base(nombre, rut)
        {
            this.nombre = nombre;
            this.rut = rut;
        }
    }
}
