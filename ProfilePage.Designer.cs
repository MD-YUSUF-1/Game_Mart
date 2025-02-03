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
            dob = new TextBox();
            phone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            SuspendLayout();
            // 
            // image
            // 

            image.BackgroundImage = Properties.Resources.defaultProfile1;
            image.Location = new Point(106, 81);
            image.Name = "image";
            image.Size = new Size(149, 147);
            image.TabIndex = 0;
            image.TabStop = false;
            image.Click += pictureBox1_Click;

            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;

            label1.Location = new Point(305, 58);

            label1.Name = "label1";
            label1.Size = new Size(221, 51);
            label1.TabIndex = 7;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;

            label2.Location = new Point(305, 107);

            label2.Name = "label2";
            label2.Size = new Size(221, 51);
            label2.TabIndex = 8;
            label2.Text = "Email :";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;

            label3.Location = new Point(305, 158);
            label3.Name = "label3";
            label3.Size = new Size(101, 51);

            label3.TabIndex = 9;
            label3.Text = "Phone:";
            // 
            // updateBtn
            // 

            updateBtn.BackColor = Color.Black;
            updateBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.Transparent;
            updateBtn.Location = new Point(397, 307);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(163, 54);
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
            label4.Location = new Point(314, 199);
            label4.Name = "label4";
            label4.Size = new Size(77, 51);
            label4.TabIndex = 13;
            label4.Text = "DOB:";
            // 
            // browseBtn
            // 
            browseBtn.BackColor = Color.Black;
            browseBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            browseBtn.ForeColor = Color.Transparent;
            browseBtn.Location = new Point(106, 307);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(163, 54);
            browseBtn.TabIndex = 14;
            browseBtn.Text = "Browse";
            browseBtn.UseVisualStyleBackColor = false;
            browseBtn.Click += browse_button_Click;
            // 
            // name
            // 
            name.Location = new Point(397, 69);
            name.Name = "name";
            name.Size = new Size(221, 23);
            name.TabIndex = 15;
            // 
            // email
            // 
            email.Location = new Point(397, 118);
            email.Name = "email";
            email.Size = new Size(221, 23);
            email.TabIndex = 16;
            // 
            // dob
            // 
            dob.Location = new Point(397, 205);
            dob.Name = "dob";
            dob.Size = new Size(221, 23);
            dob.TabIndex = 18;
            // 
            // phone
            // 
            phone.Location = new Point(397, 161);
            phone.Name = "phone";
            phone.Size = new Size(221, 23);
            phone.TabIndex = 17;

            // 
            // ProfilePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(dob);
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
        private TextBox dob;
        private TextBox phone;
    }
}