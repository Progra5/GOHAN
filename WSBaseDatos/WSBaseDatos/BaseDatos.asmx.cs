﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
        public static string Conexion = @"workstation id=Androide17.mssql.somee.com;packet size=4096;user id=alex207_SQLLogin_1;pwd=lif58eecxe;data source=Androide17.mssql.somee.com;persist security info=False;initial catalog=Androide17";
        SqlConnection cn = new SqlConnection(Conexion);
        SqlCommand comando = new SqlCommand();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public string InsertarCuerpo(string nombre, string descubridor, byte[] archivo)
        {
            try //protejemos la consulta
            {
                using (SqlConnection cn = new SqlConnection(Conexion))
                {
                    cn.Open();
<<<<<<< HEAD
                    SqlCommand cmd = new SqlCommand("INRCUE", cn);
=======
                    SqlCommand cmd = new SqlCommand("INSCUE", cn);
>>>>>>> 4af0dbc78b958ad9033bc73576daddfe81805790
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@_Nombre", nombre);
                    cmd.Parameters.AddWithValue("@_Descubridor", descubridor);
                    cmd.Parameters.AddWithValue("@_FOTOGRAFIA", archivo);
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
                using (SqlConnection cn = new SqlConnection(Conexion))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("INSTIP", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DESCRIPCION", descripcion);
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
        public string InsertarAsociados(int idCuerpo, int idAsociado, int idtipo)
        {
            try //protejemos la consulta
            {
                using (SqlConnection cn = new SqlConnection(Conexion))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("INSASO", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_CUERPO", idCuerpo);
                    cmd.Parameters.AddWithValue("@ID_ASOCIADO", idAsociado);
                    cmd.Parameters.AddWithValue("@ID_TIPO", idtipo);
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

    }
}
