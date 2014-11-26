using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Bussines;

public partial class About : System.Web.UI.Page
{
    ControllerComision cc;
    protected void Page_Load(object sender, EventArgs e)
    {
        cc=new ControllerComision();       
        Materia mat =(Materia) Session["matSel"];
       /* ListItem item = new ListItem();
        item.Value = mat;
        item.Text = mat;
        item.Attributes.Add(mat,mat.descripcion);
        item = mat;
        rblComisiones.Items.Add(item);*/
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect("~/inscMateria.aspx");
    }
    protected void btnInscribirse_Click(object sender, EventArgs e)
    {
       // rblComisiones.SelectedItem.Text;
    }
}
