using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserControls
{
    public partial class ucMBComision : UserControl
    {
        public ucMBComision()
        {
            InitializeComponent();
            this.loader();
        }

        #region Metodos Propios

        private void loader()
        {
            this.ucModificaciones.Enabled = false;
            this.ucListado.Owner = this.ucModificaciones;
            this.ucModificaciones.Owner = this.ucListado;
        }

        #endregion

        private void ucListado_Load(object sender, EventArgs e)
        {
            this.loader();
        }
    }
}
