using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Bussines;
using System.Data;

public partial class docAluCom : System.Web.UI.Page
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
        else if (Session["Comision"] == null)
        {
            Page.Response.Redirect("~/pagDocente.aspx");
        }
        if (!IsPostBack)
        {
            Comision com = (Comision)Session["Comision"];
            List<Alumno> alu = com.alumnos;
            DataTable table = new DataTable();
            DataColumn dc = new DataColumn();
            dc.ColumnName = "id";
            DataColumn dc1 = new DataColumn();
            dc1.ColumnName = "apellido";
            DataColumn dc2 = new DataColumn();
            dc2.ColumnName = "nombre";
            DataColumn dc3 = new DataColumn();
            dc3.ColumnName = "condicion";
            table.Columns.Add(dc);
            table.Columns.Add(dc1);
            table.Columns.Add(dc2);
            table.Columns.Add(dc3);
            if (com.alumnos.Count==0)
            {
                noAlFound.Text = "Ud NO tiene alumnos inscriptos en esta materia, en esta comision";
            }
            else
            {
                foreach (var item in com.alumnos)
                {
                    bool condicion = false;
                    string dsaff = item.condicion.ToString();
                    
                    if (dsaff == "0")
                    {
                        condicion = false;
                    }
                    else if (dsaff == "1")
                    {
                        condicion = true;
                    }
                    table.Rows.Add(item.id.ToString(), item.apellido, item.nombre, condicion);
                }
                dvgAluCom.DataSource = table;
                dvgAluCom.DataBind();
            }    
        }
    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        cc = new ControllerComision();
        Comision comis =(Comision) Session["Comision"];
        try
        {
            for (int i = 0; i < dvgAluCom.Rows.Count; i++)
            {
                CheckBox ckbReg = new CheckBox();
                ckbReg = dvgAluCom.Rows[i].FindControl("ckbRegular") as CheckBox;
                CheckBox ckbApr = new CheckBox();
                ckbApr = dvgAluCom.Rows[i].FindControl("ckbAprobado") as CheckBox;
                if (ckbReg.Checked == true)
                {
                    setCondicion(comis, i, 1);
                }
                else if (ckbApr.Checked == true)
                {
                    setCondicion(comis, i, 2);
                }
            }
            cc.update(comis);
        }
        catch (ArgumentOutOfRangeException)
        {
            Page.Response.Redirect("~/pagDocente.aspx");
        }
            
    }

    private void setCondicion(Comision comis, int i, int cond)
    {
        int idAl = 0;
        if (int.TryParse(dvgAluCom.Rows[i].Cells[0].Text, out idAl))
        {
            foreach (var item in comis.alumnos)
            {
                if (item.id == idAl)
                {
                    item.condicion = cond;
                }
            }
        }
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Session["Comision"] = null;
        Page.Response.Redirect("~/pagDocente.aspx");
    }
    protected void validar(object sender, EventArgs e)
    {
        CheckBox ckb = sender as CheckBox;
        for (int i = 0; i < dvgAluCom.Rows.Count; i++)
        {
            CheckBox ckbReg = new CheckBox();
            ckbReg = dvgAluCom.Rows[i].FindControl("ckbRegular") as CheckBox;
            CheckBox ckbApr = new CheckBox();
            ckbApr = dvgAluCom.Rows[i].FindControl("ckbAprobado") as CheckBox;
            
            if (ckbApr.Checked == ckbReg.Checked && ckbApr == ckb)
            {
                ckbReg.Checked = false;
            }
            if (ckbReg.Checked == ckbApr.Checked && ckbReg == ckb)
            {
                ckbApr.Checked = false;
            }
        }
    }
}