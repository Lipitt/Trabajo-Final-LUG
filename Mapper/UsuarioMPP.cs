using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using DataLayer.Escribir;
using System.Data;
using DataLayer.Leer;
using System.Collections;
using System.Windows.Forms;

namespace Mapper
{
    public class UsuarioMPP
    {
        public bool LogIn(string user, string pass)
        {
            try
            {
                LeerDatos oLeerDatos = new LeerDatos();
                DataSet DS = new DataSet();
                Hashtable hash = new Hashtable();
                List<UsuarioEE> ListaUsuario = new List<UsuarioEE>();
                hash.Add(@"Username", user);
                DS = oLeerDatos.Leer("sp_userPass", hash);

                if (DS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow Item in DS.Tables[0].Rows)
                    {
                        UsuarioEE oUEE = new UsuarioEE();
                        oUEE.Username = Item["Username"].ToString().Trim();
                        oUEE.Password = Item["Password"].ToString().Trim();
                      
                    if (user.Trim() == oUEE.Username && pass.Trim() == oUEE.Password)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<UsuarioEE> ListarUsuario()
        {
            LeerDatos oLeerDatos = new LeerDatos();
            DataSet DS = new DataSet();
            List<UsuarioEE> ListaUsuario = new List<UsuarioEE>();

            DS = oLeerDatos.Leer("sp_ListarUsuarios", null);
            if (DS.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Item in DS.Tables[0].Rows)
                {
                    UsuarioEE oUEE = new UsuarioEE();
                    oUEE.Id_Usuario = Convert.ToInt32(Item["Id_Usuario"]);
                    oUEE.Nombre = Item["Nombre"].ToString();
                    oUEE.Apellido = Item["Apellido"].ToString();
                    oUEE.DNI = Convert.ToInt32(Item["DNI"]);
                    oUEE.FechaNac = Convert.ToDateTime(Item["FechaNac"]);
                    oUEE.Username = Item["Username"].ToString();
                    oUEE.Password = Item["Password"].ToString();
                    ListaUsuario.Add(oUEE);
                }
                return ListaUsuario;
            }
            else
            {
                return null;
            }
        }
        public bool Operacion(UsuarioEE oUsuarioEE, int op)
        {
            try
            {
                string consulta;
                switch (op)
                {
                    case 1:
                        consulta = "sp_AltaUsuario";
                        break;
                    case 2:
                        consulta = "sp_ModificarUsuario";
                        break;
                    case 3:
                        consulta = "sp_BajaUsuario";
                        break;
                    default:
                        consulta = null;
                        break;
                }
                Hashtable hdatos = new Hashtable();

                if (op != 3)
                {
                    if (oUsuarioEE.Id_Usuario != 0)
                    {
                        hdatos.Add("@Id_Usuario", oUsuarioEE.Id_Usuario);
                    }
                    hdatos.Add("@Nombre", oUsuarioEE.Nombre);
                    hdatos.Add("@Apellido", oUsuarioEE.Apellido);
                    hdatos.Add("@DNI", oUsuarioEE.DNI);
                    hdatos.Add("@FechaNac", oUsuarioEE.FechaNac);
                    hdatos.Add("@Username", oUsuarioEE.Username);
                    hdatos.Add("@Password", oUsuarioEE.Password);
                }
                else
                {
                    hdatos.Add("@Id_Usuario", oUsuarioEE.Id_Usuario);
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
