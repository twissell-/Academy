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
        }

        public ucMBPersona(int det)
            :this()
        {
            this.det = det;
            this.ucListado.det = det;
            ucModificaciones.Owner = this.ucListado;
            ucListado.Owner = this.ucModificaciones;
        }

        #region Metodos Propios

        private void loader()
        {
            //this.ucListado = new ucListaAlumnos(this.det);
            //ucModificaciones.Owner = this.ucListado;
            //ucListado.Owner = this.ucModificaciones;
            ucModificaciones.Enabled = false;
        }

        #endregion


        private void ucMBPersona_Load(object sender, EventArgs e)
        {
            this.loader();
        }
    }
}
