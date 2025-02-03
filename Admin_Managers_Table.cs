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
    public partial class Admin_Managers_Table : Form
    {
        public Admin_Managers_Table()
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

        private void Admin_Managers_Table_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin_Homepage adminHomepage = new Admin_Homepage();
            adminHomepage.Show();
            this.Hide();

        }
        private void Form2_Load()
        {
            try
            {
                dbcon();
                SqlCommand sq1 = new SqlCommand("select ManagerID,Username,PhoneNumber,Email from Managers", con);
                SqlDataAdapter sda = new SqlDataAdapter(sq1);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                dataGridView1.RowTemplate.Height = 50;
                dataGridView1.DataSource = dt;
                //DataGridViewImageColumn img = new DataGridViewImageColumn();
                //img = (DataGridViewImageColumn)dataGridView1.Columns[6];
                //img.ImageLayout = DataGridViewImageCellLayout.Stretch;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Table " + ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                personID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                personName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                personPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                personGmail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid data " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_insert_manager admin_Insert_Manager = new Admin_insert_manager();
            admin_Insert_Manager.Show();
            this.Hide();
        }
    }
}
