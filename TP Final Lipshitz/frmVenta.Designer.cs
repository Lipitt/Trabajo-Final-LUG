namespace TP_Final_Lipshitz
{
    partial class frmVenta
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.txtId_Venta = new System.Windows.Forms.TextBox();
            this.lblId_Venta = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.btnGuardarBD = new System.Windows.Forms.Button();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtId_Cliente = new System.Windows.Forms.TextBox();
            this.lblId_Cliente = new System.Windows.Forms.Label();
            this.dgvClientesVentas = new System.Windows.Forms.DataGridView();
            this.lblSelecCli = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(65, 57);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(126, 21);
            this.cboMarca.TabIndex = 57;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(105, 257);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 56;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(24, 257);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 55;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(105, 227);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 54;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(24, 228);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 53;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(7, 135);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 43;
            this.lblPrecio.Text = "Precio";
            // 
            // dgvVenta
            // 
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Location = new System.Drawing.Point(209, 12);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.Size = new System.Drawing.Size(503, 188);
            this.dgvVenta.TabIndex = 46;
            this.dgvVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellContentClick);
            // 
            // txtId_Venta
            // 
            this.txtId_Venta.Location = new System.Drawing.Point(65, 33);
            this.txtId_Venta.Name = "txtId_Venta";
            this.txtId_Venta.ReadOnly = true;
            this.txtId_Venta.Size = new System.Drawing.Size(126, 20);
            this.txtId_Venta.TabIndex = 47;
            // 
            // lblId_Venta
            // 
            this.lblId_Venta.AutoSize = true;
            this.lblId_Venta.Location = new System.Drawing.Point(7, 33);
            this.lblId_Venta.Name = "lblId_Venta";
            this.lblId_Venta.Size = new System.Drawing.Size(50, 13);
            this.lblId_Venta.TabIndex = 39;
            this.lblId_Venta.Text = "Id_Venta";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(7, 57);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 40;
            this.lblMarca.Text = "Marca";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(65, 135);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(126, 20);
            this.txtPrecio.TabIndex = 51;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(7, 84);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(42, 13);
            this.lblArticulo.TabIndex = 41;
            this.lblArticulo.Text = "Articulo";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(65, 108);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(126, 20);
            this.txtCantidad.TabIndex = 50;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(7, 108);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 42;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(65, 82);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(126, 20);
            this.txtArticulo.TabIndex = 49;
            // 
            // btnGuardarBD
            // 
            this.btnGuardarBD.Location = new System.Drawing.Point(209, 228);
            this.btnGuardarBD.Name = "btnGuardarBD";
            this.btnGuardarBD.Size = new System.Drawing.Size(149, 23);
            this.btnGuardarBD.TabIndex = 58;
            this.btnGuardarBD.Text = "Guardar en BD";
            this.btnGuardarBD.UseVisualStyleBackColor = true;
            this.btnGuardarBD.Click += new System.EventHandler(this.btnGuardarBD_Click);
            // 
            // btnDescartar
            // 
            this.btnDescartar.Location = new System.Drawing.Point(364, 227);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(173, 23);
            this.btnDescartar.TabIndex = 59;
            this.btnDescartar.Text = "Descartar cambios";
            this.btnDescartar.UseVisualStyleBackColor = true;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(543, 227);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(169, 23);
            this.btnRecargar.TabIndex = 60;
            this.btnRecargar.Text = "Volver a cargar datos";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(24, 298);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(156, 23);
            this.btnFiltrar.TabIndex = 61;
            this.btnFiltrar.Text = "Filtrar por marca";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtId_Cliente
            // 
            this.txtId_Cliente.Location = new System.Drawing.Point(65, 187);
            this.txtId_Cliente.Name = "txtId_Cliente";
            this.txtId_Cliente.ReadOnly = true;
            this.txtId_Cliente.Size = new System.Drawing.Size(126, 20);
            this.txtId_Cliente.TabIndex = 63;
            // 
            // lblId_Cliente
            // 
            this.lblId_Cliente.AutoSize = true;
            this.lblId_Cliente.Location = new System.Drawing.Point(2, 190);
            this.lblId_Cliente.Name = "lblId_Cliente";
            this.lblId_Cliente.Size = new System.Drawing.Size(54, 13);
            this.lblId_Cliente.TabIndex = 62;
            this.lblId_Cliente.Text = "Id_Cliente";
            // 
            // dgvClientesVentas
            // 
            this.dgvClientesVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesVentas.Location = new System.Drawing.Point(209, 312);
            this.dgvClientesVentas.Name = "dgvClientesVentas";
            this.dgvClientesVentas.Size = new System.Drawing.Size(503, 138);
            this.dgvClientesVentas.TabIndex = 64;
            this.dgvClientesVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClienteVenta_CellContentClick);
            // 
            // lblSelecCli
            // 
            this.lblSelecCli.AutoSize = true;
            this.lblSelecCli.Location = new System.Drawing.Point(206, 296);
            this.lblSelecCli.Name = "lblSelecCli";
            this.lblSelecCli.Size = new System.Drawing.Size(98, 13);
            this.lblSelecCli.TabIndex = 65;
            this.lblSelecCli.Text = "Seleccionar Cliente";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(6, 9);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(38, 13);
            this.lblIdioma.TabIndex = 66;
            this.lblIdioma.Text = "Idioma";
            // 
            // cboIdioma
            // 
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.Items.AddRange(new object[] {
            "Español",
            "Ingles",
            "Portugues"});
            this.cboIdioma.Location = new System.Drawing.Point(65, 6);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(126, 21);
            this.cboIdioma.TabIndex = 67;
            this.cboIdioma.SelectedIndexChanged += new System.EventHandler(this.cboIdioma_SelectedIndexChanged);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 481);
            this.Controls.Add(this.cboIdioma);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblSelecCli);
            this.Controls.Add(this.dgvClientesVentas);
            this.Controls.Add(this.txtId_Cliente);
            this.Controls.Add(this.lblId_Cliente);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.btnGuardarBD);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.txtId_Venta);
            this.Controls.Add(this.lblId_Venta);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtArticulo);
            this.Name = "frmVenta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.TextBox txtId_Venta;
        private System.Windows.Forms.Label lblId_Venta;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Button btnGuardarBD;
        private System.Windows.Forms.Button btnDescartar;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtId_Cliente;
        private System.Windows.Forms.Label lblId_Cliente;
        private System.Windows.Forms.DataGridView dgvClientesVentas;
        private System.Windows.Forms.Label lblSelecCli;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.ComboBox cboIdioma;
    }
}