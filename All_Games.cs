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
            this.Load += Form2_Load;
            this.username = username;
            this.password = password;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            dbcon();
            SqlCommand sq1 = new SqlCommand("select * from User1", con);
            DataTable dt = new DataTable();

            SqlDataReader sdr = sq1.ExecuteReader();
            dt.Load(sdr);

            //dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
