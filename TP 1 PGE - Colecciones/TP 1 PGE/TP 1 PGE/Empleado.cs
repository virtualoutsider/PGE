using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1_PGE
{
    class Empleado
    {
        int legajo, antiguedad;
        string nombre;
        double basico;
        bool presentismo;

        public int Legajo { get => legajo; set => legajo = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Basico { get => basico; set => basico = value; }
        public bool Presentismo { get => presentismo; set => presentismo = value; }

        public void addAnti () 
        { 
            Antiguedad++; 
        }

        public Empleado(int leg = 0, string nom = "", double bas = 0, int anti = 0, bool pres = false)
        {
            legajo = leg;
            nombre = nom;
            basico = bas;
            antiguedad = anti;
            presentismo = pres;
        }

        public void refBas(double bas)
        {
            basico = bas;
        }

        public void refBas(int porc)
        {
            basico = (basico * porc) / 100;
        }

        public void sueldoNeto(double porcAnt,double mtoPres)
        {
            double neto;
            if (presentismo) 
            {
                neto = basico + (antiguedad * (porcAnt * basico)) + mtoPres;
            }
            else
            {
                neto = basico + (antiguedad * (porcAnt * basico));
            }
            Console.WriteLine("El sueldo neto de {0} es de ${1}",nombre,neto);
        }

        public void Mostrar()
        {
            string aux = "No";
            if (presentismo) aux = "Si";
            Console.WriteLine("Nombre: {0}\nLegajo: {1}\nSueldo Basico: {2}\nAntiguedad: {3}\nPresentismo: {4}",nombre,legajo,basico,antiguedad,aux);
        }

        public override string ToString()
        {
            this.Mostrar();
            return("lol");
        }

        public bool modif()
        {
            try
            {
                Console.WriteLine("=========================");
                Console.Write("Ingrese el nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese el basico: ");
                basico = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese la antiguedad: ");
                antiguedad = Convert.ToInt32(Console.ReadLine());
                Console.Write("Asistio todos los dias (1 - Si // 2 - No): ");
                if (Console.ReadLine() == "1")
                {
                    presentismo = true;
                }
                else
                {
                    presentismo = false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error en el ingreso " + ex.Message);
                return false;
            }
        }
    }
}
