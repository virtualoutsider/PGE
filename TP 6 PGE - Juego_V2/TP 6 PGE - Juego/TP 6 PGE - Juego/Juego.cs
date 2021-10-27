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
                orden.Add(random.Next(1, 7));
            }
            
        }

        public int CheckInt(int valor)
        {
            if (Viewing || Orden.Count == 0) return 0;
            if (Orden[Sequence] == valor)
            {
                Sequence++;
            }
            else
            {
                lose();
                reiniciar();
                return -1;
            }
            if (Sequence == Maximaseq && Maximaseq != -1)
            {
                win();
                reiniciar();
                return -1;
            }
            if (Sequence >= Orden.Count)
            {
                Puntaje++;
                Sequence = 0;
                add();
                return 1;
            }
            return 0;
        }

        public void reiniciar()
        {
            playing = false;
            sequence = 0;
            puntaje = 0;
            orden.Clear();
        }

        public void win()
        {
            MessageBox.Show("Ganaste!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public void lose()
        {
            MessageBox.Show("Perdiste, puntaje maximo: " + puntaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
