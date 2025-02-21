using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2021.PowerPoint.Comment;
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

        private const string ConnectionSrting = "Server = localhost;Database=blog;Uid=root;password=;Sslmode=None";


        private bool listcomments()
        {



            try
            {
                using (var connection = new MySqlConnection(ConnectionSrting))
                {
                    connection.Open();

                    string sql = $"SELECT blogtable.post, usertable.UserName FROM usertable RIGHT JOIN blogtable ON usertable.id = blogtable.UserId;";

                    MySqlCommand cmd = new MySqlCommand(sql, connection);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        var comment = new
                        {
                            comment = dr.GetString(0),
                            user = dr.GetString(1),
                            id = UserId.Id
                        };
                        listBox1.Items.Add(comment);
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


    }
}

