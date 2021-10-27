using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_5_PGE
{
    class No_Docente: CEmpleado,IEmpleado
    {
        int categoria;
        string area;
        public No_Docente(int leg = 0, int hora = 0, string nom = "", int cat = 0, string aria = "") :base(leg,hora,nom)
        {
            categoria = cat;
            area = aria;
        }
        public new int Legajo()
        {
            return base.Legajo;
        }

        public double calcSueldo()
        {
            switch (categoria)
            {
                case 1:
                    return 13.25 * base.Horas;
                case 2:
                    return 11.50 * base.Horas;
                case 3:
                    return 9.75 * base.Horas;
                default:
                    return 0;
            }

        }
        public override string ToString()
        {
            string texto = "Legajo: " + base.Legajo + "    Nombre: " + Nombre + "    Horas: " + Horas + "    Categoria: " + categoria + "    Area: " + area;
            return texto;
        }
    }
}
