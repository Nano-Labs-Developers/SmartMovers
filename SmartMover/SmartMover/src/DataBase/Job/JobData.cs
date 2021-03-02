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

namespace SmartMover.src.DataBase.Job
{
    public partial class JobData : UserControl
    {
        public JobData()
        {
            InitializeComponent();
        }

        #region Main Vars

        string JobID;
        string JobName;
        string LoadType;
        string ProductType;
        string JobCustomerType;

        #endregion

        #region SQL Connection String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=SmartMovers;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SmartMovers.mdf;Integrated Security=True;");

        #endregion

        #region Form Load

        private void JobData_Load(object sender, EventArgs e)
        {
            tableLoad();
        }

        #endregion       

        #region Table Load Function

        private void tableLoad()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Job";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                Job_datagridview.DataSource = dt;
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

        #region Main Buttons

        #region Save Button

        private void JobSave_btn_Click(object sender, EventArgs e)
        {
            try
            {
                JobID = JobID_txt.Text;
                JobName = JobName_txt.Text;

                if (JobDangerous_RBTN.Checked == true)
                {
                    ProductType = "Dangerous";
                }
                else if (JobnotDangerous_lbl.Checked == true)
                {
                    ProductType = "NotDangerous";
                }

                if (JobWeightSmall_RBTN.Checked == true)
                {
                    LoadType = "Small"; // Load Type
                }
                else if (JobWeightMedium_RBTN.Checked == true)
                {
                    LoadType = "Medium"; // Load Type
                }
                else if (JobWeightLarge_RBTN.Checked == true)
                {
                    LoadType = "Large"; // Load Type
                }

                // SQL query
                string query_insert = "INSERT INTO Customer VALUES('" + JobName + "', '" + JobCustomerType + "', '" + ProductType + "', '" + LoadType + "')";

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

        private void JobUpdate_btn_Click(object sender, EventArgs e)
        {
            JobID = JobID_txt.Text;
            JobName = JobName_txt.Text;

            if (JobDangerous_RBTN.Checked == true)
            {
                ProductType = "Dangerous";
            }
            else if (JobnotDangerous_lbl.Checked == true)
            {
                ProductType = "NotDangerous";
            }

            if (JobWeightSmall_RBTN.Checked == true)
            {
                LoadType = "Small"; // Load Type
            }
            else if (JobWeightMedium_RBTN.Checked == true)
            {
                LoadType = "Medium"; // Load Type
            }
            else if (JobWeightLarge_RBTN.Checked == true)
            {
                LoadType = "Large"; // Load Type
            }

            try
            {

                // SQL query
                string query_update = "UPDATE Customer SET Job_Name = '" + JobName + "',  Customer_Type = '" + JobCustomerType + "', Product_Type = '" + ProductType + "', Load_Type = '" + LoadType + "' WHERE Job_ID = '" + JobID + "'";

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

        private void JobDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {

                // SQL query
                string query_delete = "DELETE FROM Job WHERE Job_ID = '" + JobID_txt.Text + "'";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_delete, con);
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

        #region Clear Text box

        private void ClearText()
        {
            // Clear command not work with bunifu

            JobID_txt.Text = "";
            JobName_txt.Text = "";

        }

        #endregion

    }
}
