using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Canteen.ver1.CANTEEN_STAFF_CONTROL
{
    public partial class paidcreditreports : UserControl
    {
        private string connectionString = @"Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public paidcreditreports()
        {
            InitializeComponent();
        }

        private void creditreports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'canteenDBDataSet.paycreditreportstbl' table. You can move, or remove it, as needed.
            this.paycreditreportstblTableAdapter.Fill(this.canteenDBDataSet.paycreditreportstbl);
            // TODO: This line of code loads data into the 'canteenDBDataSet.customertbl' table. You can move, or remove it, as needed.
            this.paycreditreportstblTableAdapter.Fill(this.canteenDBDataSet.paycreditreportstbl);
            try
            {
                // Initialize the SqlConnection and open it
                connection = new SqlConnection(connectionString);
                connection.Open();

                // Load data into the DataGridView with a filter to show only customers with credit
                string query = "SELECT * FROM paycreditreportstbl";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                paycreditreportstblDataGridView.DataSource = dataTable;
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
    }
}
