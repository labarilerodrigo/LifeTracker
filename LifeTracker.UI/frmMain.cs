using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuButton;
using LifeTracker.Core.BE;
using LifeTracker.Core.BLL;
using LifeTracker.Services.IAM;
using LifeTracker.Services.IAM.Composite2;
using LifeTracker.UI.Services;

namespace LifeTracker.UI
{
    public partial class frmMain : Form
    {
        private UserBLL _userBLL;
        private DietBLL _dietBLL;
        private List<Form> _forms;
        private CaloriesBLL _caloriesBLL;
        private Meals _meals;

        public frmMain() {
            InitializeComponent();
            _userBLL = new UserBLL();
            _dietBLL = new DietBLL();
            _caloriesBLL = new CaloriesBLL();
            _forms = new List<Form>();
            _meals = new Meals();
        }

        public void Initialize() {
            // disabling language controls for now
            ddlLanguage.Visible = false;
            picLanguage.Visible = false;

            // labels
            lblUserName.Text = UserSessionSingleton.Instance.User.Email;

            // user profile
            initializeCtrlProfilePos();

            // top bar controls
            initializeTopBarPos();

            // set up security on UI based on User's roles
            initializeMenu();

            // bring home up
            frmHomeUp();

            // set indicators
            _meals = (Meals)_dietBLL.GetAll().FirstOrDefault();
            SetCalories((User)UserSessionSingleton.Instance.User, _meals);
            SetDiet((User)UserSessionSingleton.Instance.User);
            SetObjective((User)UserSessionSingleton.Instance.User);
        }

        #region Menu
        private void initializeMenu() {
            var permissions = _userBLL.GetPermissions((User)UserSessionSingleton.Instance.User);
            List<BunifuButton> listOfServices = new List<BunifuButton>();


            btnHome.Visible = true;
            btnHome.Enabled = true;
            btnActivity.Visible = false;
            btnActivity.Enabled = false;
            btnChallenges.Visible = false;
            btnChallenges.Enabled = false;
            btnServicesManagement.Visible = false;
            btnServicesManagement.Enabled = false;
            btnProfessional.Visible = false;
            btnProfessional.Enabled = false;
            btnBackup.Visible = false;
            btnBackup.Enabled = false;
            btnSettings.Visible = false;
            btnSettings.Enabled = false;

            foreach (var permission in permissions) {
                switch (permission.Name) {
                    case "Home":
                        btnHome.Visible = true;
                        btnHome.Enabled = true;
                        listOfServices.Add(btnHome);
                        break;
                    case "Activity":
                        btnActivity.Visible = true;
                        btnActivity.Enabled = true;
                        listOfServices.Add(btnActivity);
                        break;
                    case "Challenge":
                        btnChallenges.Visible = true;
                        btnChallenges.Enabled = true;
                        listOfServices.Add(btnChallenges);
                        break;
                    case "IAM":
                        btnServicesManagement.Visible = true;
                        btnServicesManagement.Enabled = true;
                        listOfServices.Add(btnServicesManagement);
                        break;
                    case "Professional":
                        btnProfessional.Visible = true;
                        btnProfessional.Enabled = true;
                        listOfServices.Add(btnProfessional);
                        break;
                    case "Backup":
                        btnBackup.Visible = true;
                        btnBackup.Enabled = true;
                        listOfServices.Add(btnBackup);
                        break;
                    case "Settings":
                        btnSettings.Visible = true;
                        btnSettings.Enabled = true;
                        listOfServices.Add(btnSettings);
                        break;
                    default:
                        btnHome.Visible = true;
                        btnHome.Enabled = true;
                        btnActivity.Visible = false;
                        btnActivity.Enabled = false;
                        btnChallenges.Visible = false;
                        btnChallenges.Enabled = false;
                        btnServicesManagement.Visible = false;
                        btnServicesManagement.Enabled = false;
                        btnProfessional.Visible = false;
                        btnProfessional.Enabled = false;
                        btnBackup.Visible = false;
                        btnBackup.Enabled = false;
                        btnSettings.Visible = false;
                        btnSettings.Enabled = false;
                        listOfServices.Add(btnHome);
                        break;
                }
            }

            // reorder control buttons from menu
            reorderMenu(listOfServices);
        }

        private void reorderMenu(List<BunifuButton> Buttons) {
            var topLocation = btnHome.Location;
                        
            foreach(var button in Buttons) {
                if (button.Name != "btnHome") {
                    button.Location = new Point(topLocation.X, topLocation.Y + 60);
                    topLocation = button.Location;
                }
            }
        }
        #endregion

        #region Profile & Top Menu
        private void initializeCtrlProfilePos() {
            picProfile.Location = new Point((splitContainerMenuLeft.Panel1.Width - picProfile.Width) / 2,
                          (splitContainerMenuLeft.Panel1.Height - picProfile.Height) / 2);

            var customLblUserNameHeight = splitContainerMenuLeft.Panel1.Height + 100;
            lblUserName.Location = new Point((splitContainerMenuLeft.Panel1.Width - lblUserName.Width) / 2,
                          (customLblUserNameHeight - lblUserName.Height) / 2);

            btnLogOut.Enabled = true;
        }

        private void initializeTopBarPos() {
            lblTitle.Location = new Point((panelTopBar.Width - lblTitle.Width) / 2,
                          (panelTopBar.Height - lblTitle.Height) / 2);

            ddlLanguage.Enabled = false;
            ddlLanguage.Enabled = false;
        }
        #endregion

        #region Form Events
        private void btnServicesManagement_Click(object sender, System.EventArgs e) {
            closeAllForms();
             var frm = new frmUserManagement();
            frm.TopLevel = false;
            splitContainerMain.Panel2.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            _forms.Add(frm);
        }

        private void btnBackup_Click(object sender, System.EventArgs e) {
            closeAllForms();

            var frm = new frmBackup();
            frm.TopLevel = false;
            splitContainerMain.Panel2.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            _forms.Add(frm);
        }

        private void btnProfessional_Click(object sender, System.EventArgs e) {
            closeAllForms();

            switch (UserSessionSingleton.Instance.User.Professional) {
                case true:
                    loadProfessionalMode();
                    break;
                case false:
                    loadClientMode();
                    break;
                default:
                    loadClientMode();
                    break;
            }
        }

        private void btnHome_Click(object sender, System.EventArgs e) {
            frmHomeUp();
        }

        private void frmHomeUp() {
            closeAllForms();

            var frm = new frmHome();
            frm.TopLevel = false;
            splitContainerMain.Panel2.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            _forms.Add(frm);
        }

        private void btnSettings_Click(object sender, System.EventArgs e) {
            closeAllForms();

            var frm = new frmSettings();
            frm.TopLevel = false;
            splitContainerMain.Panel2.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            _forms.Add(frm);
        }

        private void btnLogOut_Click(object sender, EventArgs e) {
            closeAllForms();

            UserSessionSingleton.Instance.Logout();
            UserSessionSingleton.Instance.IsLoggingOut = true;
            this.Close();
            this.Dispose();
        }

        private void picNotifications_Click(object sender, EventArgs e) {
            closeAllForms();

            var frm = new frmNotifications();
            frm.TopLevel = false;
            splitContainerMain.Panel2.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            _forms.Add(frm);
        }

        #endregion

        #region Other Methods
        private void closeAllForms() {
            _forms.ForEach(x => x.Close());
        }

        private void loadProfessionalMode() {
            var frm = new frmMessageProfessional();
            frm.TopLevel = false;
            splitContainerMain.Panel2.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            _forms.Add(frm);
        }

        private void loadClientMode() {
            var frm = new frmProfessional();
            frm.TopLevel = false;
            splitContainerMain.Panel2.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            _forms.Add(frm);
        }

        #endregion

        #region Calories
        public void SetCalories(User user, Meals meals) {
            /*
              -obtiene el máximo de calorías a consumir en un día predefinido por el cliente
              -obtiene todas las dietas del cliente
            */
            user.MaxCalories = _userBLL.GetMaxCalories(user); // get max calories of user
            _caloriesBLL.User = user; // set user preferences to caloriesBBL
            _caloriesBLL.Meals = meals; // set meals to caloriesBBL

            var calories = _caloriesBLL.CalculateCalories();
            var caloriesDec = decimal.Round((calories == null ? 0 : Convert.ToDecimal(calories)), 0);
            var caloriesLeft = user.MaxCalories - caloriesDec;

            // set calories
            lblCalories.Text = string.Format("{0} kcal", caloriesDec.ToString());
            lblCaloriesLeft.Text = string.Format("Faltan {0} kcal", caloriesLeft.ToString());
        }
        #endregion

        #region Diet
        public void SetDiet(User user) {
            /*
                -obtiene la dieta predefinida para el cliente del día en cuestión.
                -obtiene las comidas ejecutadas del día de dicha dieta.
            */
            var _meals = _dietBLL.GetAll().Where(x => x.TimeStamp.ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy")).ToList();
            var diet_pct = _dietBLL.CalculateNutritionalDiet(user, _meals);

            // set diet
            lblDiet.Text = string.Format("{0}%", diet_pct.ToString());
        }
        #endregion

        #region Objective
        public void SetObjective(User user) {
            /*
                -obtiene el objetivo predefinido para el cliente. 
            */
            var userObjective = _userBLL.GetUserObjective(user);
            var _meals = _dietBLL.GetAll().Where(x => x.TimeStamp.ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy")).ToList();
            var objective_pct = _dietBLL.CalculateObjective(user);

            string lblObjectiveText = null;
            switch (user.Objective) {
                case Core.Interfaces.Objective.None:
                    lblObjectiveText = "No tiene objetivos disponibles";
                    break;
                case Core.Interfaces.Objective.Increase_Weight:
                    lblObjectiveText = "Subir de peso";
                    break;
                case Core.Interfaces.Objective.Decrease_Weight:
                    lblObjectiveText = "Bajar de peso";
                    break;
                case Core.Interfaces.Objective.Keep_Same_Weight:
                    lblObjectiveText = "Mantener peso";
                    break;
                case Core.Interfaces.Objective.Load_Meals:
                    lblObjectiveText = "Cargar comidas del día";
                    break;
                default:
                    break;
            }
            lblObjective.Text = lblObjectiveText;
            lblObjectivePer.Text = string.Format("{0}%", objective_pct.ToString());
        }
        #endregion

    }
}
