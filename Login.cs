using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProjectWin
{
    public partial class Login : Form
    {
        SqlConnection con;
        string role;
        public void dbcon()
        {
            try
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""G:\8. EIGHTH SEMESTER\C#\Project\MAIN PROJECT\Game_Mart.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to the database: {ex.Message}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Login(string role)
        {
            this.role = role;
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

            string query = "SELECT * FROM Login_Info WHERE Username = '" + username + "' AND Password = '" + password + "'";
            try
            {
                using (SqlDataAdapter sqda1 = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    sqda1.Fill(dt);
                    //Storing The role
                    string[] dataArray = new string[dt.Rows.Count];
                    int i = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        dataArray[i] = row["Role"].ToString();
                        i++;
                    }
                    //checking if no role
                    if (dataArray.Length < 1)
                    {
                        MessageBox.Show("Invalid  Person", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //converting the role in to lower case
                    dataArray[0] = dataArray[0].ToLower();
                    //checking valid role trying to login
                    if (dataArray[0] != role)
                    {
                        MessageBox.Show("Invalid Author", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                        return;
                    }
                    int count = dt.Rows.Count;

                    if (count == 1 && count < 2)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (dataArray[0] == "admin")
                        {
                            Admin_Homepage admin_homePage = new Admin_Homepage();
                            admin_homePage.Show();
                            this.Hide();
                            con.Close();
                        }
                        if (dataArray[0] == "salesman")
                        {
                            SalesMan s = new SalesMan(username, password);
                            this.Hide();
                            s.Show();
                            con.Close();
                        }
                        if (dataArray[0] == "manager")
                        {
                            Manager_Home m = new Manager_Home();
                            this.Hide();
                            m.Show();
                            con.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
