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
    public partial class ucMPlanes : UserControl
    {
        ControllerPlan cp;
        public ucMPlanes()
        {
            InitializeComponent();
            cp = new ControllerPlan();
            this.dgvListaPlanesMod.AutoGenerateColumns = false;
            this.dgvListaPlanesMod.DataSource = cp.find();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListaPlanesMod.SelectedRows != null && this.dgvListaPlanesMod.SelectedRows.Count > 0)
            {
                int id = (int)this.dgvListaPlanesMod.SelectedRows[0].Cells[0].Value;
                string des = this.dgvListaPlanesMod.SelectedRows[0].Cells[1].Value.ToString();
                string esp = this.dgvListaPlanesMod.SelectedRows[0].Cells[2].Value.ToString();
                if (MessageBox.Show("¿Está seguro que desea modificar el plan " + des + " de " + esp + "?",
                    "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var pl = cp.find(id);
                    pl.descripcion= this.dgvListaPlanesMod.SelectedRows[0].Cells[1].Value.ToString();
                    pl.especialidad = (Especialidad) this.dgvListaPlanesMod.SelectedRows[0].Cells[2].Value;
                    cp.update(pl);
                }

            }
        }

  
    }
}
