using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FYP_Project.Forms;

namespace FYP_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            NetworkChecker.PingNetwork("pingtest.com");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                var lf = new MainForm();
                if (lf.LoginSuccessful())
                {
                    Application.Run(lf);
                }
                else
                {
                    Application.Exit();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occured, application will close:\n" + e.Message);
                Environment.Exit(0);
            }
        }
    }
}
