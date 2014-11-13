using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bussines;
using Entidades;

namespace UserControls
{
    public partial class ucAgregarComision : UserControl
    {
        ControllerMateria cm;
        ControllerDocente cd;

#region Enumeraciones

        enum eTurno
        {
            Mañana,
            Tarde,
            Noche
        }

        enum eCargo
        {
            Titular,
            Adjunto,
            JTP,
            Auxiliar,
        }

#endregion

        public ucAgregarComision()
        {
            InitializeComponent();
            this.cm = new ControllerMateria();
            this.cd = new ControllerDocente();
        }

        private void ucAgregarComision_Load(object sender, EventArgs e)
        {
            cmbMateria.DataSource = cm.find();
            cmbTurno.DataSource = Enum.GetValues(typeof(eTurno)).Cast<eTurno>();
            dgvListaDocentes.AutoGenerateColumns = false;
            dgvCargo.DataSource = Enum.GetValues(typeof(eCargo)).Cast<eCargo>();
            dgvListaDocentes.DataSource = cd.find();
            // TODO: Seguir Aca <---------------------------------------------
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.txtHsSemanales.Clear();
            this.txtHsTotales.Clear();
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {   
            UserControl docentes = new ucListaDocentes();
         //   this.Hide();
            docentes.Show();
           
        }
    
        private void btnGuardar_Click(object sender, EventArgs e)
        {
         /*   foreach (DataGridViewRow row in this.dgvListaDocentes.Rows)
	        {
		        
	        }
            Comision c = new Comision(Convert.ToInt32(txtAñoCursado.Text), Convert.ToDecimal(txtHsSemanales.Text), 
                Convert.ToDecimal(txtHsTotales.Text), cmbMateria.SelectedItem, */
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
