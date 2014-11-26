using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Bussines;


public partial class inscMateria : System.Web.UI.Page
{
    ControllerAlumno ca;
    ControllerComision cc;
    ControllerMateria cm;
    protected void Page_Load(object sender, EventArgs e)
    {
        cm = new ControllerMateria();
     
            cc = new ControllerComision();
            ca = new ControllerAlumno();
            if (!IsPostBack)
            {
            List<Materia> materias = new List<Materia>();
            dvgMaterias.DataSource = cm.find();
            dvgMaterias.DataBind();
        }
        else
        {
            String eventarg = this.Request.Params.Get("__EVENTARGUMENT");
            String[] das = eventarg.Split('$');
            int index = Convert.ToInt32(das[1]);
            int idM=0;
            if (int.TryParse(dvgMaterias.Rows[index].Cells[0].Text, out idM))
            {
                Materia matSel = cm.find(idM);
                Session["matSel"] = matSel;
                Response.Redirect("~/Comisiones.aspx");
            }
        }      
}
    protected void link_Click(Object sender, GridViewCommandEventArgs e)
    {
      
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect("~/Alumno.aspx");
    }
}