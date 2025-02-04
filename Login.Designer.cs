namespace ProjectWin
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            LoginTextBox1 = new TextBox();
            loginPassBox2 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            button1 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(270, 266);
            label1.Name = "label1";
            label1.Size = new Size(139, 31);
            label1.TabIndex = 0;
            label1.Text = "USERNAME";
            // 
            // LoginTextBox1
            // 
            LoginTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginTextBox1.Location = new Point(435, 266);
            LoginTextBox1.Margin = new Padding(3, 4, 3, 4);
            LoginTextBox1.Multiline = true;
            LoginTextBox1.Name = "LoginTextBox1";
            LoginTextBox1.Size = new Size(282, 38);
            LoginTextBox1.TabIndex = 1;
            LoginTextBox1.TextChanged += LoginTextBox1_TextChanged;
            // 
            // loginPassBox2
            // 
            loginPassBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginPassBox2.Location = new Point(435, 354);
            loginPassBox2.Margin = new Padding(3, 4, 3, 4);
            loginPassBox2.Multiline = true;
            loginPassBox2.Name = "loginPassBox2";
            loginPassBox2.PasswordChar = '*';
            loginPassBox2.Size = new Size(282, 38);
            loginPassBox2.TabIndex = 2;
            loginPassBox2.TextChanged += loginPassBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(270, 361);
            label2.Name = "label2";
            label2.Size = new Size(141, 31);
            label2.TabIndex = 3;
            label2.Text = "PASSWORD";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(484, 420);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(175, 49);
            button2.TabIndex = 5;
            button2.Text = "LOGIN";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(270, 171);
            label3.Name = "label3";
            label3.Size = new Size(487, 50);
            label3.TabIndex = 6;
            label3.Text = "Welcome To Our Game Store";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(885, 592);
            button1.Name = "button1";
            button1.Size = new Size(145, 49);
            button1.TabIndex = 8;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 13);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(84, 38);
            button3.TabIndex = 9;
            button3.Text = "BACK";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(679, 354);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1062, 653);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(loginPassBox2);
            Controls.Add(LoginTextBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox LoginTextBox1;
        private TextBox loginPassBox2;
        private Label label2;
        private Button button2;
        private Label label3;
        private Button button1;
        private Button button3;
        private PictureBox pictureBox1;
    }
}
