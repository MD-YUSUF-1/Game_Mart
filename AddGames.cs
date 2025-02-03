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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjectWin
{
    
    public partial class AddGames : Form
    {
        string role;
        SqlConnection con;
        public void dbcon()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""G:\8. EIGHTH SEMESTER\C#\Project\MAIN PROJECT\database\Game_Mart.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
            con.Open();
        }
        public AddGames()
        {
            InitializeComponent();
            this.role = role;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text=="" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || pictureBox1.Image== null)
                {
                    MessageBox.Show("Please provide all information");
                   
                }
                else
                {
                    dbcon();
                    SqlCommand sq2 = new SqlCommand("insert into PRODUCT_TABLE(GName,GStock,GDiscount,GPrice,GGenre,GImage,isDeleted) values(@Name,@Stock,@discount,@Price, @Genre, @Image,@isdeleted)", con);
                    sq2.Parameters.AddWithValue("@Name", textBox1.Text);
                    sq2.Parameters.AddWithValue("@Genre", textBox2.Text);
                    sq2.Parameters.AddWithValue("@Stock", textBox3.Text);
                    sq2.Parameters.AddWithValue("@Price", textBox4.Text);
                    sq2.Parameters.AddWithValue("@discount", textBox5.Text);
                    sq2.Parameters.AddWithValue("@isdeleted", 0);

                    MemoryStream memstr = new MemoryStream();
                    pictureBox1.Image.Save(memstr, pictureBox1.Image.RawFormat);
                    sq2.Parameters.AddWithValue("@Image", memstr.ToArray());


                    sq2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data added");
                    Form2_Load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed" + ex);
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddGames_Load(object sender, EventArgs e)
        {
            Form2_Load();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dbcon();
            SqlCommand sq1 = new SqlCommand("select * from PRODUCT_TABLE", con);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

            All_Products_Admin all_Products_Admin = new All_Products_Admin();

            all_Products_Admin.Show();
            this.Hide();
        }
    }
}
