using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RatingSystem
{
    public partial class ChangePassword : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();

        public ChangePassword()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-TFVT6L2;Initial Catalog=MovieRatings;Integrated Security=True";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
             con.Open();
             com.Connection = con;
             com.CommandText = "SELECT * FROM LOGIN";
             SqlDataReader dr = com.ExecuteReader();
             while (dr.Read())
             {
                 if (textOldPass.Text.Equals(dr["password"].ToString()))
                 {
                    using (var db = new MovieRatingsEntities1())
                    {
                        com = new SqlCommand($"UPDATE LOGIN SET Password = @NewPassword WHERE Password = @Password", con);
                        com.Parameters.AddWithValue("@Password", textOldPass.Text);
                        com.Parameters.Add(new SqlParameter("@NewPassword", textNewPass.Text));
                        com.ExecuteNonQuery();
                        db.SaveChanges();
                        this.Close();
                    }
                 }
                 else
                 {
                     loginLabel.Text = "Either your username or password is incorrect.";
                     loginLabel.ForeColor = System.Drawing.Color.Red;
                 }
             }
             con.Close();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            username.Text = constant.UserName;
        }
    }
}
