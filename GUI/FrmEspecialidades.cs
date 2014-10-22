using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmEspecialidades : Form
    {
        public FrmEspecialidades()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.txtDescripcion.Clear();
            this.txtId.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
