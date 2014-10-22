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
    public partial class FrmListaAlumnos : Form
    {
        public FrmListaAlumnos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            Form frmAgregarAlu = new FrmAbmAlumno();
            frmAgregarAlu.ShowDialog();
        }
    }
}
