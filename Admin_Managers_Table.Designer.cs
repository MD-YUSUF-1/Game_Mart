namespace ProjectWin
{
    partial class Admin_Managers_Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Managers_Table));
            updateBtn = new Button();
            button1 = new Button();
            label = new Label();
            personID = new TextBox();
            label6 = new Label();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            personName = new TextBox();
            personPhone = new TextBox();
            personGmail = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.DeepSkyBlue;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Location = new Point(338, 708);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(163, 52);
            updateBtn.TabIndex = 45;
            updateBtn.Text = "Edit";
            updateBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(628, 708);
            button1.Name = "button1";
            button1.Size = new Size(163, 52);
            button1.TabIndex = 44;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 15.75F);
            label.ForeColor = Color.LightSkyBlue;
            label.Location = new Point(1008, 170);
            label.Name = "label";
            label.Size = new Size(43, 37);
            label.TabIndex = 43;
            label.Text = "ID";
            // 
            // personID
            // 
            personID.BackColor = Color.Silver;
            personID.BorderStyle = BorderStyle.None;
            personID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            personID.Location = new Point(1054, 170);
            personID.Margin = new Padding(3, 4, 3, 4);
            personID.Multiline = true;
            personID.Name = "personID";
            personID.Size = new Size(299, 40);
            personID.TabIndex = 42;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSkyBlue;
            label6.Location = new Point(56, -69);
            label6.Name = "label6";
            label6.Size = new Size(133, 56);
            label6.TabIndex = 41;
            label6.Text = "<-Back";
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(96, 708);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(151, 52);
            button2.TabIndex = 40;
            button2.Text = "Insert";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15.75F);
            label5.ForeColor = Color.LightSkyBlue;
            label5.Location = new Point(964, 335);
            label5.Name = "label5";
            label5.Size = new Size(92, 37);
            label5.TabIndex = 35;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F);
            label4.ForeColor = Color.LightSkyBlue;
            label4.Location = new Point(968, 419);
            label4.Name = "label4";
            label4.Size = new Size(87, 37);
            label4.TabIndex = 34;
            label4.Text = "Gmail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.ForeColor = Color.LightSkyBlue;
            label1.Location = new Point(968, 250);
            label1.Name = "label1";
            label1.Size = new Size(88, 37);
            label1.TabIndex = 31;
            label1.Text = "Name";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Gray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 104);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(872, 560);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // personName
            // 
            personName.BackColor = Color.Silver;
            personName.BorderStyle = BorderStyle.None;
            personName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            personName.Location = new Point(1054, 250);
            personName.Margin = new Padding(3, 4, 3, 4);
            personName.Multiline = true;
            personName.Name = "personName";
            personName.Size = new Size(299, 40);
            personName.TabIndex = 46;
            // 
            // personPhone
            // 
            personPhone.BackColor = Color.Silver;
            personPhone.BorderStyle = BorderStyle.None;
            personPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            personPhone.Location = new Point(1054, 335);
            personPhone.Margin = new Padding(3, 4, 3, 4);
            personPhone.Multiline = true;
            personPhone.Name = "personPhone";
            personPhone.Size = new Size(299, 40);
            personPhone.TabIndex = 47;
            // 
            // personGmail
            // 
            personGmail.BackColor = Color.Silver;
            personGmail.BorderStyle = BorderStyle.None;
            personGmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            personGmail.Location = new Point(1054, 419);
            personGmail.Margin = new Padding(3, 4, 3, 4);
            personGmail.Multiline = true;
            personGmail.Name = "personGmail";
            personGmail.Size = new Size(299, 40);
            personGmail.TabIndex = 48;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Admin_Managers_Table
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1382, 803);
            Controls.Add(pictureBox1);
            Controls.Add(personGmail);
            Controls.Add(personPhone);
            Controls.Add(personName);
            Controls.Add(updateBtn);
            Controls.Add(button1);
            Controls.Add(label);
            Controls.Add(personID);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin_Managers_Table";
            Text = "Admin_Managers_Table";
            Load += Admin_Managers_Table_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateBtn;
        private Button button1;
        private Label label;
        private TextBox personID;
        private Label label6;
        private Button button2;
        private Label label5;
        private Label label4;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox personName;
        private TextBox personPhone;
        private TextBox personGmail;
        private PictureBox pictureBox1;
    }
}