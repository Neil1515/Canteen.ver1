using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Canteen.ver1
{
    public partial class paymentcash : Form
    {
        private string connectionString = @"Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private Reports reportsForm;

        public double TotalValue { get; set; }
        public paymentcash(double totalValue, Reports reportsForm)
        {
            InitializeComponent();
            TotalValue = totalValue;
            this.reportsForm = reportsForm;
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the database connection
                connection.Open();

                // Create an SQL INSERT statement to insert payment details
                string insertQuery = "INSERT INTO cashpaymentbl (amount, datetime) VALUES (@amount, @datetime)";
                command = new SqlCommand(insertQuery, connection);

                // Set parameters for the INSERT statement
                command.Parameters.AddWithValue("@amount", TotalValue);
                command.Parameters.AddWithValue("@datetime", DateTime.Now);


                // Execute the SQL command to insert the payment record
                command.ExecuteNonQuery();

                // Show a message indicating successful payment
                MessageBox.Show($"Payment of {TotalValue:C2} saved successfully at {DateTime.Now:hh:mm tt}.".Replace("$", "₱"));

                // Call the RefreshCashPaymentData method in the Reports form to update the data
                //reportsForm.RefreshCashPaymentData();

                // Hide the form
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void paymentcash_Load(object sender, EventArgs e)
        {
            excessAmountlabel.Text = $"{TotalValue:C2}".Replace("$", "₱");
            // Initialize the SqlConnection
            connection = new SqlConnection(connectionString);
        }

        private void cancelbtn_Click_1(object sender, EventArgs e)
        {
            // Close the form without saving
            this.Close();
        }

        private void excessAmountlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
