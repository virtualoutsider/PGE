using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_7_PGE___2
{
    public class Usuario
    {
        string apellido, nombre, provincia, ciudad, email, usuario, clave;
        int movil;
        

        public Usuario(string apellido, string nombre, string provincia, string ciudad, string email, string usuario, string clave, int movil)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.provincia = provincia;
            this.ciudad = ciudad;
            this.email = email;
            this.usuario = usuario;
            this.Clave = clave;
            this.movil = movil;
        }

        public string Apellido
        {
            get => apellido;
        }
        public string Nombre
        {
            get => nombre;
        }
        public string Clave { get => clave; set => clave = value; }

        public void ChangeClave(string valor1,string valor2)
        {
            if (valor1 == Clave)
            {
                Clave = valor2;
                Console.WriteLine("La contrasena paso de {0} a {1}",valor1,valor2);
            } 
        }
        public void getItem() // devuleve Usuario
        {
            //return new Usuario();
        }
    }
}
