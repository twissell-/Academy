using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Bussines;

namespace UserControls
{
    public partial class ucBPlanes : UserControl
    {
        ControllerPlan cp;
        public ucBPlanes()
        {
            cp = new ControllerPlan();
            InitializeComponent();
            dgvListaPlanesBaja.AutoGenerateColumns = false;
            dgvListaPlanesBaja.DataSource = cp.find();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvListaPlanesBaja.SelectedRows != null && this.dgvListaPlanesBaja.SelectedRows.Count > 0)
            {
                int id = (int)this.dgvListaPlanesBaja.SelectedRows[0].Cells[0].Value;
                string des = this.dgvListaPlanesBaja.SelectedRows[0].Cells[1].Value.ToString();
                string esp = this.dgvListaPlanesBaja.SelectedRows[0].Cells[2].Value.ToString();
                if (MessageBox.Show("¿Está seguro que desea eliminar el plan " + des + " de " + esp + "?",
                    "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cp.delete(cp.find(id));
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para eliminarla", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
