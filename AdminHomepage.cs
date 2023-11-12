using Canteen.ver1.ADMIN_CONTROL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canteen.ver1
{
    public partial class adminhomepage : Form
    {
        private int adminId;

        public adminhomepage(int adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
            home home1 = new home();
            addUserControl(home1);

            // Load and display the admin's picture based on the admin ID.
            LoadAdminPicture(adminId);
        }
        private void LoadAdminPicture(int adminId)
        {
            // Define the network path where the pictures are stored.
            string networkPath = @"\\172.16.0.4\CanteenManagementSystem\Canteen.ver1\Admin Picture";

            // Construct the full file path based on the admin ID.
            string filePath = Path.Combine(networkPath, adminId.ToString() + ".jpg");

            // Check if the file exists.
            if (File.Exists(filePath))
            {
                // Dispose of the previously loaded image, if it exists
                if (adminpicturebaseonid.Image != null)
                {
                    adminpicturebaseonid.Image.Dispose();
                }

                // Load and display the image in a PictureBox or any other control of your choice.
                Image image = Image.FromFile(filePath);
                adminpicturebaseonid.Image = image;
            }
            else
            {
                MessageBox.Show("Image not found for this admin ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void adminhomepage_Load(object sender, EventArgs e)
        {

        }
        public string AdminName
        {
            get { return adminnamelabel.Text; }
            set { adminnamelabel.Text = value; }
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            dashpanel.Controls.Clear();
            dashpanel.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            home home1 = new home();
            addUserControl(home1);
        }
         
        private void accountingbtn_Click(object sender, EventArgs e)
        {
            accounting Accounting1 = new accounting();
            addUserControl(Accounting1);
        }

        private void canteenstaffbtn_Click(object sender, EventArgs e)
        {
            canteenstaff canteenstaff1 = new canteenstaff();
            addUserControl(canteenstaff1);
        }

        private void Logout1brn_Click(object sender, EventArgs e)
        {
            // Update the logout time in the historylogstbl table
            UpdateLogoutHistory(adminId);

            this.Hide();
            login login = new login();
            login.ShowDialog();
            
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

        private void manageaccountbtn_Click(object sender, EventArgs e)
        {
            adminmanageaccount adminmanageaccount = new adminmanageaccount(adminId);
            adminmanageaccount.PictureUpdated += UpdateAdminPicture;
            adminmanageaccount.AdminNameUpdated += UpdateAdminName;
            addUserControl(adminmanageaccount);
        }
        // Handle the event by updating the displayed name
        private void UpdateAdminName(string newCanteenStaffName)
        {
            AdminName = newCanteenStaffName;
        }
        private void UpdateAdminPicture(string newImagePath)
        {
            if (File.Exists(newImagePath))
            {
                // Dispose of the previously loaded image, if it exists
                if (adminpicturebaseonid.Image != null)
                {
                    adminpicturebaseonid.Image.Dispose();
                }

                // Load the new image from the specified path
                Image image = Image.FromFile(newImagePath);

                // Set the new image as the picture for the adminpicturebaseonid control
                adminpicturebaseonid.Image = image;
            }
            else
            {
                MessageBox.Show("The selected image file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void adminpicturebaseonid_Click(object sender, EventArgs e)
        {

        }

        private void historylogsbtn_Click(object sender, EventArgs e)
        {
            histlogs histlogs = new histlogs(adminId); // Pass the adminId
            addUserControl(histlogs);
        }
    }
}
