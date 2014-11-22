namespace UserControls
{
    partial class ucBEspecialidad
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvListaEspecialidadesBaja = new System.Windows.Forms.DataGridView();
            this.idDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEspecialidadesBaja)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(770, 299);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(679, 299);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvListaEspecialidadesBaja
            // 
            this.dgvListaEspecialidadesBaja.AllowUserToAddRows = false;
            this.dgvListaEspecialidadesBaja.AllowUserToDeleteRows = false;
            this.dgvListaEspecialidadesBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvListaEspecialidadesBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEspecialidadesBaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDescripcion,
            this.descripcionEspecialidad});
            this.dgvListaEspecialidadesBaja.Location = new System.Drawing.Point(252, 3);
            this.dgvListaEspecialidadesBaja.MultiSelect = false;
            this.dgvListaEspecialidadesBaja.Name = "dgvListaEspecialidadesBaja";
            this.dgvListaEspecialidadesBaja.ReadOnly = true;
            this.dgvListaEspecialidadesBaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaEspecialidadesBaja.Size = new System.Drawing.Size(343, 319);
            this.dgvListaEspecialidadesBaja.TabIndex = 9;
            // 
            // idDescripcion
            // 
            this.idDescripcion.DataPropertyName = "id";
            this.idDescripcion.HeaderText = "ID";
            this.idDescripcion.Name = "idDescripcion";
            this.idDescripcion.ReadOnly = true;
            this.idDescripcion.Width = 150;
            // 
            // descripcionEspecialidad
            // 
            this.descripcionEspecialidad.DataPropertyName = "descripcion";
            this.descripcionEspecialidad.HeaderText = "Descripcion";
            this.descripcionEspecialidad.Name = "descripcionEspecialidad";
            this.descripcionEspecialidad.ReadOnly = true;
            this.descripcionEspecialidad.Width = 150;
            // 
            // ucBEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvListaEspecialidadesBaja);
            this.Name = "ucBEspecialidad";
            this.Size = new System.Drawing.Size(848, 325);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEspecialidadesBaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvListaEspecialidadesBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionEspecialidad;
    }
}
