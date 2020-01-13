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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        UsuarioEE oUsuarioEE = new UsuarioEE();
        UsuarioBLL oUsuarioBLL = new UsuarioBLL();

        public void checkPass()
        {
            try
            {
                string user = txtUsername.Text;
                string pass = txtPassword.Text;
                bool check = oUsuarioBLL.LogIn(user, pass);
               
                if (check == true)
                {
                    MessageBox.Show("Bienvenido " + user);
                    this.Hide();
                    var ofrmMenu = new frmMenu();
                    ofrmMenu.Closed += (s, args) => this.Close();
                    ofrmMenu.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           checkPass();
        }
    }
}
