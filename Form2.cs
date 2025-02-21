using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Office2010.CustomUI;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace blog_feladat
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private const string ConnectionSrting = "Server = localhost;Database=blog;Uid=root;password=;Sslmode=None";
        private bool Addnewblogger(string username, string email, string password)
        {
            try
            {
                string sql = "INSERT INTO `usertable`(`UserName`, `Email`, `Password`) VALUES(@username, @email, @passworld)";

                
                using (var connection = new MySqlConnection(ConnectionSrting)) 
                {
                    connection.Open();

                    using (var command = new MySqlCommand(sql,connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@passworld", password);

                        command.ExecuteNonQuery();


                    }

                    

                    connection.Close();
                    this.Close();
                    return true;
                }



            }
            catch (Exception)
            {
                return false;
            }

       

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ( Addnewblogger(textBox1.Text, textBox2.Text, textBox3.Text) == true)

                {
                    MessageBox.Show("sikeres registrálció");
                }
                else
                {
                    MessageBox.Show("sikertelen registrálció");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        }
    }

