using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new Information());
            //Application.Run(new WorkExperience());
            //Application.Run(new Education());
            //Application.Run(new Department());
            //Application.Run(new RECORDS());
            //Application.Run(new DESIGNATION());
            //Application.Run(new Salary());
            //Application.Run(new Front());
            //Application.Run(new PaySlip());
        }
    }
}
