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
            this.panAdm.Controls.Clear();
            var uc = new ucListaComisiones();
            this.panAdm.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro que desea salir?", "Esta por salir del programa", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnVerAlumnos_Click(object sender, EventArgs e)
        {
            this.panAdm.Controls.Clear();
            var uc = new ucListaAlumnos();
            this.panAdm.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
         //   Form frmalu = new FrmListaAlumnos();
          //  frmalu.ShowDialog();
        }

        private void btnAgregarEspecialidad_Click(object sender, EventArgs e)
        {
            this.panAdm.Controls.Clear();
            var uc = new ucAgregarEspecialidad();
            this.panAdm.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
         //   Form esp = new FrmEspecialidades();
           // esp.ShowDialog();
        }

        private void btnAgregarComision_Click(object sender, EventArgs e)
        {
            this.panAdm.Controls.Clear();
            var uc = new ucAgregarComision();
            this.panAdm.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
           // Form com = new FrmComisiones();
           // com.ShowDialog();
        }

        private void btnAgregarPlan_Click(object sender, EventArgs e)
        {
            this.panAdm.Controls.Clear();
            Form plan = new FrmPlanes();
            plan.ShowDialog();
        }

        private void tsmAgregarComision_Click(object sender, EventArgs e)
        {
            this.panAdm.Controls.Clear();
            var uc = new ucAgregarComision();
            this.panAdm.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            this.btnSalir_Click(sender, e);
        }

        
        private void tsmAMPersona_Click(object sender, EventArgs e)
        {
            this.panAdm.Controls.Clear();
            var uc = new ucAMPersona();
            if (sender==tsmAgregarAlumno || sender==tsmAgregarDocente)
            {
                //llenar el cmbID con el correlativo de la base de datos.
            }
            else
            {
                Form inputId = new FrmInputId();
                //llenar el todos los controles con lo de la base de datos segun lo q venga del del MessageBox o Form
            }
            this.panAdm.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void tsmEliminarPersona_Click(object sender, EventArgs e)
        {
            this.panAdm.Controls.Clear();
            var uc = new ucBPersona();
            Form inputId = new FrmInputId();// para q ingrese el id y se busque etc etc
            this.panAdm.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void tsmAMMateria_Click(object sender, EventArgs e)
        {
            this.panAdm.Controls.Clear();
            var uc = new ucAMMateria();
            if (sender == tsmAgregarMateria)
            {
                //llenar el cmbID con el correlativo de la base de datos.
            }
            else
            {
                Form inputId = new FrmInputId();
                //llenar el todos los controles con lo de la base de datos segun lo q venga del del MessageBox o Form
            }
            this.panAdm.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        
  

    }
}
