namespace AdminSide
{
    partial class Admin_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnLoginAdmin = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPasswordAdmin = new TextBox();
            txtUsernameAdmin = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(944, 132);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(199, 162);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(59, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(641, 461);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // btnLoginAdmin
            // 
            btnLoginAdmin.Font = new Font("Segoe UI", 12F);
            btnLoginAdmin.Location = new Point(982, 574);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new Size(128, 39);
            btnLoginAdmin.TabIndex = 13;
            btnLoginAdmin.Text = "Login";
            btnLoginAdmin.UseVisualStyleBackColor = true;
            btnLoginAdmin.Click += btnLoginAdmin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(786, 560);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 12;
            label3.Text = "Forgot Password?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(786, 484);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 11;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(786, 393);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 10;
            label1.Text = "Username:";
            // 
            // txtPasswordAdmin
            // 
            txtPasswordAdmin.Font = new Font("Segoe UI", 16F);
            txtPasswordAdmin.Location = new Point(786, 508);
            txtPasswordAdmin.Multiline = true;
            txtPasswordAdmin.Name = "txtPasswordAdmin";
            txtPasswordAdmin.Size = new Size(525, 40);
            txtPasswordAdmin.TabIndex = 9;
            // 
            // txtUsernameAdmin
            // 
            txtUsernameAdmin.Font = new Font("Segoe UI", 16F);
            txtUsernameAdmin.Location = new Point(786, 417);
            txtUsernameAdmin.Multiline = true;
            txtUsernameAdmin.Name = "txtUsernameAdmin";
            txtUsernameAdmin.Size = new Size(525, 40);
            txtUsernameAdmin.TabIndex = 8;
            // 
            // Admin_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1370, 749);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnLoginAdmin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPasswordAdmin);
            Controls.Add(txtUsernameAdmin);
            Name = "Admin_Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnLoginAdmin;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPasswordAdmin;
        private TextBox txtUsernameAdmin;
    }
}
