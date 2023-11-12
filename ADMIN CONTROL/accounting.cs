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
    public partial class accounting : UserControl
    {
        private string connectionString = @"Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string imagePath;
        public accounting()
        {
            InitializeComponent();
        }

        private void accounting_Load(object sender, EventArgs e)
        {
            
        }
        private void ClearFields()
        {
            idtextBox.Text = "";
            accountingnametextBox.Text = "";
            passwordtextBox.Text = "";
            usernameTextBox.Text = "";
            accountingpicture.Image = default;
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
                string insertQuery = "INSERT INTO tblaccounting (id, password, accountingname, username, status) VALUES (@id, @password, @accountingname, @username, @status)";
                command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@id", idtextBox.Text);
                command.Parameters.AddWithValue("@password", passwordtextBox.Text);
                command.Parameters.AddWithValue("@username", usernameTextBox.Text);
                command.Parameters.AddWithValue("@accountingname", accountingnametextBox.Text);
                command.Parameters.AddWithValue("@status", status);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    // Define the target path for saving the picture
                    string targetPath = "\\\\172.16.0.4\\CanteenManagementSystem\\Canteen.ver1\\Accounting Picture\\" + idtextBox.Text + ".jpg";

                    // Copy the selected image to the target path
                    File.Copy(imagePath, targetPath, true);

                    MessageBox.Show("Data saved successfully.");
                    ClearFields();

                    // Reload data into the DataGridView to reflect the changes
                    string query = "SELECT * FROM tblaccounting";
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
                string accountingId = idtextBox.Text;
                string accountingName = accountingnametextBox.Text;
                string password = passwordtextBox.Text;
                string username = usernameTextBox.Text;

                if (string.IsNullOrWhiteSpace(accountingId) || string.IsNullOrWhiteSpace(accountingName) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter Accounting ID, new Name, and new last name for updating.");
                    return;
                }

                // Open a new SqlConnection
                connection = new SqlConnection(connectionString);
                connection.Open();

                // Create and execute the SQL UPDATE command
                string updateQuery = "UPDATE tblaccounting SET accountingname = @accountingname, username = @username, password = @password WHERE id = @id";
                command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@id", accountingId);
                command.Parameters.AddWithValue("@accountingname", accountingName);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@username", username);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Customer information updated successfully.");
                    ClearFields();

                    // Reload data into the DataGridView to reflect the changes
                    string query = "SELECT * FROM tblaccounting";
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

        private void idtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void accountingnametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtextBox_TextChanged(object sender, EventArgs e)
        {

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
                    accountingpicture.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error uploading profile picture: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void accountingpicture_Click(object sender, EventArgs e)
        {

        }

        private void accountinguserbtn_Click(object sender, EventArgs e)
        {
            accountingtable accountingtable = new accountingtable();
            accountingtable.ShowDialog();
        }
    }
}
