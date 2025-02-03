﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin
{
    public partial class Manager_all_product : Form
    {
        public Manager_all_product()
        {
            InitializeComponent();
            Form2_Load();
            browseBtn.Enabled = false;
        }
        SqlConnection con;
        public void dbcon()
        {
            try
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""G:\8. EIGHTH SEMESTER\C#\Project\MAIN PROJECT\database\Game_Mart.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False
");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to the database: {ex.Message}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form2_Load()
        {
            try
            {
                dbcon();
                SqlCommand sq1 = new SqlCommand("select GameID, GName, GStock, GDiscount, GPrice, GGenre, GImage from PRODUCT_TABLE WHERE isDeleted = 0", con);
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (updateBtn.Text == "Edit")
            {
                if (string.IsNullOrWhiteSpace(gameID.Text))
                {
                    MessageBox.Show("Please Select a Product");
                    return;
                }
                else
                {
                    updateBtn.Text = "Update";
                    gameDiscount.ReadOnly = false;
                    gameGenre.ReadOnly = false;
                    gameName.ReadOnly = false;
                    gameStock.ReadOnly = false;
                    gamePrice.ReadOnly = false;
                    browseBtn.Enabled = true;
                    browseBtn.Cursor = Cursors.Hand;
                    gameName.BackColor = Color.Silver;
                    gamePrice.BackColor = Color.Silver;
                    gameStock.BackColor = Color.Silver;
                    gameDiscount.BackColor = Color.Silver;
                    gameGenre.BackColor = Color.Silver;
                }
            }
            else if (updateBtn.Text == "Update")
            {
                updateBtn.Text = "Edit";
                gameGenre.ReadOnly = true;
                gameName.ReadOnly = true;
                gameStock.ReadOnly = true;
                gamePrice.ReadOnly = true;
                gameDiscount.ReadOnly = true;
                browseBtn.Enabled = false;
                gameName.BackColor = Color.Gray;
                gamePrice.BackColor = Color.Gray;
                gameStock.BackColor = Color.Gray;
                gameDiscount.BackColor = Color.Gray;
                gameGenre.BackColor = Color.Gray;

                try
                {
                    dbcon();
                    SqlCommand sq2 = new SqlCommand("UPDATE PRODUCT_TABLE SET GName = @Name, GStock = @Stock, GDiscount = @Discount, GPrice = @Price, GGenre = @Genre, GImage = @Image WHERE GameID = @gameID", con);
                    sq2.Parameters.AddWithValue("gameID", gameID.Text);
                    sq2.Parameters.AddWithValue("@Name", gameName.Text);
                    sq2.Parameters.AddWithValue("@Genre", gameGenre.Text);
                    sq2.Parameters.AddWithValue("@Stock", gameStock.Text);
                    sq2.Parameters.AddWithValue("@Price", gamePrice.Text);
                    sq2.Parameters.AddWithValue("@discount", gameDiscount.Text);
                    MemoryStream memstr = new MemoryStream();
                    gameImage.Image.Save(memstr, gameImage.Image.RawFormat);
                    sq2.Parameters.AddWithValue("@Image", memstr.ToArray());
                    sq2.ExecuteNonQuery();
                    con.Close();
                    gameID.Text = "";
                    gameGenre.Text = "";
                    gameName.Text = "";
                    gameDiscount.Text = "";
                    gameStock.Text = "";
                    gameImage.Image = null;
                    gamePrice.Text = "";
                    MessageBox.Show("Updated Successfully");
                    // Form2_Load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Inavlid input");
                }


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    gameImage.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image file not found!" + ex);
            }
        }

        private void gameImage_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        
            {
                try
                {
                    if (updateBtn.Text == "Update")
                    {
                        MessageBox.Show("Please, Update First");
                        dataGridView1.ClearSelection();
                    }
                    else
                    {
                        gameID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        gameName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        gameGenre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                        gameStock.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        gamePrice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                        gameDiscount.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                        MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[6].Value);
                        gameImage.Image = Image.FromStream(ms);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid data " + ex.Message);
                }
            }
        
    }
}
