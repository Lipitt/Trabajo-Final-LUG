using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper.Lista;
using Mapper.Escritura;
using Mapper;
using EE;

namespace BLL
{
    public class ClienteBLL : PersonaBLL
    {
        //uso palabra reservada new para diferenciar de mismo metodo en PersonaBLL
        public new List<ClienteEE>Listar()
        {
            ListaCliente oListCli = new ListaCliente();
            return oListCli.ListarCliente();
        }
        //metodo heredado de clase persona, pero con distintos parametros
        public bool Operacion(ClienteEE oCliEE, int op)
        {
            EscrituraCliente oEscCli = new EscrituraCliente();
            return oEscCli.Operacion(oCliEE, op);
        }
    }
}
