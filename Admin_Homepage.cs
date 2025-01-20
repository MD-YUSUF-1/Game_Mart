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
    public partial class Admin_Homepage : Form
    {
        public Admin_Homepage()
        {
            InitializeComponent();
        }

        private void Admin_Homepage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            All_Products_Admin all_Products_Admin = new All_Products_Admin();
            all_Products_Admin.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            All_Role all_Role = new All_Role();
            all_Role.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Managers_Table admin_Managers_Table = new Admin_Managers_Table();
            admin_Managers_Table.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_SalesPerson_Table admin_SalesPerson_Table = new Admin_SalesPerson_Table();
            admin_SalesPerson_Table.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
