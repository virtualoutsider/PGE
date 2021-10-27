using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PGE_3
{
    class Contado: CFactura,IFactura
    {
        int tipo;
        double total;

        public Contado(int nro = 0, string name = "",int atipo = 0) :base(nro,name)
        {
            tipo = atipo;
            total = 0;
        }

        public int Tipo { get => tipo; set => tipo = value; }

        public override bool cargar()
        {
            try
            {
                Console.WriteLine("Ingrese costo: ");
                total += Convert.ToDouble(Console.ReadLine());
                return true;
            }catch(Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
            return false;
        }

        public override void imprimir()
        {
            double totreal = total;
            if (tipo == 1)
            {
                totreal = total + (total * 0.10);
            }
            else if (tipo == 2)
            {
                totreal = total + (total * 0.05);
            }
            base.imprimir();
            Console.WriteLine("Tipo de Cuenta {0}\nTotal Factura: ${1}\nTotal Real Factura: ${2}",tipo,total,totreal);
        }

        public static Contado ingreso()
        {
            try
            {
                Console.Clear();
                Contado temp = new Contado();
                Console.WriteLine("Ingreso la opcion Contado");
                Console.Write("Ingrese el numero de Factura: ");
                temp.Nmro = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el nombre del Cliente: ");
                temp.Nombre = Console.ReadLine();
                Console.Write("Ingrese el tipo de pago\n1 - Cheque\n2 - Tarjeta de debito\n3 - Efectivo\nOpcion: ");
                int type = Convert.ToInt32(Console.ReadLine());
                if (type > 0 && type < 4)
                {
                    temp.Tipo = type;
                }
                else
                {
                    Console.WriteLine("Error ");
                    return null;
                }
                return temp;                
                 
            }catch(Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
                return null;
            }
            
        }

    }
}
