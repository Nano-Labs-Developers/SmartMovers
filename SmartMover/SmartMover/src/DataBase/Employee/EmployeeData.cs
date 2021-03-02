using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace SmartMover.src.DataBase.Employee
{
    public partial class EmployeeData : UserControl
    {
        public EmployeeData()
        {
            InitializeComponent();
        }

        // This form variables

        #region Main Vars

        string Employee_ID;
        string Employee_Name;
        string Employee_NIC;
        string Employee_Address;
        string Employee_Role;
        string Employee_Gender;
        SqlDateTime Employee_BirthDay;

        #endregion

        // SQL Connection String

        #region SQL Connection String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=SmartMovers;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SmartMovers.mdf;Integrated Security=True;");

        #endregion

        // Datagridview Cell Click Event

        #region Table Load Function

        private void tableLoad()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Employee";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                Employee_datagridview.DataSource = dt;
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

        // Datagridview Data load function

        #region Table Load

        private void EmployeeData_Load(object sender, EventArgs e)
        {
            tableLoad();
        }

        #endregion

        // SAVE | UPDATE | DELETE Buttons

        #region Main Buttons

        #region Save Button

        private void CustomerSave_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Employee_ID = EmployeeID_txt.Text;
                Employee_Name = EmployeeName_txt.Text;
                Employee_Address = EmployeeAddress_txt.Text;
                Employee_NIC = EmployeeNIC_txt.Text;
                Employee_Role = Employee_dropdown.selectedValue;
                Employee_BirthDay = BirthDay_datepicker.Value;

                if (Employee_Male_RBTN.Checked == true)
                {
                    Employee_Gender = "Male";
                }
                else
                {
                    Employee_Gender = "Female";
                }

                // SQL query
                string query_insert = "INSERT INTO Customer VALUES('" + Employee_Name + "','" + Employee_Address + "','" + Employee_NIC + "','" + Employee_Role + "','" + Employee_Gender + "')";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                con.Open();
                // Execution of the command
                cmnd.ExecuteNonQuery();

                // Successfull Message after the execution
                MessageBox.Show("Done");

                con.Close();
                ClearText();
                tableLoad();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex);
            }

        }

        #endregion

        #region Update Button

        private void CustomerUpdate_btn_Click(object sender, EventArgs e)
        {
            Employee_ID = EmployeeID_txt.Text;
            Employee_Name = EmployeeName_txt.Text;
            Employee_NIC = EmployeeNIC_txt.Text;
            Employee_Address = EmployeeAddress_txt.Text;
            Employee_Role = Employee_dropdown.selectedValue;
            Employee_BirthDay = BirthDay_datepicker.Value;

            if (Employee_Male_RBTN.Checked == true)
            {
                Employee_Gender = "Male";
            }
            else
            {
                Employee_Gender = "Female";
            }

            try
            {

                // SQL query
                string query_update = "UPDATE Customer SET Employee_Name = '" + Employee_Name + "', Employee_Address = '" + Employee_Address + "', Employee_NIC = '" + Employee_NIC + "', Employee_Role = '" + Employee_Role + "', Employee_BirthDate = '" + Employee_BirthDay + "', Employee_Gender = '" + Employee_Gender + "' WHERE Employee_ID = '" + Employee_ID + "'";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_update, con);
                con.Open();
                // Execution of the command
                cmnd.ExecuteNonQuery();

                // Successfull Message after the execution
                MessageBox.Show("Done");

                con.Close();
                ClearText();
                tableLoad();

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

        #region Delete Button

        private void CustomerDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {

                // SQL query
                string query_update = "DELETE FROM Employee WHERE Employee_ID = '" + EmployeeID_txt.Text + "'";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_update, con);
                con.Open();
                // Execution of the command
                cmnd.ExecuteNonQuery();

                // Successfull Message after the execution
                MessageBox.Show("Done");

                con.Close();
                ClearText();
                tableLoad();

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

        #endregion

        // Clear Textbox

        #region Clear Text box

        private void ClearText()
        {
            // Clear command not work with bunifu

            EmployeeID_txt.Text = "Auto";
            EmployeeName_txt.Text = "";
            EmployeeNIC_txt.Text = "";

            if (Employee_Male_RBTN.Checked == false)
            {
                Employee_Male_RBTN.Checked = true;
            }

            Employee_dropdown.selectedIndex = -1;

        }

        #endregion

    }
}
