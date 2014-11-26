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
    public partial class ucAMMateria : UserControl
    {
        ControllerPlan cp;
        ControllerMateria cm;

        public ucAMMateria()
        {
            InitializeComponent();
            cp = new ControllerPlan();
            cm = new ControllerMateria();
        }

        private void loader()
        {
            cp = new ControllerPlan();
            cm = new ControllerMateria();
            cmbPlan.DataSource = cp.find();
            ucListado.Owner = this;
        }

        private void enabler(bool p)
        {
            txtId.Enabled = p;
            cmbPlan.Enabled = p;
            txtDescripcion.Enabled = p;
            txtHsSemanales.Enabled = p;
            txtHsTotales.Enabled = p;
            btnBorrar.Enabled = p;
            btnGuardar.Enabled = p;
        }

        public void edit(Materia m)
        {
            txtId.Text = m.id.ToString();
            cmbPlan.SelectedItem = m.plan;
            txtDescripcion.Text = m.descripcion.ToString();
            txtHsSemanales.Text = m.hsSemanales.ToString();
            txtHsTotales.Text = m.hsTotales.ToString();
            this.enabler(true);
        }

        private void ucAMMateria_Load(object sender, EventArgs e)
        {
            this.loader();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cm.insert(new Materia(0, txtDescripcion.Text, 0, 0, (Plan)cmbPlan.SelectedItem));
            txtDescripcion.Text = "";
        }
    }
}
