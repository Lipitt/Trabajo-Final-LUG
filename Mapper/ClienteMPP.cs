using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using System.Data;
using System.Collections;
using DataLayer.Leer;
using DataLayer.Escribir;
using System.Windows.Forms;

namespace Mapper
{
    public class ClienteMPP
    {
        protected LeerDatos oLeerDatos = new LeerDatos();
        protected DataSet DS = new DataSet();
        protected List<ClienteEE> ListaCLiente = new List<ClienteEE>();
    }

    namespace Lista
    {
        public class ListaCliente : ClienteMPP
        {
            public List<ClienteEE> ListarCliente()
            {
                try
                {
                    DS = oLeerDatos.Leer("sp_ListarClientes", null);
                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow Item in DS.Tables[0].Rows)
                        {
                            ClienteEE oCli = new ClienteEE();
                            oCli.Id_Cliente = Convert.ToInt32(Item["Id_Cliente"]);
                            oCli.Nombre = Item["Nombre"].ToString();
                            oCli.Apellido = Item["Apellido"].ToString();
                            oCli.DNI = Convert.ToInt32(Item["DNI"]);
                            oCli.FechaNac = Convert.ToDateTime(Item["FechaNac"]);
                            oCli.Domicilio = Item["Domicilio"].ToString();
                            oCli.Categoria = Item["Categoria"].ToString();
                            ListaCLiente.Add(oCli);
                        }
                        return ListaCLiente;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        } 
    }
    namespace Escritura
    {
        public class EscrituraCliente
        {
            public bool Operacion(ClienteEE oClienteEE, int op)
            {
                try
                {
                    string consulta;
                    switch (op)
                    {
                        case 1:
                            consulta = "sp_AltaCliente";
                            break;
                        case 2:
                            consulta = "sp_ModificarCliente";
                            break;
                        case 3:
                            consulta = "sp_BorrarCliente";
                            break;
                        default:
                            consulta = null;
                            break;
                    }
                    Hashtable hdatos = new Hashtable();

                    if (op != 3)
                    {
                        if (oClienteEE.Id_Cliente != 0)
                        {
                            hdatos.Add("@Id_Cliente", oClienteEE.Id_Cliente);
                        }
                        hdatos.Add("@Nombre", oClienteEE.Nombre);
                        hdatos.Add("@Apellido", oClienteEE.Apellido);
                        hdatos.Add("@DNI", oClienteEE.DNI);
                        hdatos.Add("@FechaNac", oClienteEE.FechaNac);
                        hdatos.Add("@Domicilio", oClienteEE.Domicilio);
                        hdatos.Add("@Categoria", oClienteEE.Categoria);
                    }
                    else
                    {
                        hdatos.Add("@Id_Cliente", oClienteEE.Id_Cliente);
                    }
                    EscribirDatos oEscribirDatos = new EscribirDatos();
                    return oEscribirDatos.Escribir(consulta, hdatos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
    }
}

