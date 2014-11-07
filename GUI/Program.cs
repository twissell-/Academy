using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmPRUEBA());
            Application.Run(new FrmPrincipal0());
            //Application.Run(new FrmComisiones());
           // Application.Run(new FrmAbmAlumno());
            //Application.Run(new FrmPrincipal());
        }
    }
}
