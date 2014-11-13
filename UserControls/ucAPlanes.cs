using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bussines;
using Entidades;

namespace UserControls
{
    public partial class ucAPlanes : UserControl
    {
        ControllerEspecialidad ce;
        ControllerPlan cp;
        public ucAPlanes()
        {
            InitializeComponent();
            cp = new ControllerPlan();
            ce = new ControllerEspecialidad();
        }

    
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.txtId.Clear();
            this.txtDescripcion.Clear();
          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Plan p = new Plan(Convert.ToInt32(txtId),txtDescripcion.Text,(Especialidad)cmbEspecialidad.SelectedItem);
            cp.insert(p);
        }

        private void ucAPlanes_Load(object sender, EventArgs e)
        {
            cmbEspecialidad.DataSource=ce.find();
        }
    }
}
