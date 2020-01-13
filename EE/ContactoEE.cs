using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
   public class ContactoEE
    {
        public int Id_Contacto { get; set; }
        public int Telefono { get; set; }
        public string Mail { get; set; }
        public ClienteEE Cliente { get; set; } = new ClienteEE();
    }
}
