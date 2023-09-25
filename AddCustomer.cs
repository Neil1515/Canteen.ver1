using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canteen.ver1
{
    public partial class AddCustomer : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename =C:\Users\John Neil Aying\source\repos\Canteen.ver1\CanteenDB.mdf; Integrated Security = True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {
            try
            {
                // Initialize the SqlConnection and open it
                connection = new SqlConnection(connectionString);
                connection.Open();

                // Load data into the DataGridView
                string query = "SELECT * FROM customertbl";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
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

        private void ClearFields()
        {
            idtextbox.Text = "";
            fnametextbox.Text = "";
            lnametextbox.Text = "";
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Open a new SqlConnection
                connection = new SqlConnection(connectionString);
                connection.Open();

                // Create and execute the SQL INSERT command
                string insertQuery = "INSERT INTO customertbl (id, firstname, lastname) VALUES (@id, @firstname, @lastname)";
                command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@id", idtextbox.Text);
                command.Parameters.AddWithValue("@firstname", fnametextbox.Text);
                command.Parameters.AddWithValue("@lastname", lnametextbox.Text);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data saved successfully.");
                    ClearFields();

                    // Reload data into the DataGridView to reflect the changes
                    string query = "SELECT * FROM customertbl";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
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

        private void Removebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string customerId = IdRemovetextbox.Text;

                if (string.IsNullOrWhiteSpace(customerId))
                {
                    MessageBox.Show("Please enter a customer ID to remove.");
                    return;
                }

                // Open a new SqlConnection
                connection = new SqlConnection(connectionString);
                connection.Open();

                // Create and execute the SQL DELETE command
                string deleteQuery = "DELETE FROM customertbl WHERE id = @id";
                command = new SqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@id", customerId);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Customer removed successfully.");
                    IdRemovetextbox.Clear(); // Clear the IdRemovetextbox
                    ClearFields();

                    // Reload data into the DataGridView to reflect the changes
                    string query = "SELECT * FROM customertbl";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Customer not found or data not removed.");
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
                string customerId = idtextbox.Text;
                string newFirstName = fnametextbox.Text;
                string newLastName = lnametextbox.Text;

                if (string.IsNullOrWhiteSpace(customerId) || string.IsNullOrWhiteSpace(newFirstName) || string.IsNullOrWhiteSpace(newLastName))
                {
                    MessageBox.Show("Please enter customer ID, new first name, and new last name for updating.");
                    return;
                }

                // Open a new SqlConnection
                connection = new SqlConnection(connectionString);
                connection.Open();

                // Create and execute the SQL UPDATE command
                string updateQuery = "UPDATE customertbl SET firstname = @firstname, lastname = @lastname WHERE id = @id";
                command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@id", customerId);
                command.Parameters.AddWithValue("@firstname", newFirstName);
                command.Parameters.AddWithValue("@lastname", newLastName);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Customer information updated successfully.");
                    ClearFields();

                    // Reload data into the DataGridView to reflect the changes
                    string query = "SELECT * FROM customertbl";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
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

        private void search_TextChanged(object sender, EventArgs e)
        {
            string searchCriteria = searchbox.Text.Trim();

            try
            {
                // Open a new SqlConnection
                connection = new SqlConnection(connectionString);
                connection.Open();

                // Create and execute the SQL SELECT command for searching
                string searchQuery = "SELECT * FROM customertbl WHERE id LIKE @searchCriteria OR lastname LIKE @searchCriteria";
                command = new SqlCommand(searchQuery, connection);
                command.Parameters.AddWithValue("@searchCriteria", "%" + searchCriteria + "%"); // Use "%" for partial matching

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No matching records found.");
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

        private void Homepagebtn_Click(object sender, EventArgs e)
        {
            Hide();
            AdminHomepage Home = new AdminHomepage();
            Home.ShowDialog();

        }
    }
}
