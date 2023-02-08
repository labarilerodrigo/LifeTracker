
namespace LifeTracker.UI.Services
{
    partial class frmMessageProfessional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageProfessional));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel4 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblAllMessages = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnAllMessages = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblUser = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtResponseMsg = new System.Windows.Forms.RichTextBox();
            this.lblResponseMsg = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtReceivedMsg = new System.Windows.Forms.RichTextBox();
            this.btnTrash = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnSend = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblReceivedMsg = new Bunifu.UI.WinForms.BunifuLabel();
            this.ddlSubject = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblSubject = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvMessages = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuGradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.BorderRadius = 1;
            this.bunifuGradientPanel4.Controls.Add(this.splitContainerMain);
            this.bunifuGradientPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.MediumAquamarine;
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(912, 642);
            this.bunifuGradientPanel4.TabIndex = 4;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.bunifuPanel1);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.txtResponseMsg);
            this.splitContainerMain.Panel2.Controls.Add(this.lblResponseMsg);
            this.splitContainerMain.Panel2.Controls.Add(this.txtReceivedMsg);
            this.splitContainerMain.Panel2.Controls.Add(this.btnTrash);
            this.splitContainerMain.Panel2.Controls.Add(this.btnSend);
            this.splitContainerMain.Panel2.Controls.Add(this.lblReceivedMsg);
            this.splitContainerMain.Panel2.Controls.Add(this.ddlSubject);
            this.splitContainerMain.Panel2.Controls.Add(this.lblSubject);
            this.splitContainerMain.Panel2.Controls.Add(this.dgvMessages);
            this.splitContainerMain.Size = new System.Drawing.Size(912, 642);
            this.splitContainerMain.SplitterDistance = 137;
            this.splitContainerMain.TabIndex = 0;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lblAllMessages);
            this.bunifuPanel1.Controls.Add(this.btnAllMessages);
            this.bunifuPanel1.Controls.Add(this.lblUser);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(912, 137);
            this.bunifuPanel1.TabIndex = 2;
            // 
            // lblAllMessages
            // 
            this.lblAllMessages.AllowParentOverrides = false;
            this.lblAllMessages.AutoEllipsis = false;
            this.lblAllMessages.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAllMessages.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblAllMessages.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAllMessages.Location = new System.Drawing.Point(60, 102);
            this.lblAllMessages.Name = "lblAllMessages";
            this.lblAllMessages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAllMessages.Size = new System.Drawing.Size(52, 13);
            this.lblAllMessages.TabIndex = 54;
            this.lblAllMessages.Text = "Ver Todos";
            this.lblAllMessages.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblAllMessages.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnAllMessages
            // 
            this.btnAllMessages.ActiveImage = null;
            this.btnAllMessages.AllowAnimations = true;
            this.btnAllMessages.AllowBuffering = false;
            this.btnAllMessages.AllowToggling = false;
            this.btnAllMessages.AllowZooming = false;
            this.btnAllMessages.AllowZoomingOnFocus = false;
            this.btnAllMessages.BackColor = System.Drawing.Color.Transparent;
            this.btnAllMessages.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAllMessages.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnAllMessages.ErrorImage")));
            this.btnAllMessages.FadeWhenInactive = false;
            this.btnAllMessages.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnAllMessages.Image = global::LifeTracker.UI.Properties.Resources.messages_50;
            this.btnAllMessages.ImageActive = null;
            this.btnAllMessages.ImageLocation = null;
            this.btnAllMessages.ImageMargin = 15;
            this.btnAllMessages.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAllMessages.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btnAllMessages.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnAllMessages.InitialImage")));
            this.btnAllMessages.Location = new System.Drawing.Point(62, 46);
            this.btnAllMessages.Name = "btnAllMessages";
            this.btnAllMessages.Rotation = 0;
            this.btnAllMessages.ShowActiveImage = true;
            this.btnAllMessages.ShowCursorChanges = true;
            this.btnAllMessages.ShowImageBorders = true;
            this.btnAllMessages.ShowSizeMarkers = false;
            this.btnAllMessages.Size = new System.Drawing.Size(50, 50);
            this.btnAllMessages.TabIndex = 53;
            this.btnAllMessages.ToolTipText = "";
            this.btnAllMessages.WaitOnLoad = false;
            this.btnAllMessages.Zoom = 15;
            this.btnAllMessages.ZoomSpeed = 10;
            this.btnAllMessages.Click += new System.EventHandler(this.btnAllMessages_Click);
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
            this.lblUser.Size = new System.Drawing.Size(70, 23);
            this.lblUser.TabIndex = 52;
            this.lblUser.Text = "Mensajes";
            this.lblUser.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblUser.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtResponseMsg
            // 
            this.txtResponseMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResponseMsg.Location = new System.Drawing.Point(288, 239);
            this.txtResponseMsg.Name = "txtResponseMsg";
            this.txtResponseMsg.Size = new System.Drawing.Size(336, 80);
            this.txtResponseMsg.TabIndex = 3;
            this.txtResponseMsg.Text = "";
            // 
            // lblResponseMsg
            // 
            this.lblResponseMsg.AllowParentOverrides = false;
            this.lblResponseMsg.AutoEllipsis = false;
            this.lblResponseMsg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblResponseMsg.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblResponseMsg.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblResponseMsg.Location = new System.Drawing.Point(418, 212);
            this.lblResponseMsg.Name = "lblResponseMsg";
            this.lblResponseMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResponseMsg.Size = new System.Drawing.Size(71, 21);
            this.lblResponseMsg.TabIndex = 8;
            this.lblResponseMsg.Text = "Respuesta";
            this.lblResponseMsg.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblResponseMsg.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtReceivedMsg
            // 
            this.txtReceivedMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceivedMsg.Location = new System.Drawing.Point(288, 124);
            this.txtReceivedMsg.Name = "txtReceivedMsg";
            this.txtReceivedMsg.Size = new System.Drawing.Size(336, 68);
            this.txtReceivedMsg.TabIndex = 2;
            this.txtReceivedMsg.Text = "";
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
            this.btnTrash.Location = new System.Drawing.Point(419, 330);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Rotation = 0;
            this.btnTrash.ShowActiveImage = true;
            this.btnTrash.ShowCursorChanges = true;
            this.btnTrash.ShowImageBorders = true;
            this.btnTrash.ShowSizeMarkers = false;
            this.btnTrash.Size = new System.Drawing.Size(32, 32);
            this.btnTrash.TabIndex = 4;
            this.btnTrash.ToolTipText = "";
            this.btnTrash.WaitOnLoad = false;
            this.btnTrash.Zoom = 10;
            this.btnTrash.ZoomSpeed = 10;
            this.btnTrash.Click += new System.EventHandler(this.btnTrash_Click);
            // 
            // btnSend
            // 
            this.btnSend.ActiveImage = null;
            this.btnSend.AllowAnimations = true;
            this.btnSend.AllowBuffering = false;
            this.btnSend.AllowToggling = false;
            this.btnSend.AllowZooming = true;
            this.btnSend.AllowZoomingOnFocus = false;
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSend.ErrorImage = global::LifeTracker.UI.Properties.Resources.save_32;
            this.btnSend.FadeWhenInactive = false;
            this.btnSend.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnSend.Image = global::LifeTracker.UI.Properties.Resources.save_32;
            this.btnSend.ImageActive = null;
            this.btnSend.ImageLocation = null;
            this.btnSend.ImageMargin = 10;
            this.btnSend.ImageSize = new System.Drawing.Size(22, 22);
            this.btnSend.ImageZoomSize = new System.Drawing.Size(32, 32);
            this.btnSend.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnSend.InitialImage")));
            this.btnSend.Location = new System.Drawing.Point(457, 330);
            this.btnSend.Name = "btnSend";
            this.btnSend.Rotation = 0;
            this.btnSend.ShowActiveImage = true;
            this.btnSend.ShowCursorChanges = true;
            this.btnSend.ShowImageBorders = true;
            this.btnSend.ShowSizeMarkers = false;
            this.btnSend.Size = new System.Drawing.Size(32, 32);
            this.btnSend.TabIndex = 5;
            this.btnSend.ToolTipText = "";
            this.btnSend.WaitOnLoad = false;
            this.btnSend.Zoom = 10;
            this.btnSend.ZoomSpeed = 10;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblReceivedMsg
            // 
            this.lblReceivedMsg.AllowParentOverrides = false;
            this.lblReceivedMsg.AutoEllipsis = false;
            this.lblReceivedMsg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblReceivedMsg.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblReceivedMsg.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblReceivedMsg.Location = new System.Drawing.Point(393, 97);
            this.lblReceivedMsg.Name = "lblReceivedMsg";
            this.lblReceivedMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReceivedMsg.Size = new System.Drawing.Size(122, 21);
            this.lblReceivedMsg.TabIndex = 7;
            this.lblReceivedMsg.Text = "Mensaje Recibido";
            this.lblReceivedMsg.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblReceivedMsg.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ddlSubject
            // 
            this.ddlSubject.BackColor = System.Drawing.Color.Transparent;
            this.ddlSubject.BackgroundColor = System.Drawing.Color.White;
            this.ddlSubject.BorderColor = System.Drawing.Color.Silver;
            this.ddlSubject.BorderRadius = 1;
            this.ddlSubject.Color = System.Drawing.Color.Silver;
            this.ddlSubject.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddlSubject.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddlSubject.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ddlSubject.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddlSubject.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ddlSubject.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ddlSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddlSubject.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ddlSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSubject.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddlSubject.FillDropDown = true;
            this.ddlSubject.FillIndicator = false;
            this.ddlSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlSubject.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ddlSubject.ForeColor = System.Drawing.Color.DarkGray;
            this.ddlSubject.FormattingEnabled = true;
            this.ddlSubject.Icon = null;
            this.ddlSubject.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddlSubject.IndicatorColor = System.Drawing.Color.Gray;
            this.ddlSubject.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddlSubject.ItemBackColor = System.Drawing.Color.White;
            this.ddlSubject.ItemBorderColor = System.Drawing.Color.White;
            this.ddlSubject.ItemForeColor = System.Drawing.Color.Black;
            this.ddlSubject.ItemHeight = 26;
            this.ddlSubject.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ddlSubject.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ddlSubject.ItemTopMargin = 3;
            this.ddlSubject.Location = new System.Drawing.Point(322, 46);
            this.ddlSubject.Name = "ddlSubject";
            this.ddlSubject.Size = new System.Drawing.Size(265, 32);
            this.ddlSubject.TabIndex = 1;
            this.ddlSubject.Text = "[ elige una opción ]";
            this.ddlSubject.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddlSubject.TextLeftMargin = 5;
            // 
            // lblSubject
            // 
            this.lblSubject.AllowParentOverrides = false;
            this.lblSubject.AutoEllipsis = false;
            this.lblSubject.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSubject.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubject.Location = new System.Drawing.Point(381, 19);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSubject.Size = new System.Drawing.Size(151, 21);
            this.lblSubject.TabIndex = 6;
            this.lblSubject.Text = "Motivo de la Consulta";
            this.lblSubject.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblSubject.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvMessages
            // 
            this.dgvMessages.AllowCustomTheming = false;
            this.dgvMessages.AllowUserToAddRows = false;
            this.dgvMessages.AllowUserToDeleteRows = false;
            this.dgvMessages.AllowUserToResizeColumns = false;
            this.dgvMessages.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvMessages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMessages.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMessages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMessages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMessages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMessages.ColumnHeadersHeight = 40;
            this.dgvMessages.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvMessages.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvMessages.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMessages.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvMessages.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMessages.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvMessages.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvMessages.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvMessages.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvMessages.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMessages.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvMessages.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMessages.CurrentTheme.Name = null;
            this.dgvMessages.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMessages.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvMessages.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMessages.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvMessages.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMessages.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMessages.EnableHeadersVisualStyles = false;
            this.dgvMessages.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvMessages.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvMessages.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvMessages.HeaderForeColor = System.Drawing.Color.White;
            this.dgvMessages.Location = new System.Drawing.Point(0, 0);
            this.dgvMessages.Margin = new System.Windows.Forms.Padding(10);
            this.dgvMessages.MultiSelect = false;
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMessages.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMessages.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dgvMessages.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMessages.RowTemplate.Height = 40;
            this.dgvMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMessages.ShowEditingIcon = false;
            this.dgvMessages.Size = new System.Drawing.Size(912, 501);
            this.dgvMessages.TabIndex = 9;
            this.dgvMessages.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvMessages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMessages_CellContentClick);
            // 
            // frmMessageProfessional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 642);
            this.Controls.Add(this.bunifuGradientPanel4);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMessageProfessional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel4;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.RichTextBox txtReceivedMsg;
        private Bunifu.UI.WinForms.BunifuImageButton btnTrash;
        private Bunifu.UI.WinForms.BunifuImageButton btnSend;
        private Bunifu.UI.WinForms.BunifuLabel lblReceivedMsg;
        private Bunifu.UI.WinForms.BunifuDropdown ddlSubject;
        private Bunifu.UI.WinForms.BunifuLabel lblSubject;
        private Bunifu.UI.WinForms.BunifuLabel lblUser;
        private System.Windows.Forms.RichTextBox txtResponseMsg;
        private Bunifu.UI.WinForms.BunifuLabel lblResponseMsg;
        private Bunifu.UI.WinForms.BunifuImageButton btnAllMessages;
        private Bunifu.UI.WinForms.BunifuLabel lblAllMessages;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvMessages;
    }
}