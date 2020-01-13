using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using DataLayer.Escribir;
using DataLayer.Leer;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace Mapper
{
   public class ZonaMPP
    {
        public bool Operacion(ZonaEE oZonaEE, int op)
        {
            try
            {
                string consulta;
                switch (op)
                {
                    case 1:
                        consulta = "sp_AltaZona";
                        break;
                    case 2:
                        consulta = "sp_ModificarZona";
                        break;
                    case 3:
                        consulta = "sp_BorrarZona";
                        break;
                    default:
                        consulta = null;
                        break;
                }
                Hashtable hdatos = new Hashtable();
                if (op != 3)
                {
                    if (oZonaEE.Id_Zona != 0)
                    {
                        hdatos.Add("@Id_Zona", oZonaEE.Id_Zona);
                    }
                    hdatos.Add("@Distrito", oZonaEE.Distrito);
                    hdatos.Add("@Barrio", oZonaEE.Barrio);
                }
                else
                {
                    hdatos.Add("@Id_Zona", oZonaEE.Id_Zona);
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

        public bool AgregarCliZona(ClienteEE oClienteEE, ZonaEE oZonaEE)
        {
            try
            {
                Hashtable hdatos = new Hashtable();
                hdatos.Add("@Id_Cliente", oClienteEE.Id_Cliente);
                hdatos.Add("@Id_Zona", oZonaEE.Id_Zona);

                EscribirDatos oEscribirDatos = new EscribirDatos();
                return oEscribirDatos.Escribir("sp_AgregarClienteZona", hdatos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool QuitarCliZona(ClienteEE oClienteEE, ZonaEE oZonaEE)
        {
            try
            {
                Hashtable hdatos = new Hashtable();
                hdatos.Add("@Id_Cliente", oClienteEE.Id_Cliente);
                hdatos.Add("@Id_Zona", oZonaEE.Id_Zona);
                EscribirDatos oEscribirDatos = new EscribirDatos();
                return oEscribirDatos.Escribir("sp_QuitarClienteZona", hdatos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<ZonaEE> ListarZona()
        {
            try
            {
                List<ZonaEE> ListaZonas = new List<ZonaEE>();
                LeerDatos oLeerDatos = new LeerDatos();
                DataSet DS = new DataSet();
               
                DS = oLeerDatos.Leer("sp_ListarZonas", null);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow Fila in DS.Tables[0].Rows)
                    {
                        Hashtable hdatos = new Hashtable();
                        ZonaEE oZonaEE = new ZonaEE();
                        oZonaEE.Id_Zona = Convert.ToInt32(Fila["Id_Zona"]);
                        oZonaEE.Distrito = Fila["Distrito"].ToString();
                        oZonaEE.Barrio = Fila["Barrio"].ToString();
                        hdatos.Add("@Id_Zona", oZonaEE.Id_Zona);
                        LeerDatos oLeerDatosAnidado = new LeerDatos();
                        DataSet DSZona = oLeerDatosAnidado.Leer("sp_ClientesEnZona", hdatos);
                        List<ClienteEE> ListaDeCliente = new List<ClienteEE>();
                        if (DSZona.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow Item in DSZona.Tables[0].Rows)
                            {
                                ClienteEE oClienteEE = new ClienteEE();
                                oClienteEE.Id_Cliente = Convert.ToInt32(Item["Id_Cliente"]);
                                oClienteEE.Nombre = Item["Nombre"].ToString();
                                oClienteEE.Apellido = Item["Apellido"].ToString();
                                oClienteEE.DNI = Convert.ToInt32(Item["DNI"]);
                                oClienteEE.FechaNac = Convert.ToDateTime(Item["FechaNac"]);
                                oClienteEE.Domicilio = Item["Domicilio"].ToString();
                                oClienteEE.Categoria = Item["Categoria"].ToString();
                                ListaDeCliente.Add(oClienteEE);
                            }
                            oZonaEE.ListaCliente = ListaDeCliente;
                        }
                        ListaZonas.Add(oZonaEE);
                    }
                    return ListaZonas;
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
