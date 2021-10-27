using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_5_PGE
{
    class CEmpleado
    {
        int legajo, horas;
        string nombre;
        public CEmpleado(int leg = 0, int hora = 0, string nom = "")
        {
            legajo = leg;
            horas = hora;
            nombre = nom;
        }

        public int Legajo{
            get => legajo; 
            set => legajo = value;
        }

        public string Nombre { 
            get => nombre;
            set => nombre = value; 
        }

        public int Horas {
            get => horas;
            set => horas = value;
        }
    }
}
