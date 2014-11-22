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
        ControllerComision cc;
        ControllerCargos ccar;


#region Enumeraciones

        enum eTurno
        {
            Mañana,
            Tarde,
            Noche
        }

#endregion

        public ucAgregarComision()
        {
            InitializeComponent();
            this.cm = new ControllerMateria();
            this.cd = new ControllerDocente();
            this.cc = new ControllerComision();
            this.ccar = new ControllerCargos();
            // <-------------------------- ACA
        }

        private void ucAgregarComision_Load(object sender, EventArgs e)
        {
            this.Loader();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<Docente> docentes =  new List<Docente>();
            foreach (DataGridViewRow row in this.dgvListaDocentes.Rows)
	        {
                if (Convert.ToBoolean(row.Cells["dgvTitular"].Value) || Convert.ToBoolean(row.Cells["dgvAdjunto"].Value) ||
                    Convert.ToBoolean(row.Cells["dgvJTP"].Value) || Convert.ToBoolean(row.Cells["dgvAuxiliar"].Value))
                {
                    if (Convert.ToBoolean(row.Cells["dgvTitular"].Value))
                    {
                        Docente d = (Docente)row.DataBoundItem;
                        d.cargo = 0;
                        docentes.Add(d);
                    }
                    else if (Convert.ToBoolean(row.Cells["dgvAdjunto"].Value))
                    {
                        Docente d = (Docente)row.DataBoundItem;
                        d.cargo = 1;
                        docentes.Add(d);
                    }
                    else if (Convert.ToBoolean(row.Cells["dgvJTP"].Value))
                    {
                        Docente d = (Docente)row.DataBoundItem;
                        d.cargo = 2;
                        docentes.Add(d);
                    }
                    else if (Convert.ToBoolean(row.Cells["dgvAuxiliar"].Value))
                    {
                        Docente d = (Docente)row.DataBoundItem;
                        d.cargo = 3;
                        docentes.Add(d);
                    }
                }
	        }
            cc.insert(new Comision(Convert.ToInt32(txtAñoCursado.Text), Convert.ToDecimal(txtHsSemanales.Text), 
                Convert.ToDecimal(txtHsTotales.Text), (Materia)cmbMateria.SelectedItem, docentes, (int)cmbTurno.SelectedValue));
            this.Clear();
            this.Loader();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void Clear()
        {
            this.txtId.Clear();
            this.txtAñoCursado.Clear();
            this.cmbTurno.SelectedIndex = 0;
            this.txtHsSemanales.Clear();
            this.txtHsTotales.Clear();
            this.dgvListaDocentes.Refresh();

        }
        private void Loader()
        {
            cmbMateria.DataSource = cm.find();
            cmbTurno.DataSource = Enum.GetValues(typeof(eTurno)).Cast<eTurno>();
            dgvListaDocentes.AutoGenerateColumns = false;
            dgvListaDocentes.DataSource = cd.find();
            dgvListaDocentes.ReadOnly = false;
            // Esto lo guarod para cuando cargue una comision a ser modificada,
            //foreach (DataGridViewRow row in this.dgvListaDocentes.Rows)
            //{
            //    Docente d = (Docente)row.DataBoundItem;
            //    switch (d.cargo)
            //    {
            //        case 0:
            //            row.Cells["dgvTitular"].Value = true;
            //            break;
            //        case 1:
            //            row.Cells["dgvAdjunto"].Value = true;
            //            break;
            //        case 2:
            //            row.Cells["dgvJTP"].Value = true;
            //            break;
            //        case 3:
            //            row.Cells["dgvAuxiliar"].Value = true;
            //            break;
            //        default:
            //            break;
            //    }
            //}
        }   

        private void dgvListaDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5)
            {
                switch (e.ColumnIndex)  
            	{
                    case 2:
                        dgvListaDocentes.Rows[e.RowIndex].Cells[3].Value = false;
                        dgvListaDocentes.Rows[e.RowIndex].Cells[4].Value = false;
                        dgvListaDocentes.Rows[e.RowIndex].Cells[5].Value = false;
                        break;
                    case 3:
                        dgvListaDocentes.Rows[e.RowIndex].Cells[2].Value = false;
                        dgvListaDocentes.Rows[e.RowIndex].Cells[4].Value = false;
                        dgvListaDocentes.Rows[e.RowIndex].Cells[5].Value = false;
                        break;
                    case 4:
                        dgvListaDocentes.Rows[e.RowIndex].Cells[2].Value = false;
                        dgvListaDocentes.Rows[e.RowIndex].Cells[3].Value = false;
                        dgvListaDocentes.Rows[e.RowIndex].Cells[5].Value = false;
                        break;
                    case 5:
                        dgvListaDocentes.Rows[e.RowIndex].Cells[2].Value = false;
                        dgvListaDocentes.Rows[e.RowIndex].Cells[3].Value = false;
                        dgvListaDocentes.Rows[e.RowIndex].Cells[4].Value = false;
                        break;
            		default:
                        break;
            	}
            }
        }
    }
}
