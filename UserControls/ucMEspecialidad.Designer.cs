namespace UserControls
{
    partial class ucMEspecialidad
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvListaEspecialidadesModificar = new System.Windows.Forms.DataGridView();
            this.idDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEspecialidadesModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(770, 295);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(679, 295);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvListaEspecialidadesModificar
            // 
            this.dgvListaEspecialidadesModificar.AllowUserToAddRows = false;
            this.dgvListaEspecialidadesModificar.AllowUserToDeleteRows = false;
            this.dgvListaEspecialidadesModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvListaEspecialidadesModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEspecialidadesModificar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDescripcion,
            this.descripcionEspecialidad});
            this.dgvListaEspecialidadesModificar.Location = new System.Drawing.Point(253, 2);
            this.dgvListaEspecialidadesModificar.MultiSelect = false;
            this.dgvListaEspecialidadesModificar.Name = "dgvListaEspecialidadesModificar";
            this.dgvListaEspecialidadesModificar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaEspecialidadesModificar.Size = new System.Drawing.Size(343, 283);
            this.dgvListaEspecialidadesModificar.TabIndex = 12;
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
            this.descripcionEspecialidad.Width = 150;
            // 
            // ucMEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvListaEspecialidadesModificar);
            this.Name = "ucMEspecialidad";
            this.Size = new System.Drawing.Size(848, 321);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEspecialidadesModificar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvListaEspecialidadesModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionEspecialidad;
    }
}
