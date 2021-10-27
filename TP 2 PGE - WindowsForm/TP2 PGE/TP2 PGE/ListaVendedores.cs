using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_PGE
{
    class ListaVendedores
    {
        ArrayList lista;
        public ListaVendedores()
        {
            lista = new ArrayList();
        }

        public ArrayList Lista { get => lista; set => lista = value; }

        public void add(string nom = "", string segnom = "", string ape = "", string zona = "", double vend = 0, double com = 0)
        {
            lista.Add(new Vendedor(nom, segnom,ape, zona, vend,com));
        }

        public double[] getVC(string texto)
        {
            double[] datos = {0,0};
            foreach (Vendedor solo in Lista)
            {
                if (solo.ZonaDeVenta == texto)
                {
                    datos[0] += solo.TotalVendido;
                    datos[1] += solo.Comision;
                }
            }
            return datos;
        }

        public double calcCom(string texto)
        {
            try
            {
                double temp = Convert.ToDouble(texto);
                if (temp < 50000)
                {
                    return 0;
                }
                else if (temp >= 50000 && temp < 75000)
                {
                    return temp * 0.15;
                }
                else if (temp >= 75000 && temp < 100000)
                {
                    return temp * 0.2;
                }
                else
                {
                    return temp * 0.3;
                }
            }
            catch
            {
                return 0;
            }
        }

    }
}
