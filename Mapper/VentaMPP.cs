using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using DataLayer.Leer;
using System.Data;
using System.Windows.Forms;

namespace Mapper
{
    public class VentaMPP
    {
        LeerDatos oLeerDatos = new LeerDatos();
        public DataSet ListarVentas()
        {
            return oLeerDatos.Leer("sp_ListarVentas", null);
        }

        public DataSet ReporteGrafico(int op)
        {
            string consulta = "";
            switch (op)
            {
                case 1:
                    consulta = "sp_repMayorMonto";
                    break;
                case 2:
                    consulta = "sp_repMenorMonto";
                    break;
                case 3:
                    consulta = "sp_repRecaudadoPorMarca";
                    break;
                default:
                    consulta = null;
                    break;
            }
            return oLeerDatos.Leer(consulta, null);
        }

        public List<VentaEE> VentaReporte(int op)
        {
            try
            {
                DataSet DS = new DataSet();
                List<VentaEE> ListaReporte = new List<VentaEE>();
                string Consulta = null;
                switch (op)
                {
                    case 1:
                        Consulta = "sp_repMayorMonto";
                        break;
                    case 2:
                        Consulta = "sp_repMenorMonto";
                        break;
                    case 3:
                        Consulta = "sp_repRecaudadoPorMarca";
                        break;
                    default:
                        Consulta = null;
                        break;
                }
                DS = oLeerDatos.Leer(Consulta, null);

                if (op != 3)
                {
                    if ((DS.Tables[0].Rows.Count > 0))
                    {
                        foreach (DataRow Item in DS.Tables[0].Rows)
                        {
                            VentaEE oVentaEE = new VentaEE();
                            oVentaEE.Id_Venta = Convert.ToInt32(Item["Id_Venta"]);
                            oVentaEE.Marca = Item["Marca"].ToString();
                            oVentaEE.Articulo = Item["Articulo"].ToString();
                            oVentaEE.Cantidad = Convert.ToInt32(Item["Cantidad"]);
                            oVentaEE.Precio = Convert.ToInt32(Item["Precio"]);
                            oVentaEE.Total = Convert.ToInt32(Item["Total"]);
                            ListaReporte.Add(oVentaEE);
                        }
                        return ListaReporte;
                    }
                    else
                    { return null; }
                }
                else if ((DS.Tables[0].Rows.Count > 0))
                {
                    foreach (DataRow Item in DS.Tables[0].Rows)
                    {
                        VentaEE oVentaEE = new VentaEE();
                        oVentaEE.Marca = Item["Marca"].ToString();
                        oVentaEE.Total = Convert.ToInt32(Item["Recaudado"]);
                        ListaReporte.Add(oVentaEE);
                    }
                    return ListaReporte;
                }
                else
                { return null; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
