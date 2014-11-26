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
    ControllerMateria cm;
    protected void Page_Load(object sender, EventArgs e)
    {
        cc = new ControllerComision();
        ca = new ControllerAlumno();
        cm = new ControllerMateria();
        List<Materia> materias = new List<Materia>();
        materias = cm.find();
        int Rows=materias.Count;
        //int Rows = 5;   /d/buscar cantidad de materias en db
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
        foreach (var mat in materias)
	    {
		    TableRow tr = new TableRow();
            TableCell tc = new TableCell();
            TextBox txtBox = new TextBox();
            txtBox.Text = mat.id.ToString();
            tc.Controls.Add(txtBox);
            tr.Cells.Add(tc);
            TableCell tc2 = new TableCell();
            TextBox txtBox2 = new TextBox();
            txtBox.Text = mat.descripcion.ToString();
            tc.Controls.Add(txtBox);
            tr.Cells.Add(tc);
            this.tblMaterias.Rows.Add(tr);
	    }
        /*for (int i = 0; i < tblRows; i++)
        {
            TableRow tr = new TableRow();
            TableCell tc = new TableCell();
            TextBox txtBox = new TextBox();
            txtBox.Text = mat[i].id.ToString();
            tc.Controls.Add(txtBox);
            tr.Cells.Add(tc);
            for (int j = 0; j < tblCols-1; j++)
            {
                TableCell tc = new TableCell();
                TextBox txtBox = new TextBox();
                txtBox.Text = mat[i].id.ToString();
                tc.Controls.Add(txtBox);   
                tr.Cells.Add(tc);
            } */           
            //this.tblMaterias.Rows.Add(tr);
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