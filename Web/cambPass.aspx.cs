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
        lblOk.Text = " ";
        lblFailPN.Text = " ";
        if (Session["Persona"] is Alumno)
           {
            ic = new ControllerAlumno();
           }else
                {
                    ic = new ControllerDocente();
                }
        Persona p = (Persona)Session["Persona"];
        if (txtPassN.Text.Length==0 && txtPassNR.Text.Length==0)
        {
            lblFailPN.Text = "La contraseña no puede tener longitud 0";
        }else if (Hasher.toMD5(txtPassV.Text) != p.password)
        {
            lblFailPN.Text = "La vieja contraseña es incorrecta";
        }
        else if (this.txtPassN.Text != this.txtPassNR.Text)
        {
            lblFailPN.Text = "Las nuevas contraseñas no coinciden";
        }
        else if (this.txtPassN.Text == this.txtPassNR.Text && Hasher.toMD5(txtPassV.Text) == p.password)
        {
            lblFailPN.Text = " ";
            Persona per = ic.find(p.id);
            per.password = Hasher.toMD5(txtPassN.Text);
            ic.update(per);
            Session["Persona"] = per;
            lblOk.Text = "Contraseña cambiada con exito";
        }
    }
}