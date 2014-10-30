namespace UserControls
{
    partial class ucAgregarComision
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
            this.grpComision = new System.Windows.Forms.GroupBox();
            this.txtAñoCursado = new System.Windows.Forms.TextBox();
            this.lblAñoCursado = new System.Windows.Forms.Label();
            this.txtHsTotales = new System.Windows.Forms.TextBox();
            this.lblHsTotales = new System.Windows.Forms.Label();
            this.txtHsSemanales = new System.Windows.Forms.TextBox();
            this.lblHsSemanales = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.gpbMateria = new System.Windows.Forms.GroupBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.grpComision.SuspendLayout();
            this.gpbMateria.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpComision
            // 
            this.grpComision.Controls.Add(this.txtAñoCursado);
            this.grpComision.Controls.Add(this.lblAñoCursado);
            this.grpComision.Controls.Add(this.txtHsTotales);
            this.grpComision.Controls.Add(this.lblHsTotales);
            this.grpComision.Controls.Add(this.txtHsSemanales);
            this.grpComision.Controls.Add(this.lblHsSemanales);
            this.grpComision.Controls.Add(this.cmbTurno);
            this.grpComision.Controls.Add(this.lblTurno);
            this.grpComision.Location = new System.Drawing.Point(35, 81);
            this.grpComision.Name = "grpComision";
            this.grpComision.Size = new System.Drawing.Size(245, 152);
            this.grpComision.TabIndex = 17;
            this.grpComision.TabStop = false;
            this.grpComision.Text = "Datos Comision";
            // 
            // txtAñoCursado
            // 
            this.txtAñoCursado.Location = new System.Drawing.Point(108, 19);
            this.txtAñoCursado.Name = "txtAñoCursado";
            this.txtAñoCursado.Size = new System.Drawing.Size(121, 20);
            this.txtAñoCursado.TabIndex = 13;
            // 
            // lblAñoCursado
            // 
            this.lblAñoCursado.AutoSize = true;
            this.lblAñoCursado.Location = new System.Drawing.Point(32, 27);
            this.lblAñoCursado.Name = "lblAñoCursado";
            this.lblAñoCursado.Size = new System.Drawing.Size(70, 13);
            this.lblAñoCursado.TabIndex = 12;
            this.lblAñoCursado.Text = "Año cursado:";
            // 
            // txtHsTotales
            // 
            this.txtHsTotales.Location = new System.Drawing.Point(108, 119);
            this.txtHsTotales.Name = "txtHsTotales";
            this.txtHsTotales.Size = new System.Drawing.Size(121, 20);
            this.txtHsTotales.TabIndex = 11;
            // 
            // lblHsTotales
            // 
            this.lblHsTotales.AutoSize = true;
            this.lblHsTotales.Location = new System.Drawing.Point(38, 126);
            this.lblHsTotales.Name = "lblHsTotales";
            this.lblHsTotales.Size = new System.Drawing.Size(64, 13);
            this.lblHsTotales.TabIndex = 10;
            this.lblHsTotales.Text = "Hs. Totales:";
            // 
            // txtHsSemanales
            // 
            this.txtHsSemanales.Location = new System.Drawing.Point(108, 89);
            this.txtHsSemanales.Name = "txtHsSemanales";
            this.txtHsSemanales.Size = new System.Drawing.Size(121, 20);
            this.txtHsSemanales.TabIndex = 9;
            // 
            // lblHsSemanales
            // 
            this.lblHsSemanales.AutoSize = true;
            this.lblHsSemanales.Location = new System.Drawing.Point(21, 96);
            this.lblHsSemanales.Name = "lblHsSemanales";
            this.lblHsSemanales.Size = new System.Drawing.Size(81, 13);
            this.lblHsSemanales.TabIndex = 8;
            this.lblHsSemanales.Text = "Hs. Semanales:";
            // 
            // cmbTurno
            // 
            this.cmbTurno.DisplayMember = "Mañana";
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Items.AddRange(new object[] {
            "",
            "Mañana",
            "Tarde",
            "Noche"});
            this.cmbTurno.Location = new System.Drawing.Point(108, 55);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(121, 21);
            this.cmbTurno.TabIndex = 3;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(64, 63);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 2;
            this.lblTurno.Text = "Turno:";
            // 
            // btnDocentes
            // 
            this.btnDocentes.Location = new System.Drawing.Point(93, 74);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(115, 35);
            this.btnDocentes.TabIndex = 6;
            this.btnDocentes.Text = "Docentes";
            this.btnDocentes.UseVisualStyleBackColor = true;
            this.btnDocentes.Click += new System.EventHandler(this.btnDocentes_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(381, 267);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(295, 267);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(462, 267);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(70, 23);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 13;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(32, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Id.";
            // 
            // gpbMateria
            // 
            this.gpbMateria.Controls.Add(this.cmbMateria);
            this.gpbMateria.Controls.Add(this.btnDocentes);
            this.gpbMateria.Location = new System.Drawing.Point(287, 81);
            this.gpbMateria.Name = "gpbMateria";
            this.gpbMateria.Size = new System.Drawing.Size(227, 152);
            this.gpbMateria.TabIndex = 18;
            this.gpbMateria.TabStop = false;
            this.gpbMateria.Text = "Materia";
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(7, 27);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(201, 21);
            this.cmbMateria.TabIndex = 8;
            // 
            // ucAgregarComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbMateria);
            this.Controls.Add(this.grpComision);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "ucAgregarComision";
            this.Size = new System.Drawing.Size(606, 323);
            this.grpComision.ResumeLayout(false);
            this.grpComision.PerformLayout();
            this.gpbMateria.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpComision;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtHsTotales;
        private System.Windows.Forms.Label lblHsTotales;
        private System.Windows.Forms.TextBox txtHsSemanales;
        private System.Windows.Forms.Label lblHsSemanales;
        private System.Windows.Forms.GroupBox gpbMateria;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.TextBox txtAñoCursado;
        private System.Windows.Forms.Label lblAñoCursado;
    }
}
