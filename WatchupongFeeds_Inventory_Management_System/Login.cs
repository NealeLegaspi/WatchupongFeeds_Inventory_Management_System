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
            Cashier_Home cashier = new Cashier_Home();
            cashier.Show();
        }
    }
}
