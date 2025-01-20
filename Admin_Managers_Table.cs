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
    public partial class Admin_Managers_Table : Form
    {
        public Admin_Managers_Table()
        {
            InitializeComponent();
        }

        private void Admin_Managers_Table_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin_Homepage adminHomepage = new Admin_Homepage();
            adminHomepage.Show();
            this.Hide();

        }
    }
}
