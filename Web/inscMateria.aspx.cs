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
    protected void Page_Load(object sender, EventArgs e)
    {
        cc = new ControllerComision();
        ca = new ControllerAlumno();
        int Rows = 5;   //buscar cantidad de materias en db
        int Columns = 3; //desp ver bien los datos a mostrar
        int tblRows = Rows;
        int tblCols = Columns;
        TableHeaderRow hr = new TableHeaderRow();
        TableHeaderCell hc = new TableHeaderCell();
        hc.Text = "Id";
        hr.Controls.Add(hc);
        TableHeaderCell hc1 = new TableHeaderCell();
        hc1.Text = "Descripcion";
        hr.Controls.Add(hc1);
        TableHeaderCell hc2 = new TableHeaderCell();
        hc2.Text = "Inscribirse";
        hr.Controls.Add(hc2);
        this.tblMaterias.Rows.Add(hr);    
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
            this.tblMaterias.Rows.Add(tr);
        }
    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        //no implementado
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect("~/Alumno.aspx");
    }
}