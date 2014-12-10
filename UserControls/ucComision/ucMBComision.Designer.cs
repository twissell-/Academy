namespace UserControls
{
    partial class ucMBComision
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
            this.ucListado = new UserControls.ucListaComisiones();
            this.pnlModificaciones = new System.Windows.Forms.Panel();
            this.ucModificaciones = new UserControls.ucAComision();
            this.pnlListado.SuspendLayout();
            this.pnlModificaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlListado
            // 
            this.pnlListado.Controls.Add(this.ucListado);
            this.pnlListado.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlListado.Location = new System.Drawing.Point(0, 0);
            this.pnlListado.Name = "pnlListado";
            this.pnlListado.Size = new System.Drawing.Size(326, 454);
            this.pnlListado.TabIndex = 0;
            // 
            // ucListado
            // 
            this.ucListado.AutoSize = true;
            this.ucListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucListado.Location = new System.Drawing.Point(0, 0);
            this.ucListado.Name = "ucListado";
            this.ucListado.Owner = null;
            this.ucListado.Size = new System.Drawing.Size(326, 454);
            this.ucListado.TabIndex = 0;
            this.ucListado.Load += new System.EventHandler(this.ucListado_Load);
            // 
            // pnlModificaciones
            // 
            this.pnlModificaciones.Controls.Add(this.ucModificaciones);
            this.pnlModificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlModificaciones.Location = new System.Drawing.Point(326, 0);
            this.pnlModificaciones.Name = "pnlModificaciones";
            this.pnlModificaciones.Size = new System.Drawing.Size(451, 454);
            this.pnlModificaciones.TabIndex = 1;
            // 
            // ucModificaciones
            // 
            this.ucModificaciones.AutoSize = true;
            this.ucModificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucModificaciones.Location = new System.Drawing.Point(0, 0);
            this.ucModificaciones.Name = "ucModificaciones";
            this.ucModificaciones.Owner = null;
            this.ucModificaciones.Size = new System.Drawing.Size(451, 454);
            this.ucModificaciones.TabIndex = 0;
          
            // 
            // ucMBComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlModificaciones);
            this.Controls.Add(this.pnlListado);
            this.Name = "ucMBComision";
            this.Size = new System.Drawing.Size(777, 454);
            this.pnlListado.ResumeLayout(false);
            this.pnlListado.PerformLayout();
            this.pnlModificaciones.ResumeLayout(false);
            this.pnlModificaciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlListado;
        private ucListaComisiones ucListado;
        private System.Windows.Forms.Panel pnlModificaciones;
        private ucAComision ucModificaciones;
    }
}
