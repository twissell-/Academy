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
        ControllerEspecialidad ce;
        public ucListaEspecialidades()
        {
            ce = new ControllerEspecialidad();
            InitializeComponent();
            dgvListaEspecialidades.AutoGenerateColumns = false;
            dgvListaEspecialidades.DataSource = ce.find();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
