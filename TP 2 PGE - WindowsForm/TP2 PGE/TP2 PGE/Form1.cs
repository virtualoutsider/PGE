using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_PGE
{
    public partial class Form1 : Form
    {
        ListaVendedores Lista;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lista = new ListaVendedores();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Lista.add(txtName.Text, txtSecName.Text, txtSur.Text, cbbVenta.Text, Convert.ToDouble(txtVendido.Text), Convert.ToDouble(lblCom2.Text));
                clear();
                lblEstado.Text = "Estado: Exito";
            }
            catch (Exception ex)
            {
                lblEstado.Text = "Estado: Error";
                Console.WriteLine("Error -->" + ex.Message);
            }            
        }

        private void cbbVenta2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Lista.Lista.Count > 0)
            {
                double[] datos = Lista.getVC(cbbVenta2.Text);
                txtZonaV.Text = datos[0].ToString();
                txtZonaC.Text = datos[1].ToString();
            }
            else
            {
                lblEstado2.Text = "Estado: Error\nFaltan vendedores";
            }
            
        }
        private void txtVendido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtVendido.Text != "") lblCom2.Text = Lista.calcCom(txtVendido.Text).ToString();
            }
            catch
            {

                lblEstado.Text = "Estado: Error";
            }
            
        }

        private void clear()
        {
            txtName.Text = "";
            txtSecName.Text = "";
            txtSur.Text = "";
            txtVendido.Text = "";
            txtVendido.Text = "";
            lblCom2.Text = "";

        }
    }
}
