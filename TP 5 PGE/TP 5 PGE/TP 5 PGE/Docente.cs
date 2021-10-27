using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_5_PGE
{
    class Docente: CEmpleado,IEmpleado
    {
        int antiguedad;
        double valorxhora;
        string titulo;
        public new int Legajo()
        {
            return base.Legajo;
        }
        public Docente(int leg = 0, int hora = 0, string nom = "", int anti = 0, double valor = 0, string titu = ""): base(leg,hora,nom)
        {
            antiguedad = anti;
            valorxhora = valor;
            titulo = titu;
        }
        // < 1 año antiguedad = 0%
        // > 1 && < 5 antiguedad = 10%
        // > 5 antiguedad = 25%
        public double calcSueldo()
        {
            if (antiguedad < 1)
            {
                return valorxhora * base.Horas;
            }else if ( antiguedad >= 1 && antiguedad < 5)
            {
                return valorxhora * base.Horas * 0.1;
            }
            else if( antiguedad >= 5)
            {
                return valorxhora * base.Horas * 0.25;
            }
            return 0;
        }
        public override string ToString()
        {
            string texto = "Legajo: " + base.Legajo + "    Nombre: " + Nombre + "    Horas: " + Horas + "    Antiguedad: " + antiguedad + "    Valor x Hora: " + valorxhora + "    Titulo: " + titulo;
            return texto;
        }
    }
}
