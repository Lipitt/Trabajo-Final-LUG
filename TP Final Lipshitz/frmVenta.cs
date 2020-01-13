using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EE;
using BLL;
using System.Threading;
using System.Globalization;
using System.Text.RegularExpressions;

namespace TP_Final_Lipshitz
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        DataSet DS = new DataSet();
        VentaBLL oVentaBLL = new VentaBLL();
        ClienteBLL oCliBLL = new ClienteBLL();
     
        private void frmVenta_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CargarVentas();
            CargarClientes();
            setearGrillaClientes();
        }

        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId_Venta.Text = dgvVenta.Rows[e.RowIndex].Cells[0].Value.ToString();
            cboMarca.Text = dgvVenta.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtArticulo.Text = dgvVenta.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCantidad.Text = dgvVenta.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPrecio.Text = dgvVenta.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void dgvClienteVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId_Cliente.Text = dgvClientesVentas.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        void CargarCombo()
        {
            try
            {
                cboMarca.DataSource = null;
                cboMarca.DataSource = Enum.GetValues(typeof(Marca));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public enum Marca : int
        {
            Casablanca = 1,
            Alcoyana = 2,
            Arcoiris = 3
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (Asignar())
                {
                    if (txtId_Cliente.Text == "")
                    {
                        { MessageBox.Show("Seleccione un cliente"); }
                    }

                    DataRow mDr2;
                    mDr2 = DS.Tables[0].NewRow();
                    mDr2["Marca"] = cboMarca.Text;
                    mDr2["Articulo"] = txtArticulo.Text;
                    mDr2["Cantidad"] = txtCantidad.Text;
                    mDr2["Precio"] = txtPrecio.Text;
                    mDr2["Total"] = Convert.ToInt32(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text);
                    mDr2["Id_Cliente"] = txtId_Cliente.Text;

                    DS.Tables[0].Rows.Add(mDr2);
                    Limpiar();
                    MessageBox.Show("La venta fue agregada correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void setearGrillaClientes()
        {
            dgvClientesVentas.Columns["DNI"].Visible = false;
            dgvClientesVentas.Columns["FechaNac"].Visible = false;
            dgvClientesVentas.Columns["Domicilio"].Visible = false;
        }

        void setearGrillaVentas()
        {
            dgvVenta.Columns["Id_Venta"].Width = 200;
            dgvVenta.Columns["Marca"].Width = 400;
            dgvVenta.Columns["Articulo"].Width = 400;
            dgvVenta.Columns["Cantidad"].Width = 200;
            dgvVenta.Columns["Precio"].Width = 200;
            dgvVenta.Columns["Total"].Width = 200;
            dgvVenta.Columns["Id_Cliente"].Width = 200;
        }

        void CargarClientes()
        {
            dgvClientesVentas.DataSource = null;
            dgvClientesVentas.DataSource = oCliBLL.Listar();
        }

        void CargarVentas()
        {
            DS = oVentaBLL.ListarVentas();
            dgvVenta.DataSource = null;
            dgvVenta.DataSource = DS.Tables[0];
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                if (Asignar())
                {
                    if (dgvVenta.SelectedCells.Count == 1)
                    { MessageBox.Show("Seleccione la fila que desea modificar"); }
                    else
                    {
                        DataRow mDr;
                        mDr = ((DataRowView)dgvVenta.SelectedRows[0].DataBoundItem).Row;
                        mDr["Marca"] = cboMarca.Text;
                        mDr["Articulo"] = txtArticulo.Text;
                        mDr["Cantidad"] = txtCantidad.Text;
                        mDr["Precio"] = txtPrecio.Text;
                        mDr["Total"] = Convert.ToInt32(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text);
                        mDr["Id_Cliente"] = txtId_Cliente.Text;
                        Limpiar();
                        MessageBox.Show("La venta fue modificada correctamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVenta.SelectedCells.Count == 1)
                { MessageBox.Show("Seleccione la fila(s) que desea borrar"); }
                if (dgvVenta.SelectedRows.Count > 0)
                {
                   DialogResult dr = MessageBox.Show("Seguro desea eliminar a " + dgvVenta.SelectedRows[0].Cells[1].Value.ToString().Trim() + " " + dgvVenta.SelectedRows[0].Cells[2].Value.ToString().Trim() + "?", "Eliminacion", MessageBoxButtons.YesNo);
                    {
                        if (dr == DialogResult.Yes)
                        {
                            ((DataRowView)dgvVenta.SelectedRows[0].DataBoundItem).Row.Delete();
                            MessageBox.Show("La fila fue borrada correctamente");
                        }
                    }
                }
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnGuardarBD_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Los cambios se guardaran en la base de datos. Esta seguro?", "Eliminacion", MessageBoxButtons.YesNo);
                {
                    if (dr == DialogResult.Yes)
                    {
                        SqlConnection Cnn = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = TFLipshitz; Integrated Security = True");
                        SqlDataAdapter Da = new SqlDataAdapter("Select * FROM Venta", Cnn);
                        SqlCommandBuilder Cb = new SqlCommandBuilder(Da);
                        Da.UpdateCommand = Cb.GetUpdateCommand();
                        Da.DeleteCommand = Cb.GetDeleteCommand();
                        Da.InsertCommand = Cb.GetInsertCommand();
                        Da.ContinueUpdateOnError = true;

                        Da.Update(DS.Tables[0]);
                        DS.Tables[0].Rows.Clear();
                        CargarVentas();
                    }
                    else
                    {
                        MessageBox.Show("No se guardaron los cambios");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            try
            {
                DS.RejectChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            try
            {
                DS.Tables[0].Rows.Clear();
                CargarVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVenta.SelectedRows.Count > 0)
                {
                    DataView dv = new DataView(DS.Tables[0]);
                    dv.RowFilter = ("Marca = " + "'" +  cboMarca.Text.Trim() + "'");
                    dv.Sort = "Articulo";
                    dgvVenta.DataSource = null;
                    dgvVenta.DataSource = dv;
                }
                else
                { MessageBox.Show("Debe seleccionar una fila"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Limpiar()
        {
            txtId_Cliente.Text = "";
            txtId_Venta.Text = "";
            CargarCombo();
            txtArticulo.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
        }

        public bool Asignar()
        {
            try
            {
                bool rta1, rta2, rta3;
                rta1 = Validar(txtArticulo.Text.TrimEnd(), 1, "Articulo");
                rta2 = Validar(txtCantidad.Text.Trim(), 2, "Cantidad");
                rta3 = Validar(txtPrecio.Text.Trim(), 2, "Precio");

                if (rta1 && rta2 && rta3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Validar(string palabra, int op, string Campo)
        {
            try
            {
                string patron = "";
                switch (op)
                {
                    case 1:
                        patron = "^[a-zA-Z ]+$";
                        break;
                    case 2:
                        patron = "^([0-9]+$)";
                        break;

                    case 3:
                        patron = "^([0][1-9]|[12][0-9]|3[01])(\\/|-)([0][1-9]|[1][0-2])\\2(\\d{4})$";
                        break;
                }
                bool respuesta = Regex.IsMatch(palabra, patron);
                if (respuesta == false)
                {
                    MessageBox.Show("NO corresponde con el formato ingresado ", "ERROR " + Campo);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(cboIdioma.SelectedIndex.ToString());
                switch (A)
                {
                    case 0:
                        CambiarIdioma("es-ES");
                        break;
                    case 1:
                        CambiarIdioma("en-GB");
                        break;
                    case 2:
                        CambiarIdioma("pt-BR");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void CambiarIdioma(string Cultura)
        {
            try
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(Cultura);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Cultura);

                lblIdioma.Text = Recursos.Recurso.lblIdioma;
                lblId_Venta.Text = Recursos.Recurso.lblId_Venta;
                lblMarca.Text = Recursos.Recurso.lblMarca;
                lblArticulo.Text = Recursos.Recurso.lblArt;
                lblCantidad.Text = Recursos.Recurso.lblCant;
                lblPrecio.Text = Recursos.Recurso.lblPrecio;
                lblSelecCli.Text = Recursos.Recurso.lblSelecCli;
                lblId_Cliente.Text = Recursos.Recurso.lblId_Cliente;
                dgvVenta.Columns["Id_Venta"].HeaderText = Recursos.Recurso.lblId_Venta;
                dgvVenta.Columns["Marca"].HeaderText = Recursos.Recurso.lblMarca;
                dgvVenta.Columns["Articulo"].HeaderText = Recursos.Recurso.lblArt;
                dgvVenta.Columns["Cantidad"].HeaderText = Recursos.Recurso.lblCant;
                dgvVenta.Columns["Precio"].HeaderText = Recursos.Recurso.lblPrecio;
                dgvVenta.Columns["Total"].HeaderText = Recursos.Recurso.lblTotal;
                dgvVenta.Columns["Id_Cliente"].HeaderText = Recursos.Recurso.lblId_Cliente;
                dgvClientesVentas.Columns["Id_Cliente"].HeaderText = Recursos.Recurso.lblId_Cliente;
                dgvClientesVentas.Columns["Nombre"].HeaderText = Recursos.Recurso.lblNombre;
                dgvClientesVentas.Columns["Apellido"].HeaderText = Recursos.Recurso.lblApellido;
                dgvClientesVentas.Columns["Categoria"].HeaderText = Recursos.Recurso.lblCategoria;

                btnNuevo.Text = Recursos.Recurso.btnNuevoCli;
                btnMod.Text = Recursos.Recurso.btnModCli;
                btnBorrar.Text = Recursos.Recurso.btnBorrarCli;
                btnLimpiar.Text = Recursos.Recurso.btnLimpiarCli;
                btnGuardarBD.Text = Recursos.Recurso.btnGuardarBD;
                btnDescartar.Text = Recursos.Recurso.btnDescartar;
                btnRecargar.Text = Recursos.Recurso.btnRecargar;
                btnFiltrar.Text = Recursos.Recurso.btnFiltrar;
                this.Text = Recursos.Recurso.Titulo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
