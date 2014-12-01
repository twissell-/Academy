using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Bussines;
using Util;

public partial class cambPass : System.Web.UI.Page
{
    IControllerPersona ic;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Persona"] == null)
        {
            Page.Response.Redirect("~/Default.aspx");
        }
    }
   
    protected void cancelar_Click(object sender, EventArgs e)
    {
        if (Session["Persona"] is Alumno)
        {
            Page.Response.Redirect("~/pagAlumno.aspx");
        }
        else {
            Page.Response.Redirect("~/pagDocente.aspx");
        }
    }
    protected void  cambPass_Click(object sender, EventArgs e)
    {
        if (this.txtPassN.Text != this.txtPassNR.Text)
        {
            lblFailPN.Text = "Las nuevas contraseñas no coinciden";   
        }
        else if (Session["Persona"] is Alumno)
                {
                    ic = new ControllerAlumno();
                }
                else
                {
                    ic = new ControllerDocente();
                }
                lblFailPN.Text = " ";
                Persona p = (Persona)Session["Persona"];
                Persona per = ic.find(p.id);
                per.password = Hasher.toMD5(txtPassN.Text);
                ic.update(per);
    }
}