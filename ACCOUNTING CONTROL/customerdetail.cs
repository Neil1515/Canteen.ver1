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

namespace Canteen.ver1.ACCOUNTING_CONTROL
{
    public partial class customerdetail : UserControl
    {
        private string connectionString = @"Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        static customerdetail()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }
        public customerdetail()
        {
            InitializeComponent();
        }
        public class Customer
        {
            public string Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
            public string Voucher { get; set; }
            public string Credit { get; set; }
            public string Status { get; set; }
        }
        private void customerdetail_Load(object sender, EventArgs e)
        {
            StyleDataGridView();

            // TODO: This line of code loads data into the 'canteenDBDataSet.customertbl' table. You can move, or remove it, as needed.
            this.customertblTableAdapter.Fill(this.canteenDBDataSet.customertbl);
            // TODO: This line of code loads data into the 'canteenDBDataSet.customertbl' table. You can move, or remove it, as needed.
            this.customertblTableAdapter.Fill(this.canteenDBDataSet.customertbl);
            try
            {
                // Initialize the SqlConnection and open it
                connection = new SqlConnection(connectionString);
                connection.Open();

                // Load data into the DataGridView
                string query = "SELECT * FROM customertbl";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
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

                // Create and execute the SQL SELECT command for searching
                string searchQuery = "SELECT * FROM customertbl WHERE id LIKE @searchCriteria OR lastname LIKE @searchCriteria OR department LIKE @searchCriteria";
                command = new SqlCommand(searchQuery, connection);
                command.Parameters.AddWithValue("@searchCriteria", "%" + searchCriteria + "%"); // Use "%" for partial matching

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No matching records found.");
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

        private void ImportExcelfilesbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ImportExcelFile(filePath);
            }

            // The ImportExcelFile method is called when the user selects an Excel file.
            // It will handle importing data from the Excel file and adding new customers.
        }

        private void ImportExcelFile(string filePath)
        {
            try
            {
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = package.Workbook.Worksheets[0]; // Assuming data is on the first worksheet

                    int rowCount = worksheet.Dimension.Rows;
                    List<Customer> newCustomers = new List<Customer>();

                    // Loop through the rows and add customers
                    for (int row = 2; row <= rowCount; row++) // Assuming the header is in the first row
                    {
                        string id = worksheet.Cells[row, 1].Value.ToString();
                        string firstName = worksheet.Cells[row, 2].Value.ToString();
                        string lastName = worksheet.Cells[row, 3].Value.ToString();
                        string department = worksheet.Cells[row, 4].Value.ToString();

                        // Create a Customer object and add it to the list
                        Customer customer = new Customer
                        {
                            Id = id,
                            FirstName = firstName,
                            LastName = lastName,
                            Department = department
                        };

                        newCustomers.Add(customer);
                    }

                    // Insert new customers into the database
                    InsertCustomers(newCustomers);

                    // Update voucher balance for existing customers
                    UpdateVoucherBalance(newCustomers);

                    MessageBox.Show("Data imported successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void InsertCustomers(List<Customer> customers)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                foreach (Customer customer in customers)
                {
                    // Check if a customer with the same ID already exists
                    string checkQuery = "SELECT COUNT(*) FROM customertbl WHERE id = @id";
                    command = new SqlCommand(checkQuery, connection);
                    command.Parameters.AddWithValue("@id", customer.Id);

                    int count = (int)command.ExecuteScalar();

                    if (count == 0)
                    {
                        // Customer does not exist, insert it
                        string insertQuery = "INSERT INTO customertbl (id, firstname, lastname, voucher, credit, status, department) VALUES (@id, @firstname, @lastname, @voucher, @credit, @status, @department)";
                        command = new SqlCommand(insertQuery, connection);
                        command.Parameters.AddWithValue("@id", customer.Id);
                        command.Parameters.AddWithValue("@firstname", customer.FirstName);
                        command.Parameters.AddWithValue("@lastname", customer.LastName);
                        command.Parameters.AddWithValue("@department", customer.Department);
                        command.Parameters.AddWithValue("@voucher", "0"); // Default voucher value
                        command.Parameters.AddWithValue("@credit", "0");  // Default credit value
                        command.Parameters.AddWithValue("@status", "Active"); // Default status

                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        // Customer with the same ID already exists, skip insertion
                        MessageBox.Show($"Customer with ID {customer.Id} already exists. Skipping insertion.");
                    }
                }

                // Reload data into the DataGridView to reflect the changes
                string query = "SELECT * FROM customertbl";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
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

        private void UpdateVoucherBalance(List<Customer> newCustomers)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                foreach (Customer customer in newCustomers)
                {
                    // Check if a customer with the same ID and name already exists
                    string checkQuery = "SELECT COUNT(*) FROM customertbl WHERE id = @id AND firstname = @firstname AND lastname = @lastname";
                    command = new SqlCommand(checkQuery, connection);
                    command.Parameters.AddWithValue("@id", customer.Id);
                    command.Parameters.AddWithValue("@firstname", customer.FirstName);
                    command.Parameters.AddWithValue("@lastname", customer.LastName);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        // Customer with the same ID and name exists, update voucher balance
                        string updateQuery = "UPDATE customertbl SET voucher = voucher + @voucher WHERE id = @id AND firstname = @firstname AND lastname = @lastname";
                        command = new SqlCommand(updateQuery, connection);
                        command.Parameters.AddWithValue("@id", customer.Id);
                        command.Parameters.AddWithValue("@firstname", customer.FirstName);
                        command.Parameters.AddWithValue("@lastname", customer.LastName);
                        command.Parameters.AddWithValue("@voucher", 0); // Update voucher balance as needed
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating voucher balance: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void importvoucherbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ImportVoucherData(filePath);
            }
        }

        private void ImportVoucherData(string filePath)
        {
            try
            {
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = package.Workbook.Worksheets[0]; // Assuming voucher data is on the first worksheet

                    int rowCount = worksheet.Dimension.Rows;

                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    int importedCount = 0; // Track the number of imported voucher records

                    for (int row = 2; row <= rowCount; row++) // Assuming the header is in the first row
                    {
                        string id = worksheet.Cells[row, 1].Value.ToString();
                        string name = worksheet.Cells[row, 2].Value.ToString();
                        double voucherAmount = Convert.ToDouble(worksheet.Cells[row, 3].Value);

                        // Check if the customer with the given ID exists
                        string checkQuery = "SELECT COUNT(*) FROM customertbl WHERE id = @id";
                        command = new SqlCommand(checkQuery, connection);
                        command.Parameters.AddWithValue("@id", id);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            // Update the voucher balance for the customer with the given ID
                            string updateQuery = "UPDATE customertbl SET voucher = voucher + @voucherAmount WHERE id = @id";
                            command = new SqlCommand(updateQuery, connection);
                            command.Parameters.AddWithValue("@id", id);
                            command.Parameters.AddWithValue("@voucherAmount", voucherAmount);
                            command.ExecuteNonQuery();

                            importedCount++; // Increment the count of imported voucher records
                        }
                        else
                        {
                            MessageBox.Show($"Customer with ID '{id}' not found. Voucher data not imported for this customer.");
                        }
                    }

                    MessageBox.Show($"Voucher data imported successfully for {importedCount} customers.");

                    // Reload data into the DataGridView to reflect the changes
                    string query = "SELECT * FROM customertbl";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error importing voucher data: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void StyleDataGridView()
        {
            dataGridView1.BackgroundColor = Color.White;
        }
    }
}
