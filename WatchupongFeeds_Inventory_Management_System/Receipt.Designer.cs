namespace Cashier
{
    partial class Receipt
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
            label3 = new Label();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(30, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 633);
            panel1.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 221);
            label3.Name = "label3";
            label3.Size = new Size(159, 32);
            label3.TabIndex = 4;
            label3.Text = "Order Details:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 29);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 3;
            label1.Text = "Hi, Thankyou!";
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(806, 578);
            button3.Name = "button3";
            button3.Size = new Size(115, 42);
            button3.TabIndex = 2;
            button3.Text = "HOME";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(659, 578);
            button2.Name = "button2";
            button2.Size = new Size(115, 42);
            button2.TabIndex = 1;
            button2.Text = "PRINT";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(67, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 118);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(69, 268);
            panel3.Name = "panel3";
            panel3.Size = new Size(852, 295);
            panel3.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 41);
            label9.Name = "label9";
            label9.Size = new Size(802, 15);
            label9.TabIndex = 10;
            label9.Text = "_______________________________________________________________________________________________________________________________________________________________";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 213);
            label8.Name = "label8";
            label8.Size = new Size(802, 15);
            label8.TabIndex = 9;
            label8.Text = "_______________________________________________________________________________________________________________________________________________________________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(737, 20);
            label7.Name = "label7";
            label7.Size = new Size(47, 21);
            label7.TabIndex = 8;
            label7.Text = "Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(28, 20);
            label6.Name = "label6";
            label6.Size = new Size(67, 21);
            label6.TabIndex = 7;
            label6.Text = "Product:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 238);
            label5.Name = "label5";
            label5.Size = new Size(131, 21);
            label5.TabIndex = 6;
            label5.Text = "Payment Method:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 186);
            label4.Name = "label4";
            label4.Size = new Size(105, 21);
            label4.TabIndex = 5;
            label4.Text = "Total Amount:";
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel1);
            Name = "Receipt";
            Text = "Receipt";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Panel panel2;
        private Label label3;
        private Label label1;
        private Panel panel3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}