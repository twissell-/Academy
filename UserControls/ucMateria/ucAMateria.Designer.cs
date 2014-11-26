namespace UserControls
{
    partial class ucAMateria
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
            this.grpMateria = new System.Windows.Forms.GroupBox();
            this.txtHsTotales = new System.Windows.Forms.NumericUpDown();
            this.txtHsSemanales = new System.Windows.Forms.NumericUpDown();
            this.lblHsTotales = new System.Windows.Forms.Label();
            this.lblHsSemanales = new System.Windows.Forms.Label();
            this.cmbPlan = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.grpMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHsTotales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHsSemanales)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMateria
            // 
            this.grpMateria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpMateria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpMateria.Controls.Add(this.txtHsTotales);
            this.grpMateria.Controls.Add(this.txtHsSemanales);
            this.grpMateria.Controls.Add(this.lblHsTotales);
            this.grpMateria.Controls.Add(this.lblHsSemanales);
            this.grpMateria.Controls.Add(this.cmbPlan);
            this.grpMateria.Controls.Add(this.btnBorrar);
            this.grpMateria.Controls.Add(this.txtDescripcion);
            this.grpMateria.Controls.Add(this.btnGuardar);
            this.grpMateria.Controls.Add(this.lblMateria);
            this.grpMateria.Controls.Add(this.lblDescripcion);
            this.grpMateria.Controls.Add(this.txtId);
            this.grpMateria.Controls.Add(this.lblPlan);
            this.grpMateria.Location = new System.Drawing.Point(0, 0);
            this.grpMateria.Name = "grpMateria";
            this.grpMateria.Size = new System.Drawing.Size(231, 193);
            this.grpMateria.TabIndex = 20;
            this.grpMateria.TabStop = false;
            this.grpMateria.Text = "Materia";
            // 
            // txtHsTotales
            // 
            this.txtHsTotales.DecimalPlaces = 1;
            this.txtHsTotales.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.txtHsTotales.Location = new System.Drawing.Point(90, 125);
            this.txtHsTotales.Name = "txtHsTotales";
            this.txtHsTotales.Size = new System.Drawing.Size(134, 20);
            this.txtHsTotales.TabIndex = 24;
            this.txtHsTotales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHsSemanales
            // 
            this.txtHsSemanales.DecimalPlaces = 1;
            this.txtHsSemanales.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.txtHsSemanales.Location = new System.Drawing.Point(90, 99);
            this.txtHsSemanales.Name = "txtHsSemanales";
            this.txtHsSemanales.Size = new System.Drawing.Size(134, 20);
            this.txtHsSemanales.TabIndex = 23;
            this.txtHsSemanales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHsTotales
            // 
            this.lblHsTotales.AutoSize = true;
            this.lblHsTotales.Location = new System.Drawing.Point(6, 127);
            this.lblHsTotales.Name = "lblHsTotales";
            this.lblHsTotales.Size = new System.Drawing.Size(61, 13);
            this.lblHsTotales.TabIndex = 21;
            this.lblHsTotales.Text = "Hs. Totales";
            // 
            // lblHsSemanales
            // 
            this.lblHsSemanales.AutoSize = true;
            this.lblHsSemanales.Location = new System.Drawing.Point(6, 101);
            this.lblHsSemanales.Name = "lblHsSemanales";
            this.lblHsSemanales.Size = new System.Drawing.Size(78, 13);
            this.lblHsSemanales.TabIndex = 19;
            this.lblHsSemanales.Text = "Hs Semanales:";
            // 
            // cmbPlan
            // 
            this.cmbPlan.FormattingEnabled = true;
            this.cmbPlan.Location = new System.Drawing.Point(90, 45);
            this.cmbPlan.Name = "cmbPlan";
            this.cmbPlan.Size = new System.Drawing.Size(134, 21);
            this.cmbPlan.TabIndex = 3;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.Location = new System.Drawing.Point(150, 151);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(90, 72);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(134, 20);
            this.txtDescripcion.TabIndex = 18;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(69, 151);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(6, 22);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(19, 13);
            this.lblMateria.TabIndex = 0;
            this.lblMateria.Text = "Id:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 75);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 17;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(90, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(134, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(6, 48);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(31, 13);
            this.lblPlan.TabIndex = 2;
            this.lblPlan.Text = "Plan:";
            // 
            // ucAMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.grpMateria);
            this.Name = "ucAMateria";
            this.Size = new System.Drawing.Size(231, 217);
            this.Load += new System.EventHandler(this.ucAMateria_Load);
            this.grpMateria.ResumeLayout(false);
            this.grpMateria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHsTotales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHsSemanales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMateria;
        private System.Windows.Forms.NumericUpDown txtHsTotales;
        private System.Windows.Forms.NumericUpDown txtHsSemanales;
        private System.Windows.Forms.Label lblHsTotales;
        private System.Windows.Forms.Label lblHsSemanales;
        private System.Windows.Forms.ComboBox cmbPlan;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblPlan;
    }
}
