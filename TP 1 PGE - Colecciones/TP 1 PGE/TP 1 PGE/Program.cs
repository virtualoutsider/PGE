using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1_PGE
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEmpleado listita = new ListaEmpleado();
            int op;
            bool Running = true;
            while (Running)
            {
                op = listita.menu();
                switch (op)
                {
                    case 1:
                        listita.add();
                        break;
                    case 2:
                        if (listita.Lista.Count > 0)
                        {
                            listita.Mostrar();
                        }
                        else
                        {
                            Console.WriteLine("No hay empleados");
                        }
                        
                        break;
                    case 3:
                        if (listita.Lista.Count > 0)
                        {
                            listita.searchLeg();
                        }
                        else
                        {
                            Console.WriteLine("No hay empleados");
                        }
                        break;
                    case 4:
                        if (listita.Lista.Count > 0)
                        {
                            listita.Basicos(1);
                        }
                        else
                        {
                            Console.WriteLine("No hay empleados");
                        }
                        break;
                    case 5:
                        if (listita.Lista.Count > 0)
                        {
                            listita.Basicos(0);
                        }
                        else
                        {
                            Console.WriteLine("No hay empleados");
                        }
                        break;
                    case 6:
                        if (listita.Lista.Count > 0)
                        {
                            listita.getAntiguo();
                        }
                        else
                        {
                            Console.WriteLine("No hay empleados");
                        }
                        break;
                    case 7:
                        if (listita.Lista.Count > 0)
                        {
                            listita.mejSueldo();
                        }
                        else
                        {
                            Console.WriteLine("No hay empleados");
                        }
                        break;
                    case 8:
                        if (listita.Lista.Count > 0)
                        {
                            listita.modif();
                        }
                        else
                        {
                            Console.WriteLine("No hay empleados");
                        }
                        break;
                    case 9:
                        if (listita.Lista.Count > 0)
                        {
                            listita.remove();
                        }
                        else
                        {
                            Console.WriteLine("No hay empleados");
                        }
                        break;
                    case 10:
                        Console.WriteLine("Adios...");
                        Running = false;
                        break;
                    default:
                        Console.WriteLine("Opcion equivocada");
                        break;
                }
                Console.WriteLine("Presione ENTER para continuar...");
                Console.ReadKey();
            }
        }
    }
}
