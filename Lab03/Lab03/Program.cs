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

            Console.WriteLine("           RENTCAR \n" +
                              "         BIENVENIDO!");
            while (true)
            {
                INICIO:

                Console.WriteLine("1. Crear Sucursal \n" +
                    "2. Recibir Vehiculo \n" +
                    "3. Ingresar Accesorio \n" +
                    "4. Arrendar Vehiculo\n" +
                    "5. Salir\n ");
                Console.Write("Ingrese una opcion: ");
                String opcion = Console.ReadLine();

                if (opcion == "5")
                {
                    Console.Beep();
                    break;
                }


                else if (opcion == "1")
                {
                    Console.WriteLine("Para comenzar la sucursal debes ingresar \n" +
                        "Ubicacion: ");
                    string location = Console.ReadLine();
                    Console.WriteLine("ID Sucursal: ");
                    string nombre = Console.ReadLine();
                    Sucursal sucursal = new Sucursal(location, nombre);
                    if (sucursales.Contains(sucursal))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Esta sucursal ya existe");
                        Console.ResetColor();
                        Console.Beep();
                        Console.Beep();

                        goto INICIO;
                    }
                    else
                    {
                        sucursales.Add(sucursal);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Sucursal añadida con exito!");
                        Console.ResetColor();
                        Console.Beep();
                        Console.WriteLine("Desea ingresar los vehiculos disponibles?(si/no) \n");
                        string i_v = Console.ReadLine();
                        //Vehiculo(string patente, string marca, string modelo, string licencia, int precio, int stock)
                        while (i_v.ToLower() == "si")
                        {
                            Console.WriteLine("Ingrese el tipo de vehiculo a arrendar (con la nomenclatura señalada): \nAcuatico\nBus\nCamion\nM_pesada\nMoto\nAuto\n");
                            string tipo = Console.ReadLine();
                            Console.WriteLine("Ingrerse la patente: ");
                            string patente = Console.ReadLine();
                            Console.WriteLine("Ingrerse la marca: ");
                            string marca = Console.ReadLine();
                            Console.WriteLine("Ingrerse el tipo de licencia para poder conducir este vehiculo: ");
                            string licencia = Console.ReadLine();
                            int largo = sucursales.Count() - 1;
                            if (tipo == "Acuatico")
                            {
                                Console.WriteLine("Ingrerse el modelo: ");
                                string modelo = Console.ReadLine();
                                Acuatico vehi = new Acuatico(patente, marca, modelo, licencia);
                                sucursales[largo].vehiculos.Add(vehi);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("El vehiculo " + tipo + "ha sido agregado con exito!");
                                Console.Beep();
                                Console.Beep();
                            }
                            else if (tipo == "Bus")
                            {

                                Console.WriteLine("Ingrese el tipo de Bus:\nlujo\n normal \n liviano");
                                string modelo = Console.ReadLine();
                                Bus vehi = new Bus(patente, marca, modelo, licencia);
                                sucursales[largo].vehiculos.Add(vehi);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("El vehiculo " + tipo + "ha sido agregado con exito!");
                                Console.Beep();
                                Console.Beep();
                            }
                            else if (tipo == "Camion")
                            {
                                Console.WriteLine("Ingrerse el modelo: ");
                                string modelo = Console.ReadLine();
                                Camion vehi = new Camion(patente, marca, modelo, licencia);
                                sucursales[largo].vehiculos.Add(vehi);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("El vehiculo " + tipo + "ha sido agregado con exito!");
                                Console.Beep();
                                Console.Beep();
                            }
                            else if (tipo == "M_pesada")
                            {
                                Console.WriteLine("Ingrerse el modelo: ");
                                string modelo = Console.ReadLine();
                                M_pesada vehi = new M_pesada(patente, marca, modelo, licencia);
                                sucursales[largo].vehiculos.Add(vehi);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("El vehiculo " + tipo + "ha sido agregado con exito!");
                                Console.Beep();
                                Console.Beep();
                            }
                            else if (tipo == "Moto")
                            {
                                Console.WriteLine("Ingrerse el modelo: ");
                                string modelo = Console.ReadLine();
                                Moto vehi = new Moto(patente, marca, modelo, licencia);
                                sucursales[largo].vehiculos.Add(vehi);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("El vehiculo " + tipo + "ha sido agregado con exito!");
                                Console.Beep();
                                Console.Beep();
                            }
                            else if (tipo == "Auto")
                            {
                                Console.WriteLine("Ingrerse el modelo: ");
                                string modelo = Console.ReadLine();
                                Auto vehi = new Auto(patente, marca, modelo, licencia);
                                sucursales[largo].vehiculos.Add(vehi);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("El vehiculo " + tipo + "ha sido agregado con exito!");
                                Console.Beep();
                                Console.Beep();
                            }
                            Console.ResetColor();
                            Console.WriteLine("Desea agregar otro vehiculo? (si/no)");
                            i_v = Console.ReadLine();
                            if (i_v.ToLower() == "si")
                            {
                                continue;
                            }
                            else if (i_v.ToLower() == "no")
                            {
                                break;
                            }
                        }
                        goto INICIO;
                    }
                }
                else if (opcion == "2")
                {
                    int i = 1;
                    foreach (Sucursal sucursal1 in sucursales)
                    {
                        Console.WriteLine(i + "." + sucursal1.nombre);
                    }
                    Console.WriteLine("Ingrese la opcion de la Sucursal que desea aregar el vehiculo: ");
                    int opcion_i = Convert.ToInt32(Console.ReadLine()) - 1;
                    Sucursal sucursal = sucursales[opcion_i];
                    Console.WriteLine("Ingrese el tipo de vehiculo a devolver (con la nomenclatura señalada): \nAcuatico\nBus\nCamion\nM_pesada\nMoto\nAuto\n");
                    string tipo = Console.ReadLine();
                    Console.WriteLine("Ingrerse la patente: ");
                    string patente = Console.ReadLine();
                    Console.WriteLine("Ingrerse la marca: ");
                    string marca = Console.ReadLine();
                    Console.WriteLine("Ingrerse el tipo de licencia para poder conducir este vehiculo: ");
                    string licencia = Console.ReadLine();
                    if (tipo == "Acuatico")
                    {
                        Console.WriteLine("Ingrerse el modelo: ");
                        string modelo = Console.ReadLine();
                        Acuatico vehi = new Acuatico(patente, marca, modelo, licencia);
                        if (sucursal.v_arrendados.Contains(vehi))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            vehi.stock++;
                            Console.WriteLine("El vehiculo " + tipo + "ha sido devuelto con exito!");
                            Console.Beep();
                            Console.Beep();
                        }

                    }
                    else if (tipo == "Bus")
                    {

                        Console.WriteLine("Ingrese el tipo de Bus:\nlujo\n normal \n liviano");
                        string modelo = Console.ReadLine();
                        Bus vehi = new Bus(patente, marca, modelo, licencia);
                        if (sucursal.v_arrendados.Contains(vehi))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            vehi.stock++;
                            Console.WriteLine("El vehiculo " + tipo + "ha sido devuelto con exito!");
                            Console.Beep();
                            Console.Beep();
                        }
                    }
                    else if (tipo == "Camion")
                    {
                        Console.WriteLine("Ingrerse el modelo: ");
                        string modelo = Console.ReadLine();
                        Camion vehi = new Camion(patente, marca, modelo, licencia);
                        if (sucursal.v_arrendados.Contains(vehi))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            vehi.stock++;
                            Console.WriteLine("El vehiculo " + tipo + "ha sido devuelto con exito!");
                            Console.Beep();
                            Console.Beep();
                        }
                    }
                    else if (tipo == "M_pesada")
                    {
                        Console.WriteLine("Ingrerse el modelo: ");
                        string modelo = Console.ReadLine();
                        M_pesada vehi = new M_pesada(patente, marca, modelo, licencia);
                        if (sucursal.v_arrendados.Contains(vehi))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            vehi.stock++;
                            Console.WriteLine("El vehiculo " + tipo + "ha sido devuelto con exito!");
                            Console.Beep();
                            Console.Beep();
                        }
                    }
                    else if (tipo == "Moto")
                    {
                        Console.WriteLine("Ingrerse el modelo: ");
                        string modelo = Console.ReadLine();
                        Moto vehi = new Moto(patente, marca, modelo, licencia);
                        if (sucursal.v_arrendados.Contains(vehi))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            vehi.stock++;
                            Console.WriteLine("El vehiculo " + tipo + "ha sido devuelto con exito!");
                            Console.Beep();
                            Console.Beep();
                        }
                    }
                    else if (tipo == "Auto")
                    {
                        Console.WriteLine("Ingrerse el modelo: ");
                        string modelo = Console.ReadLine();
                        Auto vehi = new Auto(patente, marca, modelo, licencia);
                        if (sucursal.v_arrendados.Contains(vehi))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            vehi.stock++;
                            Console.WriteLine("El vehiculo " + tipo + "ha sido devuelto con exito!");
                            Console.Beep();
                            Console.Beep();
                        }

                    }
                    Console.ResetColor();
                }




                else if (opcion == "4")
                {
                    int j = 1;
                    foreach (Sucursal sucursal1 in sucursales)
                    {
                        Console.WriteLine(j + "." + sucursal1.nombre);
                    }
                    Console.WriteLine("Ingrese la opcion de la Sucursal que desea arrendar el vehiculo: ");
                    int opcion_j = Convert.ToInt32(Console.ReadLine()) - 1;
                    Sucursal sucursal = sucursales[opcion_j];
                }
                
            }
        }
    } 
}

        
    

