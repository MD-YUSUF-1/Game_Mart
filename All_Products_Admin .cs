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
        public All_Products_Admin()
        {
            InitializeComponent();
            Form2_Load();
        }
        SqlConnection con;
        public void dbcon()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""G:\8. EIGHTH SEMESTER\C#\Project\MAIN PROJECT\Game_Mart.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
            con.Open();
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
            AddGames addGames = new AddGames();
            addGames.Show();
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
                gameID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                gameName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                gameGenre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                gameStock.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                gamePrice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                gameDiscount.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[6].Value);
                gameImage.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid data " + ex.Message);
            }
        }
    }
}
