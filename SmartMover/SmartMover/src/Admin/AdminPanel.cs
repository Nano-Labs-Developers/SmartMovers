using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMover.src.Admin
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        #region Main Vars

        string UserName;
        string Role;
        string UserNameText;

        #endregion

        #region SQL Connection String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=SmartMovers;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SmartMovers.mdf;Integrated Security=True;");

        #endregion

        #region Form Load

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            UsersCount();
            NewUsers();
            UsersAcceptCount();
            SystemUsers();

        }

        #endregion

        #region Table Load [User Count | New Users | User accept | System Users]

        // Find How many user login this system
        protected void UsersCount()
        {
            try
            {
                // SQL query
                string query_select = "SELECT COUNT (*) FROM LoginUser";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_select, con);
                con.Open();
                // Execution of the command
                Int32 count = (Int32)cmnd.ExecuteScalar();

                Users_lbl.Text = count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex);
            }
            finally
            {
                con.Close();
            }

        }

        // Find How many user awiting to accept
        protected void UsersAcceptCount()
        {
            try
            {
                // SQL query
                string query_select = "SELECT COUNT (*) FROM LoginUser WHERE User_Role = 'Not Set'";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_select, con);
                con.Open();
                // Execution of the command
                Int32 count = (Int32)cmnd.ExecuteScalar();

                WaitingUsers_txt.Text = count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex);
            }
            finally
            {
                con.Close();
            }

        }
        
        // Find not accepted user for load table
        protected void NewUsers()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT User_ID, Username, Email, User_Role FROM LoginUser WHERE User_Role = 'Not Set'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                NewUser_datagridview.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex);
            }
            finally
            {
                con.Close();
            }

        }

        // Find not accepted user for load table
        protected void SystemUsers()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT User_ID, Username, Email, User_Role FROM LoginUser WHERE User_Role != 'Admin' AND User_Role != 'Not Set'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                SystemUsers_datagridview.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex);
            }
            finally
            {
                con.Close();
            }

        }


        #endregion

        #region Table Cell Click Event

        private void NewUser_datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (NewUser_datagridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    NewUser_datagridview.CurrentRow.Selected = true;

                    UserName_txt.Text = NewUser_datagridview.Rows[e.RowIndex].Cells["Username"].FormattedValue.ToString();
                    Email_txt.Text = NewUser_datagridview.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();

                    Role_txt.Text = NewUser_datagridview.Rows[e.RowIndex].Cells["User_Role"].FormattedValue.ToString();

                }

            }

        }


        private void SystemUsers_datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (SystemUsers_datagridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    SystemUsers_datagridview.CurrentRow.Selected = true;

                    User_Username_txt.Text = SystemUsers_datagridview.Rows[e.RowIndex].Cells["Username"].FormattedValue.ToString();
                    User_Email_txt.Text = SystemUsers_datagridview.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();

                    User_Role_txt.Text = SystemUsers_datagridview.Rows[e.RowIndex].Cells["User_Role"].FormattedValue.ToString();

                }

            }

        }

        #endregion

        #region Clear Text Box Func

        private void ClearTextTabNewUser()
        {
            // Clear command not work with bunifu

            UserName_txt.Text = "";
            Email_txt.Text = "";
            Role_txt.Text = "";

        }

        private void ClearTextTabSystemUsers()
        {
            // Clear command not work with bunifu

            User_Username_txt.Text = "";
            User_Email_txt.Text = "";
            User_Role_txt.Text = "";

        }

        #endregion
        
        #region Reject and Kick out Class

        private void RejectKick()
        {
            try
            {
                // UseNameText check class caller func
                // SQL query
                string query_update = "DELETE FROM LoginUser WHERE Username = '" + UserNameText + "'";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_update, con);
                con.Open();
                // Execution of the command
                cmnd.ExecuteNonQuery();

                // Successfull Message after the execution
                MessageBox.Show("Successfully");

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex);
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region Accept User and StopWrok User

        private void AcceptandStopWork()
        {
            try
            {

                // SQL query
                string query_update = "UPDATE LoginUser SET User_Role = '" + Role + "' WHERE Username = '" + UserName + "'";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_update, con);
                con.Open();
                // Execution of the command
                cmnd.ExecuteNonQuery();

                // Successfull Message after the execution
                if (Role != "Not Set")
                {
                    MessageBox.Show("User successfully accepted.");
                }
                else
                {
                    MessageBox.Show("Account successfully stoped.");
                }
                

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex);
            }
        }

        #endregion

        #region Accept User Button

        private void UserAccept_btn_Click(object sender, EventArgs e)
        {
            UserName = UserName_txt.Text;
            Role = "AcceptedUser";

            AcceptandStopWork();
            ClearTextTabNewUser();
            NewUsers();
            UsersAcceptCount();
        }

        #endregion

        #region Reject User Button

        private void JobReject_btn_Click(object sender, EventArgs e)
        {
            UserNameText = UserName_txt.Text;

            RejectKick();
            ClearTextTabNewUser();
            NewUsers();
            UsersAcceptCount();
        }

        #endregion

        #region Stop Account Working

        private void StopWork_btn_Click(object sender, EventArgs e)
        {
            Role = "Not Set";
            UserName = User_Username_txt.Text;

            AcceptandStopWork();
            ClearTextTabSystemUsers();
            SystemUsers();
            UsersAcceptCount();
        }

        #endregion

        #region Kick Out User

        private void KickOut_txt_Click(object sender, EventArgs e)
        {
            UserNameText = User_Username_txt.Text;

            RejectKick();
            ClearTextTabSystemUsers();
            SystemUsers();
            UsersAcceptCount();
        }

        #endregion

        #region Reload Button

        private void SystemUserReload_btn_Click(object sender, EventArgs e)
        {
            SystemUsers();
        }

        private void NewUserReload_btn_Click(object sender, EventArgs e)
        {
            NewUsers();
        }

        #endregion

    }
}
