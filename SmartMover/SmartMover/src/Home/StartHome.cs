using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using SmartMover.src.Admin;

namespace SmartMover.src.Home
{
    public partial class StartHome : UserControl
    {
        public StartHome()
        {
            InitializeComponent();
        }

        #region Main Vars

        string UserRole = Login.Login.UserRole;

        #endregion

        #region Form Load

        private void StartHome_Load(object sender, EventArgs e)
        {
            if (UserRole == "Admin")
            {
                Home_Controller_btn.Text = "ADMIN PANEL";
                AccountType_txt.Text = "ADMIN";
            }
            else
            {
                Home_Controller_btn.Visible = false;
                AccountType_txt.Text = "USER";
            }

        }

        #endregion

        private void Home_Controller_btn_Click(object sender, EventArgs e)
        {
            AdminPanel obj = new AdminPanel();
            obj.Show();
        }

    }
}
