using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Canteen.ver1
{
    public partial class canteenstafftable : Form
    {
        private string connectionString = @"Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        public canteenstafftable()
        {
            InitializeComponent();
        }

        private void canteenstafftable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'canteenDBDataSet.customertbl' table. You can move, or remove it, as needed.
            this.canteenstaffTableAdapter.Fill(this.canteenDBDataSet.Canteenstaff);
            // TODO: This line of code loads data into the 'canteenDBDataSet.customertbl' table. You can move, or remove it, as needed.
            this.canteenstaffTableAdapter.Fill(this.canteenDBDataSet.Canteenstaff);
            try
            {
                // Initialize the SqlConnection and open it
                connection = new SqlConnection(connectionString);
                connection.Open();

                // Load data into the DataGridView
                string query = "SELECT * FROM Canteenstaff";
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
    }
}
