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

namespace ProjectWin
{
    public partial class Admin_insert_manager : Form
    {
        SqlConnection con;
        public void dbcon()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\new_project\database\Game_Mart.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
            con.Open();
        }
        public Admin_insert_manager()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dbcon();
                SqlCommand sq2 = new SqlCommand("insert into Managers(Username,PhoneNumber,Email) values(@Username,@PhoneNumber,@Email)", con);
                //sq2.Parameters.AddWithValue("@Name", textBox1.Text);
                sq2.Parameters.AddWithValue("@Username", textBox2.Text);
                sq2.Parameters.AddWithValue("@PhoneNumber", textBox3.Text);
                sq2.Parameters.AddWithValue("@Email", textBox4.Text);
                // sq2.Parameters.AddWithValue("@discount", textBox5.Text);
                MemoryStream memstr = new MemoryStream();
                pictureBox1.Image.Save(memstr, pictureBox1.Image.RawFormat);
                sq2.Parameters.AddWithValue("@Image", memstr.ToArray());


                sq2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data added");
                Form2_Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed" + ex);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form2_Load()
        {
            try
            {
                dbcon();
                SqlCommand sq1 = new SqlCommand("select * from Managers", con);
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

        private void label7_Click_1(object sender, EventArgs e)
        {
            Admin_Managers_Table admin_Managers_Table = new Admin_Managers_Table();
            admin_Managers_Table.Show();
            this.Hide();
        }
    }
}
