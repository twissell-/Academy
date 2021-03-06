﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Bussines;
using System.Data;


public partial class docMaterias : System.Web.UI.Page
{
    ControllerComision cc;
    ControllerMateria cm;
    protected void Page_Load(object sender, EventArgs e)
    {
        cc = new ControllerComision();
        cm = new ControllerMateria();
        if (Session["Persona"] == null)
        {
            Page.Response.Redirect("~/Default.aspx");
        }
        else if (Session["tipo"] is Alumno)
        {
            Page.Response.Redirect("~/pagAlumno.aspx");
        }
        if (!IsPostBack)
        {
            llenarGrid();
        }
        else
        {
            try
            {
                String eventarg = this.Request.Params.Get("__EVENTARGUMENT");
                try
                {
                    String[] das = eventarg.Split('$');
                    int index = Convert.ToInt32(das[1]);
                    int idM = 0;
                    if (int.TryParse(dvgMateriasDocentes.Rows[index].Cells[0].Text, out idM))
                    {
                        Materia mat = cm.find(idM);
                        Session["matSel"] = mat;
                        Page.Response.Redirect("~/docComisiones.aspx");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Page.Response.Redirect("~/pagDocente.aspx");
                }
            }
            catch (NullReferenceException)
            {
                Page.Response.Redirect("~/pagDocente.aspx");
            }
        }
    }

    private void llenarGrid()
    {
        List<Comision> comisionesProfesor = cc.find((Docente)Session["Persona"]);
        List<Materia> materias = new List<Materia>();
        foreach (Comision item in comisionesProfesor)
        {
            materias.Add(item.materia);
        }
        dvgMateriasDocentes.DataSource = materias;
        dvgMateriasDocentes.DataBind();
        if (materias.Count == 0)
        {
            noMatFound.Text = "Usted NO da clases en ninguna materia!";
        }
    }


    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect("~/pagDocente.aspx");
        Session["matSel"] = null;
    }
}
