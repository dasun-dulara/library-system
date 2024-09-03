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
    public partial class borrowb : Form
    {
        public borrowb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user library = new user();
            library.Show();
            this.Hide();
        }
    }
}
