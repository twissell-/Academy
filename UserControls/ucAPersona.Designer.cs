namespace UserControls
{
    partial class ucAPersona
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.gprDatosAcceso = new System.Windows.Forms.GroupBox();
            this.txtConfirmar = new System.Windows.Forms.MaskedTextBox();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.gprDatosContacto = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtNacimiento = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.grpPersona = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.gprDatosAcceso.SuspendLayout();
            this.gprDatosContacto.SuspendLayout();
            this.grpDatosPersonales.SuspendLayout();
            this.grpPersona.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(133, 22);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 25;
            this.lblTipo.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Docente",
            "Alumno"});
            this.cmbTipo.Location = new System.Drawing.Point(177, 18);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 24;
            // 
            // gprDatosAcceso
            // 
            this.gprDatosAcceso.Controls.Add(this.txtConfirmar);
            this.gprDatosAcceso.Controls.Add(this.txtPassword);
            this.gprDatosAcceso.Controls.Add(this.lblConfirmar);
            this.gprDatosAcceso.Controls.Add(this.lblPass);
            this.gprDatosAcceso.Location = new System.Drawing.Point(5, 196);
            this.gprDatosAcceso.Name = "gprDatosAcceso";
            this.gprDatosAcceso.Size = new System.Drawing.Size(563, 54);
            this.gprDatosAcceso.TabIndex = 21;
            this.gprDatosAcceso.TabStop = false;
            this.gprDatosAcceso.Text = "Datos de Acceso";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(357, 19);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = '*';
            this.txtConfirmar.Size = new System.Drawing.Size(195, 20);
            this.txtConfirmar.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(72, 19);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(195, 20);
            this.txtPassword.TabIndex = 13;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Location = new System.Drawing.Point(291, 22);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(51, 13);
            this.lblConfirmar.TabIndex = 11;
            this.lblConfirmar.Text = "Confirmar";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(6, 22);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(61, 13);
            this.lblPass.TabIndex = 9;
            this.lblPass.Text = "Contraseña";
            // 
            // gprDatosContacto
            // 
            this.gprDatosContacto.Controls.Add(this.txtMail);
            this.gprDatosContacto.Controls.Add(this.lblMail);
            this.gprDatosContacto.Controls.Add(this.txtDireccion);
            this.gprDatosContacto.Controls.Add(this.lblDireccion);
            this.gprDatosContacto.Controls.Add(this.txtTelefono);
            this.gprDatosContacto.Controls.Add(this.lblTelefono);
            this.gprDatosContacto.Location = new System.Drawing.Point(287, 51);
            this.gprDatosContacto.Name = "gprDatosContacto";
            this.gprDatosContacto.Size = new System.Drawing.Size(281, 139);
            this.gprDatosContacto.TabIndex = 20;
            this.gprDatosContacto.TabStop = false;
            this.gprDatosContacto.Text = "Datos de Contacto";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(75, 75);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(195, 20);
            this.txtMail.TabIndex = 5;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(6, 78);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 13);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "E-Mail";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(75, 49);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(195, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 52);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(75, 23);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(195, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(6, 26);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono";
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.Controls.Add(this.lblAño);
            this.grpDatosPersonales.Controls.Add(this.txtNacimiento);
            this.grpDatosPersonales.Controls.Add(this.txtDni);
            this.grpDatosPersonales.Controls.Add(this.lblNacimiento);
            this.grpDatosPersonales.Controls.Add(this.lblDni);
            this.grpDatosPersonales.Controls.Add(this.txtNombre);
            this.grpDatosPersonales.Controls.Add(this.txtApellido);
            this.grpDatosPersonales.Controls.Add(this.lblNombre);
            this.grpDatosPersonales.Controls.Add(this.lblApellido);
            this.grpDatosPersonales.Location = new System.Drawing.Point(5, 51);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Size = new System.Drawing.Size(276, 139);
            this.grpDatosPersonales.TabIndex = 19;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos Personales";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(147, 107);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(75, 13);
            this.lblAño.TabIndex = 9;
            this.lblAño.Text = "(dd/mm/aaaa)";
            // 
            // txtNacimiento
            // 
            this.txtNacimiento.Location = new System.Drawing.Point(72, 101);
            this.txtNacimiento.Name = "txtNacimiento";
            this.txtNacimiento.Size = new System.Drawing.Size(68, 20);
            this.txtNacimiento.TabIndex = 5;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(72, 23);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 2;
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(6, 104);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(60, 13);
            this.lblNacimiento.TabIndex = 8;
            this.lblNacimiento.Text = "Nacimiento";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(6, 26);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(195, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(72, 49);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(195, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 52);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(27, 19);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 18;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(5, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "Id";
            // 
            // grpPersona
            // 
            this.grpPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPersona.Controls.Add(this.gprDatosAcceso);
            this.grpPersona.Controls.Add(this.gprDatosContacto);
            this.grpPersona.Controls.Add(this.grpDatosPersonales);
            this.grpPersona.Controls.Add(this.lblTipo);
            this.grpPersona.Controls.Add(this.cmbTipo);
            this.grpPersona.Controls.Add(this.btnBorrar);
            this.grpPersona.Controls.Add(this.btnGuardar);
            this.grpPersona.Controls.Add(this.txtId);
            this.grpPersona.Controls.Add(this.lblId);
            this.grpPersona.Location = new System.Drawing.Point(11, 3);
            this.grpPersona.Name = "grpPersona";
            this.grpPersona.Size = new System.Drawing.Size(574, 285);
            this.grpPersona.TabIndex = 26;
            this.grpPersona.TabStop = false;
            this.grpPersona.Text = "Usuario";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(493, 256);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.Location = new System.Drawing.Point(412, 256);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 23;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // ucAPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.grpPersona);
            this.Name = "ucAPersona";
            this.Size = new System.Drawing.Size(602, 302);
            this.Load += new System.EventHandler(this.ucAPersona_Load);
            this.gprDatosAcceso.ResumeLayout(false);
            this.gprDatosAcceso.PerformLayout();
            this.gprDatosContacto.ResumeLayout(false);
            this.gprDatosContacto.PerformLayout();
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.grpPersona.ResumeLayout(false);
            this.grpPersona.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.GroupBox gprDatosAcceso;
        private System.Windows.Forms.MaskedTextBox txtConfirmar;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.GroupBox gprDatosContacto;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtNacimiento;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox grpPersona;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
    }
}
