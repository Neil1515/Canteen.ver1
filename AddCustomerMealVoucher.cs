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
    public partial class AddCustomerMealVoucher : Form
    {
        public AddCustomerMealVoucher()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Hide();
            AdminHomepage AdminHomepage = new AdminHomepage();
            AdminHomepage.ShowDialog();
        }
    }
}
