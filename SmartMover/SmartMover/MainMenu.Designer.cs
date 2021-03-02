namespace SmartMover
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.BackgroundBody_panel = new System.Windows.Forms.Panel();
            this.Body_panel = new System.Windows.Forms.Panel();
            this.Top_panel = new System.Windows.Forms.Panel();
            this.LogOut_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SideNotHide_panel = new System.Windows.Forms.Panel();
            this.DataBase_BTN = new System.Windows.Forms.PictureBox();
            this.Home_BTN = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainMenu_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.File_menuicon = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_File_menuicon = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit__menuicon = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings_Edit_menuicon = new System.Windows.Forms.ToolStripMenuItem();
            this.View_menuicon = new System.Windows.Forms.ToolStripMenuItem();
            this.Reload_View_menuicon = new System.Windows.Forms.ToolStripMenuItem();
            this.ToggelFScreen_View_menuicon = new System.Windows.Forms.ToolStripMenuItem();
            this.Windows_menuicon = new System.Windows.Forms.ToolStripMenuItem();
            this.ToggelTop_WIN_menuicon = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_menuicon = new System.Windows.Forms.ToolStripMenuItem();
            this.SoftwareLicense_menuicon = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Help_SoftL_menuicon = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLogs_Help_SL_menuicon = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAnIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Troubleshooting_menuicon = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckUpdates_menuicon = new System.Windows.Forms.ToolStripMenuItem();
            this.About_menuicon = new System.Windows.Forms.ToolStripMenuItem();
            this.SideHide_panel = new System.Windows.Forms.Panel();
            this.SideHidePanel_lbl6 = new System.Windows.Forms.Label();
            this.SideHidePanel_lbl5 = new System.Windows.Forms.Label();
            this.SideHidePanel_lbl4 = new System.Windows.Forms.Label();
            this.SideHidePanel_lbl3 = new System.Windows.Forms.Label();
            this.SideHidePanel_lbl2 = new System.Windows.Forms.Label();
            this.SideHidePanel_lbl1 = new System.Windows.Forms.Label();
            this.SideHidePanel_Main_lbl = new System.Windows.Forms.Label();
            this.payment1 = new SmartMover.src.DataBase.Payment.Payment();
            this.loadData1 = new SmartMover.src.DataBase.Load.LoadData();
            this.employeeData1 = new SmartMover.src.DataBase.Employee.EmployeeData();
            this.startHome1 = new SmartMover.src.Home.StartHome();
            this.jobData1 = new SmartMover.src.DataBase.Job.JobData();
            this.driverData1 = new SmartMover.src.DataBase.Driver.DriverData();
            this.customerData1 = new SmartMover.src.DataBase.Customer.CustomerData();
            this.BackgroundBody_panel.SuspendLayout();
            this.Body_panel.SuspendLayout();
            this.Top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SideNotHide_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBase_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainMenu_MenuStrip.SuspendLayout();
            this.SideHide_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundBody_panel
            // 
            this.BackgroundBody_panel.Controls.Add(this.Body_panel);
            this.BackgroundBody_panel.Controls.Add(this.Top_panel);
            this.BackgroundBody_panel.Controls.Add(this.SideNotHide_panel);
            this.BackgroundBody_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundBody_panel.Location = new System.Drawing.Point(0, 28);
            this.BackgroundBody_panel.Name = "BackgroundBody_panel";
            this.BackgroundBody_panel.Size = new System.Drawing.Size(1569, 853);
            this.BackgroundBody_panel.TabIndex = 0;
            // 
            // Body_panel
            // 
            this.Body_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.Body_panel.Controls.Add(this.payment1);
            this.Body_panel.Controls.Add(this.loadData1);
            this.Body_panel.Controls.Add(this.employeeData1);
            this.Body_panel.Controls.Add(this.startHome1);
            this.Body_panel.Controls.Add(this.jobData1);
            this.Body_panel.Controls.Add(this.driverData1);
            this.Body_panel.Controls.Add(this.customerData1);
            this.Body_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body_panel.Location = new System.Drawing.Point(100, 94);
            this.Body_panel.Name = "Body_panel";
            this.Body_panel.Size = new System.Drawing.Size(1469, 759);
            this.Body_panel.TabIndex = 2;
            this.Body_panel.MouseHover += new System.EventHandler(this.Body_panel_MouseHover);
            // 
            // Top_panel
            // 
            this.Top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Top_panel.Controls.Add(this.LogOut_btn);
            this.Top_panel.Controls.Add(this.pictureBox2);
            this.Top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_panel.Location = new System.Drawing.Point(100, 0);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(1469, 94);
            this.Top_panel.TabIndex = 1;
            this.Top_panel.MouseHover += new System.EventHandler(this.Top_panel_MouseHover);
            // 
            // LogOut_btn
            // 
            this.LogOut_btn.Active = false;
            this.LogOut_btn.Activecolor = System.Drawing.Color.DarkRed;
            this.LogOut_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogOut_btn.BackColor = System.Drawing.Color.Red;
            this.LogOut_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogOut_btn.BorderRadius = 7;
            this.LogOut_btn.ButtonText = "LOG OUT";
            this.LogOut_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOut_btn.DisabledColor = System.Drawing.Color.Gray;
            this.LogOut_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.LogOut_btn.Iconimage = null;
            this.LogOut_btn.Iconimage_right = null;
            this.LogOut_btn.Iconimage_right_Selected = null;
            this.LogOut_btn.Iconimage_Selected = null;
            this.LogOut_btn.IconMarginLeft = 0;
            this.LogOut_btn.IconMarginRight = 0;
            this.LogOut_btn.IconRightVisible = true;
            this.LogOut_btn.IconRightZoom = 0D;
            this.LogOut_btn.IconVisible = true;
            this.LogOut_btn.IconZoom = 90D;
            this.LogOut_btn.IsTab = false;
            this.LogOut_btn.Location = new System.Drawing.Point(1272, 29);
            this.LogOut_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogOut_btn.Name = "LogOut_btn";
            this.LogOut_btn.Normalcolor = System.Drawing.Color.Red;
            this.LogOut_btn.OnHovercolor = System.Drawing.Color.Crimson;
            this.LogOut_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.LogOut_btn.selected = false;
            this.LogOut_btn.Size = new System.Drawing.Size(107, 38);
            this.LogOut_btn.TabIndex = 8;
            this.LogOut_btn.Text = "LOG OUT";
            this.LogOut_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogOut_btn.Textcolor = System.Drawing.Color.White;
            this.LogOut_btn.TextFont = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.LogOut_btn.Click += new System.EventHandler(this.LogOut_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1386, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            // 
            // SideNotHide_panel
            // 
            this.SideNotHide_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.SideNotHide_panel.Controls.Add(this.DataBase_BTN);
            this.SideNotHide_panel.Controls.Add(this.Home_BTN);
            this.SideNotHide_panel.Controls.Add(this.pictureBox1);
            this.SideNotHide_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideNotHide_panel.Location = new System.Drawing.Point(0, 0);
            this.SideNotHide_panel.Name = "SideNotHide_panel";
            this.SideNotHide_panel.Size = new System.Drawing.Size(100, 853);
            this.SideNotHide_panel.TabIndex = 0;
            // 
            // DataBase_BTN
            // 
            this.DataBase_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataBase_BTN.Image = ((System.Drawing.Image)(resources.GetObject("DataBase_BTN.Image")));
            this.DataBase_BTN.Location = new System.Drawing.Point(0, 385);
            this.DataBase_BTN.Name = "DataBase_BTN";
            this.DataBase_BTN.Size = new System.Drawing.Size(100, 67);
            this.DataBase_BTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DataBase_BTN.TabIndex = 2;
            this.DataBase_BTN.TabStop = false;
            this.DataBase_BTN.Click += new System.EventHandler(this.DataBase_BTN_Click);
            this.DataBase_BTN.MouseLeave += new System.EventHandler(this.DataBase_BTN_MouseLeave);
            this.DataBase_BTN.MouseHover += new System.EventHandler(this.DataBase_BTN_MouseHover);
            // 
            // Home_BTN
            // 
            this.Home_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home_BTN.Image = global::SmartMover.Properties.Resources.home_48px_gray;
            this.Home_BTN.Location = new System.Drawing.Point(0, 284);
            this.Home_BTN.Name = "Home_BTN";
            this.Home_BTN.Size = new System.Drawing.Size(100, 67);
            this.Home_BTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Home_BTN.TabIndex = 1;
            this.Home_BTN.TabStop = false;
            this.Home_BTN.Click += new System.EventHandler(this.Home_BTN_Click);
            this.Home_BTN.MouseLeave += new System.EventHandler(this.Home_BTN_MouseLeave);
            this.Home_BTN.MouseHover += new System.EventHandler(this.Home_BTN_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu_MenuStrip
            // 
            this.MainMenu_MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainMenu_MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_menuicon,
            this.Edit__menuicon,
            this.View_menuicon,
            this.Windows_menuicon,
            this.Help_menuicon});
            this.MainMenu_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenu_MenuStrip.Name = "MainMenu_MenuStrip";
            this.MainMenu_MenuStrip.Size = new System.Drawing.Size(1569, 28);
            this.MainMenu_MenuStrip.TabIndex = 1;
            this.MainMenu_MenuStrip.Text = "Menu";
            this.MainMenu_MenuStrip.MouseHover += new System.EventHandler(this.MainMenu_MenuStrip_MouseHover);
            // 
            // File_menuicon
            // 
            this.File_menuicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.File_menuicon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit_File_menuicon});
            this.File_menuicon.Name = "File_menuicon";
            this.File_menuicon.Size = new System.Drawing.Size(46, 24);
            this.File_menuicon.Text = "File";
            this.File_menuicon.MouseHover += new System.EventHandler(this.File_menuicon_MouseHover);
            // 
            // Exit_File_menuicon
            // 
            this.Exit_File_menuicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Exit_File_menuicon.Name = "Exit_File_menuicon";
            this.Exit_File_menuicon.Size = new System.Drawing.Size(116, 26);
            this.Exit_File_menuicon.Text = "Exit";
            this.Exit_File_menuicon.Click += new System.EventHandler(this.Exit_File_menuicon_Click);
            // 
            // Edit__menuicon
            // 
            this.Edit__menuicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Edit__menuicon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Settings_Edit_menuicon});
            this.Edit__menuicon.Name = "Edit__menuicon";
            this.Edit__menuicon.Size = new System.Drawing.Size(49, 24);
            this.Edit__menuicon.Text = "Edit";
            this.Edit__menuicon.MouseHover += new System.EventHandler(this.Edit__menuicon_MouseHover);
            // 
            // Settings_Edit_menuicon
            // 
            this.Settings_Edit_menuicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Settings_Edit_menuicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Settings_Edit_menuicon.Name = "Settings_Edit_menuicon";
            this.Settings_Edit_menuicon.Size = new System.Drawing.Size(145, 26);
            this.Settings_Edit_menuicon.Text = "Settings";
            // 
            // View_menuicon
            // 
            this.View_menuicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.View_menuicon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reload_View_menuicon,
            this.ToggelFScreen_View_menuicon});
            this.View_menuicon.Name = "View_menuicon";
            this.View_menuicon.Size = new System.Drawing.Size(55, 24);
            this.View_menuicon.Text = "View";
            this.View_menuicon.MouseHover += new System.EventHandler(this.View_menuicon_MouseHover);
            // 
            // Reload_View_menuicon
            // 
            this.Reload_View_menuicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Reload_View_menuicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Reload_View_menuicon.Name = "Reload_View_menuicon";
            this.Reload_View_menuicon.Size = new System.Drawing.Size(245, 26);
            this.Reload_View_menuicon.Text = "Reload";
            // 
            // ToggelFScreen_View_menuicon
            // 
            this.ToggelFScreen_View_menuicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ToggelFScreen_View_menuicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToggelFScreen_View_menuicon.Name = "ToggelFScreen_View_menuicon";
            this.ToggelFScreen_View_menuicon.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.ToggelFScreen_View_menuicon.Size = new System.Drawing.Size(245, 26);
            this.ToggelFScreen_View_menuicon.Text = "Toggle Full Screen";
            // 
            // Windows_menuicon
            // 
            this.Windows_menuicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Windows_menuicon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToggelTop_WIN_menuicon});
            this.Windows_menuicon.Name = "Windows_menuicon";
            this.Windows_menuicon.Size = new System.Drawing.Size(84, 24);
            this.Windows_menuicon.Text = "Windows";
            this.Windows_menuicon.MouseHover += new System.EventHandler(this.Windows_menuicon_MouseHover);
            // 
            // ToggelTop_WIN_menuicon
            // 
            this.ToggelTop_WIN_menuicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ToggelTop_WIN_menuicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToggelTop_WIN_menuicon.Name = "ToggelTop_WIN_menuicon";
            this.ToggelTop_WIN_menuicon.Size = new System.Drawing.Size(238, 26);
            this.ToggelTop_WIN_menuicon.Text = "Toggel Always on Top";
            this.ToggelTop_WIN_menuicon.Click += new System.EventHandler(this.ToggelTop_WIN_menuicon_Click);
            // 
            // Help_menuicon
            // 
            this.Help_menuicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Help_menuicon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SoftwareLicense_menuicon,
            this.Troubleshooting_menuicon,
            this.CheckUpdates_menuicon,
            this.About_menuicon});
            this.Help_menuicon.Name = "Help_menuicon";
            this.Help_menuicon.Size = new System.Drawing.Size(55, 24);
            this.Help_menuicon.Text = "Help";
            this.Help_menuicon.MouseHover += new System.EventHandler(this.Help_menuicon_MouseHover);
            // 
            // SoftwareLicense_menuicon
            // 
            this.SoftwareLicense_menuicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SoftwareLicense_menuicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SoftwareLicense_menuicon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Report_Help_SoftL_menuicon,
            this.ShowLogs_Help_SL_menuicon,
            this.reportAnIssueToolStripMenuItem});
            this.SoftwareLicense_menuicon.Name = "SoftwareLicense_menuicon";
            this.SoftwareLicense_menuicon.Size = new System.Drawing.Size(203, 26);
            this.SoftwareLicense_menuicon.Text = "Software License";
            // 
            // Report_Help_SoftL_menuicon
            // 
            this.Report_Help_SoftL_menuicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Report_Help_SoftL_menuicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Report_Help_SoftL_menuicon.Name = "Report_Help_SoftL_menuicon";
            this.Report_Help_SoftL_menuicon.Size = new System.Drawing.Size(193, 26);
            this.Report_Help_SoftL_menuicon.Text = "Show License";
            this.Report_Help_SoftL_menuicon.Click += new System.EventHandler(this.Report_Help_SoftL_menuicon_Click);
            // 
            // ShowLogs_Help_SL_menuicon
            // 
            this.ShowLogs_Help_SL_menuicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ShowLogs_Help_SL_menuicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ShowLogs_Help_SL_menuicon.Name = "ShowLogs_Help_SL_menuicon";
            this.ShowLogs_Help_SL_menuicon.Size = new System.Drawing.Size(193, 26);
            this.ShowLogs_Help_SL_menuicon.Text = "Show Logs";
            // 
            // reportAnIssueToolStripMenuItem
            // 
            this.reportAnIssueToolStripMenuItem.Name = "reportAnIssueToolStripMenuItem";
            this.reportAnIssueToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.reportAnIssueToolStripMenuItem.Text = "Report an Issue";
            this.reportAnIssueToolStripMenuItem.Click += new System.EventHandler(this.reportAnIssueToolStripMenuItem_Click);
            // 
            // Troubleshooting_menuicon
            // 
            this.Troubleshooting_menuicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Troubleshooting_menuicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Troubleshooting_menuicon.Name = "Troubleshooting_menuicon";
            this.Troubleshooting_menuicon.Size = new System.Drawing.Size(203, 26);
            this.Troubleshooting_menuicon.Text = "Troubleshooting";
            // 
            // CheckUpdates_menuicon
            // 
            this.CheckUpdates_menuicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CheckUpdates_menuicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CheckUpdates_menuicon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CheckUpdates_menuicon.Name = "CheckUpdates_menuicon";
            this.CheckUpdates_menuicon.Size = new System.Drawing.Size(203, 26);
            this.CheckUpdates_menuicon.Text = "Check Updates";
            // 
            // About_menuicon
            // 
            this.About_menuicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.About_menuicon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.About_menuicon.Name = "About_menuicon";
            this.About_menuicon.Size = new System.Drawing.Size(203, 26);
            this.About_menuicon.Text = "About";
            this.About_menuicon.Click += new System.EventHandler(this.About_menuicon_Click);
            // 
            // SideHide_panel
            // 
            this.SideHide_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SideHide_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.SideHide_panel.Controls.Add(this.SideHidePanel_lbl6);
            this.SideHide_panel.Controls.Add(this.SideHidePanel_lbl5);
            this.SideHide_panel.Controls.Add(this.SideHidePanel_lbl4);
            this.SideHide_panel.Controls.Add(this.SideHidePanel_lbl3);
            this.SideHide_panel.Controls.Add(this.SideHidePanel_lbl2);
            this.SideHide_panel.Controls.Add(this.SideHidePanel_lbl1);
            this.SideHide_panel.Controls.Add(this.SideHidePanel_Main_lbl);
            this.SideHide_panel.Location = new System.Drawing.Point(100, 28);
            this.SideHide_panel.Name = "SideHide_panel";
            this.SideHide_panel.Size = new System.Drawing.Size(255, 853);
            this.SideHide_panel.TabIndex = 0;
            this.SideHide_panel.Visible = false;
            this.SideHide_panel.MouseLeave += new System.EventHandler(this.SideHide_panel_MouseLeave);
            this.SideHide_panel.MouseHover += new System.EventHandler(this.SideHide_panel_MouseHover);
            // 
            // SideHidePanel_lbl6
            // 
            this.SideHidePanel_lbl6.AutoSize = true;
            this.SideHidePanel_lbl6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SideHidePanel_lbl6.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SideHidePanel_lbl6.ForeColor = System.Drawing.Color.DarkGray;
            this.SideHidePanel_lbl6.Location = new System.Drawing.Point(39, 277);
            this.SideHidePanel_lbl6.Name = "SideHidePanel_lbl6";
            this.SideHidePanel_lbl6.Size = new System.Drawing.Size(124, 24);
            this.SideHidePanel_lbl6.TabIndex = 1;
            this.SideHidePanel_lbl6.Text = "DRIVER DATA";
            this.SideHidePanel_lbl6.Click += new System.EventHandler(this.SideHidePanel_lbl6_Click);
            this.SideHidePanel_lbl6.MouseLeave += new System.EventHandler(this.SideHidePanel_lbl6_MouseLeave);
            this.SideHidePanel_lbl6.MouseHover += new System.EventHandler(this.SideHidePanel_lbl6_MouseHover);
            // 
            // SideHidePanel_lbl5
            // 
            this.SideHidePanel_lbl5.AutoSize = true;
            this.SideHidePanel_lbl5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SideHidePanel_lbl5.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SideHidePanel_lbl5.ForeColor = System.Drawing.Color.DarkGray;
            this.SideHidePanel_lbl5.Location = new System.Drawing.Point(39, 240);
            this.SideHidePanel_lbl5.Name = "SideHidePanel_lbl5";
            this.SideHidePanel_lbl5.Size = new System.Drawing.Size(124, 24);
            this.SideHidePanel_lbl5.TabIndex = 1;
            this.SideHidePanel_lbl5.Text = "DRIVER DATA";
            this.SideHidePanel_lbl5.Click += new System.EventHandler(this.SideHidePanel_lbl5_Click);
            this.SideHidePanel_lbl5.MouseLeave += new System.EventHandler(this.SideHidePanel_lbl5_MouseLeave);
            this.SideHidePanel_lbl5.MouseHover += new System.EventHandler(this.SideHidePanel_lbl5_MouseHover);
            // 
            // SideHidePanel_lbl4
            // 
            this.SideHidePanel_lbl4.AutoSize = true;
            this.SideHidePanel_lbl4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SideHidePanel_lbl4.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SideHidePanel_lbl4.ForeColor = System.Drawing.Color.DarkGray;
            this.SideHidePanel_lbl4.Location = new System.Drawing.Point(39, 203);
            this.SideHidePanel_lbl4.Name = "SideHidePanel_lbl4";
            this.SideHidePanel_lbl4.Size = new System.Drawing.Size(124, 24);
            this.SideHidePanel_lbl4.TabIndex = 1;
            this.SideHidePanel_lbl4.Text = "DRIVER DATA";
            this.SideHidePanel_lbl4.Click += new System.EventHandler(this.SideHidePanel_lbl4_Click);
            this.SideHidePanel_lbl4.MouseLeave += new System.EventHandler(this.SideHidePanel_lbl4_MouseLeave);
            this.SideHidePanel_lbl4.MouseHover += new System.EventHandler(this.SideHidePanel_lbl4_MouseHover);
            // 
            // SideHidePanel_lbl3
            // 
            this.SideHidePanel_lbl3.AutoSize = true;
            this.SideHidePanel_lbl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SideHidePanel_lbl3.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SideHidePanel_lbl3.ForeColor = System.Drawing.Color.DarkGray;
            this.SideHidePanel_lbl3.Location = new System.Drawing.Point(39, 167);
            this.SideHidePanel_lbl3.Name = "SideHidePanel_lbl3";
            this.SideHidePanel_lbl3.Size = new System.Drawing.Size(124, 24);
            this.SideHidePanel_lbl3.TabIndex = 1;
            this.SideHidePanel_lbl3.Text = "DRIVER DATA";
            this.SideHidePanel_lbl3.Click += new System.EventHandler(this.SideHidePanel_lbl3_Click);
            this.SideHidePanel_lbl3.MouseLeave += new System.EventHandler(this.SideHidePanel_lbl3_MouseLeave);
            this.SideHidePanel_lbl3.MouseHover += new System.EventHandler(this.SideHidePanel_lbl3_MouseHover);
            // 
            // SideHidePanel_lbl2
            // 
            this.SideHidePanel_lbl2.AutoSize = true;
            this.SideHidePanel_lbl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SideHidePanel_lbl2.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SideHidePanel_lbl2.ForeColor = System.Drawing.Color.DarkGray;
            this.SideHidePanel_lbl2.Location = new System.Drawing.Point(39, 132);
            this.SideHidePanel_lbl2.Name = "SideHidePanel_lbl2";
            this.SideHidePanel_lbl2.Size = new System.Drawing.Size(124, 24);
            this.SideHidePanel_lbl2.TabIndex = 1;
            this.SideHidePanel_lbl2.Text = "DRIVER DATA";
            this.SideHidePanel_lbl2.Click += new System.EventHandler(this.SideHidePanel_lbl2_Click);
            this.SideHidePanel_lbl2.MouseLeave += new System.EventHandler(this.SideHidePanel_lbl2_MouseLeave);
            this.SideHidePanel_lbl2.MouseHover += new System.EventHandler(this.SideHidePanel_lbl2_MouseHover);
            // 
            // SideHidePanel_lbl1
            // 
            this.SideHidePanel_lbl1.AutoSize = true;
            this.SideHidePanel_lbl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SideHidePanel_lbl1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SideHidePanel_lbl1.ForeColor = System.Drawing.Color.DarkGray;
            this.SideHidePanel_lbl1.Location = new System.Drawing.Point(39, 97);
            this.SideHidePanel_lbl1.Name = "SideHidePanel_lbl1";
            this.SideHidePanel_lbl1.Size = new System.Drawing.Size(124, 24);
            this.SideHidePanel_lbl1.TabIndex = 1;
            this.SideHidePanel_lbl1.Text = "DRIVER DATA";
            this.SideHidePanel_lbl1.Click += new System.EventHandler(this.SideHidePanel_lbl1_Click);
            this.SideHidePanel_lbl1.MouseLeave += new System.EventHandler(this.SideHidePanel_lbl1_MouseLeave);
            this.SideHidePanel_lbl1.MouseHover += new System.EventHandler(this.SideHidePanel_lbl1_MouseHover);
            // 
            // SideHidePanel_Main_lbl
            // 
            this.SideHidePanel_Main_lbl.AutoSize = true;
            this.SideHidePanel_Main_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SideHidePanel_Main_lbl.ForeColor = System.Drawing.Color.White;
            this.SideHidePanel_Main_lbl.Location = new System.Drawing.Point(38, 16);
            this.SideHidePanel_Main_lbl.Name = "SideHidePanel_Main_lbl";
            this.SideHidePanel_Main_lbl.Size = new System.Drawing.Size(116, 26);
            this.SideHidePanel_Main_lbl.TabIndex = 0;
            this.SideHidePanel_Main_lbl.Text = "DATABASE";
            this.SideHidePanel_Main_lbl.MouseHover += new System.EventHandler(this.SideHidePanel_Main_lbl_MouseHover);
            // 
            // payment1
            // 
            this.payment1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.payment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payment1.Location = new System.Drawing.Point(0, 0);
            this.payment1.Name = "payment1";
            this.payment1.Size = new System.Drawing.Size(1469, 759);
            this.payment1.TabIndex = 6;
            // 
            // loadData1
            // 
            this.loadData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.loadData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadData1.Location = new System.Drawing.Point(0, 0);
            this.loadData1.Name = "loadData1";
            this.loadData1.Size = new System.Drawing.Size(1469, 759);
            this.loadData1.TabIndex = 5;
            // 
            // employeeData1
            // 
            this.employeeData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.employeeData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeData1.Location = new System.Drawing.Point(0, 0);
            this.employeeData1.Name = "employeeData1";
            this.employeeData1.Size = new System.Drawing.Size(1469, 759);
            this.employeeData1.TabIndex = 4;
            // 
            // startHome1
            // 
            this.startHome1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.startHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startHome1.Location = new System.Drawing.Point(0, 0);
            this.startHome1.Name = "startHome1";
            this.startHome1.Size = new System.Drawing.Size(1469, 759);
            this.startHome1.TabIndex = 3;
            this.startHome1.MouseHover += new System.EventHandler(this.startHome1_MouseHover);
            // 
            // jobData1
            // 
            this.jobData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.jobData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobData1.Location = new System.Drawing.Point(0, 0);
            this.jobData1.Name = "jobData1";
            this.jobData1.Size = new System.Drawing.Size(1469, 759);
            this.jobData1.TabIndex = 2;
            this.jobData1.MouseHover += new System.EventHandler(this.jobData1_MouseHover);
            // 
            // driverData1
            // 
            this.driverData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.driverData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driverData1.Location = new System.Drawing.Point(0, 0);
            this.driverData1.Name = "driverData1";
            this.driverData1.Size = new System.Drawing.Size(1469, 759);
            this.driverData1.TabIndex = 1;
            this.driverData1.MouseHover += new System.EventHandler(this.driverData1_MouseHover);
            // 
            // customerData1
            // 
            this.customerData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.customerData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerData1.Location = new System.Drawing.Point(0, 0);
            this.customerData1.Name = "customerData1";
            this.customerData1.Size = new System.Drawing.Size(1469, 759);
            this.customerData1.TabIndex = 0;
            this.customerData1.MouseHover += new System.EventHandler(this.customerData1_MouseHover);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 881);
            this.Controls.Add(this.SideHide_panel);
            this.Controls.Add(this.BackgroundBody_panel);
            this.Controls.Add(this.MainMenu_MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu_MenuStrip;
            this.MinimumSize = new System.Drawing.Size(1587, 928);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Mover";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.BackgroundBody_panel.ResumeLayout(false);
            this.Body_panel.ResumeLayout(false);
            this.Top_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.SideNotHide_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataBase_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainMenu_MenuStrip.ResumeLayout(false);
            this.MainMenu_MenuStrip.PerformLayout();
            this.SideHide_panel.ResumeLayout(false);
            this.SideHide_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BackgroundBody_panel;
        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.Panel SideNotHide_panel;
        private System.Windows.Forms.MenuStrip MainMenu_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem File_menuicon;
        private System.Windows.Forms.ToolStripMenuItem Edit__menuicon;
        private System.Windows.Forms.ToolStripMenuItem Settings_Edit_menuicon;
        private System.Windows.Forms.ToolStripMenuItem View_menuicon;
        private System.Windows.Forms.ToolStripMenuItem Reload_View_menuicon;
        private System.Windows.Forms.ToolStripMenuItem ToggelFScreen_View_menuicon;
        private System.Windows.Forms.ToolStripMenuItem Windows_menuicon;
        private System.Windows.Forms.ToolStripMenuItem ToggelTop_WIN_menuicon;
        private System.Windows.Forms.ToolStripMenuItem Help_menuicon;
        private System.Windows.Forms.ToolStripMenuItem SoftwareLicense_menuicon;
        private System.Windows.Forms.ToolStripMenuItem Report_Help_SoftL_menuicon;
        private System.Windows.Forms.ToolStripMenuItem ShowLogs_Help_SL_menuicon;
        private System.Windows.Forms.ToolStripMenuItem Troubleshooting_menuicon;
        private System.Windows.Forms.ToolStripMenuItem CheckUpdates_menuicon;
        private System.Windows.Forms.Panel Body_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Home_BTN;
        private System.Windows.Forms.PictureBox DataBase_BTN;
        private System.Windows.Forms.ToolStripMenuItem Exit_File_menuicon;
        private System.Windows.Forms.Label SideHidePanel_lbl6;
        private System.Windows.Forms.Label SideHidePanel_lbl5;
        private System.Windows.Forms.Label SideHidePanel_lbl4;
        private System.Windows.Forms.Label SideHidePanel_lbl3;
        private System.Windows.Forms.Label SideHidePanel_lbl2;
        private System.Windows.Forms.Label SideHidePanel_lbl1;
        private System.Windows.Forms.Label SideHidePanel_Main_lbl;
        private System.Windows.Forms.Panel SideHide_panel;
        private System.Windows.Forms.ToolStripMenuItem About_menuicon;
        private src.DataBase.Job.JobData jobData1;
        private src.DataBase.Driver.DriverData driverData1;
        private src.DataBase.Customer.CustomerData customerData1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private src.Home.StartHome startHome1;
        private System.Windows.Forms.ToolStripMenuItem reportAnIssueToolStripMenuItem;
        protected Bunifu.Framework.UI.BunifuFlatButton LogOut_btn;
        private src.DataBase.Employee.EmployeeData employeeData1;
        private src.DataBase.Load.LoadData loadData1;
        private src.DataBase.Payment.Payment payment1;
    }
}

