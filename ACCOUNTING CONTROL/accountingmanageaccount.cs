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
using System.IO;

namespace Canteen.ver1.ACCOUNTING_CONTROL
{
    
    public partial class accountingmanageaccount : UserControl
    {
        private int accountingId;
        private string imagePath;
        // Declare the PictureUpdated event
        public event Action<string> PictureUpdated;
        public event Action<string> AccountingUpdated;
        public accountingmanageaccount(int accountingId)
        {
            InitializeComponent();
            this.accountingId = accountingId;
            // Load and display the admin's information based on the admin ID.
            LoadAccountingInformation(accountingId);
            // Load and display the admin's picture based on the admin ID.
            LoadAccountingPicture(accountingId);
        }
        private void LoadAccountingInformation(int accountingId)
        {
            // Define your connection string
            string connectionString = "Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Define the SQL query to retrieve admin information based on the admin ID
                string sqlQuery = "SELECT id, accountingname, username FROM tblaccounting WHERE id = @accountingId";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@accountingId", accountingId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Display admin details in the textboxes
                            idtextBox.Text = reader["id"].ToString();
                            accountingnametextBox.Text = reader["accountingname"].ToString();
                            usernameTextBox.Text = reader["username"].ToString();

                            // Debugging message
                            //MessageBox.Show("CanteenStaff details loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("CanteenStaff not found for this ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void LoadAccountingPicture(int accountingId)
        {
            // Define the network path where the pictures are stored.
            string networkPath = @"\\172.16.0.4\CanteenManagementSystem\Canteen.ver1\Accounting Picture";

            // Construct the full file path based on the admin ID.
            string filePath = Path.Combine(networkPath, accountingId.ToString() + ".jpg");

            // Check if the file exists.
            if (File.Exists(filePath))
            {
                // Load and display the image in a PictureBox or any other control of your choice.
                Image image = Image.FromFile(filePath);
                accountingpicture.Image = image; // Assuming you have a PictureBox named pictureBoxAdmin.
            }
            else
            {
                MessageBox.Show("Image not found for this Canteen Staff ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void accountingmanageaccount_Load(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string newUsername = usernameTextBox.Text;
            string newAccountingName = accountingnametextBox.Text;

            // Update the admin's information in the database
            if (UpdateAccountingInfo(newUsername, newAccountingName, accountingId))
            {
                // Notify the subscribers (adminhomepage) that the admin name has been updated
                AccountingUpdated?.Invoke(newAccountingName);
                // Check if a new image is selected
                if (!string.IsNullOrEmpty(imagePath))
                {
                    if (UpdateAccountingPicture(accountingId, imagePath))
                    {
                        MessageBox.Show("Accounting information and picture updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAccountingPicture(accountingId); // Reload the updated picture
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the Accounting picture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Accounting information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Failed to update Accounting information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UpdateAccountingInfo(string newUsername, string newAccountingName, int accountingId)
        {
            try
            {
                // Define your connection string
                string connectionString = "Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Define the SQL query to update admin information
                    string sqlQuery = "UPDATE tblaccounting SET username = @newUsername, accountingname = @newAccountingName WHERE id = @canteenstaffId";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@newUsername", newUsername);
                        cmd.Parameters.AddWithValue("@newAccountingName", newAccountingName);
                        cmd.Parameters.AddWithValue("@canteenstaffId", accountingId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating Accounting information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool UpdateAccountingPicture(int accountingId, string imagePath)
        {
            try
            {
                if (!File.Exists(imagePath))
                {
                    MessageBox.Show("The selected image file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Validate if the selected file is a valid image (you can adjust the list of valid extensions)
                string[] validExtensions = { ".jpg", ".jpeg", ".png", ".gif" };
                string extension = Path.GetExtension(imagePath).ToLower();
                if (!validExtensions.Contains(extension))
                {
                    MessageBox.Show("Invalid image format. Please select a valid image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Define the network path where the pictures are stored
                string networkPath = @"\\172.16.0.4\CanteenManagementSystem\Canteen.ver1\Accounting Picture";

                // Construct the full file path based on the admin ID
                string filePath = Path.Combine(networkPath, accountingId.ToString() + ".jpg");

                // Check if the file already exists and, if so, delete it before copying the new image
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                // Copy the selected image to the network location
                File.Copy(imagePath, filePath, true);

                // Dispose of the previous image
                if (accountingpicture.Image != null)
                {
                    accountingpicture.Image.Dispose();
                    accountingpicture.Image = null;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the Accounting picture: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
