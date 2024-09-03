using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void psw_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string loging = "Server=localhost;Database=dasun;User Id=root;Password=;";
            string name = textBox1.Text;
            string password = psw.Text;
            using (MySqlConnection connection = new MySqlConnection(loging))
            {
                try
                {
                    connection.Open();

                    // Query to check if username and password match in the database
                    string query = "SELECT COUNT(*) FROM login WHERE Username = @username AND Password = @password";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", name);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        if (name == "admin")
                        {
                            MessageBox.Show("Login successful!");

                            Librarian library = new Librarian();
                            library.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Login successful!");

                            user libraryn = new user();
                            libraryn.Show();
                            this.Hide();


                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
