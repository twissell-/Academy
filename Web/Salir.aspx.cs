using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Salir : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Persona"] != null)
        {
            Session["Persona"] = null;
            Session["matSel"] = null;
            lblSalir.Text = "Usted ha salido exitosamente";
        }
        else
        {
            lblSalir.Text = "No hay una sesion activa";
        }
        hypDef.Text = "Haga click aqui para iniciar sesion";
    }
}