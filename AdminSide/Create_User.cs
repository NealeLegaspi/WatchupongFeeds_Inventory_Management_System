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
    public partial class Create_User : Form
    {
        public Create_User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          UC_Admin_Dashboard uC = new UC_Admin_Dashboard();
            uC.Show();
            this.Hide();
        }
    }
}
