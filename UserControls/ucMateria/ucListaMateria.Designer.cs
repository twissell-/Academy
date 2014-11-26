namespace UserControls
{
    partial class ucListaMateria
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
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.dgcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcHsSemanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcHsTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.AllowUserToResizeRows = false;
            this.dgvMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcId,
            this.dgcDescripcion,
            this.dgcPlan,
            this.dgcHsSemanales,
            this.dgcHsTotales});
            this.dgvMaterias.Location = new System.Drawing.Point(4, 4);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.ShowEditingIcon = false;
            this.dgvMaterias.Size = new System.Drawing.Size(393, 269);
            this.dgvMaterias.TabIndex = 0;
            this.dgvMaterias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterias_CellDoubleClick);
            // 
            // dgcId
            // 
            this.dgcId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgcId.DataPropertyName = "id";
            this.dgcId.HeaderText = "ID";
            this.dgcId.Name = "dgcId";
            this.dgcId.ReadOnly = true;
            this.dgcId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcId.Width = 43;
            // 
            // dgcDescripcion
            // 
            this.dgcDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcDescripcion.DataPropertyName = "descripcion";
            this.dgcDescripcion.HeaderText = "Materia";
            this.dgcDescripcion.Name = "dgcDescripcion";
            this.dgcDescripcion.ReadOnly = true;
            this.dgcDescripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgcPlan
            // 
            this.dgcPlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgcPlan.DataPropertyName = "plan";
            this.dgcPlan.HeaderText = "Plan";
            this.dgcPlan.Name = "dgcPlan";
            this.dgcPlan.ReadOnly = true;
            this.dgcPlan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcPlan.Width = 53;
            // 
            // dgcHsSemanales
            // 
            this.dgcHsSemanales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgcHsSemanales.DataPropertyName = "hsSemanales";
            this.dgcHsSemanales.HeaderText = "Hs. Semanales";
            this.dgcHsSemanales.Name = "dgcHsSemanales";
            this.dgcHsSemanales.ReadOnly = true;
            this.dgcHsSemanales.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcHsSemanales.Width = 95;
            // 
            // dgcHsTotales
            // 
            this.dgcHsTotales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgcHsTotales.DataPropertyName = "hsTotales";
            this.dgcHsTotales.HeaderText = "Hs. Totales";
            this.dgcHsTotales.Name = "dgcHsTotales";
            this.dgcHsTotales.ReadOnly = true;
            this.dgcHsTotales.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcHsTotales.Width = 79;
            // 
            // ucListaMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.dgvMaterias);
            this.Name = "ucListaMateria";
            this.Size = new System.Drawing.Size(400, 305);
            this.Load += new System.EventHandler(this.ucListadoMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHsSemanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHsTotales;
    }
}
