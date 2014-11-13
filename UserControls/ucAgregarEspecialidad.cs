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
    public partial class ucAgregarEspecialidad : UserControl
    {

        ControllerEspecialidad ce;

        public ucAgregarEspecialidad()
        {
            InitializeComponent();
            ce = new ControllerEspecialidad();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ce.insert(new Especialidad(0, txtDescripcion.Text));
            txtDescripcion.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
            txtId.Clear();
        }
    }
}
