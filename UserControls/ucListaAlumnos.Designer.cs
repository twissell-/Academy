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
            this.idPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacimientoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaAlumnos
            // 
            this.dgvListaAlumnos.AllowUserToAddRows = false;
            this.dgvListaAlumnos.AllowUserToDeleteRows = false;
            this.dgvListaAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersona,
            this.dniPersona,
            this.apellidoPersona,
            this.nombrePersona,
            this.nacimientoPersona,
            this.direccionPersona,
            this.telefonoPersona,
            this.emailPersona});
            this.dgvListaAlumnos.Location = new System.Drawing.Point(15, 4);
            this.dgvListaAlumnos.MultiSelect = false;
            this.dgvListaAlumnos.Name = "dgvListaAlumnos";
            this.dgvListaAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaAlumnos.Size = new System.Drawing.Size(694, 283);
            this.dgvListaAlumnos.TabIndex = 0;
            this.dgvListaAlumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaAlumnos_CellDoubleClick);
            // 
            // idPersona
            // 
            this.idPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idPersona.DataPropertyName = "id";
            this.idPersona.HeaderText = "ID";
            this.idPersona.Name = "idPersona";
            this.idPersona.ReadOnly = true;
            this.idPersona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idPersona.Width = 43;
            // 
            // dniPersona
            // 
            this.dniPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dniPersona.DataPropertyName = "dni";
            this.dniPersona.HeaderText = "DNI";
            this.dniPersona.Name = "dniPersona";
            this.dniPersona.ReadOnly = true;
            this.dniPersona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dniPersona.Width = 51;
            // 
            // apellidoPersona
            // 
            this.apellidoPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.apellidoPersona.DataPropertyName = "apellido";
            this.apellidoPersona.HeaderText = "Apellido";
            this.apellidoPersona.Name = "apellidoPersona";
            this.apellidoPersona.ReadOnly = true;
            this.apellidoPersona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.apellidoPersona.Width = 69;
            // 
            // nombrePersona
            // 
            this.nombrePersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombrePersona.DataPropertyName = "nombre";
            this.nombrePersona.HeaderText = "Nombre";
            this.nombrePersona.Name = "nombrePersona";
            this.nombrePersona.ReadOnly = true;
            this.nombrePersona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombrePersona.Width = 69;
            // 
            // nacimientoPersona
            // 
            this.nacimientoPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nacimientoPersona.DataPropertyName = "nacimiento";
            this.nacimientoPersona.HeaderText = "Fecha de Nac.";
            this.nacimientoPersona.Name = "nacimientoPersona";
            this.nacimientoPersona.ReadOnly = true;
            this.nacimientoPersona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // direccionPersona
            // 
            this.direccionPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.direccionPersona.DataPropertyName = "direccion";
            this.direccionPersona.HeaderText = "Direccion";
            this.direccionPersona.Name = "direccionPersona";
            this.direccionPersona.ReadOnly = true;
            this.direccionPersona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // telefonoPersona
            // 
            this.telefonoPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefonoPersona.DataPropertyName = "telefono";
            this.telefonoPersona.HeaderText = "Telefono";
            this.telefonoPersona.Name = "telefonoPersona";
            this.telefonoPersona.ReadOnly = true;
            this.telefonoPersona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // emailPersona
            // 
            this.emailPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailPersona.DataPropertyName = "mail";
            this.emailPersona.HeaderText = "E-Mail";
            this.emailPersona.Name = "emailPersona";
            this.emailPersona.ReadOnly = true;
            this.emailPersona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ucListaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.dgvListaAlumnos);
            this.Name = "ucListaAlumnos";
            this.Size = new System.Drawing.Size(720, 323);
            this.Load += new System.EventHandler(this.ucListaAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacimientoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailPersona;
    }
}
