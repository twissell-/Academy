namespace UserControls
{
    partial class ucMBPlanes
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
            this.pnlListado = new System.Windows.Forms.Panel();
            this.pnlModificaciones = new System.Windows.Forms.Panel();
            this.ucListado = new UserControls.ucListaPlanes();
            this.ucModificaciones = new UserControls.ucAPlanes();
            this.pnlListado.SuspendLayout();
            this.pnlModificaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlListado
            // 
            this.pnlListado.Controls.Add(this.ucListado);
            this.pnlListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListado.Location = new System.Drawing.Point(0, 0);
            this.pnlListado.Name = "pnlListado";
            this.pnlListado.Size = new System.Drawing.Size(549, 407);
            this.pnlListado.TabIndex = 0;
            // 
            // pnlModificaciones
            // 
            this.pnlModificaciones.Controls.Add(this.ucModificaciones);
            this.pnlModificaciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlModificaciones.Location = new System.Drawing.Point(549, 0);
            this.pnlModificaciones.Name = "pnlModificaciones";
            this.pnlModificaciones.Size = new System.Drawing.Size(291, 407);
            this.pnlModificaciones.TabIndex = 1;
            // 
            // ucListado
            // 
            this.ucListado.AutoSize = true;
            this.ucListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucListado.Location = new System.Drawing.Point(0, 0);
            this.ucListado.Name = "ucListado";
            this.ucListado.Owner = null;
            this.ucListado.Size = new System.Drawing.Size(549, 407);
            this.ucListado.TabIndex = 0;
            // 
            // ucModificaciones
            // 
            this.ucModificaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucModificaciones.AutoSize = true;
            this.ucModificaciones.Location = new System.Drawing.Point(3, 3);
            this.ucModificaciones.Name = "ucModificaciones";
            this.ucModificaciones.Size = new System.Drawing.Size(284, 264);
            this.ucModificaciones.TabIndex = 0;
            // 
            // ucMBPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnlListado);
            this.Controls.Add(this.pnlModificaciones);
            this.Name = "ucMBPlanes";
            this.Size = new System.Drawing.Size(840, 407);
            this.Load += new System.EventHandler(this.ucMBPlanes_Load);
            this.pnlListado.ResumeLayout(false);
            this.pnlListado.PerformLayout();
            this.pnlModificaciones.ResumeLayout(false);
            this.pnlModificaciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlListado;
        private ucListaPlanes ucListado;
        private System.Windows.Forms.Panel pnlModificaciones;
        private ucAPlanes ucModificaciones;

    }
}
