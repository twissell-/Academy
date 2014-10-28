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
            this.btnSalir = new System.Windows.Forms.Button();
            this.panAdm = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmMenuPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmComisiones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarComision = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificarComisiones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarComisiones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListadoDeComisiones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListadoDeAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDocentes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificarDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListadoDeDocentes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarEspecialidad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificarEspecialidad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarEspecialidad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListadoDeEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPlanes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificarPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListadoDePlanes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReporteCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReportePlanes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(737, 389);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panAdm
            // 
            this.panAdm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panAdm.Location = new System.Drawing.Point(92, 46);
            this.panAdm.Name = "panAdm";
            this.panAdm.Size = new System.Drawing.Size(720, 323);
            this.panAdm.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenuPrincipal});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "Menú";
            // 
            // tsmMenuPrincipal
            // 
            this.tsmMenuPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmComisiones,
            this.tsmAlumnos,
            this.tsmDocentes,
            this.tsmEspecialidades,
            this.tsmPlanes,
            this.tsmReportes,
            this.tsmSalir});
            this.tsmMenuPrincipal.Name = "tsmMenuPrincipal";
            this.tsmMenuPrincipal.Size = new System.Drawing.Size(50, 20);
            this.tsmMenuPrincipal.Text = "Menú";
            // 
            // tsmComisiones
            // 
            this.tsmComisiones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregarComision,
            this.tsmModificarComisiones,
            this.tsmEliminarComisiones,
            this.tsmListadoDeComisiones});
            this.tsmComisiones.Name = "tsmComisiones";
            this.tsmComisiones.Size = new System.Drawing.Size(152, 22);
            this.tsmComisiones.Text = "Comisiones";
            // 
            // tsmAgregarComision
            // 
            this.tsmAgregarComision.Name = "tsmAgregarComision";
            this.tsmAgregarComision.Size = new System.Drawing.Size(191, 22);
            this.tsmAgregarComision.Text = "Agregar";
            this.tsmAgregarComision.Click += new System.EventHandler(this.tsmAgregarComision_Click);
            // 
            // tsmModificarComisiones
            // 
            this.tsmModificarComisiones.Name = "tsmModificarComisiones";
            this.tsmModificarComisiones.Size = new System.Drawing.Size(191, 22);
            this.tsmModificarComisiones.Text = "Modificar";
            // 
            // tsmEliminarComisiones
            // 
            this.tsmEliminarComisiones.Name = "tsmEliminarComisiones";
            this.tsmEliminarComisiones.Size = new System.Drawing.Size(191, 22);
            this.tsmEliminarComisiones.Text = "Eliminar";
            // 
            // tsmListadoDeComisiones
            // 
            this.tsmListadoDeComisiones.Name = "tsmListadoDeComisiones";
            this.tsmListadoDeComisiones.Size = new System.Drawing.Size(191, 22);
            this.tsmListadoDeComisiones.Text = "Listado de comisiones";
            // 
            // tsmAlumnos
            // 
            this.tsmAlumnos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregarAlumno,
            this.tsmModificarAlumno,
            this.tsmEliminarAlumno,
            this.tsmListadoDeAlumnos});
            this.tsmAlumnos.Name = "tsmAlumnos";
            this.tsmAlumnos.Size = new System.Drawing.Size(152, 22);
            this.tsmAlumnos.Text = "Alumnos";
            // 
            // tsmAgregarAlumno
            // 
            this.tsmAgregarAlumno.Name = "tsmAgregarAlumno";
            this.tsmAgregarAlumno.Size = new System.Drawing.Size(177, 22);
            this.tsmAgregarAlumno.Text = "Agregar";
            this.tsmAgregarAlumno.Click += new System.EventHandler(this.tsmAMPersona_Click);
            // 
            // tsmModificarAlumno
            // 
            this.tsmModificarAlumno.Name = "tsmModificarAlumno";
            this.tsmModificarAlumno.Size = new System.Drawing.Size(177, 22);
            this.tsmModificarAlumno.Text = "Modificar";
            this.tsmModificarAlumno.Click += new System.EventHandler(this.tsmAMPersona_Click);
            // 
            // tsmEliminarAlumno
            // 
            this.tsmEliminarAlumno.Name = "tsmEliminarAlumno";
            this.tsmEliminarAlumno.Size = new System.Drawing.Size(177, 22);
            this.tsmEliminarAlumno.Text = "Eliminar";
            this.tsmEliminarAlumno.Click += new System.EventHandler(this.tsmEliminarPersona_Click);
            // 
            // tsmListadoDeAlumnos
            // 
            this.tsmListadoDeAlumnos.Name = "tsmListadoDeAlumnos";
            this.tsmListadoDeAlumnos.Size = new System.Drawing.Size(177, 22);
            this.tsmListadoDeAlumnos.Text = "Listado de alumnos";
            // 
            // tsmDocentes
            // 
            this.tsmDocentes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregarDocente,
            this.tsmModificarDocente,
            this.tsmEliminarDocente,
            this.tsmListadoDeDocentes});
            this.tsmDocentes.Name = "tsmDocentes";
            this.tsmDocentes.Size = new System.Drawing.Size(152, 22);
            this.tsmDocentes.Text = "Docentes";
            // 
            // tsmAgregarDocente
            // 
            this.tsmAgregarDocente.Name = "tsmAgregarDocente";
            this.tsmAgregarDocente.Size = new System.Drawing.Size(179, 22);
            this.tsmAgregarDocente.Text = "Agregar";
            this.tsmAgregarDocente.Click += new System.EventHandler(this.tsmAMPersona_Click);
            // 
            // tsmModificarDocente
            // 
            this.tsmModificarDocente.Name = "tsmModificarDocente";
            this.tsmModificarDocente.Size = new System.Drawing.Size(179, 22);
            this.tsmModificarDocente.Text = "Modificar";
            this.tsmModificarDocente.Click += new System.EventHandler(this.tsmAMPersona_Click);
            // 
            // tsmEliminarDocente
            // 
            this.tsmEliminarDocente.Name = "tsmEliminarDocente";
            this.tsmEliminarDocente.Size = new System.Drawing.Size(179, 22);
            this.tsmEliminarDocente.Text = "Eliminar";
            this.tsmEliminarDocente.Click += new System.EventHandler(this.tsmEliminarPersona_Click);
            // 
            // tsmListadoDeDocentes
            // 
            this.tsmListadoDeDocentes.Name = "tsmListadoDeDocentes";
            this.tsmListadoDeDocentes.Size = new System.Drawing.Size(179, 22);
            this.tsmListadoDeDocentes.Text = "Listado de docentes";
            // 
            // tsmEspecialidades
            // 
            this.tsmEspecialidades.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregarEspecialidad,
            this.tsmModificarEspecialidad,
            this.tsmEliminarEspecialidad,
            this.tsmListadoDeEspecialidades});
            this.tsmEspecialidades.Name = "tsmEspecialidades";
            this.tsmEspecialidades.Size = new System.Drawing.Size(152, 22);
            this.tsmEspecialidades.Text = "Especialidades";
            // 
            // tsmAgregarEspecialidad
            // 
            this.tsmAgregarEspecialidad.Name = "tsmAgregarEspecialidad";
            this.tsmAgregarEspecialidad.Size = new System.Drawing.Size(207, 22);
            this.tsmAgregarEspecialidad.Text = "Agregar";
            // 
            // tsmModificarEspecialidad
            // 
            this.tsmModificarEspecialidad.Name = "tsmModificarEspecialidad";
            this.tsmModificarEspecialidad.Size = new System.Drawing.Size(207, 22);
            this.tsmModificarEspecialidad.Text = "Modificar";
            // 
            // tsmEliminarEspecialidad
            // 
            this.tsmEliminarEspecialidad.Name = "tsmEliminarEspecialidad";
            this.tsmEliminarEspecialidad.Size = new System.Drawing.Size(207, 22);
            this.tsmEliminarEspecialidad.Text = "Eliminar";
            // 
            // tsmListadoDeEspecialidades
            // 
            this.tsmListadoDeEspecialidades.Name = "tsmListadoDeEspecialidades";
            this.tsmListadoDeEspecialidades.Size = new System.Drawing.Size(207, 22);
            this.tsmListadoDeEspecialidades.Text = "Listado de Especialidades";
            // 
            // tsmPlanes
            // 
            this.tsmPlanes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregarPlan,
            this.tsmModificarPlan,
            this.tsmEliminarPlan,
            this.tsmListadoDePlanes});
            this.tsmPlanes.Name = "tsmPlanes";
            this.tsmPlanes.Size = new System.Drawing.Size(152, 22);
            this.tsmPlanes.Text = "Planes";
            // 
            // tsmAgregarPlan
            // 
            this.tsmAgregarPlan.Name = "tsmAgregarPlan";
            this.tsmAgregarPlan.Size = new System.Drawing.Size(165, 22);
            this.tsmAgregarPlan.Text = "Agregar";
            // 
            // tsmModificarPlan
            // 
            this.tsmModificarPlan.Name = "tsmModificarPlan";
            this.tsmModificarPlan.Size = new System.Drawing.Size(165, 22);
            this.tsmModificarPlan.Text = "Modificar";
            // 
            // tsmEliminarPlan
            // 
            this.tsmEliminarPlan.Name = "tsmEliminarPlan";
            this.tsmEliminarPlan.Size = new System.Drawing.Size(165, 22);
            this.tsmEliminarPlan.Text = "Eliminar";
            // 
            // tsmListadoDePlanes
            // 
            this.tsmListadoDePlanes.Name = "tsmListadoDePlanes";
            this.tsmListadoDePlanes.Size = new System.Drawing.Size(165, 22);
            this.tsmListadoDePlanes.Text = "Listado de planes";
            // 
            // tsmReportes
            // 
            this.tsmReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmReporteCursos,
            this.tsmReportePlanes});
            this.tsmReportes.Name = "tsmReportes";
            this.tsmReportes.Size = new System.Drawing.Size(152, 22);
            this.tsmReportes.Text = "Reportes";
            // 
            // tsmReporteCursos
            // 
            this.tsmReporteCursos.Name = "tsmReporteCursos";
            this.tsmReporteCursos.Size = new System.Drawing.Size(110, 22);
            this.tsmReporteCursos.Text = "Cursos";
            // 
            // tsmReportePlanes
            // 
            this.tsmReportePlanes.Name = "tsmReportePlanes";
            this.tsmReportePlanes.Size = new System.Drawing.Size(110, 22);
            this.tsmReportePlanes.Text = "Planes";
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(152, 22);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 424);
            this.Controls.Add(this.panAdm);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Zahir Academia";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panAdm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmComisiones;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarComision;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarComisiones;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarComisiones;
        private System.Windows.Forms.ToolStripMenuItem tsmListadoDeComisiones;
        private System.Windows.Forms.ToolStripMenuItem tsmAlumnos;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarAlumno;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarAlumno;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarAlumno;
        private System.Windows.Forms.ToolStripMenuItem tsmListadoDeAlumnos;
        private System.Windows.Forms.ToolStripMenuItem tsmDocentes;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarDocente;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarDocente;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarDocente;
        private System.Windows.Forms.ToolStripMenuItem tsmListadoDeDocentes;
        private System.Windows.Forms.ToolStripMenuItem tsmEspecialidades;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarEspecialidad;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarEspecialidad;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarEspecialidad;
        private System.Windows.Forms.ToolStripMenuItem tsmListadoDeEspecialidades;
        private System.Windows.Forms.ToolStripMenuItem tsmPlanes;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarPlan;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarPlan;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarPlan;
        private System.Windows.Forms.ToolStripMenuItem tsmListadoDePlanes;
        private System.Windows.Forms.ToolStripMenuItem tsmReportes;
        private System.Windows.Forms.ToolStripMenuItem tsmReporteCursos;
        private System.Windows.Forms.ToolStripMenuItem tsmReportePlanes;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;


        public System.EventHandler FrmPrincipal_Load { get; set; }

        public System.Windows.Forms.PaintEventHandler panel1_Paint { get; set; }
    }      
}