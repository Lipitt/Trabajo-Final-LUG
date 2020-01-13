using EE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Text.RegularExpressions;

namespace TP_Final_Lipshitz
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        UsuarioEE oUsuarioEE = new UsuarioEE();
        UsuarioBLL oUsuarioBLL = new UsuarioBLL();

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            cargarGrillaUsuario();
        }

        void cargarGrillaUsuario()
        {
            try
            {
                dgvUsuario.DataSource = null;
                dgvUsuario.DataSource = oUsuarioBLL.Listar();
                dgvUsuario.Columns["Password"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oUsuarioEE = (UsuarioEE)dgvUsuario.CurrentRow.DataBoundItem;
            txtId_Usuario.Text = oUsuarioEE.Id_Usuario.ToString();
            txtNombre.Text = oUsuarioEE.Nombre.ToString();
            txtApellido.Text = oUsuarioEE.Apellido.ToString();
            txtDNI.Text = oUsuarioEE.DNI.ToString();
            txtFechaNac.Text = oUsuarioEE.FechaNac.ToString();
            txtUsuario.Text = oUsuarioEE.Username.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (Asignar() == true && comprobarContraseña() == true)
            {
                oUsuarioBLL.Operacion(oUsuarioEE, 1);
                cargarGrillaUsuario();
                Limpiar();
                MessageBox.Show("El usuario se ha agregado correctamente");
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedCells.Count == 1)
            { MessageBox.Show("Seleccione la fila que desea modificar");}
            else if (comprobarUsuario() == true && Asignar() == true)
            {
                oUsuarioBLL.Operacion(oUsuarioEE, 2);
                cargarGrillaUsuario();
                Limpiar();
                MessageBox.Show("El usuario se ha modificado correctamente");
            }
         }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedCells.Count == 1)
            { MessageBox.Show("Seleccione la fila que desea borrar"); }
            else if (comprobarUsuario() == true)
            {
                DialogResult dr = MessageBox.Show("Seguro desea eliminar a " + dgvUsuario.SelectedRows[0].Cells[1].Value.ToString().Trim() + " ?", "Eliminacion", MessageBoxButtons.YesNo);
                {
                    if (dr == DialogResult.Yes)
                    {
                        AsignarId();
                        oUsuarioBLL.Operacion(oUsuarioEE, 3);
                        cargarGrillaUsuario();
                        Limpiar();
                        MessageBox.Show("El usuario se ha borrado correctamente");
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void AsignarId()
        {
            try
            {
                oUsuarioEE.Id_Usuario = Convert.ToInt32(txtId_Usuario.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool Asignar()
        {
            try
            {
                bool rta1, rta2, rta3, rta4;
                rta1 = Validar(txtNombre.Text.Trim(), 1, "Nombre");
                rta2 = Validar(txtApellido.Text.Trim(), 1, "Apellido");
                rta3 = Validar(txtDNI.Text.Trim(), 2, "DNI");
                rta4 = Validar(txtFechaNac.Text.Trim(), 3, "FechaNac");

                if (rta1 && rta2 && rta3 && rta4)
                {
                    if (txtId_Usuario.Text != "")
                    { oUsuarioEE.Id_Usuario = Convert.ToInt32(txtId_Usuario.Text); }
                    else { oUsuarioEE.Id_Usuario = 0; }

                    oUsuarioEE.Nombre = txtNombre.Text;
                    oUsuarioEE.Apellido = txtApellido.Text;
                    oUsuarioEE.DNI = Convert.ToInt32(txtDNI.Text);
                    oUsuarioEE.FechaNac = Convert.ToDateTime(txtFechaNac.Text);
                    oUsuarioEE.Username = txtUsuario.Text;
                    oUsuarioEE.Password = txtPass1.Text;
                    return true;
                }
                return false;
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
                        patron = "^[a-zA-Z]+$";
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

        void Limpiar()
        {
            txtId_Usuario.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtFechaNac.Text = "";
            txtUsuario.Text = "";
            txtPass1.Text = "";
            txtPassC.Text = "";
        }

        public bool comprobarUsuario()
        {
            string user = txtUsuario.Text;
            string pass = txtPass1.Text;
            if (oUsuarioBLL.LogIn(user, pass))
            {
                if (comprobarContraseña())
                {
                    return true;
                }else
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
                return false;
            }
           
        }public bool comprobarContraseña()
        {
            if (txtPass1.Text != txtPassC.Text && txtPass1.Text != "" && txtPassC.Text != "")
            {
                MessageBox.Show("Contraseñas no coinciden");
                return false;
            }else
            {
                return true;
            }
        }
    }
}
