namespace UserControls
{
    partial class ucMBPersona
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
            this.pnlModificacion = new System.Windows.Forms.Panel();
            this.ucModificaciones = new UserControls.ucAPersona();
            this.pnlListado = new System.Windows.Forms.Panel();
            this.ucListado = new UserControls.ucListaAlumnos();
            this.pnlModificacion.SuspendLayout();
            this.pnlListado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlModificacion
            // 
            this.pnlModificacion.Controls.Add(this.ucModificaciones);
            this.pnlModificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlModificacion.Location = new System.Drawing.Point(322, 0);
            this.pnlModificacion.Name = "pnlModificacion";
            this.pnlModificacion.Size = new System.Drawing.Size(419, 344);
            this.pnlModificacion.TabIndex = 0;
            // 
            // ucModificaciones
            // 
            this.ucModificaciones.AutoSize = true;
            this.ucModificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucModificaciones.Location = new System.Drawing.Point(0, 0);
            this.ucModificaciones.Name = "ucModificaciones";
            this.ucModificaciones.Owner = null;
            this.ucModificaciones.Size = new System.Drawing.Size(419, 344);
            this.ucModificaciones.TabIndex = 0;
            // 
            // pnlListado
            // 
            this.pnlListado.Controls.Add(this.ucListado);
            this.pnlListado.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlListado.Location = new System.Drawing.Point(0, 0);
            this.pnlListado.Name = "pnlListado";
            this.pnlListado.Size = new System.Drawing.Size(322, 344);
            this.pnlListado.TabIndex = 1;
            // 
            // ucListado
            // 
            this.ucListado.AutoSize = true;
            this.ucListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucListado.Location = new System.Drawing.Point(0, 0);
            this.ucListado.Name = "ucListado";
            this.ucListado.Owner = null;
            this.ucListado.Size = new System.Drawing.Size(322, 344);
            this.ucListado.TabIndex = 0;
            // 
            // ucMBPersona
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnlModificacion);
            this.Controls.Add(this.pnlListado);
            this.Name = "ucMBPersona";
            this.Size = new System.Drawing.Size(741, 344);
            this.pnlModificacion.ResumeLayout(false);
            this.pnlModificacion.PerformLayout();
            this.pnlListado.ResumeLayout(false);
            this.pnlListado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlModificacion;
        private ucAPersona ucModificaciones;
        private System.Windows.Forms.Panel pnlListado;
        private ucListaAlumnos ucListado;

    }
}
