using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canteen.ver1
{
    public partial class paymentmethod : Form
    {
        public double TotalValue { get; set; }
        public paymentmethod(double totalValue)
        {
            InitializeComponent();
            TotalValue = totalValue;
        }

        private void totalpaylebel_Click(object sender, EventArgs e)
        {

        }

        private void paymentmethod_Load(object sender, EventArgs e)
        {
            // Display the total value and expression in the label
            totalpaylebel.Text = $"TOTAL PAY: {TotalValue:C2}";
        }

        private void MealVoucherbtn_Click(object sender, EventArgs e)
        {
            Hide();
            UseMealVoucher Voucher = new UseMealVoucher(TotalValue); // Pass the TotalValue
            Voucher.ShowDialog();
        }
    }
}
