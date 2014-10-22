using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmListaDocentes : Form
    {
        public FrmListaDocentes()
        {
            InitializeComponent();
        }

        private void btnAgregarDocente_Click(object sender, EventArgs e)
        {
            Form frmAgregarDoc = new FrmAbmDocente();
            frmAgregarDoc.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            
        }

     
       
    }
}
