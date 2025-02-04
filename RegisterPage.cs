using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin
{
    public partial class RegisterPage : Form
    {
        SqlConnection con;
        public void dbcon()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""G:\8. EIGHTH SEMESTER\C#\Project\MAIN PROJECT\database\Game_Mart.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False
"); con.Open();
        }

        public RegisterPage()
        {
            InitializeComponent();
        }
        string role = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox2.Text) || !string.IsNullOrWhiteSpace(textBox3.Text)
                || !string.IsNullOrWhiteSpace(textBox4.Text) || pictureBox1.Image != null)
            {
                if (radioButton1.Checked)
                {
                    try
                    {
                        role = "Manager";
                        dbcon();
                        SqlCommand checkUser = new SqlCommand("SELECT COUNT(*) FROM Managers WHERE Username = @Username", con);
                        checkUser.Parameters.AddWithValue("@Username", textBox1.Text);
                        int count = (int)checkUser.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists! Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        string password = textBox2.Text;
                        if (password.Length < 6 || !Regex.IsMatch(password, @"[!@#$%^&*(),.?\:{ }|<>]"))
                        {
                            MessageBox.Show("Password must be at least 6 characters long and contain at least one special character.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        SqlCommand sq2 = new SqlCommand("insert into Managers(Username,Password,PhoneNumber,Email,DateOfBirth,Photo) values(@Username,@password,@PhoneNumber,@Email,@Date,@Image)", con);

                        sq2.Parameters.AddWithValue("@Username", textBox1.Text);
                        sq2.Parameters.AddWithValue("@password", textBox2.Text);
                        sq2.Parameters.AddWithValue("@PhoneNumber", textBox4.Text);
                        sq2.Parameters.AddWithValue("@Email", textBox3.Text);
                        sq2.Parameters.AddWithValue("@Date", datePicker1.Value);
                        MemoryStream memstr = new MemoryStream();
                        pictureBox1.Image.Save(memstr, pictureBox1.Image.RawFormat);
                        sq2.Parameters.AddWithValue("@Image", memstr.ToArray());
                        sq2.ExecuteNonQuery();

                        SqlCommand sq3 = new SqlCommand("insert into Login_Info(Username,Password,Role) values(@Username,@password,@role)", con);

                        sq3.Parameters.AddWithValue("@Username", textBox1.Text);
                        sq3.Parameters.AddWithValue("@password", textBox2.Text);
                        sq3.Parameters.AddWithValue("@role", role);

                        sq3.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data added");
                        All_Role all_Role = new All_Role();
                        all_Role.Show();
                        this.Hide();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed" + ex);
                    }
                }
                else if (radioButton2.Checked)
                {
                    try
                    {
                        role = "Salesperson";
                        dbcon();
                        SqlCommand sq2 = new SqlCommand("insert into Salespersons(Username,Password,PhoneNumber,Email,DateOfBirth,Photo) values(@Username,@password,@PhoneNumber,@Email,@Date,@Image)", con);

                        sq2.Parameters.AddWithValue("@Username", textBox1.Text);
                        sq2.Parameters.AddWithValue("@password", textBox2.Text);
                        sq2.Parameters.AddWithValue("@PhoneNumber", textBox4.Text);
                        sq2.Parameters.AddWithValue("@Email", textBox3.Text);
                        sq2.Parameters.AddWithValue("@Date", datePicker1.Value);
                        MemoryStream memstr = new MemoryStream();
                        pictureBox1.Image.Save(memstr, pictureBox1.Image.RawFormat);
                        sq2.Parameters.AddWithValue("@Image", memstr.ToArray());
                        sq2.ExecuteNonQuery();

                        SqlCommand sq3 = new SqlCommand("insert into Login_Info(Username,Password,Role) values(@Username,@password,@role)", con);

                        sq3.Parameters.AddWithValue("@Username", textBox1.Text);
                        sq3.Parameters.AddWithValue("@password", textBox2.Text);
                        sq3.Parameters.AddWithValue("@role", role);

                        sq3.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data added");
                        All_Role all_Role = new All_Role();
                        all_Role.Show();
                        this.Hide();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed" + ex);
                    }
                }
                else { 
                MessageBox.Show("Please select e Role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please provide all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void datePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
