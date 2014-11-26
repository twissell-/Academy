﻿namespace UserControls
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.idPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacimientoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaAlumnos
            // 
            this.dgvListaAlumnos.AllowUserToAddRows = false;
            this.dgvListaAlumnos.AllowUserToDeleteRows = false;
            this.dgvListaAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            this.dgvListaAlumnos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaAlumnos_CellValueChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(561, 297);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(642, 297);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.apellidoPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellidoPersona.DataPropertyName = "apellido";
            this.apellidoPersona.HeaderText = "Apellido";
            this.apellidoPersona.Name = "apellidoPersona";
            this.apellidoPersona.ReadOnly = true;
            this.apellidoPersona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nombrePersona
            // 
            this.nombrePersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombrePersona.DataPropertyName = "nombre";
            this.nombrePersona.HeaderText = "Nombre";
            this.nombrePersona.Name = "nombrePersona";
            this.nombrePersona.ReadOnly = true;
            this.nombrePersona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nacimientoPersona
            // 
            this.nacimientoPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nacimientoPersona.DataPropertyName = "nacimiento";
            this.nacimientoPersona.HeaderText = "Fecha de Nac.";
            this.nacimientoPersona.Name = "nacimientoPersona";
            this.nacimientoPersona.ReadOnly = true;
            this.nacimientoPersona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nacimientoPersona.Width = 74;
            // 
            // direccionPersona
            // 
            this.direccionPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.direccionPersona.DataPropertyName = "direccion";
            this.direccionPersona.HeaderText = "Direccion";
            this.direccionPersona.Name = "direccionPersona";
            this.direccionPersona.ReadOnly = true;
            this.direccionPersona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.direccionPersona.Width = 77;
            // 
            // telefonoPersona
            // 
            this.telefonoPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefonoPersona.DataPropertyName = "telefono";
            this.telefonoPersona.HeaderText = "Telefono";
            this.telefonoPersona.Name = "telefonoPersona";
            this.telefonoPersona.ReadOnly = true;
            this.telefonoPersona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.telefonoPersona.Width = 74;
            // 
            // emailPersona
            // 
            this.emailPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.emailPersona.DataPropertyName = "mail";
            this.emailPersona.HeaderText = "E-Mail";
            this.emailPersona.Name = "emailPersona";
            this.emailPersona.ReadOnly = true;
            this.emailPersona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.emailPersona.Width = 61;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(480, 297);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ucListaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGuardar);
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacimientoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailPersona;
        private System.Windows.Forms.Button btnGuardar;
    }
}
