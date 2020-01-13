namespace TP_Final_Lipshitz
{
    partial class frmCliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.txtId_Cliente = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtFechaNac = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.dgvContacto = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnLimpiarCli = new System.Windows.Forms.Button();
            this.btnBorrarCli = new System.Windows.Forms.Button();
            this.btnModCli = new System.Windows.Forms.Button();
            this.btnNuevoCli = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCon = new System.Windows.Forms.Button();
            this.btnBorrarCon = new System.Windows.Forms.Button();
            this.btnModCon = new System.Windows.Forms.Button();
            this.btnNuevoCon = new System.Windows.Forms.Button();
            this.txtId_Contacto = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "FechaNac";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Domicilio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Categoria";
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(213, 19);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(503, 188);
            this.dgvCliente.TabIndex = 7;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // txtId_Cliente
            // 
            this.txtId_Cliente.Location = new System.Drawing.Point(69, 40);
            this.txtId_Cliente.Name = "txtId_Cliente";
            this.txtId_Cliente.ReadOnly = true;
            this.txtId_Cliente.Size = new System.Drawing.Size(126, 20);
            this.txtId_Cliente.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(69, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(126, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(69, 89);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(126, 20);
            this.txtApellido.TabIndex = 10;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(69, 115);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(126, 20);
            this.txtDNI.TabIndex = 11;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Location = new System.Drawing.Point(69, 142);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(126, 20);
            this.txtFechaNac.TabIndex = 12;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(69, 164);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(126, 20);
            this.txtDomicilio.TabIndex = 13;
            // 
            // dgvContacto
            // 
            this.dgvContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacto.Location = new System.Drawing.Point(213, 19);
            this.dgvContacto.Name = "dgvContacto";
            this.dgvContacto.Size = new System.Drawing.Size(503, 201);
            this.dgvContacto.TabIndex = 15;
            this.dgvContacto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacto_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCategoria);
            this.groupBox1.Controls.Add(this.btnLimpiarCli);
            this.groupBox1.Controls.Add(this.btnBorrarCli);
            this.groupBox1.Controls.Add(this.btnModCli);
            this.groupBox1.Controls.Add(this.btnNuevoCli);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvCliente);
            this.groupBox1.Controls.Add(this.txtId_Cliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDomicilio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFechaNac);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 327);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
           // this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(69, 187);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(126, 21);
            this.cboCategoria.TabIndex = 38;
            // 
            // btnLimpiarCli
            // 
            this.btnLimpiarCli.Location = new System.Drawing.Point(109, 264);
            this.btnLimpiarCli.Name = "btnLimpiarCli";
            this.btnLimpiarCli.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarCli.TabIndex = 37;
            this.btnLimpiarCli.Text = "Limpiar";
            this.btnLimpiarCli.UseVisualStyleBackColor = true;
            this.btnLimpiarCli.Click += new System.EventHandler(this.btnLimpiarCli_Click);
            // 
            // btnBorrarCli
            // 
            this.btnBorrarCli.Location = new System.Drawing.Point(28, 264);
            this.btnBorrarCli.Name = "btnBorrarCli";
            this.btnBorrarCli.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarCli.TabIndex = 36;
            this.btnBorrarCli.Text = "Borrar";
            this.btnBorrarCli.UseVisualStyleBackColor = true;
            this.btnBorrarCli.Click += new System.EventHandler(this.btnBorrarCli_Click);
            // 
            // btnModCli
            // 
            this.btnModCli.Location = new System.Drawing.Point(109, 234);
            this.btnModCli.Name = "btnModCli";
            this.btnModCli.Size = new System.Drawing.Size(75, 23);
            this.btnModCli.TabIndex = 35;
            this.btnModCli.Text = "Modificar";
            this.btnModCli.UseVisualStyleBackColor = true;
            this.btnModCli.Click += new System.EventHandler(this.btnModCli_Click);
            // 
            // btnNuevoCli
            // 
            this.btnNuevoCli.Location = new System.Drawing.Point(28, 235);
            this.btnNuevoCli.Name = "btnNuevoCli";
            this.btnNuevoCli.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoCli.TabIndex = 34;
            this.btnNuevoCli.Text = "Nuevo";
            this.btnNuevoCli.UseVisualStyleBackColor = true;
            this.btnNuevoCli.Click += new System.EventHandler(this.btnNuevoCli_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiarCon);
            this.groupBox2.Controls.Add(this.btnBorrarCon);
            this.groupBox2.Controls.Add(this.btnModCon);
            this.groupBox2.Controls.Add(this.btnNuevoCon);
            this.groupBox2.Controls.Add(this.dgvContacto);
            this.groupBox2.Controls.Add(this.txtId_Contacto);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 220);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contacto";
            // 
            // btnLimpiarCon
            // 
            this.btnLimpiarCon.Location = new System.Drawing.Point(95, 170);
            this.btnLimpiarCon.Name = "btnLimpiarCon";
            this.btnLimpiarCon.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarCon.TabIndex = 29;
            this.btnLimpiarCon.Text = "Limpiar";
            this.btnLimpiarCon.UseVisualStyleBackColor = true;
            this.btnLimpiarCon.Click += new System.EventHandler(this.btnLimpiarCon_Click);
            // 
            // btnBorrarCon
            // 
            this.btnBorrarCon.Location = new System.Drawing.Point(14, 170);
            this.btnBorrarCon.Name = "btnBorrarCon";
            this.btnBorrarCon.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarCon.TabIndex = 28;
            this.btnBorrarCon.Text = "Borrar";
            this.btnBorrarCon.UseVisualStyleBackColor = true;
            this.btnBorrarCon.Click += new System.EventHandler(this.btnBorrarCon_Click);
            // 
            // btnModCon
            // 
            this.btnModCon.Location = new System.Drawing.Point(95, 140);
            this.btnModCon.Name = "btnModCon";
            this.btnModCon.Size = new System.Drawing.Size(75, 23);
            this.btnModCon.TabIndex = 27;
            this.btnModCon.Text = "Modificar";
            this.btnModCon.UseVisualStyleBackColor = true;
            this.btnModCon.Click += new System.EventHandler(this.btnModCon_Click);
            // 
            // btnNuevoCon
            // 
            this.btnNuevoCon.Location = new System.Drawing.Point(14, 141);
            this.btnNuevoCon.Name = "btnNuevoCon";
            this.btnNuevoCon.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoCon.TabIndex = 26;
            this.btnNuevoCon.Text = "Nuevo";
            this.btnNuevoCon.UseVisualStyleBackColor = true;
            this.btnNuevoCon.Click += new System.EventHandler(this.btnNuevoCon_Click);
            // 
            // txtId_Contacto
            // 
            this.txtId_Contacto.Location = new System.Drawing.Point(82, 21);
            this.txtId_Contacto.Name = "txtId_Contacto";
            this.txtId_Contacto.ReadOnly = true;
            this.txtId_Contacto.Size = new System.Drawing.Size(113, 20);
            this.txtId_Contacto.TabIndex = 22;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(82, 47);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(113, 20);
            this.txtMail.TabIndex = 23;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(82, 77);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(113, 20);
            this.txtTelefono.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Id_Contacto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Mail";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Telefono";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.TextBox txtId_Cliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtFechaNac;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.DataGridView dgvContacto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnLimpiarCli;
        private System.Windows.Forms.Button btnBorrarCli;
        private System.Windows.Forms.Button btnModCli;
        private System.Windows.Forms.Button btnNuevoCli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimpiarCon;
        private System.Windows.Forms.Button btnBorrarCon;
        private System.Windows.Forms.Button btnModCon;
        private System.Windows.Forms.Button btnNuevoCon;
        private System.Windows.Forms.TextBox txtId_Contacto;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}