using Administrator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSide
{
    public partial class UC_Admin_Dashboard : Form
    {
        public UC_Admin_Dashboard()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Admin_Account());
        }

        private void btnHomeAdmin_Click(object sender, EventArgs e)
        {
            loadform(new Admin_Dashboard());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Admin_ActivityLogs());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Admin_OrderHistory());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new Admin_Inventory());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new Admin_DeliveryLogs());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin_Login Logout = new Admin_Login();
            Logout.Show();
            this.Hide();
        }

        private void UC_Admin_Dashboard_Load(object sender, EventArgs e)
        {
            AdminDashboard admin = new AdminDashboard();
            mainPanel.Controls.Add(admin);

        }
    }
}
