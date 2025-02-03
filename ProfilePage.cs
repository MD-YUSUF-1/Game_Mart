using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ProjectWin
{
    public partial class ProfilePage : Form
    {
        string username;
        string password;
        string role;
        public ProfilePage(string username, string pass, string role)
        {
            InitializeComponent();
            this.username = username;
            this.password = pass;
            this.role = role;
            //browseBtn.Enabled = false;
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
                if (role == "manager")
                {
                    dbcon();

                    SqlCommand sq1 = new SqlCommand("SELECT Username, Email, PhoneNumber, DateOfBirth, Photo FROM Managers WHERE Username = @Username AND Password = @Password", con);
                    sq1.Parameters.AddWithValue("@Username", username);
                    sq1.Parameters.AddWithValue("@Password", password);

                    SqlDataAdapter sda = new SqlDataAdapter(sq1);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        name.Text = dt.Rows[0]["Username"].ToString();
                        email.Text = dt.Rows[0]["Email"].ToString();
                        phone.Text = dt.Rows[0]["PhoneNumber"].ToString();
                        datePicker1.Value = Convert.ToDateTime(dt.Rows[0]["DateOfBirth"]);

                        byte[] imgBytes = (byte[])dt.Rows[0]["Photo"];
                        MemoryStream ms = new MemoryStream(imgBytes);
                        image.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        MessageBox.Show("No data found" + MessageBoxButtons.OK + MessageBoxIcon.Error);
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Table " + ex);
            }
        }


        private void ProfilePage_Load(object sender, EventArgs e)
        {

        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (updateBtn.Text == "Edit Profile")
            {

                updateBtn.Text = "Update";
                name.ReadOnly = false;
                email.ReadOnly = false;
                phone.ReadOnly = false;
                datePicker1.Enabled = true;
                browseBtn.Enabled = true;
                browseBtn.Cursor = Cursors.Hand;


            }
            else if (updateBtn.Text == "Update")
            {
                updateBtn.Text = "Edit Profile";
                name.ReadOnly = true;
                email.ReadOnly = true;
                phone.ReadOnly = true;
                datePicker1.Enabled = false;
                browseBtn.Enabled = false;
                //name.BackColor = Color.Gray;
                //email.BackColor = Color.Gray;
                //phone.BackColor = Color.Gray;
                //datePicker1.BackColor = Color.Gray;

                if (role == "manager")
                {
                    try
                    {
                        dbcon();
                        SqlCommand sq2 = new SqlCommand("UPDATE Managers SET Username = @Name, Email = @Email, PhoneNumber = @PhoneNumber, DateOfBirth = @DateOfBirth, Photo = @Image WHERE Username = @uname AND Password = @pass", con);
                        sq2.Parameters.AddWithValue("@Name", name.Text);
                        sq2.Parameters.AddWithValue("@Email", email.Text);
                        sq2.Parameters.AddWithValue("@PhoneNumber", phone.Text);
                        sq2.Parameters.AddWithValue("@DateOfBirth", datePicker1.Value);
                        sq2.Parameters.AddWithValue("@uname", username);
                        sq2.Parameters.AddWithValue("@pass", password);

                        MemoryStream memstr = new MemoryStream();

                        image.Image.Save(memstr, image.Image.RawFormat);
                        sq2.Parameters.AddWithValue("@Image", memstr.ToArray());

                        sq2.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Updated Successfully");
                        name.BackColor = Color.Silver;
                        email.BackColor = Color.Silver;
                        phone.BackColor = Color.Silver;
                        datePicker1.BackColor = Color.Silver;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Inavlid input" + ex);
                    }
                }


            }
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    image.Image = System.Drawing.Image.FromFile(ofd.FileName);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (role=="manager")
            {
                Manager_Homepage manager_Homepage = new Manager_Homepage(username, password, role);
                manager_Homepage.Show();
                this.Hide();
            }
        }
    }
}
