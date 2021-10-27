using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_6_PGE___Juego
{
    class Juego
    {
        int sequence = 0;
        Random random;
        List<int> orden = new List<int>();
        bool viewing;
        bool playing;
        int maximaseq;
        int puntaje;

        public Juego()
        {
            random = new Random();
            playing = false;
            puntaje = 0;
        }

        public List<int> Orden
        {
            get => orden;
        }
        public int Maximaseq
        {
            get => maximaseq;
            set => maximaseq = value;
        }
        public bool Playing
        {
            get => playing;
            set => playing = value;
        }
        public bool Viewing
        {
            get => viewing;
            set => viewing = value;
        }
        public int Sequence
        {
            get => sequence;
            set => sequence = value;
        }
        public int Puntaje
        {
            get => puntaje;
            set => puntaje = value;
        }
        public void add()
        {
            if(orden.Count != 0) //Lista no vacia
            {
                int ale = random.Next(1, 7);
                while(ale == orden[orden.Count - 1]) {
                    ale = random.Next(1, 7);
                }
                orden.Add(ale);
            }
            else //Lista Vacia
            {
                puntaje = 0;
                orden.Add(random.Next(1, 7));
            }
            
        }

        public int CheckInt(int valor)
        {
            if (viewing || orden.Count == 0) return 0;
            if (orden[Sequence] == valor)
            {
                Sequence++;
            }
            else
            {
                
                reiniciar();
                return 0;
            }
            if (sequence == maximaseq && maximaseq != -1)
            {
                puntaje++;
                reiniciar();
                return -1;
            }
            if (sequence >= Orden.Count)
            {
                puntaje++;
                sequence = 0;
                add();
                return 1;
            }
            return 2;
            
        }

        public void reiniciar()
        {
            playing = false;
            sequence = 0;
            orden.Clear();
        }

        public void win(string name)
        {

            MessageBox.Show(String.Format("Has ganado {0}",name),"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public void lose(string name)
        {
            MessageBox.Show(String.Format("Has perdido {0}\nPuntaje Maximo: {1}", name,puntaje), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
