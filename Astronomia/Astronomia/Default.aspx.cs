﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Astronomia.SRNegocio;
using System.Data;
using Newtonsoft.Json;
using System.Text;

namespace Astronomia
{
    public partial class _Default : System.Web.UI.Page
    {
        public static Astronomia.SRNegocio.NegociosSoapClient WSNegocios = new Astronomia.SRNegocio.NegociosSoapClient();
        public static Astronomia.SRBaseDatos.BaseDatosSoapClient WSBaseDatos = new Astronomia.SRBaseDatos.BaseDatosSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                actualizar();
            }
            actualizar2();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }

        protected void cargarImagenes_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileUploader1.HasFile)
                {
                    string nombre = fileUploader1.FileName;

                    string salida = WSNegocios.CuerpoCeleste(txtnombre.Text, txtDescubridor.Text, Encoding.UTF8.GetBytes(nombre));

                    Label1.Text = salida;
                    actualizar();
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            
            

        }

        protected void btnAsociar_Click(object sender, EventArgs e)
        {
            try
            {
                string salida = WSNegocios.asociar(Convert.ToInt32(ddlCuerposCelestes1.SelectedValue), Convert.ToInt32(ddlCuerposCelestes2.SelectedValue), Convert.ToInt32(ddlTipoRelacion.SelectedValue));

                Label3.Text = salida;
                actualizar();
                actualizar2();
            }
            catch (Exception ex)
            {
                Label3.Text = "Error";
            }
        }

        protected void btnInsertarTipo_Click(object sender, EventArgs e)
        {
            try
            {
                string salida = WSNegocios.insertarTipo(txtTipoRelacion.Text);

                Label4.Text = salida;

                actualizar();
                actualizar2();
            }
            catch (Exception ex)
            {
                Label4.Text = "Error";
            }
        }

        public void actualizar()
        {
            ddlCuerposCelestes1.Items.Clear();
            ddlCuerposCelestes2.Items.Clear();
            ddlTipoRelacion.Items.Clear();

            string salida = WSNegocios.consultarCuerpo();

            string[] vec = salida.Split('+').ToArray();

            if (vec[0].ToString() != "")
            {
                for (int i = 0; i < vec.Length; i++)
                {
                    string[] vec2 = vec[i].Split(',').ToArray();

                    ddlCuerposCelestes1.Items.Add(vec2[1].ToString());
                    ddlCuerposCelestes1.Items[i].Value = vec2[0].ToString();

                    ddlCuerposCelestes2.Items.Add(vec2[1].ToString());
                    ddlCuerposCelestes2.Items[i].Value = vec2[0].ToString();
                }
            }
            string salida2 = WSNegocios.consultarTipo();

            string[] vect = salida2.Split('+').ToArray();

            if (vect[0].ToString() != "")
            {
                for (int j = 0; j < vect.Length; j++)
                {
                    string[] vect2 = vect[j].Split(',').ToArray();

                    ddlTipoRelacion.Items.Add(vect2[1].ToString());
                    ddlTipoRelacion.Items[j].Value = vect2[0].ToString();
                }
            }
        }
        public void actualizar2()
        {
            try
            {
                CrearTabla ct = new CrearTabla();

                string txt = WSBaseDatos.consultarTotalCuerpos();

                DataTable dt = (DataTable)JsonConvert.DeserializeObject(txt, (typeof(DataTable)));

                string txt2 = WSBaseDatos.consultarTipos();

                DataTable dt2 = (DataTable)JsonConvert.DeserializeObject(txt2, (typeof(DataTable)));

                PlaceHolder1.Controls.Clear();
                PlaceHolder1.Controls.Clear();
                PlaceHolder1.Controls.Clear();
                PlaceHolder1.Controls.Add(new Literal { Text = ct.crear(dt2).ToString() });//tipo relacion
                //PlaceHolder2.Controls.Add(new Literal { Text = WSNegocios.crearTablaTipos().ToString() }); // asociados
                PlaceHolder3.Controls.Add(new Literal { Text = ct.crear(dt).ToString() });//cuerpos celestes

            }
            catch (Exception)
            {
            }
        }
    }
}