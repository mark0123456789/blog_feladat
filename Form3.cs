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

namespace blog_feladat
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private bool listcomments()
        {
            private bool Beleptet(string username, string password)
            {

                try
                {
                    using (var connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string sql = $"SELECT blogtable.post, usertable.UserName FROM usertable LEFT JOIN blogtable\r\nON usertable.id = blogtable.UserId;";

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
    }
}
