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

            try
            {
                ca.insert(new Alumno(int.Parse(txtId.Text), txtDni.Text, txtApellido.Text, txtNombre.Text, txtNacimiento.Text, txtTelefono.Text, txtDireccion.Text,
                txtMail.Text, txtPassword.Text));
            }
            catch (FormatException error)
            {
                MessageBox.Show("error"+error);
                throw;
            }

            this.Dispose();
        }

        private void ShowDialog(string p)
        {
            throw new NotImplementedException();
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
