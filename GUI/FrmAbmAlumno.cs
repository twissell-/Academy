using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bussines;
using Entidades;

namespace GUI
{
    public partial class FrmAbmAlumno : Form
    {
        ControllerAlumno ca;
        public FrmAbmAlumno()
        {
            ca = new ControllerAlumno();
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ca.insert(new Alumno(txtDni.Text, txtApellido.Text, txtNombre.Text, txtNacimiento.Text, txtTelefono.Text, txtDireccion.Text,
                txtMail.Text, txtPassword.Text));
        }
    }
}
