﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectWin
{
    public partial class Admin_insert_manager : Form
    {
        SqlConnection con;
        public void dbcon()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""G:\8. EIGHTH SEMESTER\C#\Project\MAIN PROJECT\database\Game_Mart.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
            con.Open();
        }
        public Admin_insert_manager()
        {
            InitializeComponent();
            Form2_Load();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" ||  pictureBox1.Image == null)
                {
                    MessageBox.Show("Please provide all information");

                }
                else {
                    try
                    {
                        string password = textBox5.Text;
                        if (password.Length < 6 || !Regex.IsMatch(password, @"[!@#$%^&*(),.?\:{ }|<>]"))
                        {
                            MessageBox.Show("Password must be at least 6 characters long and contain at least one special character.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        dbcon();
                        SqlCommand sq2 = new SqlCommand("insert into Managers(Username,PhoneNumber,Email,DateOfBirth,Photo,Password) values(@Username,@PhoneNumber,@Email,@Date,@Image,@pass)", con);

                        sq2.Parameters.AddWithValue("@Username", textBox2.Text);
                        sq2.Parameters.AddWithValue("@PhoneNumber", textBox4.Text);
                        sq2.Parameters.AddWithValue("@Email", textBox3.Text);
                        sq2.Parameters.AddWithValue("@pass", textBox5.Text);

                        sq2.Parameters.AddWithValue("@Date", datePicker1.Value);
                        MemoryStream memstr = new MemoryStream();
                        pictureBox1.Image.Save(memstr, pictureBox1.Image.RawFormat);
                        sq2.Parameters.AddWithValue("@Image", memstr.ToArray());
                        sq2.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data added");
                        Form2_Load();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to load Table " + ex);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed" + ex);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form2_Load()
        {
            try
            {
                dbcon();
                SqlCommand sq1 = new SqlCommand("select * from Managers", con);
                SqlDataAdapter sda = new SqlDataAdapter(sq1);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                dataGridView1.RowTemplate.Height = 75;
                dataGridView1.DataSource = dt;
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                img = (DataGridViewImageColumn)dataGridView1.Columns[6];
                img.ImageLayout = DataGridViewImageCellLayout.Stretch;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Table " + ex);
            }
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            Admin_Managers_Table admin_Managers_Table = new Admin_Managers_Table();
            admin_Managers_Table.Show();
            this.Hide();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image file not found!" + ex);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Admin_Managers_Table admin_Managers_Table = new Admin_Managers_Table();
            admin_Managers_Table.Show();
            this.Hide();
        }
    }
}
