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

namespace Canteen.ver1.CANTEEN_STAFF_CONTROL
{
    public partial class canteenstaffhistlogs : UserControl
    {
        private string connectionString = @"Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public canteenstaffhistlogs(int canteenstaffid)
        {
            InitializeComponent();

            try
            {
                // Initialize the SqlConnection and open it
                connection = new SqlConnection(connectionString);
                connection.Open();

                // Load data into the DataGridView for the specified adminId
                string query = "SELECT * FROM historylogstbl WHERE userId = @canteenstaffid";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@canteenstaffid", canteenstaffid);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
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

        private void canteenstaffhistlogs_Load(object sender, EventArgs e)
        {

        }
    }
}
