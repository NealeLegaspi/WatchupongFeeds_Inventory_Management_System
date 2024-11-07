namespace Cashier
{
    partial class Gcash_Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gcash_Receipt));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnReceipt = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 263);
            label2.Name = "label2";
            label2.Size = new Size(184, 37);
            label2.TabIndex = 3;
            label2.Text = "Account No.: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 192);
            label1.Name = "label1";
            label1.Size = new Size(213, 37);
            label1.TabIndex = 4;
            label1.Text = "Account Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 126);
            label3.Name = "label3";
            label3.Size = new Size(195, 37);
            label3.TabIndex = 5;
            label3.Text = "Reference No.:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 332);
            label4.Name = "label4";
            label4.Size = new Size(124, 37);
            label4.TabIndex = 6;
            label4.Text = "Amount:";
            // 
            // btnReceipt
            // 
            btnReceipt.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReceipt.Location = new Point(227, 443);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(130, 45);
            btnReceipt.TabIndex = 7;
            btnReceipt.Text = "Receipt";
            btnReceipt.UseVisualStyleBackColor = true;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 88);
            label5.Name = "label5";
            label5.Size = new Size(507, 15);
            label5.TabIndex = 8;
            label5.Text = "____________________________________________________________________________________________________";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 401);
            label6.Name = "label6";
            label6.Size = new Size(507, 15);
            label6.TabIndex = 9;
            label6.Text = "____________________________________________________________________________________________________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(241, 9);
            label7.Name = "label7";
            label7.Size = new Size(107, 37);
            label7.TabIndex = 10;
            label7.Text = "G-Cash";
            // 
            // Gcash_Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 500);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnReceipt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Gcash_Receipt";
            Text = "Gcash_Receipt";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button btnReceipt;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}