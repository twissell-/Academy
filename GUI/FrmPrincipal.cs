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
            this.panAdmGral.Controls.Clear();
            var uc = new ucAgregarComision();
            this.panAdmGral.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            this.btnSalir_Click(sender, e);
        }

        
        private void tsmAMPersona_Click(object sender, EventArgs e)
        {
            this.panAdmGral.Controls.Clear();
            var uc = new ucAMPersona();
            if (sender==tsmAgregarAlumno || sender==tsmAgregarDocentes)
            {
                //llenar el cmbID con el correlativo de la base de datos.
            }
            else
            {   
               // Form inputId = new FrmInputId(); 
              //  DialogResult res= inputId.ShowDialog();
             //   DialogResult inputId.
                
           //     llenar el todos los controles con lo de la base de datos segun lo q venga del del MessageBox o Form
            }
            this.panAdmGral.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void tsmEliminarPersona_Click(object sender, EventArgs e)
        {
            /*
            Form inp = new FrmInputId();
            //inp.ShowDialog();
         */
            this.panAdmGral.Controls.Clear();
           // var uc = new ucBPersona(inp);
            var uc = new ucListaAlumnos();
            this.panAdmGral.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
             
        }

        private void tsmAMMateria_Click(object sender, EventArgs e)
        {
            this.panAdmGral.Controls.Clear();
            var uc = new ucAMMateria();
            if (sender == tsmAgregarMateria)
            {
                //llenar el cmbID con el correlativo de la base de datos.
            }
            else
            {
             //   Form inputId = new FrmInputId();
                //llenar el todos los controles con lo de la base de datos segun lo q venga del del MessageBox o Form
            }
            this.panAdmGral.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void tsmEliminarMateria_Click(object sender, EventArgs e)
        {
            //Form inputId = new FrmInputId();
        }

        private void tsmListadoDeMaterias_Click(object sender, EventArgs e)
        {

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
            //Form inputId = new FrmInputId();
        }

        private void tsmEliminarEspecialidad_Click(object sender, EventArgs e)
        {
           // Form inputId = new FrmInputId();
        }

        private void tsmListadoDeEspecialidades_Click(object sender, EventArgs e)
        {
            //falta
        }

        private void tsmAgregarPlan_Click(object sender, EventArgs e)
        {
            this.panAdmGral.Controls.Clear();
            Form plan = new FrmPlanes();
            plan.ShowDialog();
        }

        private void tsmModificarPlan_Click(object sender, EventArgs e)
        {
           // Form inputId = new FrmInputId();
        }

        private void tsmEliminarPlan_Click(object sender, EventArgs e)
        {
          //  Form inputId = new FrmInputId();
        }

        private void tsmListadoDePlanes_Click(object sender, EventArgs e)
        {
            //falta
        }

        private void tsmReporteComisiones_Click(object sender, EventArgs e)
        {
            //falta
        }

        private void tsmReportePlanes_Click(object sender, EventArgs e)
        {
            //falta
        }

    }
}
