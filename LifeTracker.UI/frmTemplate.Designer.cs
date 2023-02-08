
namespace LifeTracker.UI.Services
{
    partial class frmTemplate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTemplate));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnTrash = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnSave = new Bunifu.UI.WinForms.BunifuImageButton();
            this.txtBackupName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnRestore = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblBackup = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblUser = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnRestoreDb = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnBackupDb = new Bunifu.UI.WinForms.BunifuImageButton();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.dgvBackup = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsBackupStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackup)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btnTrash);
            this.bunifuPanel1.Controls.Add(this.btnSave);
            this.bunifuPanel1.Controls.Add(this.txtBackupName);
            this.bunifuPanel1.Controls.Add(this.btnRestore);
            this.bunifuPanel1.Controls.Add(this.lblBackup);
            this.bunifuPanel1.Controls.Add(this.lblUser);
            this.bunifuPanel1.Controls.Add(this.btnRestoreDb);
            this.bunifuPanel1.Controls.Add(this.btnBackupDb);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(912, 132);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // btnTrash
            // 
            this.btnTrash.ActiveImage = null;
            this.btnTrash.AllowAnimations = true;
            this.btnTrash.AllowBuffering = false;
            this.btnTrash.AllowToggling = false;
            this.btnTrash.AllowZooming = true;
            this.btnTrash.AllowZoomingOnFocus = false;
            this.btnTrash.BackColor = System.Drawing.Color.Transparent;
            this.btnTrash.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTrash.ErrorImage = global::LifeTracker.UI.Properties.Resources.save_32;
            this.btnTrash.FadeWhenInactive = false;
            this.btnTrash.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnTrash.Image = global::LifeTracker.UI.Properties.Resources.delete_32;
            this.btnTrash.ImageActive = null;
            this.btnTrash.ImageLocation = null;
            this.btnTrash.ImageMargin = 10;
            this.btnTrash.ImageSize = new System.Drawing.Size(22, 22);
            this.btnTrash.ImageZoomSize = new System.Drawing.Size(32, 32);
            this.btnTrash.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnTrash.InitialImage")));
            this.btnTrash.Location = new System.Drawing.Point(535, 74);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Rotation = 0;
            this.btnTrash.ShowActiveImage = true;
            this.btnTrash.ShowCursorChanges = true;
            this.btnTrash.ShowImageBorders = true;
            this.btnTrash.ShowSizeMarkers = false;
            this.btnTrash.Size = new System.Drawing.Size(32, 32);
            this.btnTrash.TabIndex = 60;
            this.btnTrash.ToolTipText = "";
            this.btnTrash.WaitOnLoad = false;
            this.btnTrash.Zoom = 10;
            this.btnTrash.ZoomSpeed = 10;
            // 
            // btnSave
            // 
            this.btnSave.ActiveImage = null;
            this.btnSave.AllowAnimations = true;
            this.btnSave.AllowBuffering = false;
            this.btnSave.AllowToggling = false;
            this.btnSave.AllowZooming = true;
            this.btnSave.AllowZoomingOnFocus = false;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.ErrorImage = global::LifeTracker.UI.Properties.Resources.save_32;
            this.btnSave.FadeWhenInactive = false;
            this.btnSave.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnSave.Image = global::LifeTracker.UI.Properties.Resources.save_32;
            this.btnSave.ImageActive = null;
            this.btnSave.ImageLocation = null;
            this.btnSave.ImageMargin = 10;
            this.btnSave.ImageSize = new System.Drawing.Size(22, 22);
            this.btnSave.ImageZoomSize = new System.Drawing.Size(32, 32);
            this.btnSave.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnSave.InitialImage")));
            this.btnSave.Location = new System.Drawing.Point(497, 74);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0;
            this.btnSave.ShowActiveImage = true;
            this.btnSave.ShowCursorChanges = true;
            this.btnSave.ShowImageBorders = true;
            this.btnSave.ShowSizeMarkers = false;
            this.btnSave.Size = new System.Drawing.Size(32, 32);
            this.btnSave.TabIndex = 59;
            this.btnSave.ToolTipText = "";
            this.btnSave.WaitOnLoad = false;
            this.btnSave.Zoom = 10;
            this.btnSave.ZoomSpeed = 10;
            // 
            // txtBackupName
            // 
            this.txtBackupName.AcceptsReturn = false;
            this.txtBackupName.AcceptsTab = false;
            this.txtBackupName.AnimationSpeed = 200;
            this.txtBackupName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBackupName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBackupName.BackColor = System.Drawing.Color.Transparent;
            this.txtBackupName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBackupName.BackgroundImage")));
            this.txtBackupName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtBackupName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBackupName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtBackupName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtBackupName.BorderRadius = 1;
            this.txtBackupName.BorderThickness = 1;
            this.txtBackupName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBackupName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBackupName.DefaultFont = new System.Drawing.Font("Segoe UI", 8F);
            this.txtBackupName.DefaultText = "";
            this.txtBackupName.FillColor = System.Drawing.Color.White;
            this.txtBackupName.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBackupName.HideSelection = true;
            this.txtBackupName.IconLeft = null;
            this.txtBackupName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBackupName.IconPadding = 10;
            this.txtBackupName.IconRight = null;
            this.txtBackupName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBackupName.Lines = new string[0];
            this.txtBackupName.Location = new System.Drawing.Point(218, 73);
            this.txtBackupName.MaxLength = 32767;
            this.txtBackupName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBackupName.Modified = false;
            this.txtBackupName.Multiline = false;
            this.txtBackupName.Name = "txtBackupName";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBackupName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBackupName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBackupName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.DarkGray;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBackupName.OnIdleState = stateProperties4;
            this.txtBackupName.Padding = new System.Windows.Forms.Padding(3);
            this.txtBackupName.PasswordChar = '\0';
            this.txtBackupName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBackupName.PlaceholderText = "nombre del resguardo";
            this.txtBackupName.ReadOnly = false;
            this.txtBackupName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBackupName.SelectedText = "";
            this.txtBackupName.SelectionLength = 0;
            this.txtBackupName.SelectionStart = 0;
            this.txtBackupName.ShortcutsEnabled = true;
            this.txtBackupName.Size = new System.Drawing.Size(273, 35);
            this.txtBackupName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBackupName.TabIndex = 55;
            this.txtBackupName.Tag = "";
            this.txtBackupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBackupName.TextMarginBottom = 0;
            this.txtBackupName.TextMarginLeft = 3;
            this.txtBackupName.TextMarginTop = 0;
            this.txtBackupName.TextPlaceholder = "nombre del resguardo";
            this.txtBackupName.UseSystemPasswordChar = false;
            this.txtBackupName.WordWrap = true;
            // 
            // btnRestore
            // 
            this.btnRestore.AllowParentOverrides = false;
            this.btnRestore.AutoEllipsis = false;
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRestore.CursorType = System.Windows.Forms.Cursors.Default;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnRestore.Location = new System.Drawing.Point(110, 104);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRestore.Size = new System.Drawing.Size(49, 13);
            this.btnRestore.TabIndex = 49;
            this.btnRestore.Text = "Restaurar";
            this.btnRestore.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.btnRestore.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblBackup
            // 
            this.lblBackup.AllowParentOverrides = false;
            this.lblBackup.AutoEllipsis = false;
            this.lblBackup.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBackup.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblBackup.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblBackup.Location = new System.Drawing.Point(50, 104);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBackup.Size = new System.Drawing.Size(42, 13);
            this.lblBackup.TabIndex = 47;
            this.lblBackup.Text = "Guardar";
            this.lblBackup.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblBackup.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblUser
            // 
            this.lblUser.AllowParentOverrides = false;
            this.lblUser.AutoEllipsis = false;
            this.lblUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUser.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblUser.Location = new System.Drawing.Point(15, 13);
            this.lblUser.Name = "lblUser";
            this.lblUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUser.Size = new System.Drawing.Size(81, 23);
            this.lblUser.TabIndex = 43;
            this.lblUser.Text = "Resguardo";
            this.lblUser.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblUser.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnRestoreDb
            // 
            this.btnRestoreDb.ActiveImage = null;
            this.btnRestoreDb.AllowAnimations = true;
            this.btnRestoreDb.AllowBuffering = false;
            this.btnRestoreDb.AllowToggling = false;
            this.btnRestoreDb.AllowZooming = true;
            this.btnRestoreDb.AllowZoomingOnFocus = false;
            this.btnRestoreDb.BackColor = System.Drawing.Color.Transparent;
            this.btnRestoreDb.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRestoreDb.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnRestoreDb.ErrorImage")));
            this.btnRestoreDb.FadeWhenInactive = false;
            this.btnRestoreDb.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnRestoreDb.Image = global::LifeTracker.UI.Properties.Resources.database_restore_50;
            this.btnRestoreDb.ImageActive = null;
            this.btnRestoreDb.ImageLocation = null;
            this.btnRestoreDb.ImageMargin = 10;
            this.btnRestoreDb.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRestoreDb.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btnRestoreDb.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnRestoreDb.InitialImage")));
            this.btnRestoreDb.Location = new System.Drawing.Point(109, 48);
            this.btnRestoreDb.Name = "btnRestoreDb";
            this.btnRestoreDb.Rotation = 0;
            this.btnRestoreDb.ShowActiveImage = true;
            this.btnRestoreDb.ShowCursorChanges = true;
            this.btnRestoreDb.ShowImageBorders = true;
            this.btnRestoreDb.ShowSizeMarkers = false;
            this.btnRestoreDb.Size = new System.Drawing.Size(50, 50);
            this.btnRestoreDb.TabIndex = 48;
            this.btnRestoreDb.ToolTipText = "";
            this.btnRestoreDb.WaitOnLoad = false;
            this.btnRestoreDb.Zoom = 10;
            this.btnRestoreDb.ZoomSpeed = 10;
            // 
            // btnBackupDb
            // 
            this.btnBackupDb.ActiveImage = null;
            this.btnBackupDb.AllowAnimations = true;
            this.btnBackupDb.AllowBuffering = false;
            this.btnBackupDb.AllowToggling = false;
            this.btnBackupDb.AllowZooming = true;
            this.btnBackupDb.AllowZoomingOnFocus = false;
            this.btnBackupDb.BackColor = System.Drawing.Color.Transparent;
            this.btnBackupDb.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBackupDb.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnBackupDb.ErrorImage")));
            this.btnBackupDb.FadeWhenInactive = false;
            this.btnBackupDb.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnBackupDb.Image = global::LifeTracker.UI.Properties.Resources.database_backup_50;
            this.btnBackupDb.ImageActive = null;
            this.btnBackupDb.ImageLocation = null;
            this.btnBackupDb.ImageMargin = 10;
            this.btnBackupDb.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBackupDb.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btnBackupDb.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBackupDb.InitialImage")));
            this.btnBackupDb.Location = new System.Drawing.Point(47, 48);
            this.btnBackupDb.Name = "btnBackupDb";
            this.btnBackupDb.Rotation = 0;
            this.btnBackupDb.ShowActiveImage = true;
            this.btnBackupDb.ShowCursorChanges = true;
            this.btnBackupDb.ShowImageBorders = true;
            this.btnBackupDb.ShowSizeMarkers = false;
            this.btnBackupDb.Size = new System.Drawing.Size(50, 50);
            this.btnBackupDb.TabIndex = 46;
            this.btnBackupDb.ToolTipText = "";
            this.btnBackupDb.WaitOnLoad = false;
            this.btnBackupDb.Zoom = 10;
            this.btnBackupDb.ZoomSpeed = 10;
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.IsSplitterFixed = true;
            this.scMain.Location = new System.Drawing.Point(0, 132);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.scMain.Panel1.Controls.Add(this.dgvBackup);
            this.scMain.Panel1.ForeColor = System.Drawing.Color.MintCream;
            this.scMain.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.statusStrip1);
            this.scMain.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.scMain.Size = new System.Drawing.Size(912, 510);
            this.scMain.SplitterDistance = 472;
            this.scMain.TabIndex = 2;
            // 
            // dgvBackup
            // 
            this.dgvBackup.AllowCustomTheming = false;
            this.dgvBackup.AllowUserToAddRows = false;
            this.dgvBackup.AllowUserToDeleteRows = false;
            this.dgvBackup.AllowUserToResizeColumns = false;
            this.dgvBackup.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvBackup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBackup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBackup.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBackup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBackup.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBackup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBackup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBackup.ColumnHeadersHeight = 40;
            this.dgvBackup.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvBackup.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvBackup.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBackup.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvBackup.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBackup.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvBackup.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvBackup.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvBackup.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvBackup.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBackup.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvBackup.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBackup.CurrentTheme.Name = null;
            this.dgvBackup.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBackup.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvBackup.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBackup.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvBackup.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBackup.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBackup.EnableHeadersVisualStyles = false;
            this.dgvBackup.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvBackup.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvBackup.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvBackup.HeaderForeColor = System.Drawing.Color.White;
            this.dgvBackup.Location = new System.Drawing.Point(10, 10);
            this.dgvBackup.MultiSelect = false;
            this.dgvBackup.Name = "dgvBackup";
            this.dgvBackup.ReadOnly = true;
            this.dgvBackup.RowHeadersVisible = false;
            this.dgvBackup.RowTemplate.Height = 40;
            this.dgvBackup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBackup.ShowEditingIcon = false;
            this.dgvBackup.Size = new System.Drawing.Size(892, 452);
            this.dgvBackup.TabIndex = 8;
            this.dgvBackup.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBackupStatus});
            this.statusStrip1.Location = new System.Drawing.Point(10, 2);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(892, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsBackupStatus
            // 
            this.tsBackupStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBackupStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tsBackupStatus.Name = "tsBackupStatus";
            this.tsBackupStatus.Size = new System.Drawing.Size(82, 17);
            this.tsBackupStatus.Text = "[ last backup ]";
            // 
            // frmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 642);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.bunifuPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackup)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel btnRestore;
        private Bunifu.UI.WinForms.BunifuLabel lblBackup;
        private Bunifu.UI.WinForms.BunifuLabel lblUser;
        private Bunifu.UI.WinForms.BunifuImageButton btnRestoreDb;
        private Bunifu.UI.WinForms.BunifuImageButton btnBackupDb;
        private Bunifu.UI.WinForms.BunifuImageButton btnTrash;
        private Bunifu.UI.WinForms.BunifuImageButton btnSave;
        private Bunifu.UI.WinForms.BunifuTextBox txtBackupName;
        private System.Windows.Forms.SplitContainer scMain;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvBackup;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsBackupStatus;
    }
}