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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro que desea salir?", "Esta por salir del programa", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void tsmAgregarComision_Click(object sender, EventArgs e)
        {
            //ver
            this.panAdmGral.Controls.Clear();
            var uc = new ucAgregarComision();
            this.panAdmGral.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            this.btnSalir_Click(sender, e);
        }

        
        private void tsmAPersona_Click(object sender, EventArgs e)
        {
            this.panAdmGral.Controls.Clear();
            var uc = new ucAPersona();
            this.panAdmGral.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
        private void tsmMPersona_Click(object sender, EventArgs e)
        {
            UserControl uc;
            this.panAdmGral.Controls.Clear();
            if (sender==tsmModificarAdministrativo)
            {
                uc = new ucMPersona("MAd");
                this.panAdmGral.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }
            else if (sender==tsmModificarAlumno)
            {
                uc = new ucMPersona("MA");
                this.panAdmGral.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }
            else
            {
                uc = new ucMPersona("MD");
                this.panAdmGral.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }          
        }

        private void tsmEliminarPersona_Click(object sender, EventArgs e)
        {
            if (sender == tsmEliminarAlumno)
            {
                tsmListadoDeAlumnos_Click(sender, e);
            }
            else
            {
                tsmListadoDeDocentes_Click(sender, e);
            }
        }

        private void tsmAMMateria_Click(object sender, EventArgs e)
        {
            this.panAdmGral.Controls.Clear();
            var uc = new ucAMMateria();
            this.panAdmGral.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void tsmEliminarMateria_Click(object sender, EventArgs e)
        {
            //Form inputId = new FrmInputId();
        }

        private void tsmListadoDeMaterias_Click(object sender, EventArgs e)
        {
            //falta
        }

        private void tsmModificarComisiones_Click(object sender, EventArgs e)
        {
            //Form inputId = new FrmInputId();
        }

        private void tsmEliminarComisiones_Click(object sender, EventArgs e)
        {
            //Form inputId = new FrmInputId();
        }

        

        private void tsmListadoDeComisiones_Click(object sender, EventArgs e)
        {
            this.panAdmGral.Controls.Clear();
            var uc = new ucListaComisiones();
            this.panAdmGral.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void tsmListadoDeAlumnos_Click(object sender, EventArgs e)
        {
            this.panAdmGral.Controls.Clear();
            var uc = new ucListaAlumnos();
            this.panAdmGral.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void tsmListadoDeDocentes_Click(object sender, EventArgs e)
        {
            //falta
        }

        private void tsmAgregarEspecialidad_Click(object sender, EventArgs e)
        {
            this.panAdmGral.Controls.Clear();
            var uc = new ucAgregarEspecialidad();
            this.panAdmGral.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void tsmModificarEspecialidad_Click(object sender, EventArgs e)
        {
            this.panAdmGral.Controls.Clear();
            var uc = new ucMEspecialidad();
            this.panAdmGral.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void tsmEliminarEspecialidad_Click(object sender, EventArgs e)
        {
            this.panAdmGral.Controls.Clear();
            var uc = new ucBEspecialidad();
            this.panAdmGral.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void tsmListadoDeEspecialidades_Click(object sender, EventArgs e)
        {
            this.panAdmGral.Controls.Clear();
            var uc = new ucListaEspecialidades();
            this.panAdmGral.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void tsmAgregarPlan_Click(object sender, EventArgs e)
        {
            this.panAdmGral.Controls.Clear();
            UserControl uc = new ucAPlanes();
            this.panAdmGral.Controls.Add(uc);
            uc.Dock= DockStyle.Fill;       
        }

        private void tsmModificarPlan_Click(object sender, EventArgs e)
        {
            this.panAdmGral.Controls.Clear();
            UserControl uc = new ucMPlanes();
            this.panAdmGral.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;   
        }

        private void tsmEliminarPlan_Click(object sender, EventArgs e)
        {
            this.panAdmGral.Controls.Clear();
            UserControl uc = new ucBPlanes();
            this.panAdmGral.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;   
        }

        private void tsmListadoDePlanes_Click(object sender, EventArgs e)
        {
            this.panAdmGral.Controls.Clear();
            UserControl uc = new ucListaPlanes();
            this.panAdmGral.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;   
        }

        private void tsmReporteComisiones_Click(object sender, EventArgs e)
        {
            //falta
        }

        private void tsmReportePlanes_Click(object sender, EventArgs e)
        {
            //falta
        }

        private void tsmListadoDeAdministrativo_Click(object sender, EventArgs e)
        {
            //falta
        }

    }
}
