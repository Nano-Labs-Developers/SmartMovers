namespace SmartMover.src.DataBase.Customer
{
    partial class CustomerData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Customer_datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Customer_Heading_lbl = new System.Windows.Forms.Label();
            this.CustomerID_lbl = new System.Windows.Forms.Label();
            this.CustomerName_lbl = new System.Windows.Forms.Label();
            this.CustomerGender_lbl = new System.Windows.Forms.Label();
            this.CustomerCatogory_lbl = new System.Windows.Forms.Label();
            this.CustomerID_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CustomerName_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Customer_Male_RBTN = new System.Windows.Forms.RadioButton();
            this.Customer_Female_RBTN = new System.Windows.Forms.RadioButton();
            this.CustomerDelete_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CustomerSave_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CustomerUpdate_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CustomerContactNo_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CustomerContactNo_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Catogory3_rbtn = new System.Windows.Forms.RadioButton();
            this.Catogory2_rbtn = new System.Windows.Forms.RadioButton();
            this.Catogory1_rbtn = new System.Windows.Forms.RadioButton();
            this.CustomerAddress_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.CustomerAddress_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_datagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Customer_datagrid
            // 
            this.Customer_datagrid.AllowUserToAddRows = false;
            this.Customer_datagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Customer_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Customer_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Customer_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Customer_datagrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Customer_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Customer_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Customer_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Customer_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customer_datagrid.DoubleBuffered = true;
            this.Customer_datagrid.EnableHeadersVisualStyles = false;
            this.Customer_datagrid.HeaderBgColor = System.Drawing.Color.DimGray;
            this.Customer_datagrid.HeaderForeColor = System.Drawing.Color.Black;
            this.Customer_datagrid.Location = new System.Drawing.Point(591, 21);
            this.Customer_datagrid.Name = "Customer_datagrid";
            this.Customer_datagrid.ReadOnly = true;
            this.Customer_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Customer_datagrid.RowHeadersVisible = false;
            this.Customer_datagrid.RowHeadersWidth = 51;
            this.Customer_datagrid.RowTemplate.Height = 24;
            this.Customer_datagrid.Size = new System.Drawing.Size(857, 718);
            this.Customer_datagrid.TabIndex = 0;
            this.Customer_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Customer_datagrid_CellClick);
            // 
            // Customer_Heading_lbl
            // 
            this.Customer_Heading_lbl.AutoSize = true;
            this.Customer_Heading_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 14F, System.Drawing.FontStyle.Bold);
            this.Customer_Heading_lbl.ForeColor = System.Drawing.Color.White;
            this.Customer_Heading_lbl.Location = new System.Drawing.Point(211, 21);
            this.Customer_Heading_lbl.Name = "Customer_Heading_lbl";
            this.Customer_Heading_lbl.Size = new System.Drawing.Size(217, 32);
            this.Customer_Heading_lbl.TabIndex = 1;
            this.Customer_Heading_lbl.Text = "CUSTOMER DATA";
            // 
            // CustomerID_lbl
            // 
            this.CustomerID_lbl.AutoSize = true;
            this.CustomerID_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.CustomerID_lbl.ForeColor = System.Drawing.Color.White;
            this.CustomerID_lbl.Location = new System.Drawing.Point(27, 96);
            this.CustomerID_lbl.Name = "CustomerID_lbl";
            this.CustomerID_lbl.Size = new System.Drawing.Size(128, 24);
            this.CustomerID_lbl.TabIndex = 2;
            this.CustomerID_lbl.Text = "Customer ID : ";
            // 
            // CustomerName_lbl
            // 
            this.CustomerName_lbl.AutoSize = true;
            this.CustomerName_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.CustomerName_lbl.ForeColor = System.Drawing.Color.White;
            this.CustomerName_lbl.Location = new System.Drawing.Point(27, 157);
            this.CustomerName_lbl.Name = "CustomerName_lbl";
            this.CustomerName_lbl.Size = new System.Drawing.Size(146, 24);
            this.CustomerName_lbl.TabIndex = 2;
            this.CustomerName_lbl.Text = "Customer Name";
            // 
            // CustomerGender_lbl
            // 
            this.CustomerGender_lbl.AutoSize = true;
            this.CustomerGender_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.CustomerGender_lbl.ForeColor = System.Drawing.Color.White;
            this.CustomerGender_lbl.Location = new System.Drawing.Point(27, 417);
            this.CustomerGender_lbl.Name = "CustomerGender_lbl";
            this.CustomerGender_lbl.Size = new System.Drawing.Size(158, 24);
            this.CustomerGender_lbl.TabIndex = 2;
            this.CustomerGender_lbl.Text = "Customer Gender";
            // 
            // CustomerCatogory_lbl
            // 
            this.CustomerCatogory_lbl.AutoSize = true;
            this.CustomerCatogory_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.CustomerCatogory_lbl.ForeColor = System.Drawing.Color.White;
            this.CustomerCatogory_lbl.Location = new System.Drawing.Point(3, 0);
            this.CustomerCatogory_lbl.Name = "CustomerCatogory_lbl";
            this.CustomerCatogory_lbl.Size = new System.Drawing.Size(173, 24);
            this.CustomerCatogory_lbl.TabIndex = 2;
            this.CustomerCatogory_lbl.Text = "Customer Catogory";
            // 
            // CustomerID_txt
            // 
            this.CustomerID_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CustomerID_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CustomerID_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CustomerID_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerID_txt.Enabled = false;
            this.CustomerID_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CustomerID_txt.ForeColor = System.Drawing.Color.White;
            this.CustomerID_txt.HintForeColor = System.Drawing.Color.DimGray;
            this.CustomerID_txt.HintText = "Auto";
            this.CustomerID_txt.isPassword = false;
            this.CustomerID_txt.LineFocusedColor = System.Drawing.Color.Transparent;
            this.CustomerID_txt.LineIdleColor = System.Drawing.Color.Transparent;
            this.CustomerID_txt.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.CustomerID_txt.LineThickness = 3;
            this.CustomerID_txt.Location = new System.Drawing.Point(231, 87);
            this.CustomerID_txt.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerID_txt.MaxLength = 32767;
            this.CustomerID_txt.Name = "CustomerID_txt";
            this.CustomerID_txt.Size = new System.Drawing.Size(100, 33);
            this.CustomerID_txt.TabIndex = 3;
            this.CustomerID_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CustomerName_txt
            // 
            this.CustomerName_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CustomerName_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CustomerName_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CustomerName_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerName_txt.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.CustomerName_txt.ForeColor = System.Drawing.Color.White;
            this.CustomerName_txt.HintForeColor = System.Drawing.Color.Gray;
            this.CustomerName_txt.HintText = "Name";
            this.CustomerName_txt.isPassword = false;
            this.CustomerName_txt.LineFocusedColor = System.Drawing.Color.White;
            this.CustomerName_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.CustomerName_txt.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.CustomerName_txt.LineThickness = 3;
            this.CustomerName_txt.Location = new System.Drawing.Point(229, 145);
            this.CustomerName_txt.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerName_txt.MaxLength = 32767;
            this.CustomerName_txt.Name = "CustomerName_txt";
            this.CustomerName_txt.Size = new System.Drawing.Size(346, 36);
            this.CustomerName_txt.TabIndex = 4;
            this.CustomerName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Customer_Male_RBTN
            // 
            this.Customer_Male_RBTN.AutoSize = true;
            this.Customer_Male_RBTN.Checked = true;
            this.Customer_Male_RBTN.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.Customer_Male_RBTN.ForeColor = System.Drawing.Color.White;
            this.Customer_Male_RBTN.Location = new System.Drawing.Point(216, 417);
            this.Customer_Male_RBTN.Name = "Customer_Male_RBTN";
            this.Customer_Male_RBTN.Size = new System.Drawing.Size(73, 28);
            this.Customer_Male_RBTN.TabIndex = 5;
            this.Customer_Male_RBTN.TabStop = true;
            this.Customer_Male_RBTN.Text = "Male";
            this.Customer_Male_RBTN.UseVisualStyleBackColor = true;
            // 
            // Customer_Female_RBTN
            // 
            this.Customer_Female_RBTN.AutoSize = true;
            this.Customer_Female_RBTN.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.Customer_Female_RBTN.ForeColor = System.Drawing.Color.White;
            this.Customer_Female_RBTN.Location = new System.Drawing.Point(358, 417);
            this.Customer_Female_RBTN.Name = "Customer_Female_RBTN";
            this.Customer_Female_RBTN.Size = new System.Drawing.Size(91, 28);
            this.Customer_Female_RBTN.TabIndex = 6;
            this.Customer_Female_RBTN.TabStop = true;
            this.Customer_Female_RBTN.Text = "Female";
            this.Customer_Female_RBTN.UseVisualStyleBackColor = true;
            // 
            // CustomerDelete_btn
            // 
            this.CustomerDelete_btn.Active = false;
            this.CustomerDelete_btn.Activecolor = System.Drawing.Color.DarkRed;
            this.CustomerDelete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomerDelete_btn.BackColor = System.Drawing.Color.Red;
            this.CustomerDelete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CustomerDelete_btn.BorderRadius = 7;
            this.CustomerDelete_btn.ButtonText = "DELETE";
            this.CustomerDelete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerDelete_btn.DisabledColor = System.Drawing.Color.Gray;
            this.CustomerDelete_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.CustomerDelete_btn.Iconimage = null;
            this.CustomerDelete_btn.Iconimage_right = null;
            this.CustomerDelete_btn.Iconimage_right_Selected = null;
            this.CustomerDelete_btn.Iconimage_Selected = null;
            this.CustomerDelete_btn.IconMarginLeft = 0;
            this.CustomerDelete_btn.IconMarginRight = 0;
            this.CustomerDelete_btn.IconRightVisible = true;
            this.CustomerDelete_btn.IconRightZoom = 0D;
            this.CustomerDelete_btn.IconVisible = true;
            this.CustomerDelete_btn.IconZoom = 90D;
            this.CustomerDelete_btn.IsTab = false;
            this.CustomerDelete_btn.Location = new System.Drawing.Point(433, 689);
            this.CustomerDelete_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerDelete_btn.Name = "CustomerDelete_btn";
            this.CustomerDelete_btn.Normalcolor = System.Drawing.Color.Red;
            this.CustomerDelete_btn.OnHovercolor = System.Drawing.Color.Crimson;
            this.CustomerDelete_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.CustomerDelete_btn.selected = false;
            this.CustomerDelete_btn.Size = new System.Drawing.Size(131, 50);
            this.CustomerDelete_btn.TabIndex = 7;
            this.CustomerDelete_btn.Text = "DELETE";
            this.CustomerDelete_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CustomerDelete_btn.Textcolor = System.Drawing.Color.White;
            this.CustomerDelete_btn.TextFont = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.CustomerDelete_btn.Click += new System.EventHandler(this.CustomerDelete_btn_Click);
            // 
            // CustomerSave_btn
            // 
            this.CustomerSave_btn.Active = false;
            this.CustomerSave_btn.Activecolor = System.Drawing.Color.ForestGreen;
            this.CustomerSave_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomerSave_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.CustomerSave_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CustomerSave_btn.BorderRadius = 7;
            this.CustomerSave_btn.ButtonText = "SAVE";
            this.CustomerSave_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerSave_btn.DisabledColor = System.Drawing.Color.Gray;
            this.CustomerSave_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.CustomerSave_btn.Iconimage = null;
            this.CustomerSave_btn.Iconimage_right = null;
            this.CustomerSave_btn.Iconimage_right_Selected = null;
            this.CustomerSave_btn.Iconimage_Selected = null;
            this.CustomerSave_btn.IconMarginLeft = 0;
            this.CustomerSave_btn.IconMarginRight = 0;
            this.CustomerSave_btn.IconRightVisible = true;
            this.CustomerSave_btn.IconRightZoom = 0D;
            this.CustomerSave_btn.IconVisible = true;
            this.CustomerSave_btn.IconZoom = 90D;
            this.CustomerSave_btn.IsTab = false;
            this.CustomerSave_btn.Location = new System.Drawing.Point(31, 689);
            this.CustomerSave_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerSave_btn.Name = "CustomerSave_btn";
            this.CustomerSave_btn.Normalcolor = System.Drawing.Color.ForestGreen;
            this.CustomerSave_btn.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.CustomerSave_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.CustomerSave_btn.selected = false;
            this.CustomerSave_btn.Size = new System.Drawing.Size(131, 50);
            this.CustomerSave_btn.TabIndex = 8;
            this.CustomerSave_btn.Text = "SAVE";
            this.CustomerSave_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CustomerSave_btn.Textcolor = System.Drawing.Color.White;
            this.CustomerSave_btn.TextFont = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.CustomerSave_btn.Click += new System.EventHandler(this.CustomerSave_btn_Click);
            // 
            // CustomerUpdate_btn
            // 
            this.CustomerUpdate_btn.Active = false;
            this.CustomerUpdate_btn.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.CustomerUpdate_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomerUpdate_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CustomerUpdate_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CustomerUpdate_btn.BorderRadius = 7;
            this.CustomerUpdate_btn.ButtonText = "UPDATE";
            this.CustomerUpdate_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerUpdate_btn.DisabledColor = System.Drawing.Color.Gray;
            this.CustomerUpdate_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.CustomerUpdate_btn.Iconimage = null;
            this.CustomerUpdate_btn.Iconimage_right = null;
            this.CustomerUpdate_btn.Iconimage_right_Selected = null;
            this.CustomerUpdate_btn.Iconimage_Selected = null;
            this.CustomerUpdate_btn.IconMarginLeft = 0;
            this.CustomerUpdate_btn.IconMarginRight = 0;
            this.CustomerUpdate_btn.IconRightVisible = true;
            this.CustomerUpdate_btn.IconRightZoom = 0D;
            this.CustomerUpdate_btn.IconVisible = true;
            this.CustomerUpdate_btn.IconZoom = 90D;
            this.CustomerUpdate_btn.IsTab = false;
            this.CustomerUpdate_btn.Location = new System.Drawing.Point(231, 689);
            this.CustomerUpdate_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerUpdate_btn.Name = "CustomerUpdate_btn";
            this.CustomerUpdate_btn.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.CustomerUpdate_btn.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.CustomerUpdate_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.CustomerUpdate_btn.selected = false;
            this.CustomerUpdate_btn.Size = new System.Drawing.Size(131, 50);
            this.CustomerUpdate_btn.TabIndex = 9;
            this.CustomerUpdate_btn.Text = "UPDATE";
            this.CustomerUpdate_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CustomerUpdate_btn.Textcolor = System.Drawing.Color.White;
            this.CustomerUpdate_btn.TextFont = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.CustomerUpdate_btn.Click += new System.EventHandler(this.CustomerUpdate_btn_Click);
            // 
            // CustomerContactNo_txt
            // 
            this.CustomerContactNo_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CustomerContactNo_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CustomerContactNo_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CustomerContactNo_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerContactNo_txt.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.CustomerContactNo_txt.ForeColor = System.Drawing.Color.White;
            this.CustomerContactNo_txt.HintForeColor = System.Drawing.Color.Gray;
            this.CustomerContactNo_txt.HintText = "Contact Number";
            this.CustomerContactNo_txt.isPassword = false;
            this.CustomerContactNo_txt.LineFocusedColor = System.Drawing.Color.White;
            this.CustomerContactNo_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.CustomerContactNo_txt.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.CustomerContactNo_txt.LineThickness = 3;
            this.CustomerContactNo_txt.Location = new System.Drawing.Point(229, 343);
            this.CustomerContactNo_txt.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerContactNo_txt.MaxLength = 32767;
            this.CustomerContactNo_txt.Name = "CustomerContactNo_txt";
            this.CustomerContactNo_txt.Size = new System.Drawing.Size(348, 36);
            this.CustomerContactNo_txt.TabIndex = 11;
            this.CustomerContactNo_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CustomerContactNo_lbl
            // 
            this.CustomerContactNo_lbl.AutoSize = true;
            this.CustomerContactNo_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.CustomerContactNo_lbl.ForeColor = System.Drawing.Color.White;
            this.CustomerContactNo_lbl.Location = new System.Drawing.Point(27, 355);
            this.CustomerContactNo_lbl.Name = "CustomerContactNo_lbl";
            this.CustomerContactNo_lbl.Size = new System.Drawing.Size(195, 24);
            this.CustomerContactNo_lbl.TabIndex = 10;
            this.CustomerContactNo_lbl.Text = "Customer Contact No.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Catogory3_rbtn);
            this.panel1.Controls.Add(this.Catogory2_rbtn);
            this.panel1.Controls.Add(this.Catogory1_rbtn);
            this.panel1.Controls.Add(this.CustomerCatogory_lbl);
            this.panel1.Location = new System.Drawing.Point(31, 515);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 100);
            this.panel1.TabIndex = 54;
            // 
            // Catogory3_rbtn
            // 
            this.Catogory3_rbtn.AutoSize = true;
            this.Catogory3_rbtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.Catogory3_rbtn.ForeColor = System.Drawing.Color.White;
            this.Catogory3_rbtn.Location = new System.Drawing.Point(365, 41);
            this.Catogory3_rbtn.Name = "Catogory3_rbtn";
            this.Catogory3_rbtn.Size = new System.Drawing.Size(123, 28);
            this.Catogory3_rbtn.TabIndex = 10;
            this.Catogory3_rbtn.TabStop = true;
            this.Catogory3_rbtn.Text = "Catogory 3";
            this.Catogory3_rbtn.UseVisualStyleBackColor = true;
            // 
            // Catogory2_rbtn
            // 
            this.Catogory2_rbtn.AutoSize = true;
            this.Catogory2_rbtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.Catogory2_rbtn.ForeColor = System.Drawing.Color.White;
            this.Catogory2_rbtn.Location = new System.Drawing.Point(200, 41);
            this.Catogory2_rbtn.Name = "Catogory2_rbtn";
            this.Catogory2_rbtn.Size = new System.Drawing.Size(123, 28);
            this.Catogory2_rbtn.TabIndex = 9;
            this.Catogory2_rbtn.TabStop = true;
            this.Catogory2_rbtn.Text = "Catogory 2";
            this.Catogory2_rbtn.UseVisualStyleBackColor = true;
            // 
            // Catogory1_rbtn
            // 
            this.Catogory1_rbtn.AutoSize = true;
            this.Catogory1_rbtn.Checked = true;
            this.Catogory1_rbtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.Catogory1_rbtn.ForeColor = System.Drawing.Color.White;
            this.Catogory1_rbtn.Location = new System.Drawing.Point(51, 41);
            this.Catogory1_rbtn.Name = "Catogory1_rbtn";
            this.Catogory1_rbtn.Size = new System.Drawing.Size(123, 28);
            this.Catogory1_rbtn.TabIndex = 8;
            this.Catogory1_rbtn.TabStop = true;
            this.Catogory1_rbtn.Text = "Catogory 1";
            this.Catogory1_rbtn.UseVisualStyleBackColor = true;
            // 
            // CustomerAddress_txt
            // 
            this.CustomerAddress_txt.BorderColorFocused = System.Drawing.Color.White;
            this.CustomerAddress_txt.BorderColorIdle = System.Drawing.Color.Gray;
            this.CustomerAddress_txt.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.CustomerAddress_txt.BorderThickness = 3;
            this.CustomerAddress_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CustomerAddress_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerAddress_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CustomerAddress_txt.ForeColor = System.Drawing.Color.White;
            this.CustomerAddress_txt.isPassword = false;
            this.CustomerAddress_txt.Location = new System.Drawing.Point(231, 221);
            this.CustomerAddress_txt.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerAddress_txt.MaxLength = 32767;
            this.CustomerAddress_txt.Name = "CustomerAddress_txt";
            this.CustomerAddress_txt.Size = new System.Drawing.Size(348, 105);
            this.CustomerAddress_txt.TabIndex = 65;
            this.CustomerAddress_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CustomerAddress_lbl
            // 
            this.CustomerAddress_lbl.AutoSize = true;
            this.CustomerAddress_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.CustomerAddress_lbl.ForeColor = System.Drawing.Color.White;
            this.CustomerAddress_lbl.Location = new System.Drawing.Point(27, 250);
            this.CustomerAddress_lbl.Name = "CustomerAddress_lbl";
            this.CustomerAddress_lbl.Size = new System.Drawing.Size(163, 24);
            this.CustomerAddress_lbl.TabIndex = 64;
            this.CustomerAddress_lbl.Text = "Customer Address";
            // 
            // CustomerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.CustomerAddress_txt);
            this.Controls.Add(this.CustomerAddress_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CustomerContactNo_txt);
            this.Controls.Add(this.CustomerContactNo_lbl);
            this.Controls.Add(this.CustomerUpdate_btn);
            this.Controls.Add(this.CustomerSave_btn);
            this.Controls.Add(this.CustomerDelete_btn);
            this.Controls.Add(this.Customer_Female_RBTN);
            this.Controls.Add(this.Customer_Male_RBTN);
            this.Controls.Add(this.CustomerName_txt);
            this.Controls.Add(this.CustomerID_txt);
            this.Controls.Add(this.CustomerGender_lbl);
            this.Controls.Add(this.CustomerName_lbl);
            this.Controls.Add(this.CustomerID_lbl);
            this.Controls.Add(this.Customer_Heading_lbl);
            this.Controls.Add(this.Customer_datagrid);
            this.Name = "CustomerData";
            this.Size = new System.Drawing.Size(1469, 759);
            this.Load += new System.EventHandler(this.CustomerData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Customer_datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid Customer_datagrid;
        private System.Windows.Forms.Label Customer_Heading_lbl;
        private System.Windows.Forms.Label CustomerID_lbl;
        private System.Windows.Forms.Label CustomerName_lbl;
        private System.Windows.Forms.Label CustomerGender_lbl;
        private System.Windows.Forms.Label CustomerCatogory_lbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustomerID_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustomerName_txt;
        private System.Windows.Forms.RadioButton Customer_Male_RBTN;
        private System.Windows.Forms.RadioButton Customer_Female_RBTN;
        protected Bunifu.Framework.UI.BunifuFlatButton CustomerDelete_btn;
        protected Bunifu.Framework.UI.BunifuFlatButton CustomerSave_btn;
        protected Bunifu.Framework.UI.BunifuFlatButton CustomerUpdate_btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustomerContactNo_txt;
        private System.Windows.Forms.Label CustomerContactNo_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Catogory3_rbtn;
        private System.Windows.Forms.RadioButton Catogory2_rbtn;
        private System.Windows.Forms.RadioButton Catogory1_rbtn;
        protected Bunifu.Framework.UI.BunifuMetroTextbox CustomerAddress_txt;
        private System.Windows.Forms.Label CustomerAddress_lbl;
    }
}
