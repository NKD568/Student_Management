using Student_Management.FORMS;
using Student_Management.FORMS.Account;
using Student_Management.FORMS.Course;
using Student_Management.FORMS.Grade;
using Student_Management.FORMS.Main;
using Student_Management.FORMS.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
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
            Application.Run(new splashScreen());
        }
    }
}
