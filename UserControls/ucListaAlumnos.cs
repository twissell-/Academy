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

        private Persona giveSelectedPersona()
        {
            return (Persona)dgvListaAlumnos.SelectedRows[0].DataBoundItem;
        }

        #endregion

        private void ucListaAlumnos_Load(object sender, EventArgs e)
        {
            this.loader();
        }

        private void dgvListaAlumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListaAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Owner != null)
            {
                Owner.edit(this.giveSelectedPersona());
            }
        }
    }
}
