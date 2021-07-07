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
            con.ConnectionString = @"Data Source=DESKTOP-TFVT6L2;Initial Catalog=MovieRatings;Integrated Security=True;MultipleActiveResultSets=True";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsValidPassword(textNewPass.Text))
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT * FROM LOGIN";
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    if (textOldPass.Text.Equals(dr["password"].ToString()))
                    {
                        using (var db = new MovieRatingsEntities2())
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
            else
            {
                loginLabel.Text = "Invalid password!";
                loginLabel.ForeColor = System.Drawing.Color.Red;
                label6.ForeColor = System.Drawing.Color.Red;
            }
        }
        private bool IsValidPassword(string password)
        {
            return (password.Length >= 6 &&
                    password.Any(char.IsUpper)
                    );
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            username.Text = constant.UserName;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            textOldPass.PasswordChar = default(char);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textNewPass
                .PasswordChar = default(char);
        }

    }
}
