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
            label1.Location = new Point(34, 45);
            label1.Name = "label1";
            label1.Size = new Size(157, 50);
            label1.TabIndex = 0;
            label1.Text = "Account";
            // 
            // btnADDUSER
            // 
            btnADDUSER.BackColor = Color.Black;
            btnADDUSER.FlatStyle = FlatStyle.Popup;
            btnADDUSER.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnADDUSER.ForeColor = SystemColors.Control;
            btnADDUSER.Location = new Point(899, 45);
            btnADDUSER.Name = "btnADDUSER";
            btnADDUSER.Size = new Size(153, 40);
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
            dataGridView1.Location = new Point(34, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1018, 478);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NameAdmin
            // 
            NameAdmin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            NameAdmin.DefaultCellStyle = dataGridViewCellStyle1;
            NameAdmin.HeaderText = "Name";
            NameAdmin.Name = "NameAdmin";
            // 
            // UsernameAdmin
            // 
            UsernameAdmin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UsernameAdmin.HeaderText = "Username";
            UsernameAdmin.Name = "UsernameAdmin";
            // 
            // emailAdmin
            // 
            emailAdmin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            emailAdmin.HeaderText = "E-MAIL";
            emailAdmin.Name = "emailAdmin";
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone No.";
            Phone.Name = "Phone";
            // 
            // DateOfBirth
            // 
            DateOfBirth.HeaderText = "Date of Birth";
            DateOfBirth.Name = "DateOfBirth";
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.Name = "Gender";
            // 
            // RoleAdmin
            // 
            RoleAdmin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoleAdmin.HeaderText = "Role";
            RoleAdmin.Name = "RoleAdmin";
            // 
            // StatusAdmin
            // 
            StatusAdmin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StatusAdmin.HeaderText = "Status";
            StatusAdmin.Name = "StatusAdmin";
            // 
            // ActionAdmin
            // 
            ActionAdmin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ActionAdmin.HeaderText = "Actions";
            ActionAdmin.Name = "ActionAdmin";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(948, 124);
            button1.Name = "button1";
            button1.Size = new Size(32, 20);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(1002, 124);
            button2.Name = "button2";
            button2.Size = new Size(32, 20);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Admin_Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 588);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnADDUSER);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
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