using SmartMover.Login;
using SmartMover.src.About;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMover
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        // This form Main variables

        #region Main Vars

        string SidePanelSelected;
        bool TopMostForm = false;

        #endregion

        // This form load event

        #region MainMenu Load Event

        private void MainMenu_Load(object sender, EventArgs e)
        {
            SidePanelSelected = "Home";
            startHome1.BringToFront();
            Home_BTN.Image = SmartMover.Properties.Resources.home_48px_white;
            //Class run
        }

        #endregion

        // From UI Handler Func

        #region Side Menu Button

        private void Home_BTN_MouseHover(object sender, EventArgs e)
        {
            Home_BTN.Image = SmartMover.Properties.Resources.home_48px_white;

            SideHide_panel.Visible = true;
            SidePanelSelectedClass();
        }

        private void Home_BTN_MouseLeave(object sender, EventArgs e)
        {
            if (SidePanelSelected != "Home")
            {
                Home_BTN.Image = SmartMover.Properties.Resources.home_48px_gray;
            }

            //SideHide_panel.Visible = false;
            SidePanelSelectedClass();
        }

        private void DataBase_BTN_MouseHover(object sender, EventArgs e)
        {
            DataBase_BTN.Image = SmartMover.Properties.Resources.icons8_database_48px_1;

            SideHide_panel.Visible = true;
            SidePanelSelectedClass();
        }

        private void DataBase_BTN_MouseLeave(object sender, EventArgs e)
        {
            if (SidePanelSelected != "Database")
            {
                DataBase_BTN.Image = SmartMover.Properties.Resources.icons8_database_48px;
            }

            //SideHide_panel.Visible = false;
            SidePanelSelectedClass();
        }

        #endregion

        // Main menu(Top of win form) icons click event

        #region Menu Icon_ClickEvent

        private void Exit_File_menuicon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Report_Help_SoftL_menuicon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Nano-Labs-Developers/SmartMovers/blob/master/LICENSE");
        }

        private void reportAnIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Nano-Labs-Developers/SmartMovers/issues");
        }

        private void About_menuicon_Click(object sender, EventArgs e)
        {
            About obj = new About();
            obj.Show();

        }

        #endregion

        // Side panel all Class functions [ Lable Names ] [ Home | Database ]

        #region Side Panel Class

        private void SidePanelSelectedClass()
        {
            if (SidePanelSelected == "Home")
            {
                SideHidePanel_Main_lbl.Text = "HOME";
                SideHidePanel_lbl1.Text = "";
                SideHidePanel_lbl2.Text = "";
                SideHidePanel_lbl3.Text = "";
                SideHidePanel_lbl4.Text = "";
                SideHidePanel_lbl5.Text = "";
                SideHidePanel_lbl6.Text = "";

            }
            else if (SidePanelSelected == "Database")
            {
                SideHidePanel_Main_lbl.Text = "DATABASE";
                SideHidePanel_lbl1.Text = "Driver Data";
                SideHidePanel_lbl2.Text = "Customer Data";
                SideHidePanel_lbl3.Text = "Job Data";
                SideHidePanel_lbl4.Text = "Employee Data";
                SideHidePanel_lbl5.Text = "Load Data";
                SideHidePanel_lbl6.Text = "Payment Data";

            }

        }

        #endregion

        // Side panel click event [ Imagebox items ] [ Home | Database ]

        #region Side Panel Click Event

        private void Home_BTN_Click(object sender, EventArgs e)
        {
            Home_BTN.Image = SmartMover.Properties.Resources.home_48px_white;
            DataBase_BTN.Image = SmartMover.Properties.Resources.icons8_database_48px;

            SidePanelSelected = "Home";
            SidePanelSelectedClass();

            startHome1.BringToFront();
        }

        private void DataBase_BTN_Click(object sender, EventArgs e)
        {
            Home_BTN.Image = SmartMover.Properties.Resources.home_48px_gray;
            DataBase_BTN.Image = SmartMover.Properties.Resources.icons8_database_48px_1;

            SidePanelSelected = "Database";
            SidePanelSelectedClass();
        }

        #endregion

        // Windows form Close button handler

        #region Close button handle

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to Log out?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    this.Hide();
                    Login.Login obj = new Login.Login();
                    obj.Show();
                    break;
                default:
                    break;
            }
        }

        #endregion

        // Side panel hide event

        #region Side Hide Panel Event Manager

        // Class
        private void HidePanel()
        {
            this.SideHide_panel.Visible = false;
        }

        private void ShowPanel()
        {
            this.SideHide_panel.Visible = true;
        }
        //End Class

        #region Show and lable color change
        
        // Side Panel
        private void SideHide_panel_MouseHover(object sender, EventArgs e)
        {
            ShowPanel();
        }

        private void SideHide_panel_MouseLeave(object sender, EventArgs e)
        {
            
        }
        // End Side Panel

        private void SideHidePanel_Main_lbl_MouseHover(object sender, EventArgs e)
        {
            ShowPanel();
        }

        #region Side Hide Panel Mouse Hover

        private void SideHidePanel_lbl1_MouseHover(object sender, EventArgs e)
        {
            ShowPanel();
            SideHidePanel_lbl1.ForeColor = Color.White;
        }

        private void SideHidePanel_lbl2_MouseHover(object sender, EventArgs e)
        {
            ShowPanel();
            SideHidePanel_lbl2.ForeColor = Color.White;
        }

        private void SideHidePanel_lbl3_MouseHover(object sender, EventArgs e)
        {
            ShowPanel();
            SideHidePanel_lbl3.ForeColor = Color.White;
        }

        private void SideHidePanel_lbl4_MouseHover(object sender, EventArgs e)
        {
            ShowPanel();
            SideHidePanel_lbl4.ForeColor = Color.White;
        }

        private void SideHidePanel_lbl5_MouseHover(object sender, EventArgs e)
        {
            ShowPanel();
            SideHidePanel_lbl5.ForeColor = Color.White;
        }

        private void SideHidePanel_lbl6_MouseHover(object sender, EventArgs e)
        {
            ShowPanel();
            SideHidePanel_lbl6.ForeColor = Color.White;
        }

        #endregion

        #region Side Hide Panel Mouse Leave

        private void SideHidePanel_lbl1_MouseLeave(object sender, EventArgs e)
        {
            SideHidePanel_lbl1.ForeColor = Color.DarkGray;
        }

        private void SideHidePanel_lbl2_MouseLeave(object sender, EventArgs e)
        {
            SideHidePanel_lbl2.ForeColor = Color.DarkGray;
        }

        private void SideHidePanel_lbl3_MouseLeave(object sender, EventArgs e)
        {
            SideHidePanel_lbl3.ForeColor = Color.DarkGray;
        }

        private void SideHidePanel_lbl4_MouseLeave(object sender, EventArgs e)
        {
            SideHidePanel_lbl4.ForeColor = Color.DarkGray;
        }

        private void SideHidePanel_lbl5_MouseLeave(object sender, EventArgs e)
        {
            SideHidePanel_lbl5.ForeColor = Color.DarkGray;
        }

        private void SideHidePanel_lbl6_MouseLeave(object sender, EventArgs e)
        {
            SideHidePanel_lbl6.ForeColor = Color.DarkGray;
        }

        #endregion

        #endregion

        #region Hide

        private void Body_panel_MouseHover(object sender, EventArgs e)
        {
            HidePanel();
        }

        private void Top_panel_MouseHover(object sender, EventArgs e)
        {
            HidePanel();
        }

        private void MainMenu_MenuStrip_MouseHover(object sender, EventArgs e)
        {
            HidePanel();
        }

        private void File_menuicon_MouseHover(object sender, EventArgs e)
        {
            HidePanel();
        }

        private void Edit__menuicon_MouseHover(object sender, EventArgs e)
        {
            HidePanel();
        }

        private void View_menuicon_MouseHover(object sender, EventArgs e)
        {
            HidePanel();
        }

        private void Windows_menuicon_MouseHover(object sender, EventArgs e)
        {
            HidePanel();
        }

        private void Help_menuicon_MouseHover(object sender, EventArgs e)
        {
            HidePanel();
        }

        private void jobData1_MouseHover(object sender, EventArgs e)
        {
            HidePanel();
        }

        private void driverData1_MouseHover(object sender, EventArgs e)
        {
            HidePanel();
        }

        private void customerData1_MouseHover(object sender, EventArgs e)
        {
            HidePanel();
        }


        private void startHome1_MouseHover(object sender, EventArgs e)
        {
            HidePanel();
        }

        #endregion

        #endregion

        // End From UI Handler Functions [ UserControl Form navigation ]

        #region Side Hide Panel lable click event

        private void SideHidePanel_lbl1_Click(object sender, EventArgs e)
        {
            if (SidePanelSelected == "Home")
            {

            }
            else if (SidePanelSelected == "Database") // Driver Data
            {
                driverData1.BringToFront();
            }

        }

        private void SideHidePanel_lbl2_Click(object sender, EventArgs e)
        {
            if (SidePanelSelected == "Home")
            {

            }
            else if (SidePanelSelected == "Database") // Customer Data
            {
                customerData1.BringToFront();
            }
        }

        private void SideHidePanel_lbl3_Click(object sender, EventArgs e)
        {
            if (SidePanelSelected == "Home")
            {

            }
            else if (SidePanelSelected == "Database") // Job Data
            {
                jobData1.BringToFront();
            }
        }

        private void SideHidePanel_lbl4_Click(object sender, EventArgs e)
        {
            if (SidePanelSelected == "Home")
            {

            }
            else if (SidePanelSelected == "Database") // Employee Data
            {
                employeeData1.BringToFront();
            }
        }

        private void SideHidePanel_lbl5_Click(object sender, EventArgs e)
        {
            if (SidePanelSelected == "Home")
            {

            }
            else if (SidePanelSelected == "Database") // Load Data
            {
                loadData1.BringToFront();
            }
        }

        private void SideHidePanel_lbl6_Click(object sender, EventArgs e)
        {
            if (SidePanelSelected == "Home")
            {

            }
            else if (SidePanelSelected == "Database") // Payments Data
            {
                payment1.BringToFront();
            }
        }

        #endregion

        // Form always on top

        #region Toggel in Top

        private void ToggelTop_WIN_menuicon_Click(object sender, EventArgs e)
        {
            if (TopMostForm == false)
            {
                this.TopMost = true;
                TopMostForm = true;
            }
            else
            {
                this.TopMost = false;
                TopMostForm = false;
            }
        }

        #endregion

        // Logout function

        #region LogOut

        private void LogOut_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.Login obj = new Login.Login();
            obj.Show();
        }

        #endregion

    }
}