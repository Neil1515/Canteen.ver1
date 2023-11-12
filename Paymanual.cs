using Canteen.ver1.CANTEEN_STAFF_CONTROL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Canteen.ver1
{
    public partial class Paymanual : Form
    {
        private string connectionString = @"Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
       // private customercredits customercredits;
       // private CustomerCredit customerCredit;

        // Reference to the CustomerCredit form


        public Paymanual(customercredits customercredits)
        {
            InitializeComponent();

           // this.customercredits = customercredits;
        }

       // public Paymanual(CustomerCredit customerCredit)
       // {
           // this.customerCredit = customerCredit;
       // }

        private void Paymanual_Load(object sender, EventArgs e)
        {

        }

        private void EnterIDnumbertextbox_TextChanged(object sender, EventArgs e)
        {
            string customerId = EnterIDnumbertextbox.Text.Trim();


            if (!string.IsNullOrEmpty(customerId))
            {
                try
                {
                    // Create a new SqlConnection
                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    // Query the database to retrieve customer information based on the entered ID
                    string query = "SELECT * FROM customertbl WHERE id = @customerId";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@customerId", customerId);

                    // Load and display the customer image based on the customer ID
                    LoadAndDisplayCustomerImage(customerId);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Display the retrieved customer information
                        string customerName = reader["firstname"].ToString() + " " + reader["lastname"].ToString();
                        double creditAmount = Convert.ToDouble(reader["credit"]);

                        // Update the UI elements to display the information
                        namelabel.Text = customerName;
                        Creditamountindatabasetxtbox.Text = creditAmount.ToString("C", CultureInfo.CurrentCulture);
                    }
                    else
                    {
                        // If no matching customer found, display an error message
                        //MessageBox.Show("Customer not found with the entered ID.");
                        // Clear the displayed information
                        namelabel.Text = "Customer Name Here ";
                        Creditamountindatabasetxtbox.Text = "0";
                    }

                    reader.Close();
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
            else
            {
                // If the text box is empty, clear the displayed information
                namelabel.Text = "Customer Name Here ";
                Creditamountindatabasetxtbox.Text = "0";
                customerpictureBox.Image = null;
            }
        }

        private void LoadAndDisplayCustomerImage(string customerId)
        {
            string imagePath = $@"\\172.16.0.4\CanteenManagementSystem\Canteen.ver1\Customer Picture\{customerId}.jpg";

            if (File.Exists(imagePath))
            {
                // Load the image from the file and display it in the PictureBox
                using (FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    customerpictureBox.Image = Image.FromStream(stream);
                }
            }
            else
            {
                // Display a default image or a message indicating that no image is found
                customerpictureBox.Image = null; // Set to a default image or display nothing
            }
        }

        private void amountopay_TextChanged(object sender, EventArgs e)
        {

        }

        private void Creditamountindatabasetxtbox_Click(object sender, EventArgs e)
        {

        }

        private void RefreshCustomerData(string customerId)
        {
            if (!string.IsNullOrEmpty(customerId))
            {
                try
                {
                    // Create a new SqlConnection
                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    // Query the database to retrieve customer information based on the entered ID
                    string query = "SELECT * FROM customertbl WHERE id = @customerId";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@customerId", customerId);

                    // Load and display the customer image based on the customer ID
                    LoadAndDisplayCustomerImage(customerId);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Display the retrieved customer information
                        string customerName = reader["firstname"].ToString() + " " + reader["lastname"].ToString();
                        double creditAmount = Convert.ToDouble(reader["credit"]);

                        // Update the UI elements to display the information
                        namelabel.Text = customerName;
                        Creditamountindatabasetxtbox.Text = creditAmount.ToString("C", CultureInfo.CurrentCulture);
                    }
                    else
                    {
                        // If no matching customer found, display an error message
                        //MessageBox.Show("Customer not found with the entered ID.");
                        // Clear the displayed information
                        namelabel.Text = "Customer Name Here ";
                        Creditamountindatabasetxtbox.Text = "0";
                    }

                    reader.Close();
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
            else
            {
                // If the text box is empty, clear the displayed information
                namelabel.Text = "Customer Name Here ";
                Creditamountindatabasetxtbox.Text = "0";
                customerpictureBox.Image = null;
            }
        }


        private void confirmbtn_Click(object sender, EventArgs e)
        {
            string customerId = EnterIDnumbertextbox.Text.Trim();
            double amountToPay;
            string name = namelabel.Text.Trim();
            if (string.IsNullOrEmpty(customerId))
            {
                MessageBox.Show("Please enter a valid customer ID.");
                return;
            }

            if (!double.TryParse(amountopay.Text, out amountToPay) || amountToPay <= 0)
            {
                MessageBox.Show("Please enter a valid amount to pay.");
                return;
            }

            try
            {
                // Create a new SqlConnection
                connection = new SqlConnection(connectionString);
                connection.Open();

                // Check if the customer with the given ID exists
                string checkQuery = "SELECT COUNT(*) FROM customertbl WHERE id = @customerId";
                command = new SqlCommand(checkQuery, connection);
                command.Parameters.AddWithValue("@customerId", customerId);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    // Check if the customer has enough credit balance
                    string getCreditQuery = "SELECT credit FROM customertbl WHERE id = @customerId";
                    command = new SqlCommand(getCreditQuery, connection);
                    command.Parameters.AddWithValue("@customerId", customerId);

                    double currentCredit = Convert.ToDouble(command.ExecuteScalar());

                    if (amountToPay <= currentCredit)
                    {
                        // Update the credit balance by subtracting the payment amount
                        string updateQuery = "UPDATE customertbl SET credit = credit - @amountToPay WHERE id = @customerId";
                        command = new SqlCommand(updateQuery, connection);
                        command.Parameters.AddWithValue("@customerId", customerId);
                        command.Parameters.AddWithValue("@amountToPay", amountToPay);
                        command.ExecuteNonQuery();

                        // Insert a record into the paycreditreportstbl table
                        string insertReportQuery = "INSERT INTO paycreditreportstbl (customernameid, customername, amountpaid, daterecieve, canteenstaffnamerecievebaseonaccountlogin, paidby) " +
                            "VALUES (@customernameid, @customername, @amountpaid, @daterecieve, @canteenstaffnamerecievebaseonaccountlogin, @paidby)";
                        command = new SqlCommand(insertReportQuery, connection);
                        command.Parameters.AddWithValue("@customernameid", customerId); // Adjust as needed
                        command.Parameters.AddWithValue("@customername", name); // Adjust as needed
                        command.Parameters.AddWithValue("@amountpaid", amountToPay);
                        command.Parameters.AddWithValue("@daterecieve", DateTime.Now); // Set the current date
                        command.Parameters.AddWithValue("@canteenstaffnamerecievebaseonaccountlogin", "canteenstaffnamerecievebaseonaccountlogin"); // Set the staff or accounting name
                        command.Parameters.AddWithValue("@paidby", "customer");
                        command.ExecuteNonQuery();
                        // Display a success message
                        MessageBox.Show($"Payment of {amountToPay:C} has been deducted from the customer's credit.".Replace("$", "₱"));

                        // Clear the text in the textboxes
                        EnterIDnumbertextbox.Text = "";
                        amountopay.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Customer does not have sufficient credit balance for this payment.");
                    }
                }
                else
                {
                    MessageBox.Show("Customer not found with the entered ID.");
                }
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

        private void customerpictureBox_Click(object sender, EventArgs e)
        {
            // Create a new form to display the zoomed-in image
            Form zoomForm = new Form
            {
                Text = "Zoomed Image",
                Size = new Size(800, 600), // Set the size to your desired zoomed-in image size
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

            // Create a new PictureBox control in the zoomForm
            PictureBox zoomPictureBox = new PictureBox
            {
                Dock = DockStyle.Fill, // Fill the entire form with the image
                Image = customerpictureBox.Image, // Use the image from the ProfilePictureBox
                SizeMode = PictureBoxSizeMode.Zoom
            };

            // Add the zoomPictureBox to the zoomForm
            zoomForm.Controls.Add(zoomPictureBox);

            // Show the zoomForm
            zoomForm.ShowDialog();
        }
    }
}