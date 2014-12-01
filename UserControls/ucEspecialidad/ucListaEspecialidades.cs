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
    public partial class ucListaEspecialidades : UserControl
    {
        private ControllerEspecialidad ce;
        public ucAEspecialidad Owner { get; set; }

        public ucListaEspecialidades()
        {
            InitializeComponent();
        }

        #region Metodos Propios

        private void loader()
        {
            dgvListaEspecialidades.AutoGenerateColumns = false;
            ce = new ControllerEspecialidad();
            dgvListaEspecialidades.DataSource = ce.find();
            
        }

        private Especialidad giveSelectedEspecialidad()
        {
            return (Especialidad)dgvListaEspecialidades.SelectedRows[0].DataBoundItem;
        }

        internal void reload()
        {
            dgvListaEspecialidades.DataSource = ce.find();
        }

        #endregion

        private void ucListaEspecialidades_Load(object sender, EventArgs e)
        {
            this.loader();
        }

        private void dgvListaEspecialidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Owner != null)
            {
                Owner.edit(this.giveSelectedEspecialidad());
            }
        }


        
    }
}
