using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EE;
using BLL;

namespace TP_Final_Lipshitz
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        ClienteBLL oCliBLL = new ClienteBLL();
        ClienteEE oCliEE = new ClienteEE();
        ContactoEE oConEE = new ContactoEE();
        ContactoBLL oConBLL = new ContactoBLL();

        private void frmCliente_Load(object sender, EventArgs e)
        {
            cargarCombo();
            cargarGrillaCliente();
            cargarGrillaContacto();
        }
        
        #region Cliente

        public enum Categoria : int
        {
            Normal = 1,
            Especial = 2,
            Premium = 3
        }

        void cargarCombo()
        {
            cboCategoria.DataSource = Enum.GetValues((typeof(Categoria)));
        }

        void cargarGrillaCliente()
        {
            try
            {
                dgvCliente.DataSource = null;
                dgvCliente.DataSource = oCliBLL.Listar();
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oCliEE = (ClienteEE)dgvCliente.CurrentRow.DataBoundItem;
            txtId_Cliente.Text = oCliEE.Id_Cliente.ToString();
            txtNombre.Text = oCliEE.Nombre.ToString();
            txtApellido.Text = oCliEE.Apellido.ToString();
            txtDNI.Text = oCliEE.DNI.ToString();
            txtFechaNac.Text = oCliEE.FechaNac.ToString();
            txtDomicilio.Text = oCliEE.Domicilio.ToString();
            cboCategoria.Text = oCliEE.Categoria.ToString();
        }

        void LimpiarCliente()
        {
            txtId_Cliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtFechaNac.Text = "";
            txtDomicilio.Text = "";
            cargarCombo();
        }

        void AsignarCliente()
        {
            try
            {
                if (txtId_Cliente.Text != "")
                { oCliEE.Id_Cliente = Convert.ToInt32(txtId_Cliente.Text); }
                else { oCliEE.Id_Cliente = 0; }

                oCliEE.Nombre = txtNombre.Text;
                oCliEE.Apellido = txtApellido.Text;
                oCliEE.DNI = Convert.ToInt32(txtDNI.Text);
                oCliEE.FechaNac = Convert.ToDateTime(txtFechaNac.Text);
                oCliEE.Domicilio = txtDomicilio.Text;
                oCliEE.Categoria = cboCategoria.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnNuevoCli_Click(object sender, EventArgs e)
        {
            try
            {
                AsignarCliente();
                oCliBLL.Operacion(oCliEE, 1);
                LimpiarCliente();
                cargarGrillaCliente();
                MessageBox.Show("Cliente agregado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModCli_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCliente.SelectedCells.Count == 1)
                { MessageBox.Show("Seleccione la fila que desea modificar"); }
                else
                {
                    AsignarCliente();
                    oCliBLL.Operacion(oCliEE, 2);
                    LimpiarCliente();
                    cargarGrillaCliente();
                    MessageBox.Show("Cliente modificado correctamente");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrarCli_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCliente.SelectedCells.Count == 1)
                { MessageBox.Show("Seleccione la fila que desea borrar"); }
                else 
                {
                    DialogResult dr = MessageBox.Show("Seguro desea eliminar a " + dgvCliente.SelectedRows[0].Cells[1].Value.ToString().Trim()
                        + " " + dgvCliente.SelectedRows[0].Cells[2].Value.ToString().Trim() + " ?" + " Esto tambien eliminara su informacion de contacto", "Eliminacion", MessageBoxButtons.YesNo);
                    {
                        if (dr == DialogResult.Yes)
                        {
                            AsignarCliente();
                            oCliBLL.Operacion(oCliEE, 3);
                            LimpiarCliente();
                            cargarGrillaCliente();
                            cargarGrillaContacto();
                            MessageBox.Show("El cliente y su contacto se han borrado correctamente");
                        }
                    }
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiarCli_Click(object sender, EventArgs e)
        {
            LimpiarCliente();
        }

        #endregion
        #region Contacto
        private void btnNuevoCon_Click(object sender, EventArgs e)
        {
            try
            {
                if (AsignarContacto())
                {   
                    oConBLL.Operacion(oConEE, 1);
                    LimpiarContacto();
                    cargarGrillaContacto();
                    MessageBox.Show("Contacto agregado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModCon_Click(object sender, EventArgs e)
        {
            try
            {
                if (AsignarContacto())
                {
                    if (dgvContacto.SelectedCells.Count == 1)
                    { MessageBox.Show("Seleccione la fila que desea modificar"); }
                    else
                    { 
                    oConBLL.Operacion(oConEE, 2);
                    LimpiarContacto();
                    cargarGrillaContacto();
                    MessageBox.Show("Contacto modificado correctametne");
                    }
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrarCon_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContacto.SelectedCells.Count == 1)
                { MessageBox.Show("Seleccione la fila que desea borrar"); }
                else
                {
                    DialogResult dr = MessageBox.Show("Seguro desea eliminar la informacion de contacto?", "Eliminacion", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        if (AsignarContacto())
                        {
                            oConBLL.Operacion(oConEE, 3);
                            LimpiarContacto();
                            cargarGrillaContacto();
                        }
                    }
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiarCon_Click(object sender, EventArgs e)
        {
            LimpiarContacto();
        }

        void cargarGrillaContacto()
        {
            try
            {
                dgvContacto.DataSource = null;
                dgvContacto.DataSource = oConBLL.ListarContacto();
                //dgvContacto.Columns["Cliente"].Visible = false;
                dgvContacto.Columns["Cliente"].Width = 250;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LimpiarContacto()
        {
            txtId_Cliente.Text = "";
            txtId_Contacto.Text = "";
            txtTelefono.Text = "";
            txtMail.Text = "";
        }

       public bool AsignarContacto()
        {
            try
            {
                if (txtId_Cliente.Text != "")
                {
                    oConEE.Telefono = Convert.ToInt32(txtTelefono.Text);
                    oConEE.Mail = txtMail.Text;
                    oConEE.Cliente.Id_Cliente = Convert.ToInt32(txtId_Cliente.Text);

                    if (txtId_Contacto.Text != "")
                    {
                        oConEE.Id_Contacto = Convert.ToInt32(txtId_Contacto.Text);
                        return true;
                    }
                    else
                    {
                        oConEE.Id_Contacto = 0;
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un cliente");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
        private void dgvContacto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oConEE = (ContactoEE)dgvContacto.CurrentRow.DataBoundItem;
            txtId_Contacto.Text = oConEE.Id_Contacto.ToString();
            txtTelefono.Text = oConEE.Telefono.ToString();
            txtMail.Text = oConEE.Mail.ToString();
            txtId_Cliente.Text = oConEE.Cliente.Id_Cliente.ToString();
        }
        #endregion
    }
}
