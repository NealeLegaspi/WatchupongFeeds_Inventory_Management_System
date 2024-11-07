namespace Administrator
{
    partial class Admin_Removeproduct
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
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 35);
            label2.Name = "label2";
            label2.Size = new Size(322, 17);
            label2.TabIndex = 23;
            label2.Text = "Are you sure, do you want to remove this product?\r\n";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Location = new Point(309, 98);
            button2.Name = "button2";
            button2.Size = new Size(78, 26);
            button2.TabIndex = 34;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Location = new Point(219, 98);
            button1.Name = "button1";
            button1.Size = new Size(88, 26);
            button1.TabIndex = 33;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            // 
            // Admin_Removeproduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 137);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "Admin_Removeproduct";
            Text = "Admin_Removeproduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button2;
        private Button button1;
    }
}