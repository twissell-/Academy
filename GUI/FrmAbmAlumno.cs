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
using System.Text.RegularExpressions;   // Para validaciones

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
                MessageBox.Show("error");
                throw;
            }

            this.Dispose();
        }

        private void ShowDialog(string p)
        {
            throw new NotImplementedException();
        }

        private void validateForm()
        {
            // SEGUIR ACA <---------------------------------------------------------------
           // this.validateDni(txtDni);
        }

#region Metodos para Validaciones 
        // Se agrupan en esta region los metodos privados para la validacion de los campos.
        // Probablente en un futuro convenga agruparlos en una clase, para que esten todos 
        // juntos y sean reutilizables.

        private bool validate(TextBox txt, String pattern) 
        {
            // Validacion generica para ahorar codigo
            Regex regex = new Regex(pattern);
            return regex.IsMatch(txt.Text);    
        }

        private bool validateMail(TextBox txt)
        {
            return validate(txt, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        }

        private bool validateDni(TextBox txt)
        {
            return validate(txt, @"\d{9}");
        }

        private bool validateTexto(TextBox txt)
        {
            return validate(txt, @"\w+");
        }

        private bool validateNacimiento(TextBox txt)
        {
            return validate(txt, @"(\d{2}/){2}/\d{4}");
        }

        private bool validateTelefono(TextBox txt)
        {
            return validate(txt, @"\d{3,5}-\d{9}");
        }

        private void FrmAbmAlumno_Load(object sender, EventArgs e)
        {
        
        }

#endregion

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
