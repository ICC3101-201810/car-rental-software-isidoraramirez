using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Organizacion : Cliente
    {

        public bool permiso;
        public Organizacion(string nombre, string rut, bool permiso) : base(nombre, rut)
        {
            this.nombre = nombre;
            this.rut = rut;
            this.permiso = permiso;
        }
        public override bool Puede_arrendar(Vehiculo vehiculo)
        {
            if (permiso == true)
            {
                if ((vehiculo.GetType()).ToString() == "Bus" && vehiculo.modelo.ToLower() == "normal" && permiso == true)
                {
                    return true;
                }
                else if ((vehiculo.GetType()).ToString() == "Bus" && vehiculo.modelo.ToLower() == "liviano" && permiso == true)
                {
                    return false;
                }
                else if ((vehiculo.GetType()).ToString() == "Bus" && vehiculo.modelo.ToLower() == "lujo" && permiso == true)
                {
                    return false;
                }
                else if ((vehiculo.GetType()).ToString() == "M_pesada")
                {
                    return false;
                }
                else
                {
                    return true;
                }
                
            }
            return false;
        }
        public void Pedir_permiso(Vehiculo vehiculo)
        {
            Random rndm = new Random();
            double municipalidad = rndm.NextDouble();
            if ((permiso == false) && (vehiculo.GetType()).ToString() == "Bus")
            {
                if (municipalidad <= 0.35)
                {
                    this.permiso = true;
                    Console.WriteLine("El permiso fue otorgado\n");
                    Console.Beep();
                }
                else
                {
                    this.permiso = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se le otorgo el permiso\n");
                    Console.Clear();
                }
            }
            else { Console.WriteLine("Ya se tiene el permiso\n");
                Console.Beep();
            }
        }
    }
}
