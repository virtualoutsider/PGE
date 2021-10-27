using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_PGE
{
    class Nombre
    {
        string prinombre, segnombre, apellido;

        public string Priombre { get => prinombre; set => prinombre = value; }
        public string Segnombre { get => segnombre; set => segnombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public Nombre(string nom = "", string segnom = "", string ape = "")
        {
            prinombre = nom;
            segnombre = segnom;
            apellido = ape;
        }
    }
}
