using Canteen.ver1.CANTEEN_STAFF_CONTROL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Canteen.ver1
{
    public partial class DashBoard : Form
    {
        private double currentTotal = 0;
        private Reports reportsForm;

        public Reports ReportsFormReference { get; private set; }
        public canteenstaffhomepage StaffHomepageReference { get; set; }


        public DashBoard(canteenstaffhomepage staffHomepage)
        {
            InitializeComponent ();
            this.StaffHomepageReference = staffHomepage; // Store the reference to the StaffHomepage
            //reportsForm = new Reports();
            timer1.Interval = 1000; // Set the Timer interval to 1000ms (1 second)
            timer1.Start(); // Start the Timer
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            this.KeyPress += DashBoard_KeyPress;

            UpdateDateTime();
        }


        private void UpdateDateTime()
        {
            // Display the formatted date and time
            string formattedDate = DateTime.Now.ToString("dddd, d, MMM");
            string formattedTime = DateTime.Now.ToString("hh:mm:ss tt");

            datelabel.Text = formattedDate;
            timelabel.Text = formattedTime;
        }
        private void equalbtn_Click(object sender, EventArgs e)
        {
            // Validate input
            string input = totaltextBox.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter an expression.");
                return;
            }

            try
            {
                DataTable dataTable = new DataTable();
                object result = dataTable.Compute(input, "");
                totaltextBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void chargebtn_Click(object sender, EventArgs e)
        {
            string input = totaltextBox.Text.Trim();
            if (!string.IsNullOrEmpty(input))
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    object result = dataTable.Compute(input, "");
                    currentTotal = Convert.ToDouble(result);

                    // Check if the total is valid
                    if (currentTotal <= 0)
                    {
                        MessageBox.Show("Invalid total amount. Please enter a valid amount.");
                        return;
                    }

                    // Pass the updated total value and expression to the customer charge form
                    CustomerCharges Voucher = new CustomerCharges(currentTotal);
                    Voucher.ShowDialog();

                    // Clear the textbox after the transaction is completed
                    totaltextBox.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.StaffHomepageReference.addUserControl(new homecanteen());
            Close();
        }

        private void cashpaymentbtn_Click(object sender, EventArgs e)
        {
            string input = totaltextBox.Text.Trim();
            if (!string.IsNullOrEmpty(input))
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    object result = dataTable.Compute(input, "");
                    currentTotal = Convert.ToDouble(result);

                    // Check if the total is valid
                    if (currentTotal <= 0)
                    {
                        MessageBox.Show("Invalid total amount. Please enter a valid amount.");
                        return;
                    }

                    // Pass the reference to the Reports form to the paymentcash form
                    paymentcash paymentCashForm = new paymentcash(currentTotal, reportsForm); // Use the reference to the reportsForm you initialized above

                    // Show the payment form
                    paymentCashForm.ShowDialog();

                    // Clear the textbox after the transaction is completed
                    totaltextBox.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update the time label every second
            UpdateDateTime();
        }
    }
}
