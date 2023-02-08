using LifeTracker.Core.BLL;
using LifeTracker.Services.IAM;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LifeTracker.UI.Services
{
    public partial class frmNotifications : Form {

        private DataTable _dtMessages;
        private LifeTracker.Core.BLL.ProfessionalBLL _professionalBLL;
        private Core.BE.Message _message;

        public frmNotifications() {
            InitializeComponent();

            _dtMessages = new DataTable();
            _professionalBLL = new ProfessionalBLL();
            _message = new Core.BE.Message();

            Initialize();
        }

        public void Initialize() {
            initializeDgvMessages();
            populateWithMessages();
        }

        #region [ Data Grid View - Messages ]
        private void initializeDgvMessages() {
            DataColumn[] tableColumns = new DataColumn[] {
                new DataColumn() { ColumnName = "ID", DataType = typeof(string) },
                new DataColumn() { ColumnName = "Mensaje", DataType = typeof(string) },
                new DataColumn() { ColumnName = "Fecha", DataType = typeof(string) }
            };
            _dtMessages.Columns.AddRange(tableColumns);
            dgvMessages.DataSource = _dtMessages;
            dgvMessages.Columns[0].Visible = false;    // hide id column
        }

        private void populateWithMessages() {
            _dtMessages.Rows.Clear();
            var messages = _professionalBLL.GetAll().Where(x => x.UserEmail == UserSessionSingleton.Instance.User.Email).ToList().OrderByDescending(x => x.Date);

            foreach (var message in messages) {
                DataRow newRow = _dtMessages.NewRow();
                _dtMessages.Rows.Add(
                    message.MessageId,
                    message.MessageResponseText,
                    message.Date.ToString("MM/dd/yyyy hh:mm tt"));
            }
            dgvMessages.Refresh();
        }
        #endregion

    }
}
