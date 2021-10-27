using System.Drawing;

namespace TP_7_PGE
{
    partial class TextoBoxu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TextoBoxu
            // 
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Name = "UserControl1";
            this.Enter += new System.EventHandler(this.textBox1_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.Leave += new System.EventHandler(this.textBox1_Leave);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
