using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PGE_3
{
    interface IFactura
    {
        void imprimir();
        bool cargar();
        int Nmro
        {
            get;
            set;
        }
    }
}
