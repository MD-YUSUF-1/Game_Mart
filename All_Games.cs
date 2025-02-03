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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading.Tasks.Dataflow;

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
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""G:\8. EIGHTH SEMESTER\C#\Project\MAIN PROJECT\database\Game_Mart.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False
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
            this.Load += SalesMan_Load_1;
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
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SalesMan_Load_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();


            try
            {
                databseConnect(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("database Connection Error" + ex.Message);
            }
            dynamic_Data(dt);



        }


        public void dynamic_Data(DataTable dt)
        {
            try

            {

                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
                {
                    Size = new Size(1300, 670),
                    Location = new Point(40, 100),
                    AutoScroll = true,
                    BackColor = Color.Gray,
                    WrapContents = true,
                };
                foreach (DataRow row in dt.Rows)
                {
                    //Debug.WriteLine(row["GName"]);

                    Panel card = new Panel
                    {
                        Size = new Size(610, 330),
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(10),
                        //BackColor = Color.GhostWhite,
                    };



                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(300, 300),
                        Location = new Point(10, 10),
                        SizeMode = PictureBoxSizeMode.StretchImage,

                    };
                    object imageData = row["GImage"];
                    if (imageData == DBNull.Value)
                    {
                        pictureBox.Image = null;
                    }
                    else
                    {
                        MemoryStream stream = new MemoryStream((byte[])imageData);
                        pictureBox.Image = Image.FromStream(stream);
                    }
                    card.Controls.Add(pictureBox);
                    Label titleLabel1 = new Label
                    {
                        Text = "Name: " + row["GName"].ToString(),
                        Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                        Location = new Point(325, 10),
                        AutoSize = true,
                        ForeColor = Color.White,

                    };
                    card.Controls.Add(titleLabel1);

                    Label titleLabel2 = new Label
                    {
                        Text = "Genre: " + row["GGenre"].ToString(),
                        Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                        Location = new Point(325, 40),
                        AutoSize = true,
                        ForeColor = Color.White,
                    };
                    card.Controls.Add(titleLabel2);
                    Label titleLabel3 = new Label
                    {
                        Text = "Stock: " + row["GStock"].ToString(),
                        Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                        Location = new Point(325, 70),
                        AutoSize = true,
                        ForeColor = Color.White,
                    };
                    card.Controls.Add(titleLabel3);

                    Label titleLabel4 = new Label
                    {
                        Text = "Price: " + row["GPrice"].ToString(),
                        Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                        Location = new Point(325, 100),
                        AutoSize = true,
                        ForeColor = Color.White,
                    };
                    card.Controls.Add(titleLabel4);
                    System.Windows.Forms.Button AddToCartbtn = new System.Windows.Forms.Button
                    {
                        Text = "Add to cart",
                        Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                        Size = new Size(160, 50),
                        Location = new Point(325, 140),
                        BackColor = System.Drawing.ColorTranslator.FromHtml("#F5F5F5"),
                        FlatStyle = FlatStyle.Popup,
                        ForeColor = System.Drawing.ColorTranslator.FromHtml("#333333")
                    };
                    AddToCartbtn.Click += (s, e) =>
                    {
                        dbcon();
                        SqlCommand sq1 = new SqlCommand("SELECT SalespersonID,Username FROM Salespersons WHERE Username = @username AND Password = @password", con);
                        DataTable dt1 = new DataTable();
                        sq1.Parameters.AddWithValue("@username", username);
                        sq1.Parameters.AddWithValue("@password", password);
                        SqlDataAdapter sqd1 = new SqlDataAdapter(sq1);
                        sqd1.Fill(dt1);
                        if (dt1.Rows.Count > 0)
                        {
                            Debug.WriteLine("Data found!");
                            Debug.WriteLine("SalespersonID: " + dt1.Rows[0]["SalespersonID"]);
                            Debug.WriteLine("Username: " + dt1.Rows[0]["Username"]);
                        }
                        else
                        {
                            Debug.WriteLine("No data found!");
                        }


                        try
                        {
                            int gameID = Convert.ToInt32(row["GameID"]);
                            SqlCommand scmForCheck = new SqlCommand("SELECT * FROM CartTable WHERE GameID = @gameID", con);
                            scmForCheck.Parameters.AddWithValue("@gameID", gameID);
                            SqlDataAdapter sqdForCart = new SqlDataAdapter(scmForCheck);
                            DataTable dtforCartItem = new DataTable();
                            sqdForCart.Fill(dtforCartItem);

                            if (dtforCartItem.Rows.Count > 0)
                            {
                                MessageBox.Show("ALready Added to the cart. You can Update quantity in cart");
                            }
                            else
                            {
                                if (Convert.ToInt32(row["GStock"]) > 0)
                                {
                                    SqlCommand sq2 = new SqlCommand("insert into CartTABLE(SalesPersonID,SalesPersonName,GameID,GameName,Price,Quantity) values(@sid,@sname,@gid,@gname, @gp, @quantity)", con);
                                    if (float.Parse(row["GDiscount"].ToString()) > 0)
                                    {
                                        float price = float.Parse(row["GPrice"].ToString());
                                        float discount = float.Parse(row["GDiscount"].ToString());
                                        price = price - (price * (discount / 100));
                                        float newPrice = float.Parse(price.ToString("F2"));
                                        sq2.Parameters.AddWithValue("@gp", newPrice);
                                    }
                                    else
                                    {
                                        sq2.Parameters.AddWithValue("@gp", row["GPrice"]);
                                    }
                                    sq2.Parameters.AddWithValue("@gname", row["GName"]);
                                    sq2.Parameters.AddWithValue("@gid", row["GameID"]);
                                    sq2.Parameters.AddWithValue("@sid", dt1.Rows[0]["SalespersonID"]);
                                    sq2.Parameters.AddWithValue("@sname", dt1.Rows[0]["username"]);
                                    sq2.Parameters.AddWithValue("@quantity", 1);

                                    MessageBox.Show("Added to the cart", "Success", MessageBoxButtons.OK);
                                    sq2.ExecuteNonQuery();
                                    SqlCommand updateStockCmd = new SqlCommand("UPDATE PRODUCT_TABLE SET GStock = GStock - 1 WHERE GameID = @gameID", con);
                                    updateStockCmd.Parameters.AddWithValue("@gameID", gameID);
                                    updateStockCmd.ExecuteNonQuery();
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Sorry, No Stock available.");
                                }                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Cart insertion Failed. " + ex.Message);
                        }
                        con.Close();

                    };
                    card.Controls.Add(AddToCartbtn);
                    System.Windows.Forms.Button BuyNowBtn = new System.Windows.Forms.Button
                    {
                        Text = "Buy now",
                        Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                        Size = new Size(120, 50),
                        Location = new Point(325, 200),
                        BackColor = System.Drawing.ColorTranslator.FromHtml("#F5F5F5"),
                        FlatStyle = FlatStyle.Popup,
                        ForeColor = System.Drawing.ColorTranslator.FromHtml("#333333")
                    };
                    card.Controls.Add(BuyNowBtn);


                    flowLayoutPanel.Controls.Add(card);
                }

                this.Controls.Add(flowLayoutPanel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No data Found" + ex.Message);
            }
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CartPage cartPage = new CartPage(0);
            cartPage.Show();
            this.Hide();
        }

       

        private void profileBtn_Click(object sender, EventArgs e)
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            All_Role all_Role = new All_Role();
            all_Role.Show();
            this.Hide();
        }
    }
}
