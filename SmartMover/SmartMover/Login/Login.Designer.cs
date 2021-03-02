namespace SmartMover.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Image_panel = new System.Windows.Forms.Panel();
            this.SignUp_panel = new System.Windows.Forms.Panel();
            this.BacktoSignIn_lbl = new System.Windows.Forms.LinkLabel();
            this.SignupEmail_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.User_pic2 = new System.Windows.Forms.PictureBox();
            this.SignUp_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SignupUsername_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SignupPassword_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Icon_pic = new System.Windows.Forms.PictureBox();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.SignIn_panel = new System.Windows.Forms.Panel();
            this.User_pic = new System.Windows.Forms.PictureBox();
            this.SignUp_lbl = new System.Windows.Forms.LinkLabel();
            this.SignIn_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Username_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Password_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Close_btn = new System.Windows.Forms.Button();
            this.pic_DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.IconImage_DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.UserPic_DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MainPanel_DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ErrorMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.Image_panel.SuspendLayout();
            this.SignUp_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_pic)).BeginInit();
            this.Main_panel.SuspendLayout();
            this.SignIn_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // Image_panel
            // 
            this.Image_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Image_panel.BackgroundImage")));
            this.Image_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Image_panel.Controls.Add(this.Icon_pic);
            this.Image_panel.Controls.Add(this.Main_panel);
            this.Image_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Image_panel.Location = new System.Drawing.Point(0, 0);
            this.Image_panel.Name = "Image_panel";
            this.Image_panel.Size = new System.Drawing.Size(1060, 582);
            this.Image_panel.TabIndex = 0;
            // 
            // SignUp_panel
            // 
            this.SignUp_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.SignUp_panel.Controls.Add(this.SignupEmail_txt);
            this.SignUp_panel.Controls.Add(this.User_pic2);
            this.SignUp_panel.Controls.Add(this.SignUp_btn);
            this.SignUp_panel.Controls.Add(this.SignupUsername_txt);
            this.SignUp_panel.Controls.Add(this.SignupPassword_txt);
            this.SignUp_panel.Location = new System.Drawing.Point(3, 60);
            this.SignUp_panel.Name = "SignUp_panel";
            this.SignUp_panel.Size = new System.Drawing.Size(475, 447);
            this.SignUp_panel.TabIndex = 7;
            // 
            // BacktoSignIn_lbl
            // 
            this.BacktoSignIn_lbl.ActiveLinkColor = System.Drawing.Color.White;
            this.BacktoSignIn_lbl.AutoSize = true;
            this.BacktoSignIn_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BacktoSignIn_lbl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BacktoSignIn_lbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.BacktoSignIn_lbl.LinkColor = System.Drawing.Color.White;
            this.BacktoSignIn_lbl.Location = new System.Drawing.Point(263, 549);
            this.BacktoSignIn_lbl.Name = "BacktoSignIn_lbl";
            this.BacktoSignIn_lbl.Size = new System.Drawing.Size(200, 21);
            this.BacktoSignIn_lbl.TabIndex = 6;
            this.BacktoSignIn_lbl.TabStop = true;
            this.BacktoSignIn_lbl.Text = "Already have account";
            this.BacktoSignIn_lbl.Visible = false;
            this.BacktoSignIn_lbl.VisitedLinkColor = System.Drawing.Color.White;
            this.BacktoSignIn_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BacktoSignIn_lbl_LinkClicked);
            // 
            // SignupEmail_txt
            // 
            this.SignupEmail_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SignupEmail_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SignupEmail_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SignupEmail_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SignupEmail_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SignupEmail_txt.ForeColor = System.Drawing.Color.White;
            this.SignupEmail_txt.HintForeColor = System.Drawing.Color.DarkGray;
            this.SignupEmail_txt.HintText = "Email";
            this.SignupEmail_txt.isPassword = false;
            this.SignupEmail_txt.LineFocusedColor = System.Drawing.Color.White;
            this.SignupEmail_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.SignupEmail_txt.LineMouseHoverColor = System.Drawing.Color.DarkGray;
            this.SignupEmail_txt.LineThickness = 3;
            this.SignupEmail_txt.Location = new System.Drawing.Point(52, 237);
            this.SignupEmail_txt.Margin = new System.Windows.Forms.Padding(4);
            this.SignupEmail_txt.MaxLength = 32767;
            this.SignupEmail_txt.Name = "SignupEmail_txt";
            this.SignupEmail_txt.Size = new System.Drawing.Size(379, 33);
            this.SignupEmail_txt.TabIndex = 4;
            this.SignupEmail_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // User_pic2
            // 
            this.User_pic2.Image = ((System.Drawing.Image)(resources.GetObject("User_pic2.Image")));
            this.User_pic2.Location = new System.Drawing.Point(173, 28);
            this.User_pic2.Name = "User_pic2";
            this.User_pic2.Size = new System.Drawing.Size(123, 115);
            this.User_pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.User_pic2.TabIndex = 2;
            this.User_pic2.TabStop = false;
            // 
            // SignUp_btn
            // 
            this.SignUp_btn.Active = false;
            this.SignUp_btn.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.SignUp_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUp_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SignUp_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SignUp_btn.BorderRadius = 7;
            this.SignUp_btn.ButtonText = "SIGN UP";
            this.SignUp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUp_btn.DisabledColor = System.Drawing.Color.Gray;
            this.SignUp_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.SignUp_btn.Iconimage = null;
            this.SignUp_btn.Iconimage_right = null;
            this.SignUp_btn.Iconimage_right_Selected = null;
            this.SignUp_btn.Iconimage_Selected = null;
            this.SignUp_btn.IconMarginLeft = 0;
            this.SignUp_btn.IconMarginRight = 0;
            this.SignUp_btn.IconRightVisible = true;
            this.SignUp_btn.IconRightZoom = 0D;
            this.SignUp_btn.IconVisible = true;
            this.SignUp_btn.IconZoom = 90D;
            this.SignUp_btn.IsTab = false;
            this.SignUp_btn.Location = new System.Drawing.Point(184, 375);
            this.SignUp_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SignUp_btn.Name = "SignUp_btn";
            this.SignUp_btn.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.SignUp_btn.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.SignUp_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.SignUp_btn.selected = false;
            this.SignUp_btn.Size = new System.Drawing.Size(131, 50);
            this.SignUp_btn.TabIndex = 1;
            this.SignUp_btn.Text = "SIGN UP";
            this.SignUp_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignUp_btn.Textcolor = System.Drawing.Color.White;
            this.SignUp_btn.TextFont = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.SignUp_btn.Click += new System.EventHandler(this.SignUp_btn_Click);
            // 
            // SignupUsername_txt
            // 
            this.SignupUsername_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SignupUsername_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SignupUsername_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SignupUsername_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SignupUsername_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SignupUsername_txt.ForeColor = System.Drawing.Color.White;
            this.SignupUsername_txt.HintForeColor = System.Drawing.Color.DarkGray;
            this.SignupUsername_txt.HintText = "Username";
            this.SignupUsername_txt.isPassword = false;
            this.SignupUsername_txt.LineFocusedColor = System.Drawing.Color.White;
            this.SignupUsername_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.SignupUsername_txt.LineMouseHoverColor = System.Drawing.Color.DarkGray;
            this.SignupUsername_txt.LineThickness = 3;
            this.SignupUsername_txt.Location = new System.Drawing.Point(52, 182);
            this.SignupUsername_txt.Margin = new System.Windows.Forms.Padding(4);
            this.SignupUsername_txt.MaxLength = 32767;
            this.SignupUsername_txt.Name = "SignupUsername_txt";
            this.SignupUsername_txt.Size = new System.Drawing.Size(379, 33);
            this.SignupUsername_txt.TabIndex = 2;
            this.SignupUsername_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SignupPassword_txt
            // 
            this.SignupPassword_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SignupPassword_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SignupPassword_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SignupPassword_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SignupPassword_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SignupPassword_txt.ForeColor = System.Drawing.Color.White;
            this.SignupPassword_txt.HintForeColor = System.Drawing.Color.DarkGray;
            this.SignupPassword_txt.HintText = "Password";
            this.SignupPassword_txt.isPassword = true;
            this.SignupPassword_txt.LineFocusedColor = System.Drawing.Color.White;
            this.SignupPassword_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.SignupPassword_txt.LineMouseHoverColor = System.Drawing.Color.DarkGray;
            this.SignupPassword_txt.LineThickness = 3;
            this.SignupPassword_txt.Location = new System.Drawing.Point(52, 295);
            this.SignupPassword_txt.Margin = new System.Windows.Forms.Padding(4);
            this.SignupPassword_txt.MaxLength = 32767;
            this.SignupPassword_txt.Name = "SignupPassword_txt";
            this.SignupPassword_txt.Size = new System.Drawing.Size(379, 33);
            this.SignupPassword_txt.TabIndex = 3;
            this.SignupPassword_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Icon_pic
            // 
            this.Icon_pic.Image = ((System.Drawing.Image)(resources.GetObject("Icon_pic.Image")));
            this.Icon_pic.Location = new System.Drawing.Point(11, 11);
            this.Icon_pic.Name = "Icon_pic";
            this.Icon_pic.Size = new System.Drawing.Size(57, 51);
            this.Icon_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_pic.TabIndex = 1;
            this.Icon_pic.TabStop = false;
            // 
            // Main_panel
            // 
            this.Main_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.Main_panel.Controls.Add(this.SignIn_panel);
            this.Main_panel.Controls.Add(this.BacktoSignIn_lbl);
            this.Main_panel.Controls.Add(this.SignUp_lbl);
            this.Main_panel.Controls.Add(this.Close_btn);
            this.Main_panel.Controls.Add(this.SignUp_panel);
            this.Main_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Main_panel.Location = new System.Drawing.Point(585, 0);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(475, 582);
            this.Main_panel.TabIndex = 0;
            // 
            // SignIn_panel
            // 
            this.SignIn_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.SignIn_panel.Controls.Add(this.User_pic);
            this.SignIn_panel.Controls.Add(this.SignIn_btn);
            this.SignIn_panel.Controls.Add(this.Username_txt);
            this.SignIn_panel.Controls.Add(this.Password_txt);
            this.SignIn_panel.Location = new System.Drawing.Point(0, 58);
            this.SignIn_panel.Name = "SignIn_panel";
            this.SignIn_panel.Size = new System.Drawing.Size(475, 446);
            this.SignIn_panel.TabIndex = 6;
            // 
            // User_pic
            // 
            this.User_pic.Image = ((System.Drawing.Image)(resources.GetObject("User_pic.Image")));
            this.User_pic.Location = new System.Drawing.Point(163, 35);
            this.User_pic.Name = "User_pic";
            this.User_pic.Size = new System.Drawing.Size(166, 146);
            this.User_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.User_pic.TabIndex = 2;
            this.User_pic.TabStop = false;
            // 
            // SignUp_lbl
            // 
            this.SignUp_lbl.ActiveLinkColor = System.Drawing.Color.White;
            this.SignUp_lbl.AutoSize = true;
            this.SignUp_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUp_lbl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SignUp_lbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.SignUp_lbl.LinkColor = System.Drawing.Color.White;
            this.SignUp_lbl.Location = new System.Drawing.Point(38, 549);
            this.SignUp_lbl.Name = "SignUp_lbl";
            this.SignUp_lbl.Size = new System.Drawing.Size(71, 21);
            this.SignUp_lbl.TabIndex = 5;
            this.SignUp_lbl.TabStop = true;
            this.SignUp_lbl.Text = "Sign Up";
            this.SignUp_lbl.VisitedLinkColor = System.Drawing.Color.White;
            this.SignUp_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUp_lbl_LinkClicked);
            // 
            // SignIn_btn
            // 
            this.SignIn_btn.Active = false;
            this.SignIn_btn.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.SignIn_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SignIn_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SignIn_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SignIn_btn.BorderRadius = 7;
            this.SignIn_btn.ButtonText = "SIGN IN";
            this.SignIn_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignIn_btn.DisabledColor = System.Drawing.Color.Gray;
            this.SignIn_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.SignIn_btn.Iconimage = null;
            this.SignIn_btn.Iconimage_right = null;
            this.SignIn_btn.Iconimage_right_Selected = null;
            this.SignIn_btn.Iconimage_Selected = null;
            this.SignIn_btn.IconMarginLeft = 0;
            this.SignIn_btn.IconMarginRight = 0;
            this.SignIn_btn.IconRightVisible = true;
            this.SignIn_btn.IconRightZoom = 0D;
            this.SignIn_btn.IconVisible = true;
            this.SignIn_btn.IconZoom = 90D;
            this.SignIn_btn.IsTab = false;
            this.SignIn_btn.Location = new System.Drawing.Point(184, 361);
            this.SignIn_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SignIn_btn.Name = "SignIn_btn";
            this.SignIn_btn.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.SignIn_btn.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.SignIn_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.SignIn_btn.selected = false;
            this.SignIn_btn.Size = new System.Drawing.Size(131, 50);
            this.SignIn_btn.TabIndex = 1;
            this.SignIn_btn.Text = "SIGN IN";
            this.SignIn_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignIn_btn.Textcolor = System.Drawing.Color.White;
            this.SignIn_btn.TextFont = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.SignIn_btn.Click += new System.EventHandler(this.SignIn_btn_Click);
            // 
            // Username_txt
            // 
            this.Username_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Username_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Username_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Username_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Username_txt.ForeColor = System.Drawing.Color.White;
            this.Username_txt.HintForeColor = System.Drawing.Color.DarkGray;
            this.Username_txt.HintText = "Username";
            this.Username_txt.isPassword = false;
            this.Username_txt.LineFocusedColor = System.Drawing.Color.White;
            this.Username_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.Username_txt.LineMouseHoverColor = System.Drawing.Color.DarkGray;
            this.Username_txt.LineThickness = 3;
            this.Username_txt.Location = new System.Drawing.Point(52, 228);
            this.Username_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Username_txt.MaxLength = 32767;
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(379, 33);
            this.Username_txt.TabIndex = 2;
            this.Username_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Password_txt
            // 
            this.Password_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Password_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Password_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Password_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password_txt.ForeColor = System.Drawing.Color.White;
            this.Password_txt.HintForeColor = System.Drawing.Color.DarkGray;
            this.Password_txt.HintText = "Password";
            this.Password_txt.isPassword = true;
            this.Password_txt.LineFocusedColor = System.Drawing.Color.White;
            this.Password_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.Password_txt.LineMouseHoverColor = System.Drawing.Color.DarkGray;
            this.Password_txt.LineThickness = 3;
            this.Password_txt.Location = new System.Drawing.Point(52, 297);
            this.Password_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Password_txt.MaxLength = 32767;
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(379, 33);
            this.Password_txt.TabIndex = 3;
            this.Password_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Close_btn
            // 
            this.Close_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close_btn.BackgroundImage")));
            this.Close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Location = new System.Drawing.Point(438, 3);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(34, 31);
            this.Close_btn.TabIndex = 4;
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // pic_DragControl
            // 
            this.pic_DragControl.Fixed = true;
            this.pic_DragControl.Horizontal = true;
            this.pic_DragControl.TargetControl = this.Image_panel;
            this.pic_DragControl.Vertical = true;
            // 
            // IconImage_DragControl
            // 
            this.IconImage_DragControl.Fixed = true;
            this.IconImage_DragControl.Horizontal = true;
            this.IconImage_DragControl.TargetControl = this.Icon_pic;
            this.IconImage_DragControl.Vertical = true;
            // 
            // UserPic_DragControl
            // 
            this.UserPic_DragControl.Fixed = true;
            this.UserPic_DragControl.Horizontal = true;
            this.UserPic_DragControl.TargetControl = this.User_pic;
            this.UserPic_DragControl.Vertical = true;
            // 
            // MainPanel_DragControl
            // 
            this.MainPanel_DragControl.Fixed = true;
            this.MainPanel_DragControl.Horizontal = true;
            this.MainPanel_DragControl.TargetControl = this.Main_panel;
            this.MainPanel_DragControl.Vertical = true;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 582);
            this.Controls.Add(this.Image_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Image_panel.ResumeLayout(false);
            this.SignUp_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.User_pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_pic)).EndInit();
            this.Main_panel.ResumeLayout(false);
            this.Main_panel.PerformLayout();
            this.SignIn_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.User_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Image_panel;
        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.PictureBox Icon_pic;
        private System.Windows.Forms.PictureBox User_pic;
        private System.Windows.Forms.Button Close_btn;
        private Bunifu.Framework.UI.BunifuDragControl pic_DragControl;
        private Bunifu.Framework.UI.BunifuDragControl IconImage_DragControl;
        private Bunifu.Framework.UI.BunifuDragControl UserPic_DragControl;
        private Bunifu.Framework.UI.BunifuDragControl MainPanel_DragControl;
        private System.Windows.Forms.ErrorProvider ErrorMessage;
        private System.Windows.Forms.Panel SignIn_panel;
        private System.Windows.Forms.Panel SignUp_panel;
        private System.Windows.Forms.PictureBox User_pic2;
        protected Bunifu.Framework.UI.BunifuFlatButton SignIn_btn;
        protected Bunifu.Framework.UI.BunifuMaterialTextbox Password_txt;
        protected System.Windows.Forms.LinkLabel SignUp_lbl;
        protected Bunifu.Framework.UI.BunifuMaterialTextbox SignupEmail_txt;
        protected System.Windows.Forms.LinkLabel BacktoSignIn_lbl;
        protected Bunifu.Framework.UI.BunifuFlatButton SignUp_btn;
        protected Bunifu.Framework.UI.BunifuMaterialTextbox SignupPassword_txt;
        protected Bunifu.Framework.UI.BunifuMaterialTextbox SignupUsername_txt;
        protected Bunifu.Framework.UI.BunifuMaterialTextbox Username_txt;
    }
}