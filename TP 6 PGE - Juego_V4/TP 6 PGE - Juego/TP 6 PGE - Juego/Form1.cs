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
        Form2 Tiempo = new Form2();
        Usuario jugador;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            juegito.Ganastes += new Juego.ImagenEventHandler(imagen);
            jugador = new Usuario();
            juegito.Maximaseq = Convert.ToInt32(niveltxt1.Text);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            jugador.WriteFile();
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!juegito.Playing)
            {
                juegito.Playing = true;
                juegito.add();
                responsetimer.Start();
                new Thread(IniciarJuego).Start();

            }
        }

        public void IniciarJuego()
        {
            Thread.Sleep(200);
            juegito.Viewing = true;
            foreach(int boton in juegito.Orden)
            {
                switch (boton)
                {
                    case 1:
                        btn1.BackColor = Color.FromArgb(0, 0, 255);
                        Thread.Sleep(200);
                        btn1.UseVisualStyleBackColor = true;
                        break;
                    case 2:
                        btn2.BackColor = Color.FromArgb(0, 255, 0);
                        Thread.Sleep(200);
                        btn2.UseVisualStyleBackColor = true;
                        break;
                    case 3:
                        btn3.BackColor = Color.FromArgb(0,255, 255);
                        Thread.Sleep(200);
                        btn3.UseVisualStyleBackColor = true;
                        break;
                    case 4:
                        btn4.BackColor = Color.FromArgb(255, 0, 0);
                        Thread.Sleep(200);
                        btn4.UseVisualStyleBackColor = true;
                        break;
                    case 5:
                        btn5.BackColor = Color.FromArgb(255, 0, 255);
                        Thread.Sleep(200);
                        btn5.UseVisualStyleBackColor = true;
                        break;
                    case 6:
                        btn6.BackColor = Color.FromArgb(255, 255, 0);
                        Thread.Sleep(200);
                        btn6.UseVisualStyleBackColor = true;
                        break;
                }
            }
            juegito.Viewing = false;
        }
        
        public void CheckButton(int valor)
        {
            switch (juegito.CheckInt(valor))
            {
                case 0:
                    responsetimer.Stop();
                    jugador.MaxScore1 = juegito.Puntaje;
                    juegito.lose(jugador.Nombre1);
                    break;
                case -1:
                    responsetimer.Stop();
                    jugador.MaxScore1 = juegito.Puntaje;
                    juegito.win(jugador.Nombre1);
                    break;
                case 1:
                    responsetimer.Stop();
                    responsetimer.Start();
                    new Thread(IniciarJuego).Start();
                    break;

            }          
        }

        private void responsetimer_Tick(object sender, EventArgs e)
        {
            if (juegito.Playing)
            {
                juegito.lose(jugador.Nombre1);
                juegito.reiniciar();
            }
        }

        #region Buttons
        private void boton_Click(object sender, EventArgs e)
        {
            CheckButton(Convert.ToInt32(((Button)sender).Tag));
        }
        

        private void btn1_MouseDown(object sender, MouseEventArgs e)
        {
            btn1.BackColor = Color.FromArgb(0, 0, 255);
            
        }

        private void btn1_MouseUp(object sender, MouseEventArgs e)
        {
            btn1.UseVisualStyleBackColor = true;
        }

        private void btn2_MouseDown(object sender, MouseEventArgs e)
        {
            btn2.BackColor = Color.FromArgb(0, 255, 0);
        }
        private void btn2_MouseUp(object sender, MouseEventArgs e)
        {
            btn2.UseVisualStyleBackColor = true;
        }

        private void btn3_MouseDown(object sender, MouseEventArgs e)
        {
            btn3.BackColor = Color.FromArgb(0, 255, 255);
        }

        private void btn3_MouseUp(object sender, MouseEventArgs e)
        {
            btn3.UseVisualStyleBackColor = true;
        }

        private void btn4_MouseDown(object sender, MouseEventArgs e)
        {
            btn4.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void btn4_MouseUp(object sender, MouseEventArgs e)
        {
            btn4.UseVisualStyleBackColor = true;
        }

        private void btn5_MouseDown(object sender, MouseEventArgs e)
        {
            btn5.BackColor = Color.FromArgb(255, 0, 255);
        }

        private void btn5_MouseUp(object sender, MouseEventArgs e)
        {
            btn5.UseVisualStyleBackColor = true;
        }

        private void btn6_MouseDown(object sender, MouseEventArgs e)
        {
            btn6.BackColor = Color.FromArgb(255, 255, 0);
        }

        private void btn6_MouseUp(object sender, MouseEventArgs e)
        {
            btn6.UseVisualStyleBackColor = true;
        }
        #endregion

        #region Opciones
        private void comoJugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apreta el boton Jugar\nEntonces se marcara una secuencia de colores\nSegui la secuencia para llegar al puntaje deseado","Como jugar",MessageBoxButtons.OK);
        }

        private void niveltxt1_Click(object sender, EventArgs e)
        {
            juegito.Maximaseq = 5;

        }

        private void niveltxt2_Click(object sender, EventArgs e)
        {
            juegito.Maximaseq = 10;
        }

        private void niveltxt3_Click(object sender, EventArgs e)
        {
            juegito.Maximaseq = -1;
        }

        private void tiempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tiempo.ShowDialog();
            responsetimer.Interval = Tiempo.Segundos;
        }
       

        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string temp = String.Format("Informacion del Usuario\nNombre: {0}\nEdad: {1}\nPuntuacion Maxima: {2}", jugador.Nombre1, jugador.Edad1, jugador.MaxScore1);
            MessageBox.Show(temp, "Informacion", MessageBoxButtons.OK);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jugador.Editar();
            
        }
#endregion
        private void imagen(int i) {
            new Form4(i).ShowDialog();
        }
    }
}
