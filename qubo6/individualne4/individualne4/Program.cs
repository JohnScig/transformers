using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace individualne4
{
    // Formuláre bez popiskov.
    // Chýba vymazávanie vecí.
    // Program padá pri otvorení a zatvorení formulára zamestnancov.
    // Program padá pri aktualizácii zamestnanca.
    // Nesedí názov triedy a súboru (napr. frmOrganizationStructure = frmSectionManager.cs).
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
            Application.Run(new frmOrganizationStructure());
        }
    }
}
