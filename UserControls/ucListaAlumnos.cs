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
            if (this.dgvListaAlumnos.SelectedRows != null && this.dgvListaAlumnos.SelectedRows.Count > 0)
            {
                int id = (int)this.dgvListaAlumnos.SelectedRows[0].Cells[0].Value;
                string nom = this.dgvListaAlumnos.SelectedRows[0].Cells[0].Value.ToString();
                string ape = this.dgvListaAlumnos.SelectedRows[0].Cells[0].Value.ToString();
                if (MessageBox.Show("¿Está seguro que desea eliminar a " + nom + " " + ape + "?",
                    "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    controller.delete(controller.find(id));
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
