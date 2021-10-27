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
    public partial class Form2 : Form
    {
        int segundos = 5;
        public Form2()
        {
            InitializeComponent();
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            txtbox.Text = segundos.ToString();
        }
        public int Segundos
        {
            get => segundos;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtbox.Text) > 0)
            {
                segundos = Convert.ToInt32(txtbox.Text) * 1000;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese el dato correctamente", "Aviso", MessageBoxButtons.OK);
            }
        }

        
    }
}
