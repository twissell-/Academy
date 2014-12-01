using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Bussines;

public partial class docMaterias : System.Web.UI.Page
{
    ControllerComision cc;
    ControllerMateria cm;
    protected void Page_Load(object sender, EventArgs e)
    {
        cc=new ControllerComision();
        cm = new ControllerMateria();
        if (Session["Persona"] == null)
        {
            Page.Response.Redirect("~/Default.aspx");
        }
        else if (Session["tipo"] is Alumno)
        {
            Page.Response.Redirect("~/pagAlumno.aspx");
        }else if (Session["matSel"] == null)
        {
            Page.Response.Redirect("~/docComisiones.aspx");
        }
        Materia mat = (Materia)Session["matSel"];
        if (!IsPostBack)
        {
            //dvgMateriasDocentes.DataSource = //algun metodo q me de las materias de este profe //cc.find(mat);
            //dvgMateriasDocentes.DataBind();
        }else 
            {
                String eventarg = this.Request.Params.Get("__EVENTARGUMENT");
                String[] das = eventarg.Split('$');
                int index = Convert.ToInt32(das[1]);
                int idC = 0;
                if (int.TryParse(dvgMateriasDocentes.Rows[index].Cells[0].Text, out idC))
                {
                    Comision comSel=cc.find(idC);
                    Alumno al = (Alumno)Session["Persona"];
                    comSel.alumnos.Add(al);
                    cc.update(comSel);
                    //lblInscripto.Text = "Inscripto en la comision " + idC + " de la materia" + mat.descripcion;
                    Session["matSel"] = null;
                }
            }
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect("~/docComisiones.aspx");
        Session["matSel"] = null;
    }
}
