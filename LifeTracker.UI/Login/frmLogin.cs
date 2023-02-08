using System;
using System.Windows.Forms;
using LifeTracker.Core.BLL;
using LifeTracker.Services.Login;

namespace LifeTracker.UI.Login
{
    public partial class frmLogin : Form {
        private UserBLL user;
        private DietBLL diet;

        public frmLogin() {
            InitializeComponent();
            user = new UserBLL();
            diet = new DietBLL();

            // Initialize with some data
            user.SetDefaultUsers();
            diet.SetDefaultDiets();
        }

        private LoginResult _loginResult;
        public LoginResult LoginResult { get { return _loginResult; } }

        private void btnLogin_Click(object sender, EventArgs e) {            
            try {
                // LogIn
                var result = user.Login(txtUser.Text, txtPassword.Text);
                this._loginResult = result;
                this.Close();
            }
            catch (LoginException error) {
                switch (error.Result) {
                    case LoginResult.InvalidUser:
                        MessageBox.Show("Invalid User");
                        break;
                    case LoginResult.InvalidPassword:
                        MessageBox.Show("Invalid Password");
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
