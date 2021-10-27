using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_7_PGE___2
{
    public partial class Form2 : Form
    {

        Usuario temp;
        public delegate void CambiaPassHandler(string vieja, string actual);
        public event CambiaPassHandler CambioContrasena;

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            changePassword1.Botan1.Click += new System.EventHandler(this.DevuelveContrasena);
            changePassword1.Botan2.Click += new System.EventHandler(this.Cancelar);
        }

        public void DevuelveContrasena(object sender,EventArgs e)
        {
            if(temp.Clave == changePassword1.TextoBoxu1.Text)
            {
                this.CambioContrasena(changePassword1.TextoBoxu1.Text, changePassword1.TextoBoxu2.Text);
                Hide();
            }
            else
            {
                MessageBox.Show("Ingreso incorrectamente la vieja contraseña","Aviso",MessageBoxButtons.OK);
            }
            
        }

        public void Cancelar(object sender, EventArgs e)
        {
            this.Close();
        }
        public void getObjeto(Usuario x)
        {
            temp = x;
        }
    }
}
