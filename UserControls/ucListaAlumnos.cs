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
    public partial class ucListaAlumnos : UserControl
    {
        private IControllerPersona controller;

        public ucListaAlumnos(int det)
            //det 
            //0: administrativo
            //1: docente
            //2: alumnos
        {
            InitializeComponent();
            this.dgvListaAlumnos.AutoGenerateColumns = false;
            switch (det)
            {
                case 0:
                    controller = new ControllerAdministrativo();
                    break;
                case 1:
                    controller = new ControllerDocente();
                    break;
                case 2:
                    controller = new ControllerAlumno();
                    break;
                default:
                    break;
            }
            this.dgvListaAlumnos.DataSource = controller.find();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvListaAlumnos.SelectedRows != null)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar a " + 
                    this.dgvListaAlumnos.SelectedRows[0].Cells["apellidoPersona"].Value + ", " + 
                    this.dgvListaAlumnos.SelectedRows[0].Cells["nombrePersona"].Value + "?",
                    "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    controller.delete((Persona)this.dgvListaAlumnos.SelectedRows[0].DataBoundItem);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.dgvListaAlumnos.SelectedRows != null)
            {
                if (MessageBox.Show("¿Desea guardar los cambios realizados?", "Guardar Cambios", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    controller.update((Persona)dgvListaAlumnos.SelectedRows[0].DataBoundItem);
                }

            }
        }

        private void dgvListaAlumnos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnGuardar.Enabled = true;
        }
    
    }
}
