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

namespace Canteen.ver1.CANTEEN_STAFF_CONTROL
{
    public partial class staffmanageaccount : UserControl
    {
        private int canteenstaffId;
        private string imagePath;
        // Declare the PictureUpdated event
        public event Action<string> PictureUpdated;
        public event Action<string> CanteenStaffUpdated;
        public staffmanageaccount(int canteenstaffId)
        {
            InitializeComponent();
            this.canteenstaffId = canteenstaffId;

            // Debug message to check the adminId value
            //MessageBox.Show("Canteenstaff ID: " + canteenstaffId);

            // Load and display the admin's information based on the admin ID.
            LoadCanteenStaffInformation(canteenstaffId);
            // Load and display the admin's picture based on the admin ID.
            LoadCanteenStaffPicture(canteenstaffId);
        }

        private void staffmanageaccount_Load(object sender, EventArgs e)
        {

        }

        private void LoadCanteenStaffInformation(int canteenstaffId)
        {
            // Define your connection string
            string connectionString = "Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Define the SQL query to retrieve admin information based on the admin ID
                string sqlQuery = "SELECT id, staffname, username FROM CanteenStaff WHERE id = @canteenstaffId";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@canteenstaffId", canteenstaffId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Display admin details in the textboxes
                            idtextBox.Text = reader["id"].ToString();
                            canteenstaffnametextBox.Text = reader["staffname"].ToString();
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
        private void LoadCanteenStaffPicture(int canteenstaffId)
        {
            // Define the network path where the pictures are stored.
            string networkPath = @"\\172.16.0.4\CanteenManagementSystem\Canteen.ver1\CanteenStaff Picture";

            // Construct the full file path based on the admin ID.
            string filePath = Path.Combine(networkPath, canteenstaffId.ToString() + ".jpg");

            // Check if the file exists.
            if (File.Exists(filePath))
            {
                // Load and display the image in a PictureBox or any other control of your choice.
                Image image = Image.FromFile(filePath);
                canteenstaffpicture.Image = image; // Assuming you have a PictureBox named pictureBoxAdmin.
            }
            else
            {
                MessageBox.Show("Image not found for this Canteen Staff ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string newUsername = usernameTextBox.Text;
            string newCanteenStaffName = canteenstaffnametextBox.Text;

            // Update the admin's information in the database
            if (UpdateCanteenStaffInfo(newUsername, newCanteenStaffName, canteenstaffId))
            {
                // Notify the subscribers (adminhomepage) that the admin name has been updated
                CanteenStaffUpdated?.Invoke(newCanteenStaffName);
                // Check if a new image is selected
                if (!string.IsNullOrEmpty(imagePath))
                {
                    if (UpdateAdminPicture(canteenstaffId, imagePath))
                    {
                        MessageBox.Show("Canteen Staff information and picture updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCanteenStaffPicture(canteenstaffId); // Reload the updated picture
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the Canteen Staff picture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private bool UpdateCanteenStaffInfo(string newUsername, string newCanteenStaffName, int canteenstaffId)
        {
            try
            {
                // Define your connection string
                string connectionString = "Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Define the SQL query to update admin information
                    string sqlQuery = "UPDATE CanteenStaff SET username = @newUsername, staffname = @newCanteenStaffName WHERE id = @canteenstaffId";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@newUsername", newUsername);
                        cmd.Parameters.AddWithValue("@newCanteenStaffName", newCanteenStaffName);
                        cmd.Parameters.AddWithValue("@canteenstaffId", canteenstaffId);

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
        private bool UpdateAdminPicture(int canteenstaffId, string imagePath)
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
                string filePath = Path.Combine(networkPath, canteenstaffId.ToString() + ".jpg");

                // Check if the file already exists and, if so, delete it before copying the new image
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                // Copy the selected image to the network location
                File.Copy(imagePath, filePath, true);

                // Dispose of the previous image
                if (canteenstaffpicture.Image != null)
                {
                    canteenstaffpicture.Image.Dispose();
                    canteenstaffpicture.Image = null;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the admin picture: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
