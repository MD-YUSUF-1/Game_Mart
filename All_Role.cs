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
    public partial class All_Role : Form
    {
        public All_Role()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string role = "admin";
            Login l = new Login(role);
            l.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string role = "manager";
            Login l = new Login(role);
            l.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string role = "salesman";
            Login l = new Login(role);
            l.Show();
            this.Hide();
        }
    }
}
