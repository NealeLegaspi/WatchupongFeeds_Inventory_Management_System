namespace Administrator
{
    partial class Admin_AddQuan
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(23, 62);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 34);
            textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(201, 62);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 34);
            textBox1.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(205, 30);
            label3.Name = "label3";
            label3.Size = new Size(96, 17);
            label3.TabIndex = 23;
            label3.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 30);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 22;
            label2.Text = "Product ID";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(23, 155);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(159, 34);
            textBox3.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 123);
            label1.Name = "label1";
            label1.Size = new Size(91, 17);
            label1.TabIndex = 26;
            label1.Text = "Current Stock";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(23, 250);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(159, 34);
            textBox4.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 218);
            label4.Name = "label4";
            label4.Size = new Size(70, 17);
            label4.TabIndex = 28;
            label4.Text = "Add Stock";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Location = new Point(409, 298);
            button2.Name = "button2";
            button2.Size = new Size(78, 26);
            button2.TabIndex = 32;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Location = new Point(319, 298);
            button1.Name = "button1";
            button1.Size = new Size(88, 26);
            button1.TabIndex = 31;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            // 
            // Admin_AddQuan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 337);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Admin_AddQuan";
            Text = "Admin_AddQuan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox4;
        private Label label4;
        private Button button2;
        private Button button1;
    }
}