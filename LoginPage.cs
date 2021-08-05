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
using System.Data.Entity.Migrations;

namespace RatingSystem
{

    public partial class LoginPage : Form
    {
        private readonly MovieRatingsEntities3 _db;
        public int userid;

        User currentUser;

        public LoginPage()
        {
            InitializeComponent();
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
                constant.RoleName = role.Role.Name;

                this.Visible = false;
                constant.UserName = user.Username;
                constant.LoggedUserId = user.Id;
                Form1 f1 = new Form1(this, "User");
                f1.ShowDialog();
            }
        }
        #endregion

        #region Username/Password
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

        private void label5_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = default(char);
        }

        private bool IsValidPassword(string password)
        {
            return (password.Length >= 6 &&
                    password.Any(char.IsUpper)
                    );
        }
        #endregion 

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
                using (var db = new MovieRatingsEntities3())
                {
                    if (db.Users.FirstOrDefault(u => u.Username == txtUsername.Text) != null)
                    {
                        loginLabel.Text = "This username already exists.";
                        loginLabel.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        if (username != "Username" && username != "" && password != "")
                        {
                            currentUser = new User();
                            currentUser.Username = username;
                            currentUser.Password = hashed_password;

                            db.Users.AddOrUpdate(currentUser);
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

