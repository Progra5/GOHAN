using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using Newtonsoft.Json;
using WSNegocio.SRBaseDatos;
using Negocios;

namespace WSNegocio
{
    /// <summary>
    /// Descripción breve de Negocios
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Negocios : System.Web.Services.WebService
    {
        [WebMethod]
        public string CuerpoCeleste(string nombre, string descubridor, string archivo)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("nombre");
                dt.Columns.Add("descubridor");
                dt.Columns.Add("archivo");

                DataRow row = dt.NewRow();
                row["nombre"] = nombre;
                row["descubridor"] = descubridor;
                row["archivo"] = archivo;
                dt.Rows.Add(row);

                string txt = Newtonsoft.Json.JsonConvert.SerializeObject(dt);

                WSNegocio.SRBaseDatos.BaseDatosSoapClient WSBaseDatos = new WSNegocio.SRBaseDatos.BaseDatosSoapClient();

                string resultado = WSBaseDatos.InsertarCuerpo(txt);

                return resultado;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        [WebMethod]
        public string asociar(int idCuerpo, int idAsociado, int idTipo)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("idAsociado");
                dt.Columns.Add("idCuerpo");
                dt.Columns.Add("idTipo");

                DataRow row = dt.NewRow();
                row["idAsociado"] = idAsociado.ToString();
                row["idCuerpo"] = idCuerpo.ToString();
                row["idTipo"] = idTipo.ToString();
                dt.Rows.Add(row);

                string txt = Newtonsoft.Json.JsonConvert.SerializeObject(dt);

                WSNegocio.SRBaseDatos.BaseDatosSoapClient WSBaseDatos = new WSNegocio.SRBaseDatos.BaseDatosSoapClient();

                string salida = WSBaseDatos.InsertarAsociados(txt);

                return "Los datos se guardaron correctamente";
            }
            catch (Exception)
            {
                return "Ocurrio un error";
            }
        }

        [WebMethod]
        public string insertarTipo(string descripcion)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("descripcion");

                DataRow row = dt.NewRow();
                row["descripcion"] = descripcion;
                dt.Rows.Add(row);

                string txt = Newtonsoft.Json.JsonConvert.SerializeObject(dt);
                
                WSNegocio.SRBaseDatos.BaseDatosSoapClient WSBaseDatos = new WSNegocio.SRBaseDatos.BaseDatosSoapClient();

                string salida = WSBaseDatos.insertarTipo(txt);

                if (salida == "" || salida == " " || salida == null)
                {
                    return "Los datos se ingresaron correctamente";
                }
                else
                {
                    return salida;
                }
            }
            catch (Exception)
            {
                return "Ocurrio un error";
            }
        }



        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public string consultarTipo()
        {
            try
            {
                WSNegocio.SRBaseDatos.BaseDatosSoapClient WSBaseDatos = new WSNegocio.SRBaseDatos.BaseDatosSoapClient();

                string txt = WSBaseDatos.consultarTipos();

                //var JSon = JsonConvert.DeserializeObject<dynamic>(txt);
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(txt, (typeof(DataTable)));


                string salida = "";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        salida = Convert.ToString(dt.Rows[i][0].ToString()) + "," + Convert.ToString(dt.Rows[i][1].ToString());
                    }
                    else
                    {
                        salida = salida + "+" + Convert.ToString(dt.Rows[i][0].ToString()) + "," + Convert.ToString(dt.Rows[i][1].ToString());

                    }
                }
                return salida;
            }
            catch (Exception)
            {
                return "";
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        /*public void getCuerpos()
        {
            Context.Response.Write(consultarCuerpo());
        }*/
        public string consultarCuerpo()
        {
            try
            {
                WSNegocio.SRBaseDatos.BaseDatosSoapClient WSBaseDatos = new WSNegocio.SRBaseDatos.BaseDatosSoapClient();

                string txt = (WSBaseDatos.ConsultaCuerpos());

                DataTable dt = (DataTable)JsonConvert.DeserializeObject(txt, (typeof(DataTable)));
                string salida = "";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        salida = Convert.ToString(dt.Rows[i][0].ToString()) + "," + Convert.ToString(dt.Rows[i][1].ToString());
                    }
                    else
                    {
                        salida = salida + "+" + Convert.ToString(dt.Rows[i][0].ToString()) + "," + Convert.ToString(dt.Rows[i][1].ToString());

                    }
                }
                return salida;
            }
            catch (Exception)
            {
                return "";
            }
        }

        [WebMethod]
        public StringBuilder crearTablaTipos()
        {
            try
            {
                CrearTabla ct = new CrearTabla();

                WSNegocio.SRBaseDatos.BaseDatosSoapClient WSBaseDatos = new WSNegocio.SRBaseDatos.BaseDatosSoapClient();

                string txt = WSBaseDatos.consultarTipos();

                DataTable dt = (DataTable)JsonConvert.DeserializeObject(txt, (typeof(DataTable)));

                StringBuilder html = new StringBuilder();

                html = ct.crear(dt);

                return html;
            }
            catch (Exception)
            {
                return null;
            }
        }

        [WebMethod]
        public StringBuilder crearTablaCuerpos()
        {
            try
            {
                CrearTabla ct = new CrearTabla();

                WSNegocio.SRBaseDatos.BaseDatosSoapClient WSBaseDatos = new WSNegocio.SRBaseDatos.BaseDatosSoapClient();

                string txt = WSBaseDatos.consultarTotalCuerpos();

                DataTable dt = (DataTable)JsonConvert.DeserializeObject(txt, (typeof(DataTable)));

                StringBuilder html = new StringBuilder();

                html = ct.crear(dt);

                return html;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
