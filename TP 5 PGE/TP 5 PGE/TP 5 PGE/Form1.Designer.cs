namespace TP_5_PGE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAnti = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblTitu = new System.Windows.Forms.Label();
            this.txtboxNom = new System.Windows.Forms.TextBox();
            this.txtboxAnti = new System.Windows.Forms.TextBox();
            this.txtboxLeg = new System.Windows.Forms.TextBox();
            this.txtboxValor = new System.Windows.Forms.TextBox();
            this.txtboxTitulo = new System.Windows.Forms.TextBox();
            this.txtboxHoras = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblDir = new System.Windows.Forms.Label();
            this.cmbboxCat = new System.Windows.Forms.ComboBox();
            this.lblFacu = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmboxTipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listbox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNoDoc = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Legajo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas";
            // 
            // lblAnti
            // 
            this.lblAnti.AutoSize = true;
            this.lblAnti.Location = new System.Drawing.Point(27, 73);
            this.lblAnti.Name = "lblAnti";
            this.lblAnti.Size = new System.Drawing.Size(61, 13);
            this.lblAnti.TabIndex = 3;
            this.lblAnti.Text = "Antiguedad";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(204, 73);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(73, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor por hora";
            // 
            // lblTitu
            // 
            this.lblTitu.AutoSize = true;
            this.lblTitu.Location = new System.Drawing.Point(390, 73);
            this.lblTitu.Name = "lblTitu";
            this.lblTitu.Size = new System.Drawing.Size(33, 13);
            this.lblTitu.TabIndex = 5;
            this.lblTitu.Text = "Titulo";
            // 
            // txtboxNom
            // 
            this.txtboxNom.Location = new System.Drawing.Point(30, 40);
            this.txtboxNom.Name = "txtboxNom";
            this.txtboxNom.Size = new System.Drawing.Size(121, 20);
            this.txtboxNom.TabIndex = 1;
            this.txtboxNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxNom_KeyPress);
            // 
            // txtboxAnti
            // 
            this.txtboxAnti.Location = new System.Drawing.Point(30, 89);
            this.txtboxAnti.Name = "txtboxAnti";
            this.txtboxAnti.Size = new System.Drawing.Size(121, 20);
            this.txtboxAnti.TabIndex = 3;
            this.txtboxAnti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxAnti_KeyPress);
            // 
            // txtboxLeg
            // 
            this.txtboxLeg.Location = new System.Drawing.Point(207, 40);
            this.txtboxLeg.Name = "txtboxLeg";
            this.txtboxLeg.Size = new System.Drawing.Size(121, 20);
            this.txtboxLeg.TabIndex = 2;
            this.txtboxLeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxLeg_KeyPress);
            // 
            // txtboxValor
            // 
            this.txtboxValor.Location = new System.Drawing.Point(207, 89);
            this.txtboxValor.Name = "txtboxValor";
            this.txtboxValor.Size = new System.Drawing.Size(121, 20);
            this.txtboxValor.TabIndex = 4;
            this.txtboxValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxValor_KeyPress);
            // 
            // txtboxTitulo
            // 
            this.txtboxTitulo.Location = new System.Drawing.Point(393, 89);
            this.txtboxTitulo.Name = "txtboxTitulo";
            this.txtboxTitulo.Size = new System.Drawing.Size(121, 20);
            this.txtboxTitulo.TabIndex = 5;
            this.txtboxTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxTitulo_KeyPress);
            // 
            // txtboxHoras
            // 
            this.txtboxHoras.Location = new System.Drawing.Point(393, 40);
            this.txtboxHoras.Name = "txtboxHoras";
            this.txtboxHoras.Size = new System.Drawing.Size(121, 20);
            this.txtboxHoras.TabIndex = 3;
            this.txtboxHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxHoras_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(561, 495);
            this.tabControl1.TabIndex = 12;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblDir);
            this.tabPage1.Controls.Add(this.cmbboxCat);
            this.tabPage1.Controls.Add(this.lblFacu);
            this.tabPage1.Controls.Add(this.lblArea);
            this.tabPage1.Controls.Add(this.lblCat);
            this.tabPage1.Controls.Add(this.btnAgregar);
            this.tabPage1.Controls.Add(this.cmboxTipo);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtboxLeg);
            this.tabPage1.Controls.Add(this.txtboxHoras);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtboxTitulo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtboxValor);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblAnti);
            this.tabPage1.Controls.Add(this.txtboxAnti);
            this.tabPage1.Controls.Add(this.lblValor);
            this.tabPage1.Controls.Add(this.txtboxNom);
            this.tabPage1.Controls.Add(this.lblTitu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(553, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(357, 221);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(52, 13);
            this.lblDir.TabIndex = 14;
            this.lblDir.Text = "Direccion";
            // 
            // cmbboxCat
            // 
            this.cmbboxCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxCat.FormattingEnabled = true;
            this.cmbboxCat.ItemHeight = 13;
            this.cmbboxCat.Items.AddRange(new object[] {
            "Categoria 1",
            "Categoria 2",
            "Categoria 3"});
            this.cmbboxCat.Location = new System.Drawing.Point(59, 104);
            this.cmbboxCat.Name = "cmbboxCat";
            this.cmbboxCat.Size = new System.Drawing.Size(121, 21);
            this.cmbboxCat.TabIndex = 17;
            // 
            // lblFacu
            // 
            this.lblFacu.AutoSize = true;
            this.lblFacu.Location = new System.Drawing.Point(89, 221);
            this.lblFacu.Name = "lblFacu";
            this.lblFacu.Size = new System.Drawing.Size(48, 13);
            this.lblFacu.TabIndex = 13;
            this.lblFacu.Text = "Facultad";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(204, 73);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 16;
            this.lblArea.Text = "Area";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(27, 73);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(52, 13);
            this.lblCat.TabIndex = 15;
            this.lblCat.Text = "Categoria";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(439, 140);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmboxTipo
            // 
            this.cmboxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxTipo.FormattingEnabled = true;
            this.cmboxTipo.Items.AddRange(new object[] {
            "Docente",
            "No Docente"});
            this.cmboxTipo.Location = new System.Drawing.Point(30, 142);
            this.cmboxTipo.Name = "cmboxTipo";
            this.cmboxTipo.Size = new System.Drawing.Size(121, 21);
            this.cmboxTipo.TabIndex = 13;
            this.cmboxTipo.SelectedIndexChanged += new System.EventHandler(this.cmboxTipo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listbox);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(553, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(42, 19);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(463, 381);
            this.listbox.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNoDoc);
            this.groupBox1.Controls.Add(this.btnDoc);
            this.groupBox1.Controls.Add(this.btnAll);
            this.groupBox1.Controls.Add(this.btnErase);
            this.groupBox1.Location = new System.Drawing.Point(42, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 54);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btnNoDoc
            // 
            this.btnNoDoc.Location = new System.Drawing.Point(241, 20);
            this.btnNoDoc.Name = "btnNoDoc";
            this.btnNoDoc.Size = new System.Drawing.Size(121, 23);
            this.btnNoDoc.TabIndex = 7;
            this.btnNoDoc.Text = "Mostrar No Docentes";
            this.btnNoDoc.UseVisualStyleBackColor = true;
            this.btnNoDoc.Click += new System.EventHandler(this.btnNoDoc_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.Location = new System.Drawing.Point(124, 20);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(111, 23);
            this.btnDoc.TabIndex = 6;
            this.btnDoc.Text = "Mostrar Docentes";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(6, 20);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(112, 23);
            this.btnAll.TabIndex = 5;
            this.btnAll.Text = "Mostrar Todos";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(368, 20);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(89, 23);
            this.btnErase.TabIndex = 4;
            this.btnErase.Text = "Eliminar";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAnti;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblTitu;
        private System.Windows.Forms.TextBox txtboxNom;
        private System.Windows.Forms.TextBox txtboxAnti;
        private System.Windows.Forms.TextBox txtboxLeg;
        private System.Windows.Forms.TextBox txtboxValor;
        private System.Windows.Forms.TextBox txtboxTitulo;
        private System.Windows.Forms.TextBox txtboxHoras;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmboxTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblFacu;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.ComboBox cmbboxCat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button btnNoDoc;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

