namespace UserControls
{
    partial class ucListaEspecialidades
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
            this.dgvListaEspecialidades = new System.Windows.Forms.DataGridView();
            this.idDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEspecialidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(521, 295);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvListaEspecialidades
            // 
            this.dgvListaEspecialidades.AllowUserToAddRows = false;
            this.dgvListaEspecialidades.AllowUserToDeleteRows = false;
            this.dgvListaEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDescripcion,
            this.descripcionEspecialidad});
            this.dgvListaEspecialidades.Location = new System.Drawing.Point(253, 2);
            this.dgvListaEspecialidades.MultiSelect = false;
            this.dgvListaEspecialidades.Name = "dgvListaEspecialidades";
            this.dgvListaEspecialidades.ReadOnly = true;
            this.dgvListaEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaEspecialidades.Size = new System.Drawing.Size(343, 283);
            this.dgvListaEspecialidades.TabIndex = 12;
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
            // ucListaEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvListaEspecialidades);
            this.Name = "ucListaEspecialidades";
            this.Size = new System.Drawing.Size(848, 321);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEspecialidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvListaEspecialidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionEspecialidad;
    }
}
