using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace ProjectWin
{
    public partial class SalesMan : Form
    {
        SqlConnection con;
        string username;
        string password;
        public void dbcon()
        {
            try
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""G:\8. EIGHTH SEMESTER\C#\Project\MAIN PROJECT\Game_Mart.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False
");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to the database: {ex.Message}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public SalesMan(string username, string password)
        {
            InitializeComponent();
            this.Load +=SalesMan_Load_1;
            this.username = username;
            this.password = password;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
           
            
            //SalesMan_Load_1(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            All_Role lg = new All_Role();
            lg.Show();  
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void SalesMan_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                gameName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                gameGenre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                gameStock.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                gamePrice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[6].Value);
                pictureBox3.Image = Image.FromStream(ms);
            }
            catch(Exception ex) {
                MessageBox.Show("Invalid data " + ex.Message);
            }
        }

        private void SalesMan_Load_1(object sender, EventArgs e)
        {
            try
            {
                dbcon();
                SqlCommand sq1 = new SqlCommand("select * from PRODUCT_TABLE", con);
                DataTable dt = new DataTable();

                SqlDataReader sdr = sq1.ExecuteReader();
                dt.Load(sdr);

                dataGridView1.RowTemplate.Height = 75;
                dataGridView1.DataSource = dt;
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                img = (DataGridViewImageColumn)dataGridView1.Columns[6];
                img.ImageLayout = DataGridViewImageCellLayout.Stretch;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("database Connection Error"+ ex.Message);
            }
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = true;

                    gameName.Text = dataGridView1.Rows[0].Cells[1].Value?.ToString();
                    gameGenre.Text = dataGridView1.Rows[0].Cells[5].Value?.ToString();
                    gameStock.Text = dataGridView1.Rows[0].Cells[2].Value?.ToString();
                    gamePrice.Text = dataGridView1.Rows[0].Cells[4].Value?.ToString();
                }
                else
                {
                    gameName.Text = "No Data";
                    gameGenre.Text = "No Data";
                    gameStock.Text = "No Data";
                    gamePrice.Text = "No Data";
                }
            }
            catch (Exception ex) {
                MessageBox.Show("No data Found" + ex.Message);
            }

        }
    }
}
