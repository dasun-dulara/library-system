using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SDAM
{
    public partial class addremobeb : Form
    {
        public addremobeb()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Librarian library = new Librarian();
            library.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adddata = "Server=localhost;Database=dasun;User Id=root;Password=;";

            using (MySqlConnection connection = new MySqlConnection(adddata))
            {
                connection.Open();

                string query = "INSERT INTO newmanagemem2 (Book, ISBN, Author, Year) VALUES (@Value1, @Value2, @Value3, @Value4)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value1", textBox1.Text);
                    command.Parameters.AddWithValue("@Value2", textBox2.Text);
                    command.Parameters.AddWithValue("@Value3", textBox3.Text);
                    command.Parameters.AddWithValue("@value4", textBox4.Text);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("The Book has been added successfully ");
                LoadData();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData()
        {
            try
            {
                string connectionString = "Server=localhost;Database=dasun;User Id=root;Password=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Book, ISBN, Author, Year  FROM newmanagemem2";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);


                         dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                string selectedID = Convert.ToString(dataGridView1.SelectedRows[0].Cells["Book"].Value);


                string deleteQuery = "DELETE FROM newmanagemem2 WHERE Book = @Book";

                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=dasun;User Id=root;Password=;"))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Book", selectedID);
                        command.ExecuteNonQuery();
                    }
                }


                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                MessageBox.Show("Member Removed");
            }
            else
            { 
                MessageBox.Show("Please select a row to remove");
            }
        }
    }
}
