namespace ProjectWin
{
    partial class ProfilePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePage));
            image = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            updateBtn = new Button();
            label4 = new Label();
            browseBtn = new Button();
            name = new TextBox();
            email = new TextBox();
            phone = new TextBox();
            datePicker1 = new DateTimePicker();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            SuspendLayout();
            // 
            // image
            // 
            image.BackgroundImage = Properties.Resources.defaultProfile1;
            image.Location = new Point(121, 77);
            image.Margin = new Padding(3, 4, 3, 4);
            image.Name = "image";
            image.Size = new Size(198, 227);
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.TabIndex = 0;
            image.TabStop = false;
            image.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(349, 77);
            label1.Name = "label1";
            label1.Size = new Size(253, 68);
            label1.TabIndex = 7;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(349, 143);
            label2.Name = "label2";
            label2.Size = new Size(253, 68);
            label2.TabIndex = 8;
            label2.Text = "Email :";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(349, 211);
            label3.Name = "label3";
            label3.Size = new Size(115, 68);
            label3.TabIndex = 9;
            label3.Text = "Phone:";
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Black;
            updateBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.Transparent;
            updateBtn.Location = new Point(401, 384);
            updateBtn.Margin = new Padding(3, 4, 3, 4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(186, 58);
            updateBtn.TabIndex = 12;
            updateBtn.Text = "Edit Profile";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += Update_button_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(359, 265);
            label4.Name = "label4";
            label4.Size = new Size(88, 68);
            label4.TabIndex = 13;
            label4.Text = "DOB:";
            // 
            // browseBtn
            // 
            browseBtn.BackColor = Color.Black;
            browseBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            browseBtn.ForeColor = Color.Transparent;
            browseBtn.Location = new Point(151, 358);
            browseBtn.Margin = new Padding(3, 4, 3, 4);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(186, 57);
            browseBtn.TabIndex = 14;
            browseBtn.Text = "Browse";
            browseBtn.UseVisualStyleBackColor = false;
            browseBtn.Click += browse_button_Click;
            // 
            // name
            // 
            name.Location = new Point(454, 92);
            name.Margin = new Padding(3, 4, 3, 4);
            name.Name = "name";
            name.Size = new Size(252, 27);
            name.TabIndex = 15;
            // 
            // email
            // 
            email.Location = new Point(454, 157);
            email.Margin = new Padding(3, 4, 3, 4);
            email.Name = "email";
            email.Size = new Size(252, 27);
            email.TabIndex = 16;
            // 
            // phone
            // 
            phone.Location = new Point(454, 215);
            phone.Margin = new Padding(3, 4, 3, 4);
            phone.Name = "phone";
            phone.Size = new Size(252, 27);
            phone.TabIndex = 17;
            // 
            // datePicker1
            // 
            datePicker1.Location = new Point(453, 277);
            datePicker1.Name = "datePicker1";
            datePicker1.Size = new Size(305, 27);
            datePicker1.TabIndex = 51;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(12, 13);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(91, 31);
            button1.TabIndex = 52;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ProfilePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(datePicker1);
            Controls.Add(phone);
            Controls.Add(email);
            Controls.Add(name);
            Controls.Add(browseBtn);
            Controls.Add(label4);
            Controls.Add(updateBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(image);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProfilePage";
            Text = "ProfilePage";
            Load += ProfilePage_Load;
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox image;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button updateBtn;
        private Label label4;
        private Button browseBtn;
        private TextBox name;
        private TextBox email;
        private TextBox phone;
        private DateTimePicker datePicker1;
        private Button button1;
    }
}