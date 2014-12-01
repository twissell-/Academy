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
    public partial class ucAPlanes : UserControl
    {
        ControllerEspecialidad ce;
        ControllerPlan cp;
        public ucListaPlanes Owner { get; set; }

        public ucAPlanes()
        {
            InitializeComponent();
        }

        #region Metodos Propios

        private void loader()
        {
            cp = new ControllerPlan();
            ce = new ControllerEspecialidad();
            cmbEspecialidad.ValueMember = "id";
            cmbEspecialidad.DisplayMember = "descripcion";
            cmbEspecialidad.DataSource = ce.find();
            btnBorrar.Visible = btnBorrar.Enabled = false;
        }

        private void clear()
        {
            this.txtId.Clear();
            this.txtDescripcion.Clear();
            this.cmbEspecialidad.DataSource = ce.find();
            if (this.Owner != null)
            {
                Owner.reload();
                btnBorrar.Visible = btnBorrar.Enabled = false;
            }
        }

        private Plan bulidPlan()
        {
            return new Plan(txtId.Text != "" ? Convert.ToInt32(txtId.Text) : 0, 
                txtDescripcion.Text,(Especialidad)cmbEspecialidad.SelectedItem);
        }

        private void enabler(bool p)
        {
            txtDescripcion.Enabled = p;
            cmbEspecialidad.Enabled = p;
            btnGuardar.Enabled = p;
            btnBorrar.Visible = p;
            btnBorrar.Enabled = p;
        }

        public void edit(Plan p)
        {
            txtId.Text = p.id.ToString();
            txtDescripcion.Text = p.descripcion;
            cmbEspecialidad.SelectedValue = p.especialidad.id;
            this.enabler(true);
            if (!this.Enabled)
            {
                this.Enabled = true;
            }
        }

        #endregion

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            cp.delete(bulidPlan());
            this.clear();
            this.enabler(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                cp.insert(this.bulidPlan());
            }
            else
            {
                cp.update(this.bulidPlan());
                this.enabler(false);
            }
            this.clear();
        }

        private void ucAPlanes_Load(object sender, EventArgs e)
        {
            this.loader();
        }
    }
}
