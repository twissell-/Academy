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
    public partial class ucListaComisiones : UserControl
    {
        ControllerComision cc;
        public ucMBComision Owner {get; set;}

        public ucListaComisiones()
        {
            InitializeComponent();
        }

        #region Metodos Propios

        private void loader()
        {
            cc = new ControllerComision();
            dgvComisiones.AutoGenerateColumns = false;
            dgvComisiones.DataSource = cc.find();
        }

        private Comision giveSelectedComision()
        {
            return (Comision)dgvComisiones.SelectedRows[0].DataBoundItem;
        }

        public void reload()
        {
            dgvComisiones.DataSource = cc.find();
        }

        #endregion

        private void ucListaComisiones_Load(object sender, EventArgs e)
        {
            this.loader();
        }

        private void dgvComisiones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Owner != null)
            {
                Owner.edit(this.giveSelectedComision());
            }
        }


        
    }
}
