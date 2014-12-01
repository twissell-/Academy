using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Bussines;

public partial class docAluCom : System.Web.UI.Page
{
    ControllerComision cc;
    protected void Page_Load(object sender, EventArgs e)
    {
        cc = new ControllerComision();
        if (Session["Persona"] == null)
        {
            Page.Response.Redirect("~/Default.aspx");
        }
        else if (Session["tipo"] is Alumno)
        {
            Page.Response.Redirect("~/pagAlumno.aspx");
        }
        else if (Session["Comision"] == null)
        {
            Page.Response.Redirect("~/pagDocente.aspx");
        }
        if (!IsPostBack)
        {
            Comision com = (Comision)Session["Comision"];
            dvgAluCom.DataSource = com.alumnos;
            dvgAluCom.DataBind();
        }
    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        int index=dvgAluCom.Rows.Count;
        for (int i = 0; i < index; i++)
        {
            if (dvgAluCom.Rows[index].Cells[3].Text==" ")
            {
                //ya veremos
            }
            switch (dvgAluCom.Rows[index].Cells[3].Text)
            {
                case "A": break;
                case "a": break;
                case "P": break;
                case "p": break;
                case "i": break;
                case "I": break;
                
                default:// tmb ya veremos
                    break;
            }
        }
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect("~/pagDocente.aspx");
    }
}