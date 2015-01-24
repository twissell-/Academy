using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Bussines;
using System.Data;

public partial class docComisiones : System.Web.UI.Page
{
    ControllerComision cc;
    protected void Page_Load(object sender, EventArgs e)
    {
        cc = new ControllerComision();
        if (Session["Persona"] == null)
        {
            Page.Response.Redirect("~/Default.aspx");
        }
        else if (Session["tipo"] is Alumno)
        {
            Page.Response.Redirect("~/pagAlumno.aspx");
        }
        else if (Session["matSel"] == null)
        {
            Page.Response.Redirect("~/docMaterias.aspx");
        }

        if (!IsPostBack)
        {
            
            Materia mat = (Materia)Session["matSel"];
            List<Comision> com=cc.find(mat);
            lblMateria.Text = mat.descripcion;
            DataTable table = new DataTable();
            DataColumn dc = new DataColumn();
            dc.ColumnName = "id";
            DataColumn dc1 = new DataColumn();
            dc1.ColumnName = "turno";
            table.Columns.Add(dc);
            table.Columns.Add(dc1);
            foreach (Comision item in com)
            {
                if (item.turno == 0)
                {
                    table.Rows.Add(mat.id, "Mañana");
                }
                else if (item.turno == 1)
                {
                    table.Rows.Add(mat.id, "Tarde");
                }
                else
                {
                    table.Rows.Add(mat.id, "Noche");
                }
            }
            dvgMateriasDocentes.DataSource = table;
            dvgMateriasDocentes.DataBind();
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
                    if (int.TryParse(dvgMateriasDocentes.Rows[index].Cells[0].Text, out idC))
                    {
                        Comision com = cc.find(idC);
                        Session["Comision"] = com;
                        Page.Response.Redirect("~/docAluCom.aspx");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Page.Response.Redirect("~/docMaterias.aspx");
                    Session["matSel"] = null;
                }
            }
            catch (NullReferenceException)
            {
                Page.Response.Redirect("~/docMaterias.aspx");
                Session["matSel"] = null;
            }
        }
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect("~/pagDocente.aspx");
    }
}