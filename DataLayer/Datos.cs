using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataLayer
{


    public class Datos
    {
        protected string CadenaC = @"Data Source=.\SQLEXPRESS;Initial Catalog=TFLipshitz;Integrated Security=True";
        protected SqlConnection Cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TFLipshitz;Integrated Security=True");
        protected SqlTransaction Tranx;
        protected SqlCommand Cmd;
    }
        namespace Leer
    {
        public class LeerDatos : Datos
        {
            public DataSet Leer(string consulta, Hashtable hdatos)
            {
                try
                {
                    DataSet Ds = new DataSet();
                    Cmd = new SqlCommand();
                    Cmd.Connection = Cnn;
                    Cmd.CommandText = consulta;
                    Cmd.CommandType = CommandType.StoredProcedure;

                    if ((hdatos != null))
                    {
                        foreach (string dato in hdatos.Keys)
                        {
                            Cmd.Parameters.AddWithValue(dato, hdatos[dato]);
                        }
                    }

                    SqlDataAdapter Adaptador = new SqlDataAdapter(Cmd);
                    Adaptador.Fill(Ds);
                    return Ds;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        } 
    }

    namespace Escribir
    {
        public class EscribirDatos : Datos
        {
            public bool Escribir(string consulta, Hashtable hdatos)
            {
                if (Cnn.State == ConnectionState.Closed)
                {
                    Cnn.ConnectionString = CadenaC;
                    Cnn.Open();
                }

                try
                {
                    Tranx = Cnn.BeginTransaction();
                    Cmd = new SqlCommand(consulta, Cnn, Tranx);
                    Cmd.CommandType = CommandType.StoredProcedure;
           
                    if ((hdatos != null))
                    {
                        foreach (string dato in hdatos.Keys)
                        {
                            Cmd.Parameters.AddWithValue(dato, hdatos[dato]);
                        }
                    }
                    int respuesta = Cmd.ExecuteNonQuery();
                    Tranx.Commit();
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    Tranx.Rollback();
                    return false;
                }
                finally
                {
                    Cnn.Close();
                }
            }
        }
    }
}

