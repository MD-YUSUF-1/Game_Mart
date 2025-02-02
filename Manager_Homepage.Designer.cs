namespace ProjectWin
{
    partial class Manager_Homepage
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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.DeepSkyBlue;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(290, 333);
            button5.Name = "button5";
            button5.Size = new Size(221, 48);
            button5.TabIndex = 9;
            button5.Text = "Profile";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.DeepSkyBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(290, 236);
            button4.Name = "button4";
            button4.Size = new Size(221, 51);
            button4.TabIndex = 8;
            button4.Text = "Refund Request";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(290, 142);
            button3.Name = "button3";
            button3.Size = new Size(221, 52);
            button3.TabIndex = 7;
            button3.Text = "Salesman Activity";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(290, 50);
            button1.Name = "button1";
            button1.Size = new Size(221, 51);
            button1.TabIndex = 5;
            button1.Text = "All Products";
            button1.UseVisualStyleBackColor = false;
            // 
            // Manager_Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG11;
            ClientSize = new Size(810, 433);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "Manager_Homepage";
            Text = "Manager_Homepage";
            ResumeLayout(false);
        }

        #endregion

        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
    }
}