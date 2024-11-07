namespace Cashier
{
    partial class GCash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCash));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAccountName = new TextBox();
            txtAccountNo = new TextBox();
            txtAmount = new TextBox();
            btnPay = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 37);
            label1.TabIndex = 1;
            label1.Text = "G-Cash";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 130);
            label2.Name = "label2";
            label2.Size = new Size(213, 37);
            label2.TabIndex = 2;
            label2.Text = "Account Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 274);
            label3.Name = "label3";
            label3.Size = new Size(124, 37);
            label3.TabIndex = 3;
            label3.Text = "Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 203);
            label4.Name = "label4";
            label4.Size = new Size(177, 37);
            label4.TabIndex = 4;
            label4.Text = "Account No: ";
            // 
            // txtAccountName
            // 
            txtAccountName.Font = new Font("Segoe UI", 14F);
            txtAccountName.Location = new Point(232, 135);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(310, 32);
            txtAccountName.TabIndex = 5;
            // 
            // txtAccountNo
            // 
            txtAccountNo.Font = new Font("Segoe UI", 14F);
            txtAccountNo.Location = new Point(232, 208);
            txtAccountNo.Name = "txtAccountNo";
            txtAccountNo.Size = new Size(310, 32);
            txtAccountNo.TabIndex = 6;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 14F);
            txtAmount.Location = new Point(232, 279);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(310, 32);
            txtAmount.TabIndex = 7;
            // 
            // btnPay
            // 
            btnPay.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.Location = new Point(432, 389);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(110, 41);
            btnPay.TabIndex = 8;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // GCash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 500);
            Controls.Add(btnPay);
            Controls.Add(txtAmount);
            Controls.Add(txtAccountNo);
            Controls.Add(txtAccountName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GCash";
            Text = "GCash";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAccountName;
        private TextBox txtAccountNo;
        private TextBox txtAmount;
        private Button btnPay;
    }
}