using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_PGE
{
    class ListaVendedores
    {
        List<Vendedor> lista;
        int SelectedIndex;
        public ListaVendedores()
        {
            lista = new List<Vendedor>();
            SelectedIndex = 0;
        }

        public List<Vendedor> Lista { get => lista; set => lista = value; }
        public int SelectedIndex1 { get => SelectedIndex; set => SelectedIndex = value; }

        public void Add(string nom = "", string segnom = "", string ape = "", string zona = "", double vend = 0, double com = 0)
        {
            lista.Add(new Vendedor(nom, segnom, ape, zona, vend, com));
        }

        public double[] GetVC(string texto)
        {
            double[] datos = { 0, 0 };
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

        public double CalcCom(string texto)
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

        public Vendedor Next()
        {
            try
            {
                if (lista.Count-1 > SelectedIndex )
                {
                    SelectedIndex++;
                    return lista[SelectedIndex];
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            
        }

        public Vendedor Prev()
        {
            if (SelectedIndex > 0 && lista.Count > 0)
            {
                SelectedIndex--;
                return lista[SelectedIndex];
            }
            else
            {
                return null;
            }
        }

        public Vendedor First()
        {
            if (lista.Count > 0)
            {
                SelectedIndex = 0;
                return lista[0];
            }
            return null;
        }

        public Vendedor Last()
        {
            if (lista.Count > 0)
            {
                SelectedIndex = lista.Count-1;
                return lista[SelectedIndex];
            }
            return null;
        }

        public Vendedor Eliminar()
        {
            lista.RemoveAt(SelectedIndex);
            return First();
        }

        public Vendedor Refresh()
        {
            if(lista.Count > 0)
            {
                return lista[SelectedIndex];
            }
            return null;
        }
    }
}
