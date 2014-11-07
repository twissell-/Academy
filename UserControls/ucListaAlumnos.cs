using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserControls
{
    public partial class ucListaAlumnos : UserControl
    {
        public ucListaAlumnos()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows != null && this.dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)this.dataGridView1.SelectedRows[0].Cells[0].Value;
                string nom = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string ape = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                if (MessageBox.Show("¿Está seguro que desea eliminar a " + nom + " " + ape + "?",
                    "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //llamar a eliminar
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para eliminarla", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
