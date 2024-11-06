namespace Administrator
{
    partial class Admin_OrderHistory
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
            dataGridView1 = new DataGridView();
            CustomerID_Admin = new DataGridViewTextBoxColumn();
            ProductID_Admin = new DataGridViewTextBoxColumn();
            Payment_Admin = new DataGridViewTextBoxColumn();
            DateTime_Admin = new DataGridViewTextBoxColumn();
            OrderStatus_Admin = new DataGridViewTextBoxColumn();
            TotalAmount_Admin = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CustomerID_Admin, ProductID_Admin, Payment_Admin, DateTime_Admin, OrderStatus_Admin, TotalAmount_Admin });
            dataGridView1.Location = new Point(38, 171);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1493, 845);
            dataGridView1.TabIndex = 0;
            // 
            // CustomerID_Admin
            // 
            CustomerID_Admin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerID_Admin.HeaderText = "Customer ID";
            CustomerID_Admin.MinimumWidth = 8;
            CustomerID_Admin.Name = "CustomerID_Admin";
            // 
            // ProductID_Admin
            // 
            ProductID_Admin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductID_Admin.HeaderText = "Product ID";
            ProductID_Admin.MinimumWidth = 8;
            ProductID_Admin.Name = "ProductID_Admin";
            // 
            // Payment_Admin
            // 
            Payment_Admin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Payment_Admin.HeaderText = "Payment";
            Payment_Admin.MinimumWidth = 8;
            Payment_Admin.Name = "Payment_Admin";
            // 
            // DateTime_Admin
            // 
            DateTime_Admin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DateTime_Admin.HeaderText = "Date and Time";
            DateTime_Admin.MinimumWidth = 8;
            DateTime_Admin.Name = "DateTime_Admin";
            // 
            // OrderStatus_Admin
            // 
            OrderStatus_Admin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderStatus_Admin.HeaderText = "Order Status";
            OrderStatus_Admin.MinimumWidth = 8;
            OrderStatus_Admin.Name = "OrderStatus_Admin";
            // 
            // TotalAmount_Admin
            // 
            TotalAmount_Admin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalAmount_Admin.HeaderText = "Total Amount";
            TotalAmount_Admin.MinimumWidth = 8;
            TotalAmount_Admin.Name = "TotalAmount_Admin";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1010, 88);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(430, 46);
            textBox1.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1450, 88);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(81, 48);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(314, 65);
            label1.TabIndex = 3;
            label1.Text = "Order History";
            // 
            // Admin_OrderHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1576, 1045);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Admin_OrderHistory";
            Text = "Admin_OrderHistory";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CustomerID_Admin;
        private DataGridViewTextBoxColumn ProductID_Admin;
        private DataGridViewTextBoxColumn Payment_Admin;
        private DataGridViewTextBoxColumn DateTime_Admin;
        private DataGridViewTextBoxColumn OrderStatus_Admin;
        private DataGridViewTextBoxColumn TotalAmount_Admin;
        private TextBox textBox1;
        private Button btnSearch;
        private Label label1;
    }
}