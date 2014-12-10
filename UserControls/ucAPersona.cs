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
        private ControllerAlumno ca;
        private ControllerDocente cd;
        private ControllerTipo ct;
        private ControllerAdministrativo cad;
        public ucListaAlumnos Owner { get; set; }


        public ucAPersona()
        {
            InitializeComponent();
        }

        private void ucAPersona_Load(object sender, EventArgs e)
        {
            this.loader();
        }

        #region Metodos Propios

        public void edit(Persona p)
        {
            this.txtId.Text = p.id.ToString();
            this.cmbTipo.SelectedIndex = this.Owner.det;
            this.txtApellido.Text = p.apellido;
            this.txtNombre.Text = p.nombre;
            this.txtDireccion.Text = p.direccion;
            this.txtDni.Text = p.dni;
            this.txtMail.Text = p.mail;
            this.txtNacimiento.Text = p.nacimiento;
            this.txtTelefono.Text = p.telefono;
            btnBorrar.Enabled = btnBorrar.Visible = true;
            if (!this.Enabled)
            {
                this.Enabled = true;
            }
        }

        private void loader()
        {
            this.ca = new ControllerAlumno();
            this.cd = new ControllerDocente();
            this.cad = new ControllerAdministrativo();
            this.ct = new ControllerTipo();
            this.cmbTipo.DataSource = ct.find();
            btnBorrar.Enabled = btnBorrar.Visible = false;
        }

        private void clear()
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

        #endregion

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (((Tipo)cmbTipo.SelectedItem).id)
            {
                case 0:
                    cad.insert(new Administrativo(txtDni.Text, txtApellido.Text, txtNombre.Text, txtTelefono.Text,
                        txtDireccion.Text, txtMail.Text, txtNacimiento.Text, txtPassword.Text));
                    break;
                case 1:
                    cd.insert(new Docente(txtDni.Text, txtApellido.Text, txtNombre.Text, txtTelefono.Text,
                        txtDireccion.Text, txtMail.Text, txtNacimiento.Text, txtPassword.Text));
                    break;
                case 2:
                    ca.insert(new Alumno(txtDni.Text, txtApellido.Text, txtNombre.Text, txtTelefono.Text,
                        txtDireccion.Text, txtMail.Text, txtNacimiento.Text, txtPassword.Text));
                    break;
                default:
                    break;
            }
            this.clear();
        }

 


    }
}
