namespace SmartMover.src.DataBase.Driver
{
    partial class DriverData
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
            this.Product_Heading_lbl = new System.Windows.Forms.Label();
            this.Product_datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ProductUpdate_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ProductSave_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ProductDelete_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Product_Female_RBTN = new System.Windows.Forms.RadioButton();
            this.Product_Male_RBTN = new System.Windows.Forms.RadioButton();
            this.ProductName_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProductID_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProductGender_lbl = new System.Windows.Forms.Label();
            this.ProductName_lbl = new System.Windows.Forms.Label();
            this.ProductID_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Product_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Product_Heading_lbl
            // 
            this.Product_Heading_lbl.AutoSize = true;
            this.Product_Heading_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 14F, System.Drawing.FontStyle.Bold);
            this.Product_Heading_lbl.ForeColor = System.Drawing.Color.White;
            this.Product_Heading_lbl.Location = new System.Drawing.Point(214, 22);
            this.Product_Heading_lbl.Name = "Product_Heading_lbl";
            this.Product_Heading_lbl.Size = new System.Drawing.Size(201, 32);
            this.Product_Heading_lbl.TabIndex = 3;
            this.Product_Heading_lbl.Text = "PRODUCT DATA";
            // 
            // Product_datagrid
            // 
            this.Product_datagrid.AllowUserToAddRows = false;
            this.Product_datagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Product_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Product_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Product_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Product_datagrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Product_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Product_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Product_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Product_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Product_datagrid.DoubleBuffered = true;
            this.Product_datagrid.EnableHeadersVisualStyles = false;
            this.Product_datagrid.HeaderBgColor = System.Drawing.Color.Gray;
            this.Product_datagrid.HeaderForeColor = System.Drawing.Color.Black;
            this.Product_datagrid.Location = new System.Drawing.Point(591, 21);
            this.Product_datagrid.Name = "Product_datagrid";
            this.Product_datagrid.ReadOnly = true;
            this.Product_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Product_datagrid.RowHeadersVisible = false;
            this.Product_datagrid.RowHeadersWidth = 51;
            this.Product_datagrid.RowTemplate.Height = 24;
            this.Product_datagrid.Size = new System.Drawing.Size(857, 718);
            this.Product_datagrid.TabIndex = 2;
            // 
            // ProductUpdate_btn
            // 
            this.ProductUpdate_btn.Active = false;
            this.ProductUpdate_btn.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.ProductUpdate_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProductUpdate_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ProductUpdate_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProductUpdate_btn.BorderRadius = 7;
            this.ProductUpdate_btn.ButtonText = "UPDATE";
            this.ProductUpdate_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductUpdate_btn.DisabledColor = System.Drawing.Color.Gray;
            this.ProductUpdate_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.ProductUpdate_btn.Iconimage = null;
            this.ProductUpdate_btn.Iconimage_right = null;
            this.ProductUpdate_btn.Iconimage_right_Selected = null;
            this.ProductUpdate_btn.Iconimage_Selected = null;
            this.ProductUpdate_btn.IconMarginLeft = 0;
            this.ProductUpdate_btn.IconMarginRight = 0;
            this.ProductUpdate_btn.IconRightVisible = true;
            this.ProductUpdate_btn.IconRightZoom = 0D;
            this.ProductUpdate_btn.IconVisible = true;
            this.ProductUpdate_btn.IconZoom = 90D;
            this.ProductUpdate_btn.IsTab = false;
            this.ProductUpdate_btn.Location = new System.Drawing.Point(230, 689);
            this.ProductUpdate_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductUpdate_btn.Name = "ProductUpdate_btn";
            this.ProductUpdate_btn.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.ProductUpdate_btn.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.ProductUpdate_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.ProductUpdate_btn.selected = false;
            this.ProductUpdate_btn.Size = new System.Drawing.Size(131, 50);
            this.ProductUpdate_btn.TabIndex = 21;
            this.ProductUpdate_btn.Text = "UPDATE";
            this.ProductUpdate_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProductUpdate_btn.Textcolor = System.Drawing.Color.White;
            this.ProductUpdate_btn.TextFont = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.ProductUpdate_btn.Click += new System.EventHandler(this.DriverUpdate_btn_Click);
            // 
            // ProductSave_btn
            // 
            this.ProductSave_btn.Active = false;
            this.ProductSave_btn.Activecolor = System.Drawing.Color.ForestGreen;
            this.ProductSave_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProductSave_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.ProductSave_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProductSave_btn.BorderRadius = 7;
            this.ProductSave_btn.ButtonText = "SAVE";
            this.ProductSave_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductSave_btn.DisabledColor = System.Drawing.Color.Gray;
            this.ProductSave_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.ProductSave_btn.Iconimage = null;
            this.ProductSave_btn.Iconimage_right = null;
            this.ProductSave_btn.Iconimage_right_Selected = null;
            this.ProductSave_btn.Iconimage_Selected = null;
            this.ProductSave_btn.IconMarginLeft = 0;
            this.ProductSave_btn.IconMarginRight = 0;
            this.ProductSave_btn.IconRightVisible = true;
            this.ProductSave_btn.IconRightZoom = 0D;
            this.ProductSave_btn.IconVisible = true;
            this.ProductSave_btn.IconZoom = 90D;
            this.ProductSave_btn.IsTab = false;
            this.ProductSave_btn.Location = new System.Drawing.Point(30, 689);
            this.ProductSave_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductSave_btn.Name = "ProductSave_btn";
            this.ProductSave_btn.Normalcolor = System.Drawing.Color.ForestGreen;
            this.ProductSave_btn.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.ProductSave_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.ProductSave_btn.selected = false;
            this.ProductSave_btn.Size = new System.Drawing.Size(131, 50);
            this.ProductSave_btn.TabIndex = 20;
            this.ProductSave_btn.Text = "SAVE";
            this.ProductSave_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProductSave_btn.Textcolor = System.Drawing.Color.White;
            this.ProductSave_btn.TextFont = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.ProductSave_btn.Click += new System.EventHandler(this.DriverSave_btn_Click);
            // 
            // ProductDelete_btn
            // 
            this.ProductDelete_btn.Active = false;
            this.ProductDelete_btn.Activecolor = System.Drawing.Color.DarkRed;
            this.ProductDelete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProductDelete_btn.BackColor = System.Drawing.Color.Red;
            this.ProductDelete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProductDelete_btn.BorderRadius = 7;
            this.ProductDelete_btn.ButtonText = "DELETE";
            this.ProductDelete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductDelete_btn.DisabledColor = System.Drawing.Color.Gray;
            this.ProductDelete_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.ProductDelete_btn.Iconimage = null;
            this.ProductDelete_btn.Iconimage_right = null;
            this.ProductDelete_btn.Iconimage_right_Selected = null;
            this.ProductDelete_btn.Iconimage_Selected = null;
            this.ProductDelete_btn.IconMarginLeft = 0;
            this.ProductDelete_btn.IconMarginRight = 0;
            this.ProductDelete_btn.IconRightVisible = true;
            this.ProductDelete_btn.IconRightZoom = 0D;
            this.ProductDelete_btn.IconVisible = true;
            this.ProductDelete_btn.IconZoom = 90D;
            this.ProductDelete_btn.IsTab = false;
            this.ProductDelete_btn.Location = new System.Drawing.Point(432, 689);
            this.ProductDelete_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductDelete_btn.Name = "ProductDelete_btn";
            this.ProductDelete_btn.Normalcolor = System.Drawing.Color.Red;
            this.ProductDelete_btn.OnHovercolor = System.Drawing.Color.Crimson;
            this.ProductDelete_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.ProductDelete_btn.selected = false;
            this.ProductDelete_btn.Size = new System.Drawing.Size(131, 50);
            this.ProductDelete_btn.TabIndex = 19;
            this.ProductDelete_btn.Text = "DELETE";
            this.ProductDelete_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProductDelete_btn.Textcolor = System.Drawing.Color.White;
            this.ProductDelete_btn.TextFont = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.ProductDelete_btn.Click += new System.EventHandler(this.DriverDelete_btn_Click);
            // 
            // Product_Female_RBTN
            // 
            this.Product_Female_RBTN.AutoSize = true;
            this.Product_Female_RBTN.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.Product_Female_RBTN.ForeColor = System.Drawing.Color.White;
            this.Product_Female_RBTN.Location = new System.Drawing.Point(357, 251);
            this.Product_Female_RBTN.Name = "Product_Female_RBTN";
            this.Product_Female_RBTN.Size = new System.Drawing.Size(91, 28);
            this.Product_Female_RBTN.TabIndex = 18;
            this.Product_Female_RBTN.TabStop = true;
            this.Product_Female_RBTN.Text = "Female";
            this.Product_Female_RBTN.UseVisualStyleBackColor = true;
            // 
            // Product_Male_RBTN
            // 
            this.Product_Male_RBTN.AutoSize = true;
            this.Product_Male_RBTN.Checked = true;
            this.Product_Male_RBTN.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.Product_Male_RBTN.ForeColor = System.Drawing.Color.White;
            this.Product_Male_RBTN.Location = new System.Drawing.Point(215, 251);
            this.Product_Male_RBTN.Name = "Product_Male_RBTN";
            this.Product_Male_RBTN.Size = new System.Drawing.Size(73, 28);
            this.Product_Male_RBTN.TabIndex = 17;
            this.Product_Male_RBTN.TabStop = true;
            this.Product_Male_RBTN.Text = "Male";
            this.Product_Male_RBTN.UseVisualStyleBackColor = true;
            // 
            // ProductName_txt
            // 
            this.ProductName_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ProductName_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ProductName_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ProductName_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductName_txt.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.ProductName_txt.ForeColor = System.Drawing.Color.White;
            this.ProductName_txt.HintForeColor = System.Drawing.Color.Gray;
            this.ProductName_txt.HintText = "Name";
            this.ProductName_txt.isPassword = false;
            this.ProductName_txt.LineFocusedColor = System.Drawing.Color.White;
            this.ProductName_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.ProductName_txt.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.ProductName_txt.LineThickness = 3;
            this.ProductName_txt.Location = new System.Drawing.Point(215, 166);
            this.ProductName_txt.Margin = new System.Windows.Forms.Padding(4);
            this.ProductName_txt.MaxLength = 32767;
            this.ProductName_txt.Name = "ProductName_txt";
            this.ProductName_txt.Size = new System.Drawing.Size(348, 36);
            this.ProductName_txt.TabIndex = 16;
            this.ProductName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProductID_txt
            // 
            this.ProductID_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ProductID_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ProductID_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ProductID_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductID_txt.Enabled = false;
            this.ProductID_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProductID_txt.ForeColor = System.Drawing.Color.White;
            this.ProductID_txt.HintForeColor = System.Drawing.Color.DimGray;
            this.ProductID_txt.HintText = "Auto";
            this.ProductID_txt.isPassword = false;
            this.ProductID_txt.LineFocusedColor = System.Drawing.Color.Transparent;
            this.ProductID_txt.LineIdleColor = System.Drawing.Color.Transparent;
            this.ProductID_txt.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.ProductID_txt.LineThickness = 3;
            this.ProductID_txt.Location = new System.Drawing.Point(215, 87);
            this.ProductID_txt.Margin = new System.Windows.Forms.Padding(4);
            this.ProductID_txt.MaxLength = 32767;
            this.ProductID_txt.Name = "ProductID_txt";
            this.ProductID_txt.Size = new System.Drawing.Size(100, 33);
            this.ProductID_txt.TabIndex = 14;
            this.ProductID_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProductGender_lbl
            // 
            this.ProductGender_lbl.AutoSize = true;
            this.ProductGender_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.ProductGender_lbl.ForeColor = System.Drawing.Color.White;
            this.ProductGender_lbl.Location = new System.Drawing.Point(26, 251);
            this.ProductGender_lbl.Name = "ProductGender_lbl";
            this.ProductGender_lbl.Size = new System.Drawing.Size(121, 24);
            this.ProductGender_lbl.TabIndex = 11;
            this.ProductGender_lbl.Text = "Product Type";
            // 
            // ProductName_lbl
            // 
            this.ProductName_lbl.AutoSize = true;
            this.ProductName_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.ProductName_lbl.ForeColor = System.Drawing.Color.White;
            this.ProductName_lbl.Location = new System.Drawing.Point(26, 172);
            this.ProductName_lbl.Name = "ProductName_lbl";
            this.ProductName_lbl.Size = new System.Drawing.Size(131, 24);
            this.ProductName_lbl.TabIndex = 12;
            this.ProductName_lbl.Text = "Product Name";
            // 
            // ProductID_lbl
            // 
            this.ProductID_lbl.AutoSize = true;
            this.ProductID_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.ProductID_lbl.ForeColor = System.Drawing.Color.White;
            this.ProductID_lbl.Location = new System.Drawing.Point(26, 96);
            this.ProductID_lbl.Name = "ProductID_lbl";
            this.ProductID_lbl.Size = new System.Drawing.Size(113, 24);
            this.ProductID_lbl.TabIndex = 13;
            this.ProductID_lbl.Text = "Product ID : ";
            // 
            // DriverData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.ProductUpdate_btn);
            this.Controls.Add(this.ProductSave_btn);
            this.Controls.Add(this.ProductDelete_btn);
            this.Controls.Add(this.Product_Female_RBTN);
            this.Controls.Add(this.Product_Male_RBTN);
            this.Controls.Add(this.ProductName_txt);
            this.Controls.Add(this.ProductID_txt);
            this.Controls.Add(this.ProductGender_lbl);
            this.Controls.Add(this.ProductName_lbl);
            this.Controls.Add(this.ProductID_lbl);
            this.Controls.Add(this.Product_Heading_lbl);
            this.Controls.Add(this.Product_datagrid);
            this.Name = "DriverData";
            this.Size = new System.Drawing.Size(1469, 759);
            this.Load += new System.EventHandler(this.DriverData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Product_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Product_Heading_lbl;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Product_datagrid;
        protected Bunifu.Framework.UI.BunifuFlatButton ProductUpdate_btn;
        protected Bunifu.Framework.UI.BunifuFlatButton ProductSave_btn;
        protected Bunifu.Framework.UI.BunifuFlatButton ProductDelete_btn;
        private System.Windows.Forms.RadioButton Product_Female_RBTN;
        private System.Windows.Forms.RadioButton Product_Male_RBTN;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductName_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductID_txt;
        private System.Windows.Forms.Label ProductGender_lbl;
        private System.Windows.Forms.Label ProductName_lbl;
        private System.Windows.Forms.Label ProductID_lbl;
    }
}
