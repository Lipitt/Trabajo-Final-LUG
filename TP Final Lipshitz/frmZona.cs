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
    public partial class frmZona : Form
    {
        public frmZona()
        {
            InitializeComponent();
        }

        ZonaEE oZonaEE = new ZonaEE();
        ZonaBLL oZonaBLL = new ZonaBLL();
        ClienteBLL oClienteBLL = new ClienteBLL();
       
        private void frmZona_Load(object sender, EventArgs e)
        {
            cargarGrillaZona();
            CargarComboZona();
            CargarComboCliente();
        }

        void cargarGrillaZona()
        {
            try
            {
                dgvZona.DataSource = null;
                dgvZona.DataSource = oZonaBLL.ListarZona();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AsignarZona();
            oZonaBLL.Operacion(oZonaEE, 1);
            LimpiarZona();
            cargarGrillaZona();
            CargarComboZona();
            MessageBox.Show("La zona se agrego correctamente");
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (dgvZona.SelectedCells.Count == 1)
            { MessageBox.Show("Seleccione la fila que desea modificar"); }

            else
            {
                AsignarZona();
                oZonaBLL.Operacion(oZonaEE, 2);
                LimpiarZona();
                cargarGrillaZona();
                CargarComboZona();
                MessageBox.Show("La fila fue modificada correctamente");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvZona.SelectedCells.Count == 1)
            { MessageBox.Show("Seleccione la fila que desea borrar"); }
            else { 
            DialogResult dr = MessageBox.Show("Seguro desea eliminar a " + dgvZona.SelectedRows[0].Cells[1].Value.ToString().Trim() 
                + " " + dgvZona.SelectedRows[0].Cells[2].Value.ToString().Trim() +  "  ?", "Eliminacion", MessageBoxButtons.YesNo);
                {
                    if (dr == DialogResult.Yes)
                    {
                        oZonaBLL.Operacion(oZonaEE, 3);
                        LimpiarZona();
                        cargarGrillaZona();
                        CargarComboZona();
                        MessageBox.Show("La fila fue borrada correctamente");
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarZona();
        }

        private void dgvZona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oZonaEE = (ZonaEE)dgvZona.CurrentRow.DataBoundItem;
            txtId_Zona.Text = oZonaEE.Id_Zona.ToString();
            txtDistrito.Text = oZonaEE.Distrito.ToString();
            txtBarrio.Text = oZonaEE.Barrio.ToString();
        }

        void AsignarZona()
        {
            try
            {
                if (txtId_Zona.Text != "")
                { oZonaEE.Id_Zona = Convert.ToInt32(txtId_Zona.Text); }
                else { oZonaEE.Id_Zona = 0; }

                oZonaEE.Distrito = txtDistrito.Text;
                oZonaEE.Barrio = txtBarrio.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LimpiarZona()
        {
            txtBarrio.Text = "";
            txtDistrito.Text = "";
            txtId_Zona.Text = "";
        }

        private void cboZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ZonaEE oZonaComboEE = new ZonaEE();
                oZonaComboEE = (ZonaEE)cboZona.SelectedItem;

                dgvZonaCliente.DataSource = null;
                dgvZonaCliente.DataSource = oZonaComboEE.ListaCliente;
                setearZonaCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void setearZonaCliente()
        {
            dgvZonaCliente.Columns["DNI"].Visible = false;
            dgvZonaCliente.Columns["FechaNac"].Visible = false;
            dgvZonaCliente.Columns["Categoria"].Visible = false;
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ZonaEE oZonaEE = new ZonaEE();
                oZonaEE = (ZonaEE)cboZona.SelectedItem;
                ClienteEE oCliEE = new ClienteEE();
                oCliEE = (ClienteEE)cboCliente.SelectedItem;

                oZonaBLL.AgregarCliZona(oCliEE, oZonaEE);
                CargarComboZona();
                cboZona.Text = oZonaEE.Barrio;
                MessageBox.Show("Referencia agregada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Seguro desea eliminar la relacion?", "Eliminacion", MessageBoxButtons.YesNo);
                {
                    if (dr == DialogResult.Yes)
                    {
                        ZonaEE oZonaEE = new ZonaEE();
                        oZonaEE = (ZonaEE)cboZona.SelectedItem;
                        ClienteEE oCliEE = new ClienteEE();
                        oCliEE = (ClienteEE)cboCliente.SelectedItem;

                        oZonaBLL.QuitarCliZona(oCliEE, oZonaEE);
                        CargarComboZona();
                        cboZona.Text = oZonaEE.Barrio;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void CargarComboZona()
        {
            try
            {
                cboZona.DataSource = oZonaBLL.ListarZona();
                cboZona.ValueMember = "Id_Zona";
                cboZona.DisplayMember = "Barrio";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void CargarComboCliente()
        {
            try
            {
                cboCliente.DataSource = oClienteBLL.Listar();
                cboCliente.ValueMember = "Id_Cliente";
                cboCliente.DisplayMember = "Apellido";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
