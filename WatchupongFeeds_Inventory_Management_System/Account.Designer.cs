namespace Cashier
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            btnAccount = new Button();
            btnProduct = new Button();
            btnHome = new Button();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAccount
            // 
            btnAccount.BackColor = SystemColors.ControlText;
            btnAccount.FlatStyle = FlatStyle.Popup;
            btnAccount.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccount.ForeColor = Color.White;
            btnAccount.Image = (Image)resources.GetObject("btnAccount.Image");
            btnAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccount.Location = new Point(12, 490);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(256, 70);
            btnAccount.TabIndex = 28;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = false;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = SystemColors.ControlText;
            btnProduct.FlatStyle = FlatStyle.Popup;
            btnProduct.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduct.ForeColor = Color.White;
            btnProduct.Image = (Image)resources.GetObject("btnProduct.Image");
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(12, 386);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(256, 70);
            btnProduct.TabIndex = 27;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.ControlText;
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(12, 284);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(256, 70);
            btnHome.TabIndex = 26;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(95, 218);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 25;
            label2.Text = "Cashier";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Black;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(95, 118);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(93, 81);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Location = new Point(12, 89);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 633);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 20);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 30;
            label1.Text = "WATCHUPONG ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1370, 65);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(383, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 469);
            panel1.TabIndex = 31;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(360, 389);
            button4.Name = "button4";
            button4.Size = new Size(128, 40);
            button4.TabIndex = 3;
            button4.Text = "Log Out";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 16F);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(517, 84);
            button2.Name = "button2";
            button2.Size = new Size(188, 243);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(145, 84);
            button1.Name = "button1";
            button1.Size = new Size(188, 243);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(292, 79);
            label3.Name = "label3";
            label3.Size = new Size(127, 33);
            label3.TabIndex = 32;
            label3.Text = "Account";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlText;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(12, 578);
            button5.Name = "button5";
            button5.Size = new Size(256, 70);
            button5.TabIndex = 40;
            button5.Text = "History";
            button5.UseVisualStyleBackColor = false;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnAccount);
            Controls.Add(btnProduct);
            Controls.Add(btnHome);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            Text = "Account";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAccount;
        private Button btnProduct;
        private Button btnHome;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button4;
        private Button button2;
        private Button button1;
        private Label label3;
        private Button button5;
    }
}