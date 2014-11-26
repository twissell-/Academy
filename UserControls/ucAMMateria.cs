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

        private void clear()
        {
            txtId.Text = "";
            cmbPlan.SelectedItem = "";
            txtDescripcion.Text = "";
            txtHsSemanales.Text = "";
            txtHsTotales.Text = "";
            this.enabler(false);
            ucListado.reload();
        }
        private void ucAMMateria_Load(object sender, EventArgs e)
        {
            this.loader();
        }

        private Materia buildMateria()
        {
            return new Materia(Convert.ToInt32(txtId.Text), txtDescripcion.Text, txtHsSemanales.Value, txtHsTotales.Value, (Plan)cmbPlan.SelectedItem);
        }
            
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cm.update(buildMateria());
            this.clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            cm.delete(buildMateria());
            this.clear();
        }
    }
}
