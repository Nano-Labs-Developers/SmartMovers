using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMover.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region Main Vars

        private static bool AdminAlreadySingUp; // True or False [Yes | No]
        public static string UserRole; // Check user role and pass it system

        string Useranme; // Username txt
        string Password; // Password txt
        string Email; // Email txt
        string Role; // Role for user [auto assigned]
        string SetedRole;

        int Result;

        #endregion

        #region SQL Connection String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=SmartMovers;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SmartMovers.mdf;Integrated Security=True;");

        #endregion

        #region Form Load

        private void Login_Load(object sender, EventArgs e)
        {
            SignIn_panel.BringToFront();
        }

        #endregion

        #region Exit

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region DataBase Algorithm

        #region Admin Login Check

        protected void AdminLoginCheck()
        {
            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM LoginUser";

                Result = int.Parse(cmd.ExecuteScalar().ToString());

                if (Result == 0)
                {
                    AdminAlreadySingUp = false;
                }
                else
                {
                    AdminAlreadySingUp = true;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        #region Sign Up

        protected void SignUP()
        {
            if (AdminAlreadySingUp == false)
            {
                Useranme = SignupUsername_txt.Text;
                Password = SignupPassword_txt.Text;
                Email = SignupEmail_txt.Text;
                Role = "Admin";

                if (String.IsNullOrEmpty(Useranme))
                {
                    ErrorMessage.SetError(SignupUsername_txt, "Please Provide Username.");
                    return;
                }

                if (String.IsNullOrEmpty(Password))
                {
                    ErrorMessage.SetError(SignupPassword_txt, "Please Provide Password.");
                    return;
                }

                if (String.IsNullOrEmpty(Email))
                {
                    ErrorMessage.SetError(SignupEmail_txt, "Please Provide Email.");
                    return;
                }

                
                // SQL query
                string query_insert = "INSERT INTO LoginUser VALUES('" + Useranme + "','" + Password + "','" + Email + "','" + Role + "')";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                con.Open();
                // Execution of the command
                cmnd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Admin setup successfully.");


            }
            else
            {
                Useranme = SignupUsername_txt.Text;
                Password = SignupPassword_txt.Text;
                Email = SignupEmail_txt.Text;
                Role = "Not Set";

                if (String.IsNullOrEmpty(Useranme))
                {
                    ErrorMessage.SetError(SignupUsername_txt, "Please Provide Username.");
                    return;
                }

                if (String.IsNullOrEmpty(Email))
                {
                    ErrorMessage.SetError(SignupEmail_txt, "Please Provide Password.");
                    return;
                }

                if (String.IsNullOrEmpty(Password))
                {
                    ErrorMessage.SetError(SignupPassword_txt, "Please Provide Password.");
                    return;
                }
                                                
                // SQL query
                string query_insert = "INSERT INTO LoginUser VALUES('" + Useranme + "','" + Password + "','" + Email + "','" + Role + "')";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                con.Open();
                // Execution of the command
                cmnd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Wait for aprovel");

            }

        }

        #endregion

        #region Sign In

        protected void SignIN()
        {
            if (AdminAlreadySingUp == false)
            {
                MessageBox.Show("First setup admin\n\nClick Sign Up");

            }
            else
            {
                Useranme = Username_txt.Text;
                Password = Password_txt.Text;

                if (String.IsNullOrEmpty(Useranme))
                {
                    ErrorMessage.SetError(Username_txt, "Please Provide Username.");
                    return;
                }

                if (String.IsNullOrEmpty(Password))
                {
                    ErrorMessage.SetError(Password_txt, "Please Provide Password.");
                    return;
                }
                
                SqlDataAdapter sqa = new SqlDataAdapter("SELECT COUNT(*) FROM LoginUser WHERE UserName = '" + Useranme + "' and Password = '" + Password + "' ", con);
                DataTable dt = new DataTable();
                sqa.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    
                    using (var command = con.CreateCommand())
                    {
                        command.CommandText = "SELECT User_Role FROM LoginUser WHERE Username = '" + Username_txt.Text + "' ";
                        con.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                                SetedRole = reader["User_Role"].ToString();
                        }
                    }
                    con.Close();

                    if (SetedRole != "Not Set")
                    {
                        UserRole = SetedRole;

                        this.Hide();
                        MainMenu obj = new MainMenu();
                        obj.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wait for aprovel");

                        Username_txt.Text = "";
                        Password_txt.Text = "";

                    }

                }
                else
                {
                    MessageBox.Show("Your username or password incorrect.");
                }

            }

        }

        #endregion

        #endregion

        #region Panel Handle

        protected void BacktoSignIn_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn_panel.BringToFront();

            SignUp_lbl.Visible = true;
            BacktoSignIn_lbl.Visible = false;

        }

        protected void SignUp_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp_panel.BringToFront();

            SignUp_lbl.Visible = false;
            BacktoSignIn_lbl.Visible = true;

        }

        #endregion

        #region SignIn | SignUp Button

        protected void SignIn_btn_Click(object sender, EventArgs e)
        {
            AdminLoginCheck();
            SignIN();

        }

        protected void SignUp_btn_Click(object sender, EventArgs e)
        {
            AdminLoginCheck();
            SignUP();

        }

        #endregion

    }
}
