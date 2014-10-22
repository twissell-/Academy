using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmPlanes : Form
    {
        public FrmPlanes()
        {
            InitializeComponent();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            Form mate = new FrmAbmMateria();
            mate.ShowDialog();
        }
    }
}
