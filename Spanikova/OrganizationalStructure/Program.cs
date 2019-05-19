using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationalStructure
{
    // + Všetko v jednom projekte.
    // Po spustení programu som chcel pridať zamestnanca a program padol.
    // Grid (firiem) sa nedá ovládať myšou.
    // Celkovo sa mi to blbo ovláda.
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
            Application.Run(new FrmStructure());
        }
    }
}
