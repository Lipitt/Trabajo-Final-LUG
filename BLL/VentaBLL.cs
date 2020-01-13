using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using Mapper;
using System.Data;

namespace BLL
{
    public class VentaBLL
    {
        public DataSet ListarVentas()
        {
            VentaMPP oVentaMPP = new VentaMPP();
            return oVentaMPP.ListarVentas();
        }

        public List<VentaEE> VentaReporte(int op)
        {
            VentaMPP oVentaMPP = new VentaMPP();
            return oVentaMPP.VentaReporte(op);
        }

        public DataSet ReporteGrafico(int op)
        {
            VentaMPP oVentaMPP = new VentaMPP();
            return oVentaMPP.ReporteGrafico(op);
        }
    }
}
