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
    public partial class FrmPrincipal0 : Form
    {
        public FrmPrincipal0()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtId.Text=="admin" && txtContraseña.Text=="admin")
            {
                Form administrador = new FrmPrincipal();
                administrador.ShowDialog();
            }
        }

        private void Intro(object sender, KeyPressEventArgs e)
        {
            this.btnIngresar_Click(sender, e);
        }
    }
}
