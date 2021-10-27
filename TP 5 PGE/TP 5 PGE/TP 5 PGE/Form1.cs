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
    public partial class Form1 : Form
    {
        Form2 Entrada = new Form2();
        Facultad facultad;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmboxTipo.SelectedIndex = 0;
            cmbboxCat.SelectedIndex = 0;
            this.Size = new Size(600, 320);
            showDocente();
            Entrada.ShowDialog();
            lblFacu.Text = Entrada.Facu;
            lblDir.Text = Entrada.Dir;
            facultad = new Facultad(lblFacu.Text,lblDir.Text);
        }

        #region Panel Ingreso
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmboxTipo.SelectedIndex == 0)
            {
                try
                {
                    Docente temp1 = new Docente(Convert.ToInt32(txtboxLeg.Text), Convert.ToInt32(txtboxHoras.Text), txtboxNom.Text, Convert.ToInt32(txtboxAnti.Text), Convert.ToDouble(txtboxValor.Text), txtboxTitulo.Text);
                    if(Ask()) facultad.Add(temp1);
                    vaciar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No pudo ingresarse " + ex.Message, "Aviso de Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
            else if (cmboxTipo.SelectedIndex == 1)
            {
                try
                {
                    No_Docente temp2 = new No_Docente(Convert.ToInt32(txtboxLeg.Text), Convert.ToInt32(txtboxHoras.Text), txtboxNom.Text,cmbboxCat.SelectedIndex+1,txtboxValor.Text);
                    if(Ask()) facultad.Add(temp2);
                    vaciar();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No pudo ingresarse " + ex.Message, "Aviso de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void vaciar()
        {
            txtboxNom.Text = "";
            txtboxLeg.Text = "";
            txtboxHoras.Text = "";
            txtboxTitulo.Text = "";
            txtboxValor.Text = "";
            txtboxTitulo.Text = "";
            txtboxAnti.Text = "";        
        }

        private bool ValidarCampos()
        {
            bool ok = true;
            foreach(object ob in tabControl1.Controls)
            {
                if(ob is TextBox)
                {
                    if(((TextBox)ob).Text == "")
                    {
                        ok = false;
                        errorProvider1.SetError(((TextBox)ob),"Ingresar valor en campo " + ((TextBox)ob).Name);
                    }
                }
            }
            return ok;
        }

        private void cmboxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboxTipo.SelectedIndex == 0)
            {
                showDocente();
            }
            else
            {
                showNoDocente();
            }
        }

        private void showDocente() {
            lblAnti.Show();
            lblValor.Show();
            lblTitu.Show();
            txtboxTitulo.Show();

            lblArea.Hide();
            lblCat.Hide();
            cmbboxCat.Hide();
        }

        private void showNoDocente()
        {
            lblArea.Show();
            lblCat.Show();
            cmbboxCat.Show();

            lblAnti.Hide();
            lblValor.Hide();
            lblTitu.Hide();
            txtboxTitulo.Hide();
        }

        private bool Ask()
        {
            DialogResult temp = MessageBox.Show("Seguro que desea ingresar?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(temp == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Panel Listado
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if (facultad.Cant < 1)
                {
                    tabControl1.SelectedIndex = 0;
                    MessageBox.Show("Ingrese empleados antes de intentar listarlos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Size = new Size(600, 320);
                    return;
                }
                this.Size = new Size(600,600);

                
            }else if(tabControl1.SelectedIndex == 0)
            {
                this.Size = new Size(600, 320);
            }
        }

        

        private void btnAll_Click(object sender, EventArgs e)
        {
            List<IEmpleado> temp = facultad.All();
            changeListBox(temp);
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            List<IEmpleado> temp = facultad.Doc();
            changeListBox(temp);
        }

        private void btnNoDoc_Click(object sender, EventArgs e)
        {
            List<IEmpleado> temp = facultad.NoDoc();
            changeListBox(temp);
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            
            string texto = listbox.SelectedItem.ToString();
            string [] texto2 = texto.Split(' ');
            if (AskDel())
            {
                if (facultad.Erase(Convert.ToInt32(texto2[1])))
                {
                    MessageBox.Show("Eliminado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<IEmpleado> temp = facultad.All();
                    changeListBox(temp);
                }
            }
        }

        private void changeListBox(List<IEmpleado> temp)
        {
            listbox.Items.Clear();
            foreach(IEmpleado solo in temp)
            {
                string[] texto = solo.ToString().Split(',');
                foreach( string textito in texto)
                {
                    listbox.Items.Add(textito);
                }
                
            }
        }
        private bool AskDel()
        {
            DialogResult temp = MessageBox.Show("Seguro que desea eliminar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (temp == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        private void txtboxNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtboxTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtboxLeg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtboxHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtboxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtboxAnti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
