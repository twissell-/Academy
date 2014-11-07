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
        public ucAgregarComision()
        {
            InitializeComponent();
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
            
            int turno;
            if (cmbTurno.Text=="Mañana")
            { turno = 1;}
            else if (cmbTurno.Text=="Tarde")
	                {turno=2;} 
                    else{ turno=3;}
            
	        
            //Comision com = new Comision(txtId, txtAñoCursado,txtHsSemanales,txtHsTotales, cmbMateria,,,turno);
            //ControllerComision controllerCom = new ControllerComision(); 
            //controllerCom.insert(com);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
