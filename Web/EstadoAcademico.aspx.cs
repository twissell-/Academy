using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bussines;
using Entidades;
using System.Data;

public partial class EstadoAcademico : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ControllerComision cc;
        if (Session["Persona"] == null)
        {
            Page.Response.Redirect("~/Default.aspx");
        }
        else if (Session["tipo"] is Docente)
        {
            Page.Response.Redirect("~/pagDocente.aspx");
        }
        else
        {
            cc = new ControllerComision();
            List<Comision> com = cc.find((Alumno)Session["Persona"]);
            Alumno al = (Alumno)Session["Persona"];
            DataTable table = new DataTable();
            DataColumn dc = new DataColumn();
            dc.ColumnName = "id";
            DataColumn dc1 = new DataColumn();
            dc1.ColumnName = "descripcion";
            DataColumn dc2 = new DataColumn();
            dc2.ColumnName = "condicion";
            table.Columns.Add(dc);
            table.Columns.Add(dc1);
            table.Columns.Add(dc2);
            foreach (var item in com)
            {
                foreach(var dsa in item.alumnos)
			    {
                    if (dsa.id == al.id)
                    {
                        string condicion = null;
                        string dsaff = dsa.condicion.ToString();
                        if (dsaff=="0")
                        {
                            condicion = "Inscripto";
                        }
                        else if (dsaff=="1")
                        {
                            condicion = "Regular";
                        }
                        else
                        {
                            condicion = "Aprobado";
                        }
                       
                        table.Rows.Add(item.materia.id.ToString(),item.materia.descripcion.ToString(), condicion);
                    }
			    }     
            }
            dvgEstadoAcademico.DataSource = table;
            dvgEstadoAcademico.DataBind();
        }
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect("~/pagAlumno.aspx");   
    }
}