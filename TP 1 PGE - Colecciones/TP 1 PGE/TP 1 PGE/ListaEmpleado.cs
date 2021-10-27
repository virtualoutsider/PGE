using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1_PGE
{
    class ListaEmpleado
    {
        ArrayList lista;
        int leg, anti;
        string name;
        double bas;
        bool pres;

        public ArrayList Lista { get => lista; set => lista = value; }

        public ListaEmpleado()
        {
            lista = new ArrayList();
        }

        public void add()
        {
            if (!takeData()) return;
            lista.Add(new Empleado(leg,name,bas,anti,pres));
        }

        public void remove()
        {
            searchLeg(1);
        }

        public void modif()
        {
            searchLeg(2);
        }

        private bool takeData()
        {
            try 
            {
                Console.Write("Ingrese el legajo: ");
                leg = Convert.ToInt32(Console.ReadLine());
                if (!checkLeg()) return false;
                Console.Write("Ingrese el nombre: ");
                name = Console.ReadLine();
                Console.Write("Ingrese el basico: ");
                bas = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese la antiguedad: ");
                anti = Convert.ToInt32(Console.ReadLine());
                Console.Write("Asistio todos los dias (1 - Si // 2 - No): ");
                if (Console.ReadLine() == "1")
                {
                    pres = true;
                }
                else
                {
                    pres = false;
                }
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hubo un error en el ingreso " + ex.Message);
                return false;
            }
        }

        private bool checkLeg() 
        {
            foreach(Empleado solo in lista)
            {
                if(solo.Legajo == leg)
                {
                    Console.WriteLine("Ya se encuentra ese legajo");
                    return false;
                }
            }
            return true;
        }

        public void Mostrar()
        {
            bool first = false;
            foreach(Empleado solo in lista)
            {
                if (!first)
                {
                    Console.WriteLine("Mostrando empleados: ");
                }
                Console.WriteLine("==================");
                solo.Mostrar();
            }
        }

        public bool searchLeg(int aux = 0)
        {
            int busc;
            Console.Write("Ingrese el legajo: ");
            busc = Convert.ToInt32(Console.ReadLine());
            foreach(Empleado solo in lista)
            {
                if(solo.Legajo == busc)
                {
                    Console.WriteLine("Se encontro esa persona");
                    solo.Mostrar();
                    if (aux == 1)
                    {
                        Console.WriteLine("Eliminando empleado...");
                        lista.Remove(solo);
                    }else if (aux == 2)
                    {
                        solo.modif();
                    }
                    return true;
                }
            }
            return false;
        }

        public void Basicos(int op)
        {
            double amount = 0;
            foreach(Empleado solo in lista)
            {
                amount += solo.Basico;
            }
            if(op == 1)
            {
                Console.WriteLine("Hay un basico de {0}", amount);
            }
            else
            {
                Console.WriteLine("Hay un promedio basico de {0}", amount/lista.Count);
            }
            
        }

        public void getAntiguo()
        {
            int max = 0, pos = 0;
            foreach (Empleado solo in lista)
            {
                if (max < solo.Antiguedad)
                {
                    max = solo.Antiguedad;
                    pos = lista.IndexOf(solo);
                }
            }
            Console.WriteLine("El empleado mas antiguo es: ");
            lista[pos].ToString();
        }

        public void mejSueldo()
        {
            double max = 0;
            int pos = 0;
            foreach(Empleado solo in lista)
            {
                if(max < solo.Basico)
                {
                    max = solo.Basico;
                    pos = lista.IndexOf(solo);
                }
            }
            Console.WriteLine("El empleado mejor pagado es: ");
            lista[pos].ToString();
        }

        public int menu()
        {
            int op;
            Console.Write("=======Menu=======\n" +
                "1 - Agregar empleado\n" +
                "2 - Mostrar empleados\n" +
                "3 - Buscar empleado por ID\n" +
                "4 - Total Basicos\n" +
                "5 - Promedio Basicos\n" +
                "6 - Empleado mas antiguo\n" +
                "7 - Empleado con mayor basico\n" +
                "8 - Modificar empleado\n" +
                "9 - Eliminar empleado\n" +
                "10 - Salir\n" +
                "Opcion:");
            try
            {
                op = Convert.ToInt32(Console.ReadLine());
                return op;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al ingresar opcion " + ex.Message);
                return 0;
            }
            
        }
    }
}
