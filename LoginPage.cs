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
    public partial class LoginPage : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public string Title { get; set; }
        public int Rating { get; set; }

        public LoginPage()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-TFVT6L2;Initial Catalog=MovieRatings;Integrated Security=True;MultipleActiveResultSets=True";
        }

        #region LogIn
        private void LogInButton_Click(object sender, EventArgs e)
        {
           using (var db = new MovieRatingsEntities1())
            {
                int i = 0;
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT * FROM LOGIN";
                SqlDataReader dr = com.ExecuteReader();
                while(dr.Read())
                {
                    if (txtUsername.Text.Equals(dr["username"]) && txtPassword.Text.Equals(dr["password"].ToString()))
                    {
                        loginLabel.Text = "Login Succesfull.";
                        loginLabel.ForeColor = System.Drawing.Color.LightGreen;

                        this.Visible = false;
                        Form1 f1 = new Form1();
                        f1.ShowDialog();
                    }
                    else
                    {
                        loginLabel.Text = "Either your username or password is incorrect.";
                        loginLabel.ForeColor = System.Drawing.Color.Red;
                    }
                    i++;
                }
                con.Close();
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = @"Username";
            }
        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(@"Username"))
            {
                txtUsername.Text = "";
            }
        }
        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Password";
            }
        }
        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '●';
        } 
        private void label2_Click_1(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = default(char);
        }
        #endregion

        #region Register
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            using (var db = new MovieRatingsEntities1())
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT * FROM LOGIN";
                SqlDataReader dr = com.ExecuteReader();
                if(dr.Read())
                {
                    if (txtUsername.Text.Equals(dr["username"]))
                    {
                        loginLabel.Text = "This username already exists.";
                        loginLabel.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        if (txtUsername.Text != "Username" && txtUsername.Text != "" && txtPassword.Text != "")
                        {
                            com = new SqlCommand("INSERT INTO LOGIN (username, password) VALUES (@username, @password)", con);
                            com.Parameters.Add(new SqlParameter("@username", txtUsername.Text));
                            com.Parameters.Add(new SqlParameter("@password", txtPassword.Text));
                            com.ExecuteNonQuery();
                            db.SaveChanges();


                            this.Visible = false;
                            Form1 f1 = new Form1();
                            f1.ShowDialog();
                        }
                        else
                        {
                            loginLabel.Text = "Invalid username or password.";
                            loginLabel.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }
                con.Close();
            }
        }
        #endregion

        #region Delete Account
       private void DAButton_Click(object sender, EventArgs e)
        {
            using (var db = new MovieRatingsEntities1())
            {
                int i = 0;
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT * FROM LOGIN";
                SqlDataReader dr = com.ExecuteReader();
                while(dr.Read())
                {
                    if (txtUsername.Text.Equals(dr["username"]) && txtPassword.Text.Equals(dr["password"].ToString()))
                    {
                        com = new SqlCommand("DELETE FROM LOGIN WHERE username = @username", con);
                        com.Parameters.AddWithValue("@username", txtUsername.Text);
                        com.ExecuteNonQuery();

                        txtUsername.Text = "Username";
                        txtPassword.Text = "Password";
                        loginLabel.Text = "Account deleted succesfully.";
                        loginLabel.ForeColor = System.Drawing.Color.LightGreen;
                    }
                    else
                    {
                        loginLabel.Text = "Couldn't find account.";
                        loginLabel.ForeColor = System.Drawing.Color.Red;
                    }
                    i++;
                }
                con.Close();
            }
        }
        #endregion
    }
}

