using Microsoft.Data.SqlClient;
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
    public partial class All_Products_Admin : Form
    {
        string role;
        public All_Products_Admin(string role)
        {
            InitializeComponent();
            Form2_Load();
            gameImage.Image = null;
            this.role = role;
            if (role == "manager")
            {
                button2.Visible = false;
                button1.Visible = false;
            }
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

        private void label6_Click(object sender, EventArgs e)
        {
            Admin_Homepage admin_Homepage = new Admin_Homepage();
            admin_Homepage.Show();
            this.Hide();
        }

        private void Form2_Load()
        {
            try
            {
                dbcon();
                SqlCommand sq1 = new SqlCommand("select * from PRODUCT_TABLE", con);
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

        private void button2_Click(object sender, EventArgs e)
        {
            AddGames addGames = new AddGames(role);
            addGames.Show();
            this.Hide();
        }

        private void All_Products_Admin_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbcon();
            SqlCommand sq1 = new SqlCommand("DELETE from PRODUCT_TABLE where GameID=@gameID", con);
            sq1.Parameters.AddWithValue("@gameID", int.Parse(gameID.Text));
            sq1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Product DELETED");
            Form2_Load();
            gameID.Text = string.Empty;
            gameName.Text = string.Empty;
            gameStock.Text = string.Empty;
            gamePrice.Text = string.Empty;
            gameDiscount.Text = string.Empty;
            gameGenre.Text = string.Empty;
            gameImage.Image = null;
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
                    gameGenre.Text = "";
                    gameName.Text = "";
                    gameDiscount.Text = "";
                    gameStock.Text = "";
                    gamePrice.Text = "";
                    MessageBox.Show("Updated Successfully");
                    Form2_Load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Inavlid input");
                }


            }
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

        private void gameID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
