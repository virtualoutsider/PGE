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
    public partial class Form3 : Form
    {
        string nombre;
        int edad;
        public Form3()
        {
            InitializeComponent();
        }
        public string Nombre
        {
            get => nombre;

        }
        public int Edad
        {
            get => edad;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text != "" && txtEdad.Text != "")
            {
                nombre = txtNombre.Text;
                edad = Convert.ToInt32(txtEdad.Text);
                MessageBox.Show("Usuario editado correctamente", "Informacion", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error, ingrese un valor valido", "Alerta", MessageBoxButtons.OK);
            }
            
        }
    }
}
