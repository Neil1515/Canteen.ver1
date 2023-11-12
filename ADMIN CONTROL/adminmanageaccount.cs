using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canteen.ver1.ADMIN_CONTROL
{
    public partial class adminmanageaccount : UserControl
    {
        private int adminId;
        private string imagePath;
        // Declare the PictureUpdated event
        public event Action<string> PictureUpdated;
        public event Action<string> AdminNameUpdated;
        public adminmanageaccount(int adminId)
        {
            InitializeComponent();
            this.adminId = adminId;

            // Debug message to check the adminId value
            //MessageBox.Show("Admin ID: " + adminId);

            // Load and display the admin's information based on the admin ID.
            LoadAdminInformation(adminId);
            // Load and display the admin's picture based on the admin ID.
            LoadAdminPicture(adminId);
        }
        // Method to load and display the admin's information
        private void LoadAdminInformation(int adminId)
        {
            // Define your connection string
            string connectionString = "Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Define the SQL query to retrieve admin information based on the admin ID
                string sqlQuery = "SELECT id, adminame, username FROM admintbl WHERE id = @adminId";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@adminId", adminId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Display admin details in the textboxes
                            idtextBox.Text = reader["id"].ToString();
                            adminnametextBox.Text = reader["adminame"].ToString();
                            usernameTextBox.Text = reader["username"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Admin not found for this ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void LoadAdminPicture(int adminId)
        {
            // Define the network path where the pictures are stored.
            string networkPath = @"\\172.16.0.4\CanteenManagementSystem\Canteen.ver1\Admin Picture";

            // Construct the full file path based on the admin ID.
            string filePath = Path.Combine(networkPath, adminId.ToString() + ".jpg");

            // Check if the file exists.
            if (File.Exists(filePath))
            {
                // Load and display the image in a PictureBox or any other control of your choice.
                Image image = Image.FromFile(filePath);
                adminpicture.Image = image; // Assuming you have a PictureBox named pictureBoxAdmin.
            }
            else
            {
                MessageBox.Show("Image not found for this admin ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            string newUsername = usernameTextBox.Text;
            string newAdminName = adminnametextBox.Text;

            // Update the admin's information in the database
            if (UpdateAdminInfo(newUsername, newAdminName, adminId))
            {
                // Notify the subscribers (adminhomepage) that the admin name has been updated
                AdminNameUpdated?.Invoke(newAdminName);
                // Check if a new image is selected
                if (!string.IsNullOrEmpty(imagePath))
                {
                    if (UpdateAdminPicture(adminId, imagePath))
                    {
                        MessageBox.Show("Admin information and picture updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAdminPicture(adminId); // Reload the updated picture
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the admin picture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Admin information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Failed to update admin information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool UpdateAdminInfo(string newUsername, string newAdminName, int adminId)
        {
            try
            {
                // Define your connection string
                string connectionString = "Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Define the SQL query to update admin information
                    string sqlQuery = "UPDATE admintbl SET username = @newUsername, adminame = @newAdminName WHERE id = @adminId";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@newUsername", newUsername);
                        cmd.Parameters.AddWithValue("@newAdminName", newAdminName);
                        cmd.Parameters.AddWithValue("@adminId", adminId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating admin information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool UpdateAdminPicture(int adminId, string imagePath)
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
                string networkPath = @"\\172.16.0.4\CanteenManagementSystem\Canteen.ver1\Admin Picture";

                // Construct the full file path based on the admin ID
                string filePath = Path.Combine(networkPath, adminId.ToString() + ".jpg");

                // Check if the file already exists and, if so, delete it before copying the new image
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                // Copy the selected image to the network location
                File.Copy(imagePath, filePath, true);

                // Dispose of the previous image
                if (adminpicture.Image != null)
                {
                    adminpicture.Image.Dispose();
                    adminpicture.Image = null;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the admin picture: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void adminpicture_Click(object sender, EventArgs e)
        {

        }

        private void idtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminnametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void changepicturebtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
