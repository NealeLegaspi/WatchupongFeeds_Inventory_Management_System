using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier
{
    public partial class Cashier_Home : Form
    {
        public Cashier_Home()
        {
            InitializeComponent();
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Hide();
        }
        private void btnAccount_Click_1(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Hide();
        }
    }
}
