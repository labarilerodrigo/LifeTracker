
namespace LifeTracker.UI.Services
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.bunifuGradientPanel4 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.scTop = new System.Windows.Forms.SplitContainer();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.pieChartCanvas = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.doughnutChartCanvas = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.sc_barChart = new System.Windows.Forms.SplitContainer();
            this.barChartCanvas = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.verticalScrollBar = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.pieChart = new Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart(this.components);
            this.elipsePieChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.mealChart = new Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart(this.components);
            this.elipseDoughtnutChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBarChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.barChart = new Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart(this.components);
            this.bunifuGradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scTop)).BeginInit();
            this.scTop.Panel1.SuspendLayout();
            this.scTop.Panel2.SuspendLayout();
            this.scTop.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_barChart)).BeginInit();
            this.sc_barChart.Panel1.SuspendLayout();
            this.sc_barChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.BorderRadius = 1;
            this.bunifuGradientPanel4.Controls.Add(this.scMain);
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
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.IsSplitterFixed = true;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.scTop);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.panelBottom);
            this.scMain.Panel2.Padding = new System.Windows.Forms.Padding(20);
            this.scMain.Size = new System.Drawing.Size(912, 642);
            this.scMain.SplitterDistance = 290;
            this.scMain.TabIndex = 1;
            // 
            // scTop
            // 
            this.scTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scTop.IsSplitterFixed = true;
            this.scTop.Location = new System.Drawing.Point(0, 0);
            this.scTop.Name = "scTop";
            // 
            // scTop.Panel1
            // 
            this.scTop.Panel1.Controls.Add(this.panelTopLeft);
            this.scTop.Panel1.Padding = new System.Windows.Forms.Padding(20);
            // 
            // scTop.Panel2
            // 
            this.scTop.Panel2.Controls.Add(this.panelTopRight);
            this.scTop.Panel2.Margin = new System.Windows.Forms.Padding(20);
            this.scTop.Panel2.Padding = new System.Windows.Forms.Padding(20);
            this.scTop.Size = new System.Drawing.Size(912, 290);
            this.scTop.SplitterDistance = 456;
            this.scTop.TabIndex = 0;
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.AutoSize = true;
            this.panelTopLeft.Controls.Add(this.pieChartCanvas);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopLeft.Location = new System.Drawing.Point(20, 20);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Padding = new System.Windows.Forms.Padding(20);
            this.panelTopLeft.Size = new System.Drawing.Size(416, 250);
            this.panelTopLeft.TabIndex = 0;
            // 
            // pieChartCanvas
            // 
            this.pieChartCanvas.AnimationDuration = 1000;
            this.pieChartCanvas.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.pieChartCanvas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pieChartCanvas.CanvasPadding = new System.Windows.Forms.Padding(20);
            this.pieChartCanvas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pieChartCanvas.Labels = new string[] {
        "Grasas",
        "Proteínas",
        "Calorías"};
            this.pieChartCanvas.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.pieChartCanvas.LegendDisplay = true;
            this.pieChartCanvas.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieChartCanvas.LegendForeColor = System.Drawing.Color.DarkGray;
            this.pieChartCanvas.LegendFullWidth = true;
            this.pieChartCanvas.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.right;
            this.pieChartCanvas.LegendRevese = false;
            this.pieChartCanvas.LegendRTL = false;
            this.pieChartCanvas.Location = new System.Drawing.Point(20, 32);
            this.pieChartCanvas.Name = "pieChartCanvas";
            this.pieChartCanvas.Padding = new System.Windows.Forms.Padding(20);
            this.pieChartCanvas.ShowXAxis = false;
            this.pieChartCanvas.ShowYAxis = false;
            this.pieChartCanvas.Size = new System.Drawing.Size(376, 198);
            this.pieChartCanvas.TabIndex = 3;
            this.pieChartCanvas.Title = "";
            this.pieChartCanvas.TitleLineHeight = 1.2D;
            this.pieChartCanvas.TitlePadding = 10;
            this.pieChartCanvas.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.pieChartCanvas.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pieChartCanvas.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pieChartCanvas.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.pieChartCanvas.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.pieChartCanvas.TooltipsEnabled = true;
            this.pieChartCanvas.XAxesBeginAtZero = true;
            this.pieChartCanvas.XAxesDrawTicks = true;
            this.pieChartCanvas.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pieChartCanvas.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.pieChartCanvas.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pieChartCanvas.XAxesGridLines = false;
            this.pieChartCanvas.XAxesLabel = "";
            this.pieChartCanvas.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pieChartCanvas.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.pieChartCanvas.XAxesLineWidth = 1;
            this.pieChartCanvas.XAxesStacked = false;
            this.pieChartCanvas.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pieChartCanvas.XAxesZeroLineWidth = 1;
            this.pieChartCanvas.YAxesBeginAtZero = true;
            this.pieChartCanvas.YAxesDrawTicks = true;
            this.pieChartCanvas.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pieChartCanvas.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.pieChartCanvas.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pieChartCanvas.YAxesGridLines = false;
            this.pieChartCanvas.YAxesLabel = "";
            this.pieChartCanvas.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pieChartCanvas.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.pieChartCanvas.YAxesLineWidth = 1;
            this.pieChartCanvas.YAxesStacked = false;
            this.pieChartCanvas.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pieChartCanvas.YAxesZeroLineWidth = 1;
            // 
            // panelTopRight
            // 
            this.panelTopRight.AutoSize = true;
            this.panelTopRight.Controls.Add(this.doughnutChartCanvas);
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopRight.Location = new System.Drawing.Point(20, 20);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Padding = new System.Windows.Forms.Padding(20);
            this.panelTopRight.Size = new System.Drawing.Size(412, 250);
            this.panelTopRight.TabIndex = 1;
            // 
            // doughnutChartCanvas
            // 
            this.doughnutChartCanvas.AnimationDuration = 1000;
            this.doughnutChartCanvas.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.doughnutChartCanvas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.doughnutChartCanvas.CanvasPadding = new System.Windows.Forms.Padding(20);
            this.doughnutChartCanvas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.doughnutChartCanvas.Labels = new string[] {
        "Desayuno",
        "Almuerzo",
        "Merienda",
        "Cena"};
            this.doughnutChartCanvas.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.doughnutChartCanvas.LegendDisplay = true;
            this.doughnutChartCanvas.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doughnutChartCanvas.LegendForeColor = System.Drawing.Color.DarkGray;
            this.doughnutChartCanvas.LegendFullWidth = true;
            this.doughnutChartCanvas.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.left;
            this.doughnutChartCanvas.LegendRevese = false;
            this.doughnutChartCanvas.LegendRTL = false;
            this.doughnutChartCanvas.Location = new System.Drawing.Point(20, 32);
            this.doughnutChartCanvas.Name = "doughnutChartCanvas";
            this.doughnutChartCanvas.Padding = new System.Windows.Forms.Padding(20);
            this.doughnutChartCanvas.ShowXAxis = false;
            this.doughnutChartCanvas.ShowYAxis = false;
            this.doughnutChartCanvas.Size = new System.Drawing.Size(372, 198);
            this.doughnutChartCanvas.TabIndex = 4;
            this.doughnutChartCanvas.Title = "";
            this.doughnutChartCanvas.TitleLineHeight = 1.2D;
            this.doughnutChartCanvas.TitlePadding = 10;
            this.doughnutChartCanvas.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.doughnutChartCanvas.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.doughnutChartCanvas.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.doughnutChartCanvas.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.doughnutChartCanvas.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.doughnutChartCanvas.TooltipsEnabled = true;
            this.doughnutChartCanvas.XAxesBeginAtZero = true;
            this.doughnutChartCanvas.XAxesDrawTicks = true;
            this.doughnutChartCanvas.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.doughnutChartCanvas.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.doughnutChartCanvas.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.doughnutChartCanvas.XAxesGridLines = false;
            this.doughnutChartCanvas.XAxesLabel = "";
            this.doughnutChartCanvas.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.doughnutChartCanvas.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.doughnutChartCanvas.XAxesLineWidth = 1;
            this.doughnutChartCanvas.XAxesStacked = false;
            this.doughnutChartCanvas.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.doughnutChartCanvas.XAxesZeroLineWidth = 1;
            this.doughnutChartCanvas.YAxesBeginAtZero = true;
            this.doughnutChartCanvas.YAxesDrawTicks = true;
            this.doughnutChartCanvas.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.doughnutChartCanvas.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.doughnutChartCanvas.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.doughnutChartCanvas.YAxesGridLines = false;
            this.doughnutChartCanvas.YAxesLabel = "";
            this.doughnutChartCanvas.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.doughnutChartCanvas.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.doughnutChartCanvas.YAxesLineWidth = 1;
            this.doughnutChartCanvas.YAxesStacked = false;
            this.doughnutChartCanvas.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.doughnutChartCanvas.YAxesZeroLineWidth = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.AutoSize = true;
            this.panelBottom.Controls.Add(this.sc_barChart);
            this.panelBottom.Controls.Add(this.verticalScrollBar);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(20, 20);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(20);
            this.panelBottom.Size = new System.Drawing.Size(872, 308);
            this.panelBottom.TabIndex = 2;
            // 
            // sc_barChart
            // 
            this.sc_barChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_barChart.IsSplitterFixed = true;
            this.sc_barChart.Location = new System.Drawing.Point(20, 20);
            this.sc_barChart.Name = "sc_barChart";
            // 
            // sc_barChart.Panel1
            // 
            this.sc_barChart.Panel1.Controls.Add(this.barChartCanvas);
            this.sc_barChart.Size = new System.Drawing.Size(832, 268);
            this.sc_barChart.SplitterDistance = 795;
            this.sc_barChart.TabIndex = 6;
            // 
            // barChartCanvas
            // 
            this.barChartCanvas.AnimationDuration = 1000;
            this.barChartCanvas.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.barChartCanvas.AutoSize = true;
            this.barChartCanvas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.barChartCanvas.CanvasPadding = new System.Windows.Forms.Padding(0, 0, 0, 250);
            this.barChartCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barChartCanvas.Labels = new string[] {
        "Mar",
        "Miér",
        "Juev",
        "Vier",
        "Sáb",
        "Dom",
        "Lun"};
            this.barChartCanvas.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.barChartCanvas.LegendDisplay = true;
            this.barChartCanvas.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barChartCanvas.LegendForeColor = System.Drawing.Color.DarkGray;
            this.barChartCanvas.LegendFullWidth = true;
            this.barChartCanvas.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.barChartCanvas.LegendRevese = false;
            this.barChartCanvas.LegendRTL = false;
            this.barChartCanvas.Location = new System.Drawing.Point(0, 0);
            this.barChartCanvas.Margin = new System.Windows.Forms.Padding(0);
            this.barChartCanvas.Name = "barChartCanvas";
            this.barChartCanvas.ShowXAxis = false;
            this.barChartCanvas.ShowYAxis = false;
            this.barChartCanvas.Size = new System.Drawing.Size(795, 268);
            this.barChartCanvas.TabIndex = 5;
            this.barChartCanvas.Title = "";
            this.barChartCanvas.TitleLineHeight = 0D;
            this.barChartCanvas.TitlePadding = 10;
            this.barChartCanvas.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.barChartCanvas.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.barChartCanvas.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.barChartCanvas.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.barChartCanvas.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.barChartCanvas.TooltipsEnabled = true;
            this.barChartCanvas.XAxesBeginAtZero = true;
            this.barChartCanvas.XAxesDrawTicks = true;
            this.barChartCanvas.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.barChartCanvas.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.barChartCanvas.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.barChartCanvas.XAxesGridLines = false;
            this.barChartCanvas.XAxesLabel = "";
            this.barChartCanvas.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.barChartCanvas.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.barChartCanvas.XAxesLineWidth = 1;
            this.barChartCanvas.XAxesStacked = false;
            this.barChartCanvas.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.barChartCanvas.XAxesZeroLineWidth = 1;
            this.barChartCanvas.YAxesBeginAtZero = true;
            this.barChartCanvas.YAxesDrawTicks = true;
            this.barChartCanvas.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.barChartCanvas.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.barChartCanvas.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.barChartCanvas.YAxesGridLines = false;
            this.barChartCanvas.YAxesLabel = "";
            this.barChartCanvas.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.barChartCanvas.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.barChartCanvas.YAxesLineWidth = 1;
            this.barChartCanvas.YAxesStacked = false;
            this.barChartCanvas.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.barChartCanvas.YAxesZeroLineWidth = 1;
            // 
            // verticalScrollBar
            // 
            this.verticalScrollBar.AllowCursorChanges = true;
            this.verticalScrollBar.AllowHomeEndKeysDetection = false;
            this.verticalScrollBar.AllowIncrementalClickMoves = true;
            this.verticalScrollBar.AllowMouseDownEffects = true;
            this.verticalScrollBar.AllowMouseHoverEffects = true;
            this.verticalScrollBar.AllowScrollingAnimations = true;
            this.verticalScrollBar.AllowScrollKeysDetection = true;
            this.verticalScrollBar.AllowScrollOptionsMenu = true;
            this.verticalScrollBar.AllowShrinkingOnFocusLost = false;
            this.verticalScrollBar.BackgroundColor = System.Drawing.Color.Silver;
            this.verticalScrollBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("verticalScrollBar.BackgroundImage")));
            this.verticalScrollBar.BindingContainer = this.panelBottom;
            this.verticalScrollBar.BorderColor = System.Drawing.Color.Silver;
            this.verticalScrollBar.BorderRadius = 14;
            this.verticalScrollBar.BorderThickness = 1;
            this.verticalScrollBar.DurationBeforeShrink = 2000;
            this.verticalScrollBar.LargeChange = 10;
            this.verticalScrollBar.Location = new System.Drawing.Point(855, 3);
            this.verticalScrollBar.Maximum = 100;
            this.verticalScrollBar.Minimum = 0;
            this.verticalScrollBar.MinimumThumbLength = 18;
            this.verticalScrollBar.Name = "verticalScrollBar";
            this.verticalScrollBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.verticalScrollBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.verticalScrollBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.verticalScrollBar.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.verticalScrollBar.ScrollBarColor = System.Drawing.Color.Silver;
            this.verticalScrollBar.ShrinkSizeLimit = 3;
            this.verticalScrollBar.Size = new System.Drawing.Size(14, 314);
            this.verticalScrollBar.SmallChange = 1;
            this.verticalScrollBar.TabIndex = 5;
            this.verticalScrollBar.ThumbColor = System.Drawing.Color.Gray;
            this.verticalScrollBar.ThumbLength = 30;
            this.verticalScrollBar.ThumbMargin = 1;
            this.verticalScrollBar.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.verticalScrollBar.Value = 0;
            // 
            // pieChart
            // 
            this.pieChart.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("pieChart.BackgroundColor")));
            this.pieChart.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("pieChart.BorderColor")));
            this.pieChart.BorderWidth = 0;
            this.pieChart.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("pieChart.Data")));
            this.pieChart.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.pieChart.HoverBorderColor = System.Drawing.Color.Empty;
            this.pieChart.HoverBorderWidth = 0;
            this.pieChart.Label = "";
            this.pieChart.TargetCanvas = this.pieChartCanvas;
            // 
            // elipsePieChart
            // 
            this.elipsePieChart.ElipseRadius = 50;
            this.elipsePieChart.TargetControl = this.pieChartCanvas;
            // 
            // mealChart
            // 
            this.mealChart.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("mealChart.BackgroundColor")));
            this.mealChart.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("mealChart.BorderColor")));
            this.mealChart.BorderWidth = 0;
            this.mealChart.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("mealChart.Data")));
            this.mealChart.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.mealChart.HoverBorderColor = System.Drawing.Color.Empty;
            this.mealChart.HoverBorderWidth = 0;
            this.mealChart.Label = "";
            this.mealChart.TargetCanvas = this.doughnutChartCanvas;
            // 
            // elipseDoughtnutChart
            // 
            this.elipseDoughtnutChart.ElipseRadius = 50;
            this.elipseDoughtnutChart.TargetControl = this.doughnutChartCanvas;
            // 
            // elipseBarChart
            // 
            this.elipseBarChart.ElipseRadius = 50;
            this.elipseBarChart.TargetControl = this;
            // 
            // barChart
            // 
            this.barChart.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("barChart.BackgroundColor")));
            this.barChart.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("barChart.BorderColor")));
            this.barChart.BorderSkipped = null;
            this.barChart.BorderWidth = 0;
            this.barChart.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("barChart.Data")));
            this.barChart.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.barChart.HoverBorderColor = System.Drawing.Color.Empty;
            this.barChart.HoverBorderWidth = 0;
            this.barChart.Label = "Calorías";
            this.barChart.TargetCanvas = this.barChartCanvas;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 642);
            this.Controls.Add(this.bunifuGradientPanel4);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scTop.Panel1.ResumeLayout(false);
            this.scTop.Panel1.PerformLayout();
            this.scTop.Panel2.ResumeLayout(false);
            this.scTop.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scTop)).EndInit();
            this.scTop.ResumeLayout(false);
            this.panelTopLeft.ResumeLayout(false);
            this.panelTopRight.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.sc_barChart.Panel1.ResumeLayout(false);
            this.sc_barChart.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_barChart)).EndInit();
            this.sc_barChart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel4;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart pieChart;
        private Bunifu.Framework.UI.BunifuElipse elipsePieChart;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart mealChart;
        private System.Windows.Forms.SplitContainer scMain;
        private Bunifu.Framework.UI.BunifuElipse elipseDoughtnutChart;
        private System.Windows.Forms.SplitContainer scTop;
        private System.Windows.Forms.Panel panelTopRight;
        private Bunifu.Charts.WinForms.BunifuChartCanvas doughnutChartCanvas;
        private System.Windows.Forms.Panel panelTopLeft;
        private Bunifu.Charts.WinForms.BunifuChartCanvas pieChartCanvas;
        private System.Windows.Forms.Panel panelBottom;
        private Bunifu.Framework.UI.BunifuElipse elipseBarChart;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart barChart;
        private Bunifu.UI.WinForms.BunifuVScrollBar verticalScrollBar;
        private System.Windows.Forms.SplitContainer sc_barChart;
        private Bunifu.Charts.WinForms.BunifuChartCanvas barChartCanvas;
    }
}