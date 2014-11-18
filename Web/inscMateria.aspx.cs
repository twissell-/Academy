using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP;

public partial class inscMateria : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ContentPlaceHolder MainContent = new ContentPlaceHolder();
        int Rows = 5;   //buscar cantidad de materias en db
        int Columns = 6; //desp ver bien los datos a mostrar
        int tblRows = Rows;
        int tblCols = Columns;
        
        Table tbl = new Table();
        MainContent.Controls.Add(tbl);
        
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
    }
}