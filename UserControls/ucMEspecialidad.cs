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
    public partial class ucMEspecialidad : UserControl
    {
        ControllerEspecialidad ce;
        public ucMEspecialidad()
        {
            ce = new ControllerEspecialidad();
            InitializeComponent();
            dgvListaEspecialidadesModificar.AutoGenerateColumns = false;
            dgvListaEspecialidadesModificar.DataSource = ce.find();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (this.dgvListaEspecialidadesModificar.SelectedRows != null && this.dgvListaEspecialidadesModificar.SelectedRows.Count > 0)
            {
                int id = (int)this.dgvListaEspecialidadesModificar.SelectedRows[0].Cells[0].Value;
                string des = this.dgvListaEspecialidadesModificar.SelectedRows[0].Cells[1].Value.ToString();
                
                if (MessageBox.Show("¿Está seguro que desea modificar a " + des + "?",
                    "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var es = ce.find(id);
                    es.descripcion= this.dgvListaEspecialidadesModificar.SelectedRows[0].Cells[1].Value.ToString();
                    ce.update(es);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para modificarla", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
