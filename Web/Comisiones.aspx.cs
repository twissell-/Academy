using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Bussines;

public partial class Comisiones : System.Web.UI.Page
{
    ControllerComision cc;
    ControllerMateria cm;
    protected void Page_Load(object sender, EventArgs e)
    {
        cc = new ControllerComision();

        if (Session["Persona"] == null)
        {
            Page.Response.Redirect("~/Default.aspx");
        }
        else if (Session["Persona"] is Docente)
        {
            Page.Response.Redirect("~/pagDocente.aspx");
        }else if (Session["matSel"] == null)
            {
                Page.Response.Redirect("~/inscMateria.aspx");
            }
        else
        {
            Materia mat = (Materia)Session["matSel"];

            if (!IsPostBack)
            {
                List<Comision> comTodas = cc.find(mat);
                dvgComisionesAlumnos.DataSource = comTodas;
                dvgComisionesAlumnos.DataBind();
                if (comTodas.Count==0)
                {
                    noComFound.Text = "No hay comisiones de " + mat.descripcion;
                    Session["matSel"] = null;
                }
            }
            else
            {
                String eventarg = this.Request.Params.Get("__EVENTARGUMENT");
                try
                {
                    String[] das = eventarg.Split('$');
                    try
                    {
                        int index = Convert.ToInt32(das[1]);
                        int idC = 0;
                        if (int.TryParse(dvgComisionesAlumnos.Rows[index].Cells[0].Text, out idC))
                        {
                            Comision comSel = cc.find(idC);
                            comSel.alumnos.Add((Alumno)Session["Persona"]);
                            cc.update(comSel);
                            lblInscripto.Text = "Inscripto en la comision " + idC + " de la materia" + mat.descripcion;
                            Session["matSel"] = null;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Page.Response.Redirect("~/inscMateria.aspx");
                    }
                }
                catch (NullReferenceException)
                {
                    Page.Response.Redirect("~/pagAlumno.aspx");
                }
            }
        }
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect("~/inscMateria.aspx");
        Session["matSel"] = null;
    }
}

