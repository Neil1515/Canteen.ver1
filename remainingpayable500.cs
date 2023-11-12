using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
//using static Canteen.ver1.customerdetails;

namespace Canteen.ver1
{
    public partial class remainingpayable500 : Form
    {
        private string connectionString = @"Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private double excessAmount; // Define excessAmount as a class-level field
        private object customerId;

        public bool PaymentCompleted { get; internal set; }
        public double ExcessAmountPaid { get; internal set; }

        // Constructor that accepts 'excessAmount' as an argument
        public remainingpayable500(double excessAmount, object customerId)
        {
            InitializeComponent();
            this.excessAmount = excessAmount;
            this.customerId = customerId;
        }

        private void remainingpayable500_Load(object sender, EventArgs e)
        {
            // Now you can access 'excessAmount' in this event handler
            Remaining500limitlabel.Text = $"{excessAmount:C2}".Replace("$", "₱");
        }

        private void Remaining500limitlabel_Click(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void proceedbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new instance of SqlConnection for the cash database
                using (SqlConnection cashConnection = new SqlConnection(connectionString))
                {
                    // Open the cash database connection
                    cashConnection.Open();

                    // Create an SQL INSERT statement to insert payment details into the cash database
                    string cashInsertQuery = "INSERT INTO cashpaymentbl (amount, datetime) VALUES (@amount, @datetime)";
                    using (SqlCommand cashCommand = new SqlCommand(cashInsertQuery, cashConnection))
                    {
                        // Set parameters for the INSERT statement
                        cashCommand.Parameters.AddWithValue("@amount", excessAmount);
                        cashCommand.Parameters.AddWithValue("@datetime", DateTime.Now);

                        // Execute the SQL command to insert the payment record into the cash database
                        cashCommand.ExecuteNonQuery();

                        // Show a message indicating successful cash payment
                        MessageBox.Show($"Excess amount of {excessAmount:C2} saved successfully in cash database.");
                    }
                }

                // Create a new instance of SqlConnection for the credit database
                using (SqlConnection creditConnection = new SqlConnection(connectionString))
                {
                    // Open the credit database connection
                    creditConnection.Open();

                    // Create an SQL UPDATE statement to set the customer's credit to 500
                    string creditUpdateQuery = "UPDATE customertbl SET credit = @credit WHERE id = @id";
                    using (SqlCommand creditCommand = new SqlCommand(creditUpdateQuery, creditConnection))
                    {
                        // Set parameters for the UPDATE statement
                        double creditLimit = 500.0; // Fixed credit limit
                        creditCommand.Parameters.AddWithValue("@id", customerId);
                        creditCommand.Parameters.AddWithValue("@credit", creditLimit);

                        // Execute the SQL command to set the customer's credit to the credit limit
                        creditCommand.ExecuteNonQuery();

                        // Show a message indicating successful credit limit update
                        //MessageBox.Show($"Customer credit set to {creditLimit:C2} successfully.");
                    }

                }


                // Set the PaymentCompleted property to true
                PaymentCompleted = true;

                // Close the form
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
