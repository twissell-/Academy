﻿namespace GUI
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
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificarMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListadoDeMaterias = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsmAgregarDocentes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificarDocentes = new System.Windows.Forms.ToolStripMenuItem();
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
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReporteComisiones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReportePlanes = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsmMenuPrincipal,
            this.tsmMaterias,
            this.tsmComisiones,
            this.tsmAlumnos,
            this.tsmDocentes,
            this.tsmEspecialidades,
            this.tsmPlanes,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "Menú";
            // 
            // tsmMenuPrincipal
            // 
            this.tsmMenuPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSalir});
            this.tsmMenuPrincipal.Name = "tsmMenuPrincipal";
            this.tsmMenuPrincipal.Size = new System.Drawing.Size(50, 20);
            this.tsmMenuPrincipal.Text = "Menú";
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(96, 22);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // tsmMaterias
            // 
            this.tsmMaterias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregarMateria,
            this.tsmModificarMateria,
            this.tsmEliminarMateria,
            this.tsmListadoDeMaterias});
            this.tsmMaterias.Name = "tsmMaterias";
            this.tsmMaterias.Size = new System.Drawing.Size(64, 20);
            this.tsmMaterias.Text = "Materias";
            // 
            // tsmAgregarMateria
            // 
            this.tsmAgregarMateria.Name = "tsmAgregarMateria";
            this.tsmAgregarMateria.Size = new System.Drawing.Size(176, 22);
            this.tsmAgregarMateria.Text = "Agregar";
            this.tsmAgregarMateria.Click += new System.EventHandler(this.tsmAMMateria_Click);
            // 
            // tsmModificarMateria
            // 
            this.tsmModificarMateria.Name = "tsmModificarMateria";
            this.tsmModificarMateria.Size = new System.Drawing.Size(176, 22);
            this.tsmModificarMateria.Text = "Modificar";
            this.tsmModificarMateria.Click += new System.EventHandler(this.tsmAMMateria_Click);
            // 
            // tsmEliminarMateria
            // 
            this.tsmEliminarMateria.Name = "tsmEliminarMateria";
            this.tsmEliminarMateria.Size = new System.Drawing.Size(176, 22);
            this.tsmEliminarMateria.Text = "Eliminar";
            // 
            // tsmListadoDeMaterias
            // 
            this.tsmListadoDeMaterias.Name = "tsmListadoDeMaterias";
            this.tsmListadoDeMaterias.Size = new System.Drawing.Size(176, 22);
            this.tsmListadoDeMaterias.Text = "Listado de Materias";
            // 
            // tsmComisiones
            // 
            this.tsmComisiones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregarComision,
            this.tsmModificarComisiones,
            this.tsmEliminarComisiones,
            this.tsmListadoDeComisiones});
            this.tsmComisiones.Name = "tsmComisiones";
            this.tsmComisiones.Size = new System.Drawing.Size(81, 20);
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
            this.tsmAlumnos.Size = new System.Drawing.Size(67, 20);
            this.tsmAlumnos.Text = "Alumnos";
            // 
            // tsmAgregarAlumno
            // 
            this.tsmAgregarAlumno.Name = "tsmAgregarAlumno";
            this.tsmAgregarAlumno.Size = new System.Drawing.Size(179, 22);
            this.tsmAgregarAlumno.Text = "Agregar";
            this.tsmAgregarAlumno.Click += new System.EventHandler(this.tsmAMPersona_Click);
            // 
            // tsmModificarAlumno
            // 
            this.tsmModificarAlumno.Name = "tsmModificarAlumno";
            this.tsmModificarAlumno.Size = new System.Drawing.Size(179, 22);
            this.tsmModificarAlumno.Text = "Modificar";
            this.tsmModificarAlumno.Click += new System.EventHandler(this.tsmAMPersona_Click);
            // 
            // tsmEliminarAlumno
            // 
            this.tsmEliminarAlumno.Name = "tsmEliminarAlumno";
            this.tsmEliminarAlumno.Size = new System.Drawing.Size(179, 22);
            this.tsmEliminarAlumno.Text = "Eliminar";
            this.tsmEliminarAlumno.Click += new System.EventHandler(this.tsmEliminarPersona_Click);
            // 
            // tsmListadoDeAlumnos
            // 
            this.tsmListadoDeAlumnos.Name = "tsmListadoDeAlumnos";
            this.tsmListadoDeAlumnos.Size = new System.Drawing.Size(179, 22);
            this.tsmListadoDeAlumnos.Text = "Listado de Alumnos";
            // 
            // tsmDocentes
            // 
            this.tsmDocentes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregarDocentes,
            this.tsmModificarDocentes,
            this.tsmEliminarDocente,
            this.tsmListadoDeDocentes});
            this.tsmDocentes.Name = "tsmDocentes";
            this.tsmDocentes.Size = new System.Drawing.Size(68, 20);
            this.tsmDocentes.Text = "Docentes";
            // 
            // tsmAgregarDocentes
            // 
            this.tsmAgregarDocentes.Name = "tsmAgregarDocentes";
            this.tsmAgregarDocentes.Size = new System.Drawing.Size(180, 22);
            this.tsmAgregarDocentes.Text = "Agregar";
            this.tsmAgregarDocentes.Click += new System.EventHandler(this.tsmAMPersona_Click);
            // 
            // tsmModificarDocentes
            // 
            this.tsmModificarDocentes.Name = "tsmModificarDocentes";
            this.tsmModificarDocentes.Size = new System.Drawing.Size(180, 22);
            this.tsmModificarDocentes.Text = "Modificar";
            this.tsmModificarDocentes.Click += new System.EventHandler(this.tsmAMPersona_Click);
            // 
            // tsmEliminarDocente
            // 
            this.tsmEliminarDocente.Name = "tsmEliminarDocente";
            this.tsmEliminarDocente.Size = new System.Drawing.Size(180, 22);
            this.tsmEliminarDocente.Text = "Eliminar";
            this.tsmEliminarDocente.Click += new System.EventHandler(this.tsmEliminarPersona_Click);
            // 
            // tsmListadoDeDocentes
            // 
            this.tsmListadoDeDocentes.Name = "tsmListadoDeDocentes";
            this.tsmListadoDeDocentes.Size = new System.Drawing.Size(180, 22);
            this.tsmListadoDeDocentes.Text = "Listado de Docentes";
            // 
            // tsmEspecialidades
            // 
            this.tsmEspecialidades.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregarEspecialidad,
            this.tsmModificarEspecialidad,
            this.tsmEliminarEspecialidad,
            this.tsmListadoDeEspecialidades});
            this.tsmEspecialidades.Name = "tsmEspecialidades";
            this.tsmEspecialidades.Size = new System.Drawing.Size(95, 20);
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
            this.tsmPlanes.Size = new System.Drawing.Size(53, 20);
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
            this.tsmListadoDePlanes.Text = "Listado de Planes";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmReporteComisiones,
            this.tsmReportePlanes});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // tsmReporteComisiones
            // 
            this.tsmReporteComisiones.Name = "tsmReporteComisiones";
            this.tsmReporteComisiones.Size = new System.Drawing.Size(136, 22);
            this.tsmReporteComisiones.Text = "Comisiones";
            // 
            // tsmReportePlanes
            // 
            this.tsmReportePlanes.Name = "tsmReportePlanes";
            this.tsmReportePlanes.Size = new System.Drawing.Size(136, 22);
            this.tsmReportePlanes.Text = "Planes";
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
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
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
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarDocentes;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarDocentes;
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
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmReporteComisiones;
        private System.Windows.Forms.ToolStripMenuItem tsmReportePlanes;
        private System.Windows.Forms.ToolStripMenuItem tsmMaterias;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarMateria;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarMateria;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarMateria;
        private System.Windows.Forms.ToolStripMenuItem tsmListadoDeMaterias;


        public System.EventHandler FrmPrincipal_Load { get; set; }

        public System.Windows.Forms.PaintEventHandler panel1_Paint { get; set; }
    }      
}