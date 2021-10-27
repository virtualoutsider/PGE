using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PGE_3
{
    class ListadeFacutas
    {
        List<CFactura> lista;

        public ListadeFacutas()
        {
            lista = new List<CFactura>();
        }

        internal List<CFactura> Lista { get => lista; set => lista = value; }

        public void add(CFactura F)
        {
            if (F == null) return;
            lista.Add(F);
        }

        public void listar()
        {
            Console.WriteLine("Mostrando facturas");
            foreach(CFactura pepe in lista)
            {
                pepe.imprimir();
                Console.WriteLine("======================");
            }
            Console.WriteLine("Fin de Listado...");
            return;
        }

        public int menu()
        {
            int op = 0;
            Console.Write("=====Menu=====\n" +
                "1 - Crear factura\n" +
                "2 - Ingresar elemento\n" +
                "3 - Listar Facturas\n" +
                "4 - Salir\n" +
                "Opcion: ");
            op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
    }
}
