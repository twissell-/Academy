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
    public partial class ucMBPlanes : UserControl
    {
        ControllerPlan cp;
        ControllerEspecialidad ce;


        public ucMBPlanes()
        {
            InitializeComponent();
        }

        #region Metodos Propios

        private void loader()
        {
            cp = new ControllerPlan();
            ce = new ControllerEspecialidad();
            ucListado.Owner = ucModificaciones;
            ucModificaciones.Owner = ucListado;
            ucModificaciones.Enabled = false;
        }

        #endregion

        private void ucMBPlanes_Load(object sender, EventArgs e)
        {
            this.loader();
        }
    }
}
