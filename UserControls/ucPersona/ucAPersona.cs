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
        public ucListaPersona Owner { get; set; }
        private Persona aux = null;
        String t = "";


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
            if (this.Owner != null)
            {
                this.Enabled = false;
            }
        }

        #endregion

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            getRol();
            int id = 0;
            if (int.TryParse(txtId.Text, out id))
            {

                if (aux is Administrativo)
                {
                    aux = (Administrativo)cad.find(id);
                    cad.delete(aux);
                }
                else if (aux is Docente)
                {
                    aux = (Docente)cd.find(id);
                    cd.delete(aux);
                }
                else
                {
                    aux = (Alumno)ca.find(id);
                    ca.delete(aux);
                }
                MessageBox.Show(t + " eliminado con exito");
            }
            this.clear();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            getRol();

            if (this.Owner == null)
            {
                if (aux is Administrativo)
                {
                    cad.insert(new Administrativo(txtDni.Text, txtApellido.Text, txtNombre.Text, txtTelefono.Text,
                        txtDireccion.Text, txtMail.Text, txtNacimiento.Text, txtPassword.Text));
                }
                else if (aux is Administrativo)
                {
                    cd.insert(new Docente(txtDni.Text, txtApellido.Text, txtNombre.Text, txtTelefono.Text,
                        txtDireccion.Text, txtMail.Text, txtNacimiento.Text, txtPassword.Text));
                }
                else
                {
                    ca.insert(new Alumno(txtDni.Text, txtApellido.Text, txtNombre.Text, txtTelefono.Text,
                        txtDireccion.Text, txtMail.Text, txtNacimiento.Text, txtPassword.Text));
                }

            }
            else
            {
                int id = 0;
                if (int.TryParse(txtId.Text, out id))
                {

                    if (aux is Administrativo)
                    {
                        aux = (Administrativo)cad.find(id);
                        completarDatos(aux);
                        cad.update(aux);
                    }
                    else if (aux is Docente)
                    {
                        aux = (Docente)cd.find(id);
                        completarDatos(aux);
                        cd.update(aux);
                    }
                    else
                    {
                        aux = (Alumno)ca.find(id);
                        completarDatos(aux);
                        ca.update(aux);
                    }
                    MessageBox.Show(t+" modificado con exito");
                }
                this.clear();
            }
        }

        private void getRol()
        {
            switch (((Tipo)cmbTipo.SelectedItem).id)
            {
                case 0:
                    aux = new Administrativo();
                    t = "Administrativo";
                    break;
                case 1:
                    aux = new Docente();
                    t = "Docente";
                    break;
                case 2:
                    aux = new Alumno();
                    t = "Alumno";
                    break;
                default:
                    break;
            }
        }

        private void completarDatos(Persona aux)
        {
            aux.dni = txtDni.Text;
            aux.apellido = txtApellido.Text;
            aux.nombre = txtNombre.Text;
            aux.telefono = txtTelefono.Text;
            aux.direccion = txtDireccion.Text;
            aux.mail = txtMail.Text;
            aux.nacimiento = txtNacimiento.Text;
           // aux.password = txtPassword.Text;
        }
    }
}
