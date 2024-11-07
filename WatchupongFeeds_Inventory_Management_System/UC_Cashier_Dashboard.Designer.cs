namespace Cashier
{
    partial class UC_Cashier_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Cashier_Dashboard));
            panel1 = new Panel();
            button3 = new Button();
            btnHomeAdmin = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            MainPanelCashier = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnHomeAdmin);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 749);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.ImageAlign = ContentAlignment.TopLeft;
            button3.Location = new Point(0, 329);
            button3.Name = "button3";
            button3.Size = new Size(251, 60);
            button3.TabIndex = 7;
            button3.Text = "     Order History";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnHomeAdmin
            // 
            btnHomeAdmin.BackColor = Color.Black;
            btnHomeAdmin.BackgroundImage = (Image)resources.GetObject("btnHomeAdmin.BackgroundImage");
            btnHomeAdmin.BackgroundImageLayout = ImageLayout.None;
            btnHomeAdmin.FlatStyle = FlatStyle.Popup;
            btnHomeAdmin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHomeAdmin.ForeColor = Color.White;
            btnHomeAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnHomeAdmin.Location = new Point(3, 228);
            btnHomeAdmin.Name = "btnHomeAdmin";
            btnHomeAdmin.Size = new Size(248, 55);
            btnHomeAdmin.TabIndex = 4;
            btnHomeAdmin.Text = "    Home";
            btnHomeAdmin.UseVisualStyleBackColor = false;
            btnHomeAdmin.Click += btnHomeAdmin_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 0);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(251, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1119, 100);
            panel2.TabIndex = 2;
            // 
            // MainPanelCashier
            // 
            MainPanelCashier.Dock = DockStyle.Fill;
            MainPanelCashier.Location = new Point(251, 100);
            MainPanelCashier.Name = "MainPanelCashier";
            MainPanelCashier.Size = new Size(1119, 649);
            MainPanelCashier.TabIndex = 3;
            // 
            // UC_Cashier_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(MainPanelCashier);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "UC_Cashier_Dashboard";
            Text = "UC_Cashier_Dashboard";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel MainPanelCashier;
        private Button btnHomeAdmin;
        private Button button3;
    }
}