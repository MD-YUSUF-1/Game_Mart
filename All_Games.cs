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
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public void databseConnect(DataTable dt)
        {
            dbcon();
            SqlCommand sq1 = new SqlCommand("select * from PRODUCT_TABLE", con);


            SqlDataReader sdr = sq1.ExecuteReader();
            dt.Load(sdr);

            //dataGridView1.RowTemplate.Height = 75;
            //dataGridView1.DataSource = dt;
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            //img = (DataGridViewImageColumn)dataGridView1.Columns[6];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    gameName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //    gameGenre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //    gameStock.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //    gamePrice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            //    MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[6].Value);
            //    pictureBox3.Image = Image.FromStream(ms);
            //}
            //catch(Exception ex) {
            //    MessageBox.Show("Invalid data " + ex.Message);
            //}
        }

        private void SalesMan_Load_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
            {
                Size = new Size(1050, 600),
                Location = new Point(0, 100),
                AutoScroll = true,
                WrapContents = true ,
            };

            try
            {
                databseConnect(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show("database Connection Error"+ ex.Message);
            }
            try
            {
                //if (dataGridView1.Rows.Count > 0)
                //{
                //    dataGridView1.Rows[0].Selected = true;

                //    gameName.Text = dataGridView1.Rows[0].Cells[1].Value?.ToString();
                //    gameGenre.Text = dataGridView1.Rows[0].Cells[5].Value?.ToString();
                //    gameStock.Text = dataGridView1.Rows[0].Cells[2].Value?.ToString();
                //    gamePrice.Text = dataGridView1.Rows[0].Cells[4].Value?.ToString();
                //}
                //else
                //{
                //    gameName.Text = "No Data";
                //    gameGenre.Text = "No Data";
                //    gameStock.Text = "No Data";
                //    gamePrice.Text = "No Data";
                //}
                foreach (DataRow row in dt.Rows)
                {
                    Debug.WriteLine(row["GName"]);

                    //creating new Panel
                    Panel card = new Panel()
                    {
                        Size = new Size(500, 300),
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(10)
                    };
                    //adding pictureBox
                    PictureBox pictureBox = new PictureBox()
                    {
                        Size = new Size(300,250),
                        Location = new Point(10,10),
                        BackColor = Color.Red,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        //Image 
                    };
                    card.Controls.Add(pictureBox);

                 
                    Label titleLabel1 = new Label
                    {
                        Text = "Name: " + row["GName"].ToString(),
                        Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                        Location = new Point(325, 10),
                        AutoSize = true
                    };
                    card.Controls.Add(titleLabel1);

                    Label titleLabel2 = new Label
                    {
                        Text = "Genre: "+ row["GGenre"].ToString(),
                        Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                        Location = new Point(325, 40),
                        AutoSize = true
                    };
                    card.Controls.Add(titleLabel2);
                    Label titleLabel3 = new Label
                    {
                        Text = "Stock: " + row["GStock"].ToString(),
                        Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                        Location = new Point(325, 70),
                        AutoSize = true
                    };
                    card.Controls.Add(titleLabel3);

                    Label titleLabel4 = new Label
                    {
                        Text = "Price: " + row["GPrice"].ToString(),
                        Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                        Location = new Point(325, 100),
                        AutoSize = true
                    };
                    card.Controls.Add(titleLabel4);




                    flowLayoutPanel.Controls.Add(card);
                }

                this.Controls.Add(flowLayoutPanel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No data Found" + ex.Message);
            }

        }
    }
}
