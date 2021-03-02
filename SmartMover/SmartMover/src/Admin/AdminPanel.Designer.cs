namespace SmartMover.src.Admin
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AdminPanel_TabController = new System.Windows.Forms.TabControl();
            this.NewUser_TabPage = new System.Windows.Forms.TabPage();
            this.NewUserReload_btn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserAccept_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.JobReject_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Role_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Role_lbl = new System.Windows.Forms.Label();
            this.Email_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.UserName_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UserName_lbl = new System.Windows.Forms.Label();
            this.NewUser_datagridview = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.SystemUser_TabPage = new System.Windows.Forms.TabPage();
            this.SystemUserReload_btn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StopWork_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.KickOut_txt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.User_Role_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.User_Role_lbl = new System.Windows.Forms.Label();
            this.User_Email_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.User_Email_lbl = new System.Windows.Forms.Label();
            this.User_Username_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.User_Username_lbl = new System.Windows.Forms.Label();
            this.SystemUsers_datagridview = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.WaitingUsers_txt = new System.Windows.Forms.Label();
            this.WaitingUsers_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Users_lbl = new System.Windows.Forms.Label();
            this.SideHidePanel_Main_lbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdminPanel_TabController.SuspendLayout();
            this.NewUser_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewUserReload_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewUser_datagridview)).BeginInit();
            this.SystemUser_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SystemUserReload_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemUsers_datagridview)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminPanel_TabController
            // 
            this.AdminPanel_TabController.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminPanel_TabController.Controls.Add(this.NewUser_TabPage);
            this.AdminPanel_TabController.Controls.Add(this.SystemUser_TabPage);
            this.AdminPanel_TabController.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPanel_TabController.Location = new System.Drawing.Point(31, 162);
            this.AdminPanel_TabController.Name = "AdminPanel_TabController";
            this.AdminPanel_TabController.SelectedIndex = 0;
            this.AdminPanel_TabController.Size = new System.Drawing.Size(1505, 689);
            this.AdminPanel_TabController.TabIndex = 0;
            // 
            // NewUser_TabPage
            // 
            this.NewUser_TabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.NewUser_TabPage.Controls.Add(this.NewUserReload_btn);
            this.NewUser_TabPage.Controls.Add(this.label1);
            this.NewUser_TabPage.Controls.Add(this.UserAccept_btn);
            this.NewUser_TabPage.Controls.Add(this.JobReject_btn);
            this.NewUser_TabPage.Controls.Add(this.Role_txt);
            this.NewUser_TabPage.Controls.Add(this.Role_lbl);
            this.NewUser_TabPage.Controls.Add(this.Email_txt);
            this.NewUser_TabPage.Controls.Add(this.Email_lbl);
            this.NewUser_TabPage.Controls.Add(this.UserName_txt);
            this.NewUser_TabPage.Controls.Add(this.UserName_lbl);
            this.NewUser_TabPage.Controls.Add(this.NewUser_datagridview);
            this.NewUser_TabPage.Location = new System.Drawing.Point(4, 25);
            this.NewUser_TabPage.Name = "NewUser_TabPage";
            this.NewUser_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NewUser_TabPage.Size = new System.Drawing.Size(1497, 660);
            this.NewUser_TabPage.TabIndex = 0;
            this.NewUser_TabPage.Text = "New Users Accept";
            // 
            // NewUserReload_btn
            // 
            this.NewUserReload_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewUserReload_btn.Image = ((System.Drawing.Image)(resources.GetObject("NewUserReload_btn.Image")));
            this.NewUserReload_btn.Location = new System.Drawing.Point(562, 17);
            this.NewUserReload_btn.Name = "NewUserReload_btn";
            this.NewUserReload_btn.Size = new System.Drawing.Size(55, 45);
            this.NewUserReload_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.NewUserReload_btn.TabIndex = 38;
            this.NewUserReload_btn.TabStop = false;
            this.NewUserReload_btn.Click += new System.EventHandler(this.NewUserReload_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 37;
            this.label1.Text = "NEW USERS";
            // 
            // UserAccept_btn
            // 
            this.UserAccept_btn.Active = false;
            this.UserAccept_btn.Activecolor = System.Drawing.Color.ForestGreen;
            this.UserAccept_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UserAccept_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.UserAccept_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserAccept_btn.BorderRadius = 7;
            this.UserAccept_btn.ButtonText = "ACCEPT";
            this.UserAccept_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserAccept_btn.DisabledColor = System.Drawing.Color.Gray;
            this.UserAccept_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.UserAccept_btn.Iconimage = null;
            this.UserAccept_btn.Iconimage_right = null;
            this.UserAccept_btn.Iconimage_right_Selected = null;
            this.UserAccept_btn.Iconimage_Selected = null;
            this.UserAccept_btn.IconMarginLeft = 0;
            this.UserAccept_btn.IconMarginRight = 0;
            this.UserAccept_btn.IconRightVisible = true;
            this.UserAccept_btn.IconRightZoom = 0D;
            this.UserAccept_btn.IconVisible = true;
            this.UserAccept_btn.IconZoom = 90D;
            this.UserAccept_btn.IsTab = false;
            this.UserAccept_btn.Location = new System.Drawing.Point(39, 593);
            this.UserAccept_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserAccept_btn.Name = "UserAccept_btn";
            this.UserAccept_btn.Normalcolor = System.Drawing.Color.ForestGreen;
            this.UserAccept_btn.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.UserAccept_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.UserAccept_btn.selected = false;
            this.UserAccept_btn.Size = new System.Drawing.Size(131, 50);
            this.UserAccept_btn.TabIndex = 36;
            this.UserAccept_btn.Text = "ACCEPT";
            this.UserAccept_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UserAccept_btn.Textcolor = System.Drawing.Color.White;
            this.UserAccept_btn.TextFont = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.UserAccept_btn.Click += new System.EventHandler(this.UserAccept_btn_Click);
            // 
            // JobReject_btn
            // 
            this.JobReject_btn.Active = false;
            this.JobReject_btn.Activecolor = System.Drawing.Color.DarkRed;
            this.JobReject_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.JobReject_btn.BackColor = System.Drawing.Color.Red;
            this.JobReject_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JobReject_btn.BorderRadius = 7;
            this.JobReject_btn.ButtonText = "REJECT";
            this.JobReject_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JobReject_btn.DisabledColor = System.Drawing.Color.Gray;
            this.JobReject_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.JobReject_btn.Iconimage = null;
            this.JobReject_btn.Iconimage_right = null;
            this.JobReject_btn.Iconimage_right_Selected = null;
            this.JobReject_btn.Iconimage_Selected = null;
            this.JobReject_btn.IconMarginLeft = 0;
            this.JobReject_btn.IconMarginRight = 0;
            this.JobReject_btn.IconRightVisible = true;
            this.JobReject_btn.IconRightZoom = 0D;
            this.JobReject_btn.IconVisible = true;
            this.JobReject_btn.IconZoom = 90D;
            this.JobReject_btn.IsTab = false;
            this.JobReject_btn.Location = new System.Drawing.Point(441, 593);
            this.JobReject_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JobReject_btn.Name = "JobReject_btn";
            this.JobReject_btn.Normalcolor = System.Drawing.Color.Red;
            this.JobReject_btn.OnHovercolor = System.Drawing.Color.Crimson;
            this.JobReject_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.JobReject_btn.selected = false;
            this.JobReject_btn.Size = new System.Drawing.Size(131, 50);
            this.JobReject_btn.TabIndex = 35;
            this.JobReject_btn.Text = "REJECT";
            this.JobReject_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.JobReject_btn.Textcolor = System.Drawing.Color.White;
            this.JobReject_btn.TextFont = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.JobReject_btn.Click += new System.EventHandler(this.JobReject_btn_Click);
            // 
            // Role_txt
            // 
            this.Role_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Role_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Role_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Role_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Role_txt.Enabled = false;
            this.Role_txt.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.Role_txt.ForeColor = System.Drawing.Color.White;
            this.Role_txt.HintForeColor = System.Drawing.Color.Gray;
            this.Role_txt.HintText = "Role";
            this.Role_txt.isPassword = false;
            this.Role_txt.LineFocusedColor = System.Drawing.Color.White;
            this.Role_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.Role_txt.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.Role_txt.LineThickness = 3;
            this.Role_txt.Location = new System.Drawing.Point(214, 250);
            this.Role_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Role_txt.MaxLength = 32767;
            this.Role_txt.Name = "Role_txt";
            this.Role_txt.Size = new System.Drawing.Size(348, 36);
            this.Role_txt.TabIndex = 34;
            this.Role_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Role_lbl
            // 
            this.Role_lbl.AutoSize = true;
            this.Role_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.Role_lbl.ForeColor = System.Drawing.Color.White;
            this.Role_lbl.Location = new System.Drawing.Point(35, 256);
            this.Role_lbl.Name = "Role_lbl";
            this.Role_lbl.Size = new System.Drawing.Size(47, 24);
            this.Role_lbl.TabIndex = 33;
            this.Role_lbl.Text = "Role";
            // 
            // Email_txt
            // 
            this.Email_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Email_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Email_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Email_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email_txt.Enabled = false;
            this.Email_txt.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.Email_txt.ForeColor = System.Drawing.Color.White;
            this.Email_txt.HintForeColor = System.Drawing.Color.Gray;
            this.Email_txt.HintText = "Email";
            this.Email_txt.isPassword = false;
            this.Email_txt.LineFocusedColor = System.Drawing.Color.White;
            this.Email_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.Email_txt.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.Email_txt.LineThickness = 3;
            this.Email_txt.Location = new System.Drawing.Point(214, 184);
            this.Email_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Email_txt.MaxLength = 32767;
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(348, 36);
            this.Email_txt.TabIndex = 32;
            this.Email_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.Email_lbl.ForeColor = System.Drawing.Color.White;
            this.Email_lbl.Location = new System.Drawing.Point(35, 190);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(56, 24);
            this.Email_lbl.TabIndex = 31;
            this.Email_lbl.Text = "Email";
            // 
            // UserName_txt
            // 
            this.UserName_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserName_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserName_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserName_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName_txt.Enabled = false;
            this.UserName_txt.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.UserName_txt.ForeColor = System.Drawing.Color.White;
            this.UserName_txt.HintForeColor = System.Drawing.Color.Gray;
            this.UserName_txt.HintText = "Username";
            this.UserName_txt.isPassword = false;
            this.UserName_txt.LineFocusedColor = System.Drawing.Color.White;
            this.UserName_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.UserName_txt.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.UserName_txt.LineThickness = 3;
            this.UserName_txt.Location = new System.Drawing.Point(214, 118);
            this.UserName_txt.Margin = new System.Windows.Forms.Padding(4);
            this.UserName_txt.MaxLength = 32767;
            this.UserName_txt.Name = "UserName_txt";
            this.UserName_txt.Size = new System.Drawing.Size(348, 36);
            this.UserName_txt.TabIndex = 30;
            this.UserName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UserName_lbl
            // 
            this.UserName_lbl.AutoSize = true;
            this.UserName_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.UserName_lbl.ForeColor = System.Drawing.Color.White;
            this.UserName_lbl.Location = new System.Drawing.Point(35, 124);
            this.UserName_lbl.Name = "UserName_lbl";
            this.UserName_lbl.Size = new System.Drawing.Size(98, 24);
            this.UserName_lbl.TabIndex = 29;
            this.UserName_lbl.Text = "UserName";
            // 
            // NewUser_datagridview
            // 
            this.NewUser_datagridview.AllowUserToAddRows = false;
            this.NewUser_datagridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NewUser_datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.NewUser_datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewUser_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NewUser_datagridview.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.NewUser_datagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewUser_datagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NewUser_datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.NewUser_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NewUser_datagridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.NewUser_datagridview.DoubleBuffered = true;
            this.NewUser_datagridview.EnableHeadersVisualStyles = false;
            this.NewUser_datagridview.HeaderBgColor = System.Drawing.Color.Gray;
            this.NewUser_datagridview.HeaderForeColor = System.Drawing.Color.Black;
            this.NewUser_datagridview.Location = new System.Drawing.Point(623, 17);
            this.NewUser_datagridview.Name = "NewUser_datagridview";
            this.NewUser_datagridview.ReadOnly = true;
            this.NewUser_datagridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NewUser_datagridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.NewUser_datagridview.RowHeadersVisible = false;
            this.NewUser_datagridview.RowHeadersWidth = 51;
            this.NewUser_datagridview.RowTemplate.Height = 24;
            this.NewUser_datagridview.Size = new System.Drawing.Size(860, 626);
            this.NewUser_datagridview.TabIndex = 3;
            this.NewUser_datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NewUser_datagridview_CellClick);
            // 
            // SystemUser_TabPage
            // 
            this.SystemUser_TabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.SystemUser_TabPage.Controls.Add(this.SystemUserReload_btn);
            this.SystemUser_TabPage.Controls.Add(this.label2);
            this.SystemUser_TabPage.Controls.Add(this.StopWork_btn);
            this.SystemUser_TabPage.Controls.Add(this.KickOut_txt);
            this.SystemUser_TabPage.Controls.Add(this.User_Role_txt);
            this.SystemUser_TabPage.Controls.Add(this.User_Role_lbl);
            this.SystemUser_TabPage.Controls.Add(this.User_Email_txt);
            this.SystemUser_TabPage.Controls.Add(this.User_Email_lbl);
            this.SystemUser_TabPage.Controls.Add(this.User_Username_txt);
            this.SystemUser_TabPage.Controls.Add(this.User_Username_lbl);
            this.SystemUser_TabPage.Controls.Add(this.SystemUsers_datagridview);
            this.SystemUser_TabPage.Location = new System.Drawing.Point(4, 25);
            this.SystemUser_TabPage.Name = "SystemUser_TabPage";
            this.SystemUser_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SystemUser_TabPage.Size = new System.Drawing.Size(1497, 660);
            this.SystemUser_TabPage.TabIndex = 1;
            this.SystemUser_TabPage.Text = "System Users";
            // 
            // SystemUserReload_btn
            // 
            this.SystemUserReload_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SystemUserReload_btn.Image = ((System.Drawing.Image)(resources.GetObject("SystemUserReload_btn.Image")));
            this.SystemUserReload_btn.Location = new System.Drawing.Point(562, 17);
            this.SystemUserReload_btn.Name = "SystemUserReload_btn";
            this.SystemUserReload_btn.Size = new System.Drawing.Size(55, 45);
            this.SystemUserReload_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SystemUserReload_btn.TabIndex = 6;
            this.SystemUserReload_btn.TabStop = false;
            this.SystemUserReload_btn.Click += new System.EventHandler(this.SystemUserReload_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(210, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 36);
            this.label2.TabIndex = 46;
            this.label2.Text = "SYSTEM USERS";
            // 
            // StopWork_btn
            // 
            this.StopWork_btn.Active = false;
            this.StopWork_btn.Activecolor = System.Drawing.Color.ForestGreen;
            this.StopWork_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopWork_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.StopWork_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopWork_btn.BorderRadius = 7;
            this.StopWork_btn.ButtonText = "STOP WORK";
            this.StopWork_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopWork_btn.DisabledColor = System.Drawing.Color.Gray;
            this.StopWork_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.StopWork_btn.Iconimage = null;
            this.StopWork_btn.Iconimage_right = null;
            this.StopWork_btn.Iconimage_right_Selected = null;
            this.StopWork_btn.Iconimage_Selected = null;
            this.StopWork_btn.IconMarginLeft = 0;
            this.StopWork_btn.IconMarginRight = 0;
            this.StopWork_btn.IconRightVisible = false;
            this.StopWork_btn.IconRightZoom = 0D;
            this.StopWork_btn.IconVisible = false;
            this.StopWork_btn.IconZoom = 90D;
            this.StopWork_btn.IsTab = false;
            this.StopWork_btn.Location = new System.Drawing.Point(41, 593);
            this.StopWork_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StopWork_btn.Name = "StopWork_btn";
            this.StopWork_btn.Normalcolor = System.Drawing.Color.ForestGreen;
            this.StopWork_btn.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.StopWork_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.StopWork_btn.selected = false;
            this.StopWork_btn.Size = new System.Drawing.Size(139, 50);
            this.StopWork_btn.TabIndex = 45;
            this.StopWork_btn.Text = "STOP WORK";
            this.StopWork_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StopWork_btn.Textcolor = System.Drawing.Color.White;
            this.StopWork_btn.TextFont = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.StopWork_btn.Click += new System.EventHandler(this.StopWork_btn_Click);
            // 
            // KickOut_txt
            // 
            this.KickOut_txt.Active = false;
            this.KickOut_txt.Activecolor = System.Drawing.Color.DarkRed;
            this.KickOut_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.KickOut_txt.BackColor = System.Drawing.Color.Red;
            this.KickOut_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KickOut_txt.BorderRadius = 7;
            this.KickOut_txt.ButtonText = "KICK OUT";
            this.KickOut_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KickOut_txt.DisabledColor = System.Drawing.Color.Gray;
            this.KickOut_txt.Iconcolor = System.Drawing.Color.Transparent;
            this.KickOut_txt.Iconimage = null;
            this.KickOut_txt.Iconimage_right = null;
            this.KickOut_txt.Iconimage_right_Selected = null;
            this.KickOut_txt.Iconimage_Selected = null;
            this.KickOut_txt.IconMarginLeft = 0;
            this.KickOut_txt.IconMarginRight = 0;
            this.KickOut_txt.IconRightVisible = false;
            this.KickOut_txt.IconRightZoom = 0D;
            this.KickOut_txt.IconVisible = false;
            this.KickOut_txt.IconZoom = 90D;
            this.KickOut_txt.IsTab = false;
            this.KickOut_txt.Location = new System.Drawing.Point(443, 593);
            this.KickOut_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KickOut_txt.Name = "KickOut_txt";
            this.KickOut_txt.Normalcolor = System.Drawing.Color.Red;
            this.KickOut_txt.OnHovercolor = System.Drawing.Color.Crimson;
            this.KickOut_txt.OnHoverTextColor = System.Drawing.Color.White;
            this.KickOut_txt.selected = false;
            this.KickOut_txt.Size = new System.Drawing.Size(131, 50);
            this.KickOut_txt.TabIndex = 44;
            this.KickOut_txt.Text = "KICK OUT";
            this.KickOut_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.KickOut_txt.Textcolor = System.Drawing.Color.White;
            this.KickOut_txt.TextFont = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.KickOut_txt.Click += new System.EventHandler(this.KickOut_txt_Click);
            // 
            // User_Role_txt
            // 
            this.User_Role_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.User_Role_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.User_Role_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.User_Role_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.User_Role_txt.Enabled = false;
            this.User_Role_txt.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.User_Role_txt.ForeColor = System.Drawing.Color.White;
            this.User_Role_txt.HintForeColor = System.Drawing.Color.Gray;
            this.User_Role_txt.HintText = "Role";
            this.User_Role_txt.isPassword = false;
            this.User_Role_txt.LineFocusedColor = System.Drawing.Color.White;
            this.User_Role_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.User_Role_txt.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.User_Role_txt.LineThickness = 3;
            this.User_Role_txt.Location = new System.Drawing.Point(216, 250);
            this.User_Role_txt.Margin = new System.Windows.Forms.Padding(4);
            this.User_Role_txt.MaxLength = 32767;
            this.User_Role_txt.Name = "User_Role_txt";
            this.User_Role_txt.Size = new System.Drawing.Size(348, 36);
            this.User_Role_txt.TabIndex = 43;
            this.User_Role_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // User_Role_lbl
            // 
            this.User_Role_lbl.AutoSize = true;
            this.User_Role_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.User_Role_lbl.ForeColor = System.Drawing.Color.White;
            this.User_Role_lbl.Location = new System.Drawing.Point(37, 256);
            this.User_Role_lbl.Name = "User_Role_lbl";
            this.User_Role_lbl.Size = new System.Drawing.Size(47, 24);
            this.User_Role_lbl.TabIndex = 42;
            this.User_Role_lbl.Text = "Role";
            // 
            // User_Email_txt
            // 
            this.User_Email_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.User_Email_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.User_Email_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.User_Email_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.User_Email_txt.Enabled = false;
            this.User_Email_txt.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.User_Email_txt.ForeColor = System.Drawing.Color.White;
            this.User_Email_txt.HintForeColor = System.Drawing.Color.Gray;
            this.User_Email_txt.HintText = "Email";
            this.User_Email_txt.isPassword = false;
            this.User_Email_txt.LineFocusedColor = System.Drawing.Color.White;
            this.User_Email_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.User_Email_txt.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.User_Email_txt.LineThickness = 3;
            this.User_Email_txt.Location = new System.Drawing.Point(216, 184);
            this.User_Email_txt.Margin = new System.Windows.Forms.Padding(4);
            this.User_Email_txt.MaxLength = 32767;
            this.User_Email_txt.Name = "User_Email_txt";
            this.User_Email_txt.Size = new System.Drawing.Size(348, 36);
            this.User_Email_txt.TabIndex = 41;
            this.User_Email_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // User_Email_lbl
            // 
            this.User_Email_lbl.AutoSize = true;
            this.User_Email_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.User_Email_lbl.ForeColor = System.Drawing.Color.White;
            this.User_Email_lbl.Location = new System.Drawing.Point(37, 190);
            this.User_Email_lbl.Name = "User_Email_lbl";
            this.User_Email_lbl.Size = new System.Drawing.Size(56, 24);
            this.User_Email_lbl.TabIndex = 40;
            this.User_Email_lbl.Text = "Email";
            // 
            // User_Username_txt
            // 
            this.User_Username_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.User_Username_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.User_Username_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.User_Username_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.User_Username_txt.Enabled = false;
            this.User_Username_txt.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.User_Username_txt.ForeColor = System.Drawing.Color.White;
            this.User_Username_txt.HintForeColor = System.Drawing.Color.Gray;
            this.User_Username_txt.HintText = "Username";
            this.User_Username_txt.isPassword = false;
            this.User_Username_txt.LineFocusedColor = System.Drawing.Color.White;
            this.User_Username_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.User_Username_txt.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.User_Username_txt.LineThickness = 3;
            this.User_Username_txt.Location = new System.Drawing.Point(216, 118);
            this.User_Username_txt.Margin = new System.Windows.Forms.Padding(4);
            this.User_Username_txt.MaxLength = 32767;
            this.User_Username_txt.Name = "User_Username_txt";
            this.User_Username_txt.Size = new System.Drawing.Size(348, 36);
            this.User_Username_txt.TabIndex = 39;
            this.User_Username_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // User_Username_lbl
            // 
            this.User_Username_lbl.AutoSize = true;
            this.User_Username_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.User_Username_lbl.ForeColor = System.Drawing.Color.White;
            this.User_Username_lbl.Location = new System.Drawing.Point(37, 124);
            this.User_Username_lbl.Name = "User_Username_lbl";
            this.User_Username_lbl.Size = new System.Drawing.Size(98, 24);
            this.User_Username_lbl.TabIndex = 38;
            this.User_Username_lbl.Text = "UserName";
            // 
            // SystemUsers_datagridview
            // 
            this.SystemUsers_datagridview.AllowUserToAddRows = false;
            this.SystemUsers_datagridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SystemUsers_datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.SystemUsers_datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemUsers_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SystemUsers_datagridview.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.SystemUsers_datagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SystemUsers_datagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SystemUsers_datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.SystemUsers_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SystemUsers_datagridview.DefaultCellStyle = dataGridViewCellStyle7;
            this.SystemUsers_datagridview.DoubleBuffered = true;
            this.SystemUsers_datagridview.EnableHeadersVisualStyles = false;
            this.SystemUsers_datagridview.HeaderBgColor = System.Drawing.Color.Gray;
            this.SystemUsers_datagridview.HeaderForeColor = System.Drawing.Color.Black;
            this.SystemUsers_datagridview.Location = new System.Drawing.Point(623, 17);
            this.SystemUsers_datagridview.Name = "SystemUsers_datagridview";
            this.SystemUsers_datagridview.ReadOnly = true;
            this.SystemUsers_datagridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SystemUsers_datagridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.SystemUsers_datagridview.RowHeadersVisible = false;
            this.SystemUsers_datagridview.RowHeadersWidth = 51;
            this.SystemUsers_datagridview.RowTemplate.Height = 24;
            this.SystemUsers_datagridview.Size = new System.Drawing.Size(860, 626);
            this.SystemUsers_datagridview.TabIndex = 4;
            this.SystemUsers_datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SystemUsers_datagridview_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1569, 143);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.WaitingUsers_txt);
            this.panel3.Controls.Add(this.WaitingUsers_lbl);
            this.panel3.Location = new System.Drawing.Point(951, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 111);
            this.panel3.TabIndex = 5;
            // 
            // WaitingUsers_txt
            // 
            this.WaitingUsers_txt.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitingUsers_txt.ForeColor = System.Drawing.Color.White;
            this.WaitingUsers_txt.Location = new System.Drawing.Point(0, 36);
            this.WaitingUsers_txt.Name = "WaitingUsers_txt";
            this.WaitingUsers_txt.Size = new System.Drawing.Size(167, 53);
            this.WaitingUsers_txt.TabIndex = 2;
            this.WaitingUsers_txt.Text = "00";
            this.WaitingUsers_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WaitingUsers_lbl
            // 
            this.WaitingUsers_lbl.AutoSize = true;
            this.WaitingUsers_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitingUsers_lbl.ForeColor = System.Drawing.Color.White;
            this.WaitingUsers_lbl.Location = new System.Drawing.Point(0, 10);
            this.WaitingUsers_lbl.Name = "WaitingUsers_lbl";
            this.WaitingUsers_lbl.Size = new System.Drawing.Size(166, 26);
            this.WaitingUsers_lbl.TabIndex = 1;
            this.WaitingUsers_lbl.Text = "WAITING USERS";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.Users_lbl);
            this.panel2.Controls.Add(this.SideHidePanel_Main_lbl);
            this.panel2.Location = new System.Drawing.Point(1184, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 111);
            this.panel2.TabIndex = 4;
            // 
            // Users_lbl
            // 
            this.Users_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_lbl.ForeColor = System.Drawing.Color.White;
            this.Users_lbl.Location = new System.Drawing.Point(0, 36);
            this.Users_lbl.Name = "Users_lbl";
            this.Users_lbl.Size = new System.Drawing.Size(146, 53);
            this.Users_lbl.TabIndex = 2;
            this.Users_lbl.Text = "00";
            this.Users_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SideHidePanel_Main_lbl
            // 
            this.SideHidePanel_Main_lbl.AutoSize = true;
            this.SideHidePanel_Main_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SideHidePanel_Main_lbl.ForeColor = System.Drawing.Color.White;
            this.SideHidePanel_Main_lbl.Location = new System.Drawing.Point(38, 10);
            this.SideHidePanel_Main_lbl.Name = "SideHidePanel_Main_lbl";
            this.SideHidePanel_Main_lbl.Size = new System.Drawing.Size(72, 26);
            this.SideHidePanel_Main_lbl.TabIndex = 1;
            this.SideHidePanel_Main_lbl.Text = "USERS";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Location = new System.Drawing.Point(719, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(146, 111);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(461, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 111);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(209, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 111);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1569, 881);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AdminPanel_TabController);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1587, 928);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.AdminPanel_TabController.ResumeLayout(false);
            this.NewUser_TabPage.ResumeLayout(false);
            this.NewUser_TabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewUserReload_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewUser_datagridview)).EndInit();
            this.SystemUser_TabPage.ResumeLayout(false);
            this.SystemUser_TabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SystemUserReload_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemUsers_datagridview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AdminPanel_TabController;
        private System.Windows.Forms.TabPage NewUser_TabPage;
        private System.Windows.Forms.TabPage SystemUser_TabPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SideHidePanel_Main_lbl;
        private System.Windows.Forms.Label Users_lbl;
        private Bunifu.Framework.UI.BunifuCustomDataGrid NewUser_datagridview;
        private System.Windows.Forms.Label Role_lbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Email_txt;
        private System.Windows.Forms.Label Email_lbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserName_txt;
        private System.Windows.Forms.Label UserName_lbl;
        protected Bunifu.Framework.UI.BunifuFlatButton UserAccept_btn;
        protected Bunifu.Framework.UI.BunifuFlatButton JobReject_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label WaitingUsers_txt;
        private System.Windows.Forms.Label WaitingUsers_lbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Role_txt;
        private Bunifu.Framework.UI.BunifuCustomDataGrid SystemUsers_datagridview;
        private System.Windows.Forms.Label label2;
        protected Bunifu.Framework.UI.BunifuFlatButton StopWork_btn;
        protected Bunifu.Framework.UI.BunifuFlatButton KickOut_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox User_Role_txt;
        private System.Windows.Forms.Label User_Role_lbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox User_Email_txt;
        private System.Windows.Forms.Label User_Email_lbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox User_Username_txt;
        private System.Windows.Forms.Label User_Username_lbl;
        private System.Windows.Forms.PictureBox SystemUserReload_btn;
        private System.Windows.Forms.PictureBox NewUserReload_btn;
    }
}