using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Bussines;
using Util;

public partial class _Default : System.Web.UI.Page
{
    ControllerAlumno ca;
    ControllerDocente cd;
    protected void page_Load()
    {
        ca = new ControllerAlumno();
        cd = new ControllerDocente();
        Session["Persona"] = null;
    }
    protected void btnIngresar_onclick(object sender, EventArgs e)
    {
        try
        {
            Persona per = null;
            int id = 0;
            if (int.TryParse(txtUss.Text, out id))
            {
                per = cd.find(id);
                if (per == null)
                {
                    per = ca.find(id);
                }
                if (per is Alumno && per.password == Hasher.toMD5(txtPss.Text))
                {
                    Session["Persona"] = per;
                    Response.Redirect("~/pagAlumno.aspx");

                }
                else if (per is Docente && per.password == Hasher.toMD5(txtPss.Text))
                {
                    Session["Persona"] = per;
                    Response.Redirect("~/pagDocente.aspx");

                }
                else
                {
                    error.Text = " ";
                    error.Text = "Usuario y/o contraseña incorrectos";
                    txtPss.Text = "";
                }
            }
            if (per == null)
            {
                error.Text = " ";
                error.Text = "Usuario invalido";
                txtPss.Text = "";
            }
        }
        catch (AppConnectionException)
        {
            error.Text="Ocurrio un error al intentar conectarse a la Base de Datos, comuniquese con el administrador";
        }
    }
}

