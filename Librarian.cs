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
    public partial class Librarian : Form
    {
        public Librarian()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            manegemem library = new manegemem();
            library.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login library = new Login();
            library.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchbooks search = new searchbooks();
            search.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addremobeb library = new addremobeb();
            library.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkavailab library = new checkavailab();
            library.Show();
            this.Hide();
        }
    }
}
