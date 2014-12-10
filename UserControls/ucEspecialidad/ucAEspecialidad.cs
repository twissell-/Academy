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
    public partial class ucAEspecialidad : UserControl
    {

        ControllerEspecialidad ce;
        public ucListaEspecialidades Owner { get; set; }

        public ucAEspecialidad()
        {
            InitializeComponent();
        }

        #region Metodos Propios

        private void loader()
        {
            ce = new ControllerEspecialidad();
            btnBorrar.Visible = btnBorrar.Enabled = false;
        }

        private void clear()
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
            if (Owner != null)
            {
                btnBorrar.Visible = btnBorrar.Enabled = true;
                Owner.reload();
                this.Enabled = false;
            }
        }

        private Especialidad buildEspecialidad()
        {
            return new Especialidad(Owner != null ? Convert.ToInt32(txtId.Text) : 0, txtDescripcion.Text);
        }

        public void edit(Especialidad e)
        {
            if (!this.Enabled)
            {
                this.Enabled = true;
            }
            this.txtId.Text = e.id.ToString();
            this.txtDescripcion.Text = e.descripcion;
            btnBorrar.Visible = btnBorrar.Enabled = true;
        }

        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ce.insert(new Especialidad(this.Owner != null ? Convert.ToInt32(txtId.Text) : 0, txtDescripcion.Text));
            this.clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ce.delete(buildEspecialidad());
            this.clear();
        }

        private void ucAEspecialidad_Load(object sender, EventArgs e)
        {
            this.loader();
        }
    }
}
