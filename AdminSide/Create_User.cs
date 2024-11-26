using AdminSide;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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

        private void button2_Click(object sender, EventArgs e)
        {
            WatchupongConnections.Instance.Open();
            var query = WatchupongConnections.Instance.CreateCommand("INSERT INTO User_Information values ((SELECT COUNT(UserID) FROM User_Information), @NM, @email, @phoneN, @DoF, @Role, @Gen)");

            query.Parameters.AddWithValue("@NM", $"{txtfirst.Text} {txtlast.Text} ");
            query.Parameters.AddWithValue("@email",txtemail.Text);
            query.Parameters.AddWithValue("@phoneN",txtcontact.Text);
            query.Parameters.AddWithValue("@DoF", txtDoB.Text);
            query.Parameters.AddWithValue("@Role", "Admin");
            if (RBfmale.Checked)
            {
                query.Parameters.AddWithValue("@Gen", "Female");
            }
            else
            {
                query.Parameters.AddWithValue("@Gen", "Male");
            }
            
            query.ExecuteNonQuery();
            
        }
    }
}
