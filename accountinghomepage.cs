using Canteen.ver1.ACCOUNTING_CONTROL;
using Canteen.ver1.ADMIN_CONTROL;
using Canteen.ver1.CANTEEN_STAFF_CONTROL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Canteen.ver1
{
    public partial class CashierHomepage : Form
    {
        private int accountingid;
        private string connectionString = @"Data Source=LASER-GENPC01;Initial Catalog=CanteenDB;Integrated Security=True";
        public CashierHomepage(int accountingid)
        {
            InitializeComponent();
            this.accountingid = accountingid;
            homeaccounting home1 = new homeaccounting();
            addUserControl(home1);
            LoadAccountingPicture(accountingid);

        }
        private void LoadAccountingPicture(int accountingid)
        {
            // Define the network path where the pictures are stored.
            string networkPath = @"\\172.16.0.4\CanteenManagementSystem\Canteen.ver1\Accounting Picture";

            // Construct the full file path based on the admin ID.
            string filePath = Path.Combine(networkPath, accountingid.ToString() + ".jpg");

            // Check if the file exists.
            if (File.Exists(filePath))
            {
                if (accountingpicture.Image != null)
                {
                    accountingpicture.Image.Dispose();
                }

                try
                {
                    Image image = Image.FromFile(filePath);
                    accountingpicture.Image = image;
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
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            dashaccountingpanel.Controls.Clear();
            dashaccountingpanel.Controls.Add(userControl);
            userControl.BringToFront();

        }

        public string AccountingName
        {
            get { return accountingname1label.Text; }
            set { accountingname1label.Text = value; }
        }

        private void AdminHomepage_Load(object sender, EventArgs e)
        {

        }



        private void Logout1brn_Click(object sender, EventArgs e)
        {
            // Update the logout time in the historylogstbl table
            UpdateLogoutHistory(accountingid);
            this.Hide();
            login LOG = new login();
            LOG.ShowDialog();
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
        private void homebtn_Click(object sender, EventArgs e)
        {
            homeaccounting home1 = new homeaccounting();
            addUserControl(home1);
        }

        private void customerdetailsbtn_Click(object sender, EventArgs e)
        {
            customerdetail customerdetails1 = new customerdetail();
            addUserControl(customerdetails1);
        }

        private void reports1btn_Click(object sender, EventArgs e)
        {
            reports reports = new reports();
            addUserControl(reports);
        }

        private void manageaccount1_Click(object sender, EventArgs e)
        {
            accountingmanageaccount accountingmanageaccount = new accountingmanageaccount(accountingid);
            accountingmanageaccount.AccountingUpdated += UpdateAccountingName;
            addUserControl(accountingmanageaccount);
        }

        private void UpdateAccountingName(string newAccountingName)
        {
            AccountingName = newAccountingName;
        }

        private void accountinghistlogsbtn_Click(object sender, EventArgs e)
        {
            hostorylogs hostorylogs = new hostorylogs(accountingid);
            addUserControl(hostorylogs);
        }
    }
}
