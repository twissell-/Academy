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
        public ucAPersona Owner { get; set; }
        public int det { get; private set; }


        public ucListaAlumnos()
        {
            InitializeComponent();
        }

        public ucListaAlumnos(int det)
            :this()
            //det 
            //0: administrativo
            //1: docente
            //2: alumnos
        {
            this.det = det;
        }

        #region Metodos Propios

        private void loader()
        {
            this.dgvListaAlumnos.AutoGenerateColumns = false;
            switch (this.det)
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
            if (this.Owner != null)
            {
                this.dgvListaAlumnos.Columns[4].Visible = false;
                this.dgvListaAlumnos.Columns[5].Visible = false;
                this.dgvListaAlumnos.Columns[6].Visible = false;
                this.dgvListaAlumnos.Columns[7].Visible = false;
            }
        }

        #endregion

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
    }
}
