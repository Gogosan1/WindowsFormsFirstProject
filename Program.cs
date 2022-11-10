using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaSixThirdSemester
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (MessageBox.Show("Создать компанию.", "Start", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var company = new Company();
                Application.Run(new MainForm(company));
            }
            
        }
    }
}
