using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Canteen.ver1
{
    public partial class Reports : Form
    {
        private string connectionString = @"Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'canteenDBDataSet.customertbl' table. You can move, or remove it, as needed.
            this.cashpaymentblTableAdapter.Fill(this.canteenDBDataSet.cashpaymentbl);
            // TODO: This line of code loads data into the 'canteenDBDataSet.customertbl' table. You can move, or remove it, as needed.
            this.cashpaymentblTableAdapter.Fill(this.canteenDBDataSet.cashpaymentbl);
            try
            {
                // Initialize the SqlConnection and open it
                connection = new SqlConnection(connectionString);
                connection.Open();

                // Load data into the DataGridView with a filter to show only customers with credit
                string query = "SELECT * FROM cashpaymentbl";
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

        public void RefreshCashPaymentData()
        {
            try
            {
                this.cashpaymentblTableAdapter.Fill(this.canteenDBDataSet.cashpaymentbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Get the selected date from dateTimePicker1
            DateTime selectedDate = dateTimePicker1.Value.Date;

            // Format the selected date as a string in the required format (yyyy-MM-dd)
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");

            // Establish a database connection
            string connectionString = @"Data Source=DESKTOP-9JA317V;Initial Catalog=CanteenDB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create an SQL query to select cash payments for the selected date
                    string query = "SELECT * FROM cashpaymentbl WHERE CONVERT(date, date) = @selectedDate";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@selectedDate", formattedDate);

                        // Create a SqlDataAdapter to fetch the data
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable filteredDataTable = new DataTable(); // Create a new DataTable for filtered results

                        // Fill the DataTable with the filtered data
                        adapter.Fill(filteredDataTable);

                        // Bind the DataGridView to the filtered DataTable to display the filtered data
                        dataGridView1.DataSource = filteredDataTable;

                        // Execute the query to get the total cash amount
                        string totalCashQuery = "SELECT SUM(amount) FROM cashpaymentbl WHERE CONVERT(date, date) = @selectedDate";
                        using (SqlCommand totalCashCommand = new SqlCommand(totalCashQuery, connection))
                        {
                            totalCashCommand.Parameters.AddWithValue("@selectedDate", formattedDate);

                            object result = totalCashCommand.ExecuteScalar();

                            if (result != DBNull.Value)
                            {
                                decimal totalCash = Convert.ToDecimal(result);
                                TotalAmountSaleslabel.Text = "₱" + totalCash.ToString("N2"); // Display with peso sign (₱) and format as currency
                            }
                            else
                            {
                                TotalAmountSaleslabel.Text = "₱0.00"; // No cash payments for the selected date
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TotalAmountSaleslabel_Click(object sender, EventArgs e)
        {

        }
    }
}
