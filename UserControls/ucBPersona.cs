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
    public partial class ucBPersona : UserControl
    {
        public static int inid;
         public ucBPersona(Form ini)
         {
            //ini.ShowDialog();
            InitializeComponent();       
         }
        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro que desea eliminar a"+txtApellido.Text+","+txtNombre.Text, "Esta por eliminar una persona", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                //llama al metodo para eliminar de la bd
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ucBPersona_Load(object sender, EventArgs e)
        {
           // txtId.Text 
        }
    }
}
