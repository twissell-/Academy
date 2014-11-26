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
    public partial class ucListaMateria : UserControl
    {
        private ControllerMateria cm;
        public ucAMMateria Owner {get; set;}

        public ucListaMateria()
        {
            InitializeComponent();
        }

        private void ucListadoMateria_Load(object sender, EventArgs e)
        {
            this.loader();
        }

        private void loader()
        {
            cm = new ControllerMateria();
            dgvMaterias.AutoGenerateColumns = false;
            dgvMaterias.DataSource = cm.find();
        }

        private Materia giveSelectedMateria()
        {
            return (Materia)dgvMaterias.SelectedRows[0].DataBoundItem;
        }

        private void dgvMaterias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Owner.edit(this.giveSelectedMateria());
        }

        internal void reload()
        {
            dgvMaterias.DataSource = cm.find();
        }
    }
}
