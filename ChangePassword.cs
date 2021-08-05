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
using System.Data.Entity.Migrations;
using System.Security.Cryptography;

namespace RatingSystem
{
    public partial class ChangePassword : Form
    {
        LoginPage loginPage;

        public ChangePassword(LoginPage user)
        {
            InitializeComponent();
            loginPage = user;
        }

        private void ChangePass()
        {
            using (var db = new MovieRatingsEntities3())
            {
                string username = this.loginPage.txtUsername.Text;
                var currentUser = db.Users.FirstOrDefault(u => u.Username == username);

                var hashedOldPassword = GenerateHashedPassword(this.textOldPass.Text);

                if (db.Users.FirstOrDefault(p => p.Password == hashedOldPassword) != null)
                {
                    var newPassword = textNewPass.Text;
                    string hashed_password = GenerateHashedPassword(newPassword);
                    currentUser.Password = hashed_password;

                    db.Users.AddOrUpdate(currentUser);
                    db.SaveChanges();
                }
                else
                {
                    loginLabel.Text = "The password you have entered is incorrect.";
                    loginLabel.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private static string GenerateHashedPassword(string newPassword)
        {
            SHA256 sha = SHA256.Create();

            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(newPassword));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            var hashed_password = sBuilder.ToString();
            return hashed_password;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsValidPassword(textNewPass.Text))
            {
                ChangePass();
                MessageBox.Show("Password changed succesfully.", "Password change", MessageBoxButtons.OK);
                this.Close();
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
            textNewPass.PasswordChar = default(char);
        }
    }
}
