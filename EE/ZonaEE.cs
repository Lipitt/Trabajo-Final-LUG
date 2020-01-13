using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
   public class ZonaEE
    {
        public int Id_Zona { get; set; }
        public string Distrito { get; set; }
        public string Barrio { get; set; }
        public List<ClienteEE> ListaCliente = new List<ClienteEE>();
    }
}
