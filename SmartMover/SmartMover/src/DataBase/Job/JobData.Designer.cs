namespace SmartMover.src.DataBase.Job
{
    partial class JobData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Job_Heading_lbl = new System.Windows.Forms.Label();
            this.Job_datagridview = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.JobUpdate_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.JobSave_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.JobDelete_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.JobName_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.JobID_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.JobName_lbl = new System.Windows.Forms.Label();
            this.JobID_lbl = new System.Windows.Forms.Label();
            this.JobDangerous_RBTN = new System.Windows.Forms.RadioButton();
            this.JobnotDangerous_lbl = new System.Windows.Forms.RadioButton();
            this.ProductType_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.JobWeightLarge_RBTN = new System.Windows.Forms.RadioButton();
            this.JobWeightMedium_RBTN = new System.Windows.Forms.RadioButton();
            this.JobWeightSmall_RBTN = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.StartLocation_lbl = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.EndLocation_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerID_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.JobDate_datepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.LoadID_dropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.Job_datagridview)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Job_Heading_lbl
            // 
            this.Job_Heading_lbl.AutoSize = true;
            this.Job_Heading_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 14F, System.Drawing.FontStyle.Bold);
            this.Job_Heading_lbl.ForeColor = System.Drawing.Color.White;
            this.Job_Heading_lbl.Location = new System.Drawing.Point(213, 21);
            this.Job_Heading_lbl.Name = "Job_Heading_lbl";
            this.Job_Heading_lbl.Size = new System.Drawing.Size(132, 32);
            this.Job_Heading_lbl.TabIndex = 3;
            this.Job_Heading_lbl.Text = "JOB DATA";
            // 
            // Job_datagridview
            // 
            this.Job_datagridview.AllowUserToAddRows = false;
            this.Job_datagridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Job_datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Job_datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Job_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Job_datagridview.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Job_datagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Job_datagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Job_datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Job_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Job_datagridview.DoubleBuffered = true;
            this.Job_datagridview.EnableHeadersVisualStyles = false;
            this.Job_datagridview.HeaderBgColor = System.Drawing.Color.Gray;
            this.Job_datagridview.HeaderForeColor = System.Drawing.Color.Black;
            this.Job_datagridview.Location = new System.Drawing.Point(591, 21);
            this.Job_datagridview.Name = "Job_datagridview";
            this.Job_datagridview.ReadOnly = true;
            this.Job_datagridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Job_datagridview.RowHeadersVisible = false;
            this.Job_datagridview.RowHeadersWidth = 51;
            this.Job_datagridview.RowTemplate.Height = 24;
            this.Job_datagridview.Size = new System.Drawing.Size(857, 718);
            this.Job_datagridview.TabIndex = 2;
            // 
            // JobUpdate_btn
            // 
            this.JobUpdate_btn.Active = false;
            this.JobUpdate_btn.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.JobUpdate_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.JobUpdate_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.JobUpdate_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JobUpdate_btn.BorderRadius = 7;
            this.JobUpdate_btn.ButtonText = "UPDATE";
            this.JobUpdate_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JobUpdate_btn.DisabledColor = System.Drawing.Color.Gray;
            this.JobUpdate_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.JobUpdate_btn.Iconimage = null;
            this.JobUpdate_btn.Iconimage_right = null;
            this.JobUpdate_btn.Iconimage_right_Selected = null;
            this.JobUpdate_btn.Iconimage_Selected = null;
            this.JobUpdate_btn.IconMarginLeft = 0;
            this.JobUpdate_btn.IconMarginRight = 0;
            this.JobUpdate_btn.IconRightVisible = true;
            this.JobUpdate_btn.IconRightZoom = 0D;
            this.JobUpdate_btn.IconVisible = true;
            this.JobUpdate_btn.IconZoom = 90D;
            this.JobUpdate_btn.IsTab = false;
            this.JobUpdate_btn.Location = new System.Drawing.Point(242, 689);
            this.JobUpdate_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JobUpdate_btn.Name = "JobUpdate_btn";
            this.JobUpdate_btn.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.JobUpdate_btn.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.JobUpdate_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.JobUpdate_btn.selected = false;
            this.JobUpdate_btn.Size = new System.Drawing.Size(131, 50);
            this.JobUpdate_btn.TabIndex = 33;
            this.JobUpdate_btn.Text = "UPDATE";
            this.JobUpdate_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.JobUpdate_btn.Textcolor = System.Drawing.Color.White;
            this.JobUpdate_btn.TextFont = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.JobUpdate_btn.Click += new System.EventHandler(this.JobUpdate_btn_Click);
            // 
            // JobSave_btn
            // 
            this.JobSave_btn.Active = false;
            this.JobSave_btn.Activecolor = System.Drawing.Color.ForestGreen;
            this.JobSave_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.JobSave_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.JobSave_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JobSave_btn.BorderRadius = 7;
            this.JobSave_btn.ButtonText = "SAVE";
            this.JobSave_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JobSave_btn.DisabledColor = System.Drawing.Color.Gray;
            this.JobSave_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.JobSave_btn.Iconimage = null;
            this.JobSave_btn.Iconimage_right = null;
            this.JobSave_btn.Iconimage_right_Selected = null;
            this.JobSave_btn.Iconimage_Selected = null;
            this.JobSave_btn.IconMarginLeft = 0;
            this.JobSave_btn.IconMarginRight = 0;
            this.JobSave_btn.IconRightVisible = true;
            this.JobSave_btn.IconRightZoom = 0D;
            this.JobSave_btn.IconVisible = true;
            this.JobSave_btn.IconZoom = 90D;
            this.JobSave_btn.IsTab = false;
            this.JobSave_btn.Location = new System.Drawing.Point(44, 689);
            this.JobSave_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JobSave_btn.Name = "JobSave_btn";
            this.JobSave_btn.Normalcolor = System.Drawing.Color.ForestGreen;
            this.JobSave_btn.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.JobSave_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.JobSave_btn.selected = false;
            this.JobSave_btn.Size = new System.Drawing.Size(131, 50);
            this.JobSave_btn.TabIndex = 32;
            this.JobSave_btn.Text = "SAVE";
            this.JobSave_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.JobSave_btn.Textcolor = System.Drawing.Color.White;
            this.JobSave_btn.TextFont = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.JobSave_btn.Click += new System.EventHandler(this.JobSave_btn_Click);
            // 
            // JobDelete_btn
            // 
            this.JobDelete_btn.Active = false;
            this.JobDelete_btn.Activecolor = System.Drawing.Color.DarkRed;
            this.JobDelete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.JobDelete_btn.BackColor = System.Drawing.Color.Red;
            this.JobDelete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JobDelete_btn.BorderRadius = 7;
            this.JobDelete_btn.ButtonText = "DELETE";
            this.JobDelete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JobDelete_btn.DisabledColor = System.Drawing.Color.Gray;
            this.JobDelete_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.JobDelete_btn.Iconimage = null;
            this.JobDelete_btn.Iconimage_right = null;
            this.JobDelete_btn.Iconimage_right_Selected = null;
            this.JobDelete_btn.Iconimage_Selected = null;
            this.JobDelete_btn.IconMarginLeft = 0;
            this.JobDelete_btn.IconMarginRight = 0;
            this.JobDelete_btn.IconRightVisible = true;
            this.JobDelete_btn.IconRightZoom = 0D;
            this.JobDelete_btn.IconVisible = true;
            this.JobDelete_btn.IconZoom = 90D;
            this.JobDelete_btn.IsTab = false;
            this.JobDelete_btn.Location = new System.Drawing.Point(436, 689);
            this.JobDelete_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JobDelete_btn.Name = "JobDelete_btn";
            this.JobDelete_btn.Normalcolor = System.Drawing.Color.Red;
            this.JobDelete_btn.OnHovercolor = System.Drawing.Color.Crimson;
            this.JobDelete_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.JobDelete_btn.selected = false;
            this.JobDelete_btn.Size = new System.Drawing.Size(131, 50);
            this.JobDelete_btn.TabIndex = 31;
            this.JobDelete_btn.Text = "DELETE";
            this.JobDelete_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.JobDelete_btn.Textcolor = System.Drawing.Color.White;
            this.JobDelete_btn.TextFont = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.JobDelete_btn.Click += new System.EventHandler(this.JobDelete_btn_Click);
            // 
            // JobName_txt
            // 
            this.JobName_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.JobName_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.JobName_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.JobName_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.JobName_txt.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.JobName_txt.ForeColor = System.Drawing.Color.White;
            this.JobName_txt.HintForeColor = System.Drawing.Color.Gray;
            this.JobName_txt.HintText = "Name";
            this.JobName_txt.isPassword = false;
            this.JobName_txt.LineFocusedColor = System.Drawing.Color.White;
            this.JobName_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.JobName_txt.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.JobName_txt.LineThickness = 3;
            this.JobName_txt.Location = new System.Drawing.Point(219, 138);
            this.JobName_txt.Margin = new System.Windows.Forms.Padding(4);
            this.JobName_txt.MaxLength = 32767;
            this.JobName_txt.Name = "JobName_txt";
            this.JobName_txt.Size = new System.Drawing.Size(348, 36);
            this.JobName_txt.TabIndex = 28;
            this.JobName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // JobID_txt
            // 
            this.JobID_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.JobID_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.JobID_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.JobID_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.JobID_txt.Enabled = false;
            this.JobID_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.JobID_txt.ForeColor = System.Drawing.Color.White;
            this.JobID_txt.HintForeColor = System.Drawing.Color.DimGray;
            this.JobID_txt.HintText = "Auto";
            this.JobID_txt.isPassword = false;
            this.JobID_txt.LineFocusedColor = System.Drawing.Color.Transparent;
            this.JobID_txt.LineIdleColor = System.Drawing.Color.Transparent;
            this.JobID_txt.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.JobID_txt.LineThickness = 3;
            this.JobID_txt.Location = new System.Drawing.Point(219, 88);
            this.JobID_txt.Margin = new System.Windows.Forms.Padding(4);
            this.JobID_txt.MaxLength = 32767;
            this.JobID_txt.Name = "JobID_txt";
            this.JobID_txt.Size = new System.Drawing.Size(100, 33);
            this.JobID_txt.TabIndex = 26;
            this.JobID_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // JobName_lbl
            // 
            this.JobName_lbl.AutoSize = true;
            this.JobName_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.JobName_lbl.ForeColor = System.Drawing.Color.White;
            this.JobName_lbl.Location = new System.Drawing.Point(40, 150);
            this.JobName_lbl.Name = "JobName_lbl";
            this.JobName_lbl.Size = new System.Drawing.Size(94, 24);
            this.JobName_lbl.TabIndex = 24;
            this.JobName_lbl.Text = "Job Name";
            // 
            // JobID_lbl
            // 
            this.JobID_lbl.AutoSize = true;
            this.JobID_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.JobID_lbl.ForeColor = System.Drawing.Color.White;
            this.JobID_lbl.Location = new System.Drawing.Point(40, 97);
            this.JobID_lbl.Name = "JobID_lbl";
            this.JobID_lbl.Size = new System.Drawing.Size(62, 24);
            this.JobID_lbl.TabIndex = 25;
            this.JobID_lbl.Text = "Job ID";
            // 
            // JobDangerous_RBTN
            // 
            this.JobDangerous_RBTN.AutoSize = true;
            this.JobDangerous_RBTN.Checked = true;
            this.JobDangerous_RBTN.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.JobDangerous_RBTN.ForeColor = System.Drawing.Color.White;
            this.JobDangerous_RBTN.Location = new System.Drawing.Point(182, 12);
            this.JobDangerous_RBTN.Name = "JobDangerous_RBTN";
            this.JobDangerous_RBTN.Size = new System.Drawing.Size(123, 28);
            this.JobDangerous_RBTN.TabIndex = 34;
            this.JobDangerous_RBTN.TabStop = true;
            this.JobDangerous_RBTN.Text = "Dangerous";
            this.JobDangerous_RBTN.UseVisualStyleBackColor = true;
            // 
            // JobnotDangerous_lbl
            // 
            this.JobnotDangerous_lbl.AutoSize = true;
            this.JobnotDangerous_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.JobnotDangerous_lbl.ForeColor = System.Drawing.Color.White;
            this.JobnotDangerous_lbl.Location = new System.Drawing.Point(329, 12);
            this.JobnotDangerous_lbl.Name = "JobnotDangerous_lbl";
            this.JobnotDangerous_lbl.Size = new System.Drawing.Size(159, 28);
            this.JobnotDangerous_lbl.TabIndex = 35;
            this.JobnotDangerous_lbl.Text = "Not Dangerous";
            this.JobnotDangerous_lbl.UseVisualStyleBackColor = true;
            // 
            // ProductType_lbl
            // 
            this.ProductType_lbl.AutoSize = true;
            this.ProductType_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.ProductType_lbl.ForeColor = System.Drawing.Color.White;
            this.ProductType_lbl.Location = new System.Drawing.Point(3, 16);
            this.ProductType_lbl.Name = "ProductType_lbl";
            this.ProductType_lbl.Size = new System.Drawing.Size(158, 24);
            this.ProductType_lbl.TabIndex = 36;
            this.ProductType_lbl.Text = "Product Catogory";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.JobnotDangerous_lbl);
            this.panel1.Controls.Add(this.JobDangerous_RBTN);
            this.panel1.Controls.Add(this.ProductType_lbl);
            this.panel1.Location = new System.Drawing.Point(44, 552);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 55);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.JobWeightLarge_RBTN);
            this.panel2.Controls.Add(this.JobWeightMedium_RBTN);
            this.panel2.Controls.Add(this.JobWeightSmall_RBTN);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(44, 613);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 57);
            this.panel2.TabIndex = 38;
            // 
            // JobWeightLarge_RBTN
            // 
            this.JobWeightLarge_RBTN.AutoSize = true;
            this.JobWeightLarge_RBTN.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.JobWeightLarge_RBTN.ForeColor = System.Drawing.Color.White;
            this.JobWeightLarge_RBTN.Location = new System.Drawing.Point(394, 14);
            this.JobWeightLarge_RBTN.Name = "JobWeightLarge_RBTN";
            this.JobWeightLarge_RBTN.Size = new System.Drawing.Size(78, 28);
            this.JobWeightLarge_RBTN.TabIndex = 40;
            this.JobWeightLarge_RBTN.Text = "Large";
            this.JobWeightLarge_RBTN.UseVisualStyleBackColor = true;
            // 
            // JobWeightMedium_RBTN
            // 
            this.JobWeightMedium_RBTN.AutoSize = true;
            this.JobWeightMedium_RBTN.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.JobWeightMedium_RBTN.ForeColor = System.Drawing.Color.White;
            this.JobWeightMedium_RBTN.Location = new System.Drawing.Point(273, 14);
            this.JobWeightMedium_RBTN.Name = "JobWeightMedium_RBTN";
            this.JobWeightMedium_RBTN.Size = new System.Drawing.Size(101, 28);
            this.JobWeightMedium_RBTN.TabIndex = 39;
            this.JobWeightMedium_RBTN.Text = "Medium";
            this.JobWeightMedium_RBTN.UseVisualStyleBackColor = true;
            // 
            // JobWeightSmall_RBTN
            // 
            this.JobWeightSmall_RBTN.AutoSize = true;
            this.JobWeightSmall_RBTN.Checked = true;
            this.JobWeightSmall_RBTN.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.JobWeightSmall_RBTN.ForeColor = System.Drawing.Color.White;
            this.JobWeightSmall_RBTN.Location = new System.Drawing.Point(182, 14);
            this.JobWeightSmall_RBTN.Name = "JobWeightSmall_RBTN";
            this.JobWeightSmall_RBTN.Size = new System.Drawing.Size(77, 28);
            this.JobWeightSmall_RBTN.TabIndex = 38;
            this.JobWeightSmall_RBTN.TabStop = true;
            this.JobWeightSmall_RBTN.Text = "Small";
            this.JobWeightSmall_RBTN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Load Type";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.HintText = "Start Location";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(219, 261);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.MaxLength = 32767;
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(348, 36);
            this.bunifuMaterialTextbox1.TabIndex = 42;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // StartLocation_lbl
            // 
            this.StartLocation_lbl.AutoSize = true;
            this.StartLocation_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.StartLocation_lbl.ForeColor = System.Drawing.Color.White;
            this.StartLocation_lbl.Location = new System.Drawing.Point(40, 273);
            this.StartLocation_lbl.Name = "StartLocation_lbl";
            this.StartLocation_lbl.Size = new System.Drawing.Size(126, 24);
            this.StartLocation_lbl.TabIndex = 41;
            this.StartLocation_lbl.Text = "Start Location";
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.HintText = "End Location";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(219, 320);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.MaxLength = 32767;
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(348, 36);
            this.bunifuMaterialTextbox2.TabIndex = 44;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EndLocation_lbl
            // 
            this.EndLocation_lbl.AutoSize = true;
            this.EndLocation_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.EndLocation_lbl.ForeColor = System.Drawing.Color.White;
            this.EndLocation_lbl.Location = new System.Drawing.Point(40, 332);
            this.EndLocation_lbl.Name = "EndLocation_lbl";
            this.EndLocation_lbl.Size = new System.Drawing.Size(119, 24);
            this.EndLocation_lbl.TabIndex = 43;
            this.EndLocation_lbl.Text = "End Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "Load ID";
            // 
            // CustomerID_lbl
            // 
            this.CustomerID_lbl.AutoSize = true;
            this.CustomerID_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.CustomerID_lbl.ForeColor = System.Drawing.Color.White;
            this.CustomerID_lbl.Location = new System.Drawing.Point(40, 445);
            this.CustomerID_lbl.Name = "CustomerID_lbl";
            this.CustomerID_lbl.Size = new System.Drawing.Size(136, 24);
            this.CustomerID_lbl.TabIndex = 46;
            this.CustomerID_lbl.Text = "Customer Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 48;
            this.label3.Text = "Job Date";
            // 
            // JobDate_datepicker
            // 
            this.JobDate_datepicker.BackColor = System.Drawing.Color.Gray;
            this.JobDate_datepicker.BorderRadius = 0;
            this.JobDate_datepicker.ForeColor = System.Drawing.Color.White;
            this.JobDate_datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.JobDate_datepicker.FormatCustom = null;
            this.JobDate_datepicker.Location = new System.Drawing.Point(219, 200);
            this.JobDate_datepicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JobDate_datepicker.Name = "JobDate_datepicker";
            this.JobDate_datepicker.Size = new System.Drawing.Size(348, 44);
            this.JobDate_datepicker.TabIndex = 49;
            this.JobDate_datepicker.Value = new System.DateTime(2020, 7, 29, 7, 33, 17, 127);
            // 
            // LoadID_dropdown
            // 
            this.LoadID_dropdown.BackColor = System.Drawing.Color.Transparent;
            this.LoadID_dropdown.BorderRadius = 3;
            this.LoadID_dropdown.DisabledColor = System.Drawing.Color.Gray;
            this.LoadID_dropdown.ForeColor = System.Drawing.Color.Black;
            this.LoadID_dropdown.items = new string[0];
            this.LoadID_dropdown.Location = new System.Drawing.Point(219, 378);
            this.LoadID_dropdown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadID_dropdown.Name = "LoadID_dropdown";
            this.LoadID_dropdown.NomalColor = System.Drawing.Color.Gray;
            this.LoadID_dropdown.onHoverColor = System.Drawing.Color.DarkGray;
            this.LoadID_dropdown.selectedIndex = -1;
            this.LoadID_dropdown.Size = new System.Drawing.Size(348, 43);
            this.LoadID_dropdown.TabIndex = 50;
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown1.items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(219, 436);
            this.bunifuDropdown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.DarkGray;
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(348, 43);
            this.bunifuDropdown1.TabIndex = 51;
            // 
            // JobData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.LoadID_dropdown);
            this.Controls.Add(this.JobDate_datepicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerID_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuMaterialTextbox2);
            this.Controls.Add(this.EndLocation_lbl);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.StartLocation_lbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.JobUpdate_btn);
            this.Controls.Add(this.JobSave_btn);
            this.Controls.Add(this.JobDelete_btn);
            this.Controls.Add(this.JobName_txt);
            this.Controls.Add(this.JobID_txt);
            this.Controls.Add(this.JobName_lbl);
            this.Controls.Add(this.JobID_lbl);
            this.Controls.Add(this.Job_Heading_lbl);
            this.Controls.Add(this.Job_datagridview);
            this.Name = "JobData";
            this.Size = new System.Drawing.Size(1469, 759);
            this.Load += new System.EventHandler(this.JobData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Job_datagridview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Job_Heading_lbl;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Job_datagridview;
        protected Bunifu.Framework.UI.BunifuFlatButton JobUpdate_btn;
        protected Bunifu.Framework.UI.BunifuFlatButton JobSave_btn;
        protected Bunifu.Framework.UI.BunifuFlatButton JobDelete_btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox JobName_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox JobID_txt;
        private System.Windows.Forms.Label JobName_lbl;
        private System.Windows.Forms.Label JobID_lbl;
        private System.Windows.Forms.RadioButton JobDangerous_RBTN;
        private System.Windows.Forms.RadioButton JobnotDangerous_lbl;
        private System.Windows.Forms.Label ProductType_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton JobWeightMedium_RBTN;
        private System.Windows.Forms.RadioButton JobWeightSmall_RBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton JobWeightLarge_RBTN;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Label StartLocation_lbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private System.Windows.Forms.Label EndLocation_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CustomerID_lbl;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker JobDate_datepicker;
        private Bunifu.Framework.UI.BunifuDropdown LoadID_dropdown;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
    }
}
