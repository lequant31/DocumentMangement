using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace DemoAccess
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
            BonusSkins.Register();
            #region login
            var _login = new Login();
            _login.ShowDialog();
            if (_login.DialogResult != DialogResult.OK)
            {
                return;
            }
            #endregion
            Application.Run(new Form1());
        }
    }
}
