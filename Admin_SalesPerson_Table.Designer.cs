namespace ProjectWin
{
    partial class Admin_SalesPerson_Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_SalesPerson_Table));
            pictureBox1 = new PictureBox();
            personGmail = new TextBox();
            personPhone = new TextBox();
            personName = new TextBox();
            updateBtn = new Button();
            button1 = new Button();
            label = new Label();
            personID = new TextBox();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 62;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // personGmail
            // 
            personGmail.BackColor = Color.Silver;
            personGmail.BorderStyle = BorderStyle.None;
            personGmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            personGmail.Location = new Point(1042, 427);
            personGmail.Margin = new Padding(3, 4, 3, 4);
            personGmail.Multiline = true;
            personGmail.Name = "personGmail";
            personGmail.Size = new Size(299, 40);
            personGmail.TabIndex = 61;
            // 
            // personPhone
            // 
            personPhone.BackColor = Color.Silver;
            personPhone.BorderStyle = BorderStyle.None;
            personPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            personPhone.Location = new Point(1042, 343);
            personPhone.Margin = new Padding(3, 4, 3, 4);
            personPhone.Multiline = true;
            personPhone.Name = "personPhone";
            personPhone.Size = new Size(299, 40);
            personPhone.TabIndex = 60;
            // 
            // personName
            // 
            personName.BackColor = Color.Silver;
            personName.BorderStyle = BorderStyle.None;
            personName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            personName.Location = new Point(1042, 258);
            personName.Margin = new Padding(3, 4, 3, 4);
            personName.Multiline = true;
            personName.Name = "personName";
            personName.Size = new Size(299, 40);
            personName.TabIndex = 59;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.DeepSkyBlue;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Location = new Point(344, 716);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(163, 52);
            updateBtn.TabIndex = 58;
            updateBtn.Text = "Edit";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(616, 716);
            button1.Name = "button1";
            button1.Size = new Size(163, 52);
            button1.TabIndex = 57;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 15.75F);
            label.ForeColor = Color.LightSkyBlue;
            label.Location = new Point(996, 178);
            label.Name = "label";
            label.Size = new Size(43, 37);
            label.TabIndex = 56;
            label.Text = "ID";
            // 
            // personID
            // 
            personID.BackColor = Color.Silver;
            personID.BorderStyle = BorderStyle.None;
            personID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            personID.Location = new Point(1042, 178);
            personID.Margin = new Padding(3, 4, 3, 4);
            personID.Multiline = true;
            personID.Name = "personID";
            personID.Size = new Size(299, 40);
            personID.TabIndex = 55;
            personID.TextChanged += personID_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(84, 716);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(151, 52);
            button2.TabIndex = 54;
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
            label5.Location = new Point(952, 343);
            label5.Name = "label5";
            label5.Size = new Size(92, 37);
            label5.TabIndex = 53;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F);
            label4.ForeColor = Color.LightSkyBlue;
            label4.Location = new Point(956, 427);
            label4.Name = "label4";
            label4.Size = new Size(87, 37);
            label4.TabIndex = 52;
            label4.Text = "Gmail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.ForeColor = Color.LightSkyBlue;
            label1.Location = new Point(956, 258);
            label1.Name = "label1";
            label1.Size = new Size(88, 37);
            label1.TabIndex = 51;
            label1.Text = "Name";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Gray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 112);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(872, 560);
            dataGridView1.TabIndex = 50;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Admin_SalesPerson_Table
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
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin_SalesPerson_Table";
            Text = "Admin_SalesPerson_Table";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox personGmail;
        private TextBox personPhone;
        private TextBox personName;
        private Button updateBtn;
        private Button button1;
        private Label label;
        private TextBox personID;
        private Button button2;
        private Label label5;
        private Label label4;
        private Label label1;
        private DataGridView dataGridView1;
    }
}