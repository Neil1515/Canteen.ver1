using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class login : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        private int canteenstaffid;
        private int accountingid;
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            
            cn = new SqlConnection(@"Data Source=192.168.1.3;Initial Catalog=CanteenDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1");
            cn.Open();
            //Data Source=192.168.1.3;Initial Catalog=CanteenDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1
            //"A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: Named Pipes Provider, error: 40 - Could not open a connection to SQL Server)"}
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {
                int userId; // Define userId here

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;

                    // Check the Canteenstaff table first
                    cmd.CommandText = "SELECT * FROM Canteenstaff WHERE username = @username AND password = @password";
                    cmd.Parameters.AddWithValue("@username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@password", txtpassword.Text);

                    dr = cmd.ExecuteReader();

                    if (dr.HasRows) // Check if any rows were returned
                    {
                        dr.Read(); // Move to the first row
                        string staffName = dr["staffname"].ToString(); // Replace "staffname" with your actual column name for staff name
                        userId = Convert.ToInt32(dr["id"]); // Assign userId here
                        dr.Close(); // Close the SqlDataReader after reading data

                        InsertLoginHistory(userId);
                        MessageBox.Show("Login Successful as Canteen Staff.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // After a successful login as Canteen Staff
                        this.Hide();
                        

                        canteenstaffhomepage home = new canteenstaffhomepage(userId);
                        home.StaffName = staffName; // Set the staff member's name
                        home.ShowDialog();
                        return; // Exit the method since login was successful
                    }


                    dr.Close(); // Close the SqlDataReader

                    // If not found in Canteenstaff, check the tblaccounting table
                    cmd.CommandText = "SELECT * FROM tblaccounting WHERE username = @username AND password = @password";
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows) // Check if any rows were returned
                    {
                        dr.Read(); // Move to the first row
                        string accountingName = dr["accountingname"].ToString(); // Replace "accountingname" with your actual column name for accounting name
                        userId = Convert.ToInt32(dr["id"]);
                        dr.Close(); // Close the SqlDataReader after reading data
                        
                        InsertLoginHistory(userId);
                        MessageBox.Show("Login Successful as Accounting.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        CashierHomepage home = new CashierHomepage(userId);
                        home.AccountingName = accountingName; // Set the accounting member's name
                        home.ShowDialog();
                        return; // Exit the method since login was successful as Accounting
                    }

                    dr.Close(); // Close the SqlDataReader
                }

                MessageBox.Show("No Account available with this username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please enter values in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertLoginHistory(int userId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=192.168.1.3;Initial Catalog=CanteenDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("INSERT INTO historylogstbl (userId, datetimein) VALUES (@userId, @loginTime)", connection))
                    {
                        command.Parameters.AddWithValue("@userId", userId);
                        command.Parameters.AddWithValue("@loginTime", DateTime.Now);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void forgetpasslink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            securityadmin securityadmin = new securityadmin();
            securityadmin.ShowDialog();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the database connection (if open)
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

                Application.Exit(); // Exit the application
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
