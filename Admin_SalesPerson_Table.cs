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
    public partial class Admin_SalesPerson_Table : Form
    {
        public Admin_SalesPerson_Table()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin_Homepage admin_Homepage = new Admin_Homepage();   
            admin_Homepage.Show();
            this.Hide();
        }
    }
}
