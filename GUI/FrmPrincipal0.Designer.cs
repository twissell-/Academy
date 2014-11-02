namespace GUI
{
    partial class FrmPrincipal0
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
            this.gpbIngresar = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.gpbIngresar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbIngresar
            // 
            this.gpbIngresar.Controls.Add(this.btnSalir);
            this.gpbIngresar.Controls.Add(this.btnIngresar);
            this.gpbIngresar.Controls.Add(this.txtContraseña);
            this.gpbIngresar.Controls.Add(this.txtId);
            this.gpbIngresar.Controls.Add(this.lblContraseña);
            this.gpbIngresar.Controls.Add(this.lblId);
            this.gpbIngresar.Location = new System.Drawing.Point(85, 50);
            this.gpbIngresar.Name = "gpbIngresar";
            this.gpbIngresar.Size = new System.Drawing.Size(430, 195);
            this.gpbIngresar.TabIndex = 0;
            this.gpbIngresar.TabStop = false;
            this.gpbIngresar.Text = "Ingresar";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(250, 132);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 29);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(76, 132);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(84, 29);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(171, 84);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(163, 20);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Intro);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(171, 40);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(163, 20);
            this.txtId.TabIndex = 2;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(64, 87);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(96, 20);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(133, 40);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // FrmPrincipal0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 306);
            this.Controls.Add(this.gpbIngresar);
            this.Name = "FrmPrincipal0";
            this.Text = "Zahir Academia";
           // this.Load += new System.EventHandler(this.FrmPrincipal0_Load);
            this.gpbIngresar.ResumeLayout(false);
            this.gpbIngresar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbIngresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblId;
    }
}