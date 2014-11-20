using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cambPass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void cancelar_Click(object sender, EventArgs e)
    {
       
        //Page.Response.Redirect(Page.PreviousPage.ToString());
    }
    protected void  cambPass_Click(object sender, EventArgs e)
    {
        if (this.txtPassN.Text != this.txtPassNR.Text)
        {
            lblFailPN.Text = "Las nuevas contraseñas no coinciden";   
        }
        else
        {
            lblFailPN.Text = " "; 
        }
    }
}