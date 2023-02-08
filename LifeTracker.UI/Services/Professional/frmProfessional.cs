using LifeTracker.Core.BLL;
using LifeTracker.Services.IAM;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LifeTracker.UI.Services
{
    public partial class frmProfessional : Form {

        private bool _nutritionist;
        private ProfessionalBLL _professionalBLL;

        public frmProfessional() {
            InitializeComponent();
            _professionalBLL = new ProfessionalBLL();
            Initialize();
        }

        public void Initialize() {
            enableProfessionalConsultant(false);
            enableProfessionalButtons(true);
            clearTextControls();
        }

        #region Form Controls & Events
        private void btnNutrition_Click(object sender, System.EventArgs e) {
            enableProfessionalButtons(false);
            enableProfessionalConsultant(true);
            initializeDdlSubjectNut();
            _nutritionist = true;
        }

        private void btnPersonalTrainer_Click(object sender, System.EventArgs e) {
            enableProfessionalButtons(false);
            enableProfessionalConsultant(true);
            initializeDdlSubjectPer();
            _nutritionist = false;
        }

        private void enableProfessionalConsultant(bool enable) {
            txtNutMsg.Enabled = enable;
            ddlSubject.Enabled = enable;
            btnButSend.Enabled = enable;
            btnNutTrash.Enabled = enable;
        }

        private void enableProfessionalButtons(bool enable) {
            btnNutrition.Enabled = enable;
            btnPersonalTrainer.Enabled = enable;
        }

        private void clearTextControls() {
            txtNutMsg.Text = string.Empty;
            ddlSubject.Text = "Elija la opción deseada";
        }

        private void btnNutTrash_Click(object sender, System.EventArgs e) {
            Initialize();
        }

        private void btnButSend_Click(object sender, System.EventArgs e) {
            switch (_nutritionist) {
                case true:
                    sendMsg2Nutritionist();
                    msgSentNotification();
                    Initialize();
                    break;
                case false:
                    sendMsg2PersonalTrainer();
                    msgSentNotification();
                    Initialize();
                    break;
                default:
                    Initialize();
                    break;
            }
        }

        private void sendMsg2Nutritionist() {
            LifeTracker.Core.BE.Message message = new Core.BE.Message() {
                ProfessionalType = Core.Interfaces.ProfessionalType.Nutricionista,
                Subject = (LifeTracker.Core.Interfaces.SubjectType)Enum.Parse(typeof(LifeTracker.Core.Interfaces.SubjectType), ddlSubject.SelectedItem.ToString()),
                MessageText = txtNutMsg.Text,
                MessageResponseText = string.Empty,
                WasItAnswered = false,
                UserEmail = UserSessionSingleton.Instance.User.Email
            };
            _professionalBLL.Save(message);
        }

        private void sendMsg2PersonalTrainer() {
            LifeTracker.Core.BE.Message message = new Core.BE.Message() {
                ProfessionalType = Core.Interfaces.ProfessionalType.PersonalTrainer,
                Subject = (LifeTracker.Core.Interfaces.SubjectType)Enum.Parse(typeof(LifeTracker.Core.Interfaces.SubjectType), ddlSubject.SelectedItem.ToString()),
                MessageText = txtNutMsg.Text,
                MessageResponseText = string.Empty,
                WasItAnswered = false,
                UserEmail = UserSessionSingleton.Instance.User.Email
            };
            _professionalBLL.Save(message);
        }

        private void initializeDdlSubjectNut() {
            LifeTracker.Core.BE.Message msg = new Core.BE.Message();
            ddlSubject.DataSource = msg.Subjects.Where(x => x.ToString() != "Rutina").ToList();
            ddlSubject.DisplayMember = "Subject";
            ddlSubject.ForeColor = Color.Black;
        }

        private void initializeDdlSubjectPer() {
            LifeTracker.Core.BE.Message msg = new Core.BE.Message();
            ddlSubject.DataSource = msg.Subjects.Where(x => x.ToString() != "Dieta").ToList();
            ddlSubject.DisplayMember = "Subject";
            ddlSubject.ForeColor = Color.Black;
        }

        private void msgSentNotification() {
            MessageBox.Show(
                "Los profesionales evaluarán su consulta y será respondida a la brevedad.",
                "Mensaje Enviado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        #endregion
    }
}
