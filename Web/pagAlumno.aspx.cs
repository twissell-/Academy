﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Bussines;

public partial class pagAlumno : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Persona"] == null)
        {
            Page.Response.Redirect("~/Default.aspx");
        }
        else if (Session["tipo"] is Docente)
        {
            Page.Response.Redirect("~/pagDocente.aspx");
        }else
            {
                Alumno alu = (Alumno)Session["Persona"];
                lblNombre.Text = "Bienvenido " + alu.apellido + " " + alu.nombre;
            }
    }
}