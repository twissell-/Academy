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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnSalir = new System.Windows.Forms.Button();
            this.panAdmGral = new System.Windows.Forms.Panel();
            this.panAdmOtro = new System.Windows.Forms.Panel();
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
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdministrativo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarAdministrativo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificarAdministrativo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarAdministrativoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListadoDeAdministrativo = new System.Windows.Forms.ToolStripMenuItem();
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
            this.stsBarraEstado = new System.Windows.Forms.StatusStrip();
            this.lblRelleno = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuarioActivoNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuarioActivoId = new System.Windows.Forms.ToolStripStatusLabel();
            this.panAdmGral.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.stsBarraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.AutoSize = true;
            this.btnSalir.Location = new System.Drawing.Point(785, 405);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panAdmGral
            // 
            this.panAdmGral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panAdmGral.AutoSize = true;
            this.panAdmGral.Controls.Add(this.panAdmOtro);
            this.panAdmGral.Location = new System.Drawing.Point(12, 27);
            this.panAdmGral.Name = "panAdmGral";
            this.panAdmGral.Size = new System.Drawing.Size(848, 372);
            this.panAdmGral.TabIndex = 10;
            // 
            // panAdmOtro
            // 
            this.panAdmOtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panAdmOtro.AutoSize = true;
            this.panAdmOtro.Location = new System.Drawing.Point(-16, 1);
            this.panAdmOtro.Name = "panAdmOtro";
            this.panAdmOtro.Size = new System.Drawing.Size(0, 0);
            this.panAdmOtro.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenuPrincipal,
            this.tsmMaterias,
            this.tsmComisiones,
            this.personalToolStripMenuItem,
            this.tsmEspecialidades,
            this.tsmPlanes});
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
            this.tsmEliminarMateria.Click += new System.EventHandler(this.tsmEliminarMateria_Click);
            // 
            // tsmListadoDeMaterias
            // 
            this.tsmListadoDeMaterias.Name = "tsmListadoDeMaterias";
            this.tsmListadoDeMaterias.Size = new System.Drawing.Size(176, 22);
            this.tsmListadoDeMaterias.Text = "Listado de Materias";
            this.tsmListadoDeMaterias.Click += new System.EventHandler(this.tsmListadoDeMaterias_Click);
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
            this.tsmModificarComisiones.Click += new System.EventHandler(this.tsmModificarComisiones_Click);
            // 
            // tsmEliminarComisiones
            // 
            this.tsmEliminarComisiones.Name = "tsmEliminarComisiones";
            this.tsmEliminarComisiones.Size = new System.Drawing.Size(191, 22);
            this.tsmEliminarComisiones.Text = "Eliminar";
            this.tsmEliminarComisiones.Click += new System.EventHandler(this.tsmEliminarComisiones_Click);
            // 
            // tsmListadoDeComisiones
            // 
            this.tsmListadoDeComisiones.Name = "tsmListadoDeComisiones";
            this.tsmListadoDeComisiones.Size = new System.Drawing.Size(191, 22);
            this.tsmListadoDeComisiones.Text = "Listado de comisiones";
            this.tsmListadoDeComisiones.Click += new System.EventHandler(this.tsmListadoDeComisiones_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsuarioToolStripMenuItem,
            this.tsmAdministrativo,
            this.tsmAlumnos,
            this.tsmDocentes});
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personalToolStripMenuItem.Text = "Usuarios";
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario...";
            this.nuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuarioToolStripMenuItem_Click);
            // 
            // tsmAdministrativo
            // 
            this.tsmAdministrativo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregarAdministrativo,
            this.tsmModificarAdministrativo,
            this.tsmEliminarAdministrativoToolStripMenuItem1,
            this.tsmListadoDeAdministrativo});
            this.tsmAdministrativo.Name = "tsmAdministrativo";
            this.tsmAdministrativo.Size = new System.Drawing.Size(161, 22);
            this.tsmAdministrativo.Text = "Administrativos";
            this.tsmAdministrativo.Click += new System.EventHandler(this.tsmAdministrativo_Click);
            // 
            // tsmAgregarAdministrativo
            // 
            this.tsmAgregarAdministrativo.Name = "tsmAgregarAdministrativo";
            this.tsmAgregarAdministrativo.Size = new System.Drawing.Size(212, 22);
            this.tsmAgregarAdministrativo.Text = "Agregar administrativo";
            this.tsmAgregarAdministrativo.Click += new System.EventHandler(this.tsmAPersona_Click);
            // 
            // tsmModificarAdministrativo
            // 
            this.tsmModificarAdministrativo.Name = "tsmModificarAdministrativo";
            this.tsmModificarAdministrativo.Size = new System.Drawing.Size(212, 22);
            this.tsmModificarAdministrativo.Text = "Modificar administrativo";
            this.tsmModificarAdministrativo.Click += new System.EventHandler(this.tsmMPersona_Click);
            // 
            // tsmEliminarAdministrativoToolStripMenuItem1
            // 
            this.tsmEliminarAdministrativoToolStripMenuItem1.Name = "tsmEliminarAdministrativoToolStripMenuItem1";
            this.tsmEliminarAdministrativoToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.tsmEliminarAdministrativoToolStripMenuItem1.Text = "Eliminar administrativo";
            this.tsmEliminarAdministrativoToolStripMenuItem1.Click += new System.EventHandler(this.tsmEliminarPersona_Click);
            // 
            // tsmListadoDeAdministrativo
            // 
            this.tsmListadoDeAdministrativo.Name = "tsmListadoDeAdministrativo";
            this.tsmListadoDeAdministrativo.Size = new System.Drawing.Size(212, 22);
            this.tsmListadoDeAdministrativo.Text = "Listado de administrativos";
            this.tsmListadoDeAdministrativo.Click += new System.EventHandler(this.tsmListadoDeAdministrativo_Click);
            // 
            // tsmAlumnos
            // 
            this.tsmAlumnos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregarAlumno,
            this.tsmModificarAlumno,
            this.tsmEliminarAlumno,
            this.tsmListadoDeAlumnos});
            this.tsmAlumnos.Name = "tsmAlumnos";
            this.tsmAlumnos.Size = new System.Drawing.Size(161, 22);
            this.tsmAlumnos.Text = "Alumnos";
            this.tsmAlumnos.Click += new System.EventHandler(this.tsmAlumnos_Click);
            // 
            // tsmAgregarAlumno
            // 
            this.tsmAgregarAlumno.Name = "tsmAgregarAlumno";
            this.tsmAgregarAlumno.Size = new System.Drawing.Size(177, 22);
            this.tsmAgregarAlumno.Text = "Agregar alumno";
            this.tsmAgregarAlumno.Click += new System.EventHandler(this.tsmAPersona_Click);
            // 
            // tsmModificarAlumno
            // 
            this.tsmModificarAlumno.Name = "tsmModificarAlumno";
            this.tsmModificarAlumno.Size = new System.Drawing.Size(177, 22);
            this.tsmModificarAlumno.Text = "Modificar alumno";
            this.tsmModificarAlumno.Click += new System.EventHandler(this.tsmMPersona_Click);
            // 
            // tsmEliminarAlumno
            // 
            this.tsmEliminarAlumno.Name = "tsmEliminarAlumno";
            this.tsmEliminarAlumno.Size = new System.Drawing.Size(177, 22);
            this.tsmEliminarAlumno.Text = "Eliminar alumno";
            this.tsmEliminarAlumno.Click += new System.EventHandler(this.tsmEliminarPersona_Click);
            // 
            // tsmListadoDeAlumnos
            // 
            this.tsmListadoDeAlumnos.Name = "tsmListadoDeAlumnos";
            this.tsmListadoDeAlumnos.Size = new System.Drawing.Size(177, 22);
            this.tsmListadoDeAlumnos.Text = "Listado de alumnos";
            this.tsmListadoDeAlumnos.Click += new System.EventHandler(this.tsmListadoDeAlumnos_Click);
            // 
            // tsmDocentes
            // 
            this.tsmDocentes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregarDocente,
            this.tsmModificarDocente,
            this.tsmEliminarDocente,
            this.tsmListadoDeDocentes});
            this.tsmDocentes.Name = "tsmDocentes";
            this.tsmDocentes.Size = new System.Drawing.Size(161, 22);
            this.tsmDocentes.Text = "Docentes";
            this.tsmDocentes.Click += new System.EventHandler(this.tsmDocentes_Click);
            // 
            // tsmAgregarDocente
            // 
            this.tsmAgregarDocente.Name = "tsmAgregarDocente";
            this.tsmAgregarDocente.Size = new System.Drawing.Size(179, 22);
            this.tsmAgregarDocente.Text = "Agregar docente";
            this.tsmAgregarDocente.Click += new System.EventHandler(this.tsmAPersona_Click);
            // 
            // tsmModificarDocente
            // 
            this.tsmModificarDocente.Name = "tsmModificarDocente";
            this.tsmModificarDocente.Size = new System.Drawing.Size(179, 22);
            this.tsmModificarDocente.Text = "Modificar docente";
            this.tsmModificarDocente.Click += new System.EventHandler(this.tsmMPersona_Click);
            // 
            // tsmEliminarDocente
            // 
            this.tsmEliminarDocente.Name = "tsmEliminarDocente";
            this.tsmEliminarDocente.Size = new System.Drawing.Size(179, 22);
            this.tsmEliminarDocente.Text = "Eliminar docente";
            this.tsmEliminarDocente.Click += new System.EventHandler(this.tsmEliminarPersona_Click);
            // 
            // tsmListadoDeDocentes
            // 
            this.tsmListadoDeDocentes.Name = "tsmListadoDeDocentes";
            this.tsmListadoDeDocentes.Size = new System.Drawing.Size(179, 22);
            this.tsmListadoDeDocentes.Text = "Listado de docentes";
            this.tsmListadoDeDocentes.Click += new System.EventHandler(this.tsmListadoDeDocentes_Click);
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
            this.tsmAgregarEspecialidad.Click += new System.EventHandler(this.tsmAgregarEspecialidad_Click);
            // 
            // tsmModificarEspecialidad
            // 
            this.tsmModificarEspecialidad.Name = "tsmModificarEspecialidad";
            this.tsmModificarEspecialidad.Size = new System.Drawing.Size(207, 22);
            this.tsmModificarEspecialidad.Text = "Modificar";
            this.tsmModificarEspecialidad.Click += new System.EventHandler(this.tsmModificarEspecialidad_Click);
            // 
            // tsmEliminarEspecialidad
            // 
            this.tsmEliminarEspecialidad.Name = "tsmEliminarEspecialidad";
            this.tsmEliminarEspecialidad.Size = new System.Drawing.Size(207, 22);
            this.tsmEliminarEspecialidad.Text = "Eliminar";
            this.tsmEliminarEspecialidad.Click += new System.EventHandler(this.tsmEliminarEspecialidad_Click);
            // 
            // tsmListadoDeEspecialidades
            // 
            this.tsmListadoDeEspecialidades.Name = "tsmListadoDeEspecialidades";
            this.tsmListadoDeEspecialidades.Size = new System.Drawing.Size(207, 22);
            this.tsmListadoDeEspecialidades.Text = "Listado de Especialidades";
            this.tsmListadoDeEspecialidades.Click += new System.EventHandler(this.tsmListadoDeEspecialidades_Click);
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
            this.tsmAgregarPlan.Click += new System.EventHandler(this.tsmAgregarPlan_Click);
            // 
            // tsmModificarPlan
            // 
            this.tsmModificarPlan.Name = "tsmModificarPlan";
            this.tsmModificarPlan.Size = new System.Drawing.Size(165, 22);
            this.tsmModificarPlan.Text = "Modificar";
            this.tsmModificarPlan.Click += new System.EventHandler(this.tsmModificarPlan_Click);
            // 
            // tsmEliminarPlan
            // 
            this.tsmEliminarPlan.Name = "tsmEliminarPlan";
            this.tsmEliminarPlan.Size = new System.Drawing.Size(165, 22);
            this.tsmEliminarPlan.Text = "Eliminar";
            this.tsmEliminarPlan.Click += new System.EventHandler(this.tsmEliminarPlan_Click);
            // 
            // tsmListadoDePlanes
            // 
            this.tsmListadoDePlanes.Name = "tsmListadoDePlanes";
            this.tsmListadoDePlanes.Size = new System.Drawing.Size(165, 22);
            this.tsmListadoDePlanes.Text = "Listado de Planes";
            this.tsmListadoDePlanes.Click += new System.EventHandler(this.tsmListadoDePlanes_Click);
            // 
            // stsBarraEstado
            // 
            this.stsBarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRelleno,
            this.lblUsuarioActivoNombre,
            this.lblUsuarioActivoId});
            this.stsBarraEstado.Location = new System.Drawing.Point(0, 431);
            this.stsBarraEstado.Name = "stsBarraEstado";
            this.stsBarraEstado.Size = new System.Drawing.Size(872, 24);
            this.stsBarraEstado.TabIndex = 12;
            this.stsBarraEstado.Text = "statusStrip1";
            // 
            // lblRelleno
            // 
            this.lblRelleno.Name = "lblRelleno";
            this.lblRelleno.Size = new System.Drawing.Size(704, 19);
            this.lblRelleno.Spring = true;
            // 
            // lblUsuarioActivoNombre
            // 
            this.lblUsuarioActivoNombre.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblUsuarioActivoNombre.Name = "lblUsuarioActivoNombre";
            this.lblUsuarioActivoNombre.Size = new System.Drawing.Size(105, 19);
            this.lblUsuarioActivoNombre.Text = "Apellido, Nombre";
            // 
            // lblUsuarioActivoId
            // 
            this.lblUsuarioActivoId.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblUsuarioActivoId.Name = "lblUsuarioActivoId";
            this.lblUsuarioActivoId.Size = new System.Drawing.Size(48, 19);
            this.lblUsuarioActivoId.Text = "ID: xxxx";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 455);
            this.Controls.Add(this.stsBarraEstado);
            this.Controls.Add(this.panAdmGral);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zahir Academia";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panAdmGral.ResumeLayout(false);
            this.panAdmGral.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.stsBarraEstado.ResumeLayout(false);
            this.stsBarraEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panAdmGral;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmComisiones;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarComision;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarComisiones;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarComisiones;
        private System.Windows.Forms.ToolStripMenuItem tsmListadoDeComisiones;
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
        private System.Windows.Forms.ToolStripMenuItem tsmMaterias;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarMateria;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarMateria;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarMateria;
        private System.Windows.Forms.ToolStripMenuItem tsmListadoDeMaterias;
        private System.Windows.Forms.Panel panAdmOtro;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAdministrativo;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarAdministrativo;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarAdministrativo;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarAdministrativoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmListadoDeAdministrativo;
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
        private System.Windows.Forms.StatusStrip stsBarraEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioActivoNombre;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioActivoId;
        private System.Windows.Forms.ToolStripStatusLabel lblRelleno;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
    
        public System.Windows.Forms.PaintEventHandler panel1_Paint { get; set; }
    }      
}