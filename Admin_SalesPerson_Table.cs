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
    public partial class Admin_SalesPerson_Table : Form
    {
        public Admin_SalesPerson_Table()
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
                SqlCommand sq1 = new SqlCommand("select SalespersonID,Username,PhoneNumber,Email from Salespersons", con);
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin_Homepage admin_Homepage = new Admin_Homepage();
            admin_Homepage.Show();
            this.Hide();
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
    }
}
