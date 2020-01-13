using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using DataLayer;
using DataLayer.Leer;
using DataLayer.Escribir;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace Mapper
{
    public class ContactoMPP
    {
        protected LeerDatos oLeerDatos = new LeerDatos();
        public List<ContactoEE> ListarContacto()
        {
            try
            {
                DataSet DS = new DataSet();
                List<ContactoEE> ListaContactos = new List<ContactoEE>();

                DS = oLeerDatos.Leer("sp_ListarContactos", null);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow Item in DS.Tables[0].Rows)
                    {
                        ContactoEE oContacto = new ContactoEE();
                        oContacto.Id_Contacto = Convert.ToInt32(Item["Id_Contacto"]);
                        oContacto.Telefono = Convert.ToInt32(Item["Telefono"]);
                        oContacto.Mail = Item["Mail"].ToString();
                        oContacto.Cliente.Id_Cliente = Convert.ToInt32(Item["Id_Cliente"].ToString());
                        oContacto.Cliente.Nombre = Item["Nombre"].ToString().Trim();
                        oContacto.Cliente.Apellido = Item["Apellido"].ToString().Trim();
                        ListaContactos.Add(oContacto);
                    }
                    return ListaContactos;
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
        public bool Operacion(ContactoEE oContactoEE, int op)
        {
            try
            {
                string consulta;
                switch (op)
                {
                    case 1:
                        consulta = "sp_AltaContacto";
                        break;
                    case 2:
                        consulta = "sp_ModificarContacto";
                        break;
                    case 3:
                        consulta = "sp_BorrarContacto";
                        break;
                    default:
                        consulta = null;
                        break;
                }
                Hashtable hdatos = new Hashtable();

                if (op != 3)
                {
                    if (oContactoEE.Id_Contacto != 0)
                    {
                        hdatos.Add("@Id_Contacto", oContactoEE.Id_Contacto);
                    }

                    hdatos.Add("@Telefono", oContactoEE.Telefono);
                    hdatos.Add("@Mail", oContactoEE.Mail);
                    hdatos.Add("@Id_Cliente", oContactoEE.Cliente.Id_Cliente);
                }
                else
                {
                    hdatos.Add("@Id_Contacto", oContactoEE.Id_Contacto);
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
