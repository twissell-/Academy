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

        private void ucAMMateria_Load(object sender, EventArgs e)
        {
            cmbPlan.DataSource = cp.find();
            cmbPlan.DisplayMember = "Plan.name";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cm.insert(new Materia(0, txtDescripcion.Text, 0, 0, (Plan)cmbPlan.SelectedItem));
            txtDescripcion.Text = "";
        }
    }
}
