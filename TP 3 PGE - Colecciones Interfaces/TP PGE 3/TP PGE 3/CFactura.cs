using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PGE_3
{
    class CFactura:IFactura
    {
        int nmro;
        string nombre;

        public int Nmro { get => nmro; set => nmro = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public CFactura(int nro,string name)
        {
            nmro = nro;
            nombre = name;
        }

        public virtual bool cargar()
        {
            return false;
        }
        public virtual void imprimir()
        {
            
            Console.WriteLine("Nombre: {0}\nNumero de cuenta: {1}", nombre, nmro);
        }
        
        public void codigo()
        {
            Console.WriteLine(nombre[0] + nombre[1] + nombre [2] + nmro.ToString());
        }
    }
}
