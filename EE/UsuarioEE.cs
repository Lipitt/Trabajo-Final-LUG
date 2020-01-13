using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
   public class UsuarioEE : PersonaEE
    {
        public int Id_Usuario { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public UsuarioEE() {}

        public UsuarioEE(int codigo, string usuario, string contraseña)
        {
            Id_Usuario = codigo;
            Username = usuario;
            Password = contraseña;
        }
    }
}
