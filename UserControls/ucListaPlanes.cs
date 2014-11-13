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
    public partial class ucListaPlanes : UserControl
    {
        ControllerPlan cp;
        public ucListaPlanes()
        {
            cp = new ControllerPlan();
            InitializeComponent();
            dgvListaPlanes.AutoGenerateColumns = false;
            dgvListaPlanes.DataSource = cp.find();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
