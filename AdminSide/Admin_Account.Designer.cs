namespace Administrator
{
    partial class Admin_Account
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            btnADDUSER = new Button();
            dataGridView1 = new DataGridView();
            NameAdmin = new DataGridViewTextBoxColumn();
            UsernameAdmin = new DataGridViewTextBoxColumn();
            emailAdmin = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            RoleAdmin = new DataGridViewTextBoxColumn();
            StatusAdmin = new DataGridViewTextBoxColumn();
            ActionAdmin = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(236, 74);
            label1.TabIndex = 0;
            label1.Text = "Account";
            label1.Click += label1_Click;
            // 
            // btnADDUSER
            // 
            btnADDUSER.BackColor = Color.Black;
            btnADDUSER.FlatStyle = FlatStyle.Popup;
            btnADDUSER.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnADDUSER.ForeColor = SystemColors.Control;
            btnADDUSER.Location = new Point(1284, 75);
            btnADDUSER.Margin = new Padding(4, 5, 4, 5);
            btnADDUSER.Name = "btnADDUSER";
            btnADDUSER.Size = new Size(219, 67);
            btnADDUSER.TabIndex = 2;
            btnADDUSER.Text = "Add User";
            btnADDUSER.UseVisualStyleBackColor = false;
            btnADDUSER.Click += btnADDUSER_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameAdmin, UsernameAdmin, emailAdmin, Phone, DateOfBirth, Gender, RoleAdmin, StatusAdmin, ActionAdmin });
            dataGridView1.Location = new Point(49, 163);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1454, 797);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NameAdmin
            // 
            NameAdmin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            NameAdmin.DefaultCellStyle = dataGridViewCellStyle1;
            NameAdmin.HeaderText = "Name";
            NameAdmin.MinimumWidth = 8;
            NameAdmin.Name = "NameAdmin";
            // 
            // UsernameAdmin
            // 
            UsernameAdmin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UsernameAdmin.HeaderText = "Username";
            UsernameAdmin.MinimumWidth = 8;
            UsernameAdmin.Name = "UsernameAdmin";
            // 
            // emailAdmin
            // 
            emailAdmin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            emailAdmin.HeaderText = "E-MAIL";
            emailAdmin.MinimumWidth = 8;
            emailAdmin.Name = "emailAdmin";
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone No.";
            Phone.MinimumWidth = 8;
            Phone.Name = "Phone";
            Phone.Width = 150;
            // 
            // DateOfBirth
            // 
            DateOfBirth.HeaderText = "Date of Birth";
            DateOfBirth.MinimumWidth = 8;
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Width = 150;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 8;
            Gender.Name = "Gender";
            Gender.Width = 150;
            // 
            // RoleAdmin
            // 
            RoleAdmin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoleAdmin.HeaderText = "Role";
            RoleAdmin.MinimumWidth = 8;
            RoleAdmin.Name = "RoleAdmin";
            // 
            // StatusAdmin
            // 
            StatusAdmin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StatusAdmin.HeaderText = "Status";
            StatusAdmin.MinimumWidth = 8;
            StatusAdmin.Name = "StatusAdmin";
            // 
            // ActionAdmin
            // 
            ActionAdmin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ActionAdmin.HeaderText = "Actions";
            ActionAdmin.MinimumWidth = 8;
            ActionAdmin.Name = "ActionAdmin";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(1354, 207);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(46, 33);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(1431, 207);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(46, 33);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Admin_Account
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1599, 1106);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnADDUSER);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Admin_Account";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Admin_Account";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnADDUSER;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn NameAdmin;
        private DataGridViewTextBoxColumn UsernameAdmin;
        private DataGridViewTextBoxColumn emailAdmin;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn RoleAdmin;
        private DataGridViewTextBoxColumn StatusAdmin;
        private DataGridViewTextBoxColumn ActionAdmin;
    }
}