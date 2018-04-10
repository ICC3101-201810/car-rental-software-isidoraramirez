using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sucursal> sucursales = new List<Sucursal>();
            Console.WriteLine("           RENTCAR ");
            while (true)
            {
                INICIO:

                Console.WriteLine("1. Crear Sucursal \n" +
                    "2. Ingresar Vehiculo \n" +
                    "3. Ingresar Accesorio \n" +
                    "4. Arrendar Vehiculo\n" +
                    "5. Salir\n ");
                Console.Write("Ingrese una opcion: ");
                String opcion = Console.ReadLine();

                if (opcion == "5") { break; }

                else if (opcion == "1")
                {
                    Console.WriteLine("Para comenzar la sucursal debes ingresar \n" +
                        "Ubicacion: ");
                    string location = Console.ReadLine();
                    Console.WriteLine("Nombre Sucursal: ");
                    string nombre = Console.ReadLine();
                    Sucursal sucursal = new Sucursal(location, nombre);
                    if (sucursales.Contains(sucursal))
                    {
                        Console.WriteLine("Esta sucursal ya existe");
                        goto INICIO;
                    }
                    else
                    {
                        sucursales.Add(sucursal);
                        goto INICIO;
                    }



                }
            }
        }
    }
}
