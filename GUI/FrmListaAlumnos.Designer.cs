namespace GUI
{
    partial class FrmListaAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListaDocentes = new System.Windows.Forms.DataGridView();
            this.dgvApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgCargo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dvgAsignado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaDocentes
            // 
            this.dgvListaDocentes.AllowUserToOrderColumns = true;
            this.dgvListaDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvApellido,
            this.dgvNombre,
            this.dvgCargo,
            this.dvgAsignado});
            this.dgvListaDocentes.Location = new System.Drawing.Point(31, 40);
            this.dgvListaDocentes.Name = "dgvListaDocentes";
            this.dgvListaDocentes.Size = new System.Drawing.Size(443, 150);
            this.dgvListaDocentes.TabIndex = 15;
            // 
            // dgvApellido
            // 
            this.dgvApellido.HeaderText = "Apellido";
            this.dgvApellido.Name = "dgvApellido";
            this.dgvApellido.ReadOnly = true;
            // 
            // dgvNombre
            // 
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.Name = "dgvNombre";
            this.dgvNombre.ReadOnly = true;
            // 
            // dvgCargo
            // 
            this.dvgCargo.HeaderText = "Cargo";
            this.dvgCargo.Name = "dvgCargo";
            this.dvgCargo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCargo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dvgAsignado
            // 
            this.dvgAsignado.HeaderText = "Asignado";
            this.dvgAsignado.Name = "dvgAsignado";
            this.dvgAsignado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgAsignado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(548, 228);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(467, 228);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(386, 228);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(495, 40);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(124, 52);
            this.btnAgregarAlumno.TabIndex = 16;
            this.btnAgregarAlumno.Text = "Agregar Alumno";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // FrmListaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 262);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Controls.Add(this.dgvListaDocentes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FrmListaAlumnos";
            this.Text = "Lista de alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDocentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaDocentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewComboBoxColumn dvgCargo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dvgAsignado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregarAlumno;
    }
}