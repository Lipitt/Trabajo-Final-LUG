using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Final_Lipshitz
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente ofCli = new frmCliente();
            ofCli.MdiParent = this;
            ofCli.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenta ofVenta = new frmVenta();
            ofVenta.MdiParent = this;
            ofVenta.Show();
        }

        private void zonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZona ofZona = new frmZona();
            ofZona.MdiParent = this;
            ofZona.Show();
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXML ofXML = new frmXML();
            ofXML.MdiParent = this;
            ofXML.Show();
        }
   
        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportes ofReportes = new frmReportes();
            ofReportes.MdiParent = this;
            ofReportes.Show();
        }
     
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario ofUsuario = new frmUsuario();
            ofUsuario.MdiParent = this;
            ofUsuario.Show();
        }
    }
}
