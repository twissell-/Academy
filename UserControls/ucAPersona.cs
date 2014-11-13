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
    public partial class ucAPersona : UserControl
    {
       ControllerAlumno ca;
        //faltan controllers
        public ucAPersona()
        {
            ca = new ControllerAlumno();
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
                MessageBox.Show("error" + error);
                throw;
            }
        }

 


    }
}
