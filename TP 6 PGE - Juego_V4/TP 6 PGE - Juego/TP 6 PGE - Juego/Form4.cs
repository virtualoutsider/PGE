using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_6_PGE___Juego
{
    public partial class Form4 : Form
    {
        int x;
        public Form4(int z)
        {
            
            InitializeComponent();
            x = z;
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if(x == 1)
            {
                pictureBox1.Image = Image.FromFile(@"youwin.png");
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"youlose.jpg");
            }
        }
    }
}
