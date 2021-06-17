using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Project
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StartForm first = new StartForm();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(5);
            first.Show();
            while(end > DateTime.Now)
            {
                Application.DoEvents();
            }
            first.Close();
            first.Dispose();
            Application.Run(new MainForm());
        }

    }


}
