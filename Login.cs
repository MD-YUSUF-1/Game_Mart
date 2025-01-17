using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProjectWin
{
    public partial class Login : Form
    {
        SqlConnection con;
        public void dbcon()
        {
            try
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""G:\8. EIGHTH SEMESTER\C#\Project\ProjectWin\Database\Game_Mart.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False
");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to the database: {ex.Message}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbcon();
            string username = LoginTextBox1.Text.Trim();
            string password = loginPassBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "SELECT COUNT(*) FROM Users WHERE Username = '" + username + "' AND Password = '" + password + "'";
            try
            {
                if (username== "admin" && password == "admin")
                {
                    Admin_Homepage admin_homePage = new Admin_Homepage();
                    admin_homePage.Show();
                    this.Hide();
                }
                else
                {
                    dbcon();
                    using(SqlCommand sq1 = new SqlCommand(query, con))
                    {
                        int count  = Convert.ToInt32(sq1.ExecuteScalar());
                        System.Diagnostics.Debug.WriteLine($"Count: {count}");



                        DataTable dt = new DataTable();
                        SqlDataReader sdr = sq1.ExecuteReader();
                        dt.Load(sdr);
                        dataGridView1.DataSource = dt;
                        //con.Close();
                    }



                }
            }
            catch (Exception ex)
            {

            }


            //SalesMan s = new SalesMan();
            //s.Show();
            //this.Hide();
        }
    }
}
