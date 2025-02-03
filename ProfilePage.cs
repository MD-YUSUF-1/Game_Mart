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
        public ProfilePage()
        {
            InitializeComponent();
        }
        SqlConnection con;
        //Databse connection code 
        public void dbcon()
        {
            try
            {

                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\C# Project\database\database\Game_Mart.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=True;Encrypt=False
");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to the database: {ex.Message}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ProfilePage_Load(object sender, EventArgs e)
        {

        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (updateBtn.Text == "Edit")
            {
              
                    updateBtn.Text = "Update";
                    name.ReadOnly = false;
                    email.ReadOnly = false;
                    phone.ReadOnly = false;
                    dob.ReadOnly = false;
                    browseBtn.Enabled = true;
                    browseBtn.Cursor = Cursors.Hand;
                    name.BackColor = Color.Silver;
                    email.BackColor = Color.Silver;
                    phone.BackColor = Color.Silver;
                    dob.BackColor = Color.Silver;
                
            }
            else if (updateBtn.Text == "Update")
            {
                updateBtn.Text = "Edit";
                name.ReadOnly = true;
                email.ReadOnly = true;
                phone.ReadOnly = true;
                dob.ReadOnly = true;
                browseBtn.Enabled = false;
                name.BackColor = Color.Gray;
                email.BackColor = Color.Gray;
                phone.BackColor = Color.Gray;
                dob.BackColor = Color.Gray;

                try
                {
                    dbcon();
                    SqlCommand sq2 = new SqlCommand("UPDATE PRODUCT_TABLE SET GName = @Name, GStock = @Stock, GDiscount = @Discount, GPrice = @Price, GGenre = @Genre, GImage = @Image WHERE GameID = @gameID", con);
                    sq2.Parameters.AddWithValue("gameID", name.Text);
                    sq2.Parameters.AddWithValue("@Name", email.Text);
                    sq2.Parameters.AddWithValue("@Genre", phone.Text);
                    sq2.Parameters.AddWithValue("@Stock", dob.Text);
                    MemoryStream memstr = new MemoryStream();
                    image.Image.Save(memstr, image.Image.RawFormat);
                    sq2.Parameters.AddWithValue("@Image", memstr.ToArray());
                    sq2.ExecuteNonQuery();
                    con.Close();

                    name.Text = "";
                    email.Text = "";
                    phone.Text = "";
                    dob.Text = "";
                    MessageBox.Show("Updated Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Inavlid input");
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
    }
}
