namespace UserControls
{
    partial class ucMPersona
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvListaAlumnosMod = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.idAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAlumnosMod)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(545, 297);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvListaAlumnosMod
            // 
            this.dgvListaAlumnosMod.AllowUserToAddRows = false;
            this.dgvListaAlumnosMod.AllowUserToDeleteRows = false;
            this.dgvListaAlumnosMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAlumnosMod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumno,
            this.dniAlumno,
            this.apellidoAlumno,
            this.nombreAlumno,
            this.telefonoAlumno,
            this.emailAlumno,
            this.alumnoDireccion});
            this.dgvListaAlumnosMod.Location = new System.Drawing.Point(0, 0);
            this.dgvListaAlumnosMod.MultiSelect = false;
            this.dgvListaAlumnosMod.Name = "dgvListaAlumnosMod";
            this.dgvListaAlumnosMod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaAlumnosMod.Size = new System.Drawing.Size(747, 283);
            this.dgvListaAlumnosMod.TabIndex = 2;
            //this.dgvListaAlumnosMod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaAlumnosMod_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(638, 297);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // idAlumno
            // 
            this.idAlumno.DataPropertyName = "id";
            this.idAlumno.HeaderText = "ID";
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.ReadOnly = true;
            // 
            // dniAlumno
            // 
            this.dniAlumno.DataPropertyName = "dni";
            this.dniAlumno.HeaderText = "DNI";
            this.dniAlumno.Name = "dniAlumno";
            // 
            // apellidoAlumno
            // 
            this.apellidoAlumno.DataPropertyName = "apellido";
            this.apellidoAlumno.HeaderText = "Apellido";
            this.apellidoAlumno.Name = "apellidoAlumno";
            // 
            // nombreAlumno
            // 
            this.nombreAlumno.DataPropertyName = "nombre";
            this.nombreAlumno.HeaderText = "Nombre";
            this.nombreAlumno.Name = "nombreAlumno";
            // 
            // telefonoAlumno
            // 
            this.telefonoAlumno.DataPropertyName = "telefono";
            this.telefonoAlumno.HeaderText = "Telefono";
            this.telefonoAlumno.Name = "telefonoAlumno";
            // 
            // emailAlumno
            // 
            this.emailAlumno.DataPropertyName = "mail";
            this.emailAlumno.HeaderText = "E-Mail";
            this.emailAlumno.Name = "emailAlumno";
            // 
            // alumnoDireccion
            // 
            this.alumnoDireccion.DataPropertyName = "direccion";
            this.alumnoDireccion.HeaderText = "Direccion";
            this.alumnoDireccion.Name = "alumnoDireccion";
            // 
            // ucMPersona
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvListaAlumnosMod);
            this.Name = "ucMPersona";
            this.Size = new System.Drawing.Size(750, 323);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAlumnosMod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvListaAlumnosMod;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumnoDireccion;
    }
}
