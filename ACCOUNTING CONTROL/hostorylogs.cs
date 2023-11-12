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

namespace Canteen.ver1.ACCOUNTING_CONTROL
{
    public partial class hostorylogs : UserControl
    {
        private string connectionString = @"Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public hostorylogs(int accountingId)
        {
            InitializeComponent();
            try
            {
                // Initialize the SqlConnection and open it
                connection = new SqlConnection(connectionString);
                connection.Open();

                // Load data into the DataGridView for the specified adminId
                string query = "SELECT * FROM historylogstbl WHERE userId = @accountingId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@accountingId", accountingId);

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

        private void hostorylogs_Load(object sender, EventArgs e)
        {

        }
    }
}
