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
    public partial class ucMBEspecialidad : UserControl
    {
        ControllerEspecialidad ce;

        public ucMBEspecialidad()
        {
            InitializeComponent();
        }

        private void loader()
        {
            ce = new ControllerEspecialidad();
            ucListado.Owner = ucModificaciones;
            ucModificaciones.Owner = ucListado;
            ucModificaciones.Enabled = false;
        }

        private void ucMBEspecialidad_Load(object sender, EventArgs e)
        {
            this.loader();
        }
    }
}
