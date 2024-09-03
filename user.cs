using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAM
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Returnb library = new Returnb();
            library.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login library = new Login();
            library.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            borrowb library = new borrowb();
            library.Show();
            this.Hide();
        }
    }
}
