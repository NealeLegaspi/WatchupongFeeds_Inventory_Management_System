namespace AdminSide
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            UC_Admin_Dashboard dashboard = new UC_Admin_Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
