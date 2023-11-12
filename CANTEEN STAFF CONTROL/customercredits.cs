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
using System.Transactions;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Canteen.ver1.CANTEEN_STAFF_CONTROL
{
    public partial class customercredits : UserControl
    {
        private string connectionString = @"Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        // Declare the staffHomepageForm variable at the class level
        private canteenstaffhomepage staffHomepageForm;

        public customercredits(canteenstaffhomepage staffForm)
        {
            InitializeComponent();
            this.staffHomepageForm = staffForm; // Set the reference to the StaffHomepage form
        }


        private void customercredits_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'canteenDBDataSet.customertbl' table. You can move, or remove it, as needed.
            this.customertblTableAdapter.Fill(this.canteenDBDataSet.customertbl);
            // TODO: This line of code loads data into the 'canteenDBDataSet.customertbl' table. You can move, or remove it, as needed.
            this.customertblTableAdapter.Fill(this.canteenDBDataSet.customertbl);
            try
            {
                // Initialize the SqlConnection and open it
                connection = new SqlConnection(connectionString);
                connection.Open();

                // Load data into the DataGridView with a filter to show only customers with credit
                string query = "SELECT * FROM customertbl WHERE credit > 0";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                creditpaymentdatagrid.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            string searchCriteria = searchbox.Text.Trim();

            try
            {
                // Open a new SqlConnection
                connection = new SqlConnection(connectionString);
                connection.Open();

                // Create and execute the SQL SELECT command for searching with a filter to show only customers with credit
                string searchQuery = "SELECT * FROM customertbl WHERE (id LIKE @searchCriteria OR lastname LIKE @searchCriteria OR department LIKE @searchCriteria) AND credit > 0";
                command = new SqlCommand(searchQuery, connection);
                command.Parameters.AddWithValue("@searchCriteria", "%" + searchCriteria + "%"); // Use "%" for partial matching

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                creditpaymentdatagrid.DataSource = dataTable;

                if (dataTable.Rows.Count == 0)
                {
                    //MessageBox.Show("No matching records found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshCustomerData();
        }
        private void RefreshCustomerData()
        {
            try
            {
                // Reopen the SqlConnection
                connection.Open();

                // Load data into the DataGridView with a filter to show only customers with credit
                string query = "SELECT * FROM customertbl WHERE credit > 0";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                creditpaymentdatagrid.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while refreshing customer data: " + ex.Message);
            }
            finally
            {
                // Close the connection
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void ImportCreditData(string filePath)
        {

            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // Set the license context

                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = package.Workbook.Worksheets[0]; // Assuming credit data is on the first worksheet

                    int rowCount = worksheet.Dimension.Rows;

                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    int importedCount = 0; // Track the number of imported credit payment records

                    string canteenstaffnamerecievebaseonaccountlogin = ""; // Initialize with an empty string

                    if (staffHomepageForm != null)
                    {
                        canteenstaffnamerecievebaseonaccountlogin = staffHomepageForm.StaffName;
                    }
                    else
                    {
                        // Handle the case where staffHomepageForm is not available
                        MessageBox.Show("StaffHomepage form not available. Unable to determine staff name.");
                        return; // Exit the method or handle the error accordingly
                    }


                    for (int row = 2; row <= rowCount; row++) // Assuming the header is in the first row
                    {
                        string paidBy = worksheet.Cells[row, 1].Value?.ToString();
                        string id = worksheet.Cells[row, 2].Value?.ToString();
                        string name = worksheet.Cells[row, 3].Value?.ToString();
                        double amount;
                        DateTime dateReceived = DateTime.Now; // Use the current date

                        if (worksheet.Cells[row, 4].Value != null && double.TryParse(worksheet.Cells[row, 4].Value.ToString(), out amount))
                        {
                            // Check if the customer with the given ID exists
                            string checkQuery = "SELECT COUNT(*) FROM customertbl WHERE id = @id AND credit > 0";
                            command = new SqlCommand(checkQuery, connection);
                            command.Parameters.AddWithValue("@id", id);

                            int count = (int)command.ExecuteScalar();

                            if (count > 0)
                            {
                                // Check if the customer has enough credit balance
                                string getCreditQuery = "SELECT credit FROM customertbl WHERE id = @id";
                                command = new SqlCommand(getCreditQuery, connection);
                                command.Parameters.AddWithValue("@id", id);

                                double currentCredit = Convert.ToDouble(command.ExecuteScalar());

                                if (amount <= currentCredit)
                                {
                                    // Update the credit balance by subtracting the payment amount
                                    string updateQuery = "UPDATE customertbl SET credit = credit - @creditAmount WHERE id = @id";
                                    command = new SqlCommand(updateQuery, connection);
                                    command.Parameters.AddWithValue("@id", id);
                                    command.Parameters.AddWithValue("@creditAmount", amount);
                                    command.ExecuteNonQuery();

                                    // Insert a record into the paycreditreportstbl table
                                    string insertReportQuery = "INSERT INTO paycreditreportstbl (customernameid, customername, amountpaid, daterecieve, canteenstaffnamerecievebaseonaccountlogin, paidby) " +
                                        "VALUES (@customernameid,@customername, @amountpaid, @daterecieve, @canteenstaffnamerecievebaseonaccountlogin, @paidby)";
                                    command = new SqlCommand(insertReportQuery, connection);
                                    command.Parameters.AddWithValue("@customernameid", id); // Adjust as needed
                                    command.Parameters.AddWithValue("@customername", name); // Adjust as needed
                                    command.Parameters.AddWithValue("@amountpaid", amount);
                                    command.Parameters.AddWithValue("@daterecieve", DateTime.Now); // Set the current date
                                    command.Parameters.AddWithValue("@canteenstaffnamerecievebaseonaccountlogin", canteenstaffnamerecievebaseonaccountlogin); // Set the staff or accounting name
                                    command.Parameters.AddWithValue("@paidby", paidBy);
                                    command.ExecuteNonQuery();

                                    importedCount++; // Increment the count of imported credit payment records
                                }
                                else
                                {
                                    MessageBox.Show($"Customer with ID '{id}' does not have sufficient credit balance. Credit payment data not imported for this customer.");
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Customer with ID '{id}' not found or has no credit balance. Credit payment data not imported for this customer.");
                            }
                        }
                        else
                        {
                            // Log a message for invalid or missing data
                            Console.WriteLine($"Invalid data in row {row}. Skipping.");
                        }
                    }

                    MessageBox.Show($"Credit payment data imported successfully for {importedCount} customers.");

                    // Reload data into the DataGridView to reflect the changes
                    string query = "SELECT * FROM customertbl WHERE credit > 0";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Set the DataSource property of your DataGridView
                    creditpaymentdatagrid.DataSource = dataTable;
                    creditpaymentdatagrid.Refresh(); // Refresh the DataGridView to reflect changes
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: Invalid format in Excel data. " + ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: SQL error occurred. " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error: Invalid operation. " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void Paymanualbtn_Click(object sender, EventArgs e)
        {
            Paymanual Paymanual1 = new Paymanual(this);
            Paymanual1.ShowDialog();
        }

        private void importcreditsbtn_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ImportCreditData(filePath);
            }
        }

        private void data_Click(object sender, EventArgs e)
        {
        }

        private void creditpaymentdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
