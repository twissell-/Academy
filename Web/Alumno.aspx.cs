using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Bussines;

public partial class Alumno : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Persona"] == null)
        {
            Page.Response.Redirect("~/Default.aspx");
        }
        else /*if (Session["Persona"].Equals(Docente))
        {
            
        }*/
        {
            Persona alu = (Persona)Session["Persona"];
            lblNombre.Text = "Bienvenido " + alu.apellido + " " + alu.nombre;
        }
    }
    protected void linkSalir_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        //Session["Persona"] = null;
        Page.Response.Redirect("~/Default.aspx");
    }

    protected void linkInscMaterias_Click(object sender, EventArgs e)
    {
       /* int Rows = 5;   //buscar cantidad de materias en db
        int Columns = 6; //desp ver bien los datos a mostrar
        int tblRows = Rows;
        int tblCols = Columns;
        Table tbl = new Table();
        //   MainContent.Controls.Add(tbl);
        this.Controls.Add(tbl);

        for (int i = 0; i < tblRows; i++)
        {
            TableRow tr = new TableRow();
            for (int j = 0; j < tblCols; j++)
            {
                TableCell tc = new TableCell();
                TextBox txtBox = new TextBox();
                txtBox.Text = "RowNo:" + i + " " + "ColumnNo:" + " " + j;

                tc.Controls.Add(txtBox);

                tr.Cells.Add(tc);
            }

            tbl.Rows.Add(tr);
        }
      //  this.panel.Controls.Add(tbl);*/
        Page.Response.Write("DSA");
        //Page.Response.Redirect("~/inscMateria.aspx");
    }
}