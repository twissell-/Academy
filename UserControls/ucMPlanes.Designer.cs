namespace UserControls
{
    partial class ucMPlanes
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
            this.dgvListaPlanesMod = new System.Windows.Forms.DataGridView();
            this.idPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPlanesMod)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaPlanesMod
            // 
            this.dgvListaPlanesMod.AllowUserToAddRows = false;
            this.dgvListaPlanesMod.AllowUserToDeleteRows = false;
            this.dgvListaPlanesMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvListaPlanesMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPlanesMod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPlan,
            this.descripcionPlan,
            this.especialidadPlan});
            this.dgvListaPlanesMod.Location = new System.Drawing.Point(151, 3);
            this.dgvListaPlanesMod.MultiSelect = false;
            this.dgvListaPlanesMod.Name = "dgvListaPlanesMod";
            this.dgvListaPlanesMod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPlanesMod.Size = new System.Drawing.Size(494, 283);
            this.dgvListaPlanesMod.TabIndex = 3;
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
            this.descripcionPlan.Width = 150;
            // 
            // especialidadPlan
            // 
            this.especialidadPlan.DataPropertyName = "especialidad";
            this.especialidadPlan.HeaderText = "Especialidad";
            this.especialidadPlan.Name = "especialidadPlan";
            this.especialidadPlan.Width = 150;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(679, 295);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(770, 295);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ucMPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvListaPlanesMod);
            this.Name = "ucMPlanes";
            this.Size = new System.Drawing.Size(848, 321);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPlanesMod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaPlanesMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadPlan;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
