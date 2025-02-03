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
    public partial class Manager_Homepage : Form
    {
        string username;
        string password;
        string role;
        public Manager_Homepage(string username, string pass, string role)
        {
            InitializeComponent();
            this.username = username;
            this.password = pass;
            this.role = role;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manager_Activity manager_Activity = new Manager_Activity(username, password, role);
            manager_Activity.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager_all_product manager_All_Product = new Manager_all_product(username, password, role);
            manager_All_Product.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProfilePage profilePage = new ProfilePage(username, password, role);
            profilePage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            All_Role role = new All_Role();
            role.Show();
            this.Hide();
        }
    }
}
