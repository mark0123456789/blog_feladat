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

                    if (van) {
                        UserId.Id = dr.GetInt32(0);
                    }

                    connection.Close();


                    return true;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Beleptet(textBox1.Text, textBox2.Text) == true)

                {
                    MessageBox.Show("Regisztrált tag");
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                }
                else
                {
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            }
        }
    public static class UserId {

        public static int Id  { get; set; }
    }
    }


