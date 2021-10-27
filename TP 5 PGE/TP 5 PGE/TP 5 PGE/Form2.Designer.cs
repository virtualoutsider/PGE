namespace TP_5_PGE
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxFacu = new System.Windows.Forms.TextBox();
            this.txtboxDir = new System.Windows.Forms.TextBox();
            this.btnReady = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la Facultad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion:";
            // 
            // txtboxFacu
            // 
            this.txtboxFacu.Location = new System.Drawing.Point(87, 58);
            this.txtboxFacu.Name = "txtboxFacu";
            this.txtboxFacu.Size = new System.Drawing.Size(114, 20);
            this.txtboxFacu.TabIndex = 2;
            // 
            // txtboxDir
            // 
            this.txtboxDir.Location = new System.Drawing.Point(87, 110);
            this.txtboxDir.Name = "txtboxDir";
            this.txtboxDir.Size = new System.Drawing.Size(114, 20);
            this.txtboxDir.TabIndex = 3;
            // 
            // btnReady
            // 
            this.btnReady.Location = new System.Drawing.Point(220, 167);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(75, 23);
            this.btnReady.TabIndex = 4;
            this.btnReady.Text = "Listo";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 223);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.txtboxDir);
            this.Controls.Add(this.txtboxFacu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Ingreso Facultad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxFacu;
        private System.Windows.Forms.TextBox txtboxDir;
        private System.Windows.Forms.Button btnReady;
    }
}