using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bussines;
using Entidades;

public partial class EstadoAcademico : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ControllerComision cc;
        if (Session["Persona"] == null)
        {
            Page.Response.Redirect("~/Default.aspx");
        }
        else if (Session["tipo"] is Docente)
        {
            Page.Response.Redirect("~/pagDocente.aspx");
        }else
            {
                cc = new ControllerComision();
                dvgEstadoAcademico.DataSource = cc.find((Alumno)Session["Persona"]);
                dvgEstadoAcademico.DataBind();
            }
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect("~/pagAlumno.aspx");
        
    }
}