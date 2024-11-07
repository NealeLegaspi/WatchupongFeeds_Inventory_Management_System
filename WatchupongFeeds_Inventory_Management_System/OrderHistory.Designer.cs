namespace Cashier
{
    partial class OrderHistory
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(24, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(1326, 653);
            panel1.TabIndex = 40;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 205F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 148F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Location = new Point(31, 62);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40.59406F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 59.40594F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(1272, 571);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 0;
            label5.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 14);
            label3.Name = "label3";
            label3.Size = new Size(164, 45);
            label3.TabIndex = 0;
            label3.Text = "All Orders";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 12);
            label4.Name = "label4";
            label4.Size = new Size(136, 47);
            label4.TabIndex = 41;
            label4.Text = "History";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1043, 35);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 29);
            textBox1.TabIndex = 42;
            // 
            // OrderHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 610);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "OrderHistory";
            Text = "OrderHistory";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox1;
        private Label label5;
    }
}