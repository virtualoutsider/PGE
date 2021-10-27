using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_PGE
{
    class Vendedor
    {
        Nombre Singular;
        string zonaDeVenta;
        double totalVendido, comision;

        public Vendedor(string nom = "", string segnom = "", string ape = "", string zona = "", double vend = 0, double com = 0)
        {
            Singular = new Nombre(nom,segnom,ape);
            zonaDeVenta = zona;
            totalVendido = vend;
            comision = com;
        }

        public string ZonaDeVenta { get => zonaDeVenta; set => zonaDeVenta = value; }
        public double TotalVendido { get => totalVendido; set => totalVendido = value; }
        public double Comision { get => comision; set => comision = value; }
        internal Nombre Singular1 { get => Singular; set => Singular = value; }


    }
}
