using FYP_Project.GMapExtensions;
using GMap.NET.WindowsForms;

namespace FYP_Project.Forms
{
    partial class MainForm
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
            this.splitter1 = new BSE.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainMap = new GMap.NET.WindowsForms.GMapControl();
            this.panelExtra = new BSE.Windows.Forms.Panel();
            this.xPanderPanelList2 = new BSE.Windows.Forms.XPanderPanelList();
            this.xPanderPanel2 = new BSE.Windows.Forms.XPanderPanel();
            this.valveReplacementDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxValveReplaced = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.extraErrorLbl = new System.Windows.Forms.Label();
            this.extraCancelBtn = new System.Windows.Forms.Button();
            this.extraUpdateBtn = new System.Windows.Forms.Button();
            this.textBoxWellDepth = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxWaterLevel = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxNumPeople = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxVillage = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxDistrict = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.panelMenu = new BSE.Windows.Forms.Panel();
            this.xPanderPanelList1 = new BSE.Windows.Forms.XPanderPanelList();
            this.xPanderPanelMain = new BSE.Windows.Forms.XPanderPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.markersGroupBox = new System.Windows.Forms.GroupBox();
            this.zoomCenterBtn = new System.Windows.Forms.Button();
            this.checkBoxPlacemarkInfo = new System.Windows.Forms.CheckBox();
            this.clearMarkersBtn = new System.Windows.Forms.Button();
            this.addMarkerBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxGeo = new System.Windows.Forms.TextBox();
            this.reloadMapBtn = new System.Windows.Forms.Button();
            this.goToBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLng = new System.Windows.Forms.TextBox();
            this.textBoxLat = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxMapType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonZoomUp = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonZoomDown = new System.Windows.Forms.Button();
            this.xPanderPanelCache = new BSE.Windows.Forms.XPanderPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxCacheSize = new System.Windows.Forms.TextBox();
            this.textBoxCacheStatus = new System.Windows.Forms.TextBox();
            this.cacheImportBtn = new System.Windows.Forms.Button();
            this.textBoxMemory = new System.Windows.Forms.TextBox();
            this.checkBoxUseInfoCache = new System.Windows.Forms.CheckBox();
            this.cacheExportBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.clearTilesInCacheBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.opencacheLocationBtn = new System.Windows.Forms.Button();
            this.xPanderPanelInfo = new BSE.Windows.Forms.XPanderPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxZoomCurrent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxLngCurrent = new System.Windows.Forms.TextBox();
            this.textBoxMarkerCount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLatCurrent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.checkBoxDebug = new System.Windows.Forms.CheckBox();
            this.button12 = new System.Windows.Forms.Button();
            this.checkBoxCanDrag = new System.Windows.Forms.CheckBox();
            this.checkBoxCurrentMarker = new System.Windows.Forms.CheckBox();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelExtra.SuspendLayout();
            this.xPanderPanelList2.SuspendLayout();
            this.xPanderPanel2.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.xPanderPanelList1.SuspendLayout();
            this.xPanderPanelMain.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.markersGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.xPanderPanelCache.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.xPanderPanelInfo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Transparent;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(1185, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.MinExtra = 390;
            this.splitter1.MinSize = 390;
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 734);
            this.splitter1.TabIndex = 42;
            this.splitter1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panelExtra);
            this.panel4.Controls.Add(this.panelMenu);
            this.panel4.Controls.Add(this.splitter1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1188, 734);
            this.panel4.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MainMap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(305, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 734);
            this.panel2.TabIndex = 50;
            // 
            // MainMap
            // 
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.MainMap.ForeColor = System.Drawing.Color.Blue;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.Location = new System.Drawing.Point(0, 0);
            this.MainMap.Margin = new System.Windows.Forms.Padding(4);
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 17;
            this.MainMap.MinZoom = 2;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainMap.RoutesEnabled = true;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Size = new System.Drawing.Size(575, 734);
            this.MainMap.TabIndex = 0;
            this.MainMap.Zoom = 0D;
            // 
            // panelExtra
            // 
            this.panelExtra.AssociatedSplitter = this.splitter1;
            this.panelExtra.BackColor = System.Drawing.Color.Transparent;
            this.panelExtra.CaptionFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelExtra.CaptionHeight = 27;
            this.panelExtra.Controls.Add(this.xPanderPanelList2);
            this.panelExtra.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panelExtra.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panelExtra.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panelExtra.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelExtra.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panelExtra.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelExtra.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelExtra.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelExtra.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.panelExtra.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.panelExtra.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panelExtra.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelExtra.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.panelExtra.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelExtra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelExtra.Image = null;
            this.panelExtra.Location = new System.Drawing.Point(0, 0);
            this.panelExtra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelExtra.MinimumSize = new System.Drawing.Size(27, 27);
            this.panelExtra.Name = "panelExtra";
            this.panelExtra.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.panelExtra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelExtra.ShowExpandIcon = true;
            this.panelExtra.Size = new System.Drawing.Size(305, 734);
            this.panelExtra.TabIndex = 48;
            this.panelExtra.Text = "Extra Information";
            this.panelExtra.ToolTipTextCloseIcon = null;
            this.panelExtra.ToolTipTextExpandIconPanelCollapsed = "maximize";
            this.panelExtra.ToolTipTextExpandIconPanelExpanded = "minimize";
            // 
            // xPanderPanelList2
            // 
            this.xPanderPanelList2.CaptionStyle = BSE.Windows.Forms.CaptionStyle.Flat;
            this.xPanderPanelList2.Controls.Add(this.xPanderPanel2);
            this.xPanderPanelList2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanderPanelList2.GradientBackground = System.Drawing.Color.Empty;
            this.xPanderPanelList2.Location = new System.Drawing.Point(0, 28);
            this.xPanderPanelList2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xPanderPanelList2.Name = "xPanderPanelList2";
            this.xPanderPanelList2.PanelColors = null;
            this.xPanderPanelList2.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.xPanderPanelList2.ShowExpandIcon = true;
            this.xPanderPanelList2.Size = new System.Drawing.Size(305, 705);
            this.xPanderPanelList2.TabIndex = 0;
            this.xPanderPanelList2.Text = "xPanderPanelList2";
            // 
            // xPanderPanel2
            // 
            this.xPanderPanel2.CaptionFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xPanderPanel2.Controls.Add(this.valveReplacementDatePicker);
            this.xPanderPanel2.Controls.Add(this.label21);
            this.xPanderPanel2.Controls.Add(this.textBoxValveReplaced);
            this.xPanderPanel2.Controls.Add(this.label20);
            this.xPanderPanel2.Controls.Add(this.extraErrorLbl);
            this.xPanderPanel2.Controls.Add(this.extraCancelBtn);
            this.xPanderPanel2.Controls.Add(this.extraUpdateBtn);
            this.xPanderPanel2.Controls.Add(this.textBoxWellDepth);
            this.xPanderPanel2.Controls.Add(this.label19);
            this.xPanderPanel2.Controls.Add(this.textBoxWaterLevel);
            this.xPanderPanel2.Controls.Add(this.label18);
            this.xPanderPanel2.Controls.Add(this.textBoxNumPeople);
            this.xPanderPanel2.Controls.Add(this.label17);
            this.xPanderPanel2.Controls.Add(this.textBoxVillage);
            this.xPanderPanel2.Controls.Add(this.label16);
            this.xPanderPanel2.Controls.Add(this.textBoxArea);
            this.xPanderPanel2.Controls.Add(this.label15);
            this.xPanderPanel2.Controls.Add(this.textBoxDistrict);
            this.xPanderPanel2.Controls.Add(this.label12);
            this.xPanderPanel2.Controls.Add(this.label3);
            this.xPanderPanel2.Controls.Add(this.textBoxDescription);
            this.xPanderPanel2.CustomColors.BackColor = System.Drawing.SystemColors.Control;
            this.xPanderPanel2.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.xPanderPanel2.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.Empty;
            this.xPanderPanel2.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.Empty;
            this.xPanderPanel2.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.Empty;
            this.xPanderPanel2.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel2.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel2.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xPanderPanel2.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.xPanderPanel2.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xPanderPanel2.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanel2.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanel2.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanel2.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanel2.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanel2.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanel2.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel2.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel2.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xPanderPanel2.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xPanderPanel2.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.xPanderPanel2.Expand = true;
            this.xPanderPanel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel2.Image = null;
            this.xPanderPanel2.IsClosable = false;
            this.xPanderPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xPanderPanel2.Name = "xPanderPanel2";
            this.xPanderPanel2.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.xPanderPanel2.Size = new System.Drawing.Size(305, 705);
            this.xPanderPanel2.TabIndex = 1;
            this.xPanderPanel2.Text = "Well Info";
            this.xPanderPanel2.ToolTipTextCloseIcon = null;
            this.xPanderPanel2.ToolTipTextExpandIconPanelCollapsed = null;
            this.xPanderPanel2.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // valveReplacementDatePicker
            // 
            this.valveReplacementDatePicker.CalendarForeColor = System.Drawing.Color.Blue;
            this.valveReplacementDatePicker.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.valveReplacementDatePicker.CalendarTitleForeColor = System.Drawing.Color.Blue;
            this.valveReplacementDatePicker.Enabled = false;
            this.valveReplacementDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.valveReplacementDatePicker.Location = new System.Drawing.Point(8, 567);
            this.valveReplacementDatePicker.Name = "valveReplacementDatePicker";
            this.valveReplacementDatePicker.Size = new System.Drawing.Size(200, 22);
            this.valveReplacementDatePicker.TabIndex = 21;
            this.valveReplacementDatePicker.Value = new System.DateTime(2015, 3, 16, 0, 0, 0, 0);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(9, 547);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(141, 17);
            this.label21.TabIndex = 19;
            this.label21.Text = "Valve Replaced Date";
            // 
            // textBoxValveReplaced
            // 
            this.textBoxValveReplaced.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxValveReplaced.ForeColor = System.Drawing.Color.Blue;
            this.textBoxValveReplaced.Location = new System.Drawing.Point(9, 521);
            this.textBoxValveReplaced.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxValveReplaced.Name = "textBoxValveReplaced";
            this.textBoxValveReplaced.Size = new System.Drawing.Size(289, 22);
            this.textBoxValveReplaced.TabIndex = 18;
            this.textBoxValveReplaced.Text = "#Number";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(9, 501);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(127, 17);
            this.label20.TabIndex = 17;
            this.label20.Text = "Valve Replaced By";
            // 
            // extraErrorLbl
            // 
            this.extraErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.extraErrorLbl.Location = new System.Drawing.Point(7, 604);
            this.extraErrorLbl.MaximumSize = new System.Drawing.Size(289, 57);
            this.extraErrorLbl.Name = "extraErrorLbl";
            this.extraErrorLbl.Size = new System.Drawing.Size(289, 57);
            this.extraErrorLbl.TabIndex = 16;
            // 
            // extraCancelBtn
            // 
            this.extraCancelBtn.ForeColor = System.Drawing.Color.Blue;
            this.extraCancelBtn.Location = new System.Drawing.Point(196, 665);
            this.extraCancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.extraCancelBtn.Name = "extraCancelBtn";
            this.extraCancelBtn.Size = new System.Drawing.Size(100, 28);
            this.extraCancelBtn.TabIndex = 15;
            this.extraCancelBtn.Text = "Cancel";
            this.extraCancelBtn.UseVisualStyleBackColor = true;
            this.extraCancelBtn.Visible = false;
            this.extraCancelBtn.Click += new System.EventHandler(this.extraCancelBtn_Click);
            // 
            // extraUpdateBtn
            // 
            this.extraUpdateBtn.ForeColor = System.Drawing.Color.Blue;
            this.extraUpdateBtn.Location = new System.Drawing.Point(6, 665);
            this.extraUpdateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.extraUpdateBtn.Name = "extraUpdateBtn";
            this.extraUpdateBtn.Size = new System.Drawing.Size(100, 28);
            this.extraUpdateBtn.TabIndex = 14;
            this.extraUpdateBtn.Text = "Edit";
            this.extraUpdateBtn.UseVisualStyleBackColor = true;
            this.extraUpdateBtn.Click += new System.EventHandler(this.extraUpdateBtn_Click);
            // 
            // textBoxWellDepth
            // 
            this.textBoxWellDepth.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxWellDepth.ForeColor = System.Drawing.Color.Blue;
            this.textBoxWellDepth.Location = new System.Drawing.Point(9, 471);
            this.textBoxWellDepth.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWellDepth.Name = "textBoxWellDepth";
            this.textBoxWellDepth.Size = new System.Drawing.Size(289, 22);
            this.textBoxWellDepth.TabIndex = 13;
            this.textBoxWellDepth.Text = "#Number";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(9, 451);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(134, 17);
            this.label19.TabIndex = 12;
            this.label19.Text = "Well Depth (metres)";
            // 
            // textBoxWaterLevel
            // 
            this.textBoxWaterLevel.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxWaterLevel.ForeColor = System.Drawing.Color.Blue;
            this.textBoxWaterLevel.Location = new System.Drawing.Point(9, 414);
            this.textBoxWaterLevel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWaterLevel.Name = "textBoxWaterLevel";
            this.textBoxWaterLevel.Size = new System.Drawing.Size(289, 22);
            this.textBoxWaterLevel.TabIndex = 11;
            this.textBoxWaterLevel.Text = "#Number";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(9, 394);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(141, 17);
            this.label18.TabIndex = 10;
            this.label18.Text = "Water Level (metres)";
            // 
            // textBoxNumPeople
            // 
            this.textBoxNumPeople.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNumPeople.ForeColor = System.Drawing.Color.Blue;
            this.textBoxNumPeople.Location = new System.Drawing.Point(9, 359);
            this.textBoxNumPeople.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumPeople.Name = "textBoxNumPeople";
            this.textBoxNumPeople.Size = new System.Drawing.Size(289, 22);
            this.textBoxNumPeople.TabIndex = 9;
            this.textBoxNumPeople.Text = "#Number";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(9, 339);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 17);
            this.label17.TabIndex = 8;
            this.label17.Text = "Number of people";
            // 
            // textBoxVillage
            // 
            this.textBoxVillage.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxVillage.ForeColor = System.Drawing.Color.Blue;
            this.textBoxVillage.Location = new System.Drawing.Point(9, 300);
            this.textBoxVillage.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVillage.Name = "textBoxVillage";
            this.textBoxVillage.Size = new System.Drawing.Size(289, 22);
            this.textBoxVillage.TabIndex = 7;
            this.textBoxVillage.Text = "Area name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(9, 280);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 17);
            this.label16.TabIndex = 6;
            this.label16.Text = "City/Village";
            // 
            // textBoxArea
            // 
            this.textBoxArea.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxArea.ForeColor = System.Drawing.Color.Blue;
            this.textBoxArea.Location = new System.Drawing.Point(9, 247);
            this.textBoxArea.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(289, 22);
            this.textBoxArea.TabIndex = 5;
            this.textBoxArea.Text = "Area name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(5, 227);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "Area";
            // 
            // textBoxDistrict
            // 
            this.textBoxDistrict.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDistrict.ForeColor = System.Drawing.Color.Blue;
            this.textBoxDistrict.Location = new System.Drawing.Point(9, 190);
            this.textBoxDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDistrict.Name = "textBoxDistrict";
            this.textBoxDistrict.Size = new System.Drawing.Size(289, 22);
            this.textBoxDistrict.TabIndex = 3;
            this.textBoxDistrict.Text = "District name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(5, 170);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "District";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(5, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.AcceptsReturn = true;
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDescription.Enabled = false;
            this.textBoxDescription.ForeColor = System.Drawing.Color.Blue;
            this.textBoxDescription.Location = new System.Drawing.Point(7, 53);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(289, 110);
            this.textBoxDescription.TabIndex = 0;
            this.textBoxDescription.Text = "The well description will be here and should wrap onto multiple lines";
            // 
            // panelMenu
            // 
            this.panelMenu.AssociatedSplitter = this.splitter1;
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.CaptionFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.CaptionHeight = 27;
            this.panelMenu.Controls.Add(this.xPanderPanelList1);
            this.panelMenu.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panelMenu.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panelMenu.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panelMenu.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelMenu.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panelMenu.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelMenu.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelMenu.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelMenu.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.panelMenu.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.panelMenu.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panelMenu.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelMenu.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMenu.Image = null;
            this.panelMenu.Location = new System.Drawing.Point(880, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.MinimumSize = new System.Drawing.Size(27, 27);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.panelMenu.ShowExpandIcon = true;
            this.panelMenu.Size = new System.Drawing.Size(305, 734);
            this.panelMenu.TabIndex = 40;
            this.panelMenu.Text = "Menu";
            this.panelMenu.ToolTipTextCloseIcon = null;
            this.panelMenu.ToolTipTextExpandIconPanelCollapsed = "maximize";
            this.panelMenu.ToolTipTextExpandIconPanelExpanded = "minimize";
            // 
            // xPanderPanelList1
            // 
            this.xPanderPanelList1.CaptionStyle = BSE.Windows.Forms.CaptionStyle.Flat;
            this.xPanderPanelList1.Controls.Add(this.xPanderPanelMain);
            this.xPanderPanelList1.Controls.Add(this.xPanderPanelCache);
            this.xPanderPanelList1.Controls.Add(this.xPanderPanelInfo);
            this.xPanderPanelList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanderPanelList1.GradientBackground = System.Drawing.Color.Empty;
            this.xPanderPanelList1.Location = new System.Drawing.Point(0, 28);
            this.xPanderPanelList1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xPanderPanelList1.Name = "xPanderPanelList1";
            this.xPanderPanelList1.PanelColors = null;
            this.xPanderPanelList1.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.xPanderPanelList1.ShowExpandIcon = true;
            this.xPanderPanelList1.Size = new System.Drawing.Size(305, 705);
            this.xPanderPanelList1.TabIndex = 0;
            this.xPanderPanelList1.Text = "xPanderPanelList1";
            // 
            // xPanderPanelMain
            // 
            this.xPanderPanelMain.CaptionFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xPanderPanelMain.Controls.Add(this.tableLayoutPanel4);
            this.xPanderPanelMain.CustomColors.BackColor = System.Drawing.SystemColors.Control;
            this.xPanderPanelMain.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.xPanderPanelMain.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.Empty;
            this.xPanderPanelMain.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.Empty;
            this.xPanderPanelMain.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.Empty;
            this.xPanderPanelMain.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanelMain.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanelMain.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xPanderPanelMain.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.xPanderPanelMain.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xPanderPanelMain.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanelMain.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanelMain.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanelMain.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanelMain.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanelMain.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanelMain.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanelMain.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanelMain.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xPanderPanelMain.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xPanderPanelMain.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.xPanderPanelMain.Expand = true;
            this.xPanderPanelMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xPanderPanelMain.Image = null;
            this.xPanderPanelMain.IsClosable = false;
            this.xPanderPanelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xPanderPanelMain.Name = "xPanderPanelMain";
            this.xPanderPanelMain.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.xPanderPanelMain.Size = new System.Drawing.Size(305, 655);
            this.xPanderPanelMain.TabIndex = 0;
            this.xPanderPanelMain.Text = "map";
            this.xPanderPanelMain.ToolTipTextCloseIcon = null;
            this.xPanderPanelMain.ToolTipTextExpandIconPanelCollapsed = null;
            this.xPanderPanelMain.ToolTipTextExpandIconPanelExpanded = null;
            this.xPanderPanelMain.Click += new System.EventHandler(this.xPanderPanel1_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.27536F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1, 25);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(303, 630);
            this.tableLayoutPanel4.TabIndex = 38;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.markersGroupBox, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox5, 0, 4);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(64, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(236, 628);
            this.tableLayoutPanel5.TabIndex = 30;
            // 
            // markersGroupBox
            // 
            this.markersGroupBox.Controls.Add(this.zoomCenterBtn);
            this.markersGroupBox.Controls.Add(this.checkBoxPlacemarkInfo);
            this.markersGroupBox.Controls.Add(this.clearMarkersBtn);
            this.markersGroupBox.Controls.Add(this.addMarkerBtn);
            this.markersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.markersGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.markersGroupBox.Location = new System.Drawing.Point(4, 170);
            this.markersGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.markersGroupBox.Name = "markersGroupBox";
            this.markersGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.markersGroupBox.Size = new System.Drawing.Size(228, 91);
            this.markersGroupBox.TabIndex = 37;
            this.markersGroupBox.TabStop = false;
            this.markersGroupBox.Text = "wells";
            // 
            // zoomCenterBtn
            // 
            this.zoomCenterBtn.ForeColor = System.Drawing.Color.Blue;
            this.zoomCenterBtn.Location = new System.Drawing.Point(8, 55);
            this.zoomCenterBtn.Margin = new System.Windows.Forms.Padding(4);
            this.zoomCenterBtn.Name = "zoomCenterBtn";
            this.zoomCenterBtn.Size = new System.Drawing.Size(109, 30);
            this.zoomCenterBtn.TabIndex = 15;
            this.zoomCenterBtn.Text = "Zoom Center";
            this.zoomCenterBtn.UseVisualStyleBackColor = true;
            this.zoomCenterBtn.Click += new System.EventHandler(this.zoomToMarkers_Click);
            // 
            // checkBoxPlacemarkInfo
            // 
            this.checkBoxPlacemarkInfo.AutoSize = true;
            this.checkBoxPlacemarkInfo.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxPlacemarkInfo.Checked = true;
            this.checkBoxPlacemarkInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPlacemarkInfo.Location = new System.Drawing.Point(125, 23);
            this.checkBoxPlacemarkInfo.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxPlacemarkInfo.Name = "checkBoxPlacemarkInfo";
            this.checkBoxPlacemarkInfo.Size = new System.Drawing.Size(91, 21);
            this.checkBoxPlacemarkInfo.TabIndex = 14;
            this.checkBoxPlacemarkInfo.Text = "place info";
            this.checkBoxPlacemarkInfo.UseVisualStyleBackColor = true;
            // 
            // clearMarkersBtn
            // 
            this.clearMarkersBtn.ForeColor = System.Drawing.Color.Blue;
            this.clearMarkersBtn.Location = new System.Drawing.Point(125, 55);
            this.clearMarkersBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearMarkersBtn.Name = "clearMarkersBtn";
            this.clearMarkersBtn.Size = new System.Drawing.Size(84, 30);
            this.clearMarkersBtn.TabIndex = 13;
            this.clearMarkersBtn.Text = "Clear All";
            this.clearMarkersBtn.UseVisualStyleBackColor = true;
            this.clearMarkersBtn.Click += new System.EventHandler(this.clearMarkers_Click);
            // 
            // addMarkerBtn
            // 
            this.addMarkerBtn.ForeColor = System.Drawing.Color.Blue;
            this.addMarkerBtn.Location = new System.Drawing.Point(8, 18);
            this.addMarkerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addMarkerBtn.Name = "addMarkerBtn";
            this.addMarkerBtn.Size = new System.Drawing.Size(109, 30);
            this.addMarkerBtn.TabIndex = 12;
            this.addMarkerBtn.Text = "Add Well";
            this.addMarkerBtn.UseVisualStyleBackColor = true;
            this.addMarkerBtn.Click += new System.EventHandler(this.AddMarker_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxGeo);
            this.groupBox3.Controls.Add(this.reloadMapBtn);
            this.groupBox3.Controls.Add(this.goToBtn);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxLng);
            this.groupBox3.Controls.Add(this.textBoxLat);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(228, 158);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "coordinates";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "goto";
            // 
            // textBoxGeo
            // 
            this.textBoxGeo.Location = new System.Drawing.Point(12, 87);
            this.textBoxGeo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGeo.Name = "textBoxGeo";
            this.textBoxGeo.Size = new System.Drawing.Size(161, 22);
            this.textBoxGeo.TabIndex = 10;
            this.textBoxGeo.Text = "malawi";
            this.textBoxGeo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGeo_KeyPress);
            // 
            // reloadMapBtn
            // 
            this.reloadMapBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reloadMapBtn.ForeColor = System.Drawing.Color.Blue;
            this.reloadMapBtn.Location = new System.Drawing.Point(113, 121);
            this.reloadMapBtn.Margin = new System.Windows.Forms.Padding(4);
            this.reloadMapBtn.Name = "reloadMapBtn";
            this.reloadMapBtn.Size = new System.Drawing.Size(99, 30);
            this.reloadMapBtn.TabIndex = 9;
            this.reloadMapBtn.Text = "Reload";
            this.reloadMapBtn.UseVisualStyleBackColor = true;
            this.reloadMapBtn.Click += new System.EventHandler(this.reloadMap_Click);
            // 
            // goToBtn
            // 
            this.goToBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.goToBtn.ForeColor = System.Drawing.Color.Blue;
            this.goToBtn.Location = new System.Drawing.Point(12, 121);
            this.goToBtn.Margin = new System.Windows.Forms.Padding(4);
            this.goToBtn.Name = "goToBtn";
            this.goToBtn.Size = new System.Drawing.Size(96, 30);
            this.goToBtn.TabIndex = 8;
            this.goToBtn.Text = "GoTo !";
            this.goToBtn.UseVisualStyleBackColor = true;
            this.goToBtn.Click += new System.EventHandler(this.gotoLocationBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "lng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "lat";
            // 
            // textBoxLng
            // 
            this.textBoxLng.Location = new System.Drawing.Point(12, 55);
            this.textBoxLng.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLng.Name = "textBoxLng";
            this.textBoxLng.ShortcutsEnabled = false;
            this.textBoxLng.Size = new System.Drawing.Size(161, 22);
            this.textBoxLng.TabIndex = 1;
            this.textBoxLng.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLatLng_KeyPress);
            // 
            // textBoxLat
            // 
            this.textBoxLat.Location = new System.Drawing.Point(12, 23);
            this.textBoxLat.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLat.Name = "textBoxLat";
            this.textBoxLat.Size = new System.Drawing.Size(161, 22);
            this.textBoxLat.TabIndex = 0;
            this.textBoxLat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLatLng_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.comboBoxMapType);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Location = new System.Drawing.Point(5, 270);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox5.Size = new System.Drawing.Size(226, 61);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Choose Map";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "type";
            // 
            // comboBoxMapType
            // 
            this.comboBoxMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMapType.ForeColor = System.Drawing.Color.Blue;
            this.comboBoxMapType.FormattingEnabled = true;
            this.comboBoxMapType.Location = new System.Drawing.Point(11, 23);
            this.comboBoxMapType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMapType.Name = "comboBoxMapType";
            this.comboBoxMapType.Size = new System.Drawing.Size(163, 24);
            this.comboBoxMapType.TabIndex = 9;
            this.comboBoxMapType.DropDownClosed += new System.EventHandler(this.comboBoxMapType_DropDownClosed);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.buttonZoomUp, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.trackBar1, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.buttonZoomDown, 0, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(58, 626);
            this.tableLayoutPanel6.TabIndex = 31;
            // 
            // buttonZoomUp
            // 
            this.buttonZoomUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonZoomUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZoomUp.ForeColor = System.Drawing.Color.Blue;
            this.buttonZoomUp.Location = new System.Drawing.Point(0, 0);
            this.buttonZoomUp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZoomUp.Name = "buttonZoomUp";
            this.buttonZoomUp.Size = new System.Drawing.Size(58, 33);
            this.buttonZoomUp.TabIndex = 0;
            this.buttonZoomUp.Text = "+";
            this.buttonZoomUp.UseVisualStyleBackColor = true;
            this.buttonZoomUp.Click += new System.EventHandler(this.buttonZoomUp_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(0, 33);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar1.Maximum = 1700;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(58, 560);
            this.trackBar1.TabIndex = 29;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 12;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // buttonZoomDown
            // 
            this.buttonZoomDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonZoomDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZoomDown.ForeColor = System.Drawing.Color.Blue;
            this.buttonZoomDown.Location = new System.Drawing.Point(0, 593);
            this.buttonZoomDown.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZoomDown.Name = "buttonZoomDown";
            this.buttonZoomDown.Size = new System.Drawing.Size(58, 33);
            this.buttonZoomDown.TabIndex = 1;
            this.buttonZoomDown.Text = "-";
            this.buttonZoomDown.UseVisualStyleBackColor = true;
            this.buttonZoomDown.Click += new System.EventHandler(this.buttonZoomDown_Click);
            // 
            // xPanderPanelCache
            // 
            this.xPanderPanelCache.CaptionFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xPanderPanelCache.Controls.Add(this.tableLayoutPanel1);
            this.xPanderPanelCache.CustomColors.BackColor = System.Drawing.SystemColors.Control;
            this.xPanderPanelCache.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.xPanderPanelCache.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.Empty;
            this.xPanderPanelCache.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.Empty;
            this.xPanderPanelCache.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.Empty;
            this.xPanderPanelCache.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanelCache.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanelCache.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xPanderPanelCache.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.xPanderPanelCache.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xPanderPanelCache.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanelCache.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanelCache.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanelCache.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanelCache.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanelCache.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanelCache.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanelCache.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanelCache.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xPanderPanelCache.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xPanderPanelCache.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.xPanderPanelCache.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xPanderPanelCache.Image = null;
            this.xPanderPanelCache.IsClosable = false;
            this.xPanderPanelCache.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xPanderPanelCache.Name = "xPanderPanelCache";
            this.xPanderPanelCache.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.xPanderPanelCache.Size = new System.Drawing.Size(305, 25);
            this.xPanderPanelCache.TabIndex = 1;
            this.xPanderPanelCache.Text = "cache";
            this.xPanderPanelCache.ToolTipTextCloseIcon = null;
            this.xPanderPanelCache.ToolTipTextExpandIconPanelCollapsed = null;
            this.xPanderPanelCache.ToolTipTextExpandIconPanelExpanded = null;
            this.xPanderPanelCache.Click += new System.EventHandler(this.xPanderPanelCache_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxCacheSize, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCacheStatus, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.cacheImportBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMemory, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxUseInfoCache, 1, 17);
            this.tableLayoutPanel1.Controls.Add(this.cacheExportBtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.clearTilesInCacheBtn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.opencacheLocationBtn, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 21;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(303, 0);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // textBoxCacheSize
            // 
            this.textBoxCacheSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxCacheSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCacheSize.Location = new System.Drawing.Point(24, 266);
            this.textBoxCacheSize.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCacheSize.Name = "textBoxCacheSize";
            this.textBoxCacheSize.ReadOnly = true;
            this.textBoxCacheSize.Size = new System.Drawing.Size(255, 34);
            this.textBoxCacheSize.TabIndex = 49;
            this.textBoxCacheSize.Text = "...";
            // 
            // textBoxCacheStatus
            // 
            this.textBoxCacheStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxCacheStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCacheStatus.Location = new System.Drawing.Point(24, 345);
            this.textBoxCacheStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCacheStatus.Name = "textBoxCacheStatus";
            this.textBoxCacheStatus.ReadOnly = true;
            this.textBoxCacheStatus.Size = new System.Drawing.Size(255, 34);
            this.textBoxCacheStatus.TabIndex = 46;
            this.textBoxCacheStatus.Text = "...";
            // 
            // cacheImportBtn
            // 
            this.cacheImportBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cacheImportBtn.Location = new System.Drawing.Point(24, 24);
            this.cacheImportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cacheImportBtn.Name = "cacheImportBtn";
            this.cacheImportBtn.Size = new System.Drawing.Size(255, 25);
            this.cacheImportBtn.TabIndex = 5;
            this.cacheImportBtn.Text = "Import";
            this.cacheImportBtn.UseVisualStyleBackColor = true;
            this.cacheImportBtn.Click += new System.EventHandler(this.cacheImport_Click);
            // 
            // textBoxMemory
            // 
            this.textBoxMemory.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMemory.Location = new System.Drawing.Point(24, 187);
            this.textBoxMemory.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMemory.Name = "textBoxMemory";
            this.textBoxMemory.ReadOnly = true;
            this.textBoxMemory.Size = new System.Drawing.Size(255, 34);
            this.textBoxMemory.TabIndex = 39;
            this.textBoxMemory.Text = "...";
            // 
            // checkBoxUseInfoCache
            // 
            this.checkBoxUseInfoCache.AutoSize = true;
            this.checkBoxUseInfoCache.Checked = true;
            this.checkBoxUseInfoCache.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseInfoCache.Location = new System.Drawing.Point(24, 407);
            this.checkBoxUseInfoCache.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxUseInfoCache.Name = "checkBoxUseInfoCache";
            this.checkBoxUseInfoCache.Size = new System.Drawing.Size(153, 21);
            this.checkBoxUseInfoCache.TabIndex = 2;
            this.checkBoxUseInfoCache.Text = "cache geocodig/etc";
            this.checkBoxUseInfoCache.UseVisualStyleBackColor = true;
            this.checkBoxUseInfoCache.CheckedChanged += new System.EventHandler(this.checkBoxUseCache_CheckedChanged);
            // 
            // cacheExportBtn
            // 
            this.cacheExportBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cacheExportBtn.Location = new System.Drawing.Point(24, 57);
            this.cacheExportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cacheExportBtn.Name = "cacheExportBtn";
            this.cacheExportBtn.Size = new System.Drawing.Size(255, 25);
            this.cacheExportBtn.TabIndex = 4;
            this.cacheExportBtn.Text = "Export";
            this.cacheExportBtn.UseVisualStyleBackColor = true;
            this.cacheExportBtn.Click += new System.EventHandler(this.cacheExport_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 166);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "memory cache usage:";
            // 
            // clearTilesInCacheBtn
            // 
            this.clearTilesInCacheBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearTilesInCacheBtn.Location = new System.Drawing.Point(24, 90);
            this.clearTilesInCacheBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearTilesInCacheBtn.Name = "clearTilesInCacheBtn";
            this.clearTilesInCacheBtn.Size = new System.Drawing.Size(255, 25);
            this.clearTilesInCacheBtn.TabIndex = 43;
            this.clearTilesInCacheBtn.Text = "Clear tiles in disk cache";
            this.clearTilesInCacheBtn.UseVisualStyleBackColor = true;
            this.clearTilesInCacheBtn.Click += new System.EventHandler(this.clearTimesInCache_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 324);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "disk cache status:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 245);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 17);
            this.label14.TabIndex = 47;
            this.label14.Text = "disk cache size:";
            // 
            // opencacheLocationBtn
            // 
            this.opencacheLocationBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opencacheLocationBtn.Location = new System.Drawing.Point(23, 121);
            this.opencacheLocationBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.opencacheLocationBtn.Name = "opencacheLocationBtn";
            this.opencacheLocationBtn.Size = new System.Drawing.Size(257, 23);
            this.opencacheLocationBtn.TabIndex = 50;
            this.opencacheLocationBtn.Text = "Open cache location";
            this.opencacheLocationBtn.UseVisualStyleBackColor = true;
            this.opencacheLocationBtn.Click += new System.EventHandler(this.openCacheLocation_Click);
            // 
            // xPanderPanelInfo
            // 
            this.xPanderPanelInfo.CaptionFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xPanderPanelInfo.Controls.Add(this.tableLayoutPanel2);
            this.xPanderPanelInfo.CustomColors.BackColor = System.Drawing.SystemColors.Control;
            this.xPanderPanelInfo.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.xPanderPanelInfo.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.Empty;
            this.xPanderPanelInfo.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.Empty;
            this.xPanderPanelInfo.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.Empty;
            this.xPanderPanelInfo.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanelInfo.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanelInfo.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xPanderPanelInfo.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.xPanderPanelInfo.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xPanderPanelInfo.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanelInfo.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanelInfo.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanelInfo.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanelInfo.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanelInfo.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanelInfo.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanelInfo.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanelInfo.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xPanderPanelInfo.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xPanderPanelInfo.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.xPanderPanelInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xPanderPanelInfo.Image = null;
            this.xPanderPanelInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xPanderPanelInfo.Name = "xPanderPanelInfo";
            this.xPanderPanelInfo.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.xPanderPanelInfo.Size = new System.Drawing.Size(305, 25);
            this.xPanderPanelInfo.TabIndex = 3;
            this.xPanderPanelInfo.Text = "info";
            this.xPanderPanelInfo.ToolTipTextCloseIcon = null;
            this.xPanderPanelInfo.ToolTipTextExpandIconPanelCollapsed = null;
            this.xPanderPanelInfo.ToolTipTextExpandIconPanelExpanded = null;
            this.xPanderPanelInfo.Click += new System.EventHandler(this.xPanderPanelInfo_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxZoomCurrent, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.textBoxLngCurrent, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMarkerCount, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.label11, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxLatCurrent, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 25);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 13;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(303, 0);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // textBoxZoomCurrent
            // 
            this.textBoxZoomCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxZoomCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZoomCurrent.Location = new System.Drawing.Point(24, 179);
            this.textBoxZoomCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZoomCurrent.Name = "textBoxZoomCurrent";
            this.textBoxZoomCurrent.ReadOnly = true;
            this.textBoxZoomCurrent.Size = new System.Drawing.Size(255, 34);
            this.textBoxZoomCurrent.TabIndex = 8;
            this.textBoxZoomCurrent.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 158);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "zoom:";
            // 
            // textBoxLngCurrent
            // 
            this.textBoxLngCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLngCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLngCurrent.Location = new System.Drawing.Point(24, 100);
            this.textBoxLngCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLngCurrent.Name = "textBoxLngCurrent";
            this.textBoxLngCurrent.ReadOnly = true;
            this.textBoxLngCurrent.Size = new System.Drawing.Size(255, 34);
            this.textBoxLngCurrent.TabIndex = 5;
            this.textBoxLngCurrent.Text = "...";
            // 
            // textBoxMarkerCount
            // 
            this.textBoxMarkerCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMarkerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarkerCount.Location = new System.Drawing.Point(24, 238);
            this.textBoxMarkerCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMarkerCount.Name = "textBoxMarkerCount";
            this.textBoxMarkerCount.ReadOnly = true;
            this.textBoxMarkerCount.Size = new System.Drawing.Size(255, 34);
            this.textBoxMarkerCount.TabIndex = 10;
            this.textBoxMarkerCount.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 217);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "markers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "lng:";
            // 
            // textBoxLatCurrent
            // 
            this.textBoxLatCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLatCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLatCurrent.Location = new System.Drawing.Point(24, 41);
            this.textBoxLatCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLatCurrent.Name = "textBoxLatCurrent";
            this.textBoxLatCurrent.ReadOnly = true;
            this.textBoxLatCurrent.Size = new System.Drawing.Size(255, 34);
            this.textBoxLatCurrent.TabIndex = 4;
            this.textBoxLatCurrent.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "lat:";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(0, 0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 0;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(0, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 0;
            // 
            // checkBoxDebug
            // 
            this.checkBoxDebug.Location = new System.Drawing.Point(0, 0);
            this.checkBoxDebug.Name = "checkBoxDebug";
            this.checkBoxDebug.Size = new System.Drawing.Size(104, 24);
            this.checkBoxDebug.TabIndex = 0;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(0, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 0;
            // 
            // checkBoxCanDrag
            // 
            this.checkBoxCanDrag.Location = new System.Drawing.Point(0, 0);
            this.checkBoxCanDrag.Name = "checkBoxCanDrag";
            this.checkBoxCanDrag.Size = new System.Drawing.Size(104, 24);
            this.checkBoxCanDrag.TabIndex = 0;
            // 
            // checkBoxCurrentMarker
            // 
            this.checkBoxCurrentMarker.Location = new System.Drawing.Point(0, 0);
            this.checkBoxCurrentMarker.Name = "checkBoxCurrentMarker";
            this.checkBoxCurrentMarker.Size = new System.Drawing.Size(104, 24);
            this.checkBoxCurrentMarker.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1188, 734);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(733, 120);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WellsForZoe GPS Well Mapper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelExtra.ResumeLayout(false);
            this.xPanderPanelList2.ResumeLayout(false);
            this.xPanderPanel2.ResumeLayout(false);
            this.xPanderPanel2.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.xPanderPanelList1.ResumeLayout(false);
            this.xPanderPanelMain.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.markersGroupBox.ResumeLayout(false);
            this.markersGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.xPanderPanelCache.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.xPanderPanelInfo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox checkBoxUseInfoCache;
        private System.Windows.Forms.Button cacheExportBtn;
        private System.Windows.Forms.Button cacheImportBtn;
        private BSE.Windows.Forms.Panel panelMenu;
        private BSE.Windows.Forms.XPanderPanelList xPanderPanelList1;
        private BSE.Windows.Forms.XPanderPanel xPanderPanelMain;
        private BSE.Windows.Forms.XPanderPanel xPanderPanelCache;
        private System.Windows.Forms.Panel panel4;
        private BSE.Windows.Forms.Splitter splitter1;
        private BSE.Windows.Forms.XPanderPanel xPanderPanelInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLngCurrent;
        private System.Windows.Forms.TextBox textBoxLatCurrent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxZoomCurrent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxMemory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxMarkerCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button clearTilesInCacheBtn;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.CheckBox checkBoxDebug;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.CheckBox checkBoxCanDrag;
        private System.Windows.Forms.CheckBox checkBoxCurrentMarker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxMapType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button buttonZoomUp;
        private System.Windows.Forms.Button buttonZoomDown;
        private System.Windows.Forms.TextBox textBoxCacheStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxCacheSize;
        private System.Windows.Forms.Button opencacheLocationBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox markersGroupBox;
        private System.Windows.Forms.Button zoomCenterBtn;
        private System.Windows.Forms.CheckBox checkBoxPlacemarkInfo;
        private System.Windows.Forms.Button clearMarkersBtn;
        private System.Windows.Forms.Button addMarkerBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxGeo;
        private System.Windows.Forms.Button reloadMapBtn;
        private System.Windows.Forms.Button goToBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLng;
        private System.Windows.Forms.TextBox textBoxLat;
        private System.Windows.Forms.GroupBox groupBox5;
        private BSE.Windows.Forms.Panel panelExtra;
        private BSE.Windows.Forms.XPanderPanelList xPanderPanelList2;
        private BSE.Windows.Forms.XPanderPanel xPanderPanel2;
        private System.Windows.Forms.Panel panel2;
        internal GMapControl MainMap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxDistrict;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxWellDepth;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxWaterLevel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxNumPeople;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxVillage;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button extraCancelBtn;
        private System.Windows.Forms.Button extraUpdateBtn;
        private System.Windows.Forms.Label extraErrorLbl;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxValveReplaced;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker valveReplacementDatePicker;
    }
}

