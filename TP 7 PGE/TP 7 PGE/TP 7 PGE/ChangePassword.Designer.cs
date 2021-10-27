namespace TP_7_PGE
{
    partial class ChangePassword
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
            this.textoBoxu2 = new TP_7_PGE.TextoBoxu();
            this.textoBoxu1 = new TP_7_PGE.TextoBoxu();
            this.labelu2 = new TP_7_PGE.Labelu();
            this.labelu1 = new TP_7_PGE.Labelu();
            this.botan1 = new TP_7_PGE.Botan();
            this.botan2 = new TP_7_PGE.Botan();
            this.SuspendLayout();
            // 
            // textoBoxu2
            // 
            this.textoBoxu2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textoBoxu2.Location = new System.Drawing.Point(162, 60);
            this.textoBoxu2.Name = "textoBoxu2";
            this.textoBoxu2.Size = new System.Drawing.Size(100, 27);
            this.textoBoxu2.TabIndex = 3;
            // 
            // textoBoxu1
            // 
            this.textoBoxu1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textoBoxu1.Location = new System.Drawing.Point(162, 27);
            this.textoBoxu1.Name = "textoBoxu1";
            this.textoBoxu1.Size = new System.Drawing.Size(100, 27);
            this.textoBoxu1.TabIndex = 2;
            // 
            // labelu2
            // 
            this.labelu2.AutoSize = true;
            this.labelu2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelu2.Location = new System.Drawing.Point(3, 63);
            this.labelu2.Name = "labelu2";
            this.labelu2.Size = new System.Drawing.Size(143, 19);
            this.labelu2.TabIndex = 1;
            this.labelu2.Text = "Nueva Contraseña:";
            // 
            // labelu1
            // 
            this.labelu1.AutoSize = true;
            this.labelu1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelu1.Location = new System.Drawing.Point(3, 30);
            this.labelu1.Name = "labelu1";
            this.labelu1.Size = new System.Drawing.Size(143, 19);
            this.labelu1.TabIndex = 0;
            this.labelu1.Text = "Actual Contraseña:";
            // 
            // botan1
            // 
            this.botan1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.botan1.Location = new System.Drawing.Point(73, 113);
            this.botan1.Name = "botan1";
            this.botan1.Size = new System.Drawing.Size(93, 30);
            this.botan1.TabIndex = 4;
            this.botan1.Text = "Confirmar";
            this.botan1.UseVisualStyleBackColor = true;
            // 
            // botan2
            // 
            this.botan2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.botan2.Location = new System.Drawing.Point(182, 113);
            this.botan2.Name = "botan2";
            this.botan2.Size = new System.Drawing.Size(80, 30);
            this.botan2.TabIndex = 5;
            this.botan2.Text = "Cancelar";
            this.botan2.UseVisualStyleBackColor = true;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.botan2);
            this.Controls.Add(this.botan1);
            this.Controls.Add(this.textoBoxu2);
            this.Controls.Add(this.textoBoxu1);
            this.Controls.Add(this.labelu2);
            this.Controls.Add(this.labelu1);
            this.Name = "ChangePassword";
            this.Size = new System.Drawing.Size(282, 164);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Labelu labelu1;
        private Labelu labelu2;
        private TextoBoxu textoBoxu1;
        private TextoBoxu textoBoxu2;
        private Botan botan1;
        private Botan botan2;

        public Labelu Labelu1 { get => labelu1; set => labelu1 = value; }
        public Labelu Labelu2 { get => labelu2; set => labelu2 = value; }
        public TextoBoxu TextoBoxu1 { get => textoBoxu1; set => textoBoxu1 = value; }
        public TextoBoxu TextoBoxu2 { get => textoBoxu2; set => textoBoxu2 = value; }
        public Botan Botan1 { get => botan1; set => botan1 = value; }
        public Botan Botan2 { get => botan2; set => botan2 = value; }
    }
}
