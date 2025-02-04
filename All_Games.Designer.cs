namespace ProjectWin
{
    partial class SalesMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesMan));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            profileBtn = new Button();
            logoutBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(profileBtn);
            panel1.Controls.Add(logoutBtn);
            panel1.Location = new Point(-5, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(997, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // profileBtn
            // 
            profileBtn.Cursor = Cursors.Hand;
            profileBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileBtn.Location = new Point(1133, 22);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(109, 50);
            profileBtn.TabIndex = 1;
            profileBtn.Text = "Profile";
            profileBtn.UseVisualStyleBackColor = true;
            profileBtn.Click += profileBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.Cursor = Cursors.Hand;
            logoutBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutBtn.Location = new Point(1264, 22);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(108, 50);
            logoutBtn.TabIndex = 0;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // SalesMan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1404, 803);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SalesMan";
            Text = "GameDetails";
            Load += SalesMan_Load_1;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button logoutBtn;
        private Button profileBtn;
        private PictureBox pictureBox1;
    }
}