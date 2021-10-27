using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_7_PGE___2
{
    public partial class Form1 : Form
    {
        ListadeUsuarios listita;
        Form2 formulario = new Form2();
        int pos = 0;
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listita = new ListadeUsuarios();
            formulario.CambioContrasena += new Form2.CambiaPassHandler(ChangePass);
            path = Path.Combine(Directory.GetCurrentDirectory(),"cambios.txt");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listita.Add(new Usuario(txtA.Text,txtN.Text,txtP.Text,txtC.Text,txtE.Text,txtUser.Text,txtPass.Text,Convert.ToInt32(txtM.Text)));
            comboBox1.Items.Add(txtA.Text + " "+ txtN.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = ((ComboBox)sender).SelectedItem.ToString();
            string[] datos = temp.Split(' '); 
            foreach(Usuario i in listita.Lista)
            {
                if (i.Nombre == datos[0] && i.Apellido == datos[1])
                {
                    formulario.getObjeto(i);
                    formulario.ShowDialog();
                    pos = listita.Lista.IndexOf(i);
                    break;
                }
            }
        }

        private void ChangePass(string vieja, string nueva)
        {
            listita.Lista[pos].ChangeClave(vieja, nueva);
            if (File.Exists(path))
            {
                try
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write(DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss") + " Cambio de " + vieja + " a " + nueva + "\n");
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine("No funcionoo wey");
                }
            }
            else
            {
                try
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss") + " Cambio de " + vieja + " a " + nueva + "\n");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No funcionoo wey");
                }
            }
        }

        
    }
}
