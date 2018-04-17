using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Empresa : Cliente
    {
        public bool permiso;
        public Empresa(string nombre, string rut, bool permiso) : base(nombre, rut)
        {
            this.nombre = nombre;
            this.rut = rut;
            this.permiso = permiso;

        }

        public override bool Puede_arrendar(Vehiculo vehiculo)
        {
            if (permiso == true)
            {
                return true;
            }
            return false;
        }

        public void Pedir_permiso(Vehiculo vehiculo)
        {
            Random rndm = new Random();
            double municipalidad = rndm.NextDouble();
            if ((permiso == false) && (vehiculo.GetType()).ToString() == "M_pesada")
            {
                if (municipalidad < 0.63)
                {
                    this.permiso = true;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("El permiso fue otorgado\n");
                    Console.Beep();
                    Console.ResetColor();
                }
                else
                {
                    this.permiso = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se le otorgo el permiso\n");
                    Console.ResetColor();
                    Console.Beep();
                    Console.Beep();
                }
            }
            else if ((permiso == false) && (vehiculo.GetType()).ToString() == "Bus")
            {
                if (municipalidad <= 0.8)
                {
                    this.permiso = true;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("El permiso fue otorgado\n");
                    Console.Beep();
                    Console.ResetColor();
                }
                else
                {
                    this.permiso = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se le otorgo el permiso\n");
                    Console.ResetColor();
                    Console.Beep();
                    Console.Beep();

                }
            }
            else { Console.WriteLine("Ya se tiene el permiso\n");
                   Console.Beep();
                Console.Beep();
                Console.ResetColor();
            }
        }
    }
}

