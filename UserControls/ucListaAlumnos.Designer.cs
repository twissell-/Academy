namespace UserControls
{
    partial class ucListaAlumnos
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
            this.dgvListaAlumnos = new System.Windows.Forms.DataGridView();
            this.idAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaAlumnos
            // 
            this.dgvListaAlumnos.AllowUserToAddRows = false;
            this.dgvListaAlumnos.AllowUserToDeleteRows = false;
            this.dgvListaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumno,
            this.dniAlumno,
            this.apellidoAlumno,
            this.nombreAlumno,
            this.telefonoAlumno,
            this.emailAlumno});
            this.dgvListaAlumnos.Location = new System.Drawing.Point(4, 4);
            this.dgvListaAlumnos.MultiSelect = false;
            this.dgvListaAlumnos.Name = "dgvListaAlumnos";
            this.dgvListaAlumnos.ReadOnly = true;
            this.dgvListaAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaAlumnos.Size = new System.Drawing.Size(644, 283);
            this.dgvListaAlumnos.TabIndex = 0;
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
            this.dniAlumno.ReadOnly = true;
            // 
            // apellidoAlumno
            // 
            this.apellidoAlumno.DataPropertyName = "apellido";
            this.apellidoAlumno.HeaderText = "Apellido";
            this.apellidoAlumno.Name = "apellidoAlumno";
            this.apellidoAlumno.ReadOnly = true;
            // 
            // nombreAlumno
            // 
            this.nombreAlumno.DataPropertyName = "nombre";
            this.nombreAlumno.HeaderText = "Nombre";
            this.nombreAlumno.Name = "nombreAlumno";
            this.nombreAlumno.ReadOnly = true;
            // 
            // telefonoAlumno
            // 
            this.telefonoAlumno.DataPropertyName = "telefono";
            this.telefonoAlumno.HeaderText = "Telefono";
            this.telefonoAlumno.Name = "telefonoAlumno";
            this.telefonoAlumno.ReadOnly = true;
            // 
            // emailAlumno
            // 
            this.emailAlumno.DataPropertyName = "mail";
            this.emailAlumno.HeaderText = "E-Mail";
            this.emailAlumno.Name = "emailAlumno";
            this.emailAlumno.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(483, 293);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(573, 293);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ucListaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvListaAlumnos);
            this.Name = "ucListaAlumnos";
            this.Size = new System.Drawing.Size(720, 323);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaAlumnos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAlumno;
        private System.Windows.Forms.Button btnCancelar;
    }
}
