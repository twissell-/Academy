using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using UserControls;
using Bussines;
using Entidades;
using Util;


namespace GUI
{
    public partial class FrmPrincipal0 : Form
    {
        ControllerAdministrativo cad;

        public FrmPrincipal0()
        {
            InitializeComponent();
            cad = new ControllerAdministrativo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.login();
        }
        private void login()
        {
            try
            {
                Administrativo adm = (Administrativo)cad.find(Convert.ToInt32(txtId.Text));
                if (adm.password == Hasher.toMD5(txtContraseña.Text))
                {
                    Form administrador = new FrmPrincipal(adm);
                    this.clear();
                    this.Hide();
                    administrador.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("El par Usuario - Contraseña no coinciden", "Usuario o Contraseña Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("El Usuario ingresado no existe", "Usuario Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void clear()
        {
            txtId.Clear();
            txtContraseña.Clear();
        }
    }
}
