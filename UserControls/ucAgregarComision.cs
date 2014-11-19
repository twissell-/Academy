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
            Ninguno,
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
            dgvAsignado.TrueValue = true;
            dgvAsignado.FalseValue = false;
            foreach (var item in Enum.GetValues(typeof(eCargo)).Cast<eCargo>())
            {
                dgvCargo.Items.Add(item);
            } 
            dgvListaDocentes.AutoGenerateColumns = false;
            dgvListaDocentes.DataSource = cd.find();
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.txtHsSemanales.Clear();
            this.txtHsTotales.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<Docente> docentes =  new List<Docente>();
            foreach (DataGridViewRow row in this.dgvListaDocentes.Rows)
	        {
		        if ((bool)row.Cells[3].Value)
	            {
                    docentes.Add((Docente)row.DataBoundItem);
	            }
	        }
            // TODO: Seguir Aca <---------------------------------------------
           // Comision c = new Comision(Convert.ToInt32(txtAñoCursado.Text), Convert.ToDecimal(txtHsSemanales.Text), 
           //     Convert.ToDecimal(txtHsTotales.Text), cmbMateria.SelectedItem, 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvListaDocentes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
