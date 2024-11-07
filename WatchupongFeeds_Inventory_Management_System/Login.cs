using Cashier;

namespace WatchupongFeeds_Inventory_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UC_Cashier_Dashboard dashboardC = new UC_Cashier_Dashboard();
            dashboardC.Show();
            this.Hide();
        }
    }
}
