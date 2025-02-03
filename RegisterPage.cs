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
    public partial class RegisterPage : Form
    {
        SqlConnection con;
        public void dbcon()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\new_project\database\Game_Mart.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
            con.Open();
        }

        public RegisterPage()
        {
            InitializeComponent();
        }
        string role = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                try
                {
                    role = "Manager";
                    dbcon();
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


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed" + ex);
                }
            }
            if (radioButton2.Checked)
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


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed" + ex);
                }
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
    }
}
