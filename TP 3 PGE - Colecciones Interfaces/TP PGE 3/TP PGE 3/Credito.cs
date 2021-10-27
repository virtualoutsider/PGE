using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PGE_3
{
    class Credito: CFactura,IFactura
    {
        int cantcuotas;
        double total;

        public Credito(int nro = 0, string name = "",int cuotas = 0) :base(nro,name)
        {
            cantcuotas = cuotas;
            total = 0;
        }

        public int Cantcuotas { get => cantcuotas; set => cantcuotas = value; }

        public override bool cargar()
        {

            try
            {
                Console.WriteLine("Ingrese costo: ");
                total += Convert.ToDouble(Console.ReadLine());
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
            return false;
        }

        public override void imprimir()
        {
            base.imprimir();
            Console.WriteLine("Cantidad de cuotas: {0}\nTotal Factura: ${1}",cantcuotas,total);
            cuotas(); 
        }

        public void cuotas()
        {
            Console.WriteLine("Tendra que pagar ${0} en {1} cuotas, con un total de ${2}",total/cantcuotas,cantcuotas,total);
        }

        public void cuotas(int c, int dia, int mes, int aa)
        {
            Console.WriteLine("Tendra que pagar ${0} en {1} cuotas, con un total de ${2}", total / c, c, total);
            Console.WriteLine("Con una fecha de vencimiento de {0}/{1}/{2}",dia,mes,aa);
        }

        public static Credito ingreso()
        {
            try
            {
                Console.Clear();
                Credito temp = new Credito();
                Console.WriteLine("Ingreso la opcion Credito");
                Console.Write("Ingrese el numero de Factura: ");
                temp.Nmro = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el nombre del Cliente: ");
                temp.Nombre = Console.ReadLine();
                Console.Write("Ingrese cantidad de cuotas: ");
                temp.Cantcuotas = Convert.ToInt32(Console.ReadLine());
                return temp;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
                return null;
            }

        }

    }
}
