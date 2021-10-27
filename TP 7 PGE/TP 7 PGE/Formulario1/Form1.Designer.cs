namespace Formulario1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoBoxu1 = new TP_7_PGE.TextoBoxu();
            this.labelu1 = new TP_7_PGE.Labelu();
            this.SuspendLayout();
            // 
            // textoBoxu1
            // 
            this.textoBoxu1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textoBoxu1.Location = new System.Drawing.Point(27, 30);
            this.textoBoxu1.Name = "textoBoxu1";
            this.textoBoxu1.Size = new System.Drawing.Size(100, 27);
            this.textoBoxu1.TabIndex = 0;
            // 
            // labelu1
            // 
            this.labelu1.AutoSize = true;
            this.labelu1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelu1.Location = new System.Drawing.Point(27, 96);
            this.labelu1.Name = "labelu1";
            this.labelu1.Size = new System.Drawing.Size(60, 19);
            this.labelu1.TabIndex = 1;
            this.labelu1.Text = "labelu1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelu1);
            this.Controls.Add(this.textoBoxu1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TP_7_PGE.TextoBoxu textoBoxu1;
        private TP_7_PGE.Labelu labelu1;
    }
}

