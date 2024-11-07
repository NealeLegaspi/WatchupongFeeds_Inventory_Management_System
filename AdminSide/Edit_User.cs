using AdminSide;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator
{
    public partial class Edit_User : Form
    {
        public Edit_User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_Admin_Dashboard uC_Admin_Dashboard = new UC_Admin_Dashboard();
            uC_Admin_Dashboard.Show();
            this.Hide();
        }
    }
}
