
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Web;
using System.Web.Services;

namespace WSBaseDatos
{
    /// <summary>
    /// Descripción breve de BaseDatos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class BaseDatos : System.Web.Services.WebService
    {
        public static string Conexion = @"Data Source=ALEX\PROGRA;Initial Catalog=Androide17;User ID=sa;Password=progra";
        SqlConnection cn = new SqlConnection(Conexion);
        SqlCommand comando = new SqlCommand();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public string InsertarCuerpo(string datos)
        {
            try //protejemos la consulta
            {
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(datos, (typeof(DataTable)));

                using (SqlConnection cn = new SqlConnection(Conexion))
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand("INRCUE", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@_Nombre", dt.Rows[0][0].ToString());
                    cmd.Parameters.AddWithValue("@_Descubridor", dt.Rows[0][1].ToString());
                    cmd.Parameters.AddWithValue("@_FOTOGRAFIA", Encoding.UTF8.GetBytes( dt.Rows[0][2].ToString()));
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                return "";
            }
            catch (Exception ex)
            {
                cn.Close();
                comando.Dispose();
                return "";
            }
        }

        [WebMethod]
        public string insertarTipo(string descripcion)
        {
            try //protejemos la consulta
            {
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(descripcion, (typeof(DataTable)));

                using (SqlConnection cn = new SqlConnection(Conexion))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("INSTIP", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DESCRIPCION", dt.Rows[0][0].ToString());
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                return "";
            }
            catch (Exception ex)
            {
                cn.Close();
                comando.Dispose();
                return ex.ToString();
            }
        }

        [WebMethod]
        public string ConsultaCuerpos()
        {
            DataTable dt = new DataTable();
            try
            {
                using (cn = new SqlConnection(Conexion))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELCUE", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    cn.Close();

                    string txt = Newtonsoft.Json.JsonConvert.SerializeObject(dt);

                    return txt;
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                return "";
            }
        }

        [WebMethod]
        public string consultarTipos()
        {
            DataTable dt = new DataTable();
            try
            {
                using (cn = new SqlConnection(Conexion))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELTIP", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    cn.Close();
                    string txt = Newtonsoft.Json.JsonConvert.SerializeObject(dt);

                    return txt;
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                return "";
            }
        }

        [WebMethod]
        public string InsertarAsociados(string datos)
        {
            try //protejemos la consulta
            {

                DataTable dt = (DataTable)JsonConvert.DeserializeObject(datos, (typeof(DataTable)));

                using (SqlConnection cn = new SqlConnection(Conexion))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("INSASO", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_CUERPO", Convert.ToInt32(dt.Rows[0][0].ToString()));
                    cmd.Parameters.AddWithValue("@ID_ASOCIADO", Convert.ToInt32(dt.Rows[0][1].ToString()));
                    cmd.Parameters.AddWithValue("@ID_TIPO", Convert.ToInt32(dt.Rows[0][2].ToString()));
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                return "";
            }
            catch (Exception ex)
            {
                cn.Close();
                comando.Dispose();
                return ex.ToString();
            }
        }

        [WebMethod]
        public string consultarTotalCuerpos()
        {
            DataTable dt = new DataTable();
            try
            {
                using (cn = new SqlConnection(Conexion))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELTCUE", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    cn.Close();
                    string txt = Newtonsoft.Json.JsonConvert.SerializeObject(dt);

                    return txt;
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                return "";
            }
        }

        [WebMethod]
        public string consultarAsociados()
        {
            DataTable dt = new DataTable();
            try
            {
                using (cn = new SqlConnection(Conexion))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELASO", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    cn.Close();
                    string txt = Newtonsoft.Json.JsonConvert.SerializeObject(dt);

                    return txt;
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                return "";
            }
        }
    }
}
