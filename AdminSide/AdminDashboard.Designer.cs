namespace Administrator
{
    partial class AdminDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridView3 = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            OrderStatus_Admin = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            DateTime_Admin = new DataGridViewTextBoxColumn();
            Payment_Admin = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            ProductID_Admin = new DataGridViewTextBoxColumn();
            CustomerID_Admin = new DataGridViewTextBoxColumn();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1174, 569);
            label5.Name = "label5";
            label5.Size = new Size(165, 32);
            label5.TabIndex = 17;
            label5.Text = "Top Products";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1174, 185);
            label3.Name = "label3";
            label3.Size = new Size(128, 32);
            label3.TabIndex = 15;
            label3.Text = "Low Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 165);
            label2.Name = "label2";
            label2.Size = new Size(174, 32);
            label2.TabIndex = 14;
            label2.Text = "Total Revenue";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Product Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Product ID ";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridView3.Location = new Point(1174, 232);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(381, 305);
            dataGridView3.TabIndex = 13;
            // 
            // Column4
            // 
            Column4.HeaderText = "Product Name";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Product ID ";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4 });
            dataGridView2.Location = new Point(1174, 609);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(381, 393);
            dataGridView2.TabIndex = 12;
            // 
            // OrderStatus_Admin
            // 
            OrderStatus_Admin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderStatus_Admin.HeaderText = "Status";
            OrderStatus_Admin.MinimumWidth = 8;
            OrderStatus_Admin.Name = "OrderStatus_Admin";
            // 
            // Column2
            // 
            Column2.HeaderText = "Customer ID";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // DateTime_Admin
            // 
            DateTime_Admin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DateTime_Admin.HeaderText = "Date and Time";
            DateTime_Admin.MinimumWidth = 8;
            DateTime_Admin.Name = "DateTime_Admin";
            // 
            // Payment_Admin
            // 
            Payment_Admin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Payment_Admin.HeaderText = "Price";
            Payment_Admin.MinimumWidth = 8;
            Payment_Admin.Name = "Payment_Admin";
            // 
            // Column1
            // 
            Column1.HeaderText = "Qty.";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // ProductID_Admin
            // 
            ProductID_Admin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductID_Admin.HeaderText = "Product ID";
            ProductID_Admin.MinimumWidth = 8;
            ProductID_Admin.Name = "ProductID_Admin";
            // 
            // CustomerID_Admin
            // 
            CustomerID_Admin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerID_Admin.HeaderText = "Product Name";
            CustomerID_Admin.MinimumWidth = 8;
            CustomerID_Admin.Name = "CustomerID_Admin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(56, 569);
            label4.Name = "label4";
            label4.Size = new Size(171, 32);
            label4.TabIndex = 16;
            label4.Text = "Order History";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CustomerID_Admin, ProductID_Admin, Column1, Payment_Admin, DateTime_Admin, Column2, OrderStatus_Admin });
            dataGridView1.Location = new Point(44, 609);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1103, 393);
            dataGridView1.TabIndex = 11;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(56, 209);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(450, 325);
            chart1.TabIndex = 10;
            chart1.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 104);
            label1.Name = "label1";
            label1.Size = new Size(122, 48);
            label1.TabIndex = 9;
            label1.Text = "Home";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(chart1);
            Controls.Add(label1);
            Name = "AdminDashboard";
            Size = new Size(1599, 1106);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn OrderStatus_Admin;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn DateTime_Admin;
        private DataGridViewTextBoxColumn Payment_Admin;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ProductID_Admin;
        private DataGridViewTextBoxColumn CustomerID_Admin;
        private Label label4;
        private DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label1;
    }
}
