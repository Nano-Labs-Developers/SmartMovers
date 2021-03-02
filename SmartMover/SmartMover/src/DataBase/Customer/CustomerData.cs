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

namespace SmartMover.src.DataBase.Customer
{
    public partial class CustomerData : UserControl
    {
        public CustomerData()
        {
            InitializeComponent();
        }

        // This form variables

        #region Main Variables

        string CustomerID;
        string CustomerName;
        string CustomerGender;
        long CustomerContactNo;
        string CustomerAddress;
        string CustomerCatogory;
        string CustomerCatogoryTableLoad;

        #endregion

        // UserControll Form Open Functions

        #region Form Load

        private void CustomerData_Load(object sender, EventArgs e)
        {
            tableLoad();
        }

        #endregion

        // SQL Connection String

        #region SQL Connection String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=SmartMovers;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SmartMovers.mdf;Integrated Security=True;");

        #endregion

        // Table Data Load Functions

        #region Table Load Function

        private void tableLoad()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Customer";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                Customer_datagrid.DataSource = dt;
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

        // Data Gridview Cell Click Event

        #region Data Grid view Select and load data from text box

        private void Customer_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Customer_datagrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    Customer_datagrid.CurrentRow.Selected = true;

                    CustomerID_txt.Text = Customer_datagrid.Rows[e.RowIndex].Cells["Customer_ID"].FormattedValue.ToString();
                    CustomerName_txt.Text = Customer_datagrid.Rows[e.RowIndex].Cells["Customer_Name"].FormattedValue.ToString();

                    CustomerAddress_txt.Text = Customer_datagrid.Rows[e.RowIndex].Cells["Customer_Address"].FormattedValue.ToString();
                    CustomerContactNo_txt.Text = Customer_datagrid.Rows[e.RowIndex].Cells["Customer_ContactNo"].FormattedValue.ToString();

                    CustomerCatogoryTableLoad = Customer_datagrid.Rows[e.RowIndex].Cells["Customer_Catogory"].FormattedValue.ToString();

                    if (CustomerCatogoryTableLoad == "Catogory 1")
                    {
                        Catogory1_rbtn.Checked = true;
                    }
                    else if (CustomerCatogoryTableLoad == "Catogory 2")
                    {
                        Catogory2_rbtn.Checked = true;
                    }
                    else if (CustomerCatogoryTableLoad == "Catogory 3")
                    {
                        Catogory3_rbtn.Checked = true;
                    }

                    CustomerGender = Customer_datagrid.Rows[e.RowIndex].Cells["Customer_Gender"].FormattedValue.ToString();

                    if (CustomerGender == "Male")
                    {
                        if (Customer_Male_RBTN.Checked == false)
                        {
                            Customer_Male_RBTN.Checked = true;

                        }

                    }
                    else if (CustomerGender == "Female")
                    {
                        if (Customer_Female_RBTN.Checked == false)
                        {
                            Customer_Female_RBTN.Checked = true;

                        }

                    }

                }

            }

        }

        #endregion

        // Save | Update | Delete Button

        #region Main Buttons

        // Save Button [ SQL DATA INSERT ]

        #region Save Button

        private void CustomerSave_btn_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerID = CustomerID_txt.Text;
                CustomerName = CustomerName_txt.Text;
                CustomerAddress = CustomerAddress_txt.Text;
                CustomerContactNo = int.Parse(CustomerContactNo_txt.Text);

                if (Catogory1_rbtn.Checked == true)
                {
                    CustomerCatogory = "Catogory 1";
                }
                else if (Catogory2_rbtn.Checked == true)
                {
                    CustomerCatogory = "Catogory 2";
                }
                else
                {
                    CustomerCatogory = "Catogory 3";
                }

                if (Customer_Male_RBTN.Checked == true)
                {
                    CustomerGender = "Male";
                }
                else
                {
                    CustomerGender = "Female";
                }

                // SQL query
                string query_insert = "INSERT INTO Customer VALUES('" + CustomerName + "','" + CustomerAddress + "','" + CustomerContactNo + "','" + CustomerCatogory + "','" + CustomerGender + "')";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                con.Open();
                // Execution of the command
                cmnd.ExecuteNonQuery();

                // Successfull Message after the execution
                MessageBox.Show("Data inserted successfully");

                con.Close();
                ClearText();
                tableLoad();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong.\n\n" + ex);
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        // Update Button [ SQL DATA UPDATE ]

        #region Update Button

        private void CustomerUpdate_btn_Click(object sender, EventArgs e)
        {
            CustomerID = CustomerID_txt.Text;
            CustomerName = CustomerName_txt.Text;
            CustomerAddress = CustomerAddress_txt.Text;
            CustomerContactNo = int.Parse(CustomerContactNo_txt.Text);

            if (Catogory1_rbtn.Checked == true)
            {
                CustomerCatogory = "Catogory 1";
            }
            else if (Catogory2_rbtn.Checked == true)
            {
                CustomerCatogory = "Catogory 2";
            }
            else
            {
                CustomerCatogory = "Catogory 3";
            }

            if (Customer_Male_RBTN.Checked == true)
            {
                CustomerGender = "Male";
            }
            else
            {
                CustomerGender = "Female";
            }
            
            try
            {

                // SQL query
                string query_update = "UPDATE Customer SET Customer_Name = '" + CustomerName + "', Customer_Address = '" + CustomerAddress + "', Customer_ContactNo = '" + CustomerContactNo + "', Customer_Catogory = '" + CustomerCatogory + "', Customer_Gender = '" + CustomerGender + "' WHERE Customer_ID = '" + CustomerID + "'";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_update, con);
                con.Open();
                // Execution of the command
                cmnd.ExecuteNonQuery();

                // Successfull Message after the execution
                MessageBox.Show("Data updated successfully");

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

        // Delete Button [ SQL DATA DELETE ]

        #region Delete Button

        private void CustomerDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {

                // SQL query
                string query_update = "DELETE FROM Customer WHERE Customer_ID = '" + CustomerID_txt.Text + "'";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_update, con);
                con.Open();
                // Execution of the command
                cmnd.ExecuteNonQuery();

                // Successfull Message after the execution
                MessageBox.Show("Data deleted successfully");

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

            CustomerID_txt.Text = "";
            CustomerName_txt.Text = "";
            CustomerContactNo_txt.Text = "";
        }

        #endregion


    }
}
