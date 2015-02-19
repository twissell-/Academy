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
using Util;

namespace UserControls
{
    public partial class ucAPersona : UserControl
    {
        private ControllerAlumno ca;
        private ControllerDocente cd;
        private ControllerTipo ct;
        private ControllerAdministrativo cad;
        private ControllerComision cc;
        public ucListaPersona Owner { get; set; }     

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
            this.cmbTipo.Enabled = false;
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
            this.cc = new ControllerComision();
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
            Persona aux = getRol();
            String t = null; 
      
            int id = 0;
            if (int.TryParse(txtId.Text, out id))
            {
                if (aux is Docente)
                {
                    t = "Docente";
                    aux = (Docente)cd.find(id);
                    List<Comision>com=cc.find((Docente)aux);
                    if (com.Count!=0)
                    {
                        foreach (Comision item in com)
                        {
                            cc.upComision((Docente)aux, item);
                        }
                    }
                    cd.delete(aux);
                    
                } else if(aux is Alumno)
                    {
                        t = "Alumno";
                        aux = (Alumno)ca.find(id);
                        List<Comision> com = cc.find((Alumno)aux);
                        if (com.Count!=0)
                        {
                            foreach (Comision item in com)
                            {
                                cc.upComision((Alumno)aux, item);
                            }    
                        }
                        ca.delete(aux);
                        
                    }else {
                        t = "Administrativo";
                        aux = (Administrativo)cad.find(id);
                        cad.delete(aux);
                        }
                }            
            Owner.reload();
            this.loader();
                MessageBox.Show(t + " eliminado con exito");
                this.clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {           
            Persona aux = getRol();
            if (!Validator.validateNumero(txtDni.Text))
            {
                MessageBox.Show("El dni debe ser solo numeros");
            }else
            if (!Validator.validateNumero(txtDni.Text))
            {
                MessageBox.Show("El dni debe ser solo numeros");
            }else
            if (!Validator.validateTexto(txtNombre.Text))
            {
                MessageBox.Show("El nombre deben ser solo letras");
            }else
            if (!Validator.validateMail(txtMail.Text))
            { 
                MessageBox.Show("El mail no tiene el formato correcto (xx@xx.xx)");
            }else
            if (this.Owner == null)
            {
                if (txtPassword.Text != null && txtPassword.Text != txtConfirmar.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }else
                if (aux is Administrativo)
                {
                    cad.insert(new Administrativo(txtDni.Text, txtApellido.Text, txtNombre.Text, txtNacimiento.Text, txtTelefono.Text,
                        txtDireccion.Text, txtMail.Text, txtPassword.Text));
                    MessageBox.Show("Administrativo registrado con exito");
                    
                }
                else if (aux is Administrativo)
                {
                    cd.insert(new Docente(txtDni.Text, txtApellido.Text, txtNombre.Text, txtNacimiento.Text, txtTelefono.Text,
                        txtDireccion.Text, txtMail.Text, txtPassword.Text));
                    MessageBox.Show("Docente registrado con exito");
                }
                else
                {
                    ca.insert(new Alumno(txtDni.Text, txtApellido.Text, txtNombre.Text, txtNacimiento.Text, txtTelefono.Text,
                        txtDireccion.Text, txtMail.Text, txtPassword.Text));
                    MessageBox.Show("Alumno registrado con exito");
                }
                this.clear();
            }
            else
            {
                String t = null;
                int id = 0;
                if (int.TryParse(txtId.Text, out id))
                {

                    if (aux is Administrativo)
                    {
                        t = "Adminitrativo";
                        aux = (Administrativo)cad.find(id);
                        completarDatos(aux);
                        cad.update(aux);
                    }
                    else if (aux is Docente)
                    {
                        t = "Docente";
                        aux = (Docente)cd.find(id);
                        completarDatos(aux);
                        cd.update(aux);
                    }
                    else
                    {
                        t = "Alumno";
                        aux = (Alumno)ca.find(id);
                        completarDatos(aux);
                        ca.update(aux);
                    }
                    MessageBox.Show(t+" modificado con exito");
                }
                this.clear();
                Owner.reload();
            }
        }

        private Persona getRol()
        {
            Persona aux = null;
            switch (((Tipo)cmbTipo.SelectedItem).id)
            {
                case 0:
                    aux = new Administrativo();
                    break;
                case 1:
                    aux = new Docente();
                    break;
                case 2:
                    aux = new Alumno();
                    break;
                default:
                    break;
            }
            return aux;
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
            if (txtPassword.Text!=null && txtPassword.Text==txtConfirmar.Text)
            {
                aux.password = Hasher.toMD5(txtPassword.Text);
            }
            else if (txtPassword.Text != null && txtPassword.Text != txtConfirmar.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }
    }
}
