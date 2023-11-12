using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
//using static Canteen.ver1.customerdetails;

namespace Canteen.ver1
{
    public partial class CustomerCharges : Form
    {
        private string connectionString = @"Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private double totalforpayableandvoucher;
        private object customerId;

        public double TotalValue { get; set; }
        public CustomerCharges(double totalValue)
        {
            InitializeComponent();
            TotalValue = totalValue;
        }

        private void CustomerCharges_Load(object sender, EventArgs e)
        {
            payablelabel.Text = $"{TotalValue:C2}".Replace("$", "₱");
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

                    // Create and execute the SQL SELECT command to get the voucher balance and name for the given ID
                    string selectQuery = "SELECT credit, voucher, firstname, lastname, department FROM customertbl WHERE id = @id";
                    command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@id", customerId);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // If a record is found, retrieve the voucher balance, first name, and last name
                        double voucherBalance = Convert.ToDouble(reader["voucher"]);
                        double creditBalance = Convert.ToDouble(reader["credit"]);
                        string firstName = reader["firstname"].ToString();
                        string lastName = reader["lastname"].ToString();
                        string department = reader["department"].ToString();

                        DisplayNameTxtbox.Text = $"{firstName} {lastName} {department}";

                        double totalforpayableandcredit = TotalValue + creditBalance;
                        double voucherLimit = Math.Min(voucherBalance, totalforpayableandcredit);
                        double overalltotal = totalforpayableandcredit - voucherLimit;

                        // Update labels
                        overalltotallabel.Text = $"{overalltotal:C2}".Replace("$", "₱");
                        customerVoucherBalacelabel.Text = "₱"+ voucherBalance;
                        lastcreditlabel.Text = $"{creditBalance:C2}".Replace("$", "₱");
                        totalforpayableandcreditlabel.Text = $"{totalforpayableandcredit:C2}".Replace("$", "₱");
                        customervoucherlimitsbaseonpayablelabel.Text = $"{voucherLimit:C2}".Replace("$", "₱");

                        // Load and display the customer image based on the customer ID
                        LoadAndDisplayCustomerImage(customerId);
                    }
                    else
                    {
                        // If no record is found, display "ID NUMBER NOT FOUND" in the name label and clear other labels
                        DisplayNameTxtbox.Text = "ID NUMBER NOT FOUND";
                        overalltotallabel.Text = "₱0";
                        customerVoucherBalacelabel.Text = "₱0";
                        lastcreditlabel.Text = "₱0";
                        totalforpayableandcreditlabel.Text = "₱0";
                        customervoucherlimitsbaseonpayablelabel.Text = "₱0";

                        // Clear the customer image
                        customerpictureBox.Image = null;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur
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
                // Clear the text in DisplayNameTxtbox and set voucher balance to "N/A" if the ID is empty
                DisplayNameTxtbox.Text = "ENTER ID NUMBER";
                overalltotallabel.Text = "₱0";
                customerVoucherBalacelabel.Text = "₱0";
                lastcreditlabel.Text = "₱0";
                totalforpayableandcreditlabel.Text = "₱0";
                customervoucherlimitsbaseonpayablelabel.Text = "₱0";

                // Clear the customer image
                customerpictureBox.Image = null;
            }
        }

        // Helper method to load and display the customer image based on the customer ID
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

        private void customervoucherlimitsbaseonpayablelabel_Click(object sender, EventArgs e)
        {

        }

        private void totalforpayableandvoucherlabel_Click(object sender, EventArgs e)
        {

        }

        private void proceedbtn_Click_1(object sender, EventArgs e)
        {
            // Check if the customer was not found
            if (DisplayNameTxtbox.Text == "ID NUMBER NOT FOUND")
            {
                MessageBox.Show("Customer not found. Transaction cannot proceed.");
                return; // Exit the event handler without proceeding further
            }

            string overallTotalText = overalltotallabel.Text.Replace("₱", "").Trim();
            string voucherLimitText = customervoucherlimitsbaseonpayablelabel.Text.Replace("₱", "").Trim();

            if (double.TryParse(overallTotalText, NumberStyles.Currency, CultureInfo.CurrentCulture, out double overallTotal) &&
                double.TryParse(voucherLimitText, NumberStyles.Currency, CultureInfo.CurrentCulture, out double voucherLimit))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open(); // Open the connection here

                        // Check if the overall total is greater than 500
                        if (overallTotal > 500.00)
                        {
                            // Get the customer ID
                            string customerId = EnterCustomerIDtextBox.Text.Trim();

                            // Create a new instance of the remainingpayable500 form with the excess amount
                            remainingpayable500 remainingPayableForm = new remainingpayable500(overallTotal - 500, customerId);
                            remainingPayableForm.ShowDialog(); // Display the form as a dialog

                            // Check if the user completed the payment in the remainingpayable500 form
                            if (remainingPayableForm.PaymentCompleted)
                            {
                                // The user completed the payment, update the voucher and credit accordingly
                                double excessAmountPaid = remainingPayableForm.ExcessAmountPaid;

                                // Update the customer's credit with the fixed amount of 500
                                string updateCreditQuery = "UPDATE customertbl SET credit = @credit WHERE id = @id";
                                using (SqlCommand command = new SqlCommand(updateCreditQuery, connection))
                                {
                                    double creditAmount = 500.00; // Fixed credit amount
                                    command.Parameters.AddWithValue("@credit", creditAmount);
                                    command.Parameters.AddWithValue("@id", customerId);

                                    int rowsAffectedCredit = command.ExecuteNonQuery();

                                    // Update the customer's voucher balance by subtracting the voucher limit
                                    string updateVoucherQuery = "UPDATE customertbl SET voucher = voucher - @voucherLimit WHERE id = @id";
                                    using (SqlCommand voucherCommand = new SqlCommand(updateVoucherQuery, connection))
                                    {
                                        voucherCommand.Parameters.AddWithValue("@voucherLimit", voucherLimit);
                                        voucherCommand.Parameters.AddWithValue("@id", customerId);

                                        int rowsAffectedVoucher = voucherCommand.ExecuteNonQuery();

                                        if (rowsAffectedCredit > 0 && rowsAffectedVoucher > 0)
                                        {
                                            MessageBox.Show($"Customer credit and voucher updated successfully.");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Failed to update customer credit and/or voucher.");
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            // Get the customer ID
                            string customerId = EnterCustomerIDtextBox.Text.Trim();

                            double voucherBalance = 0.00; // Initialize voucherBalance

                            try
                            {
                                // Fetch the current voucher balance from the database
                                string selectVoucherQuery = "SELECT voucher FROM customertbl WHERE id = @id";
                                using (SqlCommand command = new SqlCommand(selectVoucherQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@id", customerId);

                                    SqlDataReader voucherReader = command.ExecuteReader();

                                    if (voucherReader.Read())
                                    {
                                        voucherBalance = Convert.ToDouble(voucherReader["voucher"]);
                                    }

                                    voucherReader.Close();
                                }

                                // Update the customer's credit with the overall total
                                string updateCreditQuery = "UPDATE customertbl SET credit = @credit WHERE id = @id";
                                using (SqlCommand command = new SqlCommand(updateCreditQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@credit", overallTotal);
                                    command.Parameters.AddWithValue("@id", customerId);

                                    int rowsAffectedCredit = command.ExecuteNonQuery();

                                    // Update the customer's voucher balance by subtracting the voucher limit
                                    string updateVoucherQuery = "UPDATE customertbl SET voucher = voucher - @voucherLimit WHERE id = @id";
                                    using (SqlCommand voucherCommand = new SqlCommand(updateVoucherQuery, connection))
                                    {
                                        voucherCommand.Parameters.AddWithValue("@voucherLimit", voucherLimit);
                                        voucherCommand.Parameters.AddWithValue("@id", customerId);

                                        int rowsAffectedVoucher = voucherCommand.ExecuteNonQuery();

                                        if (rowsAffectedCredit > 0 && rowsAffectedVoucher > 0)
                                        {
                                            MessageBox.Show("Customer credit and voucher updated successfully.");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Failed to update customer credit and/or voucher.");
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                // Handle any exceptions that may occur
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                    }

                    // Close the current form
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during the database operations
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid overall total or voucher limit value.");
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
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