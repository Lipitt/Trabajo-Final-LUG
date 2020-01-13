namespace TP_Final_Lipshitz
{
    partial class frmXML
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
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.btnGuardarXML = new System.Windows.Forms.Button();
            this.btnLeerXML = new System.Windows.Forms.Button();
            this.dgvXML = new System.Windows.Forms.DataGridView();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblArt = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXML)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(83, 37);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(126, 21);
            this.cboMarca.TabIndex = 64;
            // 
            // btnGuardarXML
            // 
            this.btnGuardarXML.Location = new System.Drawing.Point(469, 58);
            this.btnGuardarXML.Name = "btnGuardarXML";
            this.btnGuardarXML.Size = new System.Drawing.Size(87, 23);
            this.btnGuardarXML.TabIndex = 63;
            this.btnGuardarXML.Text = "Guardar XML";
            this.btnGuardarXML.UseVisualStyleBackColor = true;
            this.btnGuardarXML.Click += new System.EventHandler(this.btnGuardarXML_Click);
            // 
            // btnLeerXML
            // 
            this.btnLeerXML.Location = new System.Drawing.Point(469, 30);
            this.btnLeerXML.Name = "btnLeerXML";
            this.btnLeerXML.Size = new System.Drawing.Size(87, 23);
            this.btnLeerXML.TabIndex = 62;
            this.btnLeerXML.Text = "Leer XML";
            this.btnLeerXML.UseVisualStyleBackColor = true;
            this.btnLeerXML.Click += new System.EventHandler(this.btnLeerXML_Click);
            // 
            // dgvXML
            // 
            this.dgvXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXML.Location = new System.Drawing.Point(40, 114);
            this.dgvXML.Name = "dgvXML";
            this.dgvXML.Size = new System.Drawing.Size(503, 188);
            this.dgvXML.TabIndex = 58;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(311, 60);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(126, 20);
            this.txtPrecio.TabIndex = 61;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(311, 36);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(126, 20);
            this.txtCantidad.TabIndex = 60;
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(83, 60);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(126, 20);
            this.txtArticulo.TabIndex = 59;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(215, 70);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 68;
            this.lblPrecio.Text = "Precio";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(17, 40);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 65;
            this.lblMarca.Text = "Marca";
            // 
            // lblArt
            // 
            this.lblArt.AutoSize = true;
            this.lblArt.Location = new System.Drawing.Point(17, 68);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(42, 13);
            this.lblArt.TabIndex = 66;
            this.lblArt.Text = "Articulo";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(215, 44);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(49, 13);
            this.lblCant.TabIndex = 67;
            this.lblCant.Text = "Cantidad";
            // 
            // cboIdioma
            // 
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.Items.AddRange(new object[] {
            "Español",
            "Ingles",
            "Portugues"});
            this.cboIdioma.Location = new System.Drawing.Point(83, 9);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(126, 21);
            this.cboIdioma.TabIndex = 70;
            this.cboIdioma.SelectedIndexChanged += new System.EventHandler(this.cboIdioma_SelectedIndexChanged);
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(16, 12);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(38, 13);
            this.lblIdioma.TabIndex = 69;
            this.lblIdioma.Text = "Idioma";
            // 
            // frmXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 431);
            this.Controls.Add(this.cboIdioma);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblArt);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.btnGuardarXML);
            this.Controls.Add(this.btnLeerXML);
            this.Controls.Add(this.dgvXML);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtArticulo);
            this.Name = "frmXML";
            this.Text = "XML";
            this.Load += new System.EventHandler(this.frmXML_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXML)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Button btnGuardarXML;
        private System.Windows.Forms.Button btnLeerXML;
        private System.Windows.Forms.DataGridView dgvXML;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.Label lblCant;
        public System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cboIdioma;
        private System.Windows.Forms.Label lblIdioma;
    }
}