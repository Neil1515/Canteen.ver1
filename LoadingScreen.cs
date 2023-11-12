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
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;

            if(panel1.Width >= 400)
            {
                timer1.Stop();

                this.Hide();
                StaffHomepage home = new StaffHomepage();
                //home.StaffName = staffName; // Set the staff member's name
                home.ShowDialog();
            }
        }
    }
}
