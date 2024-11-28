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
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            button6 = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            btnHomeAdmin = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            MainPanelCashier = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnHomeAdmin);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 1050);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(106, 302);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 37);
            label2.TabIndex = 26;
            label2.Text = "Cashier";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Black;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(106, 162);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(133, 135);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(274, 37);
            label1.TabIndex = 11;
            label1.Text = "WATCHUPONG ";
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 1143);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(359, 100);
            button6.TabIndex = 10;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.TopLeft;
            button2.Location = new Point(0, 868);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(359, 100);
            button2.TabIndex = 9;
            button2.Text = "History";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(4, 708);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(354, 100);
            button1.TabIndex = 8;
            button1.Text = "Account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            button3.Location = new Point(0, 558);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(359, 100);
            button3.TabIndex = 7;
            button3.Text = " Product";
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
            btnHomeAdmin.Location = new Point(4, 407);
            btnHomeAdmin.Margin = new Padding(4, 5, 4, 5);
            btnHomeAdmin.Name = "btnHomeAdmin";
            btnHomeAdmin.Size = new Size(354, 92);
            btnHomeAdmin.TabIndex = 4;
            btnHomeAdmin.Text = "Home";
            btnHomeAdmin.UseVisualStyleBackColor = false;
            btnHomeAdmin.Click += btnHomeAdmin_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 0);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(359, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1565, 167);
            panel2.TabIndex = 2;
            // 
            // MainPanelCashier
            // 
            MainPanelCashier.Dock = DockStyle.Fill;
            MainPanelCashier.Location = new Point(359, 167);
            MainPanelCashier.Margin = new Padding(4, 5, 4, 5);
            MainPanelCashier.Name = "MainPanelCashier";
            MainPanelCashier.Size = new Size(1565, 883);
            MainPanelCashier.TabIndex = 3;
            // 
            // UC_Cashier_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(MainPanelCashier);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_Cashier_Dashboard";
            Text = "UC_Cashier_Dashboard";
            Load += UC_Cashier_Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel MainPanelCashier;
        private Button btnHomeAdmin;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label2;
    }
}