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
    public partial class ucMPersona : UserControl
    {
        InterfaceControllers cont;
        
        public ucMPersona(string tipo)
        {
             switch (tipo)
            {
                case "MAd": cont = new ControllerAdministrativo();
                    break;
                case "MA": cont = new ControllerAlumno();
                    break;
                case "MD": cont = new ControllerDocente();
                    break;
                default:
                    break;
            }

          
            InitializeComponent();
           
            this.dgvListaAlumnosMod.AutoGenerateColumns = false;
            this.dgvListaAlumnosMod.DataSource = cont.find();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           
            if (this.dgvListaAlumnosMod.SelectedRows != null && this.dgvListaAlumnosMod.SelectedRows.Count > 0)
            {
                int id = (int)this.dgvListaAlumnosMod.SelectedRows[0].Cells[0].Value;
                string nom = this.dgvListaAlumnosMod.SelectedRows[0].Cells[3].Value.ToString();
                string ape = this.dgvListaAlumnosMod.SelectedRows[0].Cells[2].Value.ToString();
                if (MessageBox.Show("¿Está seguro que desea modificar a " + nom + " " + ape + "?",
                    "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   var al = cont.find(id);
                   al.apellido =this.dgvListaAlumnosMod.SelectedRows[0].Cells[2].Value.ToString();
                 //al.direccion = this.dgvListaAlumnosMod.SelectedRows[0].Cells[2].Value.ToString();
                   al.dni = this.dgvListaAlumnosMod.SelectedRows[0].Cells[1].Value.ToString();
                 //al.enacimiento = DateTime.Parse(this.dgvListaAlumnosMod.SelectedRows[0].Cells[2].Value.ToString());
                   al.mail = this.dgvListaAlumnosMod.SelectedRows[0].Cells[5].Value.ToString();
                   al.nombre = this.dgvListaAlumnosMod.SelectedRows[0].Cells[3].Value.ToString();
                   al.telefono = this.dgvListaAlumnosMod.SelectedRows[0].Cells[4].Value.ToString();
                   cont.update(al);
                }
}
            
            else
            {
                MessageBox.Show("Debe seleccionar una fila para modificarla", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }     
        
    }
}
