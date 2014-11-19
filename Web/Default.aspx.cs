using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void btnIngresar_onclick(object sender, EventArgs e)
    {
        if (txtUss.Text == "docente" && txtPss.Text == "docente")
        {
            Response.Redirect("~/Docente.aspx");
        }else if (txtUss.Text == "alumno" && txtPss.Text == "alumno")
                {
                    Response.Redirect("~/Alumno.aspx");
                }else{
                        Response.Write("Usuario y/o contraseña incorrectos");
                        txtPss.Text = "";
                     }
    }

}
