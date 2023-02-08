using LifeTracker.Core.BLL;
using LifeTracker.Core.Interfaces;
using LifeTracker.Services.IAM.Composite2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LifeTracker.UI.Services
{
    public partial class frmUserManagement : Form {
        private UserBLL _userBLL;
        private UserRoleBLL _userRoleBLL;
        private ServiceTypeBLL _serviceTypeBLL;
        private UserServiceTypeBLL _userServiceTypeBLL;
        private User _user;
        private UserRole _userRole;
        private DataTable _dtRoles;
        private DataTable _dtAllPermissions;
        private DataTable _dtUserPermissions;

        public frmUserManagement() {
            InitializeComponent();
            _userBLL = new UserBLL();
            _userRoleBLL = new UserRoleBLL();
            _serviceTypeBLL = new ServiceTypeBLL();
            _userServiceTypeBLL = new UserServiceTypeBLL();

            _user = new User();
            _userRole = new UserRole();

            _dtRoles = new DataTable();
            _dtAllPermissions = new DataTable();
            _dtUserPermissions = new DataTable();
            Initialize();
        }

        public void Initialize() {
            initializeControls();
            initializeDgvRoles();
            initializedgvAllPermissions();
            initializedgvUserPermissions();
            initializeDdlUsers();            
        }

        #region General Controls
        private void initializeControls() {
            this.txtUser.Enabled = false;
            this.txtUser.Visible = false;
            this.txtUser.Location = this.ddlUser.Location;
            this.txtPassword.Enabled = false;
            this.txtPassword.Visible = false;
            this.ddlUser.Enabled = true;
            this.ddlUser.Visible = true;
            this.btnAddUser.Enabled = true;
            this.btnAddUser.Visible = true;
            this.btnAddUser.Location = new Point(this.btnAddRole.Location.X, this.txtPassword.Location.Y);
            this.btnRemoveUser.Enabled = true;
            this.btnRemoveUser.Visible = true;
            this.btnRemoveUser.Location = new Point(this.btnRemoveRole.Location.X, this.txtPassword.Location.Y);
            this.btnSaveUser.Enabled = false;
            this.btnSaveUser.Visible = false;
            this.btnTrash.Enabled = false;
            this.btnTrash.Visible = false;
            this.btnRemoveRole.Enabled = false;
            this.btnRemoveRole.Visible = false;
            this.chkProfessional.Enabled = true;
            this.chkProfessional.Visible = true;
            this.chkProfessional.Checked = false;
        }
        #endregion

        #region DropDownList_Controls
        private void initializeDdlUsers() {
            var _users = _userBLL.GetAll();
            ddlUser.DataSource = _users;
            ddlUser.DisplayMember = "Email";
            ddlUser.ValueMember = "Id";
            ddlUser.ForeColor = Color.Black;
        }

        private void initializeDdlRoles() {
            btnAddRole.Enabled = true;
            btnAddRole.Visible = true;
            btnRemoveRole.Enabled = false;
            btnRemoveRole.Visible = false;

            var allUserRoles = _userRoleBLL.GetAll();
            var userRoles = _user.Permissions;
            var userRolesFiltered = (IList<IUserRole>)allUserRoles.Where(p => !userRoles.Any(p2 => p2.Name == p.Name)).ToList();
            var userRolesFilteredByUserPermissions = userRolesFiltered.Where(x => x.Name != "User Permission").ToList();
            ddlRoles.DataSource = (userRolesFilteredByUserPermissions == null ? userRolesFiltered : userRolesFilteredByUserPermissions);
            ddlRoles.DisplayMember = "Name";
            ddlRoles.ValueMember = "Id";
            ddlRoles.ForeColor = Color.Black;
        }
        #endregion

        #region DataGridView_Controls
        private void initializeDgvRoles() {
            DataColumn[] tableColumns = new DataColumn[] {
                new DataColumn() { ColumnName = "ID", DataType = typeof(string) },
                new DataColumn() { ColumnName = "Usuario", DataType = typeof(string) },
                new DataColumn() { ColumnName = "Rol", DataType = typeof(string) }
            };
            _dtRoles.Columns.AddRange(tableColumns);
            dgvUserRoles.DataSource = _dtRoles;
            dgvUserRoles.Columns[0].Visible = false;    // hide id column
        }

        private void initializedgvAllPermissions() {
            DataColumn[] tableColumns = new DataColumn[] {
                new DataColumn() { ColumnName = "ID", DataType = typeof(string) },
                new DataColumn() { ColumnName = "Permisos Disponibles", DataType = typeof(string) },
                new DataColumn() { ColumnName = "Descripción", DataType = typeof(string) }
            };
            _dtAllPermissions.Columns.AddRange(tableColumns);
            dgvAllPermissions.DataSource = _dtAllPermissions;
            dgvAllPermissions.Columns[0].Visible = false;     // hide id column
        }

        private void initializedgvUserPermissions() {
            DataColumn[] tableColumns = new DataColumn[] {
                new DataColumn() { ColumnName = "ID", DataType = typeof(string) },
                new DataColumn() { ColumnName = "Permisos del Usuario", DataType = typeof(string) }
            };
            _dtUserPermissions.Columns.AddRange(tableColumns);
            dgvUserPermissions.DataSource = _dtUserPermissions;
            dgvUserPermissions.Columns[0].Visible = false;    // hide id column
        }

        private void populateWithUserRoles() {
            _dtRoles.Rows.Clear();

            foreach (var i in _user.Permissions.Where(x => x.Name != "User Permission").ToList()) {
                DataRow newRow = _dtRoles.NewRow();
                _dtRoles.Rows.Add(i.Id, _user.Email, i.Name);
            }
            dgvUserRoles.Refresh();
        }

        private void populateWithAllPermissions() {
            _dtAllPermissions.Rows.Clear();

            var _allServiceTypes = _serviceTypeBLL.GetAll();   // all available services
            var _userRoles = _user.Permissions;                // all user's roles

            List<IPermission> _userServices = new List<IPermission>();
            foreach (var userRole in _userRoles) {
                _userServices.AddRange(userRole.Children());
            }
            var _serviceTypesFiltered = (IList<IServiceType>)_allServiceTypes.Where(p => !_userServices.Distinct().Any(p2 => p2.Name == p.Name)).ToList();

            foreach (var service in _serviceTypesFiltered) {
                DataRow newRow = _dtAllPermissions.NewRow();
                _dtAllPermissions.Rows.Add(service.Id, service.Name, service.Description);
            }
            dgvAllPermissions.Refresh();
        }

        private void populateWithUserPermissions() {
            _dtUserPermissions.Rows.Clear();

            var _allServiceTypes = _serviceTypeBLL.GetAll();   // all available services
            var _userRoles = _user.Permissions;                // all user's roles

            List<IPermission> _userServices = new List<IPermission>();
            foreach (var userRole in _userRoles) {
                _userServices.AddRange(userRole.Children());
            }
            var _serviceTypesFiltered = (IList<IServiceType>)_allServiceTypes.Where(p => _userServices.Distinct().Any(p2 => p2.Name == p.Name)).ToList();

            foreach (var service in _serviceTypesFiltered) {
                DataRow newRow = _dtUserPermissions.NewRow();
                _dtUserPermissions.Rows.Add(service.Id, service.Name);
            }
            dgvUserPermissions.Refresh();
        }

        #endregion

        #region Other Methods
        private void onClickAdd() {
            this.ddlUser.Enabled = false;
            this.ddlUser.Visible = false;
            this.txtUser.Enabled = true;
            this.txtUser.Visible = true;
            this.txtPassword.Enabled = true;
            this.txtPassword.Visible = true;
            this.btnAddUser.Enabled = false;
            this.btnAddUser.Visible = false;
            this.btnRemoveUser.Enabled = false;
            this.btnRemoveUser.Visible = false;
            this.btnSaveUser.Enabled = true;
            this.btnSaveUser.Visible = true;
            this.btnSaveUser.Location = new Point(this.txtPassword.Location.X + this.txtPassword.Width + 10, this.txtPassword.Location.Y);
            this.btnTrash.Enabled = true;
            this.btnTrash.Visible = true;
            this.btnTrash.Location = new Point(this.txtPassword.Location.X + this.txtPassword.Width + 50, this.txtPassword.Location.Y);
            this.txtUser.ForeColor = Color.Black;
            this.txtPassword.ForeColor = Color.Black;
            txtUser.Focus();
        }

        private bool validateCreateUser() {
            return txtUser.Text != null && txtPassword.Text != null;
        }
        #endregion

        #region Tree View [ All Predefined Permissions ]
        /// <summary>
        /// Initializes the tree view and add permissions to first node.
        /// </summary>
        private void showPermissions() {
            if (_user != null) {
                initializeTreeView();
                var root = createNode("Permisos predefinidos por Rol", treePermissions);
                foreach (var i in _user.Permissions) {
                    var node = createNode(i, root);
                    if (i.Children().Count > 0)
                        showRecursivePermissions(i, node);
                }
                this.treePermissions.ExpandAll();
            }
        }

        /// <summary>
        /// Add recursively <paramref name="permission"/> to <paramref name="node"/>.
        /// </summary>
        /// <param name="permissions"></param>
        /// <param name="node"></param>
        private void showRecursivePermissions(IPermission permissions, TreeNode node) {
            foreach (var i in permissions.Children()) {
                var node1 = createNode(i, node);
                if (i.Children().Count > 0)
                    showRecursivePermissions(i, node1);
            }
        }

        private void initializeTreeView() {
            this.treePermissions.Nodes.Clear();
        }
        #endregion

        #region Tree View [ All User Permissions ]
        /// <summary>
        /// Initializes the tree view and add permissions to first node.
        /// </summary>
        private void showUserPermissions() {
            if (_user != null) {
                //var _user = _userBLL.GetUserWithFilteredPermissions(this._user);
                initializeUserTreeView();
                var root = createNode("Permisos Asignados al Usuario", treeUserPermissions);
                foreach (var userRole in _user.Permissions) {
                    if (userRole.Children().Count > 0)
                        showRecursiveUserPermissions(userRole, root);
                }
                this.treeUserPermissions.ExpandAll();
            }
        }

        /// <summary>
        /// Add recursively <paramref name="permission"/> to <paramref name="node"/>.
        /// </summary>
        /// <param name="permissions"></param>
        /// <param name="node"></param>
        private void showRecursiveUserPermissions(IPermission permissions, TreeNode node) {
            foreach (var service in permissions.Children()) {
                bool valid = true;
                foreach(var nodeItem in node.Nodes) {
                    var node1 = (TreeNode)nodeItem;
                    if (node1.Text == service.Name)
                        valid = false;
                }
                if (valid) {
                    var node1 = node.Nodes.Add(service.Name);
                    if (service.Children().Count > 0)
                        showRecursivePermissions(service, node1);
                }
            }
        }

        private void initializeUserTreeView() {
            this.treeUserPermissions.Nodes.Clear();
        }
        #endregion

        #region Tree View [ Common Methods ]
        /// <summary>
        /// Create a <paramref name="permissions"/> to first node.
        /// </summary>
        /// <param name="permissions"></param>
        /// <returns></returns>
        private TreeNode createNode(string permissions, TreeView obj) {
            var node = new TreeNode(permissions);
            obj.Nodes.Add(node);
            return node;
        }

        /// <summary>
        /// Create a <paramref name="permission"/> to <paramref name="node"/>.
        /// </summary>
        /// <param name="permission"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        private TreeNode createNode(IPermission permission, TreeNode node) {
            var node1 = node.Nodes.Add(permission.Name);
            return node1;
        }
        #endregion

        #region Form Events
        private void btnAddUser_Click(object sender, System.EventArgs e) {
            onClickAdd();
        }

        private void btnTrash_Click(object sender, System.EventArgs e) {
            initializeControls();
        }

        private void btnSaveUser_Click(object sender, System.EventArgs e) {
            if (validateCreateUser()) {
                bool _professional = chkProfessional.Checked;
                _userBLL.CreateUser(txtUser.Text, txtPassword.Text, _professional);

                initializeControls();
                initializeDdlUsers();
            }
            else {
                string msg = null;
                if (txtUser.Text == null && txtPassword.Text != null)
                    msg = "Usuario incorrecto.";
                else if (txtUser.Text != null && txtPassword.Text == null)
                    msg = "Contraseña incorrecta.";
                else
                    msg = "Los datos ingresados son incorrectos.";
                MessageBox.Show("No se puede crear el usuario. " + msg, "Life Tracker");
            }
        }

        private void btnRemoveUser_Click(object sender, System.EventArgs e) {
            if (this.ddlUser.SelectedItem != null) {
                _userBLL.RemoveUser(_user);
                initializeDdlUsers();
            }
        }

        private void ddlUser_SelectedIndexChanged(object sender, System.EventArgs e) {
            _user = (User)this.ddlUser.SelectedItem;
            refreshUserEntityWithPermissions(_user);
            if(_user == null) _user = (User)this.ddlUser.SelectedItem;  // force to get it back again when the user failed due to user permissions schema
            refreshData();
        }

        private void btnAddRole_Click(object sender, System.EventArgs e) {
            // add a new role to selected user
            if(ddlRoles.SelectedItem != null) {
                _user.AddPermission(_userRole);
                _userBLL.AddRolePermissions(_user);

                refreshData();
            }
        }

        private void ddlRoles_SelectedIndexChanged(object sender, System.EventArgs e) {
            _userRole = (UserRole)this.ddlRoles.SelectedItem;
        }

        private void dgvUserRoles_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            // hide addRole button
            this.btnAddRole.Enabled = false;
            this.btnAddRole.Visible = false;
            this.btnRemoveRole.Enabled = true;
            this.btnRemoveRole.Visible = true;
            this.btnRemoveRole.Location = btnAddRole.Location;
            this.btnRemoveRole.BringToFront();

            // drop down list reloaded by having only selected role
            overrideDdlRoles();
        }

        private void overrideDdlRoles() {
            var allUserRoles = _userRoleBLL.GetAll();
            var userRoles = _user.Permissions;
            var userRolesFiltered = (IList<IUserRole>)allUserRoles.Where(p => userRoles.Any(p2 => p2.Name == p.Name)).ToList();

            ddlRoles.DataSource = userRolesFiltered;
            ddlRoles.DisplayMember = "Name";
            ddlRoles.ValueMember = "Id";
            ddlRoles.ForeColor = Color.Black;
        }

        private void btnRemoveRole_Click(object sender, EventArgs e) {
            if(ddlRoles.SelectedItem != null) {
                // remove the userRole for the selected user
                var _userRole = (UserRole)ddlRoles.SelectedItem;
                var _updatedUser = _userBLL.RemoveRolePermission(_user, _userRole);

                refreshUserEntityWithPermissions(_updatedUser);
                ddlUser.SelectedItem = _user;
                refreshData();
            }
        }

        private void refreshUserEntityWithPermissions(User user) => _user = (User)_userBLL.GetAllWithPermission().Where(x => x.Id == user.Id).FirstOrDefault();

        private void refreshData() {
            initializeDdlRoles();
            showPermissions();
            showUserPermissions();
            populateWithUserRoles();
            populateWithAllPermissions();
            populateWithUserPermissions();
        }

        private void refreshDataWithCustomSettings() {
            initializeDdlRoles();
            showPermissions();
            showUserPermissions();
            populateWithUserRoles();
        }

        private void btnAddLeft_Click(object sender, EventArgs e) {
            if (dgvUserPermissions.SelectedRows[0].Selected) {
                try {
                    var permissionId = (string)dgvUserPermissions.SelectedRows[0].Cells[0].Value;
                    var service = _serviceTypeBLL.GetAll().Where(x => x.Id.ToString() == permissionId).FirstOrDefault();

                    // check if already exists the user role
                    var userCustomRole = (UserRole)_user.Permissions.Where(x => x.Name == "User Permission").FirstOrDefault();
                    var userServiceRole = userCustomRole.Permissions.Where(x => x.Name == service.Name).FirstOrDefault();
                    userCustomRole.RemovePermission(userServiceRole);
                    _userBLL.RemoveCustomPermission(_user, userCustomRole);

                    refreshDataWithCustomSettings();
                    populateWithAllPermissions();
                    populateWithUserPermissions();
                    initializeDdlUsers();
                }
                catch (Exception ex) {
                    MessageBox.Show(
                        "No está permitido quitar este permiso.\nIntente nuevamente.",
                        "Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnAddRight_Click(object sender, EventArgs e) {
            if (dgvAllPermissions.SelectedRows[0].Selected) {
                try { 
                    var permissionId = (string)dgvAllPermissions.SelectedRows[0].Cells[0].Value;
                    var service = _serviceTypeBLL.GetAll().Where(x => x.Id.ToString() == permissionId).FirstOrDefault();


                    // check if already exists the user role
                    UserRole userCustomRole;
                    if (!_userBLL.PermissionsExists(_user.Permissions)) {
                        _userRoleBLL.CreateCustomRole(service);
                        userCustomRole = (UserRole)_userRoleBLL.GetAll().Where(x => x.Name == "User Permission").FirstOrDefault();
                    }
                    else {
                        userCustomRole = (UserRole)_user.Permissions.Where(x => x.Name == "User Permission").FirstOrDefault();
                        _user.RemovePermission(userCustomRole);
                    }

                    userCustomRole.AddPermission(service);
                    _user.AddPermission(userCustomRole);
                    _userBLL.AddCustomPermissions(_user);

                    refreshDataWithCustomSettings();
                    populateWithAllPermissions();
                    populateWithUserPermissions();
                    initializeDdlUsers();
                }
                catch (Exception ex) {
                    MessageBox.Show(
                        "No está permitido agregar este permiso.\nIntente nuevamente.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion

    }
}
