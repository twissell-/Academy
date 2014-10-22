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
    public partial class FrmAbmDocente : Form
    {
        public FrmAbmDocente()
        {
            InitializeComponent();
        }

       

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.txtApellido.Clear();
            this.txtNombre.Clear();
            this.txtDireccion.Clear();
            this.txtDni.Clear();
            this.txtMail.Clear();
            this.txtNacimiento.Clear();
            this.txtTelefono.Clear();
            this.txtPassword.Clear();
            this.txtConfirmar.Clear();
            this.txtId.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
