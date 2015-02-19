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
using Util;

namespace UserControls
{
    public partial class ucMBMateria : UserControl
    {
        ControllerPlan cp;
        ControllerMateria cm;
        ControllerComision cc;

        public ucMBMateria()
        {
            InitializeComponent();
        }

        #region Metodos Propios

        private void loader()
        {
            cp = new ControllerPlan();
            cm = new ControllerMateria();
            cc = new ControllerComision();
            cmbPlan.DisplayMember = "descripcion";
            cmbPlan.ValueMember = "id";
            cmbPlan.DataSource = cp.find();
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            ucListado.Owner = this;
        }

        private void enabler(bool p)
        {
            cmbPlan.Enabled = p;
            txtDescripcion.Enabled = p;
            txtHsSemanales.Enabled = p;
            txtHsTotales.Enabled = p;
            btnBorrar.Enabled = p;
            btnGuardar.Enabled = p;
        }

        public void edit(Materia m)
        {
            txtId.Text = m.id.ToString();
            cmbPlan.SelectedValue = m.plan.id;
            txtDescripcion.Text = m.descripcion.ToString();
            txtHsSemanales.Text = m.hsSemanales.ToString();
            txtHsTotales.Text = m.hsTotales.ToString();
            this.enabler(true);
        }

        private void clear()
        {
            txtId.Text = "";
            cmbPlan.SelectedItem = "";
            txtDescripcion.Text = "";
            txtHsSemanales.Text = "";
            txtHsTotales.Text = "";
            this.enabler(false);
            ucListado.reload();
        }

        private Materia buildMateria()
        {
            return new Materia(Convert.ToInt32(txtId.Text),txtDescripcion.Text, txtHsSemanales.Value, txtHsTotales.Value, (Plan)cmbPlan.SelectedItem);
        }

        #endregion

        private void ucAMMateria_Load(object sender, EventArgs e)
        {
            this.loader();
        }
            
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validator.validateTexto(txtDescripcion.Text))
            {
                cm.update(buildMateria());
                MessageBox.Show("Materia modificada con exito");
                this.clear();
            }
            else
            {
                MessageBox.Show("La descripcion debe ser solo letras");
            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Materia m = buildMateria();
            List<Comision> listaComisiones=cc.find(m);
            foreach (Comision item in listaComisiones)
            {
                cc.delete(item);
            }
            cm.delete(m);
            MessageBox.Show("Materia eliminada con exito");
            this.clear();
        }
    }
}
