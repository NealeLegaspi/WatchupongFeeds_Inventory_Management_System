namespace Cashier
{
    partial class Cashier_Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            CustomerID_Admin = new DataGridViewTextBoxColumn();
            ProductID_Admin = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Payment_Admin = new DataGridViewTextBoxColumn();
            DateTime_Admin = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            OrderStatus_Admin = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(21, 120);
            chart1.Margin = new Padding(2);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(315, 195);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridView3.Location = new Point(809, 132);
            dataGridView3.Margin = new Padding(2);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(267, 183);
            dataGridView3.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Product ID ";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Product Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CustomerID_Admin, ProductID_Admin, Column1, Payment_Admin, DateTime_Admin, Column2, OrderStatus_Admin });
            dataGridView1.Location = new Point(21, 367);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(772, 236);
            dataGridView1.TabIndex = 6;
            // 
            // CustomerID_Admin
            // 
            CustomerID_Admin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerID_Admin.HeaderText = "Product Name";
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
            // Column1
            // 
            Column1.HeaderText = "Qty.";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Payment_Admin
            // 
            Payment_Admin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Payment_Admin.HeaderText = "Price";
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
            // Column2
            // 
            Column2.HeaderText = "Customer ID";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // OrderStatus_Admin
            // 
            OrderStatus_Admin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderStatus_Admin.HeaderText = "Status";
            OrderStatus_Admin.MinimumWidth = 8;
            OrderStatus_Admin.Name = "OrderStatus_Admin";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4 });
            dataGridView2.Location = new Point(809, 367);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(267, 236);
            dataGridView2.TabIndex = 7;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Product ID ";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Product Name";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Cashier_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 649);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(dataGridView3);
            Controls.Add(chart1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cashier_Dashboard";
            Text = "Cashier_Dashboard";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CustomerID_Admin;
        private DataGridViewTextBoxColumn ProductID_Admin;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Payment_Admin;
        private DataGridViewTextBoxColumn DateTime_Admin;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn OrderStatus_Admin;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}