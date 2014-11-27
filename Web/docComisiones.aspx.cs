using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class docComisiones : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Persona"] == null)
        {
            Page.Response.Redirect("~/Default.aspx");
        }
        else if (Session["tipo"].ToString() == "alumno")
        {
            Page.Response.Redirect("~/Alumno.aspx");
        }
        else
        { }
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    { 

    }
}