using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Bussines;

public partial class pagDocente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Persona"] == null)
        {
            Page.Response.Redirect("~/Default.aspx");
        }
        else if (Session["Persona"] is Alumno)
        {
            Page.Response.Redirect("~/pagAlumno.aspx");
        }else
            {
                Docente doc = (Docente)Session["Persona"];
                lblNombre.Text = "Bienvenido " + doc.apellido + " " + doc.nombre;
            }
    }
}