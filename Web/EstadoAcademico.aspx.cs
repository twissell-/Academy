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
        }
        else
        {
            /*cc = new ControllerComision();
            //List<Comision> com = cc.find((Alumno)Session["Persona"]);
            Alumno al = (Alumno)Session["Persona"];

            dvgEstadoAcademico.DataSource = cc.find((Alumno)Session["Persona"]);
            // foreach (var item in com)
            // { 
                BoundField bf = new BoundField();
                string dsaff = al.condicion.ToString();
            bf.DataField = dsaff;
            dvgEstadoAcademico.Columns.Add(bf);
            dvgEstadoAcademico.DataBind();
             COSAS NET ESCRITORIO BLOCK DE NOTAS*/
        }
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect("~/pagAlumno.aspx");
        
    }
}