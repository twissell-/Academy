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
    public partial class ucMBPersona : UserControl
    {
        private int det;

        public ucMBPersona()
        {
            InitializeComponent();
            this.loader();
        }

        public ucMBPersona(int det)
            :this()
        {
            this.det = det;
        }

        #region Metodos Propios

        private void loader()
        {
            ucListado = new ucListaAlumnos(this.det);
            ucModificaciones.Owner = ucListado;
            ucListado.Owner = ucModificaciones;
            ucModificaciones.Enabled = false;
        }

        #endregion

    }
}
