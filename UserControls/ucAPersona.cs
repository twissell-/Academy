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
        ControllerDocente cd;
        ControllerTipo ct;
        ControllerAdministrativo cad;

        public ucAPersona()
        {
            ca = new ControllerAlumno();
            cd = new ControllerDocente();
            cad = new ControllerAdministrativo();
            ct = new ControllerTipo();
            InitializeComponent();
        }

        private void ucAPersona_Load(object sender, EventArgs e)
        {
            cmbTipo.DataSource = ct.find();
        }

        private void Clear()
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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (((Tipo)cmbTipo.SelectedItem).id)
            {
                case 0:
                    cad.insert(new Administrativo(txtNombre.Text, txtApellido.Text, txtDni.Text, txtTelefono.Text,
                        txtDireccion.Text, txtMail.Text, txtNacimiento.Text, txtPassword.Text));
                    break;
                case 1:
                    cd.insert(new Docente(txtNombre.Text, txtApellido.Text, txtDni.Text, txtTelefono.Text,
                        txtDireccion.Text, txtMail.Text, txtNacimiento.Text, txtPassword.Text));
                    break;
                case 2:
                    ca.insert(new Alumno(txtNombre.Text, txtApellido.Text, txtDni.Text, txtTelefono.Text,
                        txtDireccion.Text, txtMail.Text, txtNacimiento.Text, txtPassword.Text));
                    break;
                default:
                    break;
            }
            this.Clear();
        }
    }
}
