using System;
using Canteen.ver1.CANTEEN_STAFF_CONTROL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Canteen.ver1.ADMIN_CONTROL;

namespace Canteen.ver1
{
    public partial class canteenstaffhomepage : Form
    {
        private int canteenstaffid;
        public canteenstaffhomepage(int canteenstaffid)
        {
            InitializeComponent();
            this.canteenstaffid = canteenstaffid;
            homecanteen home1 = new homecanteen();
            addUserControl(home1);
            LoadCanteenStaffPicture(canteenstaffid);
        }
        private void LoadCanteenStaffPicture(int canteenstaffid)
        {
            // Define the network path where the pictures are stored.
            string networkPath = @"\\172.16.0.4\CanteenManagementSystem\Canteen.ver1\CanteenStaff Picture";

            // Construct the full file path based on the admin ID.
            string filePath = Path.Combine(networkPath, canteenstaffid.ToString() + ".jpg");

            // Check if the file exists.
            if (File.Exists(filePath))
            {
                if (canteenstaffpicture.Image != null)
                {
                    canteenstaffpicture.Image.Dispose();
                }

                try
                {
                    Image image = Image.FromFile(filePath);
                    canteenstaffpicture.Image = image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Image not found for this admin ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        internal void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            dashpanel.Controls.Clear();
            dashpanel.Controls.Add(userControl);
            userControl.BringToFront();

        }
        // Property to set the staff member's name
        // Property to set the staff member's name
        public string StaffName
        {
            get { return staffnamelabel.Text; }
            set { staffnamelabel.Text = value; }
        }

        private void Logoutbrn_Click(object sender, EventArgs e)
        {
            // Update the logout time in the historylogstbl table
            UpdateLogoutHistory(canteenstaffid);

            this.Hide();
            login log = new login();
            log.ShowDialog();
        }
        private void UpdateLogoutHistory(int userId)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True"))
                {
                    cn.Open();

                    // Update the datetimeout in the historylogstbl table
                    using (SqlCommand cmd = new SqlCommand("UPDATE historylogstbl SET datetimeout = @logoutTime WHERE userId = @userId AND datetimeout IS NULL", cn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@logoutTime", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update logout history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void staffnamelabel_Click(object sender, EventArgs e)
        {

        }

        private void customerpay1btn_Click(object sender, EventArgs e)
        {
            DashBoard home = new DashBoard(this);
            home.ShowDialog();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            homecanteen home1 = new homecanteen();
            addUserControl(home1);
        }

        private void customercreditbtn_Click(object sender, EventArgs e)
        {
            customercredits customercredits = new customercredits(this);
            addUserControl(customercredits);
        }

        private void reports1btn_Click(object sender, EventArgs e)
        {
            reports1 reports1 = new reports1();
            addUserControl(reports1);
        }

        private void manageaccount1_Click(object sender, EventArgs e)
        {
            staffmanageaccount staffmanageaccount = new staffmanageaccount(canteenstaffid);
            staffmanageaccount.CanteenStaffUpdated += UpdateCanteenStaffName;
            addUserControl(staffmanageaccount);
        }
        private void UpdateCanteenStaffName(string newStaffName)
        {
            StaffName = newStaffName;
        }

        private void historylogsbtn_Click(object sender, EventArgs e)
        {
            canteenstaffhistlogs canteenstaffhistlogs = new canteenstaffhistlogs(canteenstaffid);
            addUserControl (canteenstaffhistlogs);
        }
    }
}
