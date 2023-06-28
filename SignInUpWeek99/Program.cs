using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignInUpWeek99.DL;
using SignInUpWeek99.BL;
using System.Windows.Forms;

namespace SignInUpWeek99
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
             int adminKey = 555;  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignInSignUpApplication());
        }
    }
}
