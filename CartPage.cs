using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin
{
    public partial class CartPage : Form
    {
        int pid;
        string name;
        string password;
        string role;
        public CartPage(int id, string name, string pass, string role)
        {
            this.pid = id;
            InitializeComponent();
            Form2_Load();
            this.name = name;
            this.password = pass;
            this.role = role;
            Debug.WriteLine(id + name+ pass+role);
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
                SqlCommand sq1 = new SqlCommand("select * from CartTable where SalesPersonID = @id", con);
                sq1.Parameters.AddWithValue("@id", pid);
                SqlDataAdapter sda = new SqlDataAdapter(sq1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dynamicDataLoad(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Table ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void dynamicDataLoad(DataTable dt)
        {

            try
            {
                FlowLayoutPanel flowLayoutPanelForCartColumn = new FlowLayoutPanel
                {
                    Size = new Size(1290, 720),
                    Location = new Point(0, 150),

                    AutoScroll = true,
                    //BackColor = Color.Green,
                    WrapContents = true,
                };
                Panel card = new Panel
                {
                    Size = new Size(1200, 60),
                    Margin = new Padding(30, 50, 0, 0),
                    BorderStyle = BorderStyle.FixedSingle,
                };
                Label titleLabel7 = new Label
                {
                    Text = "SalesmanID",
                    Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                    Location = new Point(40, 10),
                    AutoSize = true,
                    ForeColor = Color.White,

                };
                card.Controls.Add(titleLabel7);
                Label titleLabel8 = new Label
                {
                    Text = "SalesmanName",
                    Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                    Location = new Point(240, 10),
                    AutoSize = true,
                    ForeColor = Color.White,

                };
                card.Controls.Add(titleLabel8);
                Label titleLabel1 = new Label
                {
                    Text = "GameID",
                    Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                    Location = new Point(460, 10),
                    AutoSize = true,
                    ForeColor = Color.White,

                };
                card.Controls.Add(titleLabel1);

                Label titleLabel2 = new Label
                {
                    Text = "GameName",
                    Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                    Location = new Point(610, 10),
                    AutoSize = true,
                    ForeColor = Color.White,
                };
                card.Controls.Add(titleLabel2);
                Label titleLabel3 = new Label
                {
                    Text = "Quantity",
                    Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                    Location = new Point(830, 10),
                    AutoSize = true,
                    ForeColor = Color.White,
                };
                card.Controls.Add(titleLabel3);

                Label titleLabel4 = new Label
                {
                    Text = "Price",
                    Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                    Location = new Point(990, 10),
                    AutoSize = true,
                    ForeColor = Color.White,
                };
                card.Controls.Add(titleLabel4);
                //for cart data
                FlowLayoutPanel flowLayoutPanelforCartData = new FlowLayoutPanel
                {
                    Size = new Size(1270, 600),
                    Margin = new Padding(0, 0, 0, 0),
                    AutoScroll = true,
                    //BackColor = Color.Red,
                    WrapContents = true,
                };
                Panel cardForCartData;
                foreach (DataRow row in dt.Rows)
                {


                    cardForCartData = new Panel
                    {
                        Size = new Size(1070, 43),
                        Margin = new Padding(70, 10, 0, 0),
                    };
                    Label titleLabel9 = new Label
                    {
                        Text = row["SalespersonID"].ToString(),
                        Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                        Location = new Point(30, 10),
                        AutoSize = true,
                        ForeColor = Color.White,

                    };
                    cardForCartData.Controls.Add(titleLabel9);

                    Label titleLabel10 = new Label
                    {
                        Text = row["SalespersonName"].ToString(),
                        Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                        Location = new Point(230, 10),
                        AutoSize = true,
                        ForeColor = Color.White,
                    };
                    cardForCartData.Controls.Add(titleLabel10);
                    Label titleLabel11 = new Label
                    {
                        Text = row["GameID"].ToString(),
                        Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                        Location = new Point(440, 10),
                        AutoSize = true,
                        ForeColor = Color.White,
                    };
                    cardForCartData.Controls.Add(titleLabel11);
                    Label titleLabel12 = new Label
                    {

                        Text = row["GameName"].ToString(),
                        Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                        Location = new Point(580, 10),
                        AutoSize = true,
                        ForeColor = Color.White,
                    };
                    cardForCartData.Controls.Add(titleLabel12);
                    TextBox titleLabel13 = new TextBox
                    {
                        Size = new Size(60, 40),
                        BackColor = Color.FromArgb(64, 64, 64),
                        BorderStyle = BorderStyle.None,
                        Text = row["Quantity"].ToString(),
                        Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                        Location = new Point(840, 10),
                        ForeColor = Color.White,
                    };
                    cardForCartData.Controls.Add(titleLabel13);
                    Label titleLabel14 = new Label
                    {
                        Text = row["Price"].ToString(),
                        Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                        Location = new Point(950, 10),
                        AutoSize = true,
                        ForeColor = Color.White,
                    };
                    cardForCartData.Controls.Add(titleLabel14);
                    flowLayoutPanelforCartData.Controls.Add(cardForCartData);
                }
                Panel cardforTotalPrice = new Panel
                {
                    Size = new Size(1200, 50),
                    Margin = new Padding(30, 0, 0, 10),
                    BorderStyle = BorderStyle.FixedSingle,
                    //BackColor = Color.White,
                };
                Label titleLabel16 = new Label
                {
                    Text = "Total Quantity: " + TotalGames(),
                    Font = new System.Drawing.Font("Segoe UI", 14, FontStyle.Bold),
                    Location = new Point(600, 10),
                    AutoSize = true,
                    ForeColor = Color.White,
                };
                cardforTotalPrice.Controls.Add(titleLabel16);
                Label titleLabel15 = new Label
                {
                    Text = "Total Price: " + TotalPrice(),
                    Font = new System.Drawing.Font("Segoe UI", 14, FontStyle.Bold),
                    Location = new Point(850, 10),
                    AutoSize = true,
                    ForeColor = Color.White,
                };
                cardforTotalPrice.Controls.Add(titleLabel15);
                flowLayoutPanelforCartData.Controls.Add(cardforTotalPrice);
                Panel cardforBuy = new Panel
                {
                    Size = new Size(1200, 80),
                    Margin = new Padding(30, 0, 0, 50),
                    //BorderStyle = BorderStyle.FixedSingle,
                    //BackColor = Color.White,
                };
                Label lblID = new Label()
                {
                    Text = "ID: ",
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Size = new Size(70, 40),
                    Location = new Point(50, 25),
                    ForeColor = Color.White,
                };
                cardforBuy.Controls.Add(lblID);

                TextBox tb = new TextBox()
                {
                    Font = new Font("Segoe UI", 12, FontStyle.Regular),
                    Size = new Size(120, 40),
                    Location = new Point(120, 25),
                    ForeColor = Color.Black,
                    BackColor = ColorTranslator.FromHtml("#F5F5F5"),
                    BorderStyle = BorderStyle.FixedSingle
                };
                cardforBuy.Controls.Add(tb);

                System.Windows.Forms.Button UpdateBtn = new System.Windows.Forms.Button
                {
                    Text = "Update",
                    Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                    Size = new Size(180, 60),
                    Location = new Point(320, 10),
                    BackColor = System.Drawing.ColorTranslator.FromHtml("#F5F5F5"),
                    FlatStyle = FlatStyle.Popup,
                    ForeColor = System.Drawing.ColorTranslator.FromHtml("#333333")
                    //ForeColor = Color.White,
                };
                UpdateBtn.Click += (s, e) =>
                {
                    int id;
                    bool isId = int.TryParse(tb.Text, out id);
                    if (isId)
                    {
                        dbcon();
                        SqlCommand scmForCheck = new SqlCommand("SELECT COUNT(*) FROM CartTable WHERE GameID = @gameID", con);
                        scmForCheck.Parameters.AddWithValue("@gameID", id);
                        int count = Convert.ToInt32(scmForCheck.ExecuteScalar());
                        if (count > 0)
                        {
                            CartQuantityUpdate cartQuantityUpdate = new CartQuantityUpdate(id, name, password, role, pid);
                            cartQuantityUpdate.Show();
                            this.Hide();
                            tb.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("No data related to the ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please write a Game ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                };
                cardforBuy.Controls.Add(UpdateBtn);
                System.Windows.Forms.Button DeleteBtn = new System.Windows.Forms.Button
                {
                    Text = "Delete",
                    Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                    Size = new Size(180, 60),
                    Location = new Point(550, 10),
                    BackColor = System.Drawing.ColorTranslator.FromHtml("#F5F5F5"),
                    FlatStyle = FlatStyle.Popup,
                    ForeColor = System.Drawing.ColorTranslator.FromHtml("#333333"),
                    //ForeColor = Color.White,

                };
                DeleteBtn.Click += (s, e) =>
                {

                    try
                    {
                        int id;
                        bool isId = int.TryParse(tb.Text, out id);
                        if (isId)
                        {
                            dbcon();
                            SqlCommand scmForCheck = new SqlCommand("SELECT COUNT(*) FROM CartTable WHERE GameID = @gameID", con);
                            scmForCheck.Parameters.AddWithValue("@gameID", id);
                            int count = Convert.ToInt32(scmForCheck.ExecuteScalar());
                            if (count > 0)
                            {
                                dbcon();
                                SqlCommand sq1 = new SqlCommand("DELETE from CartTable where GameID=@gameID", con);
                                sq1.Parameters.AddWithValue("@gameID", id);
                                sq1.ExecuteNonQuery();
                                //flowLayoutPanelForCartColumn.Controls.Clear();
                                //Form2_Load();
                                MessageBox.Show("Product DELETED", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                CartPage newCartPage = new CartPage(pid, name, password, role);
                                newCartPage.Show();
                                tb.Text = "";
                                con.Close();

                            }
                            else
                            {
                                MessageBox.Show("No data related to the ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please write a Game ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("No game Found. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                };

                cardforBuy.Controls.Add(DeleteBtn);
                System.Windows.Forms.Button BuyNowBtn = new System.Windows.Forms.Button
                {
                    Text = "Buy now",
                    Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                    Size = new Size(180, 60),
                    Location = new Point(780, 10),
                    BackColor = System.Drawing.ColorTranslator.FromHtml("#F5F5F5"),
                    FlatStyle = FlatStyle.Popup,
                    ForeColor = System.Drawing.ColorTranslator.FromHtml("#333333")
                    //ForeColor = Color.White,
                };
                BuyNowBtn.Click += (s, e) =>
                {

                    try
                    {
                        string customerName = textBox1.Text;
                        string customerPhone = textBox2.Text;

                        if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
                        {
                            MessageBox.Show("Customer Name and Phone number cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dbcon();
                            SqlCommand insertcmd = new SqlCommand("INSERT INTO Activity_Table (SalespersonID, SalespersonName, PriceSold, CustomerName, CustomerPhone) VALUES(@SalespersonID, @SalespersonName, @PriceSold, @CustomerName, @CustomerPhone)", con);
                            insertcmd.Parameters.AddWithValue("@SalespersonID", pid);
                            insertcmd.Parameters.AddWithValue("@SalespersonName", name);
                            insertcmd.Parameters.AddWithValue("@PriceSold", TotalPrice());
                            insertcmd.Parameters.AddWithValue("@CustomerName", customerName);
                            insertcmd.Parameters.AddWithValue("@CustomerPhone", customerPhone);
                            float finalPrice = TotalPrice();
                            int rowsAffected = insertcmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                dbcon();
                                SqlCommand deleteCmd = new SqlCommand("DELETE FROM CartTable WHERE SalespersonID = @SalespersonID", con);
                                deleteCmd.Parameters.AddWithValue("@SalespersonID", pid);
                                int deleteRowsAffected = deleteCmd.ExecuteNonQuery();

                                if (deleteRowsAffected > 0)
                                {
                                    MessageBox.Show("Items Sold To " + customerName + ", Total price " + finalPrice + ".","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();
                                    SalesMan salesMan = new SalesMan(name, password, role);
                                    salesMan.Show();
                                }
                                else
                                {
                                    MessageBox.Show("No cart items found for this salesperson.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                con.Close();
                            }
                            else
                            {
                                MessageBox.Show("Insert failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            con.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }





                };
                cardforBuy.Controls.Add(BuyNowBtn);
                flowLayoutPanelforCartData.Controls.Add(cardforBuy);
                flowLayoutPanelForCartColumn.Controls.Add(card);
                flowLayoutPanelForCartColumn.Controls.Add(flowLayoutPanelforCartData);
                this.Controls.Add(flowLayoutPanelForCartColumn);

            }
            catch (Exception ex) { MessageBox.Show("No data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void CartPage_Load(object sender, EventArgs e)
        {

        }
        public float TotalPrice()
        {
            float totalPrice = 0;
            try
            {
                dbcon();
                dbcon();
                SqlCommand totalPriceCmd = new SqlCommand("SELECT SUM(Price) FROM CartTable where SalesPersonID = @id", con);
                totalPriceCmd.Parameters.AddWithValue("@id", pid);
                object result = totalPriceCmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    float totalPriceFromCart = Convert.ToSingle(result);
                    totalPrice = float.Parse(totalPriceFromCart.ToString("F2"));
                }
                con.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show("No total price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return totalPrice;
        }

        public int TotalGames()
        {
            int totalGames = 0;

            try
            {
                dbcon();
                SqlCommand totalGamesCmd = new SqlCommand("SELECT SUM(Quantity) FROM CartTable where SalesPersonID = @id", con);
                totalGamesCmd.Parameters.AddWithValue("@id", pid);
                object result = totalGamesCmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    totalGames = Convert.ToInt32(result);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error counting total games: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return totalGames;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            SalesMan sl = new SalesMan(name, password, role);
            sl.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            All_Role role = new All_Role();
            role.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SalesMan salesMan = new SalesMan(name, password, role);
            salesMan.Show();
            this.Hide();
        }
    }
}
