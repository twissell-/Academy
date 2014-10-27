using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UserControls;

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
            this.panel1.Controls.Clear();
            var uc = new ListaComisiones();
            this.panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
          
            var uc = new ABMDoc();
            this.panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
           // Form frmalu = new FrmAbmAlumno();
           // frmalu.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnVerAlumnos_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            var uc = new ListaAlumnos();
            this.panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
         //   Form frmalu = new FrmListaAlumnos();
          //  frmalu.ShowDialog();
        }

        private void btnAgregarDocente_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            var uc = new ABMDoc();
            this.panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
          
        }

        private void btnAgregarEspecialidad_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            var uc = new agregarEspecialidad();
            this.panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
         //   Form esp = new FrmEspecialidades();
           // esp.ShowDialog();
        }

        private void btnAgregarComision_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            var uc = new agregarComision();
            this.panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
           // Form com = new FrmComisiones();
           // com.ShowDialog();
        }

        private void btnAgregarPlan_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form plan = new FrmPlanes();
            plan.ShowDialog();
        } 
             
    }
}
