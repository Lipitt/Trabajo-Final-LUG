using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper;
using EE;
using System.Data;

namespace BLL
{
   public class UsuarioBLL : PersonaBLL
    {
        public new List<UsuarioEE> Listar()
        {
            UsuarioMPP oUsuarioMPP = new UsuarioMPP();
            return oUsuarioMPP.ListarUsuario();
        }

        public bool Operacion(UsuarioEE oUsuarioEE, int op)
        {
            UsuarioMPP oUsuarioMPP = new UsuarioMPP();
            return oUsuarioMPP.Operacion(oUsuarioEE, op);
        }

        public bool LogIn(string user, string pass)
        {
            UsuarioMPP oUsuarioMPP = new UsuarioMPP();
            return oUsuarioMPP.LogIn(user, pass);
        }
    }
}
