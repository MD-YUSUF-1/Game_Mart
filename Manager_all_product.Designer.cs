namespace ProjectWin
{
    partial class Manager_all_product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_all_product));
            browseBtn = new Button();
            updateBtn = new Button();
            label = new Label();
            gameID = new TextBox();
            label6 = new Label();
            gameGenre = new TextBox();
            gameStock = new TextBox();
            gamePrice = new TextBox();
            gameDiscount = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gameImage = new PictureBox();
            gameName = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gameImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // browseBtn
            // 
            browseBtn.BackColor = Color.DeepSkyBlue;
            browseBtn.Enabled = false;
            browseBtn.FlatStyle = FlatStyle.Flat;
            browseBtn.Location = new Point(550, 815);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(163, 52);
            browseBtn.TabIndex = 47;
            browseBtn.Text = "Browse";
            browseBtn.UseVisualStyleBackColor = false;
            browseBtn.Click += browseBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.DeepSkyBlue;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Location = new Point(299, 815);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(163, 52);
            updateBtn.TabIndex = 46;
            updateBtn.Text = "Edit";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.LightSkyBlue;
            label.Location = new Point(959, 71);
            label.Name = "label";
            label.Size = new Size(31, 28);
            label.TabIndex = 44;
            label.Text = "ID";
            // 
            // gameID
            // 
            gameID.BackColor = Color.Gray;
            gameID.BorderStyle = BorderStyle.None;
            gameID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameID.ForeColor = SystemColors.ControlText;
            gameID.Location = new Point(959, 107);
            gameID.Margin = new Padding(3, 4, 3, 4);
            gameID.Name = "gameID";
            gameID.ReadOnly = true;
            gameID.Size = new Size(343, 27);
            gameID.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSkyBlue;
            label6.Location = new Point(53, 19);
            label6.Name = "label6";
            label6.Size = new Size(74, 28);
            label6.TabIndex = 42;
            label6.Text = "<-Back";
            // 
            // gameGenre
            // 
            gameGenre.BackColor = Color.Gray;
            gameGenre.BorderStyle = BorderStyle.None;
            gameGenre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameGenre.Location = new Point(959, 251);
            gameGenre.Margin = new Padding(3, 4, 3, 4);
            gameGenre.Name = "gameGenre";
            gameGenre.ReadOnly = true;
            gameGenre.Size = new Size(343, 27);
            gameGenre.TabIndex = 40;
            // 
            // gameStock
            // 
            gameStock.BackColor = Color.Gray;
            gameStock.BorderStyle = BorderStyle.None;
            gameStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameStock.Location = new Point(959, 328);
            gameStock.Margin = new Padding(3, 4, 3, 4);
            gameStock.Name = "gameStock";
            gameStock.ReadOnly = true;
            gameStock.Size = new Size(343, 27);
            gameStock.TabIndex = 39;
            // 
            // gamePrice
            // 
            gamePrice.BackColor = Color.Gray;
            gamePrice.BorderStyle = BorderStyle.None;
            gamePrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gamePrice.Location = new Point(959, 407);
            gamePrice.Margin = new Padding(3, 4, 3, 4);
            gamePrice.Name = "gamePrice";
            gamePrice.ReadOnly = true;
            gamePrice.Size = new Size(343, 27);
            gamePrice.TabIndex = 38;
            // 
            // gameDiscount
            // 
            gameDiscount.BackColor = Color.Gray;
            gameDiscount.BorderStyle = BorderStyle.None;
            gameDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameDiscount.Location = new Point(959, 487);
            gameDiscount.Margin = new Padding(3, 4, 3, 4);
            gameDiscount.Name = "gameDiscount";
            gameDiscount.ReadOnly = true;
            gameDiscount.Size = new Size(343, 27);
            gameDiscount.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSkyBlue;
            label5.Location = new Point(959, 219);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 36;
            label5.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSkyBlue;
            label4.Location = new Point(955, 296);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 35;
            label4.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSkyBlue;
            label3.Location = new Point(959, 375);
            label3.Name = "label3";
            label3.Size = new Size(54, 28);
            label3.TabIndex = 34;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSkyBlue;
            label2.Location = new Point(959, 455);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 33;
            label2.Text = "Discount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSkyBlue;
            label1.Location = new Point(959, 137);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 32;
            label1.Text = "Name";
            // 
            // gameImage
            // 
            gameImage.Image = (Image)resources.GetObject("gameImage.Image");
            gameImage.Location = new Point(1018, 539);
            gameImage.Margin = new Padding(3, 4, 3, 4);
            gameImage.Name = "gameImage";
            gameImage.Size = new Size(243, 252);
            gameImage.SizeMode = PictureBoxSizeMode.StretchImage;
            gameImage.TabIndex = 31;
            gameImage.TabStop = false;
            gameImage.Click += gameImage_Click;
            // 
            // gameName
            // 
            gameName.BackColor = Color.Gray;
            gameName.BorderStyle = BorderStyle.None;
            gameName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameName.Location = new Point(959, 169);
            gameName.Margin = new Padding(3, 4, 3, 4);
            gameName.Name = "gameName";
            gameName.ReadOnly = true;
            gameName.Size = new Size(343, 27);
            gameName.TabIndex = 30;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Gray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 71);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(872, 720);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Manager_all_product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1353, 881);
            Controls.Add(browseBtn);
            Controls.Add(updateBtn);
            Controls.Add(label);
            Controls.Add(gameID);
            Controls.Add(label6);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Manager_all_product";
            Text = "Manager_all_product";
            ((System.ComponentModel.ISupportInitialize)gameImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button browseBtn;
        private Button updateBtn;
        private Label label;
        private TextBox gameID;
        private Label label6;
        private TextBox gameGenre;
        private TextBox gameStock;
        private TextBox gamePrice;
        private TextBox gameDiscount;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox gameImage;
        private TextBox gameName;
        private DataGridView dataGridView1;
    }
}