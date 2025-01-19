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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            pictureBox3 = new PictureBox();
            gameName = new Label();
            gameGenre = new Label();
            gamePrice = new Label();
            gameStock = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(-58, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 172);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-6, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1035, 105);
            panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(818, 13);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(83, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(921, 29);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(90, 44);
            button4.TabIndex = 9;
            button4.Text = "Log out";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(748, 368);
            button2.Name = "button2";
            button2.Size = new Size(118, 44);
            button2.TabIndex = 1;
            button2.Text = "Buy Now";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(548, 368);
            button3.Name = "button3";
            button3.Size = new Size(118, 44);
            button3.TabIndex = 3;
            button3.Text = "Add To Cart";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-6, 443);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1047, 224);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(190, 135);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(293, 205);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // gameName
            // 
            gameName.AutoSize = true;
            gameName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameName.ForeColor = SystemColors.ButtonHighlight;
            gameName.Location = new Point(602, 148);
            gameName.Name = "gameName";
            gameName.Size = new Size(64, 25);
            gameName.TabIndex = 11;
            gameName.Text = "Name";
            // 
            // gameGenre
            // 
            gameGenre.AutoSize = true;
            gameGenre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameGenre.ForeColor = SystemColors.ButtonHighlight;
            gameGenre.Location = new Point(600, 200);
            gameGenre.Name = "gameGenre";
            gameGenre.Size = new Size(66, 25);
            gameGenre.TabIndex = 12;
            gameGenre.Text = "Genre";
            // 
            // gamePrice
            // 
            gamePrice.AutoSize = true;
            gamePrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gamePrice.ForeColor = SystemColors.ButtonHighlight;
            gamePrice.Location = new Point(600, 315);
            gamePrice.Name = "gamePrice";
            gamePrice.Size = new Size(56, 25);
            gamePrice.TabIndex = 14;
            gamePrice.Text = "Price";
            // 
            // gameStock
            // 
            gameStock.AutoSize = true;
            gameStock.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameStock.ForeColor = SystemColors.ButtonHighlight;
            gameStock.Location = new Point(600, 258);
            gameStock.Name = "gameStock";
            gameStock.Size = new Size(62, 25);
            gameStock.TabIndex = 15;
            gameStock.Text = "Stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(507, 200);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 16;
            label1.Text = "Genre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(504, 148);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 17;
            label2.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(507, 315);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 19;
            label4.Text = "Price: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(505, 258);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 20;
            label5.Text = "Stock:";
            // 
            // SalesMan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1034, 661);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gameStock);
            Controls.Add(gamePrice);
            Controls.Add(gameGenre);
            Controls.Add(gameName);
            Controls.Add(pictureBox3);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "SalesMan";
            Text = "GameDetails";
            Load += SalesMan_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button4;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label gameName;
        private Label gameGenre;
        private Label gamePrice;
        private Label gameStock;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}