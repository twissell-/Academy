namespace GUI
{
    partial class FrmPrincipal
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
            this.btnVerComisiones = new System.Windows.Forms.Button();
            this.btnVerAlumnos = new System.Windows.Forms.Button();
            this.btnAgregarDocente = new System.Windows.Forms.Button();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregarEspecialidad = new System.Windows.Forms.Button();
            this.btnAgregarComision = new System.Windows.Forms.Button();
            this.btnAgregarPlan = new System.Windows.Forms.Button();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnReportes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerComisiones
            // 
            this.btnVerComisiones.Location = new System.Drawing.Point(18, 27);
            this.btnVerComisiones.Name = "btnVerComisiones";
            this.btnVerComisiones.Size = new System.Drawing.Size(133, 35);
            this.btnVerComisiones.TabIndex = 0;
            this.btnVerComisiones.Text = "Ver Comisiones";
            this.btnVerComisiones.UseVisualStyleBackColor = true;
            this.btnVerComisiones.Click += new System.EventHandler(this.btnVerCursos_Click);
            // 
            // btnVerAlumnos
            // 
            this.btnVerAlumnos.Location = new System.Drawing.Point(17, 68);
            this.btnVerAlumnos.Name = "btnVerAlumnos";
            this.btnVerAlumnos.Size = new System.Drawing.Size(133, 35);
            this.btnVerAlumnos.TabIndex = 1;
            this.btnVerAlumnos.Text = "Ver Alumnos";
            this.btnVerAlumnos.UseVisualStyleBackColor = true;
            this.btnVerAlumnos.Click += new System.EventHandler(this.btnVerAlumnos_Click);
            // 
            // btnAgregarDocente
            // 
            this.btnAgregarDocente.Location = new System.Drawing.Point(17, 109);
            this.btnAgregarDocente.Name = "btnAgregarDocente";
            this.btnAgregarDocente.Size = new System.Drawing.Size(133, 35);
            this.btnAgregarDocente.TabIndex = 2;
            this.btnAgregarDocente.Text = "Agregar Docente";
            this.btnAgregarDocente.UseVisualStyleBackColor = true;
            this.btnAgregarDocente.Click += new System.EventHandler(this.btnAgregarDocente_Click);
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(18, 150);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(133, 35);
            this.btnAgregarAlumno.TabIndex = 3;
            this.btnAgregarAlumno.Text = "Agregar Alumno";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(743, 356);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregarEspecialidad
            // 
            this.btnAgregarEspecialidad.Location = new System.Drawing.Point(17, 191);
            this.btnAgregarEspecialidad.Name = "btnAgregarEspecialidad";
            this.btnAgregarEspecialidad.Size = new System.Drawing.Size(133, 35);
            this.btnAgregarEspecialidad.TabIndex = 5;
            this.btnAgregarEspecialidad.Text = "Agregar Especialidad";
            this.btnAgregarEspecialidad.UseVisualStyleBackColor = true;
            this.btnAgregarEspecialidad.Click += new System.EventHandler(this.btnAgregarEspecialidad_Click);
            // 
            // btnAgregarComision
            // 
            this.btnAgregarComision.Location = new System.Drawing.Point(17, 232);
            this.btnAgregarComision.Name = "btnAgregarComision";
            this.btnAgregarComision.Size = new System.Drawing.Size(133, 35);
            this.btnAgregarComision.TabIndex = 6;
            this.btnAgregarComision.Text = "Agregar Comisión";
            this.btnAgregarComision.UseVisualStyleBackColor = true;
            this.btnAgregarComision.Click += new System.EventHandler(this.btnAgregarComision_Click);
            // 
            // btnAgregarPlan
            // 
            this.btnAgregarPlan.Location = new System.Drawing.Point(17, 273);
            this.btnAgregarPlan.Name = "btnAgregarPlan";
            this.btnAgregarPlan.Size = new System.Drawing.Size(133, 35);
            this.btnAgregarPlan.TabIndex = 7;
            this.btnAgregarPlan.Text = "Agregar Plan";
            this.btnAgregarPlan.UseVisualStyleBackColor = true;
            this.btnAgregarPlan.Click += new System.EventHandler(this.btnAgregarPlan_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnReportes);
            this.grpMenu.Controls.Add(this.btnVerComisiones);
            this.grpMenu.Controls.Add(this.btnVerAlumnos);
            this.grpMenu.Controls.Add(this.btnAgregarPlan);
            this.grpMenu.Controls.Add(this.btnAgregarDocente);
            this.grpMenu.Controls.Add(this.btnAgregarComision);
            this.grpMenu.Controls.Add(this.btnAgregarAlumno);
            this.grpMenu.Controls.Add(this.btnAgregarEspecialidad);
            this.grpMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpMenu.Location = new System.Drawing.Point(13, 13);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(173, 366);
            this.grpMenu.TabIndex = 9;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Menú";
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(17, 314);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(133, 35);
            this.btnReportes.TabIndex = 8;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(193, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 323);
            this.panel1.TabIndex = 10;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.btnSalir);
            this.Name = "FrmPrincipal";
            this.Text = "Azhir Academia";
           // this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.grpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerComisiones;
        private System.Windows.Forms.Button btnVerAlumnos;
        private System.Windows.Forms.Button btnAgregarDocente;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregarEspecialidad;
        private System.Windows.Forms.Button btnAgregarComision;
        private System.Windows.Forms.Button btnAgregarPlan;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel panel1;


        public System.EventHandler FrmPrincipal_Load { get; set; }

        public System.Windows.Forms.PaintEventHandler panel1_Paint { get; set; }
    }      
}