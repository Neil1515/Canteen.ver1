using Canteen.ver1.ADMIN_CONTROL;
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
    public partial class securityadmin : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        private int adminId;
        public securityadmin()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpassword.Text) || string.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userId; // Define userId here

            try
            {
                using (cn = new SqlConnection(@"Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True"))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM admintbl WHERE username = @username AND password = @password ", cn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtusername.Text);
                        cmd.Parameters.AddWithValue("@password", txtpassword.Text);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string adminName = dr["adminame"].ToString();
                                userId = Convert.ToInt32(dr["id"]); // Assign userId here
                                dr.Close();

                                // Insert a record into the historylogstbl table
                                InsertLoginHistory(userId);
                                MessageBox.Show("Login Successful.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                adminhomepage adminHomepage = new adminhomepage(userId); // Pass the userId here
                                adminHomepage.AdminName = adminName;
                                adminHomepage.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("No account available with this username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertLoginHistory(int userId)
        {
            try
            {
                using (cn = new SqlConnection(@"Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True"))
                {
                    cn.Open();

                    // Insert a new login record into historylogstbl
                    using (cmd = new SqlCommand("INSERT INTO historylogstbl (userId, datetimein) VALUES (@userId, @loginTime)", cn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@loginTime", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert login history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void securityadmin_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True");
            cn.Open();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
        }
    }
}
