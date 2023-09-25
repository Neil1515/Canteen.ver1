using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Canteen.ver1
{
    public partial class UseMealVoucher : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename =C:\Users\John Neil Aying\source\repos\Canteen.ver1\CanteenDB.mdf; Integrated Security = True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public double TotalValue { get; set; }
        public UseMealVoucher(double totalValue)
        {
            InitializeComponent();
            TotalValue = totalValue;
        }

        private void UseMealVoucher_Load(object sender, EventArgs e)
        {
            payablelabel.Text = $"{TotalValue:C2}";
            // Initialize the SqlConnection
            connection = new SqlConnection(connectionString);
        }

        private void EnterCustomerIDtextBox_TextChanged(object sender, EventArgs e)
        {
            string customerId = EnterCustomerIDtextBox.Text.Trim();

            if (!string.IsNullOrWhiteSpace(customerId))
            {
                try
                {
                    // Open a new SqlConnection
                    connection.Open();

                    // Create and execute the SQL SELECT command to get the name for the given ID
                    string selectQuery = "SELECT firstname, lastname FROM customertbl WHERE id = @id";
                    command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@id", customerId);

                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // If a record is found, display the name in DisplayNameTxtbox
                        string firstName = reader["firstname"].ToString();
                        string lastName = reader["lastname"].ToString();
                        DisplayNameTxtbox.Text = $"{firstName} {lastName}";
                    }
                    else
                    {
                        // If no record is found, clear the text in DisplayNameTxtbox
                        DisplayNameTxtbox.Text = ""; // Set it to an empty string
                    }

                    reader.Close();
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
            else
            {
                // Clear the text in DisplayNameTxtbox if the ID is empty
                DisplayNameTxtbox.Text = ""; // Set it to an empty string
            }
        }

        private void DisplayNameTxtbox_Click(object sender, EventArgs e)
        {

        }

        private void payablelabel_Click(object sender, EventArgs e)
        {

        }

        private void VoucherBalacelabel_Click(object sender, EventArgs e)
        {

        }

        private void RemainingBalancelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
