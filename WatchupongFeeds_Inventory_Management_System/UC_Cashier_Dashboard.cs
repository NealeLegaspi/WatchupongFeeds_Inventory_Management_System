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
    public partial class UC_Cashier_Dashboard : Form
    {
        public UC_Cashier_Dashboard()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.MainPanelCashier.Controls.Count > 0)
                this.MainPanelCashier.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanelCashier.Controls.Add(f);
            this.MainPanelCashier.Tag = f;
            f.Show();
        }

        private void btnHomeAdmin_Click(object sender, EventArgs e)
        {
            loadform(new Cashier_Dashboard());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new OrderHistory());
        }


    }
}
