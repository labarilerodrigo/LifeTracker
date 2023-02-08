using LifeTracker.Core.BLL;
using LifeTracker.Core.Interfaces;
using LifeTracker.Services.IAM;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LifeTracker.UI.Services
{
    public partial class frmMessageProfessional : Form {

        private DataTable _dtMessages;
        private LifeTracker.Core.BLL.ProfessionalBLL _professionalBLL;
        private Core.BE.Message _message;

        public frmMessageProfessional() {
            InitializeComponent();

            _dtMessages = new DataTable();
            _professionalBLL = new ProfessionalBLL();
            _message = new Core.BE.Message();

            Initialize();
        }

        public void Initialize() {
            initializeDgvMessages();
            populateWithMessages();
            initializeControls();
            initializeDdlSubject();
        }

        #region [ Data Grid View - Messages ]
        private void initializeDgvMessages() {
            DataColumn[] tableColumns = new DataColumn[] {
                new DataColumn() { ColumnName = "ID", DataType = typeof(string) },
                new DataColumn() { ColumnName = "Tipo", DataType = typeof(string) },
                new DataColumn() { ColumnName = "Email", DataType = typeof(string) },
                new DataColumn() { ColumnName = "Asunto", DataType = typeof(string) },
                new DataColumn() { ColumnName = "Mensaje", DataType = typeof(string) },
                new DataColumn() { ColumnName = "Fecha", DataType = typeof(string) }
            };
            _dtMessages.Columns.AddRange(tableColumns);
            dgvMessages.DataSource = _dtMessages;
            dgvMessages.Columns[0].Visible = false;    // hide id column
        }

        private void populateWithMessages() {
            _dtMessages.Rows.Clear();
            var messages = _professionalBLL.GetAllUnreadMessages();

            foreach (var message in messages) {
                DataRow newRow = _dtMessages.NewRow();
                _dtMessages.Rows.Add(
                    message.MessageId, 
                    message.ProfessionalType,
                    message.UserEmail,
                    message.Subject.ToString(), 
                    message.MessageText, 
                    message.Date.ToString("MM/dd/yyyy hh:mm tt"));
            }
            dgvMessages.Refresh();
        }
        #endregion

        #region Controls
        private void refreshControls() {
            populateWithMessages();
            initializeControls();
        }

        private void initializeControls() {
            btnAllMessages.Enabled = true;
            btnAllMessages.Visible = true;
            turningOnMessageMode(false);
            turningOnAllMessagesMode(true);
        }

        private void turningOnMessageMode(bool turnOn) {
            // turning off message mode
            lblSubject.Enabled = turnOn;
            lblSubject.Visible = turnOn;
            ddlSubject.Enabled = turnOn;
            ddlSubject.Visible = turnOn;
            lblReceivedMsg.Enabled = turnOn;
            lblReceivedMsg.Visible = turnOn;
            txtReceivedMsg.Enabled = turnOn;
            txtReceivedMsg.Visible = turnOn;            
            lblResponseMsg.Enabled = turnOn;
            lblResponseMsg.Visible = turnOn;
            txtResponseMsg.Enabled = turnOn;
            txtResponseMsg.Visible = turnOn;            
            btnTrash.Enabled = turnOn;
            btnTrash.Visible = turnOn;
            btnSend.Enabled = turnOn;
            btnSend.Visible = turnOn;
        }

        private void turningOnAllMessagesMode(bool turnOn) {
            dgvMessages.Enabled = turnOn;
            dgvMessages.Visible = turnOn;
        }

        private void initializeDdlSubject() {
            LifeTracker.Core.BE.Message msg = new Core.BE.Message();
            ddlSubject.DataSource = msg.Subjects;
            ddlSubject.DisplayMember = "Subject";
            ddlSubject.ForeColor = Color.Black;
        }
        #endregion

        #region Form Events
        private void dgvMessages_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvMessages.SelectedRows[0].Selected) {
                turningOnMessageMode(true);
                turningOnAllMessagesMode(false);

                // mapOne
                var _messageId = (string)dgvMessages.SelectedRows[0].Cells[0].Value.ToString();
                var _professionalType = (string)dgvMessages.SelectedRows[0].Cells[1].Value.ToString();
                var _userEmail = (string)dgvMessages.SelectedRows[0].Cells[2].Value.ToString();
                var _subject = (string)dgvMessages.SelectedRows[0].Cells[3].Value.ToString();
                var _messageText = (string)dgvMessages.SelectedRows[0].Cells[4].Value.ToString();
                
                LifeTracker.Core.BE.Message message = new Core.BE.Message() {
                    MessageId = Guid.Parse(_messageId),
                    ProfessionalType = (LifeTracker.Core.Interfaces.ProfessionalType)Enum.Parse(typeof(LifeTracker.Core.Interfaces.ProfessionalType), _professionalType),
                    Subject = (LifeTracker.Core.Interfaces.SubjectType)Enum.Parse(typeof(LifeTracker.Core.Interfaces.SubjectType), _subject),
                    MessageText = _messageText,
                    MessageResponseText = string.Empty,
                    WasItAnswered = false,
                    UserEmail = _userEmail
                };
                _message = message;

                // init controls
                ddlSubject.SelectedItem = _subject;
                txtReceivedMsg.Text = _messageText;
                ddlSubject.Enabled = false;
                txtReceivedMsg.Enabled = false;
                txtResponseMsg.Enabled = true;
                txtResponseMsg.Visible = true;
                txtResponseMsg.Text = string.Empty;
                txtResponseMsg.Focus();
            }
        }

        private void btnTrash_Click(object sender, EventArgs e) {
            turningOnMessageMode(false);
            turningOnAllMessagesMode(true);
        }

        private void btnAllMessages_Click(object sender, EventArgs e) {
            turningOnMessageMode(false);
            turningOnAllMessagesMode(true);
        }

        private void btnSend_Click(object sender, EventArgs e) {
            if(txtResponseMsg.Text != string.Empty) {
                _message.MessageResponseText = txtResponseMsg.Text;
                _message.WasItAnswered = true;
                _professionalBLL.Save(_message);

                MessageBox.Show(
                "El mensaje ha sido enviado.",
                "Mensaje Respondido",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                // init controls
                refreshControls();
            }
            else {
                MessageBox.Show(
                "Debe ingresar un mensaje de respuesta válido.",
                "Mensaje de Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        #endregion

    }
}
