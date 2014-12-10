namespace UserControls
{
    partial class ucAComision
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
            this.grpComision = new System.Windows.Forms.GroupBox();
            this.txtAñoCursado = new System.Windows.Forms.TextBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblAñoCursado = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gpbMateria = new System.Windows.Forms.GroupBox();
            this.dgvListaDocentes = new System.Windows.Forms.DataGridView();
            this.dgvApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTitular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvAdjunto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvJTP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvAuxiliar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpComision.SuspendLayout();
            this.gpbMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDocentes)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpComision
            // 
            this.grpComision.Controls.Add(this.txtAñoCursado);
            this.grpComision.Controls.Add(this.cmbMateria);
            this.grpComision.Controls.Add(this.lblMateria);
            this.grpComision.Controls.Add(this.lblAñoCursado);
            this.grpComision.Controls.Add(this.cmbTurno);
            this.grpComision.Controls.Add(this.lblTurno);
            this.grpComision.Controls.Add(this.lblId);
            this.grpComision.Controls.Add(this.txtId);
            this.grpComision.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpComision.Location = new System.Drawing.Point(0, 0);
            this.grpComision.Name = "grpComision";
            this.grpComision.Size = new System.Drawing.Size(401, 88);
            this.grpComision.TabIndex = 17;
            this.grpComision.TabStop = false;
            this.grpComision.Text = "Datos Comision";
            // 
            // txtAñoCursado
            // 
            this.txtAñoCursado.Location = new System.Drawing.Point(271, 20);
            this.txtAñoCursado.Name = "txtAñoCursado";
            this.txtAñoCursado.Size = new System.Drawing.Size(67, 20);
            this.txtAñoCursado.TabIndex = 13;
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(68, 46);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(121, 21);
            this.cmbMateria.TabIndex = 8;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(17, 49);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(45, 13);
            this.lblMateria.TabIndex = 19;
            this.lblMateria.Text = "Materia:";
            // 
            // lblAñoCursado
            // 
            this.lblAñoCursado.AutoSize = true;
            this.lblAñoCursado.Location = new System.Drawing.Point(195, 23);
            this.lblAñoCursado.Name = "lblAñoCursado";
            this.lblAñoCursado.Size = new System.Drawing.Size(70, 13);
            this.lblAñoCursado.TabIndex = 12;
            this.lblAñoCursado.Text = "Año cursado:";
            // 
            // cmbTurno
            // 
            this.cmbTurno.DisplayMember = "Mañana";
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Items.AddRange(new object[] {
            "",
            "Mañana",
            "Tarde",
            "Noche"});
            this.cmbTurno.Location = new System.Drawing.Point(271, 46);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(67, 21);
            this.cmbTurno.TabIndex = 3;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(195, 49);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 2;
            this.lblTurno.Text = "Turno:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(17, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Id.";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(68, 20);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 13;
            // 
            // gpbMateria
            // 
            this.gpbMateria.AutoSize = true;
            this.gpbMateria.Controls.Add(this.dgvListaDocentes);
            this.gpbMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbMateria.Location = new System.Drawing.Point(0, 88);
            this.gpbMateria.Name = "gpbMateria";
            this.gpbMateria.Size = new System.Drawing.Size(401, 266);
            this.gpbMateria.TabIndex = 18;
            this.gpbMateria.TabStop = false;
            this.gpbMateria.Text = "Docentes";
            // 
            // dgvListaDocentes
            // 
            this.dgvListaDocentes.AllowUserToAddRows = false;
            this.dgvListaDocentes.AllowUserToDeleteRows = false;
            this.dgvListaDocentes.AllowUserToResizeColumns = false;
            this.dgvListaDocentes.AllowUserToResizeRows = false;
            this.dgvListaDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvApellido,
            this.dgvNombre,
            this.dgvTitular,
            this.dgvAdjunto,
            this.dgvJTP,
            this.dgvAuxiliar});
            this.dgvListaDocentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaDocentes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvListaDocentes.Location = new System.Drawing.Point(3, 16);
            this.dgvListaDocentes.Name = "dgvListaDocentes";
            this.dgvListaDocentes.Size = new System.Drawing.Size(395, 247);
            this.dgvListaDocentes.TabIndex = 20;
            this.dgvListaDocentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaDocentes_CellClick);
            // 
            // dgvApellido
            // 
            this.dgvApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvApellido.DataPropertyName = "apellido";
            this.dgvApellido.HeaderText = "Apellido";
            this.dgvApellido.Name = "dgvApellido";
            this.dgvApellido.ReadOnly = true;
            this.dgvApellido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvNombre
            // 
            this.dgvNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNombre.DataPropertyName = "nombre";
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.Name = "dgvNombre";
            this.dgvNombre.ReadOnly = true;
            this.dgvNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvTitular
            // 
            this.dgvTitular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvTitular.HeaderText = "Titular";
            this.dgvTitular.Name = "dgvTitular";
            this.dgvTitular.ReadOnly = true;
            this.dgvTitular.Width = 42;
            // 
            // dgvAdjunto
            // 
            this.dgvAdjunto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvAdjunto.HeaderText = "Adjunto";
            this.dgvAdjunto.Name = "dgvAdjunto";
            this.dgvAdjunto.ReadOnly = true;
            this.dgvAdjunto.Width = 49;
            // 
            // dgvJTP
            // 
            this.dgvJTP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvJTP.HeaderText = "JTP";
            this.dgvJTP.Name = "dgvJTP";
            this.dgvJTP.ReadOnly = true;
            this.dgvJTP.Width = 32;
            // 
            // dgvAuxiliar
            // 
            this.dgvAuxiliar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvAuxiliar.HeaderText = "Auxiliar";
            this.dgvAuxiliar.Name = "dgvAuxiliar";
            this.dgvAuxiliar.ReadOnly = true;
            this.dgvAuxiliar.Width = 46;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnBorrar);
            this.pnlBotones.Controls.Add(this.btnGuardar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 354);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(401, 56);
            this.pnlBotones.TabIndex = 21;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.Location = new System.Drawing.Point(242, 6);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(323, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ucAComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.gpbMateria);
            this.Controls.Add(this.grpComision);
            this.Controls.Add(this.pnlBotones);
            this.Name = "ucAComision";
            this.Size = new System.Drawing.Size(401, 410);
            this.Load += new System.EventHandler(this.ucAgregarComision_Load);
            this.grpComision.ResumeLayout(false);
            this.grpComision.PerformLayout();
            this.gpbMateria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDocentes)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpComision;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.TextBox txtAñoCursado;
        private System.Windows.Forms.Label lblAñoCursado;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.GroupBox gpbMateria;
        private System.Windows.Forms.DataGridView dgvListaDocentes;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvTitular;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvAdjunto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvJTP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvAuxiliar;
    }
}
