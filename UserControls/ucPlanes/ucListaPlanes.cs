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
    public partial class ucListaPlanes : UserControl
    {
        ControllerPlan cp;
        public ucAPlanes Owner { get; set; }

        public ucListaPlanes()
        {
            InitializeComponent();
        }

        #region Metodos Propios

        private void loader()
        {
            cp = new ControllerPlan();
            dgvListaPlanes.AutoGenerateColumns = false;
            dgvListaPlanes.DataSource = cp.find();
        }

        private Plan giveSelectedPlan()
        {
            return (Plan)dgvListaPlanes.SelectedRows[0].DataBoundItem;
        }

        public void reload()
        {
            dgvListaPlanes.DataSource = cp.find();
        }

        #endregion

        private void ucListaPlanes_Load(object sender, EventArgs e)
        {
            this.loader();
        }

        private void dgvListaPlanes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Owner != null)
            {
                Owner.edit(this.giveSelectedPlan());
            }
        }
    }
}
