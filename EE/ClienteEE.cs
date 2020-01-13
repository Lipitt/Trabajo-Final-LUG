using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public  class ClienteEE : PersonaEE
    {
        public int Id_Cliente { get; set; }
        public string Domicilio { get; set; }
        public string Categoria { get; set; }

        public ClienteEE() {}

        public ClienteEE(int codigo, string domicilio, string cat)
        {
            Id_Cliente = codigo;
            Domicilio = domicilio;
            Categoria = cat;
        }
        
        public override string ToString()
        {
            return "Id_Cliente: " + Id_Cliente + " Nombre: " + Nombre + " Apellido: " + Apellido;
        }
    }
}
