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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnVerCursos_Click(object sender, EventArgs e)
        {
            Form comi = new FrmComisiones();
            comi.ShowDialog();
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            Form frmalu = new FrmAbmAlumno();
            frmalu.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnVerAlumnos_Click(object sender, EventArgs e)
        {
            Form frmalu = new FrmListaAlumnos();
            frmalu.ShowDialog();
        }

        private void btnAgregarDocente_Click(object sender, EventArgs e)
        {
            Form frmdoc = new FrmAbmDocente();
            frmdoc.ShowDialog();
        }

        private void btnAgregarEspecialidad_Click(object sender, EventArgs e)
        {
            Form esp = new FrmEspecialidades();
            esp.ShowDialog();
        }

        private void btnAgregarComision_Click(object sender, EventArgs e)
        {
            Form com = new FrmComisiones();
            com.ShowDialog();
        }

        private void btnAgregarPlan_Click(object sender, EventArgs e)
        {
            Form plan = new FrmPlanes();
            plan.ShowDialog();
        }
    }
}
