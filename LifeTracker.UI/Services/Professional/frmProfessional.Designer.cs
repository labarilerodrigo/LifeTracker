
namespace LifeTracker.UI.Services
{
    partial class frmProfessional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfessional));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtNutMsg = new System.Windows.Forms.RichTextBox();
            this.btnNutTrash = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnButSend = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblNutMessage = new Bunifu.UI.WinForms.BunifuLabel();
            this.ddlSubject = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblNutSubject = new Bunifu.UI.WinForms.BunifuLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblPersonalTrainer = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblNutrition = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblUser = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnPersonalTrainer = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnNutrition = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.scMain.Panel1.Controls.Add(this.bunifuPanel2);
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
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.txtNutMsg);
            this.bunifuPanel2.Controls.Add(this.btnNutTrash);
            this.bunifuPanel2.Controls.Add(this.btnButSend);
            this.bunifuPanel2.Controls.Add(this.lblNutMessage);
            this.bunifuPanel2.Controls.Add(this.ddlSubject);
            this.bunifuPanel2.Controls.Add(this.lblNutSubject);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel2.Location = new System.Drawing.Point(10, 10);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(892, 452);
            this.bunifuPanel2.TabIndex = 3;
            // 
            // txtNutMsg
            // 
            this.txtNutMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNutMsg.Location = new System.Drawing.Point(272, 126);
            this.txtNutMsg.Name = "txtNutMsg";
            this.txtNutMsg.Size = new System.Drawing.Size(336, 117);
            this.txtNutMsg.TabIndex = 55;
            this.txtNutMsg.Text = "";
            // 
            // btnNutTrash
            // 
            this.btnNutTrash.ActiveImage = null;
            this.btnNutTrash.AllowAnimations = true;
            this.btnNutTrash.AllowBuffering = false;
            this.btnNutTrash.AllowToggling = false;
            this.btnNutTrash.AllowZooming = true;
            this.btnNutTrash.AllowZoomingOnFocus = false;
            this.btnNutTrash.BackColor = System.Drawing.Color.Transparent;
            this.btnNutTrash.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNutTrash.ErrorImage = global::LifeTracker.UI.Properties.Resources.save_32;
            this.btnNutTrash.FadeWhenInactive = false;
            this.btnNutTrash.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnNutTrash.Image = global::LifeTracker.UI.Properties.Resources.delete_32;
            this.btnNutTrash.ImageActive = null;
            this.btnNutTrash.ImageLocation = null;
            this.btnNutTrash.ImageMargin = 10;
            this.btnNutTrash.ImageSize = new System.Drawing.Size(22, 22);
            this.btnNutTrash.ImageZoomSize = new System.Drawing.Size(32, 32);
            this.btnNutTrash.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnNutTrash.InitialImage")));
            this.btnNutTrash.Location = new System.Drawing.Point(403, 249);
            this.btnNutTrash.Name = "btnNutTrash";
            this.btnNutTrash.Rotation = 0;
            this.btnNutTrash.ShowActiveImage = true;
            this.btnNutTrash.ShowCursorChanges = true;
            this.btnNutTrash.ShowImageBorders = true;
            this.btnNutTrash.ShowSizeMarkers = false;
            this.btnNutTrash.Size = new System.Drawing.Size(32, 32);
            this.btnNutTrash.TabIndex = 54;
            this.btnNutTrash.ToolTipText = "";
            this.btnNutTrash.WaitOnLoad = false;
            this.btnNutTrash.Zoom = 10;
            this.btnNutTrash.ZoomSpeed = 10;
            this.btnNutTrash.Click += new System.EventHandler(this.btnNutTrash_Click);
            // 
            // btnButSend
            // 
            this.btnButSend.ActiveImage = null;
            this.btnButSend.AllowAnimations = true;
            this.btnButSend.AllowBuffering = false;
            this.btnButSend.AllowToggling = false;
            this.btnButSend.AllowZooming = true;
            this.btnButSend.AllowZoomingOnFocus = false;
            this.btnButSend.BackColor = System.Drawing.Color.Transparent;
            this.btnButSend.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnButSend.ErrorImage = global::LifeTracker.UI.Properties.Resources.save_32;
            this.btnButSend.FadeWhenInactive = false;
            this.btnButSend.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnButSend.Image = global::LifeTracker.UI.Properties.Resources.save_32;
            this.btnButSend.ImageActive = null;
            this.btnButSend.ImageLocation = null;
            this.btnButSend.ImageMargin = 10;
            this.btnButSend.ImageSize = new System.Drawing.Size(22, 22);
            this.btnButSend.ImageZoomSize = new System.Drawing.Size(32, 32);
            this.btnButSend.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnButSend.InitialImage")));
            this.btnButSend.Location = new System.Drawing.Point(441, 249);
            this.btnButSend.Name = "btnButSend";
            this.btnButSend.Rotation = 0;
            this.btnButSend.ShowActiveImage = true;
            this.btnButSend.ShowCursorChanges = true;
            this.btnButSend.ShowImageBorders = true;
            this.btnButSend.ShowSizeMarkers = false;
            this.btnButSend.Size = new System.Drawing.Size(32, 32);
            this.btnButSend.TabIndex = 53;
            this.btnButSend.ToolTipText = "";
            this.btnButSend.WaitOnLoad = false;
            this.btnButSend.Zoom = 10;
            this.btnButSend.ZoomSpeed = 10;
            this.btnButSend.Click += new System.EventHandler(this.btnButSend_Click);
            // 
            // lblNutMessage
            // 
            this.lblNutMessage.AllowParentOverrides = false;
            this.lblNutMessage.AutoEllipsis = false;
            this.lblNutMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNutMessage.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNutMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNutMessage.Location = new System.Drawing.Point(409, 99);
            this.lblNutMessage.Name = "lblNutMessage";
            this.lblNutMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNutMessage.Size = new System.Drawing.Size(58, 21);
            this.lblNutMessage.TabIndex = 47;
            this.lblNutMessage.Text = "Mensaje";
            this.lblNutMessage.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNutMessage.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.ddlSubject.Location = new System.Drawing.Point(306, 48);
            this.ddlSubject.Name = "ddlSubject";
            this.ddlSubject.Size = new System.Drawing.Size(265, 32);
            this.ddlSubject.TabIndex = 1;
            this.ddlSubject.Text = "[ elige una opción ]";
            this.ddlSubject.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddlSubject.TextLeftMargin = 5;
            // 
            // lblNutSubject
            // 
            this.lblNutSubject.AllowParentOverrides = false;
            this.lblNutSubject.AutoEllipsis = false;
            this.lblNutSubject.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNutSubject.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNutSubject.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNutSubject.Location = new System.Drawing.Point(362, 21);
            this.lblNutSubject.Name = "lblNutSubject";
            this.lblNutSubject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNutSubject.Size = new System.Drawing.Size(151, 21);
            this.lblNutSubject.TabIndex = 43;
            this.lblNutSubject.Text = "Motivo de la Consulta";
            this.lblNutSubject.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNutSubject.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(10, 2);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(892, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lblPersonalTrainer);
            this.bunifuPanel1.Controls.Add(this.lblNutrition);
            this.bunifuPanel1.Controls.Add(this.lblUser);
            this.bunifuPanel1.Controls.Add(this.btnPersonalTrainer);
            this.bunifuPanel1.Controls.Add(this.btnNutrition);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(912, 132);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // lblPersonalTrainer
            // 
            this.lblPersonalTrainer.AllowParentOverrides = false;
            this.lblPersonalTrainer.AutoEllipsis = false;
            this.lblPersonalTrainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPersonalTrainer.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPersonalTrainer.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPersonalTrainer.Location = new System.Drawing.Point(131, 104);
            this.lblPersonalTrainer.Name = "lblPersonalTrainer";
            this.lblPersonalTrainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPersonalTrainer.Size = new System.Drawing.Size(83, 13);
            this.lblPersonalTrainer.TabIndex = 49;
            this.lblPersonalTrainer.Text = "Personal Trainer";
            this.lblPersonalTrainer.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPersonalTrainer.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblNutrition
            // 
            this.lblNutrition.AllowParentOverrides = false;
            this.lblNutrition.AutoEllipsis = false;
            this.lblNutrition.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNutrition.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNutrition.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNutrition.Location = new System.Drawing.Point(38, 104);
            this.lblNutrition.Name = "lblNutrition";
            this.lblNutrition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNutrition.Size = new System.Drawing.Size(66, 13);
            this.lblNutrition.TabIndex = 47;
            this.lblNutrition.Text = "Nutricionista";
            this.lblNutrition.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNutrition.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.lblUser.Size = new System.Drawing.Size(156, 23);
            this.lblUser.TabIndex = 43;
            this.lblUser.Text = "Consulta Profesional";
            this.lblUser.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblUser.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnPersonalTrainer
            // 
            this.btnPersonalTrainer.ActiveImage = null;
            this.btnPersonalTrainer.AllowAnimations = true;
            this.btnPersonalTrainer.AllowBuffering = false;
            this.btnPersonalTrainer.AllowToggling = false;
            this.btnPersonalTrainer.AllowZooming = true;
            this.btnPersonalTrainer.AllowZoomingOnFocus = false;
            this.btnPersonalTrainer.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonalTrainer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPersonalTrainer.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPersonalTrainer.ErrorImage")));
            this.btnPersonalTrainer.FadeWhenInactive = false;
            this.btnPersonalTrainer.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPersonalTrainer.Image = global::LifeTracker.UI.Properties.Resources.personal_trainer_50;
            this.btnPersonalTrainer.ImageActive = null;
            this.btnPersonalTrainer.ImageLocation = null;
            this.btnPersonalTrainer.ImageMargin = 10;
            this.btnPersonalTrainer.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPersonalTrainer.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btnPersonalTrainer.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPersonalTrainer.InitialImage")));
            this.btnPersonalTrainer.Location = new System.Drawing.Point(145, 48);
            this.btnPersonalTrainer.Name = "btnPersonalTrainer";
            this.btnPersonalTrainer.Rotation = 0;
            this.btnPersonalTrainer.ShowActiveImage = true;
            this.btnPersonalTrainer.ShowCursorChanges = true;
            this.btnPersonalTrainer.ShowImageBorders = true;
            this.btnPersonalTrainer.ShowSizeMarkers = false;
            this.btnPersonalTrainer.Size = new System.Drawing.Size(50, 50);
            this.btnPersonalTrainer.TabIndex = 48;
            this.btnPersonalTrainer.ToolTipText = "";
            this.btnPersonalTrainer.WaitOnLoad = false;
            this.btnPersonalTrainer.Zoom = 10;
            this.btnPersonalTrainer.ZoomSpeed = 10;
            this.btnPersonalTrainer.Click += new System.EventHandler(this.btnPersonalTrainer_Click);
            // 
            // btnNutrition
            // 
            this.btnNutrition.ActiveImage = null;
            this.btnNutrition.AllowAnimations = true;
            this.btnNutrition.AllowBuffering = false;
            this.btnNutrition.AllowToggling = false;
            this.btnNutrition.AllowZooming = true;
            this.btnNutrition.AllowZoomingOnFocus = false;
            this.btnNutrition.BackColor = System.Drawing.Color.Transparent;
            this.btnNutrition.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNutrition.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnNutrition.ErrorImage")));
            this.btnNutrition.FadeWhenInactive = false;
            this.btnNutrition.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnNutrition.Image = global::LifeTracker.UI.Properties.Resources.nutritionist1_50;
            this.btnNutrition.ImageActive = null;
            this.btnNutrition.ImageLocation = null;
            this.btnNutrition.ImageMargin = 10;
            this.btnNutrition.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNutrition.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btnNutrition.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnNutrition.InitialImage")));
            this.btnNutrition.Location = new System.Drawing.Point(47, 48);
            this.btnNutrition.Name = "btnNutrition";
            this.btnNutrition.Rotation = 0;
            this.btnNutrition.ShowActiveImage = true;
            this.btnNutrition.ShowCursorChanges = true;
            this.btnNutrition.ShowImageBorders = true;
            this.btnNutrition.ShowSizeMarkers = false;
            this.btnNutrition.Size = new System.Drawing.Size(50, 50);
            this.btnNutrition.TabIndex = 46;
            this.btnNutrition.ToolTipText = "";
            this.btnNutrition.WaitOnLoad = false;
            this.btnNutrition.Zoom = 10;
            this.btnNutrition.ZoomSpeed = 10;
            this.btnNutrition.Click += new System.EventHandler(this.btnNutrition_Click);
            // 
            // frmProfessional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 642);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.bunifuPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfessional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel lblPersonalTrainer;
        private Bunifu.UI.WinForms.BunifuLabel lblNutrition;
        private Bunifu.UI.WinForms.BunifuLabel lblUser;
        private Bunifu.UI.WinForms.BunifuImageButton btnPersonalTrainer;
        private Bunifu.UI.WinForms.BunifuImageButton btnNutrition;
        private System.Windows.Forms.SplitContainer scMain;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuImageButton btnButSend;
        private Bunifu.UI.WinForms.BunifuImageButton btnNutTrash;
        private Bunifu.UI.WinForms.BunifuLabel lblNutMessage;
        private Bunifu.UI.WinForms.BunifuDropdown ddlSubject;
        private Bunifu.UI.WinForms.BunifuLabel lblNutSubject;
        private System.Windows.Forms.RichTextBox txtNutMsg;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}