namespace UserControls
{
    partial class ucListaPlanes
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
            this.dgvListaPlanes = new System.Windows.Forms.DataGridView();
            this.idPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaPlanes
            // 
            this.dgvListaPlanes.AllowUserToAddRows = false;
            this.dgvListaPlanes.AllowUserToDeleteRows = false;
            this.dgvListaPlanes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPlan,
            this.descripcionPlan,
            this.especialidadPlan});
            this.dgvListaPlanes.Location = new System.Drawing.Point(3, 3);
            this.dgvListaPlanes.MultiSelect = false;
            this.dgvListaPlanes.Name = "dgvListaPlanes";
            this.dgvListaPlanes.ReadOnly = true;
            this.dgvListaPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPlanes.Size = new System.Drawing.Size(505, 294);
            this.dgvListaPlanes.TabIndex = 7;
            this.dgvListaPlanes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaPlanes_CellDoubleClick);
            // 
            // idPlan
            // 
            this.idPlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idPlan.DataPropertyName = "id";
            this.idPlan.HeaderText = "ID";
            this.idPlan.Name = "idPlan";
            this.idPlan.ReadOnly = true;
            this.idPlan.Width = 43;
            // 
            // descripcionPlan
            // 
            this.descripcionPlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionPlan.DataPropertyName = "descripcion";
            this.descripcionPlan.HeaderText = "Descripcion";
            this.descripcionPlan.Name = "descripcionPlan";
            this.descripcionPlan.ReadOnly = true;
            // 
            // especialidadPlan
            // 
            this.especialidadPlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.especialidadPlan.DataPropertyName = "especialidad";
            this.especialidadPlan.HeaderText = "Especialidad";
            this.especialidadPlan.Name = "especialidadPlan";
            this.especialidadPlan.ReadOnly = true;
            this.especialidadPlan.Width = 92;
            // 
            // ucListaPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.dgvListaPlanes);
            this.Name = "ucListaPlanes";
            this.Size = new System.Drawing.Size(510, 332);
            this.Load += new System.EventHandler(this.ucListaPlanes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPlanes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaPlanes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadPlan;

    }
}
