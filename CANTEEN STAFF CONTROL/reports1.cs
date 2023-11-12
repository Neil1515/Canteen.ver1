using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canteen.ver1.CANTEEN_STAFF_CONTROL
{
    public partial class reports1 : UserControl
    {
        public reports1()
        {
            InitializeComponent();
        }
        private void LoadCashReports()
        {
            // Create an instance of the CashReports user control
            cashreports cashReports = new cashreports();

            // Set the user control's Dock property to fill the dashreportspanel
            cashReports.Dock = DockStyle.Fill;

            // Add the CashReports user control to the dashreportspanel
            dashreportspanel.Controls.Clear();
            dashreportspanel.Controls.Add(cashReports);
        }

        private void LoadCreditReports()
        {
            // Create an instance of the CreditReports user control (you'll need to implement this)
            paidcreditreports creditReports = new paidcreditreports();

            // Set the user control's Dock property to fill the dashreportspanel
            creditReports.Dock = DockStyle.Fill;

            // Add the CreditReports user control to the dashreportspanel
            dashreportspanel.Controls.Clear();
            dashreportspanel.Controls.Add(creditReports);
        }

        private void LoadChargesReports()
        {
            // Create an instance of the CreditReports user control (you'll need to implement this)
            chargesreports chargesreports = new chargesreports();

            // Set the user control's Dock property to fill the dashreportspanel
            chargesreports.Dock = DockStyle.Fill;

            // Add the CreditReports user control to the dashreportspanel
            dashreportspanel.Controls.Clear();
            dashreportspanel.Controls.Add(chargesreports);
        }

        private void cashbtn_Click(object sender, EventArgs e)
        {
            LoadCashReports();
        }

        private void creditbtn_Click(object sender, EventArgs e)
        {
            LoadCreditReports();
        }

        private void dashreportspanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reports1_Load(object sender, EventArgs e)
        {
            // Create an instance of the CashReports user control
            cashreports cashReports = new cashreports();

            // Set the user control's Dock property to fill the dashreportspanel
            cashReports.Dock = DockStyle.Fill;

            // Add the CashReports user control to the dashreportspanel
            dashreportspanel.Controls.Clear();
            dashreportspanel.Controls.Add(cashReports);
        }

        private void chargesbtn_Click(object sender, EventArgs e)
        {
            LoadChargesReports();
        }
    }
}
