using System;
using System.Windows.Forms;
using LifeTracker.UI.Login;
using LifeTracker.Services.Login;
using LifeTracker.Services.IAM;

namespace LifeTracker.UI
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
            new LifeTrackerAppContext();
        }


        public class LifeTrackerAppContext : ApplicationContext {
            private frmLogin FrmLogin;

            public LifeTrackerAppContext() {
                do {
                    try {
                        UserSessionSingleton.Instance.IsLoggingOut = false;

                        FrmLogin = new frmLogin();
                        FrmLogin.ShowDialog();
                        if (FrmLogin.LoginResult == LoginResult.ValidUser) {
                            FrmLogin.Close();
                            FrmLogin.Dispose();

                            frmMain FrmMain = new frmMain();
                            FrmMain.Initialize();
                            Application.Run(FrmMain);
                        }
                        else {
                            FrmLogin.Close();
                            FrmLogin.Dispose();
                            UserSessionSingleton.Instance.Logout();
                            UserSessionSingleton.Instance.IsLoggingOut = false;
                        }
                    }
                    catch (Exception ex) {
                        MessageBox.Show(
                            "Application Exception: \n" + ex.Message,
                            "Fatal Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        FrmLogin.Close();
                        FrmLogin.Dispose();
                        UserSessionSingleton.Instance.Logout();
                        UserSessionSingleton.Instance.IsLoggingOut = false;
                    }
                } while (UserSessionSingleton.Instance.IsLoggingOut);
                
            }

        }

    }
}
