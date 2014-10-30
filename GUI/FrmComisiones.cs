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
    public partial class FrmComisiones : Form
    {
        public FrmComisiones()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        { 
            Form frmdoc=new FrmListaDocentes();
            frmdoc.ShowDialog();                   
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
          //  Form frmalu = new FrmListaAlumnos();
          //    frmalu.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtMateria.Clear();
            cmbTurno.ResetText();
        }
    }
}
