using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Bussines;

public partial class Alumno : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Persona"] == null)
        {
            Page.Response.Redirect("~/Default.aspx");
        }
        else if (Session["tipo"].ToString() == "docente")
        {
            Page.Response.Redirect("~/Docente.aspx");
        }else
            {
                Persona alu = (Persona)Session["Persona"];
                lblNombre.Text = "Bienvenido " + alu.apellido + " " + alu.nombre;
            }
    }
}