namespace UserControls
{
    partial class ucListaAlumnos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumno,
            this.nombreAlumno,
            this.apellidoAlumno,
            this.telefonoAlumno,
            this.emailAlumno});
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // idAlumno
            // 
            this.idAlumno.HeaderText = "ID";
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.ReadOnly = true;
            // 
            // nombreAlumno
            // 
            this.nombreAlumno.HeaderText = "Nombre";
            this.nombreAlumno.Name = "nombreAlumno";
            this.nombreAlumno.ReadOnly = true;
            // 
            // apellidoAlumno
            // 
            this.apellidoAlumno.HeaderText = "Apellido";
            this.apellidoAlumno.Name = "apellidoAlumno";
            this.apellidoAlumno.ReadOnly = true;
            // 
            // telefonoAlumno
            // 
            this.telefonoAlumno.HeaderText = "Telefono";
            this.telefonoAlumno.Name = "telefonoAlumno";
            this.telefonoAlumno.ReadOnly = true;
            // 
            // emailAlumno
            // 
            this.emailAlumno.HeaderText = "E-Mail";
            this.emailAlumno.Name = "emailAlumno";
            this.emailAlumno.ReadOnly = true;
            // 
            // ListaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListaAlumnos";
            this.Size = new System.Drawing.Size(606, 323);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAlumno;
    }
}
