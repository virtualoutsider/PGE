using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TP_5_PGE
{
    class Facultad
    {
        List<IEmpleado> empleados;
        string nombre, direccion;
        public Facultad(string nom = "", string dir = "")
        {

            empleados = new List<IEmpleado>();
            nombre = nom;
            direccion = dir;
        }

        public int Cant {
            get => empleados.Count;
        }

        public string Nombre
        {
            get => nombre;
        }
        public string Direccion
        {
            get => direccion;
        }

        public bool Add(IEmpleado D)
        {
            if (D == null)
            {
                return false;
            }
            empleados.Add(D);
            return true;
        }

        public List<IEmpleado> All()
        {
            return empleados;
        }

        public List<IEmpleado> Doc()
        {
            List <IEmpleado> listita= new List<IEmpleado>();
            foreach(IEmpleado empleado in empleados)
            {
                if( empleado is Docente)
                {
                    listita.Add(empleado);
                }
            }
            return listita;
        }

        public List<IEmpleado> NoDoc()
        {
            List<IEmpleado> listita = new List<IEmpleado>();
            foreach (IEmpleado empleado in empleados)
            {
                if (empleado is No_Docente)
                {
                    listita.Add(empleado);
                }
            }
            return listita;
        }

        public bool Erase(int leg)
        {
            foreach (IEmpleado empleado in empleados)
            {
                if (empleado.Legajo() == leg)
                {
                    empleados.Remove(empleado);
                    return true;
                }
            }
            return false;
        }
    }
}
