namespace ProjectWin
{
    partial class CartPage
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
            logoutBtn = new Button();
            profileBtn = new Button();
            panel1 = new Panel();
            label6 = new Label();
            cusName = new Label();
            cusPhone = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // logoutBtn
            // 
            logoutBtn.Cursor = Cursors.Hand;
            logoutBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutBtn.Location = new Point(1149, 33);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(108, 50);
            logoutBtn.TabIndex = 2;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // profileBtn
            // 
            profileBtn.Cursor = Cursors.Hand;
            profileBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileBtn.Location = new Point(1015, 33);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(109, 50);
            profileBtn.TabIndex = 3;
            profileBtn.Text = "Profile";
            profileBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(profileBtn);
            panel1.Controls.Add(logoutBtn);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1386, 119);
            panel1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(57, 33);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 15;
            label6.Text = "<-Back";
            label6.Click += label6_Click;
            // 
            // cusName
            // 
            cusName.AutoSize = true;
            cusName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cusName.ForeColor = Color.White;
            cusName.Location = new Point(47, 144);
            cusName.Name = "cusName";
            cusName.Size = new Size(162, 28);
            cusName.TabIndex = 16;
            cusName.Text = "Customer Name: ";
            // 
            // cusPhone
            // 
            cusPhone.AutoSize = true;
            cusPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cusPhone.ForeColor = Color.White;
            cusPhone.Location = new Point(564, 147);
            cusPhone.Name = "cusPhone";
            cusPhone.Size = new Size(237, 28);
            cusPhone.TabIndex = 17;
            cusPhone.Text = "Customer Phone Number:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(215, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 34);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(818, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(333, 34);
            textBox2.TabIndex = 19;
            // 
            // CartPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1273, 803);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(cusPhone);
            Controls.Add(cusName);
            Controls.Add(panel1);
            Name = "CartPage";
            Text = "CartPage";
            Load += CartPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logoutBtn;
        private Button profileBtn;
        private Panel panel1;
        private Label label6;
        private Label cusName;
        private Label cusPhone;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}