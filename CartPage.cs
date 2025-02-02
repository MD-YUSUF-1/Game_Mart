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
    public partial class CartPage : Form
    {
        public CartPage()
        {
            InitializeComponent();
            Form2_Load();
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
                SqlCommand sq1 = new SqlCommand("select * from CartTable", con);
                SqlDataAdapter sda = new SqlDataAdapter(sq1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dynamicDataLoad(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Table " + ex);
            }
        }
        public void dynamicDataLoad(DataTable dt)
        {
            FlowLayoutPanel flowLayoutPanelForCartColumn = new FlowLayoutPanel
            {
                Size = new Size(1290, 710),
                Location = new Point(0, 100),
                AutoScroll = true,
                BackColor = Color.Gray,
                WrapContents = true,
            };
            Panel card = new Panel
            {
                Size = new Size(1200, 60),
                //BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(30, 50, 0, 0),
                //BackColor = Color.GhostWhite,
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
                Location = new Point(650, 10),
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
                Location = new Point(1000, 10),
                AutoSize = true,
                ForeColor = Color.White,
            };
            card.Controls.Add(titleLabel4);
            //for cart data
            FlowLayoutPanel flowLayoutPanelforCartData = new FlowLayoutPanel
            {
                Size = new Size(1070, 710),
                //Location = new Point(100, 100),
                Margin = new Padding(90, 0, 0, 0),
                AutoScroll = true,
                //BackColor = Color.Red,
                WrapContents = true,
            };
            foreach (DataRow row in dt.Rows)
            {
                //Debug.WriteLine(row["GName"]);

                Panel cardForCartData = new Panel
                {
                    Size = new Size(1070, 60),
                    //BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(0, 10, 0, 0),
                    //BackColor = Color.GhostWhite,
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
                    Location = new Point(450, 10),
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
                //Label titleLabel13 = new Label
                //{
                //    Text = row["Quantity"].ToString(),
                //    Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                //    Location = new Point(800, 10),
                //    AutoSize = true,
                //    ForeColor = Color.White,
                //};
                //cardForCartData.Controls.Add(titleLabel13);
                Label titleLabel14 = new Label
                {
                    Text = row["Price"].ToString(),
                    Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                    Location = new Point(950, 10),
                    AutoSize = true,
                    ForeColor = Color.White,
                };
                cardForCartData.Controls.Add(titleLabel14);

                //FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
                //{
                //    Size = new Size(150, 75),
                //    Location = new Point(1230, 480),
                //    AutoScroll = true,
                //    //BackColor = Color.Red,
                //    WrapContents = true,
                //};
                //Panel card = new Panel
                //{
                //    Size = new Size(100, 50),
                //    BorderStyle = BorderStyle.FixedSingle,
                //    Margin = new Padding(10),
                //    //BackColor = Color.Red,
                //};

                //Label titleLabel1 = new Label
                //{
                //    Text = "Name: ",
                //    Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                //    Location = new Point(0, 0),
                //    AutoSize = true,
                //    ForeColor = Color.White,

                //};
                //card.Controls.Add(titleLabel1);
                flowLayoutPanelForCartColumn.Controls.Add(card);
                flowLayoutPanelforCartData.Controls.Add(cardForCartData);
                flowLayoutPanelForCartColumn.Controls.Add(flowLayoutPanelforCartData);
                
                this.Controls.Add(flowLayoutPanelForCartColumn);
            }
        }
        private void CartPage_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            SalesMan sl = new SalesMan("a","b");
            sl.Show();
            this.Hide();
        }
    }
}
