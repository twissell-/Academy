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
    public partial class ucBEspecialidad : UserControl
    {
        ControllerEspecialidad ce;
        public ucBEspecialidad()
        {
            ce = new ControllerEspecialidad();
            InitializeComponent();
            dgvListaEspecialidadesBaja.AutoGenerateColumns = false;
            dgvListaEspecialidadesBaja.DataSource = ce.find();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
             if (this.dgvListaEspecialidadesBaja.SelectedRows != null && this.dgvListaEspecialidadesBaja.SelectedRows.Count > 0)
            {
                int id = (int)this.dgvListaEspecialidadesBaja.SelectedRows[0].Cells[0].Value;
                string des = this.dgvListaEspecialidadesBaja.SelectedRows[0].Cells[1].Value.ToString();
               
                if (MessageBox.Show("¿Está seguro que desea eliminar la especialidad " + des + "?",
                    "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ce.delete(ce.find(id));
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para eliminarla", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
    }
}
