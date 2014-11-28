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
    public partial class ucAMateria : UserControl
    {
        ControllerPlan cp;
        ControllerMateria cm;
        public ucListaComisiones Owner { get; set; }

        public ucAMateria()
        {
            InitializeComponent();
            cp = new ControllerPlan();
            cm = new ControllerMateria();
        }

        #region Metodos Propios

        private void loader()
        {
            cp = new ControllerPlan();
            cm = new ControllerMateria();
            cmbPlan.DisplayMember = "descripcion";
            cmbPlan.ValueMember = "id";
            cmbPlan.DataSource = cp.find();
            this.center();
        }

        private void clear()
        {
            txtId.Text = "";
            cmbPlan.SelectedItem = "";
            txtDescripcion.Text = "";
            txtHsSemanales.Text = "";
            txtHsTotales.Text = "";
        }

        private Materia buildMateria()
        {
            return new Materia(Convert.ToInt32(txtId.Text), txtDescripcion.Text, txtHsSemanales.Value, txtHsTotales.Value, (Plan)cmbPlan.SelectedItem);
        }

        private void center()
        {
            grpMateria.Left = (this.ClientSize.Width - grpMateria.Width) / 2;
            grpMateria.Top = (this.ClientSize.Height - grpMateria.Height) / 2;
        }

        #endregion

        private void ucAMateria_Load(object sender, EventArgs e)
        {
            this.loader();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cm.update(buildMateria());
            this.clear();
        }

    }
}
