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
            cbbVenta.SelectedIndex = 0;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            if(txtName.Text != "" && txtSecName.Text != "" && txtSur.Text != "")
            {
                try
                {
                    if(Convert.ToDouble(txtVendido.Text) > 0)
                    {

                        DialogResult temp = MessageBox.Show("Desea agregar este vendedor?","Aviso de Ingreso",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                        if(temp == DialogResult.Yes)
                        {
                            try
                            {

                                Lista.Add(txtName.Text, txtSecName.Text, txtSur.Text, cbbVenta.Text, Convert.ToDouble(txtVendido.Text), Convert.ToDouble(lblCom2.Text));
                                Clear();
                                MessageBox.Show("Agregado con exito","Aviso",MessageBoxButtons.OK);
                            }
                            catch (FormatException ex)
                            {
                                MessageBox.Show("Error de tipeo: " + ex.Message,"Aviso de error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                Console.WriteLine("Error -->" + ex.Message);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message, "Aviso de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Console.WriteLine("Error -->" + ex.Message);
                            }
                        }
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Error en el ingreso", "Aviso de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error en el ingreso" , "Aviso de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbbVenta2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Lista.Lista.Count > 0)
            {
                double[] datos = Lista.GetVC(cbbVenta2.Text);
                txtZonaV.Text = datos[0].ToString();
                txtZonaC.Text = datos[1].ToString();
                if(datos[0] < 1)
                {
                    lblEstado2.Text = "Estado: Error\nFaltan vendedores";
                }
                else
                {
                    lblEstado2.Text = "Estado:";
                }
            
            }
            else
            {
                lblEstado2.Text = "Estado: Error\nFaltan vendedores";
            }
            
        }
        private void TxtVendido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtVendido.Text != "") lblCom2.Text = Lista.CalcCom(txtVendido.Text).ToString();
            }
            catch
            {

                Console.WriteLine("Estado: Error");
            }
            
        }

        private void Clear()
        {
            txtName.Text = "";
            txtSecName.Text = "";
            txtSur.Text = "";
            txtVendido.Text = "";
            txtVendido.Text = "";
            lblCom2.Text = "";
            cbbVenta.SelectedIndex = 0;

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Registro")
            {
                if(Lista.Lista.Count > 0)
                {
                    ReadyButtons();
                    ChangeReg(Lista.Refresh());
                }
                else
                {
                    ReadOnlyButtons();
                    MessageBox.Show("Ingrese un vendedor antes de mostrar","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void ReadOnlyButtons()
        {
            btnPri.Enabled = false;
            btnUlt.Enabled = false;
            btnSig.Enabled = false;
            btnAnt.Enabled = false;
            btnEli.Enabled = false;
        }

        private void ReadyButtons()
        {
            btnPri.Enabled = true;
            btnUlt.Enabled = true;
            btnSig.Enabled = true;
            btnAnt.Enabled = true;
            btnEli.Enabled = true;
        }

        private void EraseReg()
        {
            txtbPos.Text = "";
            txtbNomReg.Text = "";
            txtbSegNomReg.Text = "";
            txtbApeReg.Text = "";
            txtbZonaReg.Text = "";
            txtbVentaReg.Text = "";
            txtbComReg.Text = "";
        }

        private void ChangeReg(Vendedor temp)
        {
            if(temp == null)
            {
                
                return;
            }
            try
            {
                txtbPos.Text = (Lista.SelectedIndex1 + 1).ToString() + " / " + Lista.Lista.Count;
                txtbNomReg.Text = temp.Singular1.Priombre;
                txtbSegNomReg.Text = temp.Singular1.Segnombre;
                txtbApeReg.Text = temp.Singular1.Apellido;
                txtbZonaReg.Text = temp.ZonaDeVenta;
                txtbVentaReg.Text = temp.TotalVendido.ToString();
                txtbComReg.Text = temp.Comision.ToString();
            }
            catch
            {
                EraseReg();
            }
        }

        private void BtnPri_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeReg(Lista.First());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error --> " + ex.Message);
                
            }
            
        }

        private void BtnAnt_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeReg(Lista.Prev());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error --> " + ex.Message);
                
            }
            
        }

        private void BtnSig_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeReg(Lista.Next());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error --> " + ex.Message);
                
            }
            
        }

        private void BtnUlt_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeReg(Lista.Last());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error --> " + ex.Message);
                
            }
            
        }
        private void BtnEli_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Seguro que quiere eliminar al vendedor?", "Aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Question) ;
            if(res == DialogResult.Yes)
            {
                try
                {
                    ChangeReg(Lista.Eliminar());
                    if(Lista.Lista.Count == 0)
                    {
                        EraseReg();
                    }
                    MessageBox.Show("Borrado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch(Exception ex)
                {
                    MessageBox.Show("No hay elemetos en la lista\n" + ex.Message,"Aviso de Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
