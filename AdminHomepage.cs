using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Canteen.ver1
{
    public partial class AdminHomepage : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\John Neil Aying\source\repos\Canteen.ver1\CanteenDB.mdf;Integrated Security=True";
        public AdminHomepage()
        {
            InitializeComponent();
        }

        private void AdminHomepage_Load(object sender, EventArgs e)
        {
            // Load the total customer count when the form loads
            UpdateTotalCustomerCount();
        }

        private void addcutomerbtn_Click(object sender, EventArgs e)
        {
            Hide();
            AddCustomer AddCustomer = new AddCustomer();
            AddCustomer.ShowDialog();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Hide();
            login login = new login();
            login.ShowDialog();
        }

        private void TotalCustomer_Click(object sender, EventArgs e)
        {

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

        private void AddMealVoucherbtn_Click(object sender, EventArgs e)
        {
            Hide();
            AddCustomerMealVoucher MealVoucher = new AddCustomerMealVoucher();
            MealVoucher.ShowDialog();
        }
    }
}
