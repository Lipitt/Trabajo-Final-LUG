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
    public class ZonaBLL
    {
        public List<ZonaEE> ListarZona()
        {
            ZonaMPP oZonaMPP = new ZonaMPP();
            return oZonaMPP.ListarZona();
        }
     
        public bool AgregarCliZona(ClienteEE oClienteEE, ZonaEE oZonaEE)
        {
            ZonaMPP oZonaMPP = new ZonaMPP();
            return oZonaMPP.AgregarCliZona(oClienteEE, oZonaEE);
        }

        public bool QuitarCliZona(ClienteEE oClienteEE, ZonaEE oZonaEE)
        {
            ZonaMPP oZonaMPP = new ZonaMPP();
            return oZonaMPP.QuitarCliZona(oClienteEE, oZonaEE);
        }

        public bool Operacion(ZonaEE oZonaEE, int op)
        {
            ZonaMPP oZonaMPP = new ZonaMPP();
            return oZonaMPP.Operacion(oZonaEE, op);
        }
    }
}
