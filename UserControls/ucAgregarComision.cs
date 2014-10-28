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
    public partial class ucAgregarComision : UserControl
    {
        public ucAgregarComision()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.txtHsSemanales.Clear();
            this.txtHsTotales.Clear();
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {

        }
    }
}
