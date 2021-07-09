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
using System.Security.Cryptography;

namespace RatingSystem
{

    public partial class LoginPage : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        private readonly MovieRatingsEntities3 _db;
        public int userid;

        public LoginPage()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-TFVT6L2;Initial Catalog=MovieRatings;Integrated Security=True;MultipleActiveResultSets=True";
            _db = new MovieRatingsEntities3();
        }

        #region LogIn
        private void LogInButton_Click(object sender, EventArgs e)
        {
            SHA256 sha = SHA256.Create();

            var username = txtUsername.Text;
            var password = txtPassword.Text;

            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            var hashed_password = sBuilder.ToString();

            var user = _db.Users.FirstOrDefault(q => q.Username == username && q.Password == hashed_password);
            if (user == null)
            {
                loginLabel.Text = "Either your username or password is incorrect.";
                loginLabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                var role = user.UserRoles.FirstOrDefault();
                var roleName = role.Role.Name;

                this.Visible = false;
                constant.UserName = user.Username;
                constant.LoggedUserId = user.Id;
                Form1 f1 = new Form1(this, roleName);
                f1.ShowDialog();
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

        private bool IsValidPassword(string password)
        {
            return (password.Length >= 6 &&
                    password.Any(char.IsUpper)
                    );
        }

        #region Register
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            SHA256 sha = SHA256.Create();

            var username = txtUsername.Text;
            var password = txtPassword.Text;

            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            var hashed_password = sBuilder.ToString();

            if (IsValidPassword(txtPassword.Text))
            {
                using (var _db = new MovieRatingsEntities3())
                {
                    con.Open();
                    com = new SqlCommand("SELECT Id from Users WHERE Username = @username", con);
                    com.Parameters.AddWithValue("@username", username);
                    com.ExecuteNonQuery();
                    SqlDataReader dr = com.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            userid = Convert.ToInt32(dr["userid"]);
                        }
                    }
                    con.Close();
                }
                using (var db = new MovieRatingsEntities3())
                {
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "SELECT * FROM Users";
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        if (username.Equals(dr["Username"]))
                        {
                            loginLabel.Text = "This username already exists.";
                            loginLabel.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            if (username != "Username" && username != "" && password != "")
                            {
                                com = new SqlCommand("INSERT INTO Users (Username, Password) VALUES (@username, @password)", con);
                                com.Parameters.Add(new SqlParameter("@username", username));
                                com.Parameters.Add(new SqlParameter("@password", hashed_password));
                                com.ExecuteNonQuery();
                                db.SaveChanges();

                                com = new SqlCommand("INSERT INTO UserRoles (UserId, RoleId) VALUES (@userid, @roleid)", con);
                                com.Parameters.Add(new SqlParameter("@userid", userid));
                                com.Parameters.Add(new SqlParameter("@roleid", 2));
                                com.ExecuteNonQuery();
                                db.SaveChanges();

                                var userId = _db.Users.FirstOrDefault(q => q.Username == username).Id;
                                _db.UserRoles.Add(new UserRole() { RoleId = 2, UserId = userId });
                                _db.SaveChanges();


                                constant.UserName = this.txtUsername.Text;
                                this.Visible = false;
                                Form1 f1 = new Form1(this, "User");
                                f1.ShowDialog();
                            }
                            else
                            {
                                loginLabel.Text = "Invalid username or password.";
                                loginLabel.ForeColor = System.Drawing.Color.Red;
                            }
                        
                        }
                        con.Close();
                    }
                }
            }
            else
            {
                loginLabel.Text = "Invalid password!";
                loginLabel.ForeColor = System.Drawing.Color.Red;
                label3.ForeColor = System.Drawing.Color.Red;
            }
        }
        #endregion

        private void GuestButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}

