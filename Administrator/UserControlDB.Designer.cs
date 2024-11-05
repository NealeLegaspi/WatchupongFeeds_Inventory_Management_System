namespace Administrator
{
    partial class UserControlDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDB));
            panel1 = new Panel();
            btnInventory = new Button();
            pictureBox3 = new PictureBox();
            btnDeliverylogs = new Button();
            btnOrderhistory = new Button();
            btnAccount = new Button();
            btnProduct = new Button();
            btnHome = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnInventory);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnDeliverylogs);
            panel1.Controls.Add(btnOrderhistory);
            panel1.Controls.Add(btnAccount);
            panel1.Controls.Add(btnProduct);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 749);
            panel1.TabIndex = 0;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = SystemColors.ControlText;
            btnInventory.FlatStyle = FlatStyle.Popup;
            btnInventory.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = Color.White;
            btnInventory.Image = (Image)resources.GetObject("btnInventory.Image");
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.Location = new Point(3, 577);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(224, 70);
            btnInventory.TabIndex = 34;
            btnInventory.Text = "   Inventory";
            btnInventory.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Black;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(63, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(93, 81);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            // 
            // btnDeliverylogs
            // 
            btnDeliverylogs.BackColor = SystemColors.ControlText;
            btnDeliverylogs.FlatStyle = FlatStyle.Popup;
            btnDeliverylogs.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeliverylogs.ForeColor = Color.White;
            btnDeliverylogs.Image = (Image)resources.GetObject("btnDeliverylogs.Image");
            btnDeliverylogs.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeliverylogs.Location = new Point(3, 394);
            btnDeliverylogs.Name = "btnDeliverylogs";
            btnDeliverylogs.Size = new Size(224, 70);
            btnDeliverylogs.TabIndex = 32;
            btnDeliverylogs.Text = "Delivery Logs";
            btnDeliverylogs.TextAlign = ContentAlignment.MiddleRight;
            btnDeliverylogs.UseVisualStyleBackColor = false;
            // 
            // btnOrderhistory
            // 
            btnOrderhistory.BackColor = SystemColors.ControlText;
            btnOrderhistory.FlatStyle = FlatStyle.Popup;
            btnOrderhistory.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrderhistory.ForeColor = Color.White;
            btnOrderhistory.Image = (Image)resources.GetObject("btnOrderhistory.Image");
            btnOrderhistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrderhistory.Location = new Point(0, 485);
            btnOrderhistory.Name = "btnOrderhistory";
            btnOrderhistory.Size = new Size(227, 70);
            btnOrderhistory.TabIndex = 31;
            btnOrderhistory.Text = "Order History";
            btnOrderhistory.TextAlign = ContentAlignment.MiddleRight;
            btnOrderhistory.UseVisualStyleBackColor = false;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = SystemColors.ControlText;
            btnAccount.FlatStyle = FlatStyle.Popup;
            btnAccount.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccount.ForeColor = Color.White;
            btnAccount.Image = (Image)resources.GetObject("btnAccount.Image");
            btnAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccount.Location = new Point(0, 318);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(224, 70);
            btnAccount.TabIndex = 30;
            btnAccount.Text = "   Account";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = SystemColors.ControlText;
            btnProduct.FlatStyle = FlatStyle.Popup;
            btnProduct.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduct.ForeColor = Color.White;
            btnProduct.Image = (Image)resources.GetObject("btnProduct.Image");
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(0, 242);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(227, 70);
            btnProduct.TabIndex = 29;
            btnProduct.Text = "Activity Logs";
            btnProduct.TextAlign = ContentAlignment.MiddleRight;
            btnProduct.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.ControlText;
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(3, 166);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(224, 70);
            btnHome.TabIndex = 28;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(227, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1143, 60);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(83, 17);
            label1.Name = "label1";
            label1.Size = new Size(294, 27);
            label1.TabIndex = 2;
            label1.Text = "WATCHUPONG FEEDS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(227, 60);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1143, 689);
            mainPanel.TabIndex = 2;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // UserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(mainPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserControl";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnHome;
        private Button btnProduct;
        private Button btnAccount;
        private Button btnOrderhistory;
        private Button btnDeliverylogs;
        private PictureBox pictureBox3;
        private Button btnInventory;
        private Panel mainPanel;
    }
}