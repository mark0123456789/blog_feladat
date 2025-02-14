using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace blog_feladat
{
    public partial class Form1 : Form
    {
        private string connectionString;

        public Form1()
        {
            InitializeComponent();
        }

        

        private bool Beleptet(string username, string password)
        {

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = $"SELECT `Id` FROM `usertable` WHERE UserName = @username AND Password = @password";

                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    bool van = dr.Read();


                    connection.Close();


                    return van;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Beleptet(textBox1.Text, textBox2.Text))

            {
                MessageBox.Show("Regisztrált tag");
            }
            else
            { 
            Form2 form2 = new Form2();
            form2.ShowDialog();
            }
        }
    }
}
