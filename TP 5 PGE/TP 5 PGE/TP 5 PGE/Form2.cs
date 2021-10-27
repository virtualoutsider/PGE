using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_5_PGE
{
    public partial class Form2 : Form
    {
        string facu,dir;
        bool ready = true;

        public Form2()
        {
            InitializeComponent();
        }

        public string Facu
        {
            get => facu;
        }
        public string Dir
        {
            get => dir;
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            if(txtboxFacu.Text == "" || txtboxDir.Text == "")
            {
                MessageBox.Show("Ingreso un valor invalido");
                ready = false;
            }
            if (ready)
            {
                facu = txtboxFacu.Text;
                dir = txtboxDir.Text;
                this.Close();
            }

        }
    }
}
