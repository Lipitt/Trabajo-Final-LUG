using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP_Final_Lipshitz
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        VentaBLL oVentaBLL = new VentaBLL();
        DataSet DS = new DataSet();

        private void button1_Click(object sender, EventArgs e)
        {
            cargarControles(1);
        }

        private void btnMenorMonto_Click(object sender, EventArgs e)
        {
            cargarControles(2);
        }

        private void btnRecaudado_Click(object sender, EventArgs e)
        {
            cargarControles(3);
            setearGrilla();
        }

        void cargarControles(int op)
        {
            try
            {
                dgvReportes.DataSource = null;
                dgvReportes.DataSource = oVentaBLL.VentaReporte(op);
                cargarGrafico(op);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void setearGrilla()
        {
            dgvReportes.Columns["Id_Venta"].Visible = false;
            dgvReportes.Columns["Articulo"].Visible = false;
            dgvReportes.Columns["Cantidad"].Visible = false;
            dgvReportes.Columns["Precio"].Visible = false;
        }

        void cargarGrafico(int op)
        {
            try
            {
                DS = oVentaBLL.ReporteGrafico(op);
                DataView view = new DataView(DS.Tables[0]);
                if (op != 3)
                {
                    chart1.Series[0].ChartType = SeriesChartType.Pie;
                    chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
                    chart1.Series[0].Points.DataBindXY(view, "Articulo", view, "Precio");
                }else
                {
                    chart1.Series[0].ChartType = SeriesChartType.Bar;
                    chart1.ChartAreas[0].Area3DStyle.Enable3D = false;
                    chart1.Series[0].Points.DataBindXY(view, "Marca", view, "Recaudado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
