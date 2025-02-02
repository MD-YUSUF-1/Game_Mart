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
                dataGridView1.RowTemplate.Height = 50;
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Table " + ex);
            }
        }
        private void CartPage_Load(object sender, EventArgs e)
        {

            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
            {
                Size = new Size(150, 75),
                Location = new Point(1230, 480),
                AutoScroll = true,
                //BackColor = Color.Red,
                WrapContents = true,
            };
            Panel card = new Panel
            {
                Size = new Size(100, 50),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                //BackColor = Color.Red,
            };

            Label titleLabel1 = new Label
            {
                Text = "Name: ",
                Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(0, 0),
                AutoSize = true,
                ForeColor = Color.White,

            };
            card.Controls.Add(titleLabel1);
            flowLayoutPanel.Controls.Add(card);
            this.Controls.Add(flowLayoutPanel);
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
