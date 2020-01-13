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
using System.Xml.Linq;
using System.Threading;
using System.Globalization;

namespace TP_Final_Lipshitz
{
    public partial class frmXML : Form
    {
        public frmXML()
        {
            InitializeComponent();
        }
        private void frmXML_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CargarGrillaXML();
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

        #region LeerXML
        private void btnLeerXML_Click(object sender, EventArgs e)
        {
            CargarGrillaXML();
        }

        void CargarGrillaXML()
        {
            try
            {
                dgvXML.DataSource = null;
                dgvXML.DataSource = LeerXML();
                dgvXML.Columns["Id_Venta"].Visible = false;
                dgvXML.Columns["Total"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        List<VentaEE> LeerXML()
        {
            try
            {
                var consulta =
                     from Venta in XElement.Load("TFLipshitz.xml").Elements("Venta")
                     select new VentaEE
                     {
                         Marca = Convert.ToString(Venta.Attribute("Marca").Value).Trim(),
                         Articulo = Convert.ToString(Venta.Element("Articulo").Value).Trim(),
                         Cantidad = Convert.ToInt32(Venta.Element("Cantidad").Value),
                         Precio = Convert.ToInt32(Venta.Element("Precio").Value)
                     };
                List<VentaEE> ListaVentas = consulta.ToList<VentaEE>();
                return ListaVentas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        #endregion

        #region GuardarXML

        private void btnGuardarXML_Click(object sender, EventArgs e)
        {
            GuardarXML();
        }

        private void GuardarXML()
        {
            try
            {
                XDocument xmlDoc = XDocument.Load("TFLipshitz.xml");
                xmlDoc.Element("Ventas").Add(new XElement("Venta",
                                            new XAttribute("Marca",  cboMarca.Text.Trim()),
                                            new XElement("Articulo", txtArticulo.Text.Trim()),
                                            new XElement("Cantidad", txtCantidad.Text.Trim()),
                                            new XElement("Precio", txtPrecio.Text.Trim())));
                xmlDoc.Save("TFLipshitz.xml");
                CargarGrillaXML();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

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
                lblMarca.Text = Recursos.Recurso.lblMarca;
                lblArt.Text = Recursos.Recurso.lblArt;
                lblCant.Text = Recursos.Recurso.lblCant;
                lblPrecio.Text = Recursos.Recurso.lblPrecio;
                dgvXML.Columns["Marca"].HeaderText = Recursos.Recurso.lblMarca;
                dgvXML.Columns["Articulo"].HeaderText = Recursos.Recurso.lblArt;
                dgvXML.Columns["Cantidad"].HeaderText = Recursos.Recurso.lblCant;
                dgvXML.Columns["Precio"].HeaderText = Recursos.Recurso.lblPrecio;

                btnLeerXML.Text = Recursos.Recurso.btnLeerXML;
                btnGuardarXML.Text = Recursos.Recurso.btnGuardarXML;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
