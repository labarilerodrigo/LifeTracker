using LifeTracker.Core.BLL;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace LifeTracker.UI.Services
{
    public partial class frmBackup : Form {
        private BackupBLL _backupBLL;
        private DataTable _dtBackup;
        private string _backupId;

        public frmBackup() {
            InitializeComponent();

            _backupBLL = new BackupBLL();
            _dtBackup = new DataTable();
            Initialize();
        }

        public void Initialize() {
            initializeDgvBackup();
            initializeControls();
            populateWithUserBackup();
        }

        #region [ Data Grid View - Controls ]
        private void initializeDgvBackup() {
            DataColumn[] tableColumns = new DataColumn[] {
                new DataColumn() { ColumnName = "ID", DataType = typeof(string) },
                new DataColumn() { ColumnName = "Operación", DataType = typeof(string) },
                new DataColumn() { ColumnName = "Usuario", DataType = typeof(string) },
                new DataColumn() { ColumnName = "Resguardo", DataType = typeof(string) },
                new DataColumn() { ColumnName = "Fecha", DataType = typeof(string) }
            };
            _dtBackup.Columns.AddRange(tableColumns);
            dgvBackup.DataSource = _dtBackup;
            dgvBackup.Columns[0].Visible = false;    // hide id column
        }

        private void populateWithUserBackup() {
            _dtBackup.Rows.Clear();
            var _backups = _backupBLL.GetAllBackup().OrderByDescending(x => x.TimeStamp);

            foreach (var backup in _backups) {
                DataRow newRow = _dtBackup.NewRow();
                _dtBackup.Rows.Add(
                    backup.UserId.ToString(), 
                    backup.Operation.ToString(),
                    backup.UserEmail,
                    backup.Name, 
                    backup.TimeStamp.ToString("g", CultureInfo.GetCultureInfo("es-ES")));

                tsBackupStatus.Text = "Última actualización: " + backup.TimeStamp.ToString("MM/dd/yyyy hh:mm tt");
            }
            dgvBackup.Refresh();
        }
        #endregion

        #region Form Events
        private void btnBackupDb_Click(object sender, EventArgs e) {
            onSaveControls();
        }

        private void btnRestoreDb_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea restaurar las configuraciones?", "Restauración del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            
            if (dialogResult == DialogResult.OK) {
                if (_backupId != null) {
                    _backupBLL.Restore(_backupId);
                }
            }
            turnOnControls(true);
            refreshControls();
        }

        private void btnSaveUser_Click(object sender, EventArgs e) {
            if (validateTextBoxControls()) {
                // call backup service
                _backupBLL.Backup(txtBackupName.Text);

                refreshControls();
            }
            else {
                string msg = null;
                if (txtBackupName.Text == null)
                    msg = "Nombre de resguardo incorrecto.";
                MessageBox.Show("No se puede crear el resguardo. " + msg, "Life Tracker");
            }
        }

        private void btnTrash_Click(object sender, EventArgs e) {
            txtBackupName.Enabled = false;
            txtBackupName.Visible = false;
            btnSave.Enabled = false;
            btnSave.Visible = false;
            btnTrash.Enabled = false;
            btnTrash.Visible = false;
            btnBackupDb.Enabled = true;
            btnBackupDb.Visible = true;
            btnRestore.Enabled = true;
            btnRestore.Visible = true;
            txtBackupName.Text = null;
        }

        private void dgvBackup_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvBackup.SelectedRows[0].Selected && 
                dgvBackup.SelectedRows[0].Cells[1].Value.ToString() == "Backup") {
                _backupId = (string)dgvBackup.SelectedRows[0].Cells[0].Value.ToString();

                // get ready for restore
                turnOnControls(false);
            }
            else if (dgvBackup.SelectedRows[0].Selected &&
                dgvBackup.SelectedRows[0].Cells[1].Value.ToString() == "Restore") {
                turnOffControls();
            }
        }
        #endregion

        #region Controls
        private void initializeControls() {
            txtBackupName.Enabled = false;
            txtBackupName.Visible = false;
            btnBackupDb.Enabled = true;
            btnBackupDb.Visible = true;
            btnRestoreDb.Enabled = false;
            btnRestoreDb.Visible = true;
            btnRestore.Enabled = true;
            btnRestore.Visible = true;
            btnSave.Enabled = false;
            btnSave.Visible = false;
            btnTrash.Enabled = false;
            btnTrash.Visible = false;
        }

        private void onSaveControls() {
            btnBackupDb.Enabled = false;
            btnBackupDb.Visible = true;
            btnRestoreDb.Enabled = false;
            btnRestoreDb.Visible = true;
            btnRestore.Enabled = false;
            btnRestore.Visible = true;
            txtBackupName.Enabled = true;
            txtBackupName.Visible = true;
            btnSave.Enabled = true;
            btnSave.Visible = true;
            btnTrash.Enabled = true;
            btnTrash.Visible = true;            
        }

        private void turnOnControls(bool enable = true) {
            btnBackupDb.Enabled = enable;
            btnRestoreDb.Enabled = !enable;
            txtBackupName.Enabled = enable;
            btnSave.Enabled = enable;
            btnTrash.Enabled = enable;
        }

        private void turnOffControls() {
            btnBackupDb.Enabled = false;
            btnRestoreDb.Enabled = false;
            txtBackupName.Enabled = false;
            btnSave.Enabled = false;
            btnTrash.Enabled = false;            
        }

        private bool validateTextBoxControls() {
            return txtBackupName.Text != null;
        }
        #endregion

        #region Other Methods
        private void refreshControls() {
            initializeControls();
            populateWithUserBackup();
        }

        #endregion
        
    }
}
