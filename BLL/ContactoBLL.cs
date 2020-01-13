using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using Mapper;

namespace BLL
{
    public class ContactoBLL
    {
        public bool Operacion(ContactoEE oContactoEE, int op)
        {
            ContactoMPP oContactoMPP = new ContactoMPP();
            return oContactoMPP.Operacion(oContactoEE, op);
        }

        public List<ContactoEE> ListarContacto()
        {
            ContactoMPP oContactoMPP = new ContactoMPP();
            return oContactoMPP.ListarContacto();
        }
    }
}
