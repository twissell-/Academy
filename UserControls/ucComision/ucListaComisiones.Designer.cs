namespace UserControls
{
    partial class ucListaComisiones
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
            this.dgvComisiones = new System.Windows.Forms.DataGridView();
            this.dgcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcAnioCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComisiones
            // 
            this.dgvComisiones.AllowUserToAddRows = false;
            this.dgvComisiones.AllowUserToDeleteRows = false;
            this.dgvComisiones.AllowUserToOrderColumns = true;
            this.dgvComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcId,
            this.dgcAnioCursado,
            this.dgcMateria,
            this.dgcTurno});
            this.dgvComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComisiones.Location = new System.Drawing.Point(0, 0);
            this.dgvComisiones.MultiSelect = false;
            this.dgvComisiones.Name = "dgvComisiones";
            this.dgvComisiones.ReadOnly = true;
            this.dgvComisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComisiones.Size = new System.Drawing.Size(606, 323);
            this.dgvComisiones.TabIndex = 0;
            this.dgvComisiones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComisiones_CellDoubleClick);
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
            // dgcAnioCursado
            // 
            this.dgcAnioCursado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgcAnioCursado.DataPropertyName = "anioCursado";
            this.dgcAnioCursado.HeaderText = "Año";
            this.dgcAnioCursado.Name = "dgcAnioCursado";
            this.dgcAnioCursado.ReadOnly = true;
            this.dgcAnioCursado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcAnioCursado.Width = 51;
            // 
            // dgcMateria
            // 
            this.dgcMateria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcMateria.DataPropertyName = "materia";
            this.dgcMateria.HeaderText = "Materia";
            this.dgcMateria.Name = "dgcMateria";
            this.dgcMateria.ReadOnly = true;
            this.dgcMateria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgcTurno
            // 
            this.dgcTurno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgcTurno.DataPropertyName = "turno";
            this.dgcTurno.HeaderText = "Turno";
            this.dgcTurno.Name = "dgcTurno";
            this.dgcTurno.ReadOnly = true;
            this.dgcTurno.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcTurno.Width = 60;
            // 
            // ucListaComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.dgvComisiones);
            this.Name = "ucListaComisiones";
            this.Size = new System.Drawing.Size(606, 323);
            this.Load += new System.EventHandler(this.ucListaComisiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComisiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAnioCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTurno;

    }
}
