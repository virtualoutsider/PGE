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
        int punto;
        readonly Random random = new Random();
        List<int> orden = new List<int>();
        List<int> usuario = new List<int>();
        int pos = 0;
        int posactual = 0;
        int nivel;
        public Juego()
        {

        }
        
        public int Pos
        {
            get => pos;
        }
        public int Posactual
        {
            get => posactual;
        }
        public int Nivel
        {
            get => nivel;
        }
        public int Count
        {
            get => orden.Count;
        }

        public void iniciar()
        {
            nivel = 0;
            punto = 0;
            pos = 0;
            orden.Clear();
            usuario.Clear();
            for (int i = 0; i < 7; i++) {
                orden.Add(getRandom());
            } 
        }
        public int getRandom()
        {
            return random.Next(1, 7);
        }

        public bool complete()
        {
            if(usuario.GetRange(0,nivel).Count == orden.GetRange(0, nivel).Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isInOrder()
        {
            bool ordencita = true;
            for(int i = 0; i <= nivel; i++)
            {
                try
                {
                    if (usuario[i] != orden[i])
                    {
                        ordencita = false;
                    }
                }
                catch
                {

                }
                
            }
            if(ordencita)
            {

                pos = 0;
                usuario.Clear();
                nivel++;
                return true;
            }
            return false;
        }
        public bool addUsuario(int i) { 
            if(i == orden[pos])
            {
                
                pos++;
                usuario.Add(i);

                
                return true;
            }
            return false;
        }

        public List<int> getOrder()
        {
            return orden;
        }
        public List<int> getUsuario()
        {
            return usuario;
        }

        public bool increase()
        {
            punto++;
            if (punto == 5) return true;
            return false;
        }

        public void win()
        {
            MessageBox.Show("Ganaste!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public void lose()
        {
            MessageBox.Show("Perdiste", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
