namespace UserControls
{
    partial class ucBPlanes
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
            this.dgvListaPlanesBaja = new System.Windows.Forms.DataGridView();
            this.idPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPlanesBaja)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(770, 295);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(679, 295);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvListaPlanesBaja
            // 
            this.dgvListaPlanesBaja.AllowUserToAddRows = false;
            this.dgvListaPlanesBaja.AllowUserToDeleteRows = false;
            this.dgvListaPlanesBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvListaPlanesBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPlanesBaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPlan,
            this.descripcionPlan,
            this.especialidadPlan});
            this.dgvListaPlanesBaja.Location = new System.Drawing.Point(169, 3);
            this.dgvListaPlanesBaja.MultiSelect = false;
            this.dgvListaPlanesBaja.Name = "dgvListaPlanesBaja";
            this.dgvListaPlanesBaja.ReadOnly = true;
            this.dgvListaPlanesBaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPlanesBaja.Size = new System.Drawing.Size(494, 315);
            this.dgvListaPlanesBaja.TabIndex = 6;
            // 
            // idPlan
            // 
            this.idPlan.DataPropertyName = "id";
            this.idPlan.HeaderText = "ID";
            this.idPlan.Name = "idPlan";
            this.idPlan.ReadOnly = true;
            this.idPlan.Width = 150;
            // 
            // descripcionPlan
            // 
            this.descripcionPlan.HeaderText = "Descripcion";
            this.descripcionPlan.Name = "descripcionPlan";
            this.descripcionPlan.ReadOnly = true;
            this.descripcionPlan.Width = 150;
            // 
            // especialidadPlan
            // 
            this.especialidadPlan.DataPropertyName = "especialidad";
            this.especialidadPlan.HeaderText = "Especialidad";
            this.especialidadPlan.Name = "especialidadPlan";
            this.especialidadPlan.ReadOnly = true;
            this.especialidadPlan.Width = 150;
            // 
            // ucBPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvListaPlanesBaja);
            this.Name = "ucBPlanes";
            this.Size = new System.Drawing.Size(848, 321);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPlanesBaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvListaPlanesBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadPlan;
    }
}
