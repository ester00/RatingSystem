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
using RatingSystem.GlobalConstants;

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
            con.ConnectionString = @"Data Source=DESKTOP-TFVT6L2;Initial Catalog=MovieRatings;Integrated Security=True";
        }

        #region LogIn
        private void LogInButton_Click(object sender, EventArgs e)
        {
            using (var db = new MovieRatingsEntities1())
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "Select * from LOGIN";
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    if (txtUsername.Text.Equals(dr["username"]) && txtPassword.Text.Equals(dr["password"].ToString()))
                    {
                        loginLabel.Text = "Login Succesfull.";
                        loginLabel.ForeColor = System.Drawing.Color.LightGreen;

                        this.Visible= false;
                        Form1 f1 = new Form1();
                        LoginConstants.UserName = this.txtUsername.Text;
                        f1.ShowDialog();
                    }
                    else
                    {
                        loginLabel.Text = "Either your username or password is incorrect.";
                        loginLabel.ForeColor = System.Drawing.Color.Red;
                    }
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
        #endregion

        #region Register
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            using (var db = new MovieRatingsEntities1())
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "Select * from LOGIN";
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    if (!txtUsername.Text.Equals(dr["username"]))
                    {
                        if (txtUsername.Text != "Username" && txtPassword.Text != "Password" && txtUsername.Text != "" && txtPassword.Text != "")
                        {
                            db.LOGINs.Add(new LOGIN());

                            Application.Run(new Form1());
                            Form1 f1 = new Form1();
                            f1.ShowDialog();
                        }
                        else
                        {
                            loginLabel.Text = "Invalid username or password.";
                            loginLabel.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    else
                    {
                        loginLabel.Text = "This username already exists.";
                        loginLabel.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }
        #endregion

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
