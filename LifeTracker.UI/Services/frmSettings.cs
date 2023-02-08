using LifeTracker.Core.BLL;
using LifeTracker.Core.Interfaces;
using LifeTracker.Services.IAM;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LifeTracker.UI.Services
{
    public partial class frmSettings : Form {

        private SettingsBLL _settingsBLL;
        private IUser _user;

        public frmSettings() {
            InitializeComponent();
            _settingsBLL = new SettingsBLL();

            Initialize();            
        }

        public void Initialize() {
            refresh();
            getUserSettings();
            enableButtons(btnSave, false);
            enableButtons(btnTrash, false);
            enableButtons(btnEdit, true);

            initializeDdlGender();
            initializeDdlIntensity();
            initializeDdlObjective();

            initializeControls(Color.DarkGray);
            enableTextBoxes(false);
        }

        private void getUserSettings() {
            txtAge.Text = UserSessionSingleton.Instance.User.Age.ToString();
            ddlGender.SelectedText = UserSessionSingleton.Instance.User.Gender.ToString();
            txtWeight.Text = UserSessionSingleton.Instance.User.Weight.ToString();
            txtHeight.Text = UserSessionSingleton.Instance.User.Height.ToString();
            txtAllergies.Text = (UserSessionSingleton.Instance.User.Allergic == true ? "No" : "Si");
            ddlIntensity.SelectedText = UserSessionSingleton.Instance.User.Intensity.ToString();
            txtAvailability.Text = UserSessionSingleton.Instance.User.Availability_In_Hours.ToString();
            ddlObjectives.Text = UserSessionSingleton.Instance.User.Objective.ToString();

            initializeControls(Color.Black);
        }

        private void refresh() {
            _user = _settingsBLL.Refresh(UserSessionSingleton.Instance.User);
            UserSessionSingleton.Instance.User.Age = _user.Age;
            UserSessionSingleton.Instance.User.Gender = _user.Gender;
            UserSessionSingleton.Instance.User.Weight = _user.Weight;
            UserSessionSingleton.Instance.User.Height = _user.Height;
            UserSessionSingleton.Instance.User.Allergic = _user.Allergic;
            UserSessionSingleton.Instance.User.Intensity = _user.Intensity;
            UserSessionSingleton.Instance.User.Availability_In_Hours = _user.Availability_In_Hours;
            UserSessionSingleton.Instance.User.Objective = _user.Objective;
        }

        private void enableButtons(Bunifu.UI.WinForms.BunifuImageButton button, bool enable) {
            button.Enabled = enable;
        }

        private void enableTextBoxes(bool enable) {
            txtAge.Enabled = enable;
            ddlGender.Enabled = enable;
            txtWeight.Enabled = enable;
            txtHeight.Enabled = enable;
            txtAllergies.Enabled = enable;
            ddlIntensity.Enabled = enable;
            txtAvailability.Enabled = enable;
            ddlObjectives.Enabled = enable;
        }

        private void initializeDdlGender() {
            var _gender = UserSessionSingleton.Instance.Gender;
            ddlGender.DataSource = _gender;
            ddlGender.DisplayMember = "Gender";
            ddlGender.ForeColor = Color.Black;
        }

        private void initializeDdlIntensity() {
            var _intensity = UserSessionSingleton.Instance.Intensity;
            ddlIntensity.DataSource = _intensity;
            ddlIntensity.DisplayMember = "Intensity";
            ddlIntensity.ForeColor = Color.Black;
        }

        private void initializeDdlObjective() {
            var _objective = UserSessionSingleton.Instance.Objective;
            ddlObjectives.DataSource = _objective;
            ddlObjectives.DisplayMember = "Objective";
            ddlObjectives.ForeColor = Color.Black;
        }

        private void initializeControls(Color color) {
            txtAge.ForeColor = color;
            ddlGender.ForeColor = color;
            txtWeight.ForeColor = color;
            txtHeight.ForeColor = color;
            txtAllergies.ForeColor = color;
            ddlIntensity.ForeColor = color;
            txtAvailability.ForeColor = color;
            ddlObjectives.ForeColor = color;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            initializeControls(Color.DarkGray);
            enableTextBoxes(false);
            enableButtons(btnSave, false);
            enableButtons(btnTrash, false);
            enableButtons(btnEdit, true);

            _user.Age = Convert.ToInt32(txtAge.Text);
            _user.Gender = (Gender)Enum.Parse(typeof(Gender), ddlGender.Text);
            _user.Weight = Convert.ToDecimal(txtWeight.Text);
            _user.Height = Convert.ToDecimal(txtHeight.Text);
            _user.Allergies = txtAllergies.Text;
            _user.Allergic = (txtAllergies.Text != null ? true : false);
            _user.Intensity = (Intensity)Enum.Parse(typeof(Intensity), ddlIntensity.Text);
            _user.Availability_In_Hours = Convert.ToInt32(txtAvailability.Text);
            _user.Objective = (Objective)Enum.Parse(typeof(Objective), ddlObjectives.Text);

            _settingsBLL.Save(_user);
        }

        private void btnTrash_Click(object sender, EventArgs e) {
            initializeControls(Color.DarkGray);
            enableTextBoxes(false);
            enableButtons(btnSave, false);
            enableButtons(btnTrash, false);
            enableButtons(btnEdit, true);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            enableTextBoxes(true);
            initializeControls(Color.Black);
            enableButtons(btnSave, true);
            enableButtons(btnTrash, true);
            enableButtons(btnEdit, false);
        }
    }
}
