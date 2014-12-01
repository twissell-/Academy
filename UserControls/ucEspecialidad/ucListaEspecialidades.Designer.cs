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
            this.dgvListaEspecialidades = new System.Windows.Forms.DataGridView();
            this.dgcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEspecialidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaEspecialidades
            // 
            this.dgvListaEspecialidades.AllowUserToAddRows = false;
            this.dgvListaEspecialidades.AllowUserToDeleteRows = false;
            this.dgvListaEspecialidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcId,
            this.dgcDescripcion});
            this.dgvListaEspecialidades.Location = new System.Drawing.Point(4, 2);
            this.dgvListaEspecialidades.MultiSelect = false;
            this.dgvListaEspecialidades.Name = "dgvListaEspecialidades";
            this.dgvListaEspecialidades.ReadOnly = true;
            this.dgvListaEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaEspecialidades.Size = new System.Drawing.Size(343, 283);
            this.dgvListaEspecialidades.TabIndex = 12;
            this.dgvListaEspecialidades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaEspecialidades_CellDoubleClick);
            // 
            // dgcId
            // 
            this.dgcId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgcId.DataPropertyName = "id";
            this.dgcId.HeaderText = "ID";
            this.dgcId.Name = "dgcId";
            this.dgcId.ReadOnly = true;
            this.dgcId.Width = 43;
            // 
            // dgcDescripcion
            // 
            this.dgcDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcDescripcion.DataPropertyName = "descripcion";
            this.dgcDescripcion.HeaderText = "Descripcion";
            this.dgcDescripcion.Name = "dgcDescripcion";
            this.dgcDescripcion.ReadOnly = true;
            // 
            // ucListaEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.dgvListaEspecialidades);
            this.Name = "ucListaEspecialidades";
            this.Size = new System.Drawing.Size(350, 321);
            this.Load += new System.EventHandler(this.ucListaEspecialidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEspecialidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaEspecialidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDescripcion;
    }
}
