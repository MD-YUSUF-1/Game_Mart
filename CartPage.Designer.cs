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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // logoutBtn
            // 
            logoutBtn.Cursor = Cursors.Hand;
            logoutBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutBtn.Location = new Point(1229, 33);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(108, 50);
            logoutBtn.TabIndex = 2;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            // 
            // profileBtn
            // 
            profileBtn.Cursor = Cursors.Hand;
            profileBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileBtn.Location = new Point(1093, 33);
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1383, 371);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(1094, 492);
            label2.Name = "label2";
            label2.Size = new Size(134, 31);
            label2.TabIndex = 7;
            label2.Text = "Total Price: ";
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
            // CartPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1382, 803);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "CartPage";
            Text = "CartPage";
            Load += CartPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logoutBtn;
        private Button profileBtn;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label6;
    }
}