using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Canteen.ver1.ADMIN_CONTROL
{
    public partial class canteenstaff : UserControl
    {
        private string connectionString = @"Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string imagePath;
        public canteenstaff()
        {
            InitializeComponent();
        }

        private void canteenstaff_Load(object sender, EventArgs e)
        {
           

        }
        private void ClearFields()
        {
            idtextBox.Text = "";
            canteenstaffnametextBox.Text = "";
            passwordtextBox.Text = "";
            usernameTextBox.Text = "";
            canteenstaffpicture.Image = default;
        }


        private void canteenstaffuserbtn_Click(object sender, EventArgs e)
        {
            canteenstafftable canteenstafftable = new canteenstafftable();
            canteenstafftable.ShowDialog();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Please upload an image before saving the data.");
                return;
            }
            try
            {
                // Open a new SqlConnection
                connection = new SqlConnection(connectionString);
                connection.Open();

                string status = "Active";

                // Create and execute the SQL INSERT command
                string insertQuery = "INSERT INTO CanteenStaff (id, password, staffname, username, status) VALUES (@id, @password, @staffname, @username, @status)";
                command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@id", idtextBox.Text);
                command.Parameters.AddWithValue("@password", passwordtextBox.Text);
                command.Parameters.AddWithValue("@username", usernameTextBox.Text);
                command.Parameters.AddWithValue("@staffname", canteenstaffnametextBox.Text);
                command.Parameters.AddWithValue("@status", status);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    // Define the target path for saving the picture
                    string targetPath = "\\\\172.16.0.4\\CanteenManagementSystem\\Canteen.ver1\\CanteenStaff Picture\\" + idtextBox.Text + ".jpg";

                    // Copy the selected image to the target path
                    File.Copy(imagePath, targetPath, true);

                    MessageBox.Show("Data saved successfully.");
                    ClearFields();

                    // Reload data into the DataGridView to reflect the changes
                    string query = "SELECT * FROM CanteenStaff";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    //dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Data not saved.");
                }
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

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string canteenstaffId = idtextBox.Text;
                string canteenstaffName = canteenstaffnametextBox.Text;
                string password = passwordtextBox.Text;
                string username = usernameTextBox.Text;

                if (string.IsNullOrWhiteSpace(canteenstaffId) || string.IsNullOrWhiteSpace(canteenstaffName) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter Accounting ID, new Name, and new last name for updating.");
                    return;
                }

                // Open a new SqlConnection
                connection = new SqlConnection(connectionString);
                connection.Open();

                // Create and execute the SQL UPDATE command
                string updateQuery = "UPDATE tblaccounting SET CanteenStaff = staffname = @staffname, username = @username, password = @password WHERE id = @id";
                command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@id", canteenstaffId);
                command.Parameters.AddWithValue("@staffname", canteenstaffName);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@username", username);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Customer information updated successfully.");
                    ClearFields();

                    // Reload data into the DataGridView to reflect the changes
                    string query = "SELECT * FROM CanteenStaff";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    //dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Customer not found or data not updated.");
                }
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

        private void uploadbtn_Click(object sender, EventArgs e)
        {
            // Create an instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected image file path
                imagePath = openFileDialog.FileName; // Assign the selected image path to the class-level variable

                try
                {
                    // Load the selected image and set it to the PictureBox control
                    canteenstaffpicture.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error uploading profile picture: " + ex.Message);
                }
            }
        }
    }
}
