namespace TP_6_PGE___Juego
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
            this.components = new System.ComponentModel.Container();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.responsetimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.juegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niveltxt1 = new System.Windows.Forms.ToolStripMenuItem();
            this.niveltxt2 = new System.Windows.Forms.ToolStripMenuItem();
            this.niveltxt3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tiempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoJugarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(237, 243);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Jugar";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(237, 272);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(309, 37);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(150, 150);
            this.btn2.TabIndex = 2;
            this.btn2.Tag = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.boton_Click);
            this.btn2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn2_MouseDown);
            this.btn2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn2_MouseUp);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(309, 349);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(150, 150);
            this.btn6.TabIndex = 3;
            this.btn6.Tag = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.boton_Click);
            this.btn6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn6_MouseDown);
            this.btn6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn6_MouseUp);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(364, 193);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(150, 150);
            this.btn4.TabIndex = 4;
            this.btn4.Tag = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.boton_Click);
            this.btn4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn4_MouseDown);
            this.btn4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn4_MouseUp);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(33, 193);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(150, 150);
            this.btn3.TabIndex = 7;
            this.btn3.Tag = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.boton_Click);
            this.btn3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn3_MouseDown);
            this.btn3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn3_MouseUp);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(96, 349);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(150, 150);
            this.btn5.TabIndex = 6;
            this.btn5.Tag = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.boton_Click);
            this.btn5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn5_MouseDown);
            this.btn5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn5_MouseUp);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(96, 37);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(150, 150);
            this.btn1.TabIndex = 5;
            this.btn1.Tag = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.boton_Click);
            this.btn1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseDown);
            this.btn1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseUp);
            // 
            // responsetimer
            // 
            this.responsetimer.Interval = 5000;
            this.responsetimer.Tick += new System.EventHandler(this.responsetimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.juegoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(566, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // juegoToolStripMenuItem
            // 
            this.juegoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jugarToolStripMenuItem});
            this.juegoToolStripMenuItem.Name = "juegoToolStripMenuItem";
            this.juegoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.juegoToolStripMenuItem.Text = "Juego";
            // 
            // jugarToolStripMenuItem
            // 
            this.jugarToolStripMenuItem.Name = "jugarToolStripMenuItem";
            this.jugarToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.jugarToolStripMenuItem.Text = "Jugar";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nivelesToolStripMenuItem,
            this.tiempoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // nivelesToolStripMenuItem
            // 
            this.nivelesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.niveltxt1,
            this.niveltxt2,
            this.niveltxt3});
            this.nivelesToolStripMenuItem.Name = "nivelesToolStripMenuItem";
            this.nivelesToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.nivelesToolStripMenuItem.Text = "Niveles";
            // 
            // niveltxt1
            // 
            this.niveltxt1.Name = "niveltxt1";
            this.niveltxt1.Size = new System.Drawing.Size(159, 22);
            this.niveltxt1.Text = "5";
            this.niveltxt1.Click += new System.EventHandler(this.niveltxt1_Click);
            // 
            // niveltxt2
            // 
            this.niveltxt2.Name = "niveltxt2";
            this.niveltxt2.Size = new System.Drawing.Size(159, 22);
            this.niveltxt2.Text = "10";
            this.niveltxt2.Click += new System.EventHandler(this.niveltxt2_Click);
            // 
            // niveltxt3
            // 
            this.niveltxt3.Name = "niveltxt3";
            this.niveltxt3.Size = new System.Drawing.Size(159, 22);
            this.niveltxt3.Text = "Maximo posible";
            this.niveltxt3.Click += new System.EventHandler(this.niveltxt3_Click);
            // 
            // tiempoToolStripMenuItem
            // 
            this.tiempoToolStripMenuItem.Name = "tiempoToolStripMenuItem";
            this.tiempoToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.tiempoToolStripMenuItem.Text = "Tiempo";
            this.tiempoToolStripMenuItem.Click += new System.EventHandler(this.tiempoToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comoJugarToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // comoJugarToolStripMenuItem
            // 
            this.comoJugarToolStripMenuItem.Name = "comoJugarToolStripMenuItem";
            this.comoJugarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comoJugarToolStripMenuItem.Text = "Como Jugar";
            this.comoJugarToolStripMenuItem.Click += new System.EventHandler(this.comoJugarToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informacionToolStripMenuItem.Text = "Informacion";
            this.informacionToolStripMenuItem.Click += new System.EventHandler(this.informacionToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 522);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Timer responsetimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem juegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivelesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niveltxt1;
        private System.Windows.Forms.ToolStripMenuItem niveltxt2;
        private System.Windows.Forms.ToolStripMenuItem niveltxt3;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoJugarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiempoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
    }
}

