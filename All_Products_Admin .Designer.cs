namespace ProjectWin
{
    partial class All_Products_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(All_Products_Admin));
            dataGridView1 = new DataGridView();
            gameName = new TextBox();
            gameImage = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            gameDiscount = new TextBox();
            gamePrice = new TextBox();
            gameStock = new TextBox();
            gameGenre = new TextBox();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            label6 = new Label();
            gameID = new TextBox();
            label = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gameImage).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Gray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(763, 540);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // gameName
            // 
            gameName.BackColor = Color.Gray;
            gameName.BorderStyle = BorderStyle.None;
            gameName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameName.Location = new Point(840, 120);
            gameName.Name = "gameName";
            gameName.Size = new Size(300, 22);
            gameName.TabIndex = 1;
            // 
            // gameImage
            // 
            gameImage.Image = (Image)resources.GetObject("gameImage.Image");
            gameImage.Location = new Point(892, 397);
            gameImage.Name = "gameImage";
            gameImage.Size = new Size(213, 189);
            gameImage.SizeMode = PictureBoxSizeMode.StretchImage;
            gameImage.TabIndex = 7;
            gameImage.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSkyBlue;
            label1.Location = new Point(840, 96);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSkyBlue;
            label2.Location = new Point(840, 334);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 9;
            label2.Text = "Discount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSkyBlue;
            label3.Location = new Point(840, 274);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 10;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSkyBlue;
            label4.Location = new Point(837, 215);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 11;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSkyBlue;
            label5.Location = new Point(840, 157);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 12;
            label5.Text = "Genre";
            // 
            // gameDiscount
            // 
            gameDiscount.BackColor = Color.Gray;
            gameDiscount.BorderStyle = BorderStyle.None;
            gameDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameDiscount.Location = new Point(840, 358);
            gameDiscount.Name = "gameDiscount";
            gameDiscount.Size = new Size(300, 22);
            gameDiscount.TabIndex = 13;
            // 
            // gamePrice
            // 
            gamePrice.BackColor = Color.Gray;
            gamePrice.BorderStyle = BorderStyle.None;
            gamePrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gamePrice.Location = new Point(840, 298);
            gamePrice.Name = "gamePrice";
            gamePrice.Size = new Size(300, 22);
            gamePrice.TabIndex = 14;
            // 
            // gameStock
            // 
            gameStock.BackColor = Color.Gray;
            gameStock.BorderStyle = BorderStyle.None;
            gameStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameStock.Location = new Point(840, 239);
            gameStock.Name = "gameStock";
            gameStock.Size = new Size(300, 22);
            gameStock.TabIndex = 15;
            // 
            // gameGenre
            // 
            gameGenre.BackColor = Color.Gray;
            gameGenre.BorderStyle = BorderStyle.None;
            gameGenre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameGenre.Location = new Point(840, 181);
            gameGenre.Name = "gameGenre";
            gameGenre.Size = new Size(300, 22);
            gameGenre.TabIndex = 16;
            // 
            // button4
            // 
            button4.BackColor = Color.DeepSkyBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(552, 600);
            button4.Name = "button4";
            button4.Size = new Size(132, 39);
            button4.TabIndex = 20;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(113, 600);
            button2.Name = "button2";
            button2.Size = new Size(132, 39);
            button2.TabIndex = 21;
            button2.Text = "Insert";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(340, 600);
            button3.Name = "button3";
            button3.Size = new Size(132, 39);
            button3.TabIndex = 22;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSkyBlue;
            label6.Location = new Point(27, 9);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 23;
            label6.Text = "<-Back";
            label6.Click += label6_Click;
            // 
            // gameID
            // 
            gameID.BackColor = Color.Gray;
            gameID.BorderStyle = BorderStyle.None;
            gameID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameID.Location = new Point(840, 71);
            gameID.Name = "gameID";
            gameID.Size = new Size(300, 22);
            gameID.TabIndex = 24;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.LightSkyBlue;
            label.Location = new Point(840, 46);
            label.Name = "label";
            label.Size = new Size(25, 21);
            label.TabIndex = 25;
            label.Text = "ID";
            // 
            // All_Products_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1184, 661);
            Controls.Add(label);
            Controls.Add(gameID);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(gameGenre);
            Controls.Add(gameStock);
            Controls.Add(gamePrice);
            Controls.Add(gameDiscount);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gameImage);
            Controls.Add(gameName);
            Controls.Add(dataGridView1);
            Name = "All_Products_Admin";
            Text = "All_Products_Admin";
            Click += All_Products_Admin_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gameImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox gameName;
        private PictureBox gameImage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox gameDiscount;
        private TextBox gamePrice;
        private TextBox gameStock;
        private TextBox gameGenre;
        private Button button4;
        private Button button2;
        private Button button3;
        private Label label6;
        private TextBox gameID;
        private Label label;
    }
}