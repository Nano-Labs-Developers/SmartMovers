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

namespace SmartMover.src.DataBase.Driver
{
    public partial class DriverData : UserControl
    {
        public DriverData()
        {
            InitializeComponent();
        }

        // This form main variables

        #region Main Vars

        string DriverID;
        string DriverName;
        string DriverGender;
        string DriverAddress;

        #endregion

        // SQL Connection string

        #region SQL Connection String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=SmartMovers;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SmartMovers.mdf;Integrated Security=True;");

        #endregion

        // This form Load event

        #region From Load

        private void DriverData_Load(object sender, EventArgs e)
        {
            tableLoad();
        }

        #endregion

        // Table load function

        #region Table Load Function

        private void tableLoad()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Job"; // Want to change
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                Product_datagrid.DataSource = dt;
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

        // This form main button [ INSERT, UPDATE, DELETE ]

        #region Main Buttons

        // Save button

        #region Save Button

        private void DriverSave_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DriverID = ProductID_txt.Text;
                DriverName = ProductName_txt.Text;

                if (Product_Male_RBTN.Checked == true)
                {
                    DriverGender = "Male";
                }
                else
                {
                    DriverGender = "Female";
                }

                // SQL query
                string query_insert = "INSERT INTO Driver VALUES('" + DriverName + "','" + DriverGender + "')";

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

        // Update Button

        #region Update Button

        private void DriverUpdate_btn_Click(object sender, EventArgs e)
        {
            DriverID = ProductID_txt.Text;
            DriverName = ProductName_txt.Text;

            if (Product_Male_RBTN.Checked == true)
            {
                DriverGender = "Male";
            }
            else
            {
                DriverGender = "Female";
            }

            try
            {

                // SQL query
                string query_update = "UPDATE Driver SET Driver_Name = '" + DriverName + "', Gender = '" + DriverGender + "' WHERE Driver_ID = '" + DriverID + "'";

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

        // Delete button

        #region Delete Button

        private void DriverDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {

                // SQL query
                string query_update = "DELETE FROM Product WHERE Product_ID = '" + ProductID_txt.Text + "'";

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

        // Clear textbox

        #region Clear Text box

        private void ClearText()
        {
            // Clear command not work with bunifu

            ProductID_txt.Text = "";
            ProductName_txt.Text = "";

        }

        #endregion

    }
}
