using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canteen.ver1.ACCOUNTING_CONTROL
{

    public partial class homeaccounting : UserControl
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\172.16.0.4\CanteenManagementSystem\Canteen.ver1\CanteenDB.mdf;Integrated Security=True";
        public homeaccounting()
        {
            InitializeComponent();

        }

        private void homeaccounting_Load(object sender, EventArgs e)
        {
            // Load the total customer count when the form loads
            UpdateTotalCustomerCount();

            // Load the total canteen staff count when the form loads
            UpdateTotalCanteenStaffCount();
        }

        private void UpdateTotalCanteenStaffCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Execute a SQL command to get the total staff count
                    string query = "SELECT COUNT(*) FROM Canteenstaff";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Execute the query and get the result
                    int totalStaff = (int)command.ExecuteScalar();

                    // Set the text of the TotalCanteenStaff label
                    TotalCanteenStaff.Text = $"{totalStaff}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void UpdateTotalCustomerCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Execute a SQL command to get the total customer count
                    string query = "SELECT COUNT(*) FROM customertbl";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Execute the query and get the result
                    int totalCustomers = (int)command.ExecuteScalar();

                    // Set the text of the TotalCustomer label
                    TotalCustomer.Text = $"{totalCustomers}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
