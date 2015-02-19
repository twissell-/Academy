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
using System.Net.Sockets;


namespace GUI
{
    public partial class FrmLogin : Form
    {
        ControllerAdministrativo cad;

        public FrmLogin()
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


                if (Validator.validateNumero(txtId.Text))
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
                    catch (Exception exg)
                    {
                        if (exg.GetType().ToString().Equals("MongoDB.Driver.MongoConnectionException"))
                        {
                            MessageBox.Show("Ocurrio un error al intentar conectarse a la Base de Datos.\nComuniquese con el administrador", "Imposible conectar a la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);                                   
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El Campo Id debe ser un numero", "Id no Valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SocketException dbe)//MongoDB.Driver.MongoConnectionException dbe)
            {
                MessageBox.Show("El Campo Id debe ser un numero"+dbe);
            }

        }
        private void clear()
        {
            txtId.Clear();
            txtContraseña.Clear();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar=='\r')
            {
                this.login(); 
            }
        }
    }
}
