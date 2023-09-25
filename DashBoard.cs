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
    public partial class DashBoard : Form
    {
        
        private double currentTotal = 0;
        private char selectedOperator = ' ';
        
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            this.KeyPress += DashBoard_KeyPress;
        }
        private void paybtn_Click(object sender, EventArgs e)
        {
            string input = totaltextBox.Text.Trim();
            if (!string.IsNullOrEmpty(input))
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    object result = dataTable.Compute(input, "");
                    currentTotal = Convert.ToDouble(result); // Update currentTotal with the computed value

                    // Pass the updated total value and expression to paymentmethod
                    paymentmethod paymentForm = new paymentmethod(currentTotal);
                    paymentForm.ShowDialog();

                    // Pass the same total value to UseMealVoucher form
                    //UseMealVoucher voucherForm = new UseMealVoucher(currentTotal);
                   // voucherForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void zerobtn_Click(object sender, EventArgs e)
        {
            totaltextBox.Text += "0";
        }

        private void onebtn_Click(object sender, EventArgs e)
        {
            totaltextBox.Text += "1";  
        }

        private void twobtn_Click(object sender, EventArgs e)
        {
            totaltextBox.Text += "2";
        }

        private void threebtn_Click(object sender, EventArgs e)
        {
            totaltextBox.Text += "3";
        }

        private void fourbtn_Click(object sender, EventArgs e)
        {
            totaltextBox.Text += "4";
        }

        private void fivebtn_Click(object sender, EventArgs e)
        {
            totaltextBox.Text += "5";
        }

        private void sixbtn_Click(object sender, EventArgs e)
        {
            totaltextBox.Text += "6";
        }

        private void sevenbtn_Click(object sender, EventArgs e)
        {
            totaltextBox.Text += "7";
        }

        private void eightbtn_Click(object sender, EventArgs e)
        {
            totaltextBox.Text += "8";
        }

        private void ninebtn_Click(object sender, EventArgs e)
        {
            totaltextBox.Text += "9";
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            totaltextBox.Text = ""; 
            currentTotal = 0;
            selectedOperator = ' ';
        }

        private void percentbtn_Click(object sender, EventArgs e)
        {
            // Append the minus operator to the existing text
            totaltextBox.Text += "%";
            selectedOperator = '%';
        }

        private void negativebtn_Click(object sender, EventArgs e)
        {
            // Append the minus operator to the existing text
            totaltextBox.Text += "-";
            selectedOperator = '-';
        }

        private void plusbtn_Click(object sender, EventArgs e)
        {
            // Append the plus operator to the existing text
            totaltextBox.Text += "+";
            selectedOperator = '+';
        }

        private void dividebtn_Click(object sender, EventArgs e)
        {
            // Append the division operator to the existing text
            totaltextBox.Text += "/";
            selectedOperator = '/';
        }

        private void timesbtn_Click(object sender, EventArgs e)
        {
            // Append the multiplication operator to the existing text
            totaltextBox.Text += "*";
            selectedOperator = '*';
        }

        private void dotbtn_Click(object sender, EventArgs e)
        {
            // Append the minus operator to the existing text
            totaltextBox.Text += ".";
            selectedOperator = '.';
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

            // Use DataTable.Compute to evaluate the expression
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

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Hide();
            login login1 = new login();
            login1.ShowDialog();
        }

        private void Delbtn_Click(object sender, EventArgs e)
        {
            if (totaltextBox.Text.Length > 0)
            {
                totaltextBox.Text = totaltextBox.Text.Remove(totaltextBox.Text.Length - 1);
            }
        }
    }
}
