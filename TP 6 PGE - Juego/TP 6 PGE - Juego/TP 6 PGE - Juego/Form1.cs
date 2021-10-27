using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_6_PGE___Juego
{
    public partial class Form1 : Form
    {
        Juego juegito = new Juego();
        int entero = 0;
        bool time = false;
        bool show = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            juegito.iniciar();
            time = false;
            showtimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time == false)
            {
                time = true;
                juegito.lose();
                responsetimer.Stop();
            }
        }

        private void glowButton(int i)
        {
            switch (i)
            {
                case 1:
                    btn1.BackColor = Color.FromArgb(255, 0, 0);
                    break;
                case 2:
                    btn2.BackColor = Color.FromArgb(255, 255, 0);
                    break;
                case 3:
                    btn3.BackColor = Color.FromArgb(0, 255, 0);
                    break;
                case 4:
                    btn4.BackColor = Color.FromArgb(0, 255, 255);
                    break;
                case 5:
                    btn5.BackColor = Color.FromArgb(0, 0, 255);
                    break;
                case 6:
                    btn6.BackColor = Color.FromArgb(255, 0, 255);
                    break;
            }            
        }

        #region btnFunctions
        private void btn1_Click(object sender, EventArgs e)
        {
            if (juegito.addUsuario(1)) {
                if (juegito.isInOrder() && juegito.complete())
                {
                    showtimer.Start();
                }
                if (juegito.Nivel == juegito.Count - 1)
                {
                    juegito.win();
                }
            }
            else
            {
                juegito.lose();
                responsetimer.Stop();
            }
                

        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (juegito.addUsuario(2))
            {
                if (juegito.isInOrder() && juegito.complete())
                {
                    showtimer.Start();
                }
                if (juegito.Nivel == juegito.Count - 1)
                {
                    juegito.win();
                }
            }
            else
            {
                juegito.lose();
                responsetimer.Stop();
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (juegito.addUsuario(3))
            {
                if (juegito.isInOrder() && juegito.complete())
                {
                    showtimer.Start();
                }
                if (juegito.Nivel == juegito.Count - 1)
                {
                    juegito.win();
                }
            }
            else
            {
                juegito.lose();
                responsetimer.Stop();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (juegito.addUsuario(4)) {
                if (juegito.isInOrder() && juegito.complete() && juegito.complete())
                {
                    showtimer.Start();
                }
                if (juegito.Nivel == juegito.Count - 1)
                {
                    juegito.win();
                }
            }
            else
            {
                juegito.lose();
                responsetimer.Stop();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (juegito.addUsuario(5)) {
                if (juegito.isInOrder() && juegito.complete())
                {
                    showtimer.Start();
                }
                if (juegito.Nivel == juegito.Count - 1)
                {
                    juegito.win();
                }
            }
            else
            {
                juegito.lose();
                responsetimer.Stop();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (juegito.addUsuario(6)) {
                if (juegito.isInOrder() && juegito.complete())
                {
                    showtimer.Start();
                }
                if (juegito.Nivel == juegito.Count - 1)
                {
                    juegito.win();
                }
            }
            else
            {
                juegito.lose();
                responsetimer.Stop();
            }
        }
        #endregion

        private void showtimer_Tick(object sender, EventArgs e)
        {
            responsetimer.Stop();
            if (!show)
            {
                List<int> temp = juegito.getOrder();
                glowButton(temp[entero]);
                entero++;
                show = !show;
                
            }
            else
            {
                show = !show;
                btn1.UseVisualStyleBackColor = true;
                btn2.UseVisualStyleBackColor = true;
                btn3.UseVisualStyleBackColor = true;
                btn4.UseVisualStyleBackColor = true;
                btn5.UseVisualStyleBackColor = true;
                btn6.UseVisualStyleBackColor = true;
                if (entero > juegito.Nivel)
                {
                    entero = 0;
                    showtimer.Stop();
                    responsetimer.Start();
                }
            }

        }       
    }
}
