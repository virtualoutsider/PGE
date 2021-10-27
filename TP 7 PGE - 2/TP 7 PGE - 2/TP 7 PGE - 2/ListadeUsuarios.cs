using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_7_PGE___2
{
    class ListadeUsuarios
    {

        List<Usuario> lista;
        
        public ListadeUsuarios()
        {
            lista = new List<Usuario>();
        }

        public void Add(Usuario x)
        {
            lista.Add(x);
        }

        public List<Usuario> Lista
        {
            get => lista;
        }

        


    }
}
