namespace GUI
{
    partial class FrmListaDocentes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvListaDocentes = new System.Windows.Forms.DataGridView();
            this.dgvApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgCargo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dvgAsignado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAgregarDocente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(555, 227);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(474, 227);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(393, 227);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dgvListaDocentes
            // 
            this.dgvListaDocentes.AllowUserToOrderColumns = true;
            this.dgvListaDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvApellido,
            this.dgvNombre,
            this.dvgCargo,
            this.dvgAsignado});
            this.dgvListaDocentes.Location = new System.Drawing.Point(38, 39);
            this.dgvListaDocentes.Name = "dgvListaDocentes";
            this.dgvListaDocentes.Size = new System.Drawing.Size(443, 150);
            this.dgvListaDocentes.TabIndex = 11;
            // 
            // dgvApellido
            // 
            this.dgvApellido.HeaderText = "Apellido";
            this.dgvApellido.Name = "dgvApellido";
            this.dgvApellido.ReadOnly = true;
            // 
            // dgvNombre
            // 
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.Name = "dgvNombre";
            this.dgvNombre.ReadOnly = true;
            // 
            // dvgCargo
            // 
            this.dvgCargo.HeaderText = "Cargo";
            this.dvgCargo.Name = "dvgCargo";
            this.dvgCargo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCargo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dvgAsignado
            // 
            this.dvgAsignado.HeaderText = "Asignado";
            this.dvgAsignado.Name = "dvgAsignado";
            this.dvgAsignado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgAsignado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnAgregarDocente
            // 
            this.btnAgregarDocente.Location = new System.Drawing.Point(509, 39);
            this.btnAgregarDocente.Name = "btnAgregarDocente";
            this.btnAgregarDocente.Size = new System.Drawing.Size(121, 62);
            this.btnAgregarDocente.TabIndex = 12;
            this.btnAgregarDocente.Text = "Agregar Docente";
            this.btnAgregarDocente.UseVisualStyleBackColor = true;
            this.btnAgregarDocente.Click += new System.EventHandler(this.btnAgregarDocente_Click);
            // 
            // FrmListaDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 262);
            this.Controls.Add(this.btnAgregarDocente);
            this.Controls.Add(this.dgvListaDocentes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FrmListaDocentes";
            this.Text = "ListaDocentes";
            this.Load += new System.EventHandler(this.FrmListaDocentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDocentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvListaDocentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewComboBoxColumn dvgCargo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dvgAsignado;
        private System.Windows.Forms.Button btnAgregarDocente;

        public System.EventHandler FrmListaDocentes_Load { get; set; }
    }
}