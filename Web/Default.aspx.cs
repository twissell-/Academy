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
    protected void btnIngresar_onclick(object sender, EventArgs e)
    {
        ca = new ControllerAlumno();
        cd = new ControllerDocente();
        Persona d = null;
        Persona al = null;
        int id = 0;
        if (int.TryParse(txtUss.Text, out id))
        {
            d = cd.find(id);
            if (d == null)
            {
                al = ca.find(id);
            }
            if (d == null && al.password == Hasher.toMD5(txtPss.Text))
            {
                Session["Persona"] = al;
                Response.Redirect("~/Alumno.aspx");

            }
            else if (al == null && d.password == Hasher.toMD5(txtPss.Text))
            {
                Session["Persona"] = d;
                Response.Redirect("~/Docente.aspx");

            }
            else if ((d == null && al.id != Convert.ToInt32(txtUss.Text) || al.password != Hasher.toMD5(txtPss.Text))
         || (al == null && d.id != Convert.ToInt32(txtUss.Text) || d.password != Hasher.toMD5(txtPss.Text)))//al==null && d==null)
            {
                error.Text = "Usuario y/o contraseña incorrectos";
                txtPss.Text = "";
            }
        }
        else
        {
            error.Text = "Usuario invalido";
            txtPss.Text = "";
        }
    }

}
