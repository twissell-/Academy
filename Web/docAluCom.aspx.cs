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
            dc.ColumnName = "Id";
            DataColumn dc1 = new DataColumn();
            dc1.ColumnName = "Apellido";
            DataColumn dc2 = new DataColumn();
            dc2.ColumnName = "Nombre";
            table.Columns.Add(dc);
            table.Columns.Add(dc1);
            table.Columns.Add(dc2);
            DataColumn dc3 = new DataColumn("Regular",typeof (bool));
            DataColumn dc4 = new DataColumn("Aprobado", typeof (bool));
            table.Columns.Add(dc3);
            table.Columns.Add(dc4);
            if (com.alumnos.Count == 0)
            {
                noAlFound.Text = "Ud NO tiene alumnos inscriptos en esta materia, en esta comision";
            }
            else
            {
                bool reg = false; 
                bool apr = false;
                foreach (var item in com.alumnos)
                {
                    if (item.condicion == 1)
                    {
                        reg = true;
                        apr = false;
                        table.Rows.Add(item.id.ToString(), item.apellido, item.nombre, reg, apr);
                    }
                    else if (item.condicion == 2)
                    {
                        reg = false;
                        apr = true;
                        table.Rows.Add(item.id.ToString(), item.apellido, item.nombre, reg, apr);
                    }
                    else
                    {
                        table.Rows.Add(item.id.ToString(), item.apellido, item.nombre, reg, apr);
                    }
                    dvgAluCom.DataSource = table;
                    dvgAluCom.DataBind(); 
                }
            }
        }
    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        cc = new ControllerComision();
        Comision comis = (Comision)Session["Comision"];
        try
        {
            for (int i = 0; i < dvgAluCom.Rows.Count; i++)
            {
                CheckBox cbReg = new CheckBox();
                cbReg = dvgAluCom.Rows[i].FindControl("cbRegular") as CheckBox;
                CheckBox cbApr = new CheckBox();
                cbApr = dvgAluCom.Rows[i].FindControl("cbAprobado") as CheckBox;
                if (cbReg.Checked == true)
                {
                    setCondicion(comis, i, 1);
                }
                else if (cbApr.Checked == true)
                {
                    setCondicion(comis, i, 2);
                }
                else
                {
                    setCondicion(comis, i, 0);
                }
            }
            cc.update(comis);
            lblAct.Text = "Se han actualizado los estados";
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
            CheckBox cbReg = new CheckBox();
            cbReg = dvgAluCom.Rows[i].FindControl("cbRegular") as CheckBox;
            CheckBox cbApr = new CheckBox();
            cbApr = dvgAluCom.Rows[i].FindControl("cbAprobado") as CheckBox;

            if (cbApr.Checked == cbReg.Checked && cbApr == ckb)
            {
                cbReg.Checked = false;
            }
            if (cbReg.Checked == cbApr.Checked && cbReg == ckb)
            {
                cbApr.Checked = false;
            }
        }
    }
}