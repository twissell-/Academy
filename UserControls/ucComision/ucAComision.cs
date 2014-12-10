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
    public partial class ucAComision : UserControl
    {
        private ControllerMateria cm;
        private ControllerDocente cd;
        private ControllerComision cc;
        private ControllerCargos ccar;
        private List<Alumno> al;
        public ucListaComisiones Owner { get; set; }


#region Enumeraciones

        enum eTurno
        {
            Mañana,
            Tarde,
            Noche
        }

#endregion

        public ucAComision()
        {
            InitializeComponent();
        }

        #region Metodos Propios

        private void loader()
        {
            this.cm = new ControllerMateria();
            this.cd = new ControllerDocente();
            this.cc = new ControllerComision();
            this.ccar = new ControllerCargos();
            this.al = new List<Alumno>();
            cmbMateria.ValueMember = "id";
            cmbMateria.DisplayMember = "descripcion";
            cmbMateria.DataSource = cm.find();
            cmbTurno.DataSource = Enum.GetValues(typeof(eTurno)).Cast<eTurno>();
            dgvListaDocentes.AutoGenerateColumns = false;
            dgvListaDocentes.DataSource = cd.find();
            this.btnBorrar.Enabled = this.btnBorrar.Visible = false;
        }

        private void clear()
        {
            this.txtId.Clear();
            this.txtAñoCursado.Clear();
            this.cmbTurno.SelectedIndex = 0;
            cmbMateria.DataSource = cm.find();
            dgvListaDocentes.DataSource = cd.find();
            if (this.Owner != null)
            {
                this.Owner.reload();
                this.Enabled = false;
            }

        }

        private Comision buildComision()
        {
            List<Docente> docentes = new List<Docente>();
            foreach (DataGridViewRow row in this.dgvListaDocentes.Rows)
            {
                if (Convert.ToBoolean(row.Cells["dgvTitular"].Value) || Convert.ToBoolean(row.Cells["dgvAdjunto"].Value) ||
                    Convert.ToBoolean(row.Cells["dgvJTP"].Value) || Convert.ToBoolean(row.Cells["dgvAuxiliar"].Value))
                {
                    if (Convert.ToBoolean(row.Cells["dgvTitular"].Value))
                    {
                        Docente d = (Docente)row.DataBoundItem;
                        d.cargo = 1;
                        docentes.Add(d);
                    }
                    else if (Convert.ToBoolean(row.Cells["dgvAdjunto"].Value))
                    {
                        Docente d = (Docente)row.DataBoundItem;
                        d.cargo = 2;
                        docentes.Add(d);
                    }
                    else if (Convert.ToBoolean(row.Cells["dgvJTP"].Value))
                    {
                        Docente d = (Docente)row.DataBoundItem;
                        d.cargo = 3;
                        docentes.Add(d);
                    }
                    else if (Convert.ToBoolean(row.Cells["dgvAuxiliar"].Value))
                    {
                        Docente d = (Docente)row.DataBoundItem;
                        d.cargo = 4;
                        docentes.Add(d);
                    }
                }
            }
            return new Comision(txtId.Text == "" ? 0 : Convert.ToInt32(txtId.Text), Convert.ToInt32(txtAñoCursado.Text), (Materia)cmbMateria.SelectedItem, docentes, al, (int)cmbTurno.SelectedValue);
        }

        public void edit(Comision c)
        {
            txtId.Text = c.id.ToString();
            txtAñoCursado.Text = c.anioCursado.ToString();
            cmbMateria.SelectedValue = c.materia.id;
            if (c.alumnos != null)
            {
                al = c.alumnos;
            }
            List<Persona> docentes = cd.find();
            foreach (Docente d in c.docentes)
            {
                var mr = docentes.Find(x => x.id == (d.id));
                docentes.Remove(mr);
            }
            docentes.AddRange(c.docentes);
            docentes.Reverse();
            dgvListaDocentes.DataSource = docentes;
            foreach (DataGridViewRow row in this.dgvListaDocentes.Rows)
            {
                Docente d = (Docente)row.DataBoundItem;
                switch (d.cargo)
                {
                    case 1:
                        row.Cells["dgvTitular"].Value = true;
                        break;
                    case 2:
                        row.Cells["dgvAdjunto"].Value = true;
                        break;
                    case 3:
                        row.Cells["dgvJTP"].Value = true;
                        break;
                    case 4:
                        row.Cells["dgvAuxiliar"].Value = true;
                        break;
                    default:
                        break;
                }
            }
            if (!this.Enabled)
            {
                this.Enabled = true;
                this.btnBorrar.Enabled = this.btnBorrar.Visible = true;
            }
        }

        #endregion

        private void ucAgregarComision_Load(object sender, EventArgs e)
        {
            this.loader();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            cc.delete(this.buildComision());
            this.clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cc.insert(this.buildComision());
            this.clear();
            this.loader();
        }

        private void dgvListaDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5)
            {
                switch (e.ColumnIndex)  
            	{
                    case 2:
                        dgvListaDocentes.Rows[e.RowIndex].Cells[2].Value = true;
                        dgvListaDocentes.Rows[e.RowIndex].Cells[3].Value = false;
                        dgvListaDocentes.Rows[e.RowIndex].Cells[4].Value = false;
                        dgvListaDocentes.Rows[e.RowIndex].Cells[5].Value = false;
                        break;
                    case 3:
                        dgvListaDocentes.Rows[e.RowIndex].Cells[2].Value = false;
                        dgvListaDocentes.Rows[e.RowIndex].Cells[3].Value = true;
                        dgvListaDocentes.Rows[e.RowIndex].Cells[4].Value = false;
                        dgvListaDocentes.Rows[e.RowIndex].Cells[5].Value = false;
                        break;
                    case 4:
                        dgvListaDocentes.Rows[e.RowIndex].Cells[2].Value = false;
                        dgvListaDocentes.Rows[e.RowIndex].Cells[3].Value = false;
                        dgvListaDocentes.Rows[e.RowIndex].Cells[4].Value = true;
                        dgvListaDocentes.Rows[e.RowIndex].Cells[5].Value = false;
                        break;
                    case 5:
                        dgvListaDocentes.Rows[e.RowIndex].Cells[2].Value = false;
                        dgvListaDocentes.Rows[e.RowIndex].Cells[3].Value = false;
                        dgvListaDocentes.Rows[e.RowIndex].Cells[4].Value = false;
                        dgvListaDocentes.Rows[e.RowIndex].Cells[5].Value = true;
                        break;
            		default:
                        break;
            	}
            }
        }
    }
}
