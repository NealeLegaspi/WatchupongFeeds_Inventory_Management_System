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
    public partial class GCash : Form
    {
        public GCash()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Gcash_Receipt Greceipt = new Gcash_Receipt();
            Greceipt.Show();
            this.Hide();
        }
    }
}
