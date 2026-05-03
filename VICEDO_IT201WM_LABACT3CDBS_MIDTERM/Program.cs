using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VICEDO_IT201WM_LABACT3CDBS_MIDTERM
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
            using (var login = new LoginForm())
            {
                login.ShowDialog();
                if (!login.LoggedIn) return;
            }
            Application.Run(new AppShell());
        }
    }
}
