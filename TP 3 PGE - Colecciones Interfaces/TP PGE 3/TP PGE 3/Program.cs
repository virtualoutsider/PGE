using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PGE_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ListadeFacutas facturero = new ListadeFacutas();
            int op = 0;
            bool Running = true;
            while(Running)
            {
                op = facturero.menu();
                switch (op)
                { 
                    case 1:
                        Console.WriteLine("1 - Contado\n2 - Credito\n3 - Salir");
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                                facturero.add(Contado.ingreso());
                                break;
                            case 2:
                                facturero.add(Credito.ingreso());
                                break;
                            case 3:
                                Console.WriteLine("Listo...");
                                break;
                            default:
                                Console.WriteLine("Error");
                                break;
                        }
                        break;
                    case 2:
                        if(facturero.Lista.Count > 0) facturero.Lista[facturero.Lista.Count-1].cargar();
                        break;
                    case 3:
                        if (facturero.Lista.Count > 0) facturero.listar();
                        break;
                    case 4:
                        Running = false;
                        break;
                    default:
                        Console.WriteLine("Ingreso un valor incorrecto");
                        break;
                }
                Console.WriteLine("Aprete ENTER para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
